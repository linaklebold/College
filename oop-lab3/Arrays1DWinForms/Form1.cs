using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays1DWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] arr;
        private void Button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDownCount.Value);
            arr = new double[n];
            dataGridViewArray.RowCount = 1;
            dataGridViewArray.ColumnCount = n;
            Random rnd = new Random();
            for(int i = 0; i<arr.Length; i++)
            {
                arr[i] = rnd.Next(-142, 183) / 10.0;
                dataGridViewArray[i, 0].Value = arr[i];
                dataGridViewArray.Columns[i].HeaderText = i.ToString();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += i;
                }
            }

            double temp;
            int k = Convert.ToInt32(numericUpDownSort.Value);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < k - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            for (int j = 0; j < k; j++)
            {
                dataGridViewArray[j, 0].Value = arr[j];
            }

            textBoxSumma.Text = sum.ToString();
        }


    }
}
