using EnigmaSimulator.Language.Dictionary;
using EnigmaSimulator.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSimulator.View
{
    public partial class CopyrightView : Form
    {
        public CopyrightView()
        {
            InitializeComponent();
            ViewController.ViewStylizer(this);
            labelTitle.Text = Lang.copyrightTitle;
        }

        private void pictureBoxEmail_Click(object sender, EventArgs e)
        {
            try {
                Clipboard.SetText("biloshitskiy_m@mail.ru");
                MessageBox.Show(Lang.emailCopiedMessage, Lang.message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch { }
        }

        private void pictureBoxTg_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show(Lang.openBlowserDialog, Lang.message, MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
{
                Process.Start("https://t.me/imuafamilia");
            }
        }

        private void pictureBoxVK_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show(Lang.openBlowserDialog, Lang.message, MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
            {
                Process.Start("https://vk.com/imuafamilia");
            }
        }

        private void CopyrightView_Load(object sender, EventArgs e)
        {
            this.Text = Lang.copyright; 
        }
    }
}
