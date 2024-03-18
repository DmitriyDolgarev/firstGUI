namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int first, second, third;
            try // оборачиваем кусок кода склонный к падению
            {
                first = int.Parse(this.firstValue.Text);
                second = int.Parse(this.secondValue.Text);
                third = int.Parse(this.thirdValue.Text);
            }
            catch (FormatException) // тип ошибки, которую перехватываем
            {
                MessageBox.Show("Некорректный ввод!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // прерываем обработчик клика, если ввели какую-то ерунду
            }
            first = int.Parse(this.firstValue.Text);
            second = int.Parse(this.secondValue.Text);
            third = int.Parse(this.thirdValue.Text);

            Properties.Settings.Default.first = first;
            Properties.Settings.Default.second = second;
            Properties.Settings.Default.third = third;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.Calculate(first, second, third));
        }
    }
    public class Logic
    {
        public static string Calculate(int first, int second, int third)
        {
            string outMessage = "";
            if (first > second && first > third)
            {
                outMessage += "Самое большое число: " + first + "\n";
            }
            else if (second > first && second > third)
            {
                outMessage += "Самое большое число: " + second + "\n";
            }
            else
            {
                outMessage += "Самое большое число: " + third + "\n";
            }

            if (first < second && first < third)
            {
                outMessage += "Самое маленькое число: " + first + "\n";
            }
            else if (second < first && second < third)
            {
                outMessage += "Самое маленькое число: " + second + "\n";
            }
            else
            {
                outMessage += "Самое маленькое число: " + third + "\n";
            }

            if (first < second && first > third || first < third && first > second)
            {
                outMessage += "Среднее число: " + first + "\n";
            }
            else if (second < third && second > first || second < first && second > third)
            {
                outMessage += "Среднее число: " + second + "\n";
            }
            else
            {
                outMessage += "Среднее число: " + third + "\n";
            }
            return outMessage;
        }
    }
}
