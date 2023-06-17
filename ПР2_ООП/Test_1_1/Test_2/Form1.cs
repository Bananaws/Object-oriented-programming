namespace Test_2
{
    public partial class Form1 : Form
    {
        // ����� �������:
        public static int NOD(int a, int b)// ������������� ����� NOD c 2 �����������
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
        public static int NOD(int a, int b, int c) // ������������� ����� NOD � 3 �����������
        {
            int d = NOD(a, b);
            int e = NOD(d, c);
            return e;
        }
        public static int NOD(int a, int b, int c, int d) // ������������� ����� NOD � 4 �����������
        { 
            int three = NOD(a, b, c);
            int e = NOD(three, d);
            return e;
        }
        public static int NOD(int a, int b, int c, int d, int e) // ������������� ����� NOD � 5 �����������
    {
            int four = NOD(a, b, c, d);
            int r = NOD(four, e);
            return r;
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
                    label1.Text = NOD(num1, num2).ToString(); // ����� ������ NOD � ���� ������
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
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
                    if (!(int.TryParse(textBox3.Text, out var num3))) // �������� ����� ������� �����
                    {
                        MessageBox.Show("�������, ��������� ����");
                        return;
                    }
                    else
                    {
                        label1.Text = NOD(num1, num2, num3).ToString(); // ����� ������ NOD � ���� ������
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
                    if (!(int.TryParse(textBox3.Text, out var num3))) // �������� ����� ������� �����
                    {
                        MessageBox.Show("�������, ��������� ����");
                        return;
                    }
                    else
                    {
                        if (!(int.TryParse(textBox4.Text, out var num4))) // �������� ����� ������� �����
                        {
                            MessageBox.Show("�������, ��������� ����");
                            return;
                        }
                        else
                        {
                            label1.Text = NOD(num1, num2, num3, num4).ToString(); // ����� ������ NOD � ���� ������
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
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
                    if (!(int.TryParse(textBox3.Text, out var num3))) // �������� ����� ������� �����
                    {
                        MessageBox.Show("�������, ��������� ����");
                        return;
                    }
                    else
                    {
                        if (!(int.TryParse(textBox4.Text, out var num4))) // �������� ����� ������� �����
                        {
                            MessageBox.Show("�������, ��������� ����");
                            return;
                        }
                        else
                        {
                            if (!(int.TryParse(textBox5.Text, out var num5))) // �������� ����� ������� �����
                            {
                                MessageBox.Show("�������, ��������� ����");
                                return;
                            }
                            else
                            {
                                label1.Text = NOD(num1, num2, num3, num4, num5).ToString(); // ����� ������ NOD � ���� ������
                            }
                        }
                    }
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}