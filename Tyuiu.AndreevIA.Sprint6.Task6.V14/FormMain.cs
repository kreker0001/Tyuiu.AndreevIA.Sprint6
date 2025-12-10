using Tyuiu.AndreevIA.Sprint6.Task6.V14;
using Tyuiu.AndreevIA.Sprint6.Task6.V14.Lib;
namespace Tyuiu.AndreevIA.Sprint6.Task6.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxIn.Text = File.ReadAllText(openFilePath);
            buttonDone.Enabled = true;
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {

            textBoxOut.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}