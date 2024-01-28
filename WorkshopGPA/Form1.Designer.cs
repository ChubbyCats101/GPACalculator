namespace WorkshopGPA
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
            namestudnet = new Label();
            score_label1 = new Label();
            name_textBox = new TextBox();
            score_textBox = new TextBox();
            Save_button = new Button();
            GPA_label1 = new Label();
            AVGscore_label1 = new Label();
            lowestscore_label = new Label();
            highestscore_Label = new Label();
            label1 = new Label();
            MaxName = new TextBox();
            MaxSC = new TextBox();
            label2 = new Label();
            MinName = new TextBox();
            MinSC = new TextBox();
            AVG_Score = new TextBox();
            GPA_textbox = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // namestudnet
            // 
            namestudnet.AutoSize = true;
            namestudnet.BackColor = Color.White;
            namestudnet.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namestudnet.ForeColor = Color.Black;
            namestudnet.Location = new Point(89, 25);
            namestudnet.Name = "namestudnet";
            namestudnet.Size = new Size(69, 30);
            namestudnet.TabIndex = 0;
            namestudnet.Text = "Name";
            // 
            // score_label1
            // 
            score_label1.AutoSize = true;
            score_label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            score_label1.Location = new Point(94, 66);
            score_label1.Name = "score_label1";
            score_label1.Size = new Size(64, 30);
            score_label1.TabIndex = 1;
            score_label1.Text = "Score";
            // 
            // name_textBox
            // 
            name_textBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name_textBox.Location = new Point(167, 25);
            name_textBox.Margin = new Padding(3, 2, 3, 2);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(193, 35);
            name_textBox.TabIndex = 2;
            // 
            // score_textBox
            // 
            score_textBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            score_textBox.Location = new Point(167, 73);
            score_textBox.Margin = new Padding(3, 2, 3, 2);
            score_textBox.Name = "score_textBox";
            score_textBox.Size = new Size(98, 35);
            score_textBox.TabIndex = 3;
            // 
            // Save_button
            // 
            Save_button.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Save_button.Location = new Point(193, 112);
            Save_button.Margin = new Padding(3, 2, 3, 2);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(148, 45);
            Save_button.TabIndex = 4;
            Save_button.Text = "SAVE";
            Save_button.UseVisualStyleBackColor = true;
            Save_button.Click += Save_button_Click;
            // 
            // GPA_label1
            // 
            GPA_label1.AutoSize = true;
            GPA_label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GPA_label1.Location = new Point(66, 343);
            GPA_label1.Name = "GPA_label1";
            GPA_label1.Size = new Size(47, 25);
            GPA_label1.TabIndex = 5;
            GPA_label1.Text = "GPA";
            // 
            // AVGscore_label1
            // 
            AVGscore_label1.AutoSize = true;
            AVGscore_label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AVGscore_label1.Location = new Point(32, 292);
            AVGscore_label1.Name = "AVGscore_label1";
            AVGscore_label1.Size = new Size(98, 25);
            AVGscore_label1.TabIndex = 6;
            AVGscore_label1.Text = "คะแนนเฉลี่ย";
            // 
            // lowestscore_label
            // 
            lowestscore_label.AutoSize = true;
            lowestscore_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lowestscore_label.Location = new Point(32, 248);
            lowestscore_label.Name = "lowestscore_label";
            lowestscore_label.Size = new Size(102, 25);
            lowestscore_label.TabIndex = 8;
            lowestscore_label.Text = "คะแนนต่ำสุด";
            // 
            // highestscore_Label
            // 
            highestscore_Label.AutoSize = true;
            highestscore_Label.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            highestscore_Label.Location = new Point(33, 202);
            highestscore_Label.Name = "highestscore_Label";
            highestscore_Label.Size = new Size(99, 25);
            highestscore_Label.TabIndex = 7;
            highestscore_Label.Text = "คะแนนสูงสุด";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 175);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 9;
            label1.Text = "Name";
            // 
            // MaxName
            // 
            MaxName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaxName.Location = new Point(167, 202);
            MaxName.Margin = new Padding(3, 2, 3, 2);
            MaxName.Name = "MaxName";
            MaxName.Size = new Size(193, 33);
            MaxName.TabIndex = 10;
            // 
            // MaxSC
            // 
            MaxSC.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaxSC.Location = new Point(402, 202);
            MaxSC.Margin = new Padding(3, 2, 3, 2);
            MaxSC.Name = "MaxSC";
            MaxSC.Size = new Size(98, 33);
            MaxSC.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(423, 175);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 12;
            label2.Text = "Score";
            // 
            // MinName
            // 
            MinName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinName.Location = new Point(167, 248);
            MinName.Margin = new Padding(3, 2, 3, 2);
            MinName.Name = "MinName";
            MinName.Size = new Size(193, 33);
            MinName.TabIndex = 13;
            // 
            // MinSC
            // 
            MinSC.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinSC.Location = new Point(402, 248);
            MinSC.Margin = new Padding(3, 2, 3, 2);
            MinSC.Name = "MinSC";
            MinSC.Size = new Size(98, 33);
            MinSC.TabIndex = 14;
            // 
            // AVG_Score
            // 
            AVG_Score.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AVG_Score.Location = new Point(167, 285);
            AVG_Score.Margin = new Padding(3, 2, 3, 2);
            AVG_Score.Name = "AVG_Score";
            AVG_Score.Size = new Size(98, 33);
            AVG_Score.TabIndex = 15;
            // 
            // GPA_textbox
            // 
            GPA_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GPA_textbox.Location = new Point(119, 343);
            GPA_textbox.Margin = new Padding(3, 2, 3, 2);
            GPA_textbox.Name = "GPA_textbox";
            GPA_textbox.Size = new Size(98, 33);
            GPA_textbox.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cat_cats1;
            pictureBox1.Location = new Point(411, 291);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 85);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._489ohv5xzvf31;
            ClientSize = new Size(555, 388);
            Controls.Add(pictureBox1);
            Controls.Add(GPA_textbox);
            Controls.Add(AVG_Score);
            Controls.Add(MinSC);
            Controls.Add(MinName);
            Controls.Add(label2);
            Controls.Add(MaxSC);
            Controls.Add(MaxName);
            Controls.Add(label1);
            Controls.Add(lowestscore_label);
            Controls.Add(highestscore_Label);
            Controls.Add(AVGscore_label1);
            Controls.Add(GPA_label1);
            Controls.Add(Save_button);
            Controls.Add(score_textBox);
            Controls.Add(name_textBox);
            Controls.Add(score_label1);
            Controls.Add(namestudnet);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namestudnet;
        private Label score_label1;
        private TextBox name_textBox;
        private TextBox score_textBox;
        private Button Save_button;
        private Label GPA_label1;
        private Label AVGscore_label1;
        private Label lowestscore_label;
        private Label highestscore_Label;
        private Label label1;
        private TextBox MaxName;
        private TextBox MaxSC;
        private Label label2;
        private TextBox MinName;
        private TextBox MinSC;
        private TextBox AVG_Score;
        private TextBox GPA_textbox;
        private PictureBox pictureBox1;
    }
}
