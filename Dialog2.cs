using System.Windows.Forms;

namespace SchulungsprojektGit
{
    public class Dialog2 : Form
    {
        public Dialog2()
        {
            Text = "Text für den zweiten Dialog Änderung im Branch Feat1";
            // Das wurde für die Schulung angepasst

            Label lblText = new Label
            {
                Text = Text,
                AutoSize = true,
                Left = 40,
                Top = 30
            };

            Controls.Add(lblText);

            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new System.Drawing.Size(350, 100);
        }
    }
}