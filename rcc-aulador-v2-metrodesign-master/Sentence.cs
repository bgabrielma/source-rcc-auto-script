using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rcc_aulador_v2_metrodesign_master
{
    class Sentence
    {

        // class's variables
        protected string valueLine;
        protected int idTitle;

        // construct: valueLine -> @String && idTitle -> @Int
        public Sentence(string valueLine, int idTitle)
        {
            this.valueLine = valueLine;
            this.idTitle = idTitle;
        }

        // construct without params
        public Sentence() { }

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
