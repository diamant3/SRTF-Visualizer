
namespace SRTF_Visualizer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.home_btn = new System.Windows.Forms.Button();
            this.SRTF_btn = new System.Windows.Forms.Button();
            this.about_btn = new System.Windows.Forms.Button();
            this.top_panel = new System.Windows.Forms.Panel();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.top_panel.SuspendLayout();
            this.viewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // home_btn
            // 
            this.home_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.home_btn.FlatAppearance.BorderSize = 0;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Location = new System.Drawing.Point(0, 0);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(140, 40);
            this.home_btn.TabIndex = 0;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // SRTF_btn
            // 
            this.SRTF_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SRTF_btn.FlatAppearance.BorderSize = 0;
            this.SRTF_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SRTF_btn.Location = new System.Drawing.Point(146, 0);
            this.SRTF_btn.Name = "SRTF_btn";
            this.SRTF_btn.Size = new System.Drawing.Size(140, 40);
            this.SRTF_btn.TabIndex = 1;
            this.SRTF_btn.Text = "SRTF";
            this.SRTF_btn.UseVisualStyleBackColor = true;
            this.SRTF_btn.Click += new System.EventHandler(this.SRTF_btn_Click);
            // 
            // about_btn
            // 
            this.about_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.about_btn.FlatAppearance.BorderSize = 0;
            this.about_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_btn.Location = new System.Drawing.Point(1118, 0);
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(140, 40);
            this.about_btn.TabIndex = 2;
            this.about_btn.Text = "About";
            this.about_btn.UseVisualStyleBackColor = true;
            this.about_btn.Click += new System.EventHandler(this.About_btn_Click);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.top_panel.Controls.Add(this.about_btn);
            this.top_panel.Controls.Add(this.SRTF_btn);
            this.top_panel.Controls.Add(this.home_btn);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1258, 40);
            this.top_panel.TabIndex = 0;
            // 
            // viewPanel
            // 
            this.viewPanel.Controls.Add(this.pictureBox1);
            this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPanel.Location = new System.Drawing.Point(0, 40);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(1258, 672);
            this.viewPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1258, 672);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1258, 712);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.top_panel);
            this.Font = new System.Drawing.Font("Fira Code Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRTF Visualizer";
            this.top_panel.ResumeLayout(false);
            this.viewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button SRTF_btn;
        private System.Windows.Forms.Button about_btn;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

