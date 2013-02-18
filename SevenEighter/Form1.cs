using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace SevenEighter
{
    public partial class Form1 : Form
    {
        string bin = System.Environment.CurrentDirectory;
        string currentversion = "";

        int queuedDownloads = 0;

        bool hasErrored = false;

        System.Collections.ObjectModel.Collection<string> packages = new System.Collections.ObjectModel.Collection<string>();

        public Form1()
        {
            InitializeComponent();
            if (System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86"))
            {
                //hack: it's a 64-bit os
                bin += @"\x64\UpdateWP.exe";
            }
            else {
                bin += @"\x86\UpdateWP.exe";
            }
        //    @"\x64\UpdateWP.exe";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doUpdate();            
        }

        void doUpdate()
        {
            Process pro = new Process();
            pro.StartInfo.FileName = bin;
            pro.StartInfo.Arguments = "/iu test";

            //try
            //{

            pro.StartInfo.RedirectStandardOutput = true;
            pro.StartInfo.UseShellExecute = false;
            pro.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            pro.StartInfo.CreateNoWindow = true;
            pro.Start();

            pro.WaitForExit();

            string output = pro.StandardOutput.ReadToEnd();

            if (output.Contains("Zune is currently running"))
            {
                MessageBox.Show("Zune is running. Close it and try again.");
                return;
            }
            if (output.Contains("COM"))
            {
                if (MessageBox.Show("You don't have the Windows Phone Support Tools installed. Press OK to download them.", "", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    Process bro = new Process();
                    bro.StartInfo.FileName = "http://forum.xda-developers.com/attachment.php?attachmentid=751891&d=1318801790";
                    bro.Start();
                }
                return;
            }
            if (!output.Contains("Applying update"))
            {
                MessageBox.Show("An unknown error occured:\n" + output);
                return;
            }
            System.Diagnostics.Debug.Write(output);

            
            
            
            //Get phone OS version
            currentversion = getVersionFromOutput(output);
            

            if (availablePackages.selectedLanguages.Count == 0)
            {
                languagelist frm = new languagelist();
                frm.ShowDialog();

                for (int i = 0; i < frm.checkedListBox1.Items.Count; i++)
                {
                    if (frm.checkedListBox1.CheckedItems.Contains(frm.checkedListBox1.Items[i]))
                    {
                        availablePackages.selectedLanguages.Add(i);
                    }
                }
            }

            button1.Enabled = false;

            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Enabled = true;
            progressBar1.MarqueeAnimationSpeed = 40;

            if (currentversion.Contains("7720"))
            {
                lblStatus.Text = "Downloading 7740...";

                packages.Clear();

                packages.Add(availablePackages.ver7740);

                System.Threading.Thread th = new System.Threading.Thread(() =>
                {
                    installPackages();
                });
                th.Start();
            }

            if (currentversion.Contains("7740"))
            {
                lblStatus.Text = "Downloading 8107...";
                packages.Clear();

                packages.Add(availablePackages.ver8107);
                for (int i = 0; i < availablePackages.selectedLanguages.Count; i++)
                {
                    packages.Add(availablePackages.ver8107langs[availablePackages.selectedLanguages[i]]);
                }

                System.Threading.Thread th = new System.Threading.Thread(() =>
                {
                    installPackages();
                });
                th.Start();
            }

            if (currentversion.Contains("8107"))
            {
                lblStatus.Text = "Tango time, 1 of 2...";
                packages.Clear();

                packages.Add(availablePackages.ver8112_1);
                packages.Add(availablePackages.ver8112_2);

                for (int i = 0; i < availablePackages.selectedLanguages.Count; i++)
                {
                    packages.Add(availablePackages.ver8112langs[availablePackages.selectedLanguages[i]]);
                }

                System.Threading.Thread th = new System.Threading.Thread(() =>
                {
                    installPackages();
                });
                th.Start();
            }

            if (currentversion.Contains("8112"))
            {
                lblStatus.Text = "Tango time, 2 of 2...";
                packages.Clear();

                packages.Add(availablePackages.ver8773_1);
                packages.Add(availablePackages.ver8773_2);

                for (int i = 0; i < availablePackages.selectedLanguages.Count; i++)
                {
                    packages.Add(availablePackages.ver8773langs[availablePackages.selectedLanguages[i]]);
                }

                System.Threading.Thread th = new System.Threading.Thread(() =>
                {
                    installPackages();
                });
                th.Start();
            }

            if (currentversion.Contains("8773"))
            {
                lblStatus.Text = "Downloading 8779 (pre-7.8, 1 of 3)...";
            
                packages.Clear();

                packages.Add(availablePackages.ver8779);
                for (int i = 0; i < availablePackages.selectedLanguages.Count; i++)
                {
                    packages.Add(availablePackages.ver8779langs[availablePackages.selectedLanguages[i]]);
                }

                System.Threading.Thread th = new System.Threading.Thread(() =>
                {
                    installPackages();
                });
                th.Start();
            

            }

            if (currentversion.Contains("8779"))
            {
                lblStatus.Text = "Downloading 8783 (pre-7.8, 2 of 3)...";
                
                packages.Clear();

                packages.Add(availablePackages.ver8783);
                
                System.Threading.Thread th = new System.Threading.Thread(() =>
                {
                    installPackages();
                });
                th.Start();
            }

            if (currentversion.Contains("8783"))
            {
                lblStatus.Text = "Downloading WP7.8 (3 of 3)...";
                

                packages.Clear();

                packages.Add(availablePackages.ver8858_1);
                packages.Add(availablePackages.ver8858_2);
                for (int i = 0; i < availablePackages.selectedLanguages.Count; i++)
                {
                    packages.Add(availablePackages.ver8858langs[availablePackages.selectedLanguages[i]]);
                }


                System.Threading.Thread th = new System.Threading.Thread(() =>
                {
                    installPackages();
                });
                th.Start();
            }
            if (currentversion.Contains("8858"))
            {
                
                progressBar1.Enabled = false;
                
                MessageBox.Show("Congratulations! You're done!");
                this.Close();
            }
            
        }
        void installPackages()
        {
            hasErrored = false;

            string filelist = "";
            for (int i = 0; i < packages.Count; i++)
            {
                //string file = "cabs\\" + packages[i].Replace("http://download.windowsupdate.com/", "").Replace("/", "_");
                filelist += packages[i] + " ";
            }
            Process pro = new Process();
            pro.StartInfo.FileName = bin;
            pro.StartInfo.Arguments = "/iu " + filelist + (currentversion.Contains("8773") ? " /enablebackup" : "");
            pro.StartInfo.RedirectStandardOutput = true;
            pro.StartInfo.RedirectStandardError = true;
            pro.StartInfo.CreateNoWindow = true;
            pro.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            pro.StartInfo.UseShellExecute = false;
            pro.OutputDataReceived += pro_OutputDataReceived;
            pro.EnableRaisingEvents = true;

            pro.Start();
            pro.BeginOutputReadLine();
            pro.WaitForExit();

            if (!hasErrored) {
                this.BeginInvoke((Action)(() =>
                {
                    doUpdate();
                }));
            }

        }

        void pro_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                if (e.Data.Contains("Error"))
                {
                    MessageBox.Show(e.Data);
                    hasErrored = true;
                }
                this.BeginInvoke((Action)(() =>
                {
                    lblStatus.Text = e.Data;
                }));
            }
        }

        /*
        void downloadPackages()
        {
            for (int i = 0; i < packages.Count; i++)
            {
                System.Net.WebClient c = new System.Net.WebClient();
                c.DownloadFileAsync(new Uri(packages[i]), "cabs\\" + packages[i].Replace("http://download.windowsupdate.com/", "").Replace("/", "_"));
                c.DownloadFileCompleted += c_DownloadFileCompleted;
                queuedDownloads++;
            }
            progressBar1.Style = ProgressBarStyle.Continuous;
        }

        void c_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            queuedDownloads--;
            if (queuedDownloads == 0)
            {
                //All done!
                progressBar1.Style = ProgressBarStyle.Blocks;

                lblStatus.Text = "Applying updates...";
                string filelist = "";
                for (int i = 0; i < packages.Count; i++)
                {
                    string file = "cabs\\" + packages[i].Replace("http://download.windowsupdate.com/", "").Replace("/", "_");
                    filelist += file + " ";
                }
                Process pro = new Process();
                pro.StartInfo.FileName = bin;
                pro.StartInfo.Arguments = "/iu " + filelist;
                pro.Start();
            }
        }*/

        public string getVersionFromOutput(string output)
        {
            string ver = "";
            string[] s = output.Split(new string[] { "Version: " }, StringSplitOptions.None);
            s = s[1].Split("\n".ToCharArray());
            ver = s[0];
            return ver;
        }
    }
}
