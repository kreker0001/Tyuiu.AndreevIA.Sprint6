using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.AndreevIA.Sprint6.Task6.V14
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
            buttonHelp = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBoxIn = new TextBox();
            groupBox3 = new GroupBox();
            textBoxOut = new TextBox();
            buttonLoad = new Button();
            buttonDone = new Button();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelp
            // 
            buttonHelp.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonHelp.BackgroundImage");
            buttonHelp.BackgroundImageLayout = ImageLayout.Center;
            buttonHelp.FlatStyle = FlatStyle.Popup;
            buttonHelp.Location = new Point(633, 9);
            buttonHelp.Margin = new Padding(3, 2, 3, 2);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(57, 49);
            buttonHelp.TabIndex = 0;
            toolTip.SetToolTip(buttonHelp, "Сведение о программе");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(4, 65);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(687, 77);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 17);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(680, 56);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxIn);
            groupBox2.Location = new Point(10, 147);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(332, 182);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод:";
            // 
            // textBoxIn
            // 
            textBoxIn.Location = new Point(10, 20);
            textBoxIn.Margin = new Padding(3, 2, 3, 2);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ReadOnly = true;
            textBoxIn.Size = new Size(319, 158);
            textBoxIn.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxOut);
            groupBox3.Location = new Point(354, 147);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(332, 182);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод:";
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(9, 17);
            textBoxOut.Margin = new Padding(3, 2, 3, 2);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ReadOnly = true;
            textBoxOut.Size = new Size(319, 158);
            textBoxOut.TabIndex = 0;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = Color.Transparent;
            buttonLoad.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonLoad.BackgroundImage");
            buttonLoad.BackgroundImageLayout = ImageLayout.Center;
            buttonLoad.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLoad.Location = new Point(10, 9);
            buttonLoad.Margin = new Padding(3, 2, 3, 2);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(66, 48);
            buttonLoad.TabIndex = 3;
            toolTip.SetToolTip(buttonLoad, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Transparent;
            buttonDone.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonDone.BackgroundImage");
            buttonDone.BackgroundImageLayout = ImageLayout.Center;
            buttonDone.Enabled = false;
            buttonDone.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone.Location = new Point(82, 9);
            buttonDone.Margin = new Padding(3, 2, 3, 2);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(66, 48);
            buttonDone.TabIndex = 3;
            toolTip.SetToolTip(buttonDone, "Производит поиск файла");
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "InPutFileTask6V14.txt";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonDone);
            Controls.Add(buttonLoad);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonHelp);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 21 | Андреев И.А.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBoxIn;
        private GroupBox groupBox3;
        private TextBox textBoxOut;
        private Button buttonLoad;
        private Button buttonDone;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
    }
}