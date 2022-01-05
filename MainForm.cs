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
    public partial class MainForm : Form
    {
        private Form activeForm;
        private bool srtfClicked = false;
        public MainForm()
        {
            InitializeComponent();
        }

        /*
         *  Open a child form inside the parent form
         */

        private void OpenChildForm(Form childForm, object btnSender) // Source: https://www.youtube.com/watch?v=BtOEztT1Qzk&list=PLwG-AtjFaHdMi6wceN1_atblW-B4R-llj&t=891s
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.viewPanel.Controls.Add(childForm);
            this.viewPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /*
         *  Home Form/Button
         */
        private void Home_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainForm(), sender);
            top_panel.Visible = false;
        }

        /*
         *  SRTF Form/Button
         */

        private void SRTF_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Srtf(), sender);
            srtfClicked = true;
            if(srtfClicked)
            {
                SRTF_btn.Enabled = false;
                SRTF_btn.BackColor = Color.FromArgb(120,120,120);
            }
        }

        /*
         *  About Form/Button
         */

        private void About_btn_Click(object sender, EventArgs e)
        {
            // source: https://www.youtube.com/watch?v=jB8q__utFwA
            Form formbg = new();
            try
            {
                using About about = new();
                formbg.StartPosition = FormStartPosition.CenterScreen;
                formbg.FormBorderStyle = FormBorderStyle.FixedDialog;
                formbg.Opacity = 0.0d;
                formbg.BackColor = Color.FromArgb(40, 40, 40);
                formbg.WindowState = FormWindowState.Normal;
                formbg.TopMost = true;
                formbg.Location = this.Location;
                formbg.ShowInTaskbar = false;
                formbg.Show();

                about.Owner = formbg;
                about.ShowDialog();

                formbg.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formbg.Dispose();
            }
        }
    }
}
