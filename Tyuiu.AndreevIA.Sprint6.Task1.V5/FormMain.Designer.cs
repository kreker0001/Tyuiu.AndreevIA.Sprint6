
namespace Tyuiu.AndreevIA.Sprint6.Task1.V5
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxUslovie_AIA = new GroupBox();
            textBoxUslovie_AIA = new TextBox();
            groupBoxVvod_AIA = new GroupBox();
            textBoxStop_AIA = new TextBox();
            textBoxStart_AIA = new TextBox();
            labelStop_AIA = new Label();
            labelStart_AIA = new Label();
            buttonSpravka_AIA = new Button();
            buttonVipolnit_AIA = new Button();
            groupBoxVivod_AIA = new GroupBox();
            textBoxResult_AIA = new TextBox();
            labelResult_AIA = new Label();
            groupBoxUslovie_AIA.SuspendLayout();
            groupBoxVvod_AIA.SuspendLayout();
            groupBoxVivod_AIA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUslovie_AIA
            // 
            groupBoxUslovie_AIA.Controls.Add(textBoxUslovie_AIA);
            groupBoxUslovie_AIA.Location = new Point(10, 11);
            groupBoxUslovie_AIA.Name = "groupBoxUslovie_AIA";
            groupBoxUslovie_AIA.Size = new Size(515, 277);
            groupBoxUslovie_AIA.TabIndex = 0;
            groupBoxUslovie_AIA.TabStop = false;
            groupBoxUslovie_AIA.Text = "Условие";
            // 
            // textBoxUslovie_AIA
            // 
            textBoxUslovie_AIA.Location = new Point(9, 20);
            textBoxUslovie_AIA.Multiline = true;
            textBoxUslovie_AIA.Name = "textBoxUslovie_AIA";
            textBoxUslovie_AIA.ReadOnly = true;
            textBoxUslovie_AIA.Size = new Size(476, 257);
            textBoxUslovie_AIA.TabIndex = 0;
            textBoxUslovie_AIA.Text = "Протабулировать функцию sin(x) + cos(2x)/2 - 1,5x на заданном диапазоне.Результат вывести в виде таблицы.";
            // 
            // groupBoxVvod_AIA
            // 
            groupBoxVvod_AIA.Controls.Add(textBoxStop_AIA);
            groupBoxVvod_AIA.Controls.Add(textBoxStart_AIA);
            groupBoxVvod_AIA.Controls.Add(labelStop_AIA);
            groupBoxVvod_AIA.Controls.Add(labelStart_AIA);
            groupBoxVvod_AIA.Location = new Point(10, 293);
            groupBoxVvod_AIA.Name = "groupBoxVvod_AIA";
            groupBoxVvod_AIA.Size = new Size(317, 119);
            groupBoxVvod_AIA.TabIndex = 1;
            groupBoxVvod_AIA.TabStop = false;
            groupBoxVvod_AIA.Text = "Ввод данных";
            // 
            // textBoxStop_AIA
            // 
            textBoxStop_AIA.Location = new Point(127, 50);
            textBoxStop_AIA.Name = "textBoxStop_AIA";
            textBoxStop_AIA.Size = new Size(95, 23);
            textBoxStop_AIA.TabIndex = 3;
            // 
            // textBoxStart_AIA
            // 
            textBoxStart_AIA.Location = new Point(9, 50);
            textBoxStart_AIA.Name = "textBoxStart_AIA";
            textBoxStart_AIA.Size = new Size(88, 23);
            textBoxStart_AIA.TabIndex = 2;
            // 
            // labelStop_AIA
            // 
            labelStop_AIA.AutoSize = true;
            labelStop_AIA.Location = new Point(124, 21);
            labelStop_AIA.Name = "labelStop_AIA";
            labelStop_AIA.Size = new Size(75, 15);
            labelStop_AIA.TabIndex = 1;
            labelStop_AIA.Text = "Конец шага:";
            // 
            // labelStart_AIA
            // 
            labelStart_AIA.AutoSize = true;
            labelStart_AIA.Location = new Point(6, 21);
            labelStart_AIA.Name = "labelStart_AIA";
            labelStart_AIA.Size = new Size(72, 15);
            labelStart_AIA.TabIndex = 0;
            labelStart_AIA.Text = "Старт шага:";
            // 
            // buttonSpravka_AIA
            // 
            buttonSpravka_AIA.BackColor = SystemColors.MenuHighlight;
            buttonSpravka_AIA.ForeColor = SystemColors.ActiveCaptionText;
            buttonSpravka_AIA.Location = new Point(353, 312);
            buttonSpravka_AIA.Name = "buttonSpravka_AIA";
            buttonSpravka_AIA.Size = new Size(85, 83);
            buttonSpravka_AIA.TabIndex = 2;
            buttonSpravka_AIA.Text = "Справка";
            buttonSpravka_AIA.UseVisualStyleBackColor = false;
            buttonSpravka_AIA.Click += buttonSpravka_AIA_Click;
            // 
            // buttonVipolnit_AIA
            // 
            buttonVipolnit_AIA.BackColor = Color.ForestGreen;
            buttonVipolnit_AIA.Location = new Point(443, 314);
            buttonVipolnit_AIA.Name = "buttonVipolnit_AIA";
            buttonVipolnit_AIA.Size = new Size(83, 82);
            buttonVipolnit_AIA.TabIndex = 3;
            buttonVipolnit_AIA.Text = "Выполнить";
            buttonVipolnit_AIA.UseVisualStyleBackColor = false;
            buttonVipolnit_AIA.Click += buttonVipolnit_AIA_Click;
            // 
            // groupBoxVivod_AIA
            // 
            groupBoxVivod_AIA.Controls.Add(textBoxResult_AIA);
            groupBoxVivod_AIA.Controls.Add(labelResult_AIA);
            groupBoxVivod_AIA.Location = new Point(539, 11);
            groupBoxVivod_AIA.Name = "groupBoxVivod_AIA";
            groupBoxVivod_AIA.Size = new Size(176, 399);
            groupBoxVivod_AIA.TabIndex = 4;
            groupBoxVivod_AIA.TabStop = false;
            groupBoxVivod_AIA.Text = "Вывод данных";
            // 
            // textBoxResult_AIA
            // 
            textBoxResult_AIA.Location = new Point(8, 41);
            textBoxResult_AIA.Multiline = true;
            textBoxResult_AIA.Name = "textBoxResult_AIA";
            textBoxResult_AIA.ReadOnly = true;
            textBoxResult_AIA.Size = new Size(141, 353);
            textBoxResult_AIA.TabIndex = 1;
            // 
            // labelResult_AIA
            // 
            labelResult_AIA.AutoSize = true;
            labelResult_AIA.Location = new Point(5, 22);
            labelResult_AIA.Name = "labelResult_AIA";
            labelResult_AIA.Size = new Size(63, 15);
            labelResult_AIA.TabIndex = 0;
            labelResult_AIA.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 422);
            Controls.Add(groupBoxVivod_AIA);
            Controls.Add(buttonVipolnit_AIA);
            Controls.Add(buttonSpravka_AIA);
            Controls.Add(groupBoxVvod_AIA);
            Controls.Add(groupBoxUslovie_AIA);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 5 | Андреев И.А.";
            Load += Form1_Load;
            groupBoxUslovie_AIA.ResumeLayout(false);
            groupBoxUslovie_AIA.PerformLayout();
            groupBoxVvod_AIA.ResumeLayout(false);
            groupBoxVvod_AIA.PerformLayout();
            groupBoxVivod_AIA.ResumeLayout(false);
            groupBoxVivod_AIA.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_AIA;
        private System.Windows.Forms.GroupBox groupBoxVvod_AIA;
        private System.Windows.Forms.TextBox textBoxStop_AIA;
        private System.Windows.Forms.TextBox textBoxStart_AIA;
        private System.Windows.Forms.Label labelStop_AIA;
        private System.Windows.Forms.Label labelStart_AIA;
        private System.Windows.Forms.TextBox textBoxUslovie_AIA;
        private System.Windows.Forms.Button buttonSpravka_AIA;
        private System.Windows.Forms.Button buttonVipolnit_AIA;
        private System.Windows.Forms.GroupBox groupBoxVivod_AIA;
        private System.Windows.Forms.Label labelResult_AIA;
        private System.Windows.Forms.TextBox textBoxResult_AIA;
    }
}