
namespace SQLCRACKER
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.buttonStartStage = new System.Windows.Forms.Button();
            this.labelChooseFile = new System.Windows.Forms.Label();
            this.buttonStartChoice = new System.Windows.Forms.Button();
            this.buttonShowRank = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectUser = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonContact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartStage
            // 
            this.buttonStartStage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(216)))), ((int)(((byte)(176)))));
            this.buttonStartStage.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonStartStage, "buttonStartStage");
            this.buttonStartStage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonStartStage.Name = "buttonStartStage";
            this.buttonStartStage.UseVisualStyleBackColor = false;
            this.buttonStartStage.Click += new System.EventHandler(this.buttonStartStageClick);
            // 
            // labelChooseFile
            // 
            resources.ApplyResources(this.labelChooseFile, "labelChooseFile");
            this.labelChooseFile.BackColor = System.Drawing.Color.White;
            this.labelChooseFile.Name = "labelChooseFile";
            this.labelChooseFile.Click += new System.EventHandler(this.labelChooseFileClick);
            // 
            // buttonStartChoice
            // 
            this.buttonStartChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(216)))), ((int)(((byte)(176)))));
            this.buttonStartChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonStartChoice, "buttonStartChoice");
            this.buttonStartChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonStartChoice.Name = "buttonStartChoice";
            this.buttonStartChoice.UseVisualStyleBackColor = false;
            this.buttonStartChoice.Click += new System.EventHandler(this.startChoiceClick);
            // 
            // buttonShowRank
            // 
            this.buttonShowRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(216)))), ((int)(((byte)(176)))));
            this.buttonShowRank.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonShowRank, "buttonShowRank");
            this.buttonShowRank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonShowRank.Name = "buttonShowRank";
            this.buttonShowRank.UseVisualStyleBackColor = false;
            this.buttonShowRank.Click += new System.EventHandler(this.showRankClick);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::SQLCRACKER.Properties.Resources.backBlockAndCastle;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // selectUser
            // 
            this.selectUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(216)))), ((int)(((byte)(176)))));
            this.selectUser.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.selectUser, "selectUser");
            this.selectUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.selectUser.Name = "selectUser";
            this.selectUser.UseVisualStyleBackColor = false;
            this.selectUser.Click += new System.EventHandler(this.selectUserClick);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::SQLCRACKER.Properties.Resources.title;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // buttonContact
            // 
            this.buttonContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(216)))), ((int)(((byte)(176)))));
            this.buttonContact.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonContact, "buttonContact");
            this.buttonContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonContact.Name = "buttonContact";
            this.buttonContact.UseVisualStyleBackColor = false;
            this.buttonContact.Click += new System.EventHandler(this.buttonContact_Click);
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.selectUser);
            this.Controls.Add(this.buttonShowRank);
            this.Controls.Add(this.buttonStartChoice);
            this.Controls.Add(this.labelChooseFile);
            this.Controls.Add(this.buttonStartStage);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartStage;
        private System.Windows.Forms.Label labelChooseFile;
        private System.Windows.Forms.Button buttonStartChoice;
        private System.Windows.Forms.Button buttonShowRank;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button selectUser;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonContact;
    }
}

