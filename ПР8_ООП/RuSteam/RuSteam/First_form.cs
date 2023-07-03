using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RuSteam_DI;
using RuSteam_Settings;

namespace RuSteam
{
    public partial class First_form : Form
    {
        Enter_account_form enter_acc_f;
        Registration_form registration_f;
        public First_form()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            enter_acc_f = new Enter_account_form();
            enter_acc_f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            registration_f = new Registration_form();
            registration_f.Show();
        }
    }
}
