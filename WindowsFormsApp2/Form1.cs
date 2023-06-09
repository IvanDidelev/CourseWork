using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Linq.Expressions;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string m = textBox1.Text;

            int nomer; // Номер в алфавите
            int d; // Смещение
            string s; //Результат
            int j; // Переменная для циклов

            char[] massage = m.ToCharArray(); // Превращаем строку в массив символов.

            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            // Перебираем каждый символ сообщения
            for (int i = 0; i < massage.Length; i++)
            {
                // Ищем индекс буквы
                for (j = 0; j < alfavit.Length; j++)
                {
                    if (massage[i] == alfavit[j])
                    {
                        break;
                    }
                }

                if (j != 33) // Если j равно 33, значит символ не из алфавита
                {
                    nomer = j; // Индекс буквы
                    d = nomer + 3; // Делаем смещение

                    // Проверяем, чтобы не вышли за пределы алфавита
                    if (d > 32)
                    {
                        d = d - 33;
                    }

                    massage[i] = alfavit[d]; // Меняем букву
                }
            }

            s = new string(massage); // Собираем символы обратно в строку.
            label1.Text = s;
            stopwatch.Stop();

            TimeSpan timeSpan = stopwatch.Elapsed;
            MessageBox.Show($"Время исполнения шифрования: {timeSpan}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }

        }
        private void VisitLink()
        {
            
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://cryptoperson.ru/cryptography/shifrovanie-teksta");
        }
    }
}
