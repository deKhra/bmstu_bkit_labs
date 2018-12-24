using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace lab5
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
                fileTimeBox.Text = watch.Elapsed.ToString();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String word = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(word))
            {
                int maxDist = int.Parse(DistanceBox.Text.Trim());
                //подготовка списка
                listBox1.BeginUpdate();
                listBox1.Items.Clear();
                //запуск таймера
                Stopwatch watch = new Stopwatch();
                watch.Start();
            
                foreach (String line in words)
                {
                    if (DLDistance.Distance(word, line) <= maxDist)
                    {
                        listBox1.Items.Add(line);
                    
                    }
                }
                listBox1.EndUpdate();
                watch.Stop();
                searchTimeBox.Text = watch.Elapsed.ToString();
            }
        }
    }
}
