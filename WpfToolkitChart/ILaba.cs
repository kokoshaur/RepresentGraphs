using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfToolkitChart
{
    interface ILaba<T>
    {
        List<KeyValuePair<string, T>> getAnsver();
        void refreshSorse(string pathToSorse, string typeNumber);
    }
}
