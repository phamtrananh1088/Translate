
namespace Anh.DB_definition_diagram__WRS
{
    partial class Test
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
            this.btnJdict = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtInputTest = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJdict
            // 
            this.btnJdict.Location = new System.Drawing.Point(253, 116);
            this.btnJdict.Name = "btnJdict";
            this.btnJdict.Size = new System.Drawing.Size(75, 23);
            this.btnJdict.TabIndex = 0;
            this.btnJdict.Text = "Jdict";
            this.btnJdict.UseVisualStyleBackColor = true;
            this.btnJdict.Click += new System.EventHandler(this.btnJdict_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(16, 14);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 12);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "label1";
            // 
            // txtInputTest
            // 
            this.txtInputTest.Location = new System.Drawing.Point(106, 63);
            this.txtInputTest.Multiline = true;
            this.txtInputTest.Name = "txtInputTest";
            this.txtInputTest.Size = new System.Drawing.Size(222, 47);
            this.txtInputTest.TabIndex = 2;
            this.txtInputTest.Text = "優先でESS連携仕様に関してご相談です。";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Location = new System.Drawing.Point(106, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 263);
            this.panel1.TabIndex = 3;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtInputTest);
            this.Controls.Add(this.btnJdict);
            this.Name = "Test";
            this.Text = "Test";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJdict;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtInputTest;
        private System.Windows.Forms.Panel panel1;
    }
}