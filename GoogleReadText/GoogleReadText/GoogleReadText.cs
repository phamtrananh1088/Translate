using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Anh.Translate;

namespace Anh.GoRe
{
    public partial class GoogleReadText : Form
    {
        static string sPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "translated.mp3");
        public GoogleReadText()
        {
            InitializeComponent();
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCon.Text.Trim()))
            {
                MessageBox.Show("日本語を入力してください。","Google Read Text",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            var trans = new ActionF1();
            byte[] b2 = await trans.Translate_tts(txtCon.Text.Trim(), "ja");
            using (BinaryWriter w = new BinaryWriter(File.Open(sPath, FileMode.Create)))
            {
                w.Write(b2);
            }
            MessageBox.Show("終了しました。", "Google Read Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
