using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace WpfToolkitChart.Metrologia
{
    abstract class Laba<T> : ILaba<T>
    {
        protected List<object> sorses = new List<object>();
        public Laba(string pathToSorse = "..\\..\\Metrologia\\Laba1Sorse.txt", string typeNumber = "en-US")
        {
            initSorse(pathToSorse);
        }

        public void refreshSorse(string pathToSorse, string typeNumber = "en-US")
        {
            initSorse(pathToSorse);
        }

        abstract public List<KeyValuePair<string, T>> getAnsver();

        protected void initSorse(string pathToSorse, string typeNumber = "en-US")
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(typeNumber);
            try
            {
                using (StreamReader File = new StreamReader(pathToSorse))
                {
                    while (!File.EndOfStream)
                    {
                        sorses.Add(double.Parse(File.ReadLine()));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
