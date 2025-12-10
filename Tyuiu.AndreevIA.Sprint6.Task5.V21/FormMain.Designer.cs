using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.AndreevIA.Sprint6.Task5.V21
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            buttonInfo = new Button();
            buttonOpenFile = new Button();
            buttonDone = new Button();
            groupBoxCondition_AIA = new GroupBox();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            dataGridView_AIA = new DataGridView();
            chart_AIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            groupBoxCondition_AIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AIA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_AIA).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonInfo);
            panel1.Controls.Add(buttonOpenFile);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(groupBoxCondition_AIA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 132);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(814, 27);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(103, 85);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(665, 27);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(143, 85);
            buttonOpenFile.TabIndex = 2;
            buttonOpenFile.Text = "Посмотреть файл";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(529, 23);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(130, 89);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxCondition_AIA
            // 
            groupBoxCondition_AIA.Controls.Add(label1);
            groupBoxCondition_AIA.Location = new Point(12, 12);
            groupBoxCondition_AIA.Name = "groupBoxCondition_AIA";
            groupBoxCondition_AIA.Size = new Size(511, 100);
            groupBoxCondition_AIA.TabIndex = 0;
            groupBoxCondition_AIA.TabStop = false;
            groupBoxCondition_AIA.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Выполнить задание";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 132);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView_AIA);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(chart_AIA);
            splitContainer1.Size = new Size(1089, 475);
            splitContainer1.SplitterDistance = 306;
            splitContainer1.TabIndex = 1;
            // 
            // dataGridView_AIA
            // 
            dataGridView_AIA.AllowUserToAddRows = false;
            dataGridView_AIA.AllowUserToDeleteRows = false;
            dataGridView_AIA.AllowUserToResizeColumns = false;
            dataGridView_AIA.AllowUserToResizeRows = false;
            dataGridView_AIA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_AIA.Dock = DockStyle.Fill;
            dataGridView_AIA.Location = new Point(0, 0);
            dataGridView_AIA.Name = "dataGridView_AIA";
            dataGridView_AIA.RowHeadersVisible = false;
            dataGridView_AIA.ScrollBars = ScrollBars.Vertical;
            dataGridView_AIA.Size = new Size(306, 475);
            dataGridView_AIA.TabIndex = 0;
            // 
            // chart_AIA
            // 
            chartArea1.Name = "ChartArea1";
            chart_AIA.ChartAreas.Add(chartArea1);
            chart_AIA.Dock = DockStyle.Fill;
            chart_AIA.Location = new Point(0, 0);
            chart_AIA.Name = "chart_AIA";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chart_AIA.Series.Add(series1);
            chart_AIA.Size = new Size(779, 475);
            chart_AIA.TabIndex = 0;
            chart_AIA.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 607);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Спринт 6 | Таск 5 | Вариант 21 | Андреев И.А.";
            panel1.ResumeLayout(false);
            groupBoxCondition_AIA.ResumeLayout(false);
            groupBoxCondition_AIA.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_AIA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_AIA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView_AIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_AIA;
        private Button buttonInfo;
        private Button buttonOpenFile;
        private Button buttonDone;
        private GroupBox groupBoxCondition_AIA;
        private Label label1;
    }
}