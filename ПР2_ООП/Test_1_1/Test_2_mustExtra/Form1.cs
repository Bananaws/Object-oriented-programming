namespace Test_2_mustExtra
{
    public partial class Form1 : Form
    {
        public static int NOD(params int[] vals) // ����� ��� ���������� ����������� ������ �������� (�������� �������)
        {
            // ��������� �������� ����� params, �� ����� ���������� �������������� ���������� ����������
            int count = 0;
            int a = 0;
            foreach (int v in vals)
            {
                if (count == 0) // ������ �����
                {
                    count++;
                    a = v;
                    continue;
                }

                int b = v; // ������ ��������� ������� �������
                // ��������� ��� �������� �������
                if (a == 0)
                {
                    a = b;
                    continue;
                }
                while (b != 0)
                {
                    if (a > b) a -= b;
                    else b -= a;
                }
            }
            return a;
        }
        public void output_for_button() // ����� ��� ����� ����� ������� ������
        {
            string[] array = textBox1.Text.Split(" "); // ������ ����� ����������� ���������� � ������
            int[] conv_int_array;
            try // ���������, ����� ������ �� int
            {
                conv_int_array = Array.ConvertAll(array, int.Parse); // ������������ ������ ������� � �������������
            }
            catch(FormatException) //����� ������ �������� ������
            {
                MessageBox.Show("�������� ������, ���������!");
                return;
            }
            if (conv_int_array.Length < 2) // ������������� ���� ������ 2� �����
            {
                MessageBox.Show("����� ������ �� ����� ����");
                return;
            }
            label2.Text = NOD(conv_int_array).ToString(); // ������� � ���� ������ � label2

        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            output_for_button();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}