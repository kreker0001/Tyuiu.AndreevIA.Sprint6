using System.IO;
using Tyuiu.AndreevIA.Sprint6.Task5.V21.Lib;

namespace Tyuiu.AndreevIA.Sprint6.Task5.V21
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string path = Path.Combine(Directory.GetCurrentDirectory(), "InPutFileTask5V21.txt");
        public FormMain()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                double[] data = ds.LoadFromDataFile(path);


                chart_AIA.Series[0].Points.Clear();

                dataGridView_AIA.Rows.Clear();
                dataGridView_AIA.Columns.Clear();
                dataGridView_AIA.ReadOnly = true;
                chart_AIA.ChartAreas[0].AxisX.Title = "Ось X";
                chart_AIA.ChartAreas[0].AxisY.Title = "Ось Y";

                dataGridView_AIA.Columns.Add("Index", "Индекс");
                dataGridView_AIA.Columns.Add("Value", "Значение");

                dataGridView_AIA.Columns[0].Width = 50;
                dataGridView_AIA.Columns[1].Width = 50;


                for (int i = 0; i < ds.index; i++)
                {
                    double val = Math.Round(data[i], 3);
                    dataGridView_AIA.Rows.Add(i.ToString(), val.ToString());
                    chart_AIA.Series[0].Points.AddXY(i, val);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("notepad.exe", path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы РППб-25-1 Андреев Иван Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}