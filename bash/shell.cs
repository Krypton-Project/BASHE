/**
Copyright (c) 2011, Edward Chernysh
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the Krypton-Project <http://krypton-project.webs.com> nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL <EDWARD CHERNYSH> BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

**/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace bash
{
    public partial class shell : UserControl
    {
        bool loop = false;
        public string ID = "WinUser@" + Application.ExecutablePath + " -$";
        public string proc;

        public bool status;
        public shell()
        {
            InitializeComponent();
        }

        private void shell_Load(object sender, EventArgs e)
        {
            send.SendToBack();
            this.Select();
            this.terminal.Text += ID;
            this.command.Select();
        }

        private void send_Click(object sender, EventArgs e)
        {
            this.terminal.Text += "\n";
            this.run(command.Text);
            this.command.Text = null;
        }

        public void run(string cmd)
        {
            if (cmd == "help")   {
                usage();
            }
            else if (cmd == "bash")
            {
                (new bashGUI()).Show();
            }
            else if (cmd == "shell")
                (new bashGUI()).Show(this);
            else if (cmd.IndexOf("printf") == 0)
            {
                this.terminal.Text += cmd.Substring(7).ToString();
            }
            else if (cmd == "clear")
            {
                this.terminal.Text = null;               
            }
            else if (cmd == "cal")
            {
                DateTime dt = new DateTime();
                this.terminal.Text += dt.DayOfWeek;                
                this.terminal.Text += "\n" + dt.Month.ToString();
                this.terminal.Text += "\n" + dt.Year.ToString();                
            }
            else if (cmd.IndexOf("cat") == 0)
            {
                string[] words = cmd.Split(' ');
                if (words[1] == "<")
                {
                    try
                    {
                        StreamReader sr = new StreamReader(words[2]);
                        this.terminal.Text += sr.ReadToEnd();
                        sr.Dispose();
                    }

                    catch
                    {
                        this.terminal.Text += "File does not exist";
                    }
                }
                else if (words[1] == ">")
                {
                    try
                    {
                        StreamWriter sw = new StreamWriter(words[2]);
                        sw.WriteLine(words[3]);
                        sw.Dispose();
                    }

                    catch
                    {
                        this.terminal.Text += "File does not exist";
                    }
                }
                else
                {
                    this.terminal.Text += "Syntax error";
                }
            }

            else if (cmd.IndexOf("mkdir") == 0)
            {
                string[] words = cmd.Split(' ');
                try
                {
                    string mkdir_cmd = "mkdir " + words[1];
                    ExecCmd.ExecuteCommand(mkdir_cmd);
                }
                catch
                {
                    this.terminal.Text += "Segmentation fault";
                }

            }
            else if (cmd.IndexOf("rmdir") == 0)
            {
                string[] words = cmd.Split(' ');
                try
                {
                    string rm_dir = "rmdir " + words[1];
                    ExecCmd.ExecuteCommand(rm_dir);
                }

                catch
                {
                    this.terminal.Text += "Segmentation fault";
                }
            }
            else if (cmd.IndexOf("xwindow") == 0)
            {
                alert.message(cmd.Substring(8).ToString(), "Warning", "Alert");
                terminal.Text += "xwindow returned 0";
            }
            else if (cmd.IndexOf("cd") == 0)
            {
                string[] words = cmd.Split(' ');

                try
                {
                    string cd_dir = "cd " + words[1];
                    ExecCmd.ExecuteCommand(cd_dir);
                }
                catch
                {
                    terminal.Text += "Segmentation fault";
                }
            }
            else if (cmd.IndexOf("command") == 0)
            {
                try
                {
                    string[] comm = cmd.Split(' ');
                    ExecCmd.ExecuteCommand(comm[1]);
                }
                catch
                {
                    this.terminal.Text += "no command";
                }
            }
            else if (cmd == "continue")
            {
                ;
            }

            else if (cmd.IndexOf("cp") == 0)
            {
                string[] argv = cmd.Split(' ');
                string name = argv[1];
                string todir = argv[2];               

                StreamReader sr = new StreamReader(name);
                string filetext = sr.ReadToEnd();
                sr.Dispose();

                using (StreamWriter writer = new StreamWriter(todir))
                {
                    writer.Write(filetext);
                }
            }

            else if (cmd.IndexOf("crontab") == 0)
            {
                try
                {
                    string[] args = cmd.Split(' ');
                    string sproc = args[1];
                    string interval = args[2];

                    Timer cmd_timer = new Timer();
                    int interv;

                    int.TryParse(interval, out interv);

                    cmd_timer.Interval = interv;
                    cmd_timer.Tick += new EventHandler(cmd_timer_Tick);
                    this.command.Text = sproc;
                    cmd_timer.Start();
                    cmd_timer.Stop();
                    this.command.Text = null;
                }

                catch
                {
                    this.terminal.Text += "wrong data";
                }
            }

            else if (cmd.IndexOf("bg") == 0)
            {
                this.Dispose();
                bashGUI.recreate();
            }
            else if (cmd.IndexOf("break") == 0)
            {
                if (!loop)
                    ;
                else
                {
                    ExecCmd.ExecuteCommand("break");
                }
            }

            else if (cmd.IndexOf("echo") == 0)
            {
                string[] words = cmd.Split(' ');

                try
                {
                    int i = 1;
                    int sz = words.Length;
                    while (i < sz)
                    {
                        this.terminal.Text += words[i];
                        this.terminal.Text += " ";
                        i++;
                    }
                }
                catch
                {
                    this.terminal.Text += "no string";
                }
            }
            else if (cmd.IndexOf("bzip2") == 0)
            {
                string[] words = cmd.Split(' ');

                ExecCmd.ExecuteCommand("compact " + words[1]);
            }

            else if (cmd == "date")
            {
                this.terminal.Text += DateTime.Now.ToShortDateString();               
            }

            else if (cmd == "dc")
            {
                ExecCmd.ExecuteCommand("calc");
            }

            else if (cmd == "ddrescue")
            {
                ExecCmd.ExecuteCommandShowWindow("recover");
            }

            else if (cmd.IndexOf("diff") == 0)
            {
                string[] argv = cmd.Split(' ');

                try
                {
                    /* Declare the StreamReader */

                    using (StreamReader reader = new StreamReader(argv[1]))
                    {
                        string file1 = reader.ReadToEnd();                        
                        using (StreamReader _reader = new StreamReader(argv[2]))
                        {
                            string file2 = _reader.ReadToEnd();
                            this.terminal.Text += String.Compare(file1, 
                                file2).ToString();
                            _reader.Dispose();
                            
                        }
                        reader.Dispose();
                        
                    }

                   
                }
                catch
                {
                    this.terminal.Text += "syntax error";
                }
            }
            else if (cmd == "dir")
            {
                this.terminal.Text += ExecCmd.ExecuteCommand("dir");
            }

            else if (cmd.IndexOf("ethtool") == 0)
            {
                string[] argv = cmd.Split(' ');
                try
                {
                    this.terminal.Text +=
                        ExecCmd.ExecuteCommand("ping " + argv[1]);
                }

                catch
                {
                    this.terminal.Text += "syntax error\n";
                }
            }
            else if (cmd.IndexOf("exec") == 0)
            {
                string[] argv = cmd.Split(' ');
                try
                {
                    this.terminal.Text +=
                        ExecCmd.ExecuteCommand(argv[1]);
                }
                catch { this.terminal.Text += "syntax error"; }
            }
            else if (cmd == "exit")
            {
                try { Application.Exit(); }
                catch { alert.message("A process appears to be running!", "Warning", "BASHE"); };
            }
            else if (cmd == "false")
            {
                this.status = false;
            }
            else if (cmd == "fg")
            {
                this.BringToFront();
            }
          
            if (cmd != "clear")
                this.terminal.Text += "\n";
            this.terminal.Text += ID;
            this.terminal.SelectionStart = terminal.Text.Length;
            this.terminal.ScrollToCaret();
        }

        void usage()
        {
            /* B */
            this.terminal.Text += "bash\t\tBourne Again SHell\n";
            this.terminal.Text += "bg\t\tSend to background\n";
            this.terminal.Text += "break\t\tExit a loop\n";
            this.terminal.Text += "bzip2\t\tCompress file\n";
            /* C */
            this.terminal.Text += "cal\t\tPrint Calendar Info\n";
            this.terminal.Text += "cd <dir>\tChange Directory\n";
            this.terminal.Text += "cat\t\tConcatenate and print the content of files\n";
            this.terminal.Text += "clear\t\tClear Terminal Screen\n";
            this.terminal.Text += "command\t\tRun MS-DOS command\n";
            this.terminal.Text += "continue\tNext segment of a loop\n";
            this.terminal.Text += "cp\t\tCopy file to location\n";
            this.terminal.Text += "crontab\t\tAdd a command to a timer\n";
            /* D */
            this.terminal.Text += "date\t\tPrint date\n";
            this.terminal.Text += "dc\t\tNative calculator\n";
            this.terminal.Text += "ddrescue\tWindows recovery tool\n";
            this.terminal.Text += "diff\t\tDifference between two files\n";
            this.terminal.Text += "dir\t\tPrint directory members\n";
            /* E */
            this.terminal.Text += "echo\t\tPrint text to screen\n";
            this.terminal.Text += "ethtool\t\tPing website\n";
            this.terminal.Text += "exec\t\tExecute a DOS command\n";
            /* F */
            this.terminal.Text += "false\t\tDo nothing, unsuccessfully\n";
            this.terminal.Text += "fg\t\tSend job to foreground\n";
            this.terminal.Text += "help\t\tList of Commands\n";
            this.terminal.Text += "mkdir <name>\tCreate a directory\n";
            this.terminal.Text += "printf <string> Print String\n";
            this.terminal.Text += "rmdir <name> Remove directory\n";
            this.terminal.Text += "xwindow <text>\tAlert Window\n";
            
        }
        public void cmd_timer_Tick(object sender, EventArgs e)
        {
           this.send.PerformClick();
        }
    }

}
