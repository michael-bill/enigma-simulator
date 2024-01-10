
namespace EnigmaSimulator.View
{
    partial class Plugboard
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxComp = new System.Windows.Forms.ListBox();
            this.comboBoxLeftLetter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxRightLetter = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(124, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Plugboard replacements:";
            // 
            // listBoxComp
            // 
            this.listBoxComp.FormattingEnabled = true;
            this.listBoxComp.Location = new System.Drawing.Point(12, 35);
            this.listBoxComp.Name = "listBoxComp";
            this.listBoxComp.Size = new System.Drawing.Size(376, 212);
            this.listBoxComp.TabIndex = 2;
            // 
            // comboBoxLeftLetter
            // 
            this.comboBoxLeftLetter.Location = new System.Drawing.Point(12, 253);
            this.comboBoxLeftLetter.Name = "comboBoxLeftLetter";
            this.comboBoxLeftLetter.Size = new System.Drawing.Size(161, 21);
            this.comboBoxLeftLetter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "⇆";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(12, 290);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(161, 32);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(227, 290);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(161, 32);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxRightLetter
            // 
            this.comboBoxRightLetter.Location = new System.Drawing.Point(227, 253);
            this.comboBoxRightLetter.Name = "comboBoxRightLetter";
            this.comboBoxRightLetter.Size = new System.Drawing.Size(161, 21);
            this.comboBoxRightLetter.TabIndex = 8;
            // 
            // Plugboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 336);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxRightLetter);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLeftLetter);
            this.Controls.Add(this.listBoxComp);
            this.Controls.Add(this.labelTitle);
            this.Name = "Plugboard";
            this.Text = "Plugboard";
            this.Load += new System.EventHandler(this.Plugboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox listBoxComp;
        private System.Windows.Forms.ComboBox comboBoxLeftLetter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxRightLetter;
    }
}