using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace lab4
{
    public partial class Form1 : Form
    {
        List<String> words = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "текстовые файлы|*.txt";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                string text = File.ReadAllText(fd.FileName);

                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };
                string[] textArray = text.Split(separators);

                foreach (string strTemp in textArray)
                {           
                    string str = strTemp.Trim().ToLower();         
                    if (!words.Contains(str)) words.Add(str);
                }
                watch.Stop();
                label1.Text = "Текст считан за " + watch.Elapsed.ToString();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String word = textBox1.Text;

            Stopwatch watch = new Stopwatch();
            listBox1.BeginUpdate();
            bool isFound = false;
            watch.Start();
            listBox1.Items.Clear();
            foreach (String line in words)
            {
                if (line.Contains(word))
                {

                    listBox1.Items.Add(line);

                    isFound = true;
                }
            }
            if(!isFound) MessageBox.Show("Слово не найдено");
            listBox1.EndUpdate();
            watch.Stop();
            label3.Text = "Поиск выполнен за " + watch.Elapsed.ToString();
        }
    }
}
