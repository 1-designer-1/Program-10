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
            Array.Add(Convert.ToInt32(textBox1.Text));
            listBox1.Items.Add(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();



        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int max = Array.Max();
            textBox2.Text = max.ToString();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
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
    }
}
