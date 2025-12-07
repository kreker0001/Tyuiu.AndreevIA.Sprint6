using Tyuiu.AndreevIA.Sprint6.Task0.V29.Lib;
namespace Tyuiu.AndreevIA.Sprint6.Task0.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();
            try
            {
                textBoxResult_AIA.Text = Convert.ToString(dataService.Calculate(Convert.ToInt32(textBoxX_AIA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarX_AIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonQuestion_AIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Такс 0 выполнил студент группы РППб-25-1 Андреев Иван Александрович", "Сообщение", MessageBoxButtons.OK);
        }
    }
}