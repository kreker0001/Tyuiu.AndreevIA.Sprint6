using System.Windows.Forms.VisualStyles;
using Tyuiu.AndreevIA.Sprint6.Task2.V13.Lib;
namespace Tyuiu.AndreevIA.Sprint6.Task2.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_AIA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_AIA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_AIA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_AIA.Titles.Add("График");

                this.chartFunction_AIA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_AIA.ChartAreas[0].AxisX.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_AIA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_AIA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_AIA.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_AIA.BackColor = Color.Green;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_AIA.BackColor = Color.Blue;
        }

        private void buttonSpravka_AIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студент группы РППб-25-1 Андреев Иван Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void buttonHelp_AIA_Click_1(object sender, EventArgs e)
        {

        }
    }
}