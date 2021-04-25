using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace infSec10_programmingHeadquarters
{
    public partial class Form1 : Form
    {
        string up = "ЙЦУКЕНГШЩЗФЫВАПРОЛДЯЧСМИТЬQWERTYUIOPASDFGHJKLXCVBNM";
        string low = "йцукенгшщзфывапролдячсмитьqwertyuiopasdfghjklzxcvbnm";
        string num = "1234567890";
        string spec = " !@#$%^&*()_+-=[]{}<>?№;:\"\'";
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e) //проверка пароля
        {
            label1.Text = CheckingResult(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox1.Text = "";
            checkUp.Checked = true;
        }

        private void NumLength_ValueChanged(object sender, EventArgs e)
        {
            Generation();
        }

        private void CheckUp_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBoxes();
            Generation();
        }

        private void CheckLow_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBoxes();
            Generation();
        }

        private void CheckNum_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBoxes();
            Generation();
        }

        private void CheckSpec_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBoxes();
            Generation();
        }

        private void CheckCheckBoxes()//проверка, чтобы хоть один из checkBox-ов был отмечен
        {
            if (checkUp.Checked == false && checkLow.Checked == false &&
                checkNum.Checked == false && checkSpec.Checked == false)
                checkUp.Checked = true;
        }

        private void Generation()//генерация пароля
        {
            up = "QWERTYUIOPASDFGHJKLXCVBNM";
            low = "qwertyuiopasdfghjklzxcvbnm";
            Random rnd = new Random();
            string symbolBase = "";
            string password = "";
            if (checkUp.Checked) 
            {
                password += up[rnd.Next(0, up.Length)];
                symbolBase += up;
            }
            if (checkLow.Checked)
            {
                password += low[rnd.Next(0, low.Length)];
                symbolBase += low;
            }
            if (checkNum.Checked)
            {
                password += num[rnd.Next(0, num.Length)];
                symbolBase += num;
            }
            if (checkSpec.Checked)
            {
                password += spec[rnd.Next(0, spec.Length)];
                symbolBase += spec;
            }
            for (int i = password.Length; i < numLength.Value; i++)
                password += symbolBase[rnd.Next(0, symbolBase.Length)];
            result.Text = password;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Generation();
        }

        private string CheckingResult(string pswrd)
        {
            up = "ЙЦУКЕНГШЩЗФЫВАПРОЛДЯЧСМИТЬQWERTYUIOPASDFGHJKLXCVBNM";
            low = "йцукенгшщзфывапролдячсмитьqwertyuiopasdfghjklzxcvbnm";
            string resultStr = "Длина пароля: " + pswrd.Length;
            bool upBool = false, lowBool = false, numBool = false, specBool = false;
            foreach (char symbol in pswrd)
            {
                foreach (char up1 in up)
                {
                    if (symbol.Equals(up1))
                    {
                        upBool = true;
                        break;
                    }
                }
                foreach (char low1 in low)
                {
                    if (symbol.Equals(low1))
                    {
                        lowBool = true;
                        break;
                    }
                }
                foreach (char num1 in num)
                {
                    if (symbol.Equals(num1))
                    {
                        numBool = true;
                        break;
                    }
                }
                foreach (char spec1 in spec)
                {
                    if (symbol.Equals(spec1))
                    {
                        specBool = true;
                        break;
                    }
                }
            }
            if (upBool) resultStr += "\nВерхний регистр задействован.";
            else resultStr += "\nВерхний регистр не задействован.";
            if (lowBool) resultStr += "\nНижний регистр задействован.";
            else resultStr += "\nНижний регистр не задействован.";
            if (numBool) resultStr += "\nЦифры задействованы.";
            else resultStr += "\nЦифры не задействованы.";
            if (specBool) resultStr += "\nСпецсимволы задействованы.";
            else resultStr += "\nСпецсимволы не задействованы.";
            return resultStr;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Файл должен содержать по одному паролю в строке, " +
                "иначе отчет будет отражать некорректные данные.", "Внимание", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            else
            {
                textBox2.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox2.Text))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Отчеты");
                StreamReader reader = new StreamReader(textBox2.Text);
                string dateStr = DateTime.Now.ToLongDateString().Replace(" г.", "");
                StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + 
                    "\\Отчеты\\Отчет от " + dateStr + ".txt");
                while (!reader.EndOfStream)
                {
                    string p = reader.ReadLine();
                    writer.WriteLine(p + "\n" + CheckingResult(p));
                }
                writer.Close();
                reader.Close();
                Process.Start(Directory.GetCurrentDirectory() +
                    "\\Отчеты\\Отчет от " + dateStr + ".txt");
            }
            else MessageBox.Show("Указанный файл не существует.", "Ошибка", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
