using System.Windows.Forms;

namespace SchulungsprojektGit
{
    public class Dialog3 : Form
    {
        public Dialog3()
        {
            Text = "Text für den dritten Dialog";
            // Änderung 1 für Feat 2
            // Änderung 2 für Feat 2


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