using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP31
{
    public partial class Form1 : Form
    {
        private ImageList processIconList; // ImageList для зберігання іконок процесів

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr ExtractIcon(IntPtr hInst, string lpszExeFileName, int nIconIndex);

        public Form1()
        {
            InitializeComponent();
            InitializeContextMenu();

            listView1.Items.Clear();
            processIconList = new ImageList();
            processIconList.ImageSize = new Size(16, 16);
            listView1.SmallImageList = processIconList;

            RefreshProcessList();
        }

        private void RefreshProcessList()
        {
            listView1.Items.Clear();
            processIconList.Images.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());
                listView1.Items.Add(item);

                try
                {
                    // Замість використання Icon.ExtractAssociatedIcon() ви можете використовувати вашу власну іконку
                    // Замініть "your_icon.ico" на шлях до вашої іконки
                    Icon icon = new Icon("C:\\Users\\lox22\\source\\repos\\OOP21\\Photo\\icons8-дублировать-30.png");
                    processIconList.Images.Add(icon);
                    item.ImageIndex = processIconList.Images.Count - 1;
                }
                catch (Exception)
                {
                    // Обробити виняток, якщо не вдається завантажити вашу іконку
                    item.ImageIndex = -1;
                }
            }

            listView1.SmallImageList = processIconList;
        }

        private void InitializeContextMenu()
        {
            contextMenuStrip1.Items.Add("Оновити процеси", null, оновитиПроцесиToolStripMenuItem1_Click);
            contextMenuStrip1.Items.Add("Зупинити процес", null, зупинитиПроцесToolStripMenuItem1_Click);
            contextMenuStrip1.Items.Add("Інформація про процес", null, інформаціяПроПроцесToolStripMenuItem1_Click);
            contextMenuStrip1.Items.Add("Єкспорт списку процесів", null, экспортСпискуToolStripMenuItem_Click);
            listView1.ContextMenuStrip = contextMenuStrip1;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void оновитиПроцесиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

        private void зупинитиПроцесToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string processName = listView1.SelectedItems[0].Text;
                Process process = Process.GetProcessesByName(processName)[0];
                try
                {
                    process.Kill();
                    MessageBox.Show($"Process '{process.ProcessName}' has been stopped.",
                                    "Process Stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to stop process.\nError: {ex.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void інформаціяПроПроцесToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string processName = listView1.SelectedItems[0].Text;
                Process process = Process.GetProcessesByName(processName)[0];

                string processInfo = $"Process Name: {process.ProcessName}\n" +
                                     $"ID: {process.Id}\n" +
                                     $"Start Time: {process.StartTime}\n" +
                                     $"Responding: {process.Responding}\n" +
                                     $"Threads: {process.Threads.Count}\n" +
                                     $"Modules: {process.Modules.Count}\n\n";

                processInfo += "Threads:\n";
                foreach (ProcessThread thread in process.Threads)
                {
                    processInfo += $"Thread ID: {thread.Id}\tState: {thread.ThreadState}\n";
                }

                processInfo += "\nModules:\n";
                foreach (ProcessModule module in process.Modules)
                {
                    processInfo += $"Module Name: {module.ModuleName}\tFile Name: {module.FileName}\n";
                }

                MessageBox.Show(processInfo, "Process Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void экспортСпискуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (ListViewItem item in listView1.Items)
                        {
                            writer.WriteLine($"Process Name: {item.Text}\tID: {item.SubItems[1].Text}");
                        }
                    }
                    MessageBox.Show("Process list exported successfully.",
                                    "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
