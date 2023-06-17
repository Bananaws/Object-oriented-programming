namespace Test_1
{
    public partial class Form1 : Form
    {
        public static int NOD(int a, int b) // ����� ������� ��� ���� ����������
        {
            if (a == 0) return b;
            while (b != 0)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(textBox1.Text, out var num1))) // �������� ����� ������� �����
            {
                MessageBox.Show("�������, ��������� ����");
                return;
            }
            else
            {
                if (!(int.TryParse(textBox2.Text, out var num2))) // �������� ����� ������� �����
                {
                    MessageBox.Show("�������, ��������� ����");
                    return;
                }
                else 
                {
                    label1.Text = "��� = " + NOD(num1, num2).ToString(); // ����� ������ NOD � ���� ������
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}