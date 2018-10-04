using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rcc_script_system
{
    public class Line
    {
        // class's variables
        private string valueLine;
        private int idTitle;

        // construct: valueLine -> @String && idTitle -> @Int
        public Line(string valueLine, int idTitle)
        {
            this.valueLine = valueLine;
            this.idTitle = idTitle;
        }

        // construct without params
        public Line() { }

        public void setValueLine(string x)
        {
            valueLine = x;
        }

        public string getValueLine()
        {
            return valueLine;
        }
        public void setIdTitle(int x)
        {
            idTitle = x;
        }

        public int getIdTitle()
        {
            return idTitle;
        }
    }
}
