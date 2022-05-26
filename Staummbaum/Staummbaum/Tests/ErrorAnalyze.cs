using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Staummbaum.Services;
using Staummbaum.Classes;


namespace Staummbaum.Tests
{
    class ErrorAnalyze
    {
        Service service = new Service();
        String pathGlobalTree = "C:\\Users\\prueb\\Desktop\\respald\\Staummbaum\\Staummbaum\\Resources\\Trees";

        public void treeTest(String treeName, List<Tree> treeList)
        {
            if (Directory.Exists(pathGlobalTree + "\\" + treeName))
            {
                Boolean parentOrSib = true;
                String testResult = "";
                Tree tree = new Tree();
                List<Person> persons = new List<Person>();
                int n = 0;
                foreach(Tree t in treeList)
                {
                    if(t.name == treeName)
                    {
                        tree = t;
                    }
                }
                persons = tree.persons;
                if(persons != null)
                {
                    foreach (Person p in persons)
                    {
                        int idPerson = p.id;
                        testResult += "Test for: " + p.name + " with id: " + idPerson + " \n";
                        if (p.hatParents() && p.hatSiblings())
                        {
                            parentOrSib = true;
                            foreach (Person parent in p.parents)
                            {
                                int idParent = parent.id;
                                if (idParent == idPerson)
                                {
                                    testResult += p.name + " may not be the parent of the person with id: " + idParent + "\n";
                                }
                                foreach (Person sibling in p.siblings)
                                {
                                    if (sibling.id == idParent)
                                    {
                                        testResult += p.name + " cannot have the same father or mother and brother or sister at the same time with id: " + sibling.id + "\n";
                                    }
                                    if (sibling.id == idPerson)
                                    {
                                        if (n == 0)
                                        {
                                        testResult += p.name + " may not be the sibling of the person with id: " + sibling.id + "\n";
                                            n++;
                                        }
                                    }
                                }
                            }
                        }
                        else if (p.hatSiblings())
                        {
                            parentOrSib = true;
                            testResult += "\n Missing information from Parents ";

                            foreach (Person sibling in p.siblings)
                            {
                                if (sibling.id == idPerson)
                                {
                                    testResult += p.name + " may not be the sibling of the person with id: " + sibling.id + "\n";
                                }
                            }
                        }
                        if (!parentOrSib)
                        {
                            if (p.hatParents() && !parentOrSib)
                            {
                                testResult += "\n Missing information from Siblings";
                                foreach (Person parent in p.parents)
                                {
                                    if (parent.id == idPerson)
                                    {
                                        testResult += p.name + " may not be the parent of the person with id: " + parent.id + "\n";
                                    }
                                }
                            }
                            else
                            {
                                testResult += "\n Missing information from parents and siblings \n";

                            }
                        }
                        testResult += "\n";
                    }
                }
                   
                System.Windows.Forms.MessageBox.Show(testResult);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("This tree is not created");

            }
        }

    }
}
