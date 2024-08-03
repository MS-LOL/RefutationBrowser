namespace RefutationBrowser
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
            TreeNode treeNode1 = new TreeNode("Not all AI art");
            TreeNode treeNode2 = new TreeNode("AI is transformative and Fair Use");
            TreeNode treeNode3 = new TreeNode("Theft deprives people");
            TreeNode treeNode4 = new TreeNode("AI art is theft", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("AI doesn't overclock computers");
            TreeNode treeNode6 = new TreeNode("But physical art is more damaging");
            TreeNode treeNode7 = new TreeNode("AI is bad for the envoronment", new TreeNode[] { treeNode5, treeNode6 });
            TreeNode treeNode8 = new TreeNode("CSAM was removed from Laion-5B");
            TreeNode treeNode9 = new TreeNode("AI is trained off of CSAM", new TreeNode[] { treeNode8 });
            TreeNode treeNode10 = new TreeNode("AI cannot replace artists");
            TreeNode treeNode11 = new TreeNode("AI takes away people's jobs", new TreeNode[] { treeNode10 });
            TreeNode treeNode12 = new TreeNode("INVALID ARGUMENT: MOVIE != REALITY");
            TreeNode treeNode13 = new TreeNode("The prevoius point applies to Non reprogrammed  T-800s");
            TreeNode treeNode14 = new TreeNode("The T-800 was programmed to do so", new TreeNode[] { treeNode13 });
            TreeNode treeNode15 = new TreeNode("The T-800 helped in the second movie", new TreeNode[] { treeNode14 });
            TreeNode treeNode16 = new TreeNode("Issac Asimov's 3 laws of robotics");
            TreeNode treeNode17 = new TreeNode("AI is bad because The Terminator", new TreeNode[] { treeNode12, treeNode15, treeNode16 });
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            refutationsToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            counterpointsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            whatIsThisToolStripMenuItem = new ToolStripMenuItem();
            howToUseToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            treeView1 = new TreeView();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(210, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(662, 569);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Home";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(662, 547);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Rich Text Box";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, refutationsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportToolStripMenuItem, importToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(110, 22);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(110, 22);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(110, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // refutationsToolStripMenuItem
            // 
            refutationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem, counterpointsToolStripMenuItem });
            refutationsToolStripMenuItem.Name = "refutationsToolStripMenuItem";
            refutationsToolStripMenuItem.Size = new Size(54, 20);
            refutationsToolStripMenuItem.Text = "Search";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(134, 22);
            searchToolStripMenuItem.Text = "Arguments";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // counterpointsToolStripMenuItem
            // 
            counterpointsToolStripMenuItem.Name = "counterpointsToolStripMenuItem";
            counterpointsToolStripMenuItem.Size = new Size(134, 22);
            counterpointsToolStripMenuItem.Text = "Refutations";
            counterpointsToolStripMenuItem.Click += counterpointsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whatIsThisToolStripMenuItem, howToUseToolStripMenuItem, homeToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // whatIsThisToolStripMenuItem
            // 
            whatIsThisToolStripMenuItem.Name = "whatIsThisToolStripMenuItem";
            whatIsThisToolStripMenuItem.Size = new Size(140, 22);
            whatIsThisToolStripMenuItem.Text = "What is this?";
            whatIsThisToolStripMenuItem.Click += whatIsThisToolStripMenuItem_Click;
            // 
            // howToUseToolStripMenuItem
            // 
            howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            howToUseToolStripMenuItem.Size = new Size(140, 22);
            howToUseToolStripMenuItem.Text = "How to use";
            howToUseToolStripMenuItem.Click += howToUseToolStripMenuItem_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(140, 22);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 30);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Not all AI art";
            treeNode2.Name = "Node2";
            treeNode2.Text = "AI is transformative and Fair Use";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Theft deprives people";
            treeNode4.Name = "Node0";
            treeNode4.Text = "AI art is theft";
            treeNode5.Name = "Node5";
            treeNode5.Text = "AI doesn't overclock computers";
            treeNode6.Name = "Node6";
            treeNode6.Text = "But physical art is more damaging";
            treeNode7.Name = "Node4";
            treeNode7.Text = "AI is bad for the envoronment";
            treeNode8.Name = "Node8";
            treeNode8.Text = "CSAM was removed from Laion-5B";
            treeNode9.Name = "Node7";
            treeNode9.Text = "AI is trained off of CSAM";
            treeNode10.Name = "Node10";
            treeNode10.Text = "AI cannot replace artists";
            treeNode11.Name = "Node9";
            treeNode11.Text = "AI takes away people's jobs";
            treeNode12.Name = "Node12";
            treeNode12.Text = "INVALID ARGUMENT: MOVIE != REALITY";
            treeNode13.Name = "Node15";
            treeNode13.Text = "The prevoius point applies to Non reprogrammed  T-800s";
            treeNode14.Name = "Node14";
            treeNode14.Text = "The T-800 was programmed to do so";
            treeNode15.Name = "Node13";
            treeNode15.Text = "The T-800 helped in the second movie";
            treeNode16.Name = "Node16";
            treeNode16.Text = "Issac Asimov's 3 laws of robotics";
            treeNode17.Name = "Node11";
            treeNode17.Text = "AI is bad because The Terminator";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode4, treeNode7, treeNode9, treeNode11, treeNode17 });
            treeView1.Size = new Size(192, 569);
            treeView1.TabIndex = 3;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 611);
            Controls.Add(treeView1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Refutation Browser";
            groupBox1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem refutationsToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem counterpointsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem whatIsThisToolStripMenuItem;
        private ToolStripMenuItem howToUseToolStripMenuItem;
        private TreeView treeView1;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem homeToolStripMenuItem;
    }
}
