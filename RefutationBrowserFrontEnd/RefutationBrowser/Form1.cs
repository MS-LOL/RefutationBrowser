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
        public void UpdateOutput(string Name, string Body)
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
        private JsonElement CreateEmptyJsonElement(string nodeName)
        {
            string json = $"{{\"Name\":\"{nodeName}\", \"Body\":\"\", \"Children\":[]}}";
            return JsonDocument.Parse(json).RootElement;
        }
        private object SerializeNode(TreeNode node)
        {
            var jsonElement = (JsonElement)node.Tag;
            var nodeObject = JsonNode.Parse(jsonElement.GetRawText()) as JsonObject;

            if (nodeObject != null)
            {
                var counterArgumentsList = new List<object>();
                foreach (TreeNode childNode in node.Nodes)
                {
                    counterArgumentsList.Add(SerializeNode(childNode));
                }

                if (counterArgumentsList.Count > 0)
                {
                    nodeObject["CounterArguments"] = JsonSerializer.SerializeToNode(counterArgumentsList);
                }
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
                    UpdateOutput(currentSelectedNode.Text, body);
                }
                else
                {
                    UpdateOutput(currentSelectedNode.Text, string.Empty);
                }
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (currentSelectedNode != null && currentSelectedNode.Tag != null)
            {
                var jsonElement = (JsonElement)currentSelectedNode.Tag;

                // Create a mutable JsonNode to modify the Body content
                var updatedJsonNode = JsonNode.Parse(jsonElement.GetRawText()) as JsonObject;

                if (updatedJsonNode != null && updatedJsonNode.ContainsKey("Body"))
                {
                    updatedJsonNode["Body"] = richTextBox1.Text; // Update the Body with new text
                }

                // Update the TreeNode's Tag with the new JsonElement
                currentSelectedNode.Tag = JsonDocument.Parse(updatedJsonNode.ToJsonString()).RootElement;
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
        private void whatIsThisToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UpdateOutput("What is this program?", "This is the Debate Refutation Browser. \r\nThis program is for the use of:\r\n1) Checking common arguments used in certain debates.\r\n2) Coming up with counterpoints.\r\n3) Sharing this information with others.\r\nWhen debating on the interwebz, you may find yourself unable to tackle all arguments used at the same time.\r\nThis program fixes that issue by allowing you to view a hierarchy of arguments used in debates, plan out responses, and co-ordinate a debate with facts and logic rather than slander and insults.");
        }
        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string HowtoUse = "This";
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateOutput("Home", "Welcome to the Debate Refutation Browser.\r\n\r\nTo get started, click on Help\r\n\r\nWhat is this - A short introduction to this tool\r\nHow to use - How to use this tool and the terminology related to this\r\nHome - View this page\r\n");
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                var result = MessageBox.Show($"Are you sure you want to remove '{treeView1.SelectedNode.Text}'?",
                                             "Remove Node", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    treeView1.SelectedNode.Remove();
                }
            }
            else
            {
                MessageBox.Show("No node selected.", "Remove Node", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                string newNodeName = Prompt.ShowDialog("Enter new name for the node:", "Rename Node", treeView1.SelectedNode.Text);

                if (!string.IsNullOrEmpty(newNodeName))
                {
                    treeView1.SelectedNode.Text = newNodeName;

                    // Update the JSON element's "Name" property
                    var jsonElement = (JsonElement)treeView1.SelectedNode.Tag;
                    var updatedJsonNode = JsonNode.Parse(jsonElement.GetRawText()) as JsonObject;
                    if (updatedJsonNode != null && updatedJsonNode.ContainsKey("Name"))
                    {
                        updatedJsonNode["Name"] = newNodeName;
                        treeView1.SelectedNode.Tag = JsonDocument.Parse(updatedJsonNode.ToJsonString()).RootElement;
                    }
                }
            }
            else
            {
                MessageBox.Show("No node selected.", "Rename Node", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode node = treeView1.GetNodeAt(e.X, e.Y);
            if (node == null)
            {
                treeView1.SelectedNode = null;
                currentSelectedNode = null;
                richTextBox1.Clear();
            }
        }
        private void rootNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Prompt for the new root node's name
            string newNodeName = Prompt.ShowDialog("Enter name for the new root node:", "Add Root Node");

            if (!string.IsNullOrEmpty(newNodeName))
            {
                TreeNode newNode = new TreeNode(newNodeName)
                {
                    Tag = CreateEmptyJsonElement(newNodeName)
                };

                // Add the new node at the root level
                treeView1.Nodes.Add(newNode);
            }
        }
        private void childNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newNodeName = Prompt.ShowDialog("Enter name for new node:", "Add Node");

            if (!string.IsNullOrEmpty(newNodeName))
            {
                TreeNode newNode = new TreeNode(newNodeName)
                {
                    Tag = CreateEmptyJsonElement(newNodeName)
                };

                if (treeView1.SelectedNode != null)
                {
                    // Add as a child of the selected node
                    treeView1.SelectedNode.Nodes.Add(newNode);
                    treeView1.SelectedNode.Expand(); // Expand the parent node to show the new child

                    // Update the parent's JSON element to include the new child
                    var parentJsonElement = (JsonElement)treeView1.SelectedNode.Tag;
                    var updatedParentJsonNode = JsonNode.Parse(parentJsonElement.GetRawText()) as JsonObject;

                    if (updatedParentJsonNode != null && updatedParentJsonNode["Children"] is JsonArray childrenArray)
                    {
                        childrenArray.Add(JsonNode.Parse(newNode.Tag.ToString()));
                        treeView1.SelectedNode.Tag = JsonDocument.Parse(updatedParentJsonNode.ToJsonString()).RootElement;
                    }
                }
                else
                {
                    // Add as a root node
                    treeView1.Nodes.Add(newNode);
                }
            }
        }
    }
}
