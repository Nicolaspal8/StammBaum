
namespace Staummbaum
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTestTree = new System.Windows.Forms.TextBox();
            this.textBoxTree = new System.Windows.Forms.TextBox();
            this.BTN_createTree = new System.Windows.Forms.Button();
            this.selectXML = new System.Windows.Forms.ComboBox();
            this.BTN_test = new System.Windows.Forms.Button();
            this.BTN_info = new System.Windows.Forms.Button();
            this.BTN_search = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.treeMain = new System.Windows.Forms.TreeView();
            this.searchAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Test Tree";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(566, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Create new Tree\r\n";
            // 
            // textBoxTestTree
            // 
            this.textBoxTestTree.Location = new System.Drawing.Point(13, 34);
            this.textBoxTestTree.Name = "textBoxTestTree";
            this.textBoxTestTree.Size = new System.Drawing.Size(100, 23);
            this.textBoxTestTree.TabIndex = 18;
            // 
            // textBoxTree
            // 
            this.textBoxTree.Location = new System.Drawing.Point(505, 31);
            this.textBoxTree.Name = "textBoxTree";
            this.textBoxTree.Size = new System.Drawing.Size(100, 23);
            this.textBoxTree.TabIndex = 17;
            this.textBoxTree.Tag = "";
            // 
            // BTN_createTree
            // 
            this.BTN_createTree.Location = new System.Drawing.Point(738, 28);
            this.BTN_createTree.Name = "BTN_createTree";
            this.BTN_createTree.Size = new System.Drawing.Size(38, 27);
            this.BTN_createTree.TabIndex = 16;
            this.BTN_createTree.Text = "new";
            this.BTN_createTree.UseVisualStyleBackColor = true;
            this.BTN_createTree.Click += new System.EventHandler(this.BTN_createTree_Click);
            // 
            // selectXML
            // 
            this.selectXML.BackColor = System.Drawing.SystemColors.Info;
            this.selectXML.FormattingEnabled = true;
            this.selectXML.Location = new System.Drawing.Point(611, 31);
            this.selectXML.Name = "selectXML";
            this.selectXML.Size = new System.Drawing.Size(121, 23);
            this.selectXML.TabIndex = 15;
            this.selectXML.Text = "Select a XML File";
            this.selectXML.KeyDown += new System.Windows.Forms.KeyEventHandler(this.selectXML_KeyDown);
            // 
            // BTN_test
            // 
            this.BTN_test.BackColor = System.Drawing.Color.Red;
            this.BTN_test.Location = new System.Drawing.Point(162, 31);
            this.BTN_test.Name = "BTN_test";
            this.BTN_test.Size = new System.Drawing.Size(40, 27);
            this.BTN_test.TabIndex = 13;
            this.BTN_test.Text = "test";
            this.BTN_test.UseVisualStyleBackColor = false;
            this.BTN_test.Click += new System.EventHandler(this.BTN_test_Click);
            // 
            // BTN_info
            // 
            this.BTN_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTN_info.Location = new System.Drawing.Point(116, 31);
            this.BTN_info.Name = "BTN_info";
            this.BTN_info.Size = new System.Drawing.Size(40, 27);
            this.BTN_info.TabIndex = 14;
            this.BTN_info.Text = "info";
            this.BTN_info.UseVisualStyleBackColor = false;
            this.BTN_info.Click += new System.EventHandler(this.BTN_info_Click);
            // 
            // BTN_search
            // 
            this.BTN_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_search.BackgroundImage")));
            this.BTN_search.Location = new System.Drawing.Point(372, 25);
            this.BTN_search.Name = "BTN_search";
            this.BTN_search.Size = new System.Drawing.Size(35, 33);
            this.BTN_search.TabIndex = 12;
            this.BTN_search.UseVisualStyleBackColor = true;
            this.BTN_search.Click += new System.EventHandler(this.BTN_search_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(250, 32);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(116, 23);
            this.textBoxSearch.TabIndex = 11;
            this.textBoxSearch.Tag = "";
            // 
            // treeMain
            // 
            this.treeMain.Location = new System.Drawing.Point(12, 76);
            this.treeMain.Name = "treeMain";
            this.treeMain.Size = new System.Drawing.Size(776, 365);
            this.treeMain.TabIndex = 10;
            // 
            // searchAll
            // 
            this.searchAll.Location = new System.Drawing.Point(413, 28);
            this.searchAll.Name = "searchAll";
            this.searchAll.Size = new System.Drawing.Size(32, 24);
            this.searchAll.TabIndex = 21;
            this.searchAll.Text = "All";
            this.searchAll.UseVisualStyleBackColor = true;
            this.searchAll.Click += new System.EventHandler(this.searchAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(269, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Search Tree";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTestTree);
            this.Controls.Add(this.textBoxTree);
            this.Controls.Add(this.BTN_createTree);
            this.Controls.Add(this.selectXML);
            this.Controls.Add(this.BTN_test);
            this.Controls.Add(this.BTN_info);
            this.Controls.Add(this.BTN_search);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.treeMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTestTree;
        private System.Windows.Forms.TextBox textBoxTree;
        private System.Windows.Forms.Button BTN_createTree;
        private System.Windows.Forms.ComboBox selectXML;
        private System.Windows.Forms.Button BTN_test;
        private System.Windows.Forms.Button BTN_info;
        private System.Windows.Forms.Button BTN_search;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TreeView treeMain;
        private System.Windows.Forms.Button searchAll;
        private System.Windows.Forms.Label label3;
    }
}

