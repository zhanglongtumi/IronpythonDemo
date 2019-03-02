using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronpythonDemo
{
    public static class DataManage
    {
        private static string _showData;
        
        public static string ShowData
        {
            get { return _showData; }
            set { _showData = value; }
        }
    }
}
