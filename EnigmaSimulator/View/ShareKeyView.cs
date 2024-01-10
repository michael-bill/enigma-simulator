using EnigmaSimulator.Enigma;
using EnigmaSimulator.Enigma.Model;
using EnigmaSimulator.Language.Dictionary;
using EnigmaSimulator.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSimulator.View
{
    public partial class ShareKeyView : Form
    {
        public ShareKeyView()
        {
            InitializeComponent();
            ViewController.ViewStylizer(this);
        }

        string[] romanNums = new string[] { "I", "II", "III", "IV", "V" };
        public bool changed = false;
        string configText = "";

        private void ShareKeyView_Load(object sender, EventArgs e)
        {
            LoadText();
            panelDrop.AllowDrop = true;
        }

        private void LoadText() {
            configText = "";
            for (int i = 0; i < Configuration.Compartments.Length; i++)
            {
                configText += "Compartment" + (i + 1) + ": " + romanNums[Configuration.Compartments[i].Type - 1] + "\r\n";
            }
            configText += "ReflectorType: " + Configuration.ReflectorСompartment.Type + "\r\n";
            for (int i = 0; i < Configuration.Compartments.Length; i++)
            {
                configText += "RotorPosition" + (i + 1) + ": " + Configuration.Compartments[i].Position + "\r\n";
            }
            configText += "Plugboard: " + new string(Configuration.Plugboard);
            textBoxConfig.Text = configText;
            buttonLoad.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Enigma Files(*.enig)|*.enig";
            sfd.FileName = "EnigmaCfg_" + DateTime.Now.ToString("dd.MM.yyyy");
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK) {
                using (FileStream file = new FileStream(sfd.FileName, FileMode.Create)) {
                    using (StreamWriter stream = new StreamWriter(file)) {
                        stream.Write(configText);
                        MessageBox.Show(Lang.fileSavedSuccessfully, Lang.message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Enigma Files(*.enig)|*.enig";
            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK) {
                FileLoad(ofd.FileName);
            }
        }

        private void FileLoad(string path) {
            try {
                string text = File.ReadAllText(path);
                string[] lines = text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                string[] values = new string[lines.Length];
                int i = 0;
                foreach (string line in lines) {
                    values[i] = line.Split(new string[] { ": " }, StringSplitOptions.None)[1];
                    i++;
                }
                changed = true;
                Configuration.Compartments[0] = new Rotor(Configuration.AllRotors[Array.IndexOf(romanNums, values[0])]);
                Configuration.Compartments[1] = new Rotor(Configuration.AllRotors[Array.IndexOf(romanNums, values[1])]);
                Configuration.Compartments[2] = new Rotor(Configuration.AllRotors[Array.IndexOf(romanNums, values[2])]);
                Configuration.ReflectorСompartment = Configuration.AllReflectors[Array.IndexOf("BC".ToCharArray(), values[3][0])];
                Configuration.Compartments[0].Position = Int32.Parse(values[4]);
                Configuration.Compartments[1].Position = Int32.Parse(values[5]);
                Configuration.Compartments[2].Position = Int32.Parse(values[6]);
                Configuration.Plugboard = values[7].ToCharArray();
                LoadText();
                MessageBox.Show(Lang.fileLoadedSuccessfully, Lang.message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                panelDrop.BackColor = Color.FromArgb(240, 240, 240);
            }
        }

        private void panel1_DragLeave(object sender, EventArgs e)
        {
            panelDrop.BackColor = Color.White;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string path = files[0].ToString();
            string fileFormat = Path.GetExtension(path);
            if (files.Length == 1 && fileFormat == ".enig") {
                FileLoad(path);
            }
            panelDrop.BackColor = Color.White;
        }
    }
}
