using System.Windows.Forms;
using Tyuiu.AndreevIA.Sprint6.Task7.V17.Lib;
namespace Tyuiu.AndreevIA.Sprint6.Task7.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask7.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask7.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows; static int columns; static string path;
        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_AIA.ColumnCount = 50;
            dataGridViewOut_AIA.ColumnCount = 50;
            dataGridViewIn_AIA.RowCount = 50;
            dataGridViewOut_AIA.RowCount = 50;
            panel3.Width = this.Width / 2;
            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_AIA.Columns[i].Width = 25;
                dataGridViewOut_AIA.Columns[i].Width = 25;
            }
        }
        public static int[,] LoadFromFileData(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = int.Parse(line_r[c]);
                }
            }
            return arrayValues;

        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(path);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_AIA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_AIA.Enabled = true;

        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask7.ShowDialog();
            path = openFileDialogTask7.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(path);
            dataGridViewIn_AIA.ColumnCount = columns;
            dataGridViewIn_AIA.RowCount = rows;
            dataGridViewOut_AIA.ColumnCount = columns;
            dataGridViewOut_AIA.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_AIA.Columns[i].Width = 25;
                dataGridViewOut_AIA.Columns[i].Width = 25;

            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_AIA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(path);
            buttonStart_AIA.Enabled = true;
        }
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogTask7.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask7.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask7.ShowDialog();
            string path = saveFileDialogTask7.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_AIA.RowCount;
            int columns = dataGridViewOut_AIA.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOut_AIA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut_AIA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }
        private void buttonStart_MouseEnter(Object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }
        private void buttonSaveFile_MouseEnter(Object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить в файл";
        }

    }
}