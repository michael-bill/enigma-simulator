using EnigmaSimulator.Enigma;
using EnigmaSimulator.Language.Dictionary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSimulator.Utils
{
    class PlugboardUtils
    {
        public static void FillPreviewPanel(Panel panel)
        {
            panel.Controls.Clear();
            Bitmap bitmap = new Bitmap(panel.Width, panel.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Gray, 2);
            int xPos = 5, yPos = 5;
            int width = 15, height = 17;
            for (int k = 0; k < 2; k++) {
                for (int i = 0; i < Configuration.ALPH_LENGTH; i++) {
                    Label label = new Label() {
                        Name = k == 0 ? "up_" + i : "down_" + i,
                        Text = Configuration.Alphabet[i] + "",
                        Width = width,
                        Height = height,
                        Location = new Point(xPos, yPos),
                        TextAlign = ContentAlignment.MiddleLeft,
                        BorderStyle = BorderStyle.FixedSingle,
                        Font = new Font("Consolas", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 204)
                    };
                    panel.Controls.Add(label);
                    xPos += 14;
                }
                xPos = 5;
                yPos += 123;
            }
            for (int i = 0; i < Configuration.ALPH_LENGTH; i++) {
                graphics.DrawLine(pen,
                    panel.Controls["up_" + i].Location.X + (width / 2),
                    panel.Controls["up_" + i].Location.Y + height - 1,
                    panel.Controls["down_" + Array.IndexOf(Configuration.Alphabet, Configuration.Plugboard[i])].Location.X + (width / 2),
                    panel.Controls["down_" + Array.IndexOf(Configuration.Alphabet, Configuration.Plugboard[i])].Location.Y);
            }
            panel.BackgroundImage = bitmap;
        }

        public static void SetControlsText(Form form)
        {
            form.Controls["labelTitle"].Text = Lang.plugboardLabelText;
            form.Controls["buttonAdd"].Text = Lang.add;
            form.Controls["buttonDelete"].Text = Lang.delete;
        }
    }
}
