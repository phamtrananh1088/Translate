using Anh.DB_definition_diagram__WRS.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        bool isCreateControlKanji = false;
        public RD001201()
        {
            InitializeComponent();
        }
        public RD001201(List<Kanji> listKanji)
        {
            InitializeComponent();
            paramListKanji = listKanji;
            paramListKanji = paramListKanji.Distinct(new KanjiComparer()).ToList();
        }

        private void RD001201_Load(object sender, EventArgs e)
        {
           txtKanji.Text = String.Join("\r\n", paramListKanji.Select(u => u.ToString()));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pnlHan.Controls.Count; i++)
            {
                pnlHan.Controls[i].Text = paramListKanji[i].hanviet;
                pnlKanji.Controls[i].Text = paramListKanji[i].kanji;
            }
            
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == (int)enumTab.Kanji && !isCreateControlKanji)
            {
                isCreateControlKanji = true;
                Size pnlSize = pnlHan.Size;
                for (int i = 0, j = 0; i < paramListKanji.Count; i++)
                {
                    if (i % 4 == 0) j ++;
                    // add control into panel Han
                    Label label1 = new Label();
                    label1.Font = new System.Drawing.Font("Meiryo", 10F);
                    label1.Location = new System.Drawing.Point(9 + 105*(i%4), 9 + 30*j);
                    label1.BackColor = System.Drawing.Color.LightGray;
                    label1.Name = "labelHan"+i.ToString();
                    label1.Size = new System.Drawing.Size(100, 25);
                    label1.TabIndex = 0;
                    label1.Text = paramListKanji[i].hanviet;
                    pnlHan.Controls.Add(label1);

                    // add control into panel Kanji
                    Label label3 = new Label();
                    label3.Font = new System.Drawing.Font("Meiryo", 10F);
                    label3.Location = new System.Drawing.Point(9 + 105 * (i % 4), 9 + 30 * j);
                    label3.BackColor = System.Drawing.Color.LightGray;
                    label3.Name = "labelKanji" + i.ToString();
                    label3.Size = new System.Drawing.Size(100, 25);
                    label3.TabIndex = 0;
                    label3.Text = paramListKanji[i].kanji;
                    pnlKanji.Controls.Add(label3);
                }
                
            }

        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
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
    }
}
