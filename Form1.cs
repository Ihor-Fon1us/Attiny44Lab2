using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace VS
{
    public partial class Form1 : Form
    {
        SerialPort port;

        public Form1()
        {
            InitializeComponent();
            
            try
            {
                port = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
                port.Open();
                port.NewLine = "\r";
            }
            catch (Exception)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                MessageBox.Show("Порт не підключений");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (checkBox1.Checked) a += 8;
            if (checkBox2.Checked) a += 4;
            if (checkBox3.Checked) a += 2;
            if (checkBox4.Checked) a++;
            port.WriteLine("0" + a.ToString("X"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (checkBox1.Checked) a += 8;
            if (checkBox2.Checked) a += 4;
            if (checkBox3.Checked) a += 2;
            if (checkBox4.Checked) a++;
            port.WriteLine("1" + a.ToString("X"));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (checkBox1.Checked) a += 8;
            if (checkBox2.Checked) a += 4;
            if (checkBox3.Checked) a += 2;
            if (checkBox4.Checked) a++;
            port.WriteLine("2" + a.ToString("X"));
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            port.Close();
        }
    }
}
