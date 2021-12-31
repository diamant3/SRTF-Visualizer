
namespace SRTF_Visualizer
{
    partial class Srtf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Srtf));
            this.panel1 = new System.Windows.Forms.Panel();
            this.recordTable2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordTable1 = new System.Windows.Forms.DataGridView();
            this.processID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tatValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wtValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartBox = new System.Windows.Forms.GroupBox();
            this.gcPane = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.solve_btn = new System.Windows.Forms.Button();
            this.clear_all_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.procID_in = new System.Windows.Forms.NumericUpDown();
            this.at_in = new System.Windows.Forms.NumericUpDown();
            this.bt_in = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.wtBox = new System.Windows.Forms.TextBox();
            this.tatBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordTable1)).BeginInit();
            this.chartBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.procID_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.at_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_in)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.recordTable2);
            this.panel1.Controls.Add(this.recordTable1);
            this.panel1.Controls.Add(this.chartBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(433, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 672);
            this.panel1.TabIndex = 0;
            // 
            // recordTable2
            // 
            this.recordTable2.AllowUserToAddRows = false;
            this.recordTable2.AllowUserToResizeColumns = false;
            this.recordTable2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recordTable2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.recordTable2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Fira Code Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordTable2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.recordTable2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordTable2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Fira Code Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recordTable2.DefaultCellStyle = dataGridViewCellStyle8;
            this.recordTable2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.recordTable2.GridColor = System.Drawing.Color.Gray;
            this.recordTable2.Location = new System.Drawing.Point(12, 96);
            this.recordTable2.Name = "recordTable2";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Fira Code Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recordTable2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.recordTable2.RowHeadersVisible = false;
            this.recordTable2.RowHeadersWidth = 62;
            this.recordTable2.RowTemplate.Height = 33;
            this.recordTable2.Size = new System.Drawing.Size(801, 398);
            this.recordTable2.TabIndex = 15;
            this.recordTable2.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Process ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Arrival Time";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Burst Time";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Turn Around Time";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Waiting Time";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // recordTable1
            // 
            this.recordTable1.AllowUserToAddRows = false;
            this.recordTable1.AllowUserToResizeColumns = false;
            this.recordTable1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recordTable1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.recordTable1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Fira Code Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordTable1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.recordTable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordTable1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processID,
            this.atValue,
            this.btValue,
            this.tatValue,
            this.wtValue});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Fira Code Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recordTable1.DefaultCellStyle = dataGridViewCellStyle11;
            this.recordTable1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.recordTable1.GridColor = System.Drawing.Color.Gray;
            this.recordTable1.Location = new System.Drawing.Point(12, 96);
            this.recordTable1.Name = "recordTable1";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Fira Code Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recordTable1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.recordTable1.RowHeadersVisible = false;
            this.recordTable1.RowHeadersWidth = 62;
            this.recordTable1.RowTemplate.Height = 33;
            this.recordTable1.Size = new System.Drawing.Size(801, 398);
            this.recordTable1.TabIndex = 0;
            this.recordTable1.TabStop = false;
            // 
            // processID
            // 
            this.processID.HeaderText = "Process ID";
            this.processID.MinimumWidth = 8;
            this.processID.Name = "processID";
            // 
            // atValue
            // 
            this.atValue.HeaderText = "Arrival Time";
            this.atValue.MinimumWidth = 8;
            this.atValue.Name = "atValue";
            // 
            // btValue
            // 
            this.btValue.HeaderText = "Burst Time";
            this.btValue.MinimumWidth = 8;
            this.btValue.Name = "btValue";
            // 
            // tatValue
            // 
            this.tatValue.HeaderText = "Turn Around Time";
            this.tatValue.MinimumWidth = 8;
            this.tatValue.Name = "tatValue";
            // 
            // wtValue
            // 
            this.wtValue.HeaderText = "Waiting Time";
            this.wtValue.MinimumWidth = 8;
            this.wtValue.Name = "wtValue";
            // 
            // chartBox
            // 
            this.chartBox.Controls.Add(this.gcPane);
            this.chartBox.ForeColor = System.Drawing.Color.White;
            this.chartBox.Location = new System.Drawing.Point(12, 499);
            this.chartBox.Name = "chartBox";
            this.chartBox.Size = new System.Drawing.Size(801, 161);
            this.chartBox.TabIndex = 14;
            this.chartBox.TabStop = false;
            this.chartBox.Text = "Gantt Chart";
            // 
            // gcPane
            // 
            this.gcPane.AutoScroll = true;
            this.gcPane.AutoSize = true;
            this.gcPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPane.Location = new System.Drawing.Point(3, 30);
            this.gcPane.Name = "gcPane";
            this.gcPane.Size = new System.Drawing.Size(795, 128);
            this.gcPane.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Fira Code Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(297, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 47);
            this.label5.TabIndex = 13;
            this.label5.Text = "Output Table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arrival Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Burst Time:";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Blue;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Location = new System.Drawing.Point(12, 309);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(146, 34);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Add...";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // solve_btn
            // 
            this.solve_btn.BackColor = System.Drawing.Color.Blue;
            this.solve_btn.FlatAppearance.BorderSize = 0;
            this.solve_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solve_btn.Location = new System.Drawing.Point(12, 349);
            this.solve_btn.Name = "solve_btn";
            this.solve_btn.Size = new System.Drawing.Size(146, 34);
            this.solve_btn.TabIndex = 9;
            this.solve_btn.Text = "Solve";
            this.solve_btn.UseVisualStyleBackColor = false;
            this.solve_btn.Click += new System.EventHandler(this.Solve_btn_Click);
            // 
            // clear_all_btn
            // 
            this.clear_all_btn.BackColor = System.Drawing.Color.Blue;
            this.clear_all_btn.FlatAppearance.BorderSize = 0;
            this.clear_all_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_all_btn.Location = new System.Drawing.Point(274, 309);
            this.clear_all_btn.Name = "clear_all_btn";
            this.clear_all_btn.Size = new System.Drawing.Size(146, 34);
            this.clear_all_btn.TabIndex = 10;
            this.clear_all_btn.Text = "Clear all";
            this.clear_all_btn.UseVisualStyleBackColor = false;
            this.clear_all_btn.Click += new System.EventHandler(this.Clear_all_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Fira Code Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(147, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 47);
            this.label4.TabIndex = 12;
            this.label4.Text = "Input";
            // 
            // procID_in
            // 
            this.procID_in.Location = new System.Drawing.Point(240, 96);
            this.procID_in.Name = "procID_in";
            this.procID_in.Size = new System.Drawing.Size(180, 34);
            this.procID_in.TabIndex = 13;
            // 
            // at_in
            // 
            this.at_in.Location = new System.Drawing.Point(240, 168);
            this.at_in.Name = "at_in";
            this.at_in.Size = new System.Drawing.Size(180, 34);
            this.at_in.TabIndex = 14;
            this.at_in.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bt_in
            // 
            this.bt_in.Location = new System.Drawing.Point(240, 242);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(180, 34);
            this.bt_in.TabIndex = 15;
            this.bt_in.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 32);
            this.label6.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.wtBox);
            this.groupBox1.Controls.Add(this.tatBox);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 159);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Average Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Waiting Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Turn Around Time";
            // 
            // wtBox
            // 
            this.wtBox.Location = new System.Drawing.Point(252, 104);
            this.wtBox.Name = "wtBox";
            this.wtBox.Size = new System.Drawing.Size(150, 34);
            this.wtBox.TabIndex = 1;
            // 
            // tatBox
            // 
            this.tatBox.Location = new System.Drawing.Point(252, 41);
            this.tatBox.Name = "tatBox";
            this.tatBox.Size = new System.Drawing.Size(150, 34);
            this.tatBox.TabIndex = 0;
            // 
            // Srtf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1258, 672);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_in);
            this.Controls.Add(this.at_in);
            this.Controls.Add(this.procID_in);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clear_all_btn);
            this.Controls.Add(this.solve_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Fira Code Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Srtf";
            this.Text = "SRTF Scheduling";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordTable1)).EndInit();
            this.chartBox.ResumeLayout(false);
            this.chartBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.procID_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.at_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_in)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button solve_btn;
        private System.Windows.Forms.Button clear_all_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView recordTable1;
        private System.Windows.Forms.NumericUpDown procID_in;
        private System.Windows.Forms.NumericUpDown at_in;
        private System.Windows.Forms.NumericUpDown bt_in;
        private System.Windows.Forms.GroupBox chartBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox wtBox;
        private System.Windows.Forms.TextBox tatBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn processID;
        private System.Windows.Forms.DataGridViewTextBoxColumn atValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn btValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn tatValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn wtValue;
        private System.Windows.Forms.DataGridView recordTable2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel gcPane;
    }
}