using System.Windows.Forms;

namespace SchulungsprojektGit
{
    public class Dialog4 : Form
    {
        public Dialog4()
        {
            Text = "Text für den vierter Niklas Jürgen";
            // immer nur einer Zeile

            Label lblText = new Label
            {
                Text = Text,
                AutoSize = true,
                Left = 40,
                Top = 30
            };

            // immer nur einer Zeile
            Controls.Add(lblText);

            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new System.Drawing.Size(350, 100);
        }
    }
}