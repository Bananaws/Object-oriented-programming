using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using RuSteam_DI;
using RuSteam_Settings;
using RuSteam_BII;
namespace RuSteam
{
    public partial class Main_form : Form
    {
        private Configuration configuration;
        public static IAccount account;
        Shop_form shop_f;
        Library_form library_f;
        Profile_form profile_f;
        public Main_form(Configuration config, IAccount acc)
        {
            InitializeComponent();
            configuration = config;
            account = acc;
            label1.Text = $"{acc.Money} руб";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            shop_f = new Shop_form(configuration, account);
            shop_f.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            library_f = new Library_form(configuration, account);
            library_f.Show();
        }
        public void button3_Click(object sender, EventArgs e)
        {
            profile_f = new Profile_form(configuration, account);
            profile_f.Show();
        }

        public void label1_Click(object sender, EventArgs e)
        {
            label1.Text = $"{account.Money} руб";
        }
    }
}
