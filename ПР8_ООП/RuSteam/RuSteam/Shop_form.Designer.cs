namespace RuSteam
{
    partial class Shop_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop_form));
            listView1 = new ListView();
            name = new ColumnHeader();
            tags = new ColumnHeader();
            description = new ColumnHeader();
            price = new ColumnHeader();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(0, 0, 64);
            listView1.Columns.AddRange(new ColumnHeader[] { name, tags, description, price });
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.ForeColor = SystemColors.Window;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(1254, 571);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // name
            // 
            name.Text = "Название";
            name.Width = 250;
            // 
            // tags
            // 
            tags.Text = "Теги";
            tags.Width = 300;
            // 
            // description
            // 
            description.Text = "Описание";
            description.Width = 600;
            // 
            // price
            // 
            price.Text = "Цена";
            price.Width = 100;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1352, 507);
            button1.Name = "button1";
            button1.Size = new Size(148, 76);
            button1.TabIndex = 5;
            button1.Text = "Купить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1272, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 27);
            textBox1.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.Indigo;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1352, 83);
            button2.Name = "button2";
            button2.Size = new Size(139, 78);
            button2.TabIndex = 7;
            button2.Text = "Поиск";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Shop_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1580, 699);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Shop_form";
            Text = "МАГАЗИН";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader name;
        private ColumnHeader tags;
        private ColumnHeader description;
        private ColumnHeader price;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
    }
}