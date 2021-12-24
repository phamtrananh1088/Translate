using Anh.DB_definition_diagram__WRS.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Anh.DB_definition_diagram__WRS
{
    public partial class RD001201 : Form
    {
        private enum enumTab
        {
            List = 0,
            Kanji
        }
        List<Kanji> paramListKanji;
        Kanji theKanji = new Kanji() { kanji = "", hanviet = "" };
        Control lblHan = null;
        Control lblKanji = null;
        int iSuccess;
        int iFail;
        bool isCreateControlKanji = false;
        Timer timer = new Timer();
        int iTime;
        public RD001201()
        {
            InitializeComponent();
        }
        public RD001201(List<Kanji> listKanji)
        {
            InitializeComponent();
            paramListKanji = listKanji;
            paramListKanji = paramListKanji.Distinct(new KanjiComparer()).ToList();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }
        string[] colorYellows = { "#ffd600", "#ffea00", "#ffff00", "#ffff8d", "#f57f17", "#f9a825", "#fbc02d", "#fdd835", "#ffeb3b", "#ffee58", "#fff176", "#fff59d", "#fff9c4", "#fffde7" };
        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer timer1 = (Timer)sender;
            iTime++;
            lblTime.Text = (iTime / 60).ToString("00") + ":" + (iTime % 60).ToString("00");
            int i = (iTime / 60) % 14;
            Color color = System.Drawing.ColorTranslator.FromHtml(colorYellows[i]);
            lblTime.BackColor = color;
        }

        private void RD001201_Load(object sender, EventArgs e)
        {
            txtKanji.Text = String.Join("\r\n", paramListKanji.Select(u => u.ToString()));
            lblCountKanji.Text = "Total: " + paramListKanji.Count.ToString() + " kanji";
            LoadData();
            btnReset_Click(null, null);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pnlHan.Controls.Count; i++)
            {
                pnlHan.Controls[i].Text = paramListKanji[i].hanviet;
                pnlHan.Controls[i].BackColor = Color.LightGray;
                pnlKanji.Controls[i].Text = paramListKanji[i].kanji;
                pnlKanji.Controls[i].BackColor = Color.LightGray;
                theKanji.hanviet = "";
                theKanji.kanji = "";
                iSuccess = 0;
                iFail = 0;
                lblCountSuccess.Text = iSuccess.ToString();
                lblCountFail.Text = iFail.ToString();
                dgvKanji.Rows.Clear();
                iTime = 0;
                timer.Start();
            }

        }

        private void LoadData()
        {
            isCreateControlKanji = true;
            for (int i = 0, j = 0; i < paramListKanji.Count; i++)
            {
                if (i % 4 == 0) j++;
                // add control into panel Han
                Label label1 = new Label();
                label1.Font = new Font("Meiryo", 10F);
                label1.Location = new Point(9 + 105 * (i % 4), 9 + 30 * j);
                label1.BackColor = Color.LightGray;
                label1.TextAlign = ContentAlignment.MiddleCenter;
                label1.Name = "labelHan" + i.ToString();
                label1.Size = new Size(100, 25);
                label1.TabIndex = 0;
                label1.Text = paramListKanji[i].hanviet;
                label1.Click += LabelHan_Click;
                pnlHan.Controls.Add(label1);

                // add control into panel Kanji
                Label label3 = new Label();
                label3.Font = new Font("Meiryo", 10F);
                label3.Location = new Point(9 + 105 * (i % 4), 9 + 30 * j);
                label3.BackColor = Color.LightGray;
                label3.TextAlign = ContentAlignment.MiddleCenter;
                label3.Name = "labelKanji" + i.ToString();
                label3.Size = new Size(100, 25);
                label3.TabIndex = 0;
                label3.Text = paramListKanji[i].kanji;
                label3.Click += LabelKanji_Click;
                pnlKanji.Controls.Add(label3);
            }
        }
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == (int)enumTab.Kanji && !isCreateControlKanji)
            {
                LoadData();
            }

        }

        private void LabelHan_Click(object sender, EventArgs e)
        {
            if (lblHan != null)
            {
                lblHan.BackColor = Color.LightGray;
                if (lblHan.Name == ((Control)sender).Name)
                {
                    lblHan = null;
                    theKanji.hanviet = "";
                    return;
                }
            }
            lblHan = (Control)sender;
            lblHan.BackColor = Color.LightBlue;
            theKanji.hanviet = lblHan.Text;
            if (!String.IsNullOrEmpty(theKanji.kanji))
            {
                if (paramListKanji.Any(u => u.hanviet == ((Control)sender).Text && u.kanji == theKanji.kanji))
                {
                    iSuccess++;
                    lblCountSuccess.Text = iSuccess.ToString();

                    dgvKanji.Rows.Add(theKanji.hanviet, theKanji.kanji);
                    theKanji.hanviet = "";
                    theKanji.kanji = "";
                    lblHan.BackColor = Color.Transparent;
                    lblHan.Text = "";
                    lblHan = null;
                    lblKanji.BackColor = Color.Transparent;
                    lblKanji.Text = "";
                    lblKanji = null;
                    if (dgvKanji.Rows.Count == paramListKanji.Count) timer.Stop();
                }
                else
                {
                    iFail++;
                    lblCountFail.Text = iFail.ToString();
                }
            }
        }

        private void LabelKanji_Click(object sender, EventArgs e)
        {
            if (lblKanji != null)
            {
                lblKanji.BackColor = Color.LightGray;
                if (lblKanji.Name == ((Control)sender).Name)
                {
                    lblKanji = null;
                    theKanji.kanji = "";
                    return;
                }
            }
            lblKanji = (Control)sender;
            lblKanji.BackColor = Color.LightSkyBlue;
            theKanji.kanji = lblKanji.Text;
            if (!String.IsNullOrEmpty(theKanji.hanviet))
            {
                if (paramListKanji.Any(u => u.hanviet == theKanji.hanviet && u.kanji == theKanji.kanji))
                {
                    iSuccess++;
                    lblCountSuccess.Text = iSuccess.ToString();

                    dgvKanji.Rows.Add(theKanji.hanviet, theKanji.kanji);
                    theKanji.hanviet = "";
                    theKanji.kanji = "";
                    lblHan.BackColor = Color.Transparent;
                    lblHan.Text = "";
                    lblHan = null;
                    lblKanji.BackColor = Color.Transparent;
                    lblKanji.Text = "";
                    lblKanji = null;
                    if (dgvKanji.Rows.Count == paramListKanji.Count) timer.Stop();
                }
                else
                {
                    iFail++;
                    lblCountFail.Text = iFail.ToString();
                }
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            btnReset_Click(null, null);
            int count = pnlHan.Controls.Count;
            List<int> listDataHan = new List<int>();
            List<int> listDataKanji = new List<int>();
            for (int i = 0; i < count; i++)
            {
                listDataHan.Add(i);
            }
            for (int i = 0; i < count; i++)
            {
                listDataKanji.Add(i);
            }
            List<int> listRandomHan = new List<int>();
            List<int> listRandomKanji = new List<int>();
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int r = random.Next(0, count - i);
                listRandomHan.Add(listDataHan[r]);
                listDataHan.RemoveAt(r);
            }
            for (int i = 0; i < count; i++)
            {
                int rKanji = random.Next(0, count - i);
                listRandomKanji.Add(listDataKanji[rKanji]);
                listDataKanji.RemoveAt(rKanji);
            }
            for (int i = 0; i < count; i++)
            {
                pnlHan.Controls[i].Text = paramListKanji[listRandomHan[i]].hanviet;
                pnlKanji.Controls[i].Text = paramListKanji[listRandomKanji[i]].kanji;
            }
        }

        private void dgvKanji_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            String rowIdx = (e.RowIndex + 1).ToString();

            StringFormat centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Far;
            centerFormat.LineAlignment = StringAlignment.Center;

            Rectangle headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            headerBounds.Inflate(-2, -2);
            e.Graphics.DrawString(rowIdx, grid.RowHeadersDefaultCellStyle.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
