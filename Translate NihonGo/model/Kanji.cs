using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anh.DB_definition_diagram__WRS.model
{
    public class Kanji
    {
        public string kanji;
        public string hanviet;
        public override string ToString()
        {
            return hanviet + "(" + kanji + ")";

        }

    }
    public class KanjiComparer : IEqualityComparer<Kanji>
    {
        public bool Equals(Kanji x, Kanji y)
        {
            return x.kanji == y.kanji;
        }

        public int GetHashCode(Kanji obj)
        {
            Encoding encoding = Encoding.GetEncoding(932);
            int m = Convert.ToInt32(obj.kanji.ToCharArray()[0]);
            return m;
        }
    }
}
