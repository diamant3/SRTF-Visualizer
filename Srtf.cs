/*
 * Based on the srtf scheduling https://github.com/Zain-Bin-Arshad/OS-Scheduling
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRTF_Visualizer
{
    public partial class Srtf : Form
    {
        public Srtf()
        {
            InitializeComponent();

        }

        /*
         * Declaring or Initializing all lists and variables for storing process id and required inputs
         */
        List<Process> Process_List = new();
        readonly List<Process> ganttChart = new();
        readonly List<int> Arrival_time = new();
        readonly List<int> burst_time = new();
        readonly List<int> flag = new();
        readonly List<int> service_time = new();
        int Process_ID;
        int Process_Arrival;
        int Process_Burst;
        int time = 0;
        int complete = 0, shortest = 0, finish_time, minimum;
        float total_waiting_time = 0f, total_turnAround_time = 0f;
        string[] row = new string[50];
        bool sameProcID = false;

        /*
         * Gantt Chart drawing boxes - positions x and y
         */
        int X = 16;
        int Y = 16;
        readonly int gcX = 50;
        readonly int gcY = 50;


        /*
         *  Solve Button Function
         */
        private void Solve_btn_Click(object sender, EventArgs e)
        {

            // check if process list is empty
            if (Process_List.Count == 0)
            {
                MessageBox.Show("Input your data first!", "SRTF Visualizer: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SRTFfindavgTime(Process_List, Process_List.Count); // core srtf functions

            recordTable2.Visible = false;
            recordTable1.Visible = true;

            // final output to the table
            Process_List = Process_List.OrderBy(i => i.P_id).ToList();
            for (int i = 0; i < Process_List.Count; i++)
            {
                row = new[]
                {
                    Convert.ToString(Process_List[i].P_id),
                    Convert.ToString(Process_List[i].arrival_time),
                    Convert.ToString(Process_List[i].burst_time),
                    Convert.ToString(Process_List[i].PturnAround_time),
                    Convert.ToString(Process_List[i].Pwaiting_time)
                };

                recordTable1.Rows.Add(row);
            }

            if ((total_turnAround_time / Process_List.Count) == 0)
               tatBox.Text = "0.00";
            else
                tatBox.Text = (total_turnAround_time / Process_List.Count).ToString("#.##");

            if ((total_waiting_time / Process_List.Count) == 0)
                wtBox.Text = "0.00";
            else
                wtBox.Text = (total_waiting_time / Process_List.Count).ToString("#.##");
        }

        /*
         *  Add button Function
         */
        private void Add_btn_Click(object sender, EventArgs e)
        {
            recordTable1.Visible = false;
            Process_ID = Convert.ToInt32(procID_in.Value);
            Process_Burst = Convert.ToInt32(bt_in.Text);
            Process_Arrival = Convert.ToInt32(at_in.Text);

            // check if has same process id
            for (int process = 0; process < Process_List.Count; process++)
            {
                if (Process_List[process].P_id == Process_ID)
                    sameProcID = true;
            }

            if (sameProcID)
            {
                MessageBox.Show("Two process can't have the same ID: " + Convert.ToString(Process_ID), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sameProcID = false;
                return;
            }
            else
            {
                // Insert the input data to table
                Process_List.Add(new Process(Process_ID, Process_Burst, Process_Arrival));
                row = new[]
                {
                    Convert.ToString(Process_List[^1].P_id),
                    Convert.ToString(Process_List[^1].arrival_time),
                    Convert.ToString(Process_List[^1].burst_time),
                    "   --",
                    "   --",
                    "   --"
                };
            }

            recordTable2.Rows.Add(row);
            sameProcID = false;
        }

        /*
         *  Clear All Button
         */
        private void Clear_all_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Remove all Process?", "SRTF Visualizer: Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            // Just reset hehe
            if (dialog == DialogResult.Yes)
            {
                total_turnAround_time = 0;
                total_waiting_time = 0;
                X = 16;
                Y = 16;
                time = 0;
                Process_Burst = 0;
                complete = 0; 
                shortest = 0; 
                finish_time = 0; 
                minimum = 0; 
                sameProcID = false;
                Process_List.Clear(); 
                ganttChart.Clear(); 
                flag.Clear();
                burst_time.Clear(); 
                Arrival_time.Clear(); 
                service_time.Clear();
                recordTable1.Rows.Clear();
                recordTable1.Refresh();
                recordTable2.Rows.Clear();
                recordTable2.Refresh();
                tatBox.Text = wtBox.Text = "";
                gcPane.Controls.Clear();
            }
        }

        /*
         * SRTF Core Function
         */
        public void SRTFfindavgTime(List<Process> Process_List, int processLength)
        {
            minimum = int.MaxValue;

            // Copy the burst time into rt[] 
            for (int process = 0; process < processLength; process++)
            {
                burst_time.Add(Process_List[process].burst_time); // making new burst time list 
            }
            // do until all processes are done
            while (complete != processLength)
            {
                // find minimum remaing time process, from process arrived till now
                for (int procTime = 0; procTime < processLength; procTime++)
                {
                    if ((Process_List[procTime].arrival_time <= time) && (burst_time[procTime] < minimum) && burst_time[procTime] > 0)
                    {
                        minimum = burst_time[procTime];
                        shortest = procTime;
                        sameProcID = true;
                    }
                }

                if (sameProcID == false)
                {
                    time++;
                    continue;
                }
                ganttChart.Add(Process_List[shortest]);

                // reduce remaining time by one 
                burst_time[shortest]--;

                // draw box for Process id to Gantt chart
                TextBox textBox1 = new();
                gcPane.Controls.Add(textBox1);
                textBox1.Size = new Size(gcY, gcX);
                textBox1.Text = "P" + Convert.ToString(Process_List[shortest].P_id);
                textBox1.Location = new Point(X, 34);
                textBox1.BackColor = Process_List[shortest].process_color;
                textBox1.Name = "textBox1";
                textBox1.ReadOnly = true;
                X += textBox1.Width;

                // Update minimum 
                minimum = burst_time[shortest];

                // if prcess is done executing
                if (burst_time[shortest] == 0)
                {
                    minimum = int.MaxValue;

                    // Increment complete 
                    complete++;
                    sameProcID = false;

                    //finish time in array
                    finish_time = time + 1;

                    // waiting time calculate
                    Process_List[shortest].Pwaiting_time = finish_time - Process_List[shortest].burst_time - Process_List[shortest].arrival_time;
                    Process_List[shortest].PturnAround_time = Process_List[shortest].burst_time + Process_List[shortest].Pwaiting_time;

                    if (Process_List[shortest].Pwaiting_time < 0)
                        Process_List[shortest].Pwaiting_time = 0;
                }
                // Move next in time 
                time++;
            }

            PrintGanttChart(ganttChart);

            for (int process = 0; process < processLength; process++)
            {
                total_waiting_time += Process_List[process].Pwaiting_time;
                total_turnAround_time += Process_List[process].PturnAround_time;
            }
        }

        /*
         *  Gantt Chart Drawing Function
         */
        public void PrintGanttChart(List<Process> ganttChart)
        {
            int num = 0;
            TextBox textBox6 = new();
            gcPane.Controls.Add(textBox6);
            textBox6.ReadOnly = true;
            textBox6.Size = new System.Drawing.Size(gcY, gcX);
            textBox6.BackColor = ganttChart[0].process_color;
            textBox6.Location = new Point(Y, 59);
            textBox6.Text = 0.ToString();
 

            for (; num < ganttChart.Count; num++)
            {
                if (num < (ganttChart.Count - 1))
                {
                    if (ganttChart[num].P_id != ganttChart[num + 1].P_id)
                    {
                        TextBox textBox2 = new();
                        gcPane.Controls.Add(textBox2);
                        textBox2.ReadOnly = true;
                        textBox2.Size = new Size(gcY, gcX);
                        textBox2.BackColor = ganttChart[num].process_color;
                        textBox2.Location = new Point(Y, 59);
                        textBox2.Text = (num.ToString());
                
                        TextBox textBox5 = new();
                        gcPane.Controls.Add(textBox5);
                        textBox5.ReadOnly = true;
                        textBox5.Size = new Size(gcY, gcX);
                        textBox5.BackColor = ganttChart[num + 1].process_color;
                        textBox5.Location = new Point((Y + textBox2.Width), 59);
                        textBox5.Text = ((num + 1).ToString());
                        
                    }

                    Y += gcY;
                }
                if (num == (ganttChart.Count - 1))
                {
                    TextBox textBox7 = new();
                    gcPane.Controls.Add(textBox7);
                    textBox7.ReadOnly = true;
                    textBox7.Size = new Size(gcY, gcX);
                    if (num != 0)
                        textBox7.BackColor = ganttChart[num - 1].process_color;
                    else
                        textBox7.BackColor = ganttChart[num].process_color;
                    textBox7.Location = new Point(Y, 59);
                    textBox7.Text = num.ToString();
                }
            }
        }
    }
}
