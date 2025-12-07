using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AndreevIA.Sprint6.Task1.V5.Lib;

namespace Tyuiu.AndreevIA.Sprint6.Task1.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSpravka_AIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студент группы РППб-25-1 Андреев Иван Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        DataService ds = new DataService();
        private void buttonVipolnit_AIA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_AIA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_AIA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_AIA.Text = "";
                textBoxResult_AIA.AppendText("+----------+-----------+" + Environment.NewLine);
                textBoxResult_AIA.AppendText("|    X     +    f(x)   |" + Environment.NewLine);
                textBoxResult_AIA.AppendText("+----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}   |", startStep, valueArray[i]);
                    textBoxResult_AIA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_AIA.AppendText("+----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}