using Pattern_Strategy.Strategy;
using System.Text;

namespace Pattern_Strategy
{
    public partial class Form1 : Form
    {
        Hero hero;
        StringBuilder str;
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Gun");
            listBox1.Items.Add("Bow");
            listBox1.Items.Add("Sword");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") 
            {
                MessageBox.Show("Дайте имя герою");
                return;
            }
            hero = new(textBox1.Text);
            IWeapon? weapon = null;
            if (listBox1.SelectedItem is null) { MessageBox.Show("Выберите оружие"); return; }
            switch(listBox1.SelectedItem.ToString())
            {
                case "Gun":
                    weapon = new Gun();
                    break;
                case "Bow":
                    weapon = new Bow();
                    break;
                case "Sword":
                    weapon = new Sword();
                    break;
            }
            hero.SetWeapon(weapon);
            str = hero.Attack();
            richTextBox1.Text = str.ToString();
        }
    }
}