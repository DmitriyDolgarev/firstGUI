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
            try // ����������� ����� ���� �������� � �������
            {
                first = int.Parse(this.firstValue.Text);
                second = int.Parse(this.secondValue.Text);
                third = int.Parse(this.thirdValue.Text);
            }
            catch (FormatException) // ��� ������, ������� �������������
            {
                MessageBox.Show("������������ ����!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // ��������� ���������� �����, ���� ����� �����-�� ������
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
                outMessage += "����� ������� �����: " + first + "\n";
            }
            else if (second > first && second > third)
            {
                outMessage += "����� ������� �����: " + second + "\n";
            }
            else
            {
                outMessage += "����� ������� �����: " + third + "\n";
            }

            if (first < second && first < third)
            {
                outMessage += "����� ��������� �����: " + first + "\n";
            }
            else if (second < first && second < third)
            {
                outMessage += "����� ��������� �����: " + second + "\n";
            }
            else
            {
                outMessage += "����� ��������� �����: " + third + "\n";
            }

            if (first < second && first > third || first < third && first > second)
            {
                outMessage += "������� �����: " + first + "\n";
            }
            else if (second < third && second > first || second < first && second > third)
            {
                outMessage += "������� �����: " + second + "\n";
            }
            else
            {
                outMessage += "������� �����: " + third + "\n";
            }
            return outMessage;
        }
    }
}
