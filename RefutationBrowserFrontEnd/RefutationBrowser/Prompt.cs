using System;

public static class Prompt
{
    public static string ShowDialog(string text, string caption, string defaultValue = "")
    {
        Form prompt = new Form
        {
            Width = 400,
            Height = 150,
            Text = caption
        };
        Label textLabel = new Label { Left = 10, Top = 20, Text = text, AutoSize = true };
        TextBox textBox = new TextBox { Left = 10, Top = 50, Width = 360, Text = defaultValue };
        Button confirmation = new Button { Text = "OK", Left = 300, Width = 70, Top = 80, DialogResult = DialogResult.OK };
        confirmation.Click += (sender, e) => { prompt.Close(); };
        prompt.Controls.Add(textBox);
        prompt.Controls.Add(confirmation);
        prompt.Controls.Add(textLabel);
        prompt.AcceptButton = confirmation;

        return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
    }
}

