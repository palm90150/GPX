namespace GPAX
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
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            tbinputGPA = new TextBox();
            tbGPAx = new TextBox();
            tbMin = new TextBox();
            tbMax = new TextBox();
            tbCount = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(376, 93);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 98);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "add data";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 96);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 1;
            label1.Text = "ใส่คะแนนGPA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 171);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "GPAX";
            // 
            // tbinputGPA
            // 
            tbinputGPA.Location = new Point(182, 168);
            tbinputGPA.Name = "tbinputGPA";
            tbinputGPA.Size = new Size(125, 27);
            tbinputGPA.TabIndex = 3;
            tbinputGPA.TextChanged += tbinputGPA_TextChanged;
            // 
            // tbGPAx
            // 
            tbGPAx.Location = new Point(182, 96);
            tbGPAx.Name = "tbGPAx";
            tbGPAx.Size = new Size(125, 27);
            tbGPAx.TabIndex = 4;
            tbGPAx.TextChanged += tbGPAx_TextChanged;
            // 
            // tbMin
            // 
            tbMin.Location = new Point(182, 340);
            tbMin.Name = "tbMin";
            tbMin.Size = new Size(125, 27);
            tbMin.TabIndex = 5;
            // 
            // tbMax
            // 
            tbMax.Location = new Point(182, 279);
            tbMax.Name = "tbMax";
            tbMax.Size = new Size(125, 27);
            tbMax.TabIndex = 6;
            // 
            // tbCount
            // 
            tbCount.Location = new Point(182, 220);
            tbCount.Name = "tbCount";
            tbCount.Size = new Size(125, 27);
            tbCount.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 227);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 8;
            label3.Text = "จำนวนคน";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 286);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 9;
            label4.Text = "max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 347);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 10;
            label5.Text = "min";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 498);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbCount);
            Controls.Add(tbMax);
            Controls.Add(tbMin);
            Controls.Add(tbGPAx);
            Controls.Add(tbinputGPA);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private Label label2;
        private TextBox tbinputGPA;
        private TextBox tbGPAx;
        private TextBox tbMin;
        private TextBox tbMax;
        private TextBox tbCount;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
