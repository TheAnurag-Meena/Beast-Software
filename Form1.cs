using Beast_SB.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Beast_SB
{
    public partial class Form1 : Form
    {

       
        private GAME g = new GAME();
        

        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // open smartgaga

            try
            {
                File.WriteAllBytes("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\titan.pak", Resources.beasttitan);
                File.WriteAllBytes("D:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\titan.pak", Resources.beasttitan);
                File.WriteAllBytes("E:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\titan.pak", Resources.beasttitan);
                File.WriteAllBytes("F:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\titan.pak", Resources.beasttitan);


            }
            catch
            {
            }


            try
            {
                File.WriteAllBytes("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\lang\\en_US.ini", Resources.en_US);
                File.WriteAllBytes("D:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\lang\\en_US.ini", Resources.en_US);
                File.WriteAllBytes("E:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\lang\\en_US.ini", Resources.en_US);
                File.WriteAllBytes("F:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\lang\\en_US.ini", Resources.en_US);
            }
            catch
            {

            }

            try
            {
                string exepathc = "C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\Launcher.exe";

                if ((File.Exists(exepathc)))
                {
                    Process.Start(exepathc);

                }
            }
            catch
            {
            }

            try
            {
                string exepathc = "D:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\Launcher.exe";

                if ((File.Exists(exepathc)))
                {
                    Process.Start(exepathc);

                }
            }
            catch
            {
            }

            try
            {
                string exepathc = "E:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\Launcher.exe";

                if ((File.Exists(exepathc)))
                {
                    Process.Start(exepathc);

                }
            }
            catch
            {
            }

            try
            {
                string exepathc = "F:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\Launcher.exe";

                if ((File.Exists(exepathc)))
                {
                    Process.Start(exepathc);

                }
            }
            catch
            {
            }

            try
            {
                string exepathc = "G:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\Launcher.exe";

                if ((File.Exists(exepathc)))
                {
                    Process.Start(exepathc);

                }
            }
            catch
            {
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Start Game
            Console.Beep();


            try
            {
                File.WriteAllBytes("C:\\Windows\\System\\adb.exe", Resources.adb);
                File.WriteAllBytes("C:\\Windows\\System\\AdbWinApi.dll", Resources.AdbWinApi);

            }
            catch
            {
            }

            if (!this.radioButton1.Checked & !this.radioButton2.Checked & !this.radioButton3.Checked & !this.radioButton4.Checked)
            {
                _ = (int)MessageBox.Show("Select Game Version First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (radioButton1.Checked)
            {
                g.GLOBAL();


            }
            if (radioButton2.Checked)
            {
                g.TAIWAN();


            }
            if (radioButton3.Checked)
            {
                g.KOREA();


            }
            if (radioButton4.Checked)
            {
                g.VNG();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/HYNruC");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start("https://shoppy.gg/@CSBEAST");
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            //Close Button

            Process process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                CreateNoWindow = true,
                RedirectStandardInput = true,
                UseShellExecute = false
            };
            process.Start();
            using (StreamWriter standardInput = process.StandardInput)
            {
                if (!standardInput.BaseStream.CanWrite)
                    return;
                standardInput.WriteLine("taskkill /f /im adb.exe & taskkill /f /im ProjectTitan.exe & taskkill /f /im AndroidProcess.exe & taskkill /f /im TitanService.exe & net stop TitanService");
                
            }
           
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            //Game fix
            siticoneRoundedButton1.Enabled = false;
            siticoneRoundedButton1.Text = "Fixing...";
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                CreateNoWindow = true,
                RedirectStandardInput = true,
                UseShellExecute = false
            };
            process.Start();
            using (StreamWriter standardInput = process.StandardInput)
            {
                if (!standardInput.BaseStream.CanWrite)
                    return;
                standardInput.WriteLine("taskkill /f /im adb.exe & taskkill /f /im adb.exe");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe start-server");
                standardInput.WriteLine("taskkill /f /im processhacker.exe & taskkill /f /im Procmon64.exe & taskkill /f /im apimonitor-x64 & taskkill /f /im apimonitor-x64");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell cp /data/stdin /data/data/");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell cp /stdin /data/data/");
                standardInput.WriteLine("taskkill /f /im processhacker.exe & taskkill /f /im Procmon64.exe & taskkill /f /im apimonitor-x64 & taskkill /f /im apimonitor-x64");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell rename /data/data/stdin /data/data/com.tencent.tinput");
                standardInput.WriteLine("taskkill /f /im processhacker.exe & taskkill /f /im Procmon64.exe & taskkill /f /im apimonitor-x64 & taskkill /f /im apimonitor-x64");

            }
            process.WaitForExit();
            {
                siticoneRoundedButton1.Enabled = false;
                siticoneRoundedButton1.Text = "Fixed";
                _ = MessageBox.Show("Permanent Game Fixed!", "Information",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            // Dx fix

            try
            {
                File.WriteAllBytes("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libEGL.dll", Resources.libEGL);
                File.WriteAllBytes("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLESv1.dll", Resources.libGLESv1);
                File.WriteAllBytes("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLESv2.dll", Resources.libGLESv2);
                File.WriteAllBytes("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLESv3Detect.dll", Resources.libGLESv3Detect);
                File.WriteAllBytes("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLES_CM_translator.dll", Resources.libGLES_CM_translator);
                File.WriteAllBytes("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLES_CM_translator_v3.dll", Resources.libGLES_CM_translator_v3);
                File.WriteAllBytes("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLES_V2_translator.dll", Resources.libGLES_V2_translator);
                File.WriteAllBytes("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLES_V2_translator_v3.dll", Resources.libGLES_V2_translator_v3);


            }
            catch
            {
            }

            try
            {
                File.WriteAllBytes("D:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libEGL.dll", Resources.libEGL);
                File.WriteAllBytes("D:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLESv1.dll", Resources.libGLESv1);
                File.WriteAllBytes("D:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLESv2.dll", Resources.libGLESv2);
                File.WriteAllBytes("D:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLESv3Detect.dll", Resources.libGLESv3Detect);
                File.WriteAllBytes("D:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLES_CM_translator.dll", Resources.libGLES_CM_translator);
                File.WriteAllBytes("D:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLES_CM_translator_v3.dll", Resources.libGLES_CM_translator_v3);
                File.WriteAllBytes("D:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLES_V2_translator.dll", Resources.libGLES_V2_translator);
                File.WriteAllBytes("D:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLES_V2_translator_v3.dll", Resources.libGLES_V2_translator_v3);


            }
            catch
            {
            }

            try
            {
                File.WriteAllBytes("E:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libEGL.dll", Resources.libEGL);
                File.WriteAllBytes("E:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLESv1.dll", Resources.libGLESv1);
                File.WriteAllBytes("E:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLESv2.dll", Resources.libGLESv2);
                File.WriteAllBytes("E:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLESv3Detect.dll", Resources.libGLESv3Detect);
                File.WriteAllBytes("E:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLES_CM_translator.dll", Resources.libGLES_CM_translator);
                File.WriteAllBytes("E:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLES_CM_translator_v3.dll", Resources.libGLES_CM_translator_v3);
                File.WriteAllBytes("E:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLES_V2_translator.dll", Resources.libGLES_V2_translator);
                File.WriteAllBytes("E:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLES_V2_translator_v3.dll", Resources.libGLES_V2_translator_v3);


            }
            catch
            {
            }

            try
            {
                File.WriteAllBytes("F:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libEGL.dll", Resources.libEGL);
                File.WriteAllBytes("F:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLESv1.dll", Resources.libGLESv1);
                File.WriteAllBytes("F:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLESv2.dll", Resources.libGLESv2);
                File.WriteAllBytes("F:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLESv3Detect.dll", Resources.libGLESv3Detect);
                File.WriteAllBytes("F:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLES_CM_translator.dll", Resources.libGLES_CM_translator);
                File.WriteAllBytes("F:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLES_CM_translator_v3.dll", Resources.libGLES_CM_translator_v3);
                File.WriteAllBytes("F:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLES_V2_translator.dll", Resources.libGLES_V2_translator);
                File.WriteAllBytes("F:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\renderer_dx\\libGLES_V2_translator_v3.dll", Resources.libGLES_V2_translator_v3);


            }
            catch
            {
            }

            siticoneRoundedButton2.Enabled = false;
            siticoneRoundedButton2.Text = "Fixed";
            _ = MessageBox.Show("DirectX Fixed! Change Smartgaga setting to DirectX", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
