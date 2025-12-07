using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.AndreevIA.Sprint6.Task2.V13
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxTask_AIA = new GroupBox();
            textBoxText_AIA = new TextBox();
            groupBoxTasky_AIA = new GroupBox();
            buttonDone_AIA = new Button();
            buttonHelp_AIA = new Button();
            textBoxEnd_AIA = new TextBox();
            textBoxBeg_AIA = new TextBox();
            textBoxStop_AIA = new TextBox();
            textBoxStart_AIA = new TextBox();
            groupBoxResults_AIA = new GroupBox();
            chartFunction_AIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_AIA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            groupBoxTask_AIA.SuspendLayout();
            groupBoxTasky_AIA.SuspendLayout();
            groupBoxResults_AIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AIA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_AIA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_AIA
            // 
            groupBoxTask_AIA.Controls.Add(textBoxText_AIA);
            groupBoxTask_AIA.Location = new Point(12, 12);
            groupBoxTask_AIA.Name = "groupBoxTask_AIA";
            groupBoxTask_AIA.Size = new Size(491, 278);
            groupBoxTask_AIA.TabIndex = 0;
            groupBoxTask_AIA.TabStop = false;
            groupBoxTask_AIA.Text = "Условие";
            // 
            // textBoxText_AIA
            // 
            textBoxText_AIA.BackColor = SystemColors.MenuBar;
            textBoxText_AIA.Location = new Point(6, 22);
            textBoxText_AIA.Name = "textBoxText_AIA";
            textBoxText_AIA.ReadOnly = true;
            textBoxText_AIA.Size = new Size(470, 23);
            textBoxText_AIA.TabIndex = 0;
            textBoxText_AIA.Text = "Написать программу, которая выводит таблицу на заданном промежутке:";
            // 
            // groupBoxTasky_AIA
            // 
            groupBoxTasky_AIA.Controls.Add(buttonDone_AIA);
            groupBoxTasky_AIA.Controls.Add(buttonHelp_AIA);
            groupBoxTasky_AIA.Controls.Add(textBoxEnd_AIA);
            groupBoxTasky_AIA.Controls.Add(textBoxBeg_AIA);
            groupBoxTasky_AIA.Controls.Add(textBoxStop_AIA);
            groupBoxTasky_AIA.Controls.Add(textBoxStart_AIA);
            groupBoxTasky_AIA.Location = new Point(12, 296);
            groupBoxTasky_AIA.Name = "groupBoxTasky_AIA";
            groupBoxTasky_AIA.Size = new Size(491, 142);
            groupBoxTasky_AIA.TabIndex = 1;
            groupBoxTasky_AIA.TabStop = false;
            groupBoxTasky_AIA.Text = "Ввод Данных";
            // 
            // buttonDone_AIA
            // 
            buttonDone_AIA.BackColor = Color.LightGreen;
            buttonDone_AIA.Location = new Point(369, 69);
            buttonDone_AIA.Name = "buttonDone_AIA";
            buttonDone_AIA.Size = new Size(116, 67);
            buttonDone_AIA.TabIndex = 5;
            buttonDone_AIA.Tag = "Выполнить";
            buttonDone_AIA.Text = "Выполнить";
            buttonDone_AIA.UseVisualStyleBackColor = false;
            buttonDone_AIA.Click += buttonDone_AIA_Click;
            // 
            // buttonHelp_AIA
            // 
            buttonHelp_AIA.BackColor = SystemColors.ActiveCaption;
            buttonHelp_AIA.Location = new Point(264, 83);
            buttonHelp_AIA.Name = "buttonHelp_AIA";
            buttonHelp_AIA.Size = new Size(99, 53);
            buttonHelp_AIA.TabIndex = 4;
            buttonHelp_AIA.Text = "Справка";
            buttonHelp_AIA.UseVisualStyleBackColor = false;
            buttonHelp_AIA.Click += buttonHelp_AIA_Click_1;
            // 
            // textBoxEnd_AIA
            // 
            textBoxEnd_AIA.Location = new Point(135, 84);
            textBoxEnd_AIA.Name = "textBoxEnd_AIA";
            textBoxEnd_AIA.Size = new Size(123, 23);
            textBoxEnd_AIA.TabIndex = 3;
            textBoxEnd_AIA.Text = "Конец шага:";
            // 
            // textBoxBeg_AIA
            // 
            textBoxBeg_AIA.Location = new Point(6, 84);
            textBoxBeg_AIA.Name = "textBoxBeg_AIA";
            textBoxBeg_AIA.Size = new Size(123, 23);
            textBoxBeg_AIA.TabIndex = 2;
            textBoxBeg_AIA.Text = "Старт шага:";
            // 
            // textBoxStop_AIA
            // 
            textBoxStop_AIA.Location = new Point(135, 113);
            textBoxStop_AIA.Name = "textBoxStop_AIA";
            textBoxStop_AIA.Size = new Size(123, 23);
            textBoxStop_AIA.TabIndex = 1;
            // 
            // textBoxStart_AIA
            // 
            textBoxStart_AIA.Location = new Point(6, 113);
            textBoxStart_AIA.Name = "textBoxStart_AIA";
            textBoxStart_AIA.Size = new Size(123, 23);
            textBoxStart_AIA.TabIndex = 0;
            // 
            // groupBoxResults_AIA
            // 
            groupBoxResults_AIA.Controls.Add(chartFunction_AIA);
            groupBoxResults_AIA.Controls.Add(dataGridViewFunction_AIA);
            groupBoxResults_AIA.Location = new Point(522, 12);
            groupBoxResults_AIA.Name = "groupBoxResults_AIA";
            groupBoxResults_AIA.Size = new Size(697, 430);
            groupBoxResults_AIA.TabIndex = 2;
            groupBoxResults_AIA.TabStop = false;
            groupBoxResults_AIA.Text = "Вывод Данных";
            // 
            // chartFunction_AIA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_AIA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_AIA.Legends.Add(legend1);
            chartFunction_AIA.Location = new Point(184, 19);
            chartFunction_AIA.Name = "chartFunction_AIA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_AIA.Series.Add(series1);
            chartFunction_AIA.Size = new Size(507, 408);
            chartFunction_AIA.TabIndex = 1;
            chartFunction_AIA.Text = "chart1";
            // 
            // dataGridViewFunction_AIA
            // 
            dataGridViewFunction_AIA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_AIA.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction_AIA.Location = new Point(3, 19);
            dataGridViewFunction_AIA.Name = "dataGridViewFunction_AIA";
            dataGridViewFunction_AIA.RowHeadersVisible = false;
            dataGridViewFunction_AIA.Size = new Size(165, 405);
            dataGridViewFunction_AIA.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 450);
            Controls.Add(groupBoxResults_AIA);
            Controls.Add(groupBoxTasky_AIA);
            Controls.Add(groupBoxTask_AIA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 13 | Андреев И.А";
            groupBoxTask_AIA.ResumeLayout(false);
            groupBoxTask_AIA.PerformLayout();
            groupBoxTasky_AIA.ResumeLayout(false);
            groupBoxTasky_AIA.PerformLayout();
            groupBoxResults_AIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_AIA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_AIA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBoxTask_AIA;
        private TextBox textBoxText_AIA;
        private GroupBox groupBoxTasky_AIA;
        private GroupBox groupBoxResults_AIA;
        private TextBox textBoxStart_AIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AIA;
        private DataGridView dataGridViewFunction_AIA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private TextBox textBoxBeg_AIA;
        private TextBox textBoxStop_AIA;
        private Button buttonDone_AIA;
        private Button buttonHelp_AIA;
        private TextBox textBoxEnd_AIA;
    }
}