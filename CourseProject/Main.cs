using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{

    public partial class Main : Form
    {
        private Language language = Language.RUSSIAN;

        private int nextCharIdx;
        private bool isRunningTest = false;
        private int errors = 0;
        private int testTime = 0;
        public Main()
        {
            InitializeComponent();
        }

        private void темнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            foreach (Control c in Controls)
            {
                c.BackColor = Color.Black;
                c.ForeColor = Color.White;
            }
            errorLabel.ForeColor = Color.Red;
        }

        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
            foreach (Control c in Controls)
            {
                c.BackColor = Color.White;
                c.ForeColor = Color.Black;
            }
            errorLabel.ForeColor = Color.Red;
        }

        private void английскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            language = Language.ENGLISH;
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            language = Language.RUSSIAN;
        }
        public void testEnd(bool byUser = false)
        {
            if (byUser)
            {
                MessageBox.Show("Вы остановили тест");
                isRunningTest = false;
                timer.Stop();
                textBox1.ReadOnly = true;
                textBox1.Text = "";
                return;
            }
            isRunningTest = false;
            timer.Stop();
            textBox1.ReadOnly = true;
            string timeTaken = Logics.convertTime(testTime);
            string result = $"Длина текста:{textLabel.Text.Length} Время:{timeTaken} Ошибок:{errors}";
            MessageBox.Show(result);
            DbService.SaveResult(textLabel.Text.Length,testTime, timeTaken,errors,language);
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            string text = "";
            if (RandTextRB.Checked)
            {
                text = Logics.pickRandomText(language);

            }
            else if (TextFFileRB.Checked)
            {
                MessageBox.Show(text: "Убедитесь, что текст в Вашем файле разделен по строкам!", caption: "Важно");
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        text = Logics.LoadTextFromFile(openFileDialog1.FileName);
                        language = Language.USERS;
                    }
                    catch (Exception ex)
                    {
                        if(ex.Message == "incorrect length")
                        {
                            MessageBox.Show($"Минимальная длина должна составлять {TextService.minLength} символов!", caption: "Ошибка");
                        }
                        else if (ex.Message == "incorrect file format")
                        {
                            MessageBox.Show("Выберите текстовый файл!", caption: "Ошибка");
                        }
                        language = Language.RUSSIAN;
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите режим загрузки текста!");
                return;
            }
            textLabel.Text = text;
            textLengthLabel.Text = $"Количество символов: {text.Length}";
            nextCharIdx = 0;
            timeLabel.Text = "0";
            isRunningTest = true;
            textBox1.ReadOnly = false;
            errors = 0;
            testTime = 0;
            timer.Start();
            textBox1.Focus();
        }
        public void HandleSpecificChars(char ch)
        {
            if (ch == ' ')
            {
                textBox1.Text = "";
            }
            if (textLabel.Text[nextCharIdx] == '\r')
            {
                nextCharIdx += 2;
                textBox1.Text = "";
            }
        }
        public void checkEndTest()
        {
            if (nextCharIdx >= textLabel.Text.Length)
            {
                testEnd();
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isRunningTest)
            {
                char ch = e.KeyChar;
                char nextChar = textLabel.Text[nextCharIdx];
                if (ch == nextChar)
                {
                    char[] chars = textLabel.Text.ToCharArray();
                    chars[nextCharIdx] = '*';
                    textLabel.Text = new string(chars);
                    nextCharIdx++;
                    checkEndTest();
                    errorLabel.Text = "";
                }
                else
                {
                    errors++;
                    errorLabel.Text = "Ошибка!";
                    e.Handled = true;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            testTime++;
            timeLabel.Text = Logics.convertTime(testTime);

        }

        private void оТестеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проект был разработан Блонским Ярославом");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            HandleSpecificChars((char)e.KeyValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isRunningTest)
                testEnd(true);
        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Results rForm = new Results();
            rForm.Show();
        }
    }
}
