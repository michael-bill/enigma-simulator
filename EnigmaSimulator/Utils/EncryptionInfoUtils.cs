using EnigmaSimulator.Enigma;
using EnigmaSimulator.Enigma.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSimulator.Utils
{
    class EncryptionInfoUtils
    {
        const int LABEL_PREVIEW_SIZE = 13;

        public static void FillPreviewPanel(Panel panel)
        {
            panel.BackgroundImage = null;
            panel.Controls.Clear();

            int yPos = 4;
            int id = 0;

            int rowX = 322;
            CreateLabels(panel, rowX, yPos, Configuration.Alphabet, id++);

            rowX = 282;
            CreateLabels(panel, rowX, yPos, Configuration.Alphabet, id++);

            rowX = 230;
            CreateLabels(panel, rowX, yPos, Configuration.Alphabet, id++);
            CreateLabels(panel, rowX -= 11, yPos, Configuration.Compartments[0].Replacements, id++);

            rowX = 160;
            CreateLabels(panel, rowX, yPos, Configuration.Alphabet, id++);
            CreateLabels(panel, rowX -= 11, yPos, Configuration.Compartments[1].Replacements, id++);

            rowX = 90;
            CreateLabels(panel, rowX, yPos, Configuration.Alphabet, id++);
            CreateLabels(panel, rowX -= 11, yPos, Configuration.Compartments[2].Replacements, id++);

            rowX = 20;
            CreateLabels(panel, rowX, yPos, Configuration.Alphabet, id++);
            CreateLabels(panel, rowX - 11, yPos, Configuration.ReflectorСompartment.Replacements, id);
        }

        public static void DrawPreviewEncryptionSequence(Panel panel)
        {
            if (Configuration.EncryptionSteps.Count > 0)
            {
                Bitmap bitmap = new Bitmap(panel.Width, panel.Height);
                Graphics graphics = Graphics.FromImage(bitmap);
                Pen pen = new Pen(Color.Green, 2);

                DrawForwardRoute(graphics, pen, panel, 0, 0);
                DrawForwardRoute(graphics, pen, panel, 1, 1);
                DrawForwardRoute(graphics, pen, panel, 3, 3);
                DrawForwardRoute(graphics, pen, panel, 5, 5);
                DrawForwardRoute(graphics, pen, panel, 7, 7);

                pen.Color = Color.Red;

                DrawBackwardRoute(graphics, pen, panel, 8, 9);
                DrawBackwardRoute(graphics, pen, panel, 6, 11);
                DrawBackwardRoute(graphics, pen, panel, 4, 13);
                DrawBackwardRoute(graphics, pen, panel, 2, 15);
                DrawBackwardRoute(graphics, pen, panel, 1, 16);
                panel.BackgroundImage = bitmap;
            }
            else
            {
                panel.BackgroundImage = null;
            }
        }

        private static void DrawForwardRoute(Graphics graphics, Pen pen, Panel panel, int id, int index)
        {
            EncryptionStep step = Configuration.EncryptionSteps[Configuration.EncryptionSteps.Count - 1];
            graphics.DrawLine(
                pen,
                panel.Controls[id + "_" + Configuration.Alphabet[step.EncryptionSequence[index]]].Location.X,
                panel.Controls[id + "_" + Configuration.Alphabet[step.EncryptionSequence[index]]].Location.Y + (LABEL_PREVIEW_SIZE / 2),
                panel.Controls[(id + 1) + "_" + Configuration.Alphabet[step.EncryptionSequence[index + 1]]].Location.X + LABEL_PREVIEW_SIZE,
                panel.Controls[(id + 1) + "_" + Configuration.Alphabet[step.EncryptionSequence[index + 1]]].Location.Y + (LABEL_PREVIEW_SIZE / 2)
            );
        }

        private static void DrawBackwardRoute(Graphics graphics, Pen pen, Panel panel, int id, int index)
        {
            EncryptionStep step = Configuration.EncryptionSteps[Configuration.EncryptionSteps.Count - 1];
            graphics.DrawLine(
                pen,
                panel.Controls[id + "_" + Configuration.Alphabet[step.EncryptionSequence[index]]].Location.X + LABEL_PREVIEW_SIZE,
                panel.Controls[id + "_" + Configuration.Alphabet[step.EncryptionSequence[index]]].Location.Y + (LABEL_PREVIEW_SIZE / 2),
                panel.Controls[(id - 1) + "_" + Configuration.Alphabet[step.EncryptionSequence[index + 1]]].Location.X,
                panel.Controls[(id - 1) + "_" + Configuration.Alphabet[step.EncryptionSequence[index + 1]]].Location.Y + (LABEL_PREVIEW_SIZE / 2)
            );
        }


        private static void CreateLabels(Panel panel, int xPos, int yPos, char[] letters, int id)
        {
            for (int i = 0; i < Configuration.ALPH_LENGTH; i++)
            {
                Label label = new Label()
                {
                    Name = id + "_" + letters[i],
                    Text = letters[i] + "",
                    Width = LABEL_PREVIEW_SIZE,
                    Height = LABEL_PREVIEW_SIZE,
                    Location = new Point(xPos, yPos),
                    Font = new Font("Consolas", 10.0F, FontStyle.Regular, GraphicsUnit.Point, 204)
                };
                panel.Controls.Add(label);
                yPos += LABEL_PREVIEW_SIZE;
            }
        }
    }
}
