
namespace EnigmaSimulator.View
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.EncryptionInfoPanel = new System.Windows.Forms.Panel();
            this.buttonRot3Plus = new System.Windows.Forms.Button();
            this.buttonRot3Min = new System.Windows.Forms.Button();
            this.textBoxCom1 = new System.Windows.Forms.TextBox();
            this.textBoxCom2 = new System.Windows.Forms.TextBox();
            this.buttonRot2Plus = new System.Windows.Forms.Button();
            this.buttonRot2Min = new System.Windows.Forms.Button();
            this.textBoxCom3 = new System.Windows.Forms.TextBox();
            this.buttonRot1Plus = new System.Windows.Forms.Button();
            this.buttonRot1Min = new System.Windows.Forms.Button();
            this.buttonCompartments = new System.Windows.Forms.Button();
            this.buttonRandomSet = new System.Windows.Forms.Button();
            this.buttonChangeViewRotors = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.panelPlugboard = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.pictureBoxCopyright = new System.Windows.Forms.PictureBox();
            this.buttonBackSpace = new System.Windows.Forms.Button();
            this.buttonShareKey = new System.Windows.Forms.Button();
            this.buttonPlugboard = new System.Windows.Forms.Button();
            this.labelShortInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopyright)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOutput
            // 
            resources.ApplyResources(this.textBoxOutput, "textBoxOutput");
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            // 
            // textBoxInput
            // 
            resources.ApplyResources(this.textBoxInput, "textBoxInput");
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ReadOnly = true;
            // 
            // labelOutput
            // 
            resources.ApplyResources(this.labelOutput, "labelOutput");
            this.labelOutput.Name = "labelOutput";
            // 
            // labelInput
            // 
            resources.ApplyResources(this.labelInput, "labelInput");
            this.labelInput.Name = "labelInput";
            // 
            // EncryptionInfoPanel
            // 
            this.EncryptionInfoPanel.BackColor = System.Drawing.Color.White;
            this.EncryptionInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.EncryptionInfoPanel, "EncryptionInfoPanel");
            this.EncryptionInfoPanel.Name = "EncryptionInfoPanel";
            // 
            // buttonRot3Plus
            // 
            resources.ApplyResources(this.buttonRot3Plus, "buttonRot3Plus");
            this.buttonRot3Plus.Name = "buttonRot3Plus";
            this.buttonRot3Plus.UseVisualStyleBackColor = true;
            this.buttonRot3Plus.Click += new System.EventHandler(this.buttonRot3Plus_Click);
            // 
            // buttonRot3Min
            // 
            resources.ApplyResources(this.buttonRot3Min, "buttonRot3Min");
            this.buttonRot3Min.Name = "buttonRot3Min";
            this.buttonRot3Min.UseVisualStyleBackColor = true;
            this.buttonRot3Min.Click += new System.EventHandler(this.buttonRot3Min_Click);
            // 
            // textBoxCom1
            // 
            resources.ApplyResources(this.textBoxCom1, "textBoxCom1");
            this.textBoxCom1.Name = "textBoxCom1";
            this.textBoxCom1.ReadOnly = true;
            // 
            // textBoxCom2
            // 
            resources.ApplyResources(this.textBoxCom2, "textBoxCom2");
            this.textBoxCom2.Name = "textBoxCom2";
            this.textBoxCom2.ReadOnly = true;
            // 
            // buttonRot2Plus
            // 
            resources.ApplyResources(this.buttonRot2Plus, "buttonRot2Plus");
            this.buttonRot2Plus.Name = "buttonRot2Plus";
            this.buttonRot2Plus.UseVisualStyleBackColor = true;
            this.buttonRot2Plus.Click += new System.EventHandler(this.buttonRot2Plus_Click);
            // 
            // buttonRot2Min
            // 
            resources.ApplyResources(this.buttonRot2Min, "buttonRot2Min");
            this.buttonRot2Min.Name = "buttonRot2Min";
            this.buttonRot2Min.UseVisualStyleBackColor = true;
            this.buttonRot2Min.Click += new System.EventHandler(this.buttonRot2Min_Click);
            // 
            // textBoxCom3
            // 
            resources.ApplyResources(this.textBoxCom3, "textBoxCom3");
            this.textBoxCom3.Name = "textBoxCom3";
            this.textBoxCom3.ReadOnly = true;
            // 
            // buttonRot1Plus
            // 
            resources.ApplyResources(this.buttonRot1Plus, "buttonRot1Plus");
            this.buttonRot1Plus.Name = "buttonRot1Plus";
            this.buttonRot1Plus.UseVisualStyleBackColor = true;
            this.buttonRot1Plus.Click += new System.EventHandler(this.buttonRot1Plus_Click);
            // 
            // buttonRot1Min
            // 
            resources.ApplyResources(this.buttonRot1Min, "buttonRot1Min");
            this.buttonRot1Min.Name = "buttonRot1Min";
            this.buttonRot1Min.UseVisualStyleBackColor = true;
            this.buttonRot1Min.Click += new System.EventHandler(this.buttonRot1Min_Click);
            // 
            // buttonCompartments
            // 
            resources.ApplyResources(this.buttonCompartments, "buttonCompartments");
            this.buttonCompartments.Name = "buttonCompartments";
            this.buttonCompartments.UseVisualStyleBackColor = true;
            this.buttonCompartments.Click += new System.EventHandler(this.buttonCompartments_Click);
            // 
            // buttonRandomSet
            // 
            resources.ApplyResources(this.buttonRandomSet, "buttonRandomSet");
            this.buttonRandomSet.Name = "buttonRandomSet";
            this.buttonRandomSet.UseVisualStyleBackColor = true;
            this.buttonRandomSet.Click += new System.EventHandler(this.buttonRandomSet_Click);
            // 
            // buttonChangeViewRotors
            // 
            resources.ApplyResources(this.buttonChangeViewRotors, "buttonChangeViewRotors");
            this.buttonChangeViewRotors.Name = "buttonChangeViewRotors";
            this.buttonChangeViewRotors.UseVisualStyleBackColor = true;
            this.buttonChangeViewRotors.Click += new System.EventHandler(this.buttonChangeViewRotors_Click);
            // 
            // buttonClear
            // 
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPaste
            // 
            resources.ApplyResources(this.buttonPaste, "buttonPaste");
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // buttonCopy
            // 
            resources.ApplyResources(this.buttonCopy, "buttonCopy");
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // panelPlugboard
            // 
            this.panelPlugboard.BackColor = System.Drawing.Color.White;
            this.panelPlugboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlugboard.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.panelPlugboard, "panelPlugboard");
            this.panelPlugboard.Name = "panelPlugboard";
            this.panelPlugboard.Click += new System.EventHandler(this.panelPlugboard_Click);
            // 
            // labelLogo
            // 
            resources.ApplyResources(this.labelLogo, "labelLogo");
            this.labelLogo.Name = "labelLogo";
            // 
            // pictureBoxCopyright
            // 
            this.pictureBoxCopyright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCopyright.Image = global::EnigmaSimulator.Properties.Resources.copyright;
            resources.ApplyResources(this.pictureBoxCopyright, "pictureBoxCopyright");
            this.pictureBoxCopyright.Name = "pictureBoxCopyright";
            this.pictureBoxCopyright.TabStop = false;
            this.pictureBoxCopyright.Click += new System.EventHandler(this.pictureBoxCopyright_Click);
            // 
            // buttonBackSpace
            // 
            resources.ApplyResources(this.buttonBackSpace, "buttonBackSpace");
            this.buttonBackSpace.Name = "buttonBackSpace";
            this.buttonBackSpace.UseVisualStyleBackColor = true;
            this.buttonBackSpace.Click += new System.EventHandler(this.buttonBackSpace_Click);
            // 
            // buttonShareKey
            // 
            resources.ApplyResources(this.buttonShareKey, "buttonShareKey");
            this.buttonShareKey.Name = "buttonShareKey";
            this.buttonShareKey.UseVisualStyleBackColor = true;
            this.buttonShareKey.Click += new System.EventHandler(this.buttonShareKey_Click);
            // 
            // buttonPlugboard
            // 
            resources.ApplyResources(this.buttonPlugboard, "buttonPlugboard");
            this.buttonPlugboard.Name = "buttonPlugboard";
            this.buttonPlugboard.UseVisualStyleBackColor = true;
            this.buttonPlugboard.Click += new System.EventHandler(this.buttonPlugboard_Click);
            // 
            // labelShortInfo
            // 
            resources.ApplyResources(this.labelShortInfo, "labelShortInfo");
            this.labelShortInfo.Name = "labelShortInfo";
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelShortInfo);
            this.Controls.Add(this.buttonPlugboard);
            this.Controls.Add(this.buttonShareKey);
            this.Controls.Add(this.buttonBackSpace);
            this.Controls.Add(this.pictureBoxCopyright);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.panelPlugboard);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonPaste);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonChangeViewRotors);
            this.Controls.Add(this.buttonRandomSet);
            this.Controls.Add(this.buttonCompartments);
            this.Controls.Add(this.textBoxCom3);
            this.Controls.Add(this.buttonRot1Plus);
            this.Controls.Add(this.buttonRot1Min);
            this.Controls.Add(this.textBoxCom2);
            this.Controls.Add(this.buttonRot2Plus);
            this.Controls.Add(this.buttonRot2Min);
            this.Controls.Add(this.textBoxCom1);
            this.Controls.Add(this.buttonRot3Plus);
            this.Controls.Add(this.buttonRot3Min);
            this.Controls.Add(this.EncryptionInfoPanel);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxOutput);
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopyright)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Panel EncryptionInfoPanel;
        private System.Windows.Forms.Button buttonRot3Plus;
        private System.Windows.Forms.Button buttonRot3Min;
        private System.Windows.Forms.TextBox textBoxCom1;
        private System.Windows.Forms.TextBox textBoxCom2;
        private System.Windows.Forms.Button buttonRot2Plus;
        private System.Windows.Forms.Button buttonRot2Min;
        private System.Windows.Forms.TextBox textBoxCom3;
        private System.Windows.Forms.Button buttonRot1Plus;
        private System.Windows.Forms.Button buttonRot1Min;
        private System.Windows.Forms.Button buttonCompartments;
        private System.Windows.Forms.Button buttonRandomSet;
        private System.Windows.Forms.Button buttonChangeViewRotors;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Panel panelPlugboard;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.PictureBox pictureBoxCopyright;
        private System.Windows.Forms.Button buttonBackSpace;
        private System.Windows.Forms.Button buttonShareKey;
        private System.Windows.Forms.Button buttonPlugboard;
        private System.Windows.Forms.Label labelShortInfo;
    }
}