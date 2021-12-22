using Anh.Translate.Action.Jdict;
using Newtonsoft.Json.Linq;
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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private async void btnJdict_Click(object sender, EventArgs e)
        {
            JdictTrans trans = new JdictTrans();
            JObject res =  await trans.analyzer(txtInputTest.Text);
            lblResult.Text = res.ToString();
        }
    }
}
