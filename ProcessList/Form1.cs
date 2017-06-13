using System;
using System.Collections;
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
        List<Task> tasks;



        public Form1()
        {
            InitializeComponent();
        }

        public struct Task
        {
            public int key;
            public String name;
            public String note;

            public override string ToString()
            {
                return "ID: " + key.ToString() + "\t Name: " + name;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processDict = new Dictionary<int, string>();
            tasks = new List<Task>();
            GetProcesses();
            ShowProcesses();
        }

        void ShowProcesses()
        {
            foreach (var pair in processDict)
            {
                Task element = new Task();
                element.key = pair.Key;
                element.name = pair.Value;
                element.note = "";
                tasks.Add(element);
            }
            FillListboxWithTasks();
        }

        void FillListboxWithTasks()
        {
            ListOfTasks.Items.Clear();
            foreach (Task element in tasks) 
            {
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
            ShowAttributes();
        }

        private void ShowAttributes()
        {
            NoteTextBox.Text = selectedTask.note;
            try
            {
                Process selectedProcess = Process.GetProcessById(selectedTask.key);
                TaskNameLabel.Text = "Task name: " + selectedTask.name.ToString();
                TaskIdLabel.Text = "Task ID: " + selectedTask.key.ToString();
                StartTimeLabel.Text = "Start time: " + selectedProcess.StartTime.ToString();
                RunningTimeLabel.Text = "Running time: " + (DateTime.Now - selectedProcess.StartTime).ToString();
                MemoryUsageLabel.Text = "Memory usage: " + GetMemoryUsage(selectedProcess).ToString() + " Mb";
                CpuUsageLabel.Text = String.Format("CPU usage: {0:0.00}", GetCpuUsage()) + "%";
                ThreadsLabel.Text = "Threads:" + selectedProcess.Threads.Count.ToString();

            }
            catch (Exception)
            {

            }
        }

        float GetCpuUsage()
        {
            PC = new PerformanceCounter("Process", "% Processor Time", selectedTask.name, true);
            PC.NextValue();
            Thread.Sleep(100);
            return PC.NextValue();
        }

        int GetMemoryUsage(Process selectedProcess)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                int id = 0;
                foreach (Task element in tasks)
                {
                    if (element.Equals(selectedTask))
                    {
                        id = tasks.IndexOf(element);
                    }
                }
                Task task = tasks[id]; 
                task.note = NoteTextBox.Text;
                tasks[id] = task;
                FillListboxWithTasks();
            }
        }
    }
    
}
