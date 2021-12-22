using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anh.Translate.Model
{
    public class DataReturn
    {
        public string textOrg { get; set; }
        public string textTran { get; set; }
        public override string ToString()
        {
            return textOrg + ": " + textTran;
        }
    }
}
