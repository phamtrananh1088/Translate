
namespace Anh.DB_definition_diagram__WRS
{
    partial class RD001201
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPTestKanji = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCountFail = new System.Windows.Forms.Label();
            this.lblCountSuccess = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.pnlKanji = new System.Windows.Forms.Panel();
            this.dgvKanji = new System.Windows.Forms.DataGridView();
            this.Han = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kanji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlHan = new System.Windows.Forms.Panel();
            this.tabPListKanji = new System.Windows.Forms.TabPage();
            this.txtKanji = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCountKanji = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPTestKanji.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKanji)).BeginInit();
            this.tabPListKanji.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 616);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPTestKanji);
            this.tabControl1.Controls.Add(this.tabPListKanji);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1351, 616);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPTestKanji
            // 
            this.tabPTestKanji.Controls.Add(this.panel3);
            this.tabPTestKanji.Controls.Add(this.btnShuffle);
            this.tabPTestKanji.Controls.Add(this.pnlKanji);
            this.tabPTestKanji.Controls.Add(this.dgvKanji);
            this.tabPTestKanji.Controls.Add(this.btnReset);
            this.tabPTestKanji.Controls.Add(this.pnlHan);
            this.tabPTestKanji.Location = new System.Drawing.Point(4, 22);
            this.tabPTestKanji.Name = "tabPTestKanji";
            this.tabPTestKanji.Padding = new System.Windows.Forms.Padding(3);
            this.tabPTestKanji.Size = new System.Drawing.Size(1343, 590);
            this.tabPTestKanji.TabIndex = 1;
            this.tabPTestKanji.Text = "Test Kanji";
            this.tabPTestKanji.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(0)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblCountKanji);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Controls.Add(this.lblCountFail);
            this.panel3.Controls.Add(this.lblCountSuccess);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(1019, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 155);
            this.panel3.TabIndex = 5;
            // 
            // lblCountFail
            // 
            this.lblCountFail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCountFail.Location = new System.Drawing.Point(207, 115);
            this.lblCountFail.Name = "lblCountFail";
            this.lblCountFail.Size = new System.Drawing.Size(49, 23);
            this.lblCountFail.TabIndex = 4;
            this.lblCountFail.Text = "0";
            // 
            // lblCountSuccess
            // 
            this.lblCountSuccess.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCountSuccess.Location = new System.Drawing.Point(59, 115);
            this.lblCountSuccess.Name = "lblCountSuccess";
            this.lblCountSuccess.Size = new System.Drawing.Size(44, 23);
            this.lblCountSuccess.TabIndex = 3;
            this.lblCountSuccess.Text = "0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(156, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fail";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(187)))), ((int)(((byte)(4)))));
            this.label2.Font = new System.Drawing.Font("Meiryo", 9F);
            this.label2.Location = new System.Drawing.Point(152, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 111);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Success";
            // 
            // btnShuffle
            // 
            this.btnShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShuffle.Location = new System.Drawing.Point(102, 554);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(90, 30);
            this.btnShuffle.TabIndex = 4;
            this.btnShuffle.Text = "SHUFFLE";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // pnlKanji
            // 
            this.pnlKanji.AutoScroll = true;
            this.pnlKanji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKanji.Location = new System.Drawing.Point(513, 7);
            this.pnlKanji.Name = "pnlKanji";
            this.pnlKanji.Size = new System.Drawing.Size(500, 540);
            this.pnlKanji.TabIndex = 3;
            // 
            // dgvKanji
            // 
            this.dgvKanji.AllowUserToAddRows = false;
            this.dgvKanji.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKanji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKanji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKanji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Han,
            this.Kanji});
            this.dgvKanji.Location = new System.Drawing.Point(1019, 177);
            this.dgvKanji.Name = "dgvKanji";
            this.dgvKanji.RowTemplate.Height = 21;
            this.dgvKanji.Size = new System.Drawing.Size(311, 370);
            this.dgvKanji.TabIndex = 2;
            this.dgvKanji.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvKanji_RowPostPaint);
            // 
            // Han
            // 
            this.Han.HeaderText = "Hán";
            this.Han.Name = "Han";
            this.Han.Width = 150;
            // 
            // Kanji
            // 
            this.Kanji.HeaderText = "Kanji";
            this.Kanji.Name = "Kanji";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Location = new System.Drawing.Point(6, 554);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 30);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlHan
            // 
            this.pnlHan.AutoScroll = true;
            this.pnlHan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHan.Location = new System.Drawing.Point(7, 7);
            this.pnlHan.Name = "pnlHan";
            this.pnlHan.Size = new System.Drawing.Size(500, 540);
            this.pnlHan.TabIndex = 0;
            // 
            // tabPListKanji
            // 
            this.tabPListKanji.Controls.Add(this.txtKanji);
            this.tabPListKanji.Location = new System.Drawing.Point(4, 22);
            this.tabPListKanji.Name = "tabPListKanji";
            this.tabPListKanji.Padding = new System.Windows.Forms.Padding(3);
            this.tabPListKanji.Size = new System.Drawing.Size(1343, 590);
            this.tabPListKanji.TabIndex = 0;
            this.tabPListKanji.Text = "List Kanji";
            this.tabPListKanji.UseVisualStyleBackColor = true;
            // 
            // txtKanji
            // 
            this.txtKanji.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKanji.Location = new System.Drawing.Point(6, 6);
            this.txtKanji.Multiline = true;
            this.txtKanji.Name = "txtKanji";
            this.txtKanji.ReadOnly = true;
            this.txtKanji.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKanji.Size = new System.Drawing.Size(1091, 570);
            this.txtKanji.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 635);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1376, 43);
            this.panel2.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(132, 2);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(45, 23);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountKanji
            // 
            this.lblCountKanji.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCountKanji.Location = new System.Drawing.Point(3, 2);
            this.lblCountKanji.Name = "lblCountKanji";
            this.lblCountKanji.Size = new System.Drawing.Size(123, 23);
            this.lblCountKanji.TabIndex = 7;
            this.lblCountKanji.Text = "Total";
            this.lblCountKanji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RD001201
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 678);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RD001201";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kanji";
            this.Load += new System.EventHandler(this.RD001201_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPTestKanji.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKanji)).EndInit();
            this.tabPListKanji.ResumeLayout(false);
            this.tabPListKanji.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKanji;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPListKanji;
        private System.Windows.Forms.TabPage tabPTestKanji;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlHan;
        private System.Windows.Forms.DataGridView dgvKanji;
        private System.Windows.Forms.Panel pnlKanji;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCountFail;
        private System.Windows.Forms.Label lblCountSuccess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Han;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kanji;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCountKanji;
    }
}