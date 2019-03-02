using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronpythonDemo
{
    public class ScriptFunLib
    {
        public void PrintClear()
        {
            DataManage.ShowData = "";
        }

        public void PrintLine(string value)
        {
            DataManage.ShowData += value + "\n";
        }

        public void Print(string value)
        {
            DataManage.ShowData += value;
        }
    }
}
