using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Net;

namespace Powercord_installer
{
    public partial class Powercord_Installer : Form
    {

        private const string ZIPURL = "https://codeload.github.com/powercord-org/powercord/zip/v2";
        private readonly string POWERCORDPATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "powercord");

        private FormConsole formConsole;

        private void SetStatus(string status) => formConsole.WriteLine(status);

        public Powercord_Installer()
        {
            InitializeComponent();
            formConsole = new FormConsole(rtb_console);
            updateButtonStatus();
        }

        private void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs, bool overwrite)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, overwrite);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs, overwrite);
                }
            }
        }

        // We download this into ~/powercord. Maybe this should be user configurable

        private void ButtonEnabledColors(object sender, System.EventArgs e)
        {
            Button x = sender as Button;

            x.BackColor = x.Enabled ? Color.LightGray : Color.DimGray;
        }

        private void updateButtonStatus()
        {
            btn_install.Enabled = true;
            btn_killDiscord.Enabled = true;
            btn_openPlugins.Enabled = Directory.Exists(Path.Combine(POWERCORDPATH, "src", "Powercord" ,"plugins"));
            btn_openThemes.Enabled = Directory.Exists(Path.Combine(POWERCORDPATH, "src", "Powercord", "themes"));
            btn_plug.Enabled = Directory.Exists(POWERCORDPATH);
            try
            {
                btn_unplug.Enabled = Directory.Exists(GetAppDir());
            }
            catch
            {
                btn_unplug.Enabled = false;
            }
            
            btn_updateNodePkg.Enabled = Directory.Exists(POWERCORDPATH);
            btn_updatePowercord.Enabled = true;
        }

        private void disableAllButtons()
        {
            btn_install.Enabled = false;
            btn_killDiscord.Enabled = false;
            btn_openPlugins.Enabled = false;
            btn_openThemes.Enabled = false;
            btn_plug.Enabled = false;
            btn_unplug.Enabled = false;
            btn_updateNodePkg.Enabled = false;
            btn_updatePowercord.Enabled = false;
        }

        private async Task DownloadZip()
        {
            WebClient wc = new WebClient();
            string downloadFileLocation = Path.Combine(Path.GetTempPath(), "powercord.zip");
            string zipExtractLocation = Path.Combine(Path.GetTempPath(), "powercord-2");

            SetStatus("Downloading...");
            await wc.DownloadFileTaskAsync(new Uri(ZIPURL), downloadFileLocation);
            SetStatus("Download complete, unzipping...");
            if (Directory.Exists(zipExtractLocation))
                Directory.Delete(zipExtractLocation, true);
            ZipFile.ExtractToDirectory(downloadFileLocation, Path.GetTempPath());
            DirectoryCopy(zipExtractLocation, POWERCORDPATH, true, true);
            SetStatus("Unzipped!");
        }

        private string GetAppDir()
        {
            string discordPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DiscordCanary");
            if (!Directory.Exists(discordPath))
                throw new Exception("You do not have discord canary!");

            string build = Directory.GetDirectories(discordPath).Select(Path.GetFileName).Where(x => x.StartsWith("app-")).OrderByDescending(x => x).First();

            return Path.Combine(discordPath, build, "resources", "app");
        }

        private async Task Plug()
        {
            string appPath = GetAppDir();

            Directory.CreateDirectory(appPath);
            File.WriteAllText(Path.Combine(appPath, "index.js"), $"require(`{Path.Combine(POWERCORDPATH, "src", "patcher.js")}`)".Replace("\\", "/"));
            File.WriteAllText(Path.Combine(appPath, "package.json"), "{\"main\":\"index.js\",\"name\":\"discord\"}");
            SetStatus("Plugged powercord!");
        }

        private void test(Process proc)
        {
            while (!proc.HasExited) ;
        }

        private async Task GetNodePackages()
        {
            SetStatus("Getting node packages...");
            ProcessStartInfo start = new ProcessStartInfo();
            start.WorkingDirectory = POWERCORDPATH;
            start.FileName = "C:/Program Files/nodejs/npm.cmd";
            start.Arguments = "i";
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;
            start.UseShellExecute = false;

            Process proc = new Process();
            proc.StartInfo = start;
            proc.Start();

            proc.Start();
            await Task.Run(() => test(proc));

            SetStatus("Got node packages");
        }

        private async Task Unplug()
        {
            string appPath = GetAppDir();
            if (Directory.Exists(appPath))
            {
                Directory.Delete(GetAppDir(), true);
                SetStatus("Unplugged powercord");
            }
            else
            {
                SetStatus("There is nothing to unplug");
            }
        }

        private async Task KillDiscordCanary()
        {
            Process process = Process.GetProcessesByName("DiscordCanary").Where(x => x.MainWindowTitle != "").FirstOrDefault();
            if (process != null)
            {
                SetStatus("Found discord process, killing!");
                process.Kill();
            }
        }

        private void rtb_console_TextChanged(object sender, EventArgs e)
        {
            rtb_console.SelectionStart = rtb_console.Text.Length;
            rtb_console.ScrollToCaret();
        }

        private async void btn_killDiscord_Click(object sender, EventArgs e)
        {
            await KillDiscordCanary();
        }

        private async void btn_unplug_Click(object sender, EventArgs e)
        {
            disableAllButtons();
            await Unplug();
            await KillDiscordCanary();
            updateButtonStatus();
        }

        private async void btn_plug_Click(object sender, EventArgs e)
        {
            disableAllButtons();
            await Plug();
            await KillDiscordCanary();
            updateButtonStatus();
        }

        private void btn_openPlugins_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(POWERCORDPATH, "src", "Powercord", "plugins"));
        }

        private void btn_openThemes_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(POWERCORDPATH, "src", "Powercord", "themes"));
        }

        private async void btn_updateNodePkg_Click(object sender, EventArgs e)
        {
            disableAllButtons();
            try
            {
                await GetNodePackages();
            }
            catch (Exception f)
            {
                SetStatus($"Exception: {f.Message}");
            }

            updateButtonStatus();
        }

        private async void btn_updatePowercord_Click(object sender, EventArgs e)
        {
            disableAllButtons();
            try
            {
                GetAppDir();
                await DownloadZip();
            }
            catch (Exception f)
            {
                SetStatus($"Exception: {f.Message}");
            }

            updateButtonStatus();
        }

        private async void btn_install_Click(object sender, EventArgs e)
        {
            disableAllButtons();
            try
            {
                GetAppDir();
                await DownloadZip();
                await GetNodePackages();
                await Plug();
                await KillDiscordCanary();
                SetStatus("Done!");
            }
            catch (Exception f)
            {
                SetStatus($"Exception: {f.Message}");
            }
            updateButtonStatus();
        }
    }
}
