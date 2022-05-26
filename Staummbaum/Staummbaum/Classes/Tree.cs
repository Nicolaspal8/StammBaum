using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Staummbaum.Classes
{
    class Tree
    {
        public String name { get; set; }

        //@"C:\Users\Schulung\Desktop\respald\Staummbaum\Staummbaum\Resources\xml\Staummbaum_pg_sm.xml"
        public String pathXML { get; set; }
        public XmlDocument doc { get; set; }
        public List<Person> persons { get; set; }

    
        public Tree(String name, String pathXML)
            {
                this.name = name;
                this.pathXML = pathXML;
            }

        public Tree()
            {
              
            }

    }
}
