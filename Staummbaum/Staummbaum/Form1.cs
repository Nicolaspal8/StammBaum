using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Staummbaum.Services;
using Staummbaum.Tests;
using System.Windows.Forms;
using System.Xml;
using Staummbaum.Classes;
namespace Staummbaum
{
    public partial class Form1 : Form
    {
        List<Tree> treeList = new List<Tree>();
        String pathGlobalTree = "C:\\Users\\prueb\\Desktop\\respald\\Staummbaum\\Staummbaum\\Resources\\";
        Service service = new Service();
        ErrorAnalyze test = new ErrorAnalyze();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] xmlFiles = Directory.GetFiles(pathGlobalTree + "xml");

            //Add elements in the select
            foreach (String element in xmlFiles)
            {
                FileInfo tmpFile = new FileInfo(element);
                String test = tmpFile.Name;
                selectXML.Items.Add(test);
            }
            textBoxTree.PlaceholderText = "New Tree...";
            textBoxTestTree.PlaceholderText = "Test tree...";
            textBoxSearch.PlaceholderText = "Search...";


            BTN_info.FlatStyle = FlatStyle.Flat;
            BTN_info.FlatAppearance.BorderColor = Color.White;

            BTN_test.FlatStyle = FlatStyle.Flat;
            BTN_test.FlatAppearance.BorderColor = Color.White;

        }

        //Create TreeView
        private TreeNode CreateTree(DirectoryInfo directoryInfo)
        {
            treeMain.Nodes.Clear();
            TreeNode treeNode = new TreeNode(directoryInfo.Name);
            foreach (var item in directoryInfo.GetDirectories())
            {
                treeNode.Nodes.Add(CreateTree(item));
            }
            foreach (var item in directoryInfo.GetFiles())
            {
                treeNode.Nodes.Add(new TreeNode(item.Name));
            }
            return treeNode;
        }
        private void BTN_createTree_Click(object sender, EventArgs e)
        {
            String treeNameBox = textBoxTree.Text;
            String pathTree = selectXML.Text;
            String pathNewTree = pathGlobalTree + "Trees" + "\\" + treeNameBox;
            if (treeNameBox != "")
            {
                if (pathTree == "Select a XML File")
                {
                    MessageBox.Show("Xml selected invalid");
                }
                else if (!Directory.Exists(pathNewTree))
                {
                    //Create Tree 
                    Tree tree = service.createTree(treeNameBox, pathTree);
                    //Add Tree in my Global ListTree
                    treeList.Add(tree);
                    Directory.CreateDirectory(pathNewTree);
                    List<Person> personsTree = tree.persons;

                    //Create Files
                    foreach (Person person in personsTree)
                    {
                        int idPerson = person.id;
                        String namePerson = person.name;
                        String pathPerson = pathNewTree + "\\" + idPerson + " " + namePerson;
                        Directory.CreateDirectory(pathPerson);

                        File.Create(pathPerson + "\\" + person.genus);

                        if (person.hatParents())
                        {
                            String pathParents = pathPerson + "\\" + "Parents";
                            foreach (Person p in person.parents)
                            {
                                Directory.CreateDirectory(pathParents + "\\" + p.name + " " + p.genus);

                            }

                        }
                        if (person.hatSiblings())
                        {
                            String pathSiblings = pathPerson + "\\" + "Siblings";
                            foreach (Person p in person.siblings)
                            {
                                Directory.CreateDirectory(pathSiblings + "\\" + p.name + " " + p.genus);

                            }
                        }
                    }
                    DirectoryInfo directoryInfo = new DirectoryInfo(pathGlobalTree + "Trees");
                    treeMain.Nodes.Add(CreateTree(directoryInfo));

                }
                else
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(pathGlobalTree + "Trees");
                    treeMain.Nodes.Add(CreateTree(directoryInfo));
                    MessageBox.Show("This Tree Exists");
                }

            }
            else
            {
                MessageBox.Show("The name of the new Tree can't empty");
            }
        }

        private void selectXML_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void BTN_search_Click(object sender, EventArgs e)
        {
            String search = textBoxSearch.Text;
            String pathTreeSearch = pathGlobalTree + "Trees\\" + search;
            if (Directory.Exists(pathTreeSearch))
            {
            DirectoryInfo directoryInfo = new DirectoryInfo(pathTreeSearch);
            treeMain.Nodes.Add(CreateTree(directoryInfo));
            }
            else
            {
                MessageBox.Show("Tree not found");
            }
        }

        //Test BTN and Info
        private void BTN_test_Click(object sender, EventArgs e)
        {
            String txtBox = textBoxTestTree.Text;
            test.treeTest(txtBox, treeList);
        }

        private void BTN_info_Click(object sender, EventArgs e)
        {

            String treeName = textBoxTestTree.Text;
            if(treeName != "" && treeList.Count > 0)
            {
                Tree tree = new Tree();
                foreach (Tree t in treeList)
                {
                    if (t.name == treeName)
                    {
                        tree = t;
                    }
                }
                if(!Object.ReferenceEquals(null, tree.doc))
                {
                XmlDocument doc = service.createDocument(tree.pathXML);
                System.Windows.Forms.MessageBox.Show(doc.DocumentElement.OuterXml);
                }
                else
                {
                    MessageBox.Show("Tree not found");

                }
            }
            else
            {
                MessageBox.Show("Tree not found");
            }
        }

        private void searchAll_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(pathGlobalTree + "Trees");
            treeMain.Nodes.Add(CreateTree(directoryInfo));
        }


    }
}
