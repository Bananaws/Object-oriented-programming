using RuSteam_DI;
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
using RuSteam_BII;

namespace RuSteam
{
    public partial class Library_form : Form
    {
        private Configuration configuration;
        public IAccount account;
        public Library_form(Configuration config, IAccount acc)
        {
            InitializeComponent();
            configuration = config;
            account = acc;
            ShowAllGames();
        }
        private ListViewItem MakeNewItem(string game)
        {
            ListViewItem item = new ListViewItem(game);
            return item;
        }
        private void ShowAllGames()
        {
            string games = account.Games;
            string word = "";
            ListViewItem item;
            foreach (var g in games)
            {
                
                if (g !=';')
                {
                    word += g;
                }
                else
                {
                    item = MakeNewItem(word);
                    listView1.Items.Add(item);
                    word = "";
                }
                
            }
            item = MakeNewItem(word);
            listView1.Items.Add(item);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
