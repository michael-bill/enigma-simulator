using EnigmaSimulator.Enigma;
using EnigmaSimulator.Language.Dictionary;
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

namespace EnigmaSimulator.View
{
    public partial class Plugboard : Form
    {
        public Plugboard()
        {
            InitializeComponent();
            ViewController.ViewStylizer(this);
        }

        const string sep = " ⇆ ";

        private void Plugboard_Load(object sender, EventArgs e)
        {
            this.Text = Lang.plugboardTitle;
            PlugboardUtils.SetControlsText(this);
            comboBoxLeftLetter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRightLetter.DropDownStyle = ComboBoxStyle.DropDownList;
            fillComboboxes();
            fillListComp();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxLeftLetter.SelectedIndex >= 0 && comboBoxRightLetter.SelectedIndex >= 0 &&
                comboBoxLeftLetter.SelectedItem.ToString() != comboBoxRightLetter.SelectedItem.ToString()) {
                char letter1 = comboBoxLeftLetter.SelectedItem.ToString()[0];
                char letter2 = comboBoxRightLetter.SelectedItem.ToString()[0];
                listBoxComp.Items.Add(letter1 + sep + letter2);
                EncryptionManagement.PlugboardPermutation(Configuration.Plugboard, letter1, letter2);
                comboBoxLeftLetter.Items.Remove(letter1);
                comboBoxLeftLetter.Items.Remove(letter2);
                comboBoxRightLetter.Items.Remove(letter1);
                comboBoxRightLetter.Items.Remove(letter2);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxComp.SelectedIndex >= 0) {
                string value = listBoxComp.SelectedItem.ToString();
                char letter1 = value.Split(new string[] { sep }, StringSplitOptions.None)[0][0];
                char letter2 = value.Split(new string[] { sep }, StringSplitOptions.None)[1][0];
                EncryptionManagement.PlugboardPermutation(Configuration.Plugboard, letter1, letter2);
                listBoxComp.Items.RemoveAt(listBoxComp.SelectedIndex);
            }
        }

        private void fillComboboxes()
        {
            comboBoxLeftLetter.Items.Clear();
            comboBoxRightLetter.Items.Clear();
            for (int i = 0; i < Configuration.ALPH_LENGTH; i++) {
                if (Configuration.Plugboard[i] == Configuration.Alphabet[i]) {
                    comboBoxLeftLetter.Items.Add(Configuration.Alphabet[i]);
                    comboBoxRightLetter.Items.Add(Configuration.Alphabet[i]);
                }
            }
        }

        private void fillListComp()
        {
            listBoxComp.Items.Clear();
            for (int i = 0; i < Configuration.ALPH_LENGTH; i++) {
                char letter1 = Configuration.Plugboard[i];
                char letter2 = Configuration.Alphabet[i];
                if (letter1 != letter2 && !(listBoxComp.Items.Contains(letter2 + sep + letter1))) {
                    listBoxComp.Items.Add(letter1 + sep + letter2);
                }
            }
        }
    }
}