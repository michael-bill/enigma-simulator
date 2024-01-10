using EnigmaSimulator.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnigmaSimulator.Enigma;
using EnigmaSimulator.Language;
using EnigmaSimulator.Language.Dictionary;

namespace EnigmaSimulator.View
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            Localization.SetLanguage("en");
            InitializeComponent();
            ViewController.ViewStylizer(this);
            MainWindowUtils.SetControlsText(this);
            MainWindowUtils.SetControlsFonts(this);
            textBoxInput.Select();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            MainWindowUtils.CreateKeyboardButtons(this);
            PlugboardUtils.FillPreviewPanel(panelPlugboard);
            EncryptionInfoUtils.FillPreviewPanel(EncryptionInfoPanel);
            MainWindowUtils.SetInfoLabel(this);
        }

        private void buttonRot1Min_Click(object sender, EventArgs e)
        {
            MainWindowUtils.ChangeViewMin(ref Configuration.Compartments[0].Position, textBoxCom1);
        }

        private void buttonRot1Plus_Click(object sender, EventArgs e)
        {
            MainWindowUtils.ChangeViewPlus(ref Configuration.Compartments[0].Position, textBoxCom1);
        }

        private void buttonRot2Min_Click(object sender, EventArgs e)
        {
            MainWindowUtils.ChangeViewMin(ref Configuration.Compartments[1].Position, textBoxCom2);
        }

        private void buttonRot2Plus_Click(object sender, EventArgs e)
        {
            MainWindowUtils.ChangeViewPlus(ref Configuration.Compartments[1].Position, textBoxCom2);
        }

        private void buttonRot3Min_Click(object sender, EventArgs e)
        {
            MainWindowUtils.ChangeViewMin(ref Configuration.Compartments[2].Position, textBoxCom3);
        }

        private void buttonRot3Plus_Click(object sender, EventArgs e)
        {
            MainWindowUtils.ChangeViewPlus(ref Configuration.Compartments[2].Position, textBoxCom3);
        }

        private void buttonChangeViewRotors_Click(object sender, EventArgs e)
        {
            MainWindowUtils.RotorsViewChanged = !MainWindowUtils.RotorsViewChanged;
            MainWindowUtils.SetRotorTextBoxesText(this);
        }

        private void pictureBoxCopyright_Click(object sender, EventArgs e)
        {
            CopyrightView form = new CopyrightView();
            form.ShowDialog();
            form.Dispose();
        }

        private void panelPlugboard_Click(object sender, EventArgs e)
        {
            string temp = new string(Configuration.Plugboard);
            Plugboard form = new Plugboard();
            form.ShowDialog();
            form.Dispose();
            if (temp != new string(Configuration.Plugboard)) {
                Clear();
                PlugboardUtils.FillPreviewPanel(panelPlugboard);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            MainWindowUtils.BackSpace(this);
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && textBoxInput.Focused) {
                MainWindowUtils.BackSpace(this);
                textBoxInput.SelectionStart = textBoxInput.Text.Length;
            } else if (e.KeyCode.ToString().Length == 1 && Configuration.Alphabet.Contains(e.KeyCode.ToString()[0])) {
                MainWindowUtils.LetterClick(e.KeyCode.ToString()[0], this);
            }
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            MainWindowUtils.PasteClick(Clipboard.GetText(), this);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            try {
                Clipboard.SetText(textBoxOutput.Text);
                MessageBox.Show(Lang.outputCopiedMessage, Lang.message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch { }
        }

        private void Clear()
        {
            if (Configuration.Key != null) {
                textBoxInput.Text = "";
                textBoxOutput.Text = "";
                EncryptionManagement.RollBack();
                MainWindowUtils.SetRotorTextBoxesText(this);
                EncryptionInfoUtils.DrawPreviewEncryptionSequence(EncryptionInfoPanel);
            }
        }

        private void buttonCompartments_Click(object sender, EventArgs e)
        {
            RotorsConfiguration form = new RotorsConfiguration();
            form.ShowDialog();
            if (form.changed) {
                textBoxInput.Text = "";
                textBoxOutput.Text = "";
                if (Configuration.Key != null) EncryptionManagement.RollBack();
                EncryptionInfoUtils.DrawPreviewEncryptionSequence(EncryptionInfoPanel);
                EncryptionInfoUtils.FillPreviewPanel(EncryptionInfoPanel);
                MainWindowUtils.SetInfoLabel(this);
            }
        }

        private void buttonRandomSet_Click(object sender, EventArgs e)
        {
            MainWindowUtils.RandomSet(this);
        }

        private void buttonPlugboard_Click(object sender, EventArgs e)
        {
            panelPlugboard_Click(sender, e);
        }

        private void buttonShareKey_Click(object sender, EventArgs e)
        {
            ShareKeyView form = new ShareKeyView();
            form.ShowDialog();
            if (form.changed) {
                textBoxInput.Text = "";
                textBoxOutput.Text = "";
                if (Configuration.Key != null) EncryptionManagement.RollBack();
                EncryptionInfoUtils.DrawPreviewEncryptionSequence(EncryptionInfoPanel);
                EncryptionInfoUtils.FillPreviewPanel(EncryptionInfoPanel);
                PlugboardUtils.FillPreviewPanel(panelPlugboard);
                MainWindowUtils.SetInfoLabel(this);
            }
        }
    }
}
