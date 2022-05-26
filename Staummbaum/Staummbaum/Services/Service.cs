using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Staummbaum.Classes;
using System.Xml;
using System.IO;



namespace Staummbaum.Services
{

    class Service
    {

        public Tree createTree(String nameTree, String path)
        {
                String pathTree = @"C:\Users\prueb\Desktop\respald\Staummbaum\Staummbaum\Resources\xml\" + path;
                Tree tree = new Tree(nameTree, pathTree);
                XmlDocument doc = createDocument(pathTree);
                tree.doc = doc;
                XmlNodeList root = doc.DocumentElement.SelectNodes("./Person");
                List<Person> persons = new List<Person>();

                //iteration of each node in the XML to add a list of people to the tree
                if (root.Count > 0)
                {
                    for (int i = 0; i < root.Count; i++)
                    {
                        XmlElement person = (XmlElement)root[i];
                        XmlAttribute attrPerson = person.GetAttributeNode("id");

                        //Childs of Node Person
                        XmlNode nameNode = root[i].SelectSingleNode("Name");
                        XmlNode genusNode = root[i].SelectSingleNode("Geschlecht");

                        //Personen Dates
                        String namePersonString = nameNode.InnerText;
                        String genusPersonString = genusNode.InnerText;
                        int idPerson = int.Parse(attrPerson.InnerXml);

                        persons.Add(new Person(idPerson, namePersonString, genusPersonString, tree));

                    }
                    tree.persons = persons;

                    for (int i = 0; i < root.Count; i++)
                    {
                        try
                        {
                            XmlElement person = (XmlElement)root[i];
                            XmlAttribute attrPerson = person.GetAttributeNode("id");
                            int idPerson = int.Parse(attrPerson.InnerXml);                       
                            Person personNode = searchPersonInTree(idPerson, tree);
                            
                            XmlNode siblingNode = root[i].SelectSingleNode("Geschwister");
                            XmlNode parentNode = root[i].SelectSingleNode("Eltern");
                            if (siblingNode != null)
                            {
                                XmlNodeList xmlSiblingsNode = siblingNode.SelectNodes("./PersonRef");
                                if (xmlSiblingsNode.Count > 0)
                                {
                                    List<Person> personSiblings = new List<Person>();

                                    for (int n = 0; n < xmlSiblingsNode.Count; n++)
                                    {
                                        //Get Person ID
                                        XmlElement sibling = (XmlElement)xmlSiblingsNode[n];
                                        XmlAttribute attrSiblingId = sibling.GetAttributeNode("refId");
                                        int idSibling = int.Parse(attrSiblingId.InnerXml);

                                        //Search Person
                                        Person personInNode = searchPersonInTree(idSibling, tree);
                                        if (personInNode == null)
                                        {
                                            Console.WriteLine("The person on id is: " + idSibling + "is not present");
                                        }
                                        else
                                        {
                                            personSiblings.Add(personInNode);
                                            personNode.siblings = personSiblings;
                                        }
                                    }

                                }
                            }
                            if (parentNode != null)
                            {
                                XmlNodeList xmlParentsNode = parentNode.SelectNodes("./PersonRef");
                                if (xmlParentsNode.Count > 0)
                                {
                                    List<Person> personParents = new List<Person>();
                                    for (int j = 0; j < xmlParentsNode.Count; j++)
                                    {
                                        XmlElement parent = (XmlElement)xmlParentsNode[j];
                                        XmlAttribute attrParentId = parent.GetAttributeNode("refId");
                                        XmlAttribute attrParentType = parent.GetAttributeNode("type");
                                        int idParent = int.Parse(attrParentId.InnerXml);
                                        String typeParent = (String)attrParentType.InnerText;
                                        Person personInNode = searchPersonInTree(idParent, tree);
                                        if (personInNode == null)
                                        {
                                            Console.WriteLine("The person on id is: " + idParent + "is not present");
                                        }
                                        else
                                        {
                                            personParents.Add(personInNode);
                                            personNode.parents = personParents;
                                        }
                                    }
                                }

                            }
                        }
                        catch (System.NullReferenceException e)
                        {
                            Console.WriteLine(e);
                        }

                    }
                return tree;
                }
                else
                {
                    throw new ArgumentException("Error in the Path");
                }
        }

        public XmlDocument createDocument(String pathTree)
        {
                XmlDocument doc = new XmlDocument();
                doc.PreserveWhitespace = true;
                try
                {
                    doc.Load(pathTree);
                    return doc;

                }
                catch (System.IO.FileNotFoundException e)
                {
                    Console.WriteLine(e);
                    return doc;
                }
        }

        public String familyInfo(Person p, Tree tree)
        {
            String info = "";
            if (p.parents.Count > 0)
            {
                info += "Parents: ";
                foreach (Person pParent in p.parents)
                {
                    Person parent = searchPersonInTree(pParent.id, tree);
                    info += parent.name + "\n";
                }
            }
            else
            {
                info += "Not Parents\n";
            }
            if (p.siblings.Count > 0)
            {
                info += "Siblings: ";
                foreach (Person pSibling in p.siblings)
                {
                    Person sibling = searchPersonInTree(pSibling.id, tree);
                    info += sibling.name + "\n";
                }
            }
            else
            {
                info += "Not Siblings";
            }
            return info;
            
        }


        public Person searchPersonInTree(int id, Tree tree)
        {
            List<Person> persons = tree.persons;

            foreach(Person p in persons){
                if(p.id == id)
                {
                    return p;
                }
            }
            return null;
        }

    }
}
