using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RuSteam_BII;
using RuSteam_DI;
using RuSteam_Settings;

namespace RuSteam
{
    public partial class Profile_form : Form
    {
        private Configuration configuration;
        public IAccount account;

        public Profile_form(Configuration config, IAccount acc)
        {
            InitializeComponent();
            configuration = config;
            account = acc;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                account.Deposit(a);
                IShop shop = configuration.Container.GetInstance<IShop>();
                shop.UploadAccount(account);
            }
            catch
            {
                MessageBox.Show("Введите необходимую сумму");
            }
        }
    }
}
