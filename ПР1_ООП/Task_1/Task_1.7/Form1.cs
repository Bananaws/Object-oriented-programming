using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Task_1._7
{
    public partial class Form1 : Form
    {
        private void Text_check() // ����� ��� �������� ����� �� ������������ ������� �������
        {
            int input;
            double input2;
            bool res = double.TryParse(textBox1.Text, out input2); // ����������� ��, ��� �����, � ����� double
            if (res == true) // ���� �������������� ������ �������
            {
                input = (int)input2; // ������ ����� ��������������
                if (input - input2 == 0) // ���� �� �������� ������� �����, �� ������� �����
                    MessageBox.Show("���� ����� �� ������������ ������� �������");
                else
                    MessageBox.Show($"�� ����� ����� ������������ �����: {input2}");
  
            }
            else
                MessageBox.Show("���� ����� �� ������������ ������� �������");
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e) // ����, ���� �� ���������
        {
            
        }
        private void button1_Click(object sender, EventArgs e) // ������ ("����"), ����� ������� ������� ��������� �����
        {
            Text_check(); // ����������� ��� �����
        }
    }
}