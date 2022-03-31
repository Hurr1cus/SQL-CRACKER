namespace SQLCRACKER {
    partial class rank {
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelStage = new System.Windows.Forms.Label();
            this.labelChoice = new System.Windows.Forms.Label();
            this.labelCoin = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelName.Location = new System.Drawing.Point(42, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(324, 46);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "你好，！";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelInfo.Location = new System.Drawing.Point(83, 93);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(230, 189);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "到现在为止，你已经\r\n\r\n通过了                       关\r\n\r\n答对了                       题\r\n\r\n拥有金钱";
            // 
            // labelStage
            // 
            this.labelStage.BackColor = System.Drawing.Color.Transparent;
            this.labelStage.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelStage.Location = new System.Drawing.Point(174, 131);
            this.labelStage.Name = "labelStage";
            this.labelStage.Size = new System.Drawing.Size(81, 52);
            this.labelStage.TabIndex = 2;
            this.labelStage.Text = "0";
            this.labelStage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChoice
            // 
            this.labelChoice.BackColor = System.Drawing.Color.Transparent;
            this.labelChoice.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelChoice.Location = new System.Drawing.Point(174, 186);
            this.labelChoice.Name = "labelChoice";
            this.labelChoice.Size = new System.Drawing.Size(81, 52);
            this.labelChoice.TabIndex = 3;
            this.labelChoice.Text = "0";
            this.labelChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCoin
            // 
            this.labelCoin.BackColor = System.Drawing.Color.Transparent;
            this.labelCoin.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelCoin.Location = new System.Drawing.Point(174, 238);
            this.labelCoin.Name = "labelCoin";
            this.labelCoin.Size = new System.Drawing.Size(139, 52);
            this.labelCoin.TabIndex = 4;
            this.labelCoin.Text = "0";
            this.labelCoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(323, 188);
            this.dataGridView1.TabIndex = 5;
            // 
            // rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SQLCRACKER.Properties.Resources.BackBlock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 531);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelCoin);
            this.Controls.Add(this.labelChoice);
            this.Controls.Add(this.labelStage);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelName);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rank";
            this.ShowInTaskbar = false;
            this.Text = "排行榜";
            this.Load += new System.EventHandler(this.Ranking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelStage;
        private System.Windows.Forms.Label labelChoice;
        private System.Windows.Forms.Label labelCoin;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}