namespace Task6_3
{
    public partial class Form1 : Form
    {
        // ������ ���������� �������
        Account account = new Account();
        Activity activity = new Activity();

        public Form1()
        {
            InitializeComponent();
        }

        async void Calculate(object? obj, double balance) // ����������� ����� � ��������� ������������� ������� ��� ������ ��������� �����
        {
            label4.Text = $"�������� �� ��������� ���: 3 �������.";
            await Task.Delay(1000); // �������� ��������������� ������
            label4.Text = $"�������� �� ��������� ���: 2 �������.";
            await Task.Delay(1000); // �������� ��������������� ������
            label4.Text = $"�������� �� ��������� ���: 1 �������.";
            await Task.Delay(1000); // �������� ��������������� ������
            label4.Text = "";
            label3.Text = $"����: {balance}"; // ������� ���� ��������

        }
        private void Add_Click(object sender, EventArgs e)
        {
            account.AddedEvent += Calculate; // ������������� �� ������� ������� ����������
            account.AddedEvent += activity.UpdateActivity; // ������������� �� ������� ������� �������� �� ������ ����������
            double num;
            if (textBox1.Text != "")
            {
                num = double.Parse(textBox1.Text);
                account.Add(num);
                label1.Text = $"����� ���������: {activity.added}"; // ����� ����� ���������� �� ������ ������
                // ����� �������� ������ ������, ���������.
                account.AddedEvent -= Calculate; // ������������
                account.AddedEvent -= activity.UpdateActivity; // ������������
            }
            else return;

        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            account.TakenEvent += Calculate; // ������������� �� ������� ������� ����������
            account.TakenEvent += activity.UpdateActivity; // ������������� �� ������� ������� �������� �� ������ ����������
            double num;
            if (textBox2.Text != "")
            {
                num = double.Parse(textBox2.Text);
                account.Take(num);
                label2.Text = $"����� �������: {activity.taken}"; // ����� ����� �������� �� ������ ������
                // ����� �������� ������ ������, ���������.
                account.TakenEvent -= Calculate; // ������������
                account.TakenEvent -= activity.UpdateActivity; // ������������
            }
            else return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}