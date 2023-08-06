namespace Snake
{
    partial class Form1
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
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            numericUpDown3 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(560, 5);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Draw";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.InterceptArrowKeys = false;
            numericUpDown1.Location = new Point(68, 7);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.TabStop = false;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.InterceptArrowKeys = false;
            numericUpDown2.Location = new Point(68, 45);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.ReadOnly = true;
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 2;
            numericUpDown2.TabStop = false;
            numericUpDown2.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(20, 20);
            label1.TabIndex = 3;
            label1.Text = "N";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 4;
            label2.Text = "M";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(12, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 492);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(700, 35);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 9);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 8;
            label4.Text = "px";
            // 
            // numericUpDown3
            // 
            numericUpDown3.InterceptArrowKeys = false;
            numericUpDown3.Location = new Point(344, 7);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.ReadOnly = true;
            numericUpDown3.Size = new Size(150, 27);
            numericUpDown3.TabIndex = 7;
            numericUpDown3.TabStop = false;
            numericUpDown3.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 582);
            Controls.Add(label4);
            Controls.Add(numericUpDown3);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown3;
    }
}