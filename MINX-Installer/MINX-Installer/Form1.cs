using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINX_Installer
{
    public partial class Form1 : Form
    {
        //ENviornment VAR VS100Comntools dir : ../../VC

        private string vs2010Dir, vs2012Dir, vs2013Dir;
        public Form1()
        {
            InitializeComponent();
        }

        private void installDetectorButton_Click(object sender, EventArgs e)
        {
            installDetectorButton.Enabled = false;
            vsVersionPanel.Enabled = true;

            //Check if Visual Studio 2010 is Installed
            consoleBox.AppendText("Checking for Visual Studio 2010: ");
            vs10Checkbox.Enabled = Registry.ClassesRoot.OpenSubKey("VisualStudio.DTE.10.0") != null;
            if (vs10Checkbox.Enabled)
            {
                consoleBox.AppendText(" Found!\n");
                string vs10RootDir = Directory.GetParent(Environment.GetEnvironmentVariable("VS100COMNTOOLS")).Parent.Parent.FullName;
                vs10Dir.Text = Path.Combine(vs10RootDir, "VC");
                vs2010Dir = vs10Dir.Text;
                if (vs10Dir.Text.Length > 47)
                {
                    vs10Dir.Text = vs10Dir.Text.Insert(47, "\r\n");
                }
                vs10Checkbox.ForeColor = Color.Green;
            }
            else
            {
                consoleBox.AppendText(" Missing!\n");
            }

            //Check if Visual Studio 2012 is Installed
            consoleBox.AppendText("Checking for Visual Studio 2012: ");
            vs12Checkbox.Enabled = Registry.ClassesRoot.OpenSubKey("VisualStudio.DTE.11.0") != null;
            if (vs12Checkbox.Enabled)
            {
                consoleBox.AppendText(" Found!\n");
                string vs12RootDir = Directory.GetParent(Environment.GetEnvironmentVariable("VS110COMNTOOLS")).Parent.Parent.FullName;
                vs12Dir.Text = Path.Combine(vs12RootDir, "VC");
                vs2012Dir = vs12Dir.Text;
                if (vs12Dir.Text.Length > 47)
                {
                    vs12Dir.Text = vs12Dir.Text.Insert(47, "\r\n");
                }
                vs12Checkbox.ForeColor = Color.Green;
            }
            else
            {
                consoleBox.AppendText(" Missing!\n");
            }

            //Check if Visual Studio 2013 is Installed
            consoleBox.AppendText("Checking for Visual Studio 2013: ");
            vs13Checkbox.Enabled = Registry.ClassesRoot.OpenSubKey("VisualStudio.DTE.12.0") != null;
            if (vs13Checkbox.Enabled)
            {
                consoleBox.AppendText(" Found!\n");
                string vs13RootDir = Directory.GetParent(Environment.GetEnvironmentVariable("VS120COMNTOOLS")).Parent.Parent.FullName;
                vs13Dir.Text = Path.Combine(vs13RootDir, "VC");
                vs2013Dir = vs13Dir.Text;
                if (vs13Dir.Text.Length > 47)
                {
                    vs13Dir.Text = vs13Dir.Text.Insert(47, "\r\n");
                }
                vs13Checkbox.ForeColor = Color.Green;
            }
            else
            {
                consoleBox.AppendText(" Missing!\n");
            }
        }

        private void installMINXButton_Click(object sender, EventArgs e)
        {
            if (!vsVersionPanel.Enabled || !(vs10Checkbox.Checked || vs12Checkbox.Checked || vs13Checkbox.Checked))
            {
                consoleBox.AppendText("Please Select a Visual Studio Version Before Continuing!\n");
                return;
            }
            consoleBox.AppendText("Installing MINX\n\n");
            if (vs10Checkbox.Checked)
            {
                consoleBox.AppendText("Installing MINX for Visual Studio 2010\n");
                ExtractZipWithOverwrite("../../../../headers.zip", Path.Combine(vs2010Dir, "include/"));
                //ZipFile.ExtractToDirectory("headers.zip", Path.Combine(vs2010Dir, "include"));
                ExtractZipWithOverwrite("../../../../libs.zip", Path.Combine(vs2010Dir, "lib/"));
                consoleBox.AppendText("MINX for Visual Studio 2010 Installed!\n");
            }
            if (vs12Checkbox.Checked)
            {
                consoleBox.AppendText("Installing MINX for Visual Studio 2012\n");
                ExtractZipWithOverwrite("../../../../headers.zip", Path.Combine(vs2012Dir, "include/"));
                ExtractZipWithOverwrite("../../../../libs.zip", Path.Combine(vs2012Dir, "lib/"));
                consoleBox.AppendText("MINX for Visual Studio 2012 Installed!\n");
            }
            if (vs13Checkbox.Checked)
            {
                consoleBox.AppendText("Installing MINX for Visual Studio 2013\n");
                ExtractZipWithOverwrite("../../../../headers.zip", Path.Combine(vs2013Dir, "include/"));
                ExtractZipWithOverwrite("../../../../libs.zip", Path.Combine(vs2013Dir, "lib/"));
                consoleBox.AppendText("MINX for Visual Studio 2013 Installed!\n");
            }
            MessageBox.Show("Installation Complete!");
        }
        private void ExtractZipWithOverwrite(string location, string destination)
        {
            //Get Zip File Inner-Entry
            foreach (ZipArchiveEntry entry in ZipFile.Open(location, ZipArchiveMode.Read).Entries)
            {
                //Make sure it's not a directory
                if (entry.Name.Length > 0)
                {
                    //Find out the Directory teh file will go in
                    string dir = destination + (entry.FullName.Remove(entry.FullName.Length - entry.Name.Length));

                    //If it doesn't exist create it
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }

                    //extract the file
                    entry.ExtractToFile(destination + entry.FullName, true);
                }
            }
        }
    }
}
