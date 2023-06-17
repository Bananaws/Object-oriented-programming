using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RuSteam_Settings;
using RuSteam_DI;
using Microsoft.VisualBasic.ApplicationServices;
using RuSteam_BII;
namespace RuSteam
{
    public partial class Registration_form : Form
    {
        private Configuration configuration;
        public Registration_form()
        {
            InitializeComponent();
            configuration = new Configuration();
        }

        private IAccount MakeNewAcc()
        {
            IShop shop = configuration.Container.GetInstance<IShop>();
            IAccount newAcc = configuration.Container.GetInstance<IAccount>();
            newAcc.Nick_name = textBox1.Text;
            if (textBox2.Text == textBox3.Text)
            {
                newAcc.Password = textBox2.Text;
            }
            newAcc.Id = shop.ReturnIdToAccount();
            return newAcc;
        }
        private void DisplayMessage(IShop sender, AccountEventArgs e)
        {
            MessageBox.Show(e.Message);
        }
        private void AddAccountToDatabase(IAccount account)
        {
            IShop shop = configuration.Container.GetInstance<IShop>();
            shop.Notify += DisplayMessage;
            shop.AddAccount(account);
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name_acc = textBox1.Text;
            string password1_acc = textBox2.Text;
            string password2_acc = textBox3.Text;
            if (name_acc != "" && password1_acc == password2_acc)
            {
                IAccount newAcc = MakeNewAcc();
                AddAccountToDatabase(newAcc);
                this.Close();
            }
            else
            {
                MessageBox.Show("Что-то пошло не так. Повторите ввод.");
            }
        }
    }
}
