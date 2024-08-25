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
            argumentsToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            renameToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(240, 40);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(757, 759);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Home";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 29);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(756, 728);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Rich Text Box";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, refutationsToolStripMenuItem, helpToolStripMenuItem, argumentsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1010, 30);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportToolStripMenuItem, importToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(137, 26);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(137, 26);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(137, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // refutationsToolStripMenuItem
            // 
            refutationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem, counterpointsToolStripMenuItem });
            refutationsToolStripMenuItem.Name = "refutationsToolStripMenuItem";
            refutationsToolStripMenuItem.Size = new Size(67, 24);
            refutationsToolStripMenuItem.Text = "Search";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(167, 26);
            searchToolStripMenuItem.Text = "Arguments";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // counterpointsToolStripMenuItem
            // 
            counterpointsToolStripMenuItem.Name = "counterpointsToolStripMenuItem";
            counterpointsToolStripMenuItem.Size = new Size(167, 26);
            counterpointsToolStripMenuItem.Text = "Refutations";
            counterpointsToolStripMenuItem.Click += counterpointsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whatIsThisToolStripMenuItem, howToUseToolStripMenuItem, homeToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // whatIsThisToolStripMenuItem
            // 
            whatIsThisToolStripMenuItem.Name = "whatIsThisToolStripMenuItem";
            whatIsThisToolStripMenuItem.Size = new Size(175, 26);
            whatIsThisToolStripMenuItem.Text = "What is this?";
            whatIsThisToolStripMenuItem.Click += whatIsThisToolStripMenuItem_Click;
            // 
            // howToUseToolStripMenuItem
            // 
            howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            howToUseToolStripMenuItem.Size = new Size(175, 26);
            howToUseToolStripMenuItem.Text = "How to use";
            howToUseToolStripMenuItem.Click += howToUseToolStripMenuItem_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(175, 26);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(14, 40);
            treeView1.Margin = new Padding(3, 4, 3, 4);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(219, 757);
            treeView1.TabIndex = 3;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // argumentsToolStripMenuItem
            // 
            argumentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, removeToolStripMenuItem, renameToolStripMenuItem });
            argumentsToolStripMenuItem.Name = "argumentsToolStripMenuItem";
            argumentsToolStripMenuItem.Size = new Size(95, 24);
            argumentsToolStripMenuItem.Text = "Arguments";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(224, 26);
            addToolStripMenuItem.Text = "Add";
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(224, 26);
            removeToolStripMenuItem.Text = "Remove";
            // 
            // renameToolStripMenuItem
            // 
            renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            renameToolStripMenuItem.Size = new Size(224, 26);
            renameToolStripMenuItem.Text = "Rename";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 815);
            Controls.Add(treeView1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
        private ToolStripMenuItem argumentsToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem renameToolStripMenuItem;
    }
}
