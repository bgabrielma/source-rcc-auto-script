using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rcc_aulador_v2_metrodesign_master
{
    public class Militar
    {
        protected string name;
        protected string tag;
        protected Bitmap image;

        public Militar(string name, string tag, Bitmap image)
        {
            this.name = name;
            this.tag = tag;
            this.image = image;
        }

        public Militar() { }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Tag
        {
            get 
            {
                return tag;
            }
            set
            {
                tag = value;
            }
        }

        public Bitmap Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }
    }
}
