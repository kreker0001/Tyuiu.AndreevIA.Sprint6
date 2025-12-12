using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.AndreevIA.Sprint6.Task7.V17
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonOk_YVA = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(8, 14);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 163);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // buttonOk_YVA
            // 
            buttonOk_YVA.Location = new Point(400, 177);
            buttonOk_YVA.Margin = new Padding(2);
            buttonOk_YVA.Name = "buttonOk_YVA";
            buttonOk_YVA.Size = new Size(78, 20);
            buttonOk_YVA.TabIndex = 2;
            buttonOk_YVA.Text = "Ок";
            buttonOk_YVA.UseVisualStyleBackColor = true;
            buttonOk_YVA.Click += buttonOk_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 14);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(356, 163);
            textBox1.TabIndex = 3;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(482, 205);
            Controls.Add(textBox1);
            Controls.Add(buttonOk_YVA);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonOk_YVA;
        private TextBox textBox1;
    }
}