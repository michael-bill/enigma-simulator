using EnigmaSimulator.Enigma;
using EnigmaSimulator.Language.Dictionary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSimulator.Utils
{
    class MainWindowUtils
    {
        public static bool RotorsViewChanged = false;
        public const string KEYBOARD_CHARS = "QWERTYUIOPASDFGHJKLZXCVBNM";

        public static void ChangeViewMin(ref int rot, TextBox txt)
        {
            if (rot != 1) rot--;
            else rot = Configuration.ALPH_LENGTH;
            txt.Text = RotorsViewChanged ? rot + "" : Configuration.Alphabet[rot - 1] + "";
        }

        public static void ChangeViewPlus(ref int rot, TextBox txt)
        {
            if (rot != Configuration.ALPH_LENGTH) rot++;
            else rot = 1;
            txt.Text = RotorsViewChanged ? rot + "" : Configuration.Alphabet[rot - 1] + "";
        }

        public static void SetControlsText(Form form)
        {
            form.Text = Lang.title;
            form.Controls["labelInput"].Text = Lang.input;
            form.Controls["labelOutput"].Text = Lang.output;
            form.Controls["buttonClear"].Text = Lang.clear;
            form.Controls["buttonPaste"].Text = Lang.paste;
            form.Controls["buttonCopy"].Text = Lang.copy;
            form.Controls["buttonChangeViewRotors"].Text = Lang.btnChangeViewRotors;
            form.Controls["buttonRandomSet"].Text = Lang.randomSet;
            form.Controls["buttonCompartments"].Text = Lang.configuration;
            form.Controls["buttonBackSpace"].Text = Lang.btnBackspace;
            form.Controls["buttonShareKey"].Text = Lang.shareKeyButton;
            form.Controls["buttonPlugboard"].Text = Lang.plugboardTitle;
            SetRotorTextBoxesText(form);
        }

        public static void SetControlsFonts(Form form)
        {
            Font font = new Font("Consolas", 16.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            form.Controls["labelLogo"].Font = new Font("Consolas", 19.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            form.Controls["textBoxInput"].Font = font;
            form.Controls["textBoxOutput"].Font = font;
            form.Controls["textBoxCom1"].Font = font;
            form.Controls["textBoxCom2"].Font = font;
            form.Controls["textBoxCom3"].Font = font;
        }

        public static void SetRotorTextBoxesText(Form form)
        {
            form.Controls["textBoxCom1"].Text = RotorsViewChanged ?
                Configuration.Compartments[0].Position + "" :
                Configuration.Alphabet[Configuration.Compartments[0].Position - 1] + "";
            form.Controls["textBoxCom2"].Text = RotorsViewChanged ?
                Configuration.Compartments[1].Position + "" :
                Configuration.Alphabet[Configuration.Compartments[1].Position - 1] + "";
            form.Controls["textBoxCom3"].Text = RotorsViewChanged ?
                Configuration.Compartments[2].Position + "" :
                Configuration.Alphabet[Configuration.Compartments[2].Position - 1] + "";
        }

        public static void SetInfoLabel(Form form)
        {
            string[] romanNums = new string[] { "I", "II", "III", "IV", "V" };
            form.Controls["labelShortInfo"].Text =
                "Rotors: " +
                romanNums[Configuration.Compartments[0].Type - 1] + ", " +
                romanNums[Configuration.Compartments[1].Type - 1] + ", " +
                romanNums[Configuration.Compartments[2].Type - 1] + " " +
                "Reflector: " + Configuration.ReflectorСompartment.Type;
        }

        public static void CreateKeyboardButtons(Form form)
        {
            int xPos = 30, yPos = 173;
            int width = 53, height = 42;
            for (int i = 0; i < Configuration.ALPH_LENGTH; i++) {
                if (i == 10) {
                    xPos = 46;
                    yPos += 51;
                } else if (i == 19) {
                    xPos = 83;
                    yPos += 51;
                }
                Button buttonLetter = new Button() {
                    Size = new Size(width, height),
                    Text = KEYBOARD_CHARS[i].ToString(),
                    Name = "buttonKeyboard_" + KEYBOARD_CHARS[i].ToString(),
                    Location = new Point(xPos, yPos),
                    Cursor = Cursors.Hand,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.White,
                    Font = new Font("Consolas", 15.25F, FontStyle.Regular, GraphicsUnit.Point, 204)
                };
                xPos += 63;
                buttonLetter.Click += (sender, e) => {
                    LetterClick(((Button)sender).Text[0], form);
                };
                form.Controls.Add(buttonLetter);
            }
        }

        public static void LetterClick(char letter, Form form)
        {
            form.Controls["textBoxInput"].Text += letter;
            form.Controls["textBoxOutput"].Text += EncryptionManagement.StartEncryption(letter);
            ((TextBox)form.Controls["textBoxInput"]).SelectionStart = form.Controls["textBoxInput"].Text.Length;
            ((TextBox)form.Controls["textBoxOutput"]).SelectionStart = form.Controls["textBoxOutput"].Text.Length;
            SetRotorTextBoxesText(form);
            EncryptionInfoUtils.DrawPreviewEncryptionSequence((Panel)form.Controls["EncryptionInfoPanel"]);
        }

        public static void PasteClick(string line, Form form)
        {
            line = Regex.Replace(line.ToUpper(), "(?i)[^A-Z]", "");
            if (line.Length > 0) {
                string resultLine = "";
                foreach (char letter in line) {
                    resultLine += EncryptionManagement.StartEncryption(letter);
                }
                form.Controls["textBoxInput"].Text += line;
                form.Controls["textBoxOutput"].Text += resultLine;
                ((TextBox)form.Controls["textBoxInput"]).SelectionStart = form.Controls["textBoxInput"].Text.Length;
                ((TextBox)form.Controls["textBoxOutput"]).SelectionStart = form.Controls["textBoxOutput"].Text.Length;
                SetRotorTextBoxesText(form);
                EncryptionInfoUtils.DrawPreviewEncryptionSequence((Panel)form.Controls["EncryptionInfoPanel"]);
            } else {
                MessageBox.Show(Lang.clipboardIsEmptyMessage, Lang.message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void BackSpace(Form form)
        {
            if (form.Controls["textBoxInput"].Text.Length > 0) {
                EncryptionManagement.StepBack();
                SetRotorTextBoxesText(form);
                form.Controls["textBoxOutput"].Text = form.Controls["textBoxOutput"].Text.Substring(0, form.Controls["textBoxOutput"].Text.Length - 1);
                form.Controls["textBoxInput"].Text = form.Controls["textBoxInput"].Text.Substring(0, form.Controls["textBoxInput"].Text.Length - 1);
                EncryptionInfoUtils.DrawPreviewEncryptionSequence((Panel)form.Controls["EncryptionInfoPanel"]);
            }
        }

        public static void RandomSet(Form form)
        {
            if (MessageBox.Show(Lang.areYouSureMessage, Lang.message, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                // Rotors
                Random random = new Random();
                for (int i = 0; i < Configuration.Compartments.Length; i++) {
                    int index = random.Next(0, Configuration.AllRotors.Length);
                    Configuration.Compartments[i] = new Enigma.Model.Rotor(Configuration.AllRotors[index]);
                    Configuration.Compartments[i].Position = random.Next(1, Configuration.ALPH_LENGTH + 1);
                }
                // Reflector
                Configuration.ReflectorСompartment = Configuration.AllReflectors[random.Next(0, Configuration.AllReflectors.Length)];
                // Plugboard
                Array.Copy(Configuration.Alphabet, Configuration.Plugboard, Configuration.ALPH_LENGTH);
                for (int i = 0; i < 8; i++) {
                    char randomLetter1 = Configuration.Alphabet[random.Next(0, Configuration.ALPH_LENGTH)];
                    char randomLetter2 = Configuration.Alphabet[random.Next(0, Configuration.ALPH_LENGTH)];
                    while (randomLetter2 == randomLetter1) { randomLetter2 = Configuration.Alphabet[random.Next(0, Configuration.ALPH_LENGTH)]; }
                    if (Array.IndexOf(Configuration.Plugboard, randomLetter1) != Array.IndexOf(Configuration.Alphabet, randomLetter1) ||
                        Array.IndexOf(Configuration.Plugboard, randomLetter2) != Array.IndexOf(Configuration.Alphabet, randomLetter2))
                    {
                        i--;
                        continue;
                    }
                    EncryptionManagement.PlugboardPermutation(Configuration.Plugboard, randomLetter1, randomLetter2);
                }

                Configuration.EncryptionSteps.Clear();
                form.Controls["textBoxInput"].Text = "";
                form.Controls["textBoxOutput"].Text = "";
                SetInfoLabel(form);
                SetRotorTextBoxesText(form);
                PlugboardUtils.FillPreviewPanel(form.Controls["panelPlugboard"] as Panel);
                EncryptionInfoUtils.FillPreviewPanel(form.Controls["EncryptionInfoPanel"] as Panel);
            }
        }
    }
}
