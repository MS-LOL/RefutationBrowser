using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace RefutationBrowser
{
    public partial class Form1 : Form
    {
        public string PointName;
        public string PointBody;
        public TreeNode currentSelectedNode;

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
        private void LoadJson(string filePath)
        {
            string jsonText = File.ReadAllText(filePath);
            var jsonDoc = JsonDocument.Parse(jsonText);

            // Check if ProgramName exists and has the correct value
            if (!jsonDoc.RootElement.TryGetProperty("ProgramName", out JsonElement programNameElement) ||
                programNameElement.GetString() != "RefutationBrowser")
            {
                MessageBox.Show("Invalid JSON file or missing 'ProgramName'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear existing nodes
            treeView1.Nodes.Clear();

            // Populate TreeView
            foreach (var argument in jsonDoc.RootElement.GetProperty("Arguments").EnumerateArray())
            {
                TreeNode argumentNode = new TreeNode(argument.GetProperty("Name").GetString())
                {
                    Tag = argument // Set the Tag to the JsonElement
                };
                PopulateCounterArguments(argumentNode, argument);
                treeView1.Nodes.Add(argumentNode);
            }

            treeView1.ExpandAll(); // Optional: Expand all nodes initially
        }
        private void PopulateCounterArguments(TreeNode parentNode, JsonElement argument)
        {
            if (argument.TryGetProperty("Children", out JsonElement counterArguments))
            {
                foreach (var counterArgument in counterArguments.EnumerateArray())
                {
                    TreeNode counterNode = new TreeNode(counterArgument.GetProperty("Name").GetString())
                    {
                        Tag = counterArgument // Set the Tag to the JsonElement
                    };
                    PopulateCounterArguments(counterNode, counterArgument);
                    parentNode.Nodes.Add(counterNode);
                }
            }
        }
        private object SerializeNode(TreeNode node)
        {
            var jsonElement = (JsonElement)node.Tag;
            var nodeObject = new JsonObject();

            foreach (var property in jsonElement.EnumerateObject())
            {
                if (property.Name == "Body")
                {
                    nodeObject[property.Name] = property.Value.GetString();
                }
                else
                {
                    nodeObject[property.Name] = property.Value.Clone();
                }
            }

            var counterArgumentsList = new List<object>();
            foreach (TreeNode childNode in node.Nodes)
            {
                counterArgumentsList.Add(SerializeNode(childNode));
            }

            if (counterArgumentsList.Count > 0)
            {
                nodeObject["CounterArguments"] = JsonSerializer.SerializeToElement(counterArgumentsList);
            }

            return nodeObject;
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            currentSelectedNode = e.Node;
            if (currentSelectedNode != null && currentSelectedNode.Tag != null)
            {
                var jsonElement = (JsonElement)currentSelectedNode.Tag;

                if (jsonElement.TryGetProperty("Body", out JsonElement bodyElement))
                {
                    string body = bodyElement.GetString();
                    updateOutput(currentSelectedNode.Text, body);
                }
                else
                {
                    updateOutput(currentSelectedNode.Text, string.Empty);
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (currentSelectedNode != null && currentSelectedNode.Tag != null)
            {
                var jsonElement = (JsonElement)currentSelectedNode.Tag;

                // Create a mutable copy of the JsonElement
                var updatedJson = new JsonObject();

                foreach (var property in jsonElement.EnumerateObject())
                {
                    if (property.Name == "Body")
                    {
                        updatedJson[property.Name] = richTextBox1.Text; // Update the Body with new text
                    }
                    else
                    {
                        updatedJson[property.Name] = property.Value.Clone();
                    }
                }

                // Update the TreeNode's Tag with the new JsonElement
                currentSelectedNode.Tag = JsonSerializer.Deserialize<JsonElement>(updatedJson.ToJsonString());
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadJson(openFileDialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Serialize TreeView back to JSON and save
                var argumentsList = new List<object>();

                foreach (TreeNode node in treeView1.Nodes)
                {
                    argumentsList.Add(SerializeNode(node));
                }

                var jsonObject = new
                {
                    ProgramName = "RefutationBrowser",
                    Arguments = argumentsList
                };

                string jsonString = JsonSerializer.Serialize(jsonObject, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(saveFileDialog.FileName, jsonString);
            }
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
