using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staummbaum.Classes
{
    class Person
    {
        public int id { get; private set; }
        public String name { get; set; }
        public String genus { get; set; }
        
        public List<Person> parents { get; set; }
        public List<Person> siblings { get; set; }
        public Tree tree { get; set; }


        public Person()
        {
        }

        public Person(int id, String name, String genus, Tree tree)
        {
            this.id = id;
            this.name = name;
            this.genus = genus;
            this.tree = tree;
            parents = new List<Person>();
            siblings = new List<Person>();

        }

        public Boolean hatParents()
        {
            if (this.parents.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean hatSiblings()
        {
            if (this.siblings.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void changeId(int newId)
        {

            // Checks: has any other person in my tree already the same id?
            foreach(Person p in tree.persons)
            {
                if (p.id == newId)
                {
                    //disallow changing, already present!
                    throw new ArgumentException("Id '" + newId.ToString() + "' already exists! Changing not allowed");
                }
            }
            // no entry found with new id
            id = newId;
        }

    }
}
