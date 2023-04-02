namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int _counter;
        string _result;
        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
            _counter++;
            _result += message;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowMessage("Нажмите на кнопку 2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            ShowMessage("Нажмите на кнопку 3");

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            ShowMessage("Будет фокус:");   
            ShowMessage("Вы бот на пк установлен вирус. Удачи!");
            MessageBox.Show($"{_result.Length / _counter}");
            Close();
            
        }
    }
}