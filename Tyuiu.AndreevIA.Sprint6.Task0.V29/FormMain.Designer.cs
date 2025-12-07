using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.AndreevIA.Sprint6.Task0.V29
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_AIA = new GroupBox();
            pictureBoxTask_AIA = new PictureBox();
            textBoxTask_AIA = new TextBox();
            groupBoxInput_AIA = new GroupBox();
            label1 = new Label();
            textBoxX_AIA = new TextBox();
            groupBoxOutput_AIA = new GroupBox();
            label4 = new Label();
            textBoxResult_AIA = new TextBox();
            buttonQuestion_AIA = new Button();
            buttonDoneResult_AIA = new Button();
            groupBoxTask_AIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_AIA).BeginInit();
            groupBoxInput_AIA.SuspendLayout();
            groupBoxOutput_AIA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_AIA
            // 
            groupBoxTask_AIA.Controls.Add(pictureBoxTask_AIA);
            groupBoxTask_AIA.Controls.Add(textBoxTask_AIA);
            groupBoxTask_AIA.Location = new Point(12, 12);
            groupBoxTask_AIA.Name = "groupBoxTask_AIA";
            groupBoxTask_AIA.Size = new Size(706, 231);
            groupBoxTask_AIA.TabIndex = 0;
            groupBoxTask_AIA.TabStop = false;
            groupBoxTask_AIA.Text = "Условие";
            // 
            // pictureBoxTask_AIA
            // 
            pictureBoxTask_AIA.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxTask_AIA.ErrorImage = null;
            pictureBoxTask_AIA.Image = (System.Drawing.Image)resources.GetObject("pictureBoxTask_AIA.Image");
            pictureBoxTask_AIA.InitialImage = null;
            pictureBoxTask_AIA.Location = new Point(462, 19);
            pictureBoxTask_AIA.Name = "pictureBoxTask_AIA";
            pictureBoxTask_AIA.Size = new Size(220, 127);
            pictureBoxTask_AIA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask_AIA.TabIndex = 1;
            pictureBoxTask_AIA.TabStop = false;
            // 
            // textBoxTask_AIA
            // 
            textBoxTask_AIA.BorderStyle = BorderStyle.None;
            textBoxTask_AIA.Location = new Point(11, 19);
            textBoxTask_AIA.Multiline = true;
            textBoxTask_AIA.Name = "textBoxTask_AIA";
            textBoxTask_AIA.ReadOnly = true;
            textBoxTask_AIA.Size = new Size(326, 127);
            textBoxTask_AIA.TabIndex = 0;
            textBoxTask_AIA.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInput_AIA
            // 
            groupBoxInput_AIA.Controls.Add(label1);
            groupBoxInput_AIA.Controls.Add(textBoxX_AIA);
            groupBoxInput_AIA.Location = new Point(12, 261);
            groupBoxInput_AIA.Name = "groupBoxInput_AIA";
            groupBoxInput_AIA.Size = new Size(426, 100);
            groupBoxInput_AIA.TabIndex = 1;
            groupBoxInput_AIA.TabStop = false;
            groupBoxInput_AIA.Text = "Ввод данных";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 35);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Переменная X:";
            // 
            // textBoxX_AIA
            // 
            textBoxX_AIA.Location = new Point(11, 53);
            textBoxX_AIA.Name = "textBoxX_AIA";
            textBoxX_AIA.Size = new Size(108, 23);
            textBoxX_AIA.TabIndex = 0;
            textBoxX_AIA.KeyPress += textBoxVarX_AIA_KeyPress;
            // 
            // groupBoxOutput_AIA
            // 
            groupBoxOutput_AIA.Controls.Add(label4);
            groupBoxOutput_AIA.Controls.Add(textBoxResult_AIA);
            groupBoxOutput_AIA.Location = new Point(444, 261);
            groupBoxOutput_AIA.Name = "groupBoxOutput_AIA";
            groupBoxOutput_AIA.Size = new Size(274, 100);
            groupBoxOutput_AIA.TabIndex = 2;
            groupBoxOutput_AIA.TabStop = false;
            groupBoxOutput_AIA.Text = "Вывод данных";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 35);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 9;
            label4.Text = "Результат:";
            // 
            // textBoxResult_AIA
            // 
            textBoxResult_AIA.Location = new Point(6, 53);
            textBoxResult_AIA.Name = "textBoxResult_AIA";
            textBoxResult_AIA.ReadOnly = true;
            textBoxResult_AIA.Size = new Size(262, 23);
            textBoxResult_AIA.TabIndex = 8;
            // 
            // buttonQuestion_AIA
            // 
            buttonQuestion_AIA.FlatStyle = FlatStyle.Flat;
            buttonQuestion_AIA.Location = new Point(450, 376);
            buttonQuestion_AIA.Name = "buttonQuestion_AIA";
            buttonQuestion_AIA.Size = new Size(63, 62);
            buttonQuestion_AIA.TabIndex = 3;
            buttonQuestion_AIA.Text = "?";
            buttonQuestion_AIA.UseVisualStyleBackColor = true;
            buttonQuestion_AIA.Click += buttonQuestion_AIA_Click;
            // 
            // buttonDoneResult_AIA
            // 
            buttonDoneResult_AIA.BackgroundImageLayout = ImageLayout.None;
            buttonDoneResult_AIA.FlatStyle = FlatStyle.System;
            buttonDoneResult_AIA.Location = new Point(530, 376);
            buttonDoneResult_AIA.Name = "buttonDoneResult_AIA";
            buttonDoneResult_AIA.Size = new Size(182, 62);
            buttonDoneResult_AIA.TabIndex = 4;
            buttonDoneResult_AIA.Text = "Выполнить";
            buttonDoneResult_AIA.UseVisualStyleBackColor = true;
            buttonDoneResult_AIA.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 450);
            Controls.Add(buttonDoneResult_AIA);
            Controls.Add(buttonQuestion_AIA);
            Controls.Add(groupBoxOutput_AIA);
            Controls.Add(groupBoxInput_AIA);
            Controls.Add(groupBoxTask_AIA);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 29 | Андреев И.А.";
            groupBoxTask_AIA.ResumeLayout(false);
            groupBoxTask_AIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_AIA).EndInit();
            groupBoxInput_AIA.ResumeLayout(false);
            groupBoxInput_AIA.PerformLayout();
            groupBoxOutput_AIA.ResumeLayout(false);
            groupBoxOutput_AIA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_AIA;
        private GroupBox groupBoxInput_AIA;
        private GroupBox groupBoxOutput_AIA;
        private TextBox textBoxTask_AIA;
        private Label label1;
        private TextBox textBoxX_AIA;
        private Label label4;
        private TextBox textBoxResult_AIA;
        private Button buttonQuestion_AIA;
        private Button buttonDoneResult_AIA;
        private PictureBox pictureBoxTask_AIA;
    }
}