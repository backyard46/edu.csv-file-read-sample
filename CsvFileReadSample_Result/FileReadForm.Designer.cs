namespace CsvFileReadSample_Result
{
    partial class FileReadForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonFileSelect = new System.Windows.Forms.Button();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridMainData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSJIS = new System.Windows.Forms.RadioButton();
            this.radioUTF = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBar = new System.Windows.Forms.RadioButton();
            this.radioComma = new System.Windows.Forms.RadioButton();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonClose);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 365);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(752, 53);
            this.panelBottom.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(616, 8);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(128, 40);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonWrite);
            this.panelTop.Controls.Add(this.groupBox2);
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Controls.Add(this.buttonFileSelect);
            this.panelTop.Controls.Add(this.textFileName);
            this.panelTop.Controls.Add(this.buttonOpenFile);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(752, 96);
            this.panelTop.TabIndex = 0;
            // 
            // buttonFileSelect
            // 
            this.buttonFileSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFileSelect.BackgroundImage = global::CsvFileReadSample_Result.Properties.Resources.Folder_16x;
            this.buttonFileSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFileSelect.Location = new System.Drawing.Point(709, 55);
            this.buttonFileSelect.Name = "buttonFileSelect";
            this.buttonFileSelect.Size = new System.Drawing.Size(28, 28);
            this.buttonFileSelect.TabIndex = 4;
            this.buttonFileSelect.UseVisualStyleBackColor = true;
            this.buttonFileSelect.Click += new System.EventHandler(this.buttonFileSelect_Click);
            // 
            // textFileName
            // 
            this.textFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFileName.Location = new System.Drawing.Point(16, 56);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(688, 27);
            this.textFileName.TabIndex = 3;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(16, 8);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(128, 40);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "ファイルを開く";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridMainData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 269);
            this.panel1.TabIndex = 3;
            // 
            // gridMainData
            // 
            this.gridMainData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMainData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMainData.Location = new System.Drawing.Point(0, 0);
            this.gridMainData.Name = "gridMainData";
            this.gridMainData.RowTemplate.Height = 21;
            this.gridMainData.Size = new System.Drawing.Size(752, 269);
            this.gridMainData.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSJIS);
            this.groupBox1.Controls.Add(this.radioUTF);
            this.groupBox1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(296, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 40);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文字コード";
            // 
            // radioSJIS
            // 
            this.radioSJIS.AutoSize = true;
            this.radioSJIS.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioSJIS.Location = new System.Drawing.Point(72, 16);
            this.radioSJIS.Name = "radioSJIS";
            this.radioSJIS.Size = new System.Drawing.Size(74, 19);
            this.radioSJIS.TabIndex = 4;
            this.radioSJIS.Text = "Shift JIS";
            this.radioSJIS.UseVisualStyleBackColor = true;
            // 
            // radioUTF
            // 
            this.radioUTF.AutoSize = true;
            this.radioUTF.Checked = true;
            this.radioUTF.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioUTF.Location = new System.Drawing.Point(8, 16);
            this.radioUTF.Name = "radioUTF";
            this.radioUTF.Size = new System.Drawing.Size(61, 19);
            this.radioUTF.TabIndex = 3;
            this.radioUTF.TabStop = true;
            this.radioUTF.Text = "UTF-8";
            this.radioUTF.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBar);
            this.groupBox2.Controls.Add(this.radioComma);
            this.groupBox2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(472, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 40);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "区切り文字";
            // 
            // radioBar
            // 
            this.radioBar.AutoSize = true;
            this.radioBar.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioBar.Location = new System.Drawing.Point(72, 16);
            this.radioBar.Name = "radioBar";
            this.radioBar.Size = new System.Drawing.Size(49, 19);
            this.radioBar.TabIndex = 4;
            this.radioBar.Text = "縦棒";
            this.radioBar.UseVisualStyleBackColor = true;
            // 
            // radioComma
            // 
            this.radioComma.AutoSize = true;
            this.radioComma.Checked = true;
            this.radioComma.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioComma.Location = new System.Drawing.Point(8, 16);
            this.radioComma.Name = "radioComma";
            this.radioComma.Size = new System.Drawing.Size(52, 19);
            this.radioComma.TabIndex = 3;
            this.radioComma.TabStop = true;
            this.radioComma.Text = "カンマ";
            this.radioComma.UseVisualStyleBackColor = true;
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(152, 8);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(128, 40);
            this.buttonWrite.TabIndex = 7;
            this.buttonWrite.Text = "ファイルを保存する";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // FileReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FileReadForm";
            this.Text = "CSVファイル読み込み";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileReadForm_FormClosing);
            this.Load += new System.EventHandler(this.FileReadForm_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMainData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridMainData;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonFileSelect;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBar;
        private System.Windows.Forms.RadioButton radioComma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSJIS;
        private System.Windows.Forms.RadioButton radioUTF;
        private System.Windows.Forms.Button buttonWrite;
    }
}

