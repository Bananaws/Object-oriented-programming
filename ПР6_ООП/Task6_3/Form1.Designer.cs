namespace Task6_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Add = new Button();
            Withdraw = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuText;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(98, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaptionText;
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(98, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // Add
            // 
            Add.BackColor = Color.Lime;
            Add.Location = new Point(257, 95);
            Add.Name = "Add";
            Add.Size = new Size(112, 29);
            Add.TabIndex = 2;
            Add.Text = "Пополнить";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Withdraw
            // 
            Withdraw.BackColor = Color.Red;
            Withdraw.Location = new Point(257, 169);
            Withdraw.Name = "Withdraw";
            Withdraw.Size = new Size(112, 29);
            Withdraw.TabIndex = 3;
            Withdraw.Text = "Списать";
            Withdraw.UseVisualStyleBackColor = false;
            Withdraw.Click += Withdraw_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(392, 97);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 4;
            label1.Text = "Всего пополнено: 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(392, 169);
            label2.Name = "label2";
            label2.Size = new Size(163, 28);
            label2.TabIndex = 5;
            label2.Text = "Всего списано: 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(98, 380);
            label3.Name = "label3";
            label3.Size = new Size(128, 40);
            label3.TabIndex = 6;
            label3.Text = "Счёт: 0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.SpringGreen;
            label4.Location = new Point(98, 295);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Withdraw);
            Controls.Add(Add);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Кошелёк";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button Add;
        private Button Withdraw;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}