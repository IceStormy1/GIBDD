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
    public partial class AboutProgramm : Form
    {
        public AboutProgramm()
        {
            InitializeComponent();
        }

        private void AboutProgramm_button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
