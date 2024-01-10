namespace EnigmaSimulator.View
{
    partial class ShareKeyView
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
            this.textBoxConfig = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDrop = new System.Windows.Forms.Panel();
            this.labelDrag = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.panelDrop.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxConfig
            // 
            this.textBoxConfig.Location = new System.Drawing.Point(12, 51);
            this.textBoxConfig.Multiline = true;
            this.textBoxConfig.Name = "textBoxConfig";
            this.textBoxConfig.ReadOnly = true;
            this.textBoxConfig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConfig.Size = new System.Drawing.Size(320, 266);
            this.textBoxConfig.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(64, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Current key:";
            // 
            // panelDrop
            // 
            this.panelDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrop.Controls.Add(this.labelDrag);
            this.panelDrop.Location = new System.Drawing.Point(338, 51);
            this.panelDrop.Name = "panelDrop";
            this.panelDrop.Size = new System.Drawing.Size(107, 266);
            this.panelDrop.TabIndex = 2;
            this.panelDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panelDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panelDrop.DragLeave += new System.EventHandler(this.panel1_DragLeave);
            // 
            // labelDrag
            // 
            this.labelDrag.AutoSize = true;
            this.labelDrag.Location = new System.Drawing.Point(27, 106);
            this.labelDrag.Name = "labelDrag";
            this.labelDrag.Size = new System.Drawing.Size(30, 39);
            this.labelDrag.TabIndex = 1;
            this.labelDrag.Text = "Drag\r\nand\r\nDrop";
            this.labelDrag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(338, 9);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 36);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(227, 9);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(105, 36);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // ShareKeyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 329);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelDrop);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxConfig);
            this.Name = "ShareKeyView";
            this.Text = "ShareKeyView";
            this.Load += new System.EventHandler(this.ShareKeyView_Load);
            this.panelDrop.ResumeLayout(false);
            this.panelDrop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConfig;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDrop;
        private System.Windows.Forms.Label labelDrag;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
    }
}