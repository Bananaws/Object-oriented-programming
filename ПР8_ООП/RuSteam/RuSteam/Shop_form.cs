using RuSteam_Settings;
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
namespace RuSteam
{
    public partial class Shop_form : Form
    {
        private Configuration configuration;
        public IAccount Account;
        public Shop_form(Configuration config, IAccount acc)
        {
            InitializeComponent();
            configuration = config;
            Account = acc;
            ShowAllGames();
        }
        private void ShowAllGames()
        {
            var games = GetAllGames();
            foreach (var game in games)
            {
                ListViewItem item = MakeNewItem(game);
                listView1.Items.Add(item);
            }
        }
        private IEnumerable<IGame> GetAllGames()
        {
            IShop shop = configuration.Container.GetInstance<IShop>();
            var games = shop.GetAllGames();
            return games;
        }
        private ListViewItem MakeNewItem(IGame game)
        {
            ListViewItem item = new ListViewItem(game.Game_name);
            item.SubItems.Add(game.Game_tags);
            item.SubItems.Add(game.Game_description);
            item.SubItems.Add(game.Game_price.ToString());
            return item;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            IShop shop = configuration.Container.GetInstance<IShop>();
            string game;
            try
            {
                game = listView1.SelectedItems[0].SubItems[0].Text;
            }
            catch
            {
                return;
            }
            int price = int.Parse(listView1.SelectedItems[0].SubItems[3].Text);
            if (Account.Money >= price)
            {
                shop.AddGame(Account, game, price);
                Account.Money -= price;
                if (Account.Games == "None") Account.Games = game;
                else Account.Games += $";{game}";
                MessageBox.Show("Поздравляем с покупкой!");
            }
            else MessageBox.Show($"Недостаточно средств (нехватает {price - Account.Money} руб)");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            listView1.Items.Clear();
            ShowCertainGames(str);
        }
        private void ShowCertainGames(string input)
        {
            var games = GetAllGames();
            foreach (var g in games)
            {
                if (input != "")
                {
                    if (g.Game_name.ToLower().Contains(input.ToLower()) || g.Game_tags.ToLower().Contains(input.ToLower()))
                    {
                        ListViewItem item = MakeNewItem(g);
                        listView1.Items.Add(item);
                    }
                }
                else ShowAllGames();
            }
        }
    }
}
