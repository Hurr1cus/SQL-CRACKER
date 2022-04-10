namespace SQLCRACKER {
    partial class testChoice {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCurrentQuestion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabeTotalQuestion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.buttonChoice0 = new System.Windows.Forms.Button();
            this.buttonChoice1 = new System.Windows.Forms.Button();
            this.buttonChoice2 = new System.Windows.Forms.Button();
            this.buttonChoice3 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCurrentQuestion,
            this.toolStripStatusLabeTotalQuestion,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 393);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(718, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCurrentQuestion
            // 
            this.toolStripStatusLabelCurrentQuestion.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabelCurrentQuestion.Name = "toolStripStatusLabelCurrentQuestion";
            this.toolStripStatusLabelCurrentQuestion.Size = new System.Drawing.Size(66, 21);
            this.toolStripStatusLabelCurrentQuestion.Text = "当前第?题";
            // 
            // toolStripStatusLabeTotalQuestion
            // 
            this.toolStripStatusLabeTotalQuestion.Name = "toolStripStatusLabeTotalQuestion";
            this.toolStripStatusLabeTotalQuestion.Size = new System.Drawing.Size(58, 21);
            this.toolStripStatusLabeTotalQuestion.Text = "总共10题";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 20);
            this.toolStripProgressBar1.Value = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.labelQuestion);
            this.panel1.Location = new System.Drawing.Point(24, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 80);
            this.panel1.TabIndex = 1;
            // 
            // labelQuestion
            // 
            this.labelQuestion.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelQuestion.Location = new System.Drawing.Point(15, 11);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(638, 56);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "这里是问题描述";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.Color.Transparent;
            this.labelA.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA.ForeColor = System.Drawing.Color.Chocolate;
            this.labelA.Location = new System.Drawing.Point(28, 137);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(30, 30);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.BackColor = System.Drawing.Color.Transparent;
            this.labelB.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelB.ForeColor = System.Drawing.Color.Chocolate;
            this.labelB.Location = new System.Drawing.Point(28, 203);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(28, 30);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "B";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.BackColor = System.Drawing.Color.Transparent;
            this.labelC.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelC.ForeColor = System.Drawing.Color.Chocolate;
            this.labelC.Location = new System.Drawing.Point(28, 266);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(28, 30);
            this.labelC.TabIndex = 4;
            this.labelC.Text = "C";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.BackColor = System.Drawing.Color.Transparent;
            this.labelD.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelD.ForeColor = System.Drawing.Color.Chocolate;
            this.labelD.Location = new System.Drawing.Point(28, 332);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(30, 30);
            this.labelD.TabIndex = 5;
            this.labelD.Text = "D";
            // 
            // buttonChoice0
            // 
            this.buttonChoice0.BackColor = System.Drawing.Color.MistyRose;
            this.buttonChoice0.FlatAppearance.BorderSize = 0;
            this.buttonChoice0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoice0.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonChoice0.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonChoice0.Location = new System.Drawing.Point(70, 135);
            this.buttonChoice0.Name = "buttonChoice0";
            this.buttonChoice0.Size = new System.Drawing.Size(622, 35);
            this.buttonChoice0.TabIndex = 6;
            this.buttonChoice0.Text = "A选项";
            this.buttonChoice0.UseVisualStyleBackColor = false;
            this.buttonChoice0.Click += new System.EventHandler(this.optionClick);
            // 
            // buttonChoice1
            // 
            this.buttonChoice1.BackColor = System.Drawing.Color.MistyRose;
            this.buttonChoice1.FlatAppearance.BorderSize = 0;
            this.buttonChoice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoice1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonChoice1.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonChoice1.Location = new System.Drawing.Point(70, 201);
            this.buttonChoice1.Name = "buttonChoice1";
            this.buttonChoice1.Size = new System.Drawing.Size(622, 35);
            this.buttonChoice1.TabIndex = 7;
            this.buttonChoice1.Text = "B选项";
            this.buttonChoice1.UseVisualStyleBackColor = false;
            this.buttonChoice1.Click += new System.EventHandler(this.optionClick);
            // 
            // buttonChoice2
            // 
            this.buttonChoice2.BackColor = System.Drawing.Color.MistyRose;
            this.buttonChoice2.FlatAppearance.BorderSize = 0;
            this.buttonChoice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoice2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonChoice2.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonChoice2.Location = new System.Drawing.Point(71, 264);
            this.buttonChoice2.Name = "buttonChoice2";
            this.buttonChoice2.Size = new System.Drawing.Size(622, 35);
            this.buttonChoice2.TabIndex = 8;
            this.buttonChoice2.Text = "C选项";
            this.buttonChoice2.UseVisualStyleBackColor = false;
            this.buttonChoice2.Click += new System.EventHandler(this.optionClick);
            // 
            // buttonChoice3
            // 
            this.buttonChoice3.BackColor = System.Drawing.Color.MistyRose;
            this.buttonChoice3.FlatAppearance.BorderSize = 0;
            this.buttonChoice3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoice3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonChoice3.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonChoice3.Location = new System.Drawing.Point(70, 330);
            this.buttonChoice3.Name = "buttonChoice3";
            this.buttonChoice3.Size = new System.Drawing.Size(622, 35);
            this.buttonChoice3.TabIndex = 9;
            this.buttonChoice3.Text = "D选项";
            this.buttonChoice3.UseVisualStyleBackColor = false;
            this.buttonChoice3.Click += new System.EventHandler(this.optionClick);
            // 
            // testChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SQLCRACKER.Properties.Resources.BackBlock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 419);
            this.Controls.Add(this.buttonChoice3);
            this.Controls.Add(this.buttonChoice2);
            this.Controls.Add(this.buttonChoice1);
            this.Controls.Add(this.buttonChoice0);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "testChoice";
            this.ShowIcon = false;
            this.Text = " 做题";
            this.Load += new System.EventHandler(this.testChoice_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabeTotalQuestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        public System.Windows.Forms.Label labelQuestion;
        public System.Windows.Forms.Button buttonChoice0;
        public System.Windows.Forms.Button buttonChoice1;
        public System.Windows.Forms.Button buttonChoice2;
        public System.Windows.Forms.Button buttonChoice3;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCurrentQuestion;
    }
}