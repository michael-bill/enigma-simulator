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
    public partial class RotorsConfiguration : Form
    {
        public RotorsConfiguration()
        {
            InitializeComponent();
            ViewController.ViewStylizer(this);
        }

        string[] romanNums = new string[] { "I", "II", "III", "IV", "V" };
        public bool changed = false;
        private bool loaded = false;

        private void RotorsConfiguration_Load(object sender, EventArgs e)
        {
            this.Text = Lang.configuration;
            labelCompartment1.Text = Lang.сompartmentLabel + " 1:";
            labelCompartment2.Text = Lang.сompartmentLabel + " 2:";
            labelCompartment3.Text = Lang.сompartmentLabel + " 3:";
            labelReflector.Text = Lang.reflectorLabel + ":";

            for (int i = 0; i < Configuration.AllRotors.Length; i++) {
                comboBoxCom1.Items.Add(romanNums[i]);
                comboBoxCom2.Items.Add(romanNums[i]);
                comboBoxCom3.Items.Add(romanNums[i]);
            }
            for (int i = 0; i < Configuration.AllReflectors.Length; i++) {
                comboBoxRef.Items.Add(Configuration.AllReflectors[i].Type);
            }
            comboBoxCom1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCom2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCom3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRef.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxCom1.SelectedIndexChanged += ComboBoxCom_Changed;
            comboBoxCom2.SelectedIndexChanged += ComboBoxCom_Changed;
            comboBoxCom3.SelectedIndexChanged += ComboBoxCom_Changed;
            comboBoxRef.SelectedIndexChanged += ComboBoxCom_Changed;

            comboBoxCom1.SelectedIndex = Configuration.Compartments[0].Type - 1;
            comboBoxCom2.SelectedIndex = Configuration.Compartments[1].Type - 1;
            comboBoxCom3.SelectedIndex = Configuration.Compartments[2].Type - 1;
            comboBoxRef.SelectedIndex = Configuration.ReflectorСompartment.Type == 'B' ? 0 : 1;

            UpdateText();
            loaded = true;
        }

        private void ComboBoxCom_Changed(object sender, EventArgs e)
        {
            if (loaded) {
                Configuration.Compartments[0] = Configuration.AllRotors[comboBoxCom1.SelectedIndex];
                Configuration.Compartments[1] = Configuration.AllRotors[comboBoxCom2.SelectedIndex];
                Configuration.Compartments[2] = Configuration.AllRotors[comboBoxCom3.SelectedIndex];
                Configuration.ReflectorСompartment = Configuration.AllReflectors[comboBoxRef.SelectedIndex];
                UpdateText();
                changed = true;
            }
        }

        private void UpdateText()
        {
            labelCom1Prev.Text = new string(Configuration.Compartments[0].Replacements);
            labelCom2Prev.Text = new string(Configuration.Compartments[1].Replacements);
            labelCom3Prev.Text = new string(Configuration.Compartments[2].Replacements);
            labelRefPrev.Text = new string(Configuration.ReflectorСompartment.Replacements);
        }
    }
}
