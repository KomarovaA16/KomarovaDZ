using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomarovaExam
{
    public partial class Form1 : Form
    {
        bool isRunning;
        string x;
        string ans;
        int qty;
        static Random random = new Random();
        int a;
        int b;
        int trys;
        List<string> nums = new List<string>() { };
        DateTime date1 = new DateTime(0, 0);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isRunning)
            { 
            if(e.KeyValue == (char)Keys.Enter)
            {
                a = 0;
                b = 0;
                ans = textBox1.Text;
                trys += 1;
                toolStripStatusLabel1.Text = $"Попыток: {trys}";

                for (int i = 0; i < qty; i++)
                    if (x[i] == ans[i]) a++;

                foreach (string j in nums)
                    if (ans.Contains(j)) b++;

                labelB.Text = $"Угадано цифр: {b}";
                labelA.Text = $"Из них на своих местах: {a}";

                    if (x == ans) { label1.Text = "Победа!"; isRunning = false; StButton.Text = "Старт"; timer1.Enabled = false; }
            }
            }
        }

        private void StButton_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;
                Start();
                date1 = new DateTime(0, 0);
                timer1.Enabled = true;
                StButton.Text = "Стоп";

            }
            else
            {
                isRunning = false;
                StButton.Text = "Старт";
                timer1.Enabled = false;
            }
        }

        string StringList(List<string> l)
        {
            string s = "";
            foreach (string i in l)
                s += i;
            return s;
        }

        private void Start()
        {

            trys = 0;
            toolStripStatusLabel1.Text = $"Попыток: {trys}";
            label1.Text = "Угадайте задуманное компьютером число";
            isRunning = true;
            textBox1.Clear();
            if (qty == 3)
                x = random.Next(100, 1000).ToString();
            else if (qty == 4)
                x = random.Next(1000, 10000).ToString();
            else if (qty == 5)
                x = random.Next(10000, 100000).ToString();
            else if (qty == 5)
                x = random.Next(100000, 1000000).ToString();
            
            foreach(char i in x)
            {
                string si = i.ToString();
                if (!nums.Contains(si)) nums.Add(si);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                string i = comboBox1.SelectedItem.ToString();
                qty = int.Parse(i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date1 = date1.AddSeconds(1);
            toolStripStatusLabel2.Text ="Время: " + date1.ToString("mm:ss");
        }

        private void labelA_Click(object sender, EventArgs e)
        {

        }
    }
}
