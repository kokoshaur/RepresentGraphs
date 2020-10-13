using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace WpfToolkitChart.Metrologia
{
    class Laba1<T> : Laba<T>
    {
        public override List<KeyValuePair<string, T>> getAnsver()
        {
            List<KeyValuePair<string, T>> ansver = new List<KeyValuePair<string, T>>();
            int i = 0;

            foreach (object subj in sorses)
            {
                ansver.Add(new KeyValuePair<string, T>(i.ToString(), (T)Convert.ChangeType(subj, typeof(T))));
                i++;
            }

            return ansver;
        }
    }
}
