using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessList
{
    public partial class Form1 : Form
    {

        PerformanceCounter PC;
        Dictionary<int, string> processDict;
        Task selectedTask;



        public Form1()
        {
            InitializeComponent();
        }

        public struct Task
        {
            public int key;
            public String name;

            public override string ToString()
            {
                return "ID: " + key.ToString() + "\t Name: " + name;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processDict = new Dictionary<int, string>();
            GetProcesses();
            ShowProcesses();
        }

        void ShowProcesses()
        {
            ListOfTasks.Items.Clear();
            foreach (var pair in processDict)
            {
                Task element = new Task();
                element.key = pair.Key;
                element.name = pair.Value;
                ListOfTasks.Items.Add(element);
            }

        }

        void GetProcesses()
        {
            Process[] allProcess;
            allProcess = Process.GetProcesses();
            processDict.Clear();
            foreach (Process element in allProcess)
            {
                processDict.Add(element.Id, element.ProcessName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTask = (Task) ListOfTasks.SelectedItem;
            ShowAttributes(selectedTask);
        }

        private void ShowAttributes(Task selectedTask)
        {
            try
            {
                Process selectedProcess = Process.GetProcessById(selectedTask.key);
                label1.Text = "Task name: " + selectedTask.name.ToString();
                label2.Text = "Task ID: " + selectedTask.key.ToString();
                label4.Text = "Start time: " + selectedProcess.StartTime.ToString();
                label5.Text = "Running time: " + (DateTime.Now - selectedProcess.StartTime).ToString();
                label6.Text = "Memory usage: " + getMemoryUsage(selectedProcess).ToString() + " Mb";
                PC = new PerformanceCounter("Process", "% Processor Time", selectedTask.name, true);
                PC.NextValue();
                Thread.Sleep(0);
                label3.Text = String.Format("CPU usage: {0:0.00}", PC.NextValue()) + "%";
                label7.Text = "Threads:" + selectedProcess.Threads.Count.ToString();

            }
            catch (Exception)
            {

            }
        }

        int getMemoryUsage(Process selectedProcess)
        {
            int memsize = 0; // memsize in Megabyte
            PerformanceCounter PC = new PerformanceCounter();
            PC.CategoryName = "Process";
            PC.CounterName = "Working Set - Private";
            PC.InstanceName = selectedProcess.ProcessName;
            PC.NextValue();
            memsize = Convert.ToInt32(PC.NextValue()) / (int)(1024);
            PC.Close();
            PC.Dispose();
            return memsize;
        }

        void ShowCpuUsage()
        {
                
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                
            }
        }
    }
    
}
