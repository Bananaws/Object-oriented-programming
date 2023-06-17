namespace Task6_3
{
    public partial class Form1 : Form
    {
        // Создаём экземпляры классов
        Account account = new Account();
        Activity activity = new Activity();

        public Form1()
        {
            InitializeComponent();
        }

        async void Calculate(object? obj, double balance) // асинхронный метод – экономное использование потоков для выноса отдельных задач
        {
            label4.Text = $"Операция на удержании ещё: 3 секунды.";
            await Task.Delay(1000); // имитация продолжительной работы
            label4.Text = $"Операция на удержании ещё: 2 секунды.";
            await Task.Delay(1000); // имитация продолжительной работы
            label4.Text = $"Операция на удержании ещё: 1 секунды.";
            await Task.Delay(1000); // имитация продолжительной работы
            label4.Text = "";
            label3.Text = $"Счет: {balance}"; // Выводим счёт кошелька

        }
        private void Add_Click(object sender, EventArgs e)
        {
            account.AddedEvent += Calculate; // подписываемся на событие методом Рассчитать
            account.AddedEvent += activity.UpdateActivity; // подписываемся на событие методом обновить из класса активность
            double num;
            if (textBox1.Text != "")
            {
                num = double.Parse(textBox1.Text);
                account.Add(num);
                label1.Text = $"Всего пополнено: {activity.added}"; // вывод суммы пополнений на данный момент
                // чтобы избежать утечки памяти, отпишимся.
                account.AddedEvent -= Calculate; // отписываемся
                account.AddedEvent -= activity.UpdateActivity; // отписываемся
            }
            else return;

        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            account.TakenEvent += Calculate; // подписываемся на событие методом Рассчитать
            account.TakenEvent += activity.UpdateActivity; // подписываемся на событие методом обновить из класса активность
            double num;
            if (textBox2.Text != "")
            {
                num = double.Parse(textBox2.Text);
                account.Take(num);
                label2.Text = $"Всего списано: {activity.taken}"; // вывод суммы списаний на данный момент
                // чтобы избежать утечки памяти, отпишимся.
                account.TakenEvent -= Calculate; // отписываемся
                account.TakenEvent -= activity.UpdateActivity; // отписываемся
            }
            else return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}