using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ContactsUI.Controls.Util
{
    public static class Prompt
    {
        public static string ShowInputDialog(string title, string hint, string text = "")
        {
            MaterialForm prompt = new()
            {
                Width = 500,
                Height = 200,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };
            MaterialSkinManager.Instance.AddFormToManage(prompt);
            MaterialTextBox textBox = new()
            {
                Left = 50,
                Top = 80,
                Width = 400,
                Hint = hint,
                Text = text,
                
            };
            MaterialButton confirmation = new() 
            {
                Text = "Ok", 
                Left = 350, 
                Width = 100, 
                Top = 150, 
                DialogResult = DialogResult.OK 
            };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        public static bool ShowConfirmationDialog(string title, string text = "")
        {
            MaterialForm prompt = new()
            {
                Width = 500,
                Height = 200,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };
            MaterialSkinManager.Instance.AddFormToManage(prompt);
            MaterialLabel textBox = new()
            {
                Left = 50,
                Top = 80,
                Width = 400,
                Height = 70,
                Text = text,
                BackColor = System.Drawing.Color.White,
            };
            MaterialButton yesButton = new()
            {
                Text = "Yes",
                Left = 270,
                Width = 50,
                Top = 150,
                DialogResult = DialogResult.Yes
            };
            MaterialButton noButton = new()
            {
                Text = "No",
                Left = 370,
                Width = 50,
                Top = 150,
                DialogResult = DialogResult.No
            };
            yesButton.Click += (sender, e) => { prompt.Close(); };
            noButton.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(yesButton);
            prompt.Controls.Add(noButton);
            prompt.AcceptButton = yesButton;
            prompt.CancelButton = noButton;

            return prompt.ShowDialog() == DialogResult.Yes;
        }
    }
}
