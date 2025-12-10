using System.Windows.Forms.VisualStyles;
using Tyuiu.AndreevIA.Sprint6.Task4.V4.Lib;
namespace Tyuiu.AndreevIA.Sprint6.Task4.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int stop = Convert.ToInt32(textBoxStop.Text);
                int len = ds.GetMassFunction(start, stop).Length;
                double[] array = ds.GetMassFunction(start, stop);
                this.chartTask.Titles.Add("Функция F(x)");
                this.chartTask.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartTask.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult.Text = "";
                chartTask.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartTask.Series[0].Points.AddXY(start + i, array[i]);
                    textBoxResult.AppendText(array[i] + Environment.NewLine);
                }
            }
            catch { MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы РППб-25-1 Андреев Иван Александрович", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult.Text);
                DialogResult dr = MessageBox.Show("Файл " + path + " сохранен успешно.\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch { MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}