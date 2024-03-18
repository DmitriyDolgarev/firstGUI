namespace WinFormsApp1
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
            firstValue = new TextBox();
            secondValue = new TextBox();
            thirdValue = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // firstValue
            // 
            firstValue.Location = new Point(128, 6);
            firstValue.Name = "firstValue";
            firstValue.Size = new Size(125, 27);
            firstValue.TabIndex = 0;
            // 
            // secondValue
            // 
            secondValue.Location = new Point(128, 39);
            secondValue.Name = "secondValue";
            secondValue.Size = new Size(125, 27);
            secondValue.TabIndex = 1;
            // 
            // thirdValue
            // 
            thirdValue.Location = new Point(128, 72);
            thirdValue.Name = "thirdValue";
            thirdValue.Size = new Size(125, 27);
            thirdValue.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 3;
            label1.Text = "Первое число:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 42);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 4;
            label2.Text = "Второе число:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 75);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 5;
            label3.Text = "Третье число:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 110);
            button1.Name = "button1";
            button1.Size = new Size(241, 29);
            button1.TabIndex = 6;
            button1.Text = "Ответ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 147);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(thirdValue);
            Controls.Add(secondValue);
            Controls.Add(firstValue);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstValue;
        private TextBox secondValue;
        private TextBox thirdValue;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
