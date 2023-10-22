namespace LAB_3_SE
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
            solutionButton = new Button();
            projectTypeComboBox = new ComboBox();
            effortLable = new Label();
            timeToLable = new Label();
            developersLable = new Label();
            codeSizeTxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            productivityLable = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // solutionButton
            // 
            solutionButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            solutionButton.Location = new Point(23, 204);
            solutionButton.Name = "solutionButton";
            solutionButton.Size = new Size(142, 35);
            solutionButton.TabIndex = 0;
            solutionButton.Text = "Розрахувати";
            solutionButton.UseVisualStyleBackColor = true;
            solutionButton.Click += solutionButton_Click;
            // 
            // projectTypeComboBox
            // 
            projectTypeComboBox.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            projectTypeComboBox.FormattingEnabled = true;
            projectTypeComboBox.Location = new Point(34, 69);
            projectTypeComboBox.Name = "projectTypeComboBox";
            projectTypeComboBox.Size = new Size(199, 34);
            projectTypeComboBox.TabIndex = 1;
            projectTypeComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // effortLable
            // 
            effortLable.AutoSize = true;
            effortLable.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            effortLable.Location = new Point(365, 69);
            effortLable.Name = "effortLable";
            effortLable.Size = new Size(62, 26);
            effortLable.TabIndex = 2;
            effortLable.Text = "label1";
            effortLable.Click += label1_Click;
            // 
            // timeToLable
            // 
            timeToLable.AutoSize = true;
            timeToLable.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            timeToLable.Location = new Point(362, 112);
            timeToLable.Name = "timeToLable";
            timeToLable.Size = new Size(65, 26);
            timeToLable.TabIndex = 3;
            timeToLable.Text = "label2";
            // 
            // developersLable
            // 
            developersLable.AutoSize = true;
            developersLable.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            developersLable.Location = new Point(362, 158);
            developersLable.Name = "developersLable";
            developersLable.Size = new Size(65, 26);
            developersLable.TabIndex = 4;
            developersLable.Text = "label3";
            // 
            // codeSizeTxtBox
            // 
            codeSizeTxtBox.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            codeSizeTxtBox.Location = new Point(34, 150);
            codeSizeTxtBox.Name = "codeSizeTxtBox";
            codeSizeTxtBox.Size = new Size(121, 34);
            codeSizeTxtBox.TabIndex = 5;
            codeSizeTxtBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(201, 26);
            label1.TabIndex = 6;
            label1.Text = "Оберіть тип проекту:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 112);
            label2.Name = "label2";
            label2.Size = new Size(144, 26);
            label2.TabIndex = 7;
            label2.Text = "Введіть KSLOC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(301, 69);
            label3.Name = "label3";
            label3.Size = new Size(45, 26);
            label3.TabIndex = 8;
            label3.Text = "PM:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(298, 112);
            label4.Name = "label4";
            label4.Size = new Size(48, 26);
            label4.TabIndex = 9;
            label4.Text = "TM:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(300, 158);
            label5.Name = "label5";
            label5.Size = new Size(44, 26);
            label5.TabIndex = 10;
            label5.Text = "SS:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(301, 204);
            label6.Name = "label6";
            label6.Size = new Size(28, 26);
            label6.TabIndex = 11;
            label6.Text = "P:";
            label6.Click += label6_Click;
            // 
            // productivityLable
            // 
            productivityLable.AutoSize = true;
            productivityLable.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            productivityLable.Location = new Point(362, 204);
            productivityLable.Name = "productivityLable";
            productivityLable.Size = new Size(65, 26);
            productivityLable.TabIndex = 12;
            productivityLable.Text = "label7";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(301, 36);
            label7.Name = "label7";
            label7.Size = new Size(111, 26);
            label7.TabIndex = 13;
            label7.Text = "Результати";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 261);
            Controls.Add(label7);
            Controls.Add(productivityLable);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(codeSizeTxtBox);
            Controls.Add(developersLable);
            Controls.Add(timeToLable);
            Controls.Add(effortLable);
            Controls.Add(projectTypeComboBox);
            Controls.Add(solutionButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button solutionButton;
        private ComboBox projectTypeComboBox;
        private Label effortLable;
        private Label timeToLable;
        private Label developersLable;
        private TextBox codeSizeTxtBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label productivityLable;
        private Label label7;
    }
}