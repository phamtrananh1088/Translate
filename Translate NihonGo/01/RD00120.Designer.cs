namespace Anh.DB_definition_diagram__WRS
{
    partial class RD00120
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtExcelName = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnPre = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbSheetName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbSelectSheet = new System.Windows.Forms.RadioButton();
            this.rbAllSheet = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbRangeSheet = new System.Windows.Forms.RadioButton();
            this.numF = new System.Windows.Forms.NumericUpDown();
            this.numT = new System.Windows.Forms.NumericUpDown();
            this.TO = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.lblRow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKanji = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtExcelName
            // 
            this.txtExcelName.BackColor = System.Drawing.Color.LightYellow;
            this.txtExcelName.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtExcelName.Location = new System.Drawing.Point(130, 15);
            this.txtExcelName.Name = "txtExcelName";
            this.txtExcelName.ReadOnly = true;
            this.txtExcelName.Size = new System.Drawing.Size(359, 22);
            this.txtExcelName.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.LightGray;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.linkLabel1.Location = new System.Drawing.Point(10, 15);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(120, 22);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "FILE NAME";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnPre.Location = new System.Drawing.Point(10, 3);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(90, 30);
            this.btnPre.TabIndex = 0;
            this.btnPre.Text = "TRANSALTE";
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 193);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(510, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Step = 1;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(15, 17);
            this.toolStripStatusLabel3.Text = "1";
            // 
            // cbSheetName
            // 
            this.cbSheetName.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbSheetName.FormattingEnabled = true;
            this.cbSheetName.Location = new System.Drawing.Point(130, 69);
            this.cbSheetName.Name = "cbSheetName";
            this.cbSheetName.Size = new System.Drawing.Size(148, 24);
            this.cbSheetName.TabIndex = 5;
            this.cbSheetName.DropDown += new System.EventHandler(this.cbSheetName_DropDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "SHEET NAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbSelectSheet
            // 
            this.rbSelectSheet.AutoSize = true;
            this.rbSelectSheet.Checked = true;
            this.rbSelectSheet.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rbSelectSheet.Location = new System.Drawing.Point(3, 0);
            this.rbSelectSheet.Name = "rbSelectSheet";
            this.rbSelectSheet.Size = new System.Drawing.Size(79, 20);
            this.rbSelectSheet.TabIndex = 0;
            this.rbSelectSheet.TabStop = true;
            this.rbSelectSheet.Text = "Specified";
            this.rbSelectSheet.UseVisualStyleBackColor = true;
            this.rbSelectSheet.CheckedChanged += new System.EventHandler(this.rbSelectSheet_CheckedChanged);
            // 
            // rbAllSheet
            // 
            this.rbAllSheet.AutoSize = true;
            this.rbAllSheet.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rbAllSheet.Location = new System.Drawing.Point(203, 0);
            this.rbAllSheet.Name = "rbAllSheet";
            this.rbAllSheet.Size = new System.Drawing.Size(79, 20);
            this.rbAllSheet.TabIndex = 2;
            this.rbAllSheet.TabStop = true;
            this.rbAllSheet.Text = "All Sheet";
            this.rbAllSheet.UseVisualStyleBackColor = true;
            this.rbAllSheet.CheckedChanged += new System.EventHandler(this.rbAllSheet_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "SHEET OPTION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbRangeSheet);
            this.panel1.Controls.Add(this.rbSelectSheet);
            this.panel1.Controls.Add(this.rbAllSheet);
            this.panel1.Location = new System.Drawing.Point(130, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 22);
            this.panel1.TabIndex = 3;
            // 
            // rbRangeSheet
            // 
            this.rbRangeSheet.AutoSize = true;
            this.rbRangeSheet.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rbRangeSheet.Location = new System.Drawing.Point(112, 0);
            this.rbRangeSheet.Name = "rbRangeSheet";
            this.rbRangeSheet.Size = new System.Drawing.Size(63, 20);
            this.rbRangeSheet.TabIndex = 1;
            this.rbRangeSheet.TabStop = true;
            this.rbRangeSheet.Text = "Range";
            this.rbRangeSheet.UseVisualStyleBackColor = true;
            this.rbRangeSheet.CheckedChanged += new System.EventHandler(this.rbRangeSheet_CheckedChanged);
            // 
            // numF
            // 
            this.numF.Enabled = false;
            this.numF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.numF.Location = new System.Drawing.Point(130, 96);
            this.numF.Name = "numF";
            this.numF.Size = new System.Drawing.Size(90, 22);
            this.numF.TabIndex = 7;
            this.numF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numF.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numT
            // 
            this.numT.Enabled = false;
            this.numT.Font = new System.Drawing.Font("Arial", 9.75F);
            this.numT.Location = new System.Drawing.Point(257, 96);
            this.numT.Name = "numT";
            this.numT.Size = new System.Drawing.Size(90, 22);
            this.numT.TabIndex = 9;
            this.numT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TO
            // 
            this.TO.BackColor = System.Drawing.Color.LightGray;
            this.TO.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TO.Location = new System.Drawing.Point(220, 96);
            this.TO.Name = "TO";
            this.TO.Size = new System.Drawing.Size(38, 22);
            this.TO.TabIndex = 8;
            this.TO.Text = "~";
            this.TO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRow
            // 
            this.txtRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRow.Location = new System.Drawing.Point(130, 123);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(90, 22);
            this.txtRow.TabIndex = 11;
            this.txtRow.Text = "0";
            this.txtRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRow_KeyPress);
            // 
            // lblRow
            // 
            this.lblRow.BackColor = System.Drawing.Color.LightGray;
            this.lblRow.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblRow.Location = new System.Drawing.Point(10, 123);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(120, 22);
            this.lblRow.TabIndex = 10;
            this.lblRow.Text = "ROW START";
            this.lblRow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(10, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "SHEET RANGE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnKanji);
            this.panel2.Controls.Add(this.btnPre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 37);
            this.panel2.TabIndex = 12;
            // 
            // btnKanji
            // 
            this.btnKanji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnKanji.Location = new System.Drawing.Point(106, 3);
            this.btnKanji.Name = "btnKanji";
            this.btnKanji.Size = new System.Drawing.Size(90, 30);
            this.btnKanji.TabIndex = 1;
            this.btnKanji.Text = "KANJI";
            this.btnKanji.UseVisualStyleBackColor = false;
            this.btnKanji.Click += new System.EventHandler(this.btnKanji_Click);
            // 
            // RD00120
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 215);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.TO);
            this.Controls.Add(this.numT);
            this.Controls.Add(this.numF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSheetName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtExcelName);
            this.Name = "RD00120";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translate WorkBook(.xls) [ja->en,vi]";
            this.Load += new System.EventHandler(this.RD00120_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtExcelName;
        private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button btnPre;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ComboBox cbSheetName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbSelectSheet;
		private System.Windows.Forms.RadioButton rbAllSheet;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.RadioButton rbRangeSheet;
		private System.Windows.Forms.NumericUpDown numF;
		private System.Windows.Forms.NumericUpDown numT;
		private System.Windows.Forms.Label TO;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKanji;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

