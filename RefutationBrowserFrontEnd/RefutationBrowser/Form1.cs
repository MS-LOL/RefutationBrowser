namespace RefutationBrowser
{
    public partial class Form1 : Form
    {
        public string PointName;
        public string PointBody;

        public Form1()
        {
            InitializeComponent();
        }
        public void updateOutput(string Name, string Body)
        {
            groupBox1.Text = Name;
            richTextBox1.Text = Body;
            groupBox1.Invalidate();
            richTextBox1.Invalidate();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode != null)
            {

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void counterpointsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void whatIsThisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
