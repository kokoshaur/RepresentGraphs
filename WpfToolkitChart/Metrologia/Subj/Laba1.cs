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

            double matwait = matWait(sorses.Count);
            double middlerezwatch = middleRezWatch(sorses.Count, matwait);
            double middlerezcheck = middleRezCheck(sorses.Count, matwait);

            sorses = refreshSor(matwait, middlerezcheck);
            sorses = discret(5);

            int i = 0;
            foreach(object subj in sorses)
                ansver.Add(new KeyValuePair<string, T>(i++.ToString(), (T)Convert.ChangeType(subj, typeof(T))));
            return ansver;
        }

        private double matWait(int size)
        {
            double ansver = 0;
            for (int i = 0; i < size; i++)
                ansver += (double)sorses[i];
            return ansver / size;
        }

        private double middleRezWatch(int size, double matwait)
        {
            double ansver = 0;

            for (int i = 0; i < size; i++)
                ansver += Math.Pow((double)sorses[i] - matwait, 2);

            return Math.Sqrt(ansver/(matwait-1));
        }

        private double middleRezCheck(int size, double matwait)
        {
            double ansver = 0;

            for (int i = 0; i < size; i++)
                ansver += Math.Pow((double)sorses[i] - matwait, 2);

            return Math.Sqrt(ansver / (matwait*(matwait - 1)));
        }

        private List<object> refreshSor(double midNum, double delta)
        {
            List<object> newSorse = new List<object>();

            foreach (object subj in sorses)
                if (((double)subj < midNum + delta) && ((double)subj > midNum - delta))
                    newSorse.Add(subj);

            return newSorse;
        }

        private List<object> discret(int sizeBlock)
        {
            List<object> newSorse = new List<object>();

            for (int i = 0; i < sorses.Count - sizeBlock; i++)
                newSorse.Add(((double)sorses[i] + (double)sorses[i + 1]) / sizeBlock);

            return newSorse;
        }
    }
}
