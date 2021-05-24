using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yt_DesignUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void egoldsGoogleTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {

        }

        private void yt_Button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Otchet_Button_Click(object sender, EventArgs e)
        {
            Otchet otchetForm = new Otchet();
            otchetForm.Show();
            
        }

        private void Formii_Button_Click(object sender, EventArgs e)
        {
            Formii formii = new Formii();
            formii.Show();
        }

        private void AboutProgramm_Click(object sender, EventArgs e)
        {
            AboutProgramm aboutProgramm = new AboutProgramm();
            aboutProgramm.Show();
        }
    }
}
