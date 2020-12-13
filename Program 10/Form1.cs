using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Program_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> Array = new List<int>();
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Array.Add(Convert.ToInt32(textBox1.Text)); // записываем значение в массив
            listBox1.Items.Add(Convert.ToInt32(textBox1.Text));// отображает значение в ListBox
            textBox1.Clear();



        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int max = Array.Max(); // до делать 
            textBox2.Text = max.ToString();
            int Index = Array.IndexOf(max);
            textBox3.Text = (++Index).ToString();
           
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа № 10\n" +
                            "Серегин Денис \n" +
                            "ИСП-31\n" +
                            "Задание \n" +
                            "Составьте программу вычисления в массиве максимального среди отрицательных элементов и его номера. ", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Array.Clear();
        }
    }
}
