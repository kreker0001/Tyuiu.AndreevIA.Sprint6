using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.AndreevIA.Sprint6.Task7.V17
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonOpenFile_AIA = new Button();
            buttonStart_AIA = new Button();
            buttonSaveFile_AIA = new Button();
            buttonHelp_AIA = new Button();
            panel2 = new Panel();
            groupBoxCondition_AIA = new GroupBox();
            labelCondition_AIA = new Label();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            dataGridViewIn_AIA = new DataGridView();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            dataGridViewOut_AIA = new DataGridView();
            toolTipButton = new ToolTip(components);
            openFileDialogTask7 = new OpenFileDialog();
            saveFileDialogTask7 = new SaveFileDialog();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxCondition_AIA.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_AIA).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_AIA).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(buttonOpenFile_AIA);
            panel1.Controls.Add(buttonStart_AIA);
            panel1.Controls.Add(buttonSaveFile_AIA);
            panel1.Controls.Add(buttonHelp_AIA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 52);
            panel1.TabIndex = 0;
            // 
            // buttonOpenFile_AIA
            // 
            buttonOpenFile_AIA.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonOpenFile_AIA.BackgroundImage");
            buttonOpenFile_AIA.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenFile_AIA.Location = new Point(8, 2);
            buttonOpenFile_AIA.Margin = new Padding(2);
            buttonOpenFile_AIA.Name = "buttonOpenFile_AIA";
            buttonOpenFile_AIA.Size = new Size(75, 48);
            buttonOpenFile_AIA.TabIndex = 1;
            toolTipButton.SetToolTip(buttonOpenFile_AIA, "Открыть файл для обработки данных в формате CSV");
            buttonOpenFile_AIA.UseVisualStyleBackColor = true;
            buttonOpenFile_AIA.Click += buttonOpenFile_Click;
            buttonOpenFile_AIA.MouseEnter += buttonOpenFile_MouseEnter;
            // 
            // buttonStart_AIA
            // 
            buttonStart_AIA.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonStart_AIA.BackgroundImage");
            buttonStart_AIA.BackgroundImageLayout = ImageLayout.Center;
            buttonStart_AIA.Enabled = false;
            buttonStart_AIA.Location = new Point(87, 2);
            buttonStart_AIA.Margin = new Padding(2);
            buttonStart_AIA.Name = "buttonStart_AIA";
            buttonStart_AIA.Size = new Size(75, 48);
            buttonStart_AIA.TabIndex = 2;
            toolTipButton.SetToolTip(buttonStart_AIA, "Выполнить обработку данных");
            buttonStart_AIA.UseVisualStyleBackColor = true;
            buttonStart_AIA.Click += buttonStart_Click;
            buttonStart_AIA.MouseEnter += buttonStart_MouseEnter;
            // 
            // buttonSaveFile_AIA
            // 
            buttonSaveFile_AIA.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonSaveFile_AIA.BackgroundImage");
            buttonSaveFile_AIA.BackgroundImageLayout = ImageLayout.Center;
            buttonSaveFile_AIA.Enabled = false;
            buttonSaveFile_AIA.Location = new Point(165, 2);
            buttonSaveFile_AIA.Margin = new Padding(2);
            buttonSaveFile_AIA.Name = "buttonSaveFile_AIA";
            buttonSaveFile_AIA.Size = new Size(75, 48);
            buttonSaveFile_AIA.TabIndex = 3;
            toolTipButton.SetToolTip(buttonSaveFile_AIA, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_AIA.UseVisualStyleBackColor = true;
            buttonSaveFile_AIA.Click += buttonSaveFile_Click;
            buttonSaveFile_AIA.MouseEnter += buttonSaveFile_MouseEnter;
            // 
            // buttonHelp_AIA
            // 
            buttonHelp_AIA.AutoSize = true;
            buttonHelp_AIA.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonHelp_AIA.BackgroundImage");
            buttonHelp_AIA.BackgroundImageLayout = ImageLayout.Center;
            buttonHelp_AIA.Location = new Point(733, 2);
            buttonHelp_AIA.Margin = new Padding(2);
            buttonHelp_AIA.Name = "buttonHelp_AIA";
            buttonHelp_AIA.Size = new Size(75, 48);
            buttonHelp_AIA.TabIndex = 0;
            toolTipButton.SetToolTip(buttonHelp_AIA, "Сведения о программе");
            buttonHelp_AIA.UseVisualStyleBackColor = true;
            buttonHelp_AIA.Click += buttonHelp_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxCondition_AIA);
            panel2.Location = new Point(0, 51);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 62);
            panel2.TabIndex = 1;
            // 
            // groupBoxCondition_AIA
            // 
            groupBoxCondition_AIA.AutoSize = true;
            groupBoxCondition_AIA.Controls.Add(textBox1);
            groupBoxCondition_AIA.Controls.Add(labelCondition_AIA);
            groupBoxCondition_AIA.Dock = DockStyle.Fill;
            groupBoxCondition_AIA.Location = new Point(0, 0);
            groupBoxCondition_AIA.Margin = new Padding(2);
            groupBoxCondition_AIA.Name = "groupBoxCondition_AIA";
            groupBoxCondition_AIA.Padding = new Padding(2);
            groupBoxCondition_AIA.Size = new Size(816, 62);
            groupBoxCondition_AIA.TabIndex = 0;
            groupBoxCondition_AIA.TabStop = false;
            groupBoxCondition_AIA.Text = "Условие";
            // 
            // labelCondition_AIA
            // 
            labelCondition_AIA.AutoSize = true;
            labelCondition_AIA.Font = new System.Drawing.Font("Segoe UI", 8F);
            labelCondition_AIA.Location = new Point(5, 18);
            labelCondition_AIA.Margin = new Padding(2, 0, 2, 0);
            labelCondition_AIA.Name = "labelCondition_AIA";
            labelCondition_AIA.Size = new Size(0, 13);
            labelCondition_AIA.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(0, 117);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(417, 330);
            panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(dataGridViewIn_AIA);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(417, 330);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод";
            // 
            // dataGridViewIn_AIA
            // 
            dataGridViewIn_AIA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_AIA.ColumnHeadersVisible = false;
            dataGridViewIn_AIA.Location = new Point(4, 20);
            dataGridViewIn_AIA.Margin = new Padding(2);
            dataGridViewIn_AIA.Name = "dataGridViewIn_AIA";
            dataGridViewIn_AIA.ReadOnly = true;
            dataGridViewIn_AIA.RowHeadersVisible = false;
            dataGridViewIn_AIA.RowHeadersWidth = 62;
            dataGridViewIn_AIA.ScrollBars = ScrollBars.Vertical;
            dataGridViewIn_AIA.Size = new Size(399, 286);
            dataGridViewIn_AIA.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(816, 52);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(0, 385);
            panel4.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(dataGridViewOut_AIA);
            groupBox2.Location = new Point(421, 117);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(391, 330);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод";
            // 
            // dataGridViewOut_AIA
            // 
            dataGridViewOut_AIA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_AIA.Location = new Point(4, 20);
            dataGridViewOut_AIA.Margin = new Padding(2);
            dataGridViewOut_AIA.Name = "dataGridViewOut_AIA";
            dataGridViewOut_AIA.ReadOnly = true;
            dataGridViewOut_AIA.RowHeadersWidth = 62;
            dataGridViewOut_AIA.ScrollBars = ScrollBars.Vertical;
            dataGridViewOut_AIA.Size = new Size(381, 286);
            dataGridViewOut_AIA.TabIndex = 0;
            // 
            // openFileDialogTask7
            // 
            openFileDialogTask7.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 14);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(816, 48);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(816, 437);
            Controls.Add(groupBox2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 17 | Андреев И.А.";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBoxCondition_AIA.ResumeLayout(false);
            groupBoxCondition_AIA.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_AIA).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_AIA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonHelp_AIA;
        private Button buttonSaveFile_AIA;
        private Button buttonStart_AIA;
        private Button buttonOpenFile_AIA;
        private Panel panel2;
        private GroupBox groupBoxCondition_AIA;
        private Panel panel3;
        private GroupBox groupBox1;
        private DataGridView dataGridViewIn_AIA;
        private Panel panel4;
        private GroupBox groupBox2;
        private DataGridView dataGridViewOut_AIA;
        private Label labelCondition_AIA;
        private ToolTip toolTipButton;
        private OpenFileDialog openFileDialogTask7;
        private SaveFileDialog saveFileDialogTask7;
        private TextBox textBox1;
    }
}