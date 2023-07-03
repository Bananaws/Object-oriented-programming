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

namespace RuSteam
{
    
    public partial class Enter_account_form : Form
    {
        private Configuration configuration;
        Main_form main_form;
        public Enter_account_form()
        {
            InitializeComponent();
            configuration = new Configuration();
        }
        private IAccount InitializeAccount()
        {
            IAccount account = configuration.Container.GetInstance<IAccount>();
            account.Nick_name = textBox1.Text;
            account.Password = textBox2.Text;
            return account;
        }
        private IAccount FindAccountInDatabase()
        {
            IShop shop = configuration.Container.GetInstance<IShop>();
            IAccount foundAccount = InitializeAccount();
            foundAccount = shop.FindCurrentAccount(foundAccount);
            return foundAccount;
        }

        private void Enter_button_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите логин!", "Ошибка ввода");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Введите пароль!", "Ошибка ввода");
            }
            IAccount acc = configuration.Container.GetInstance<IAccount>();
            acc.Nick_name = textBox1.Text;
            acc.Password = textBox2.Text;
            acc = FindAccountInDatabase();
            if (acc == null)
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка ввода");
            }
            else
            {
                main_form = new Main_form(configuration, acc);
                main_form.Text = acc.Nick_name;
                main_form.Show();
                this.Close();
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
