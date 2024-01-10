
namespace EnigmaSimulator.View
{
    partial class CopyrightView
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
            this.labelVK = new System.Windows.Forms.Label();
            this.labelTelegram = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.pictureBoxTg = new System.Windows.Forms.PictureBox();
            this.pictureBoxVK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVK)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVK
            // 
            this.labelVK.AutoSize = true;
            this.labelVK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelVK.Location = new System.Drawing.Point(14, 184);
            this.labelVK.Name = "labelVK";
            this.labelVK.Size = new System.Drawing.Size(170, 20);
            this.labelVK.TabIndex = 12;
            this.labelVK.Text = "ВК: vk.com/imuafamilia";
            // 
            // labelTelegram
            // 
            this.labelTelegram.AutoSize = true;
            this.labelTelegram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTelegram.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTelegram.Location = new System.Drawing.Point(14, 152);
            this.labelTelegram.Name = "labelTelegram";
            this.labelTelegram.Size = new System.Drawing.Size(178, 20);
            this.labelTelegram.TabIndex = 10;
            this.labelTelegram.Text = "Telegram: @imuafamilia";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelEmail.Location = new System.Drawing.Point(14, 121);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(213, 20);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "email: biloshitskiy_m@mail.ru";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(15, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(243, 90);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Программа была создана и\r\nнаписана Билошицким Михаилом\r\n\r\nТут вы можете найти кон" +
    "такты\r\nавтора:";
            // 
            // pictureBoxEmail
            // 
            this.pictureBoxEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEmail.Image = global::EnigmaSimulator.Properties.Resources.email;
            this.pictureBoxEmail.Location = new System.Drawing.Point(322, 121);
            this.pictureBoxEmail.Name = "pictureBoxEmail";
            this.pictureBoxEmail.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmail.TabIndex = 13;
            this.pictureBoxEmail.TabStop = false;
            this.pictureBoxEmail.Click += new System.EventHandler(this.pictureBoxEmail_Click);
            // 
            // pictureBoxTg
            // 
            this.pictureBoxTg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTg.Image = global::EnigmaSimulator.Properties.Resources.telegram_app;
            this.pictureBoxTg.Location = new System.Drawing.Point(322, 152);
            this.pictureBoxTg.Name = "pictureBoxTg";
            this.pictureBoxTg.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxTg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTg.TabIndex = 14;
            this.pictureBoxTg.TabStop = false;
            this.pictureBoxTg.Click += new System.EventHandler(this.pictureBoxTg_Click);
            // 
            // pictureBoxVK
            // 
            this.pictureBoxVK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVK.Image = global::EnigmaSimulator.Properties.Resources.vk_com;
            this.pictureBoxVK.Location = new System.Drawing.Point(322, 184);
            this.pictureBoxVK.Name = "pictureBoxVK";
            this.pictureBoxVK.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxVK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVK.TabIndex = 15;
            this.pictureBoxVK.TabStop = false;
            this.pictureBoxVK.Click += new System.EventHandler(this.pictureBoxVK_Click);
            // 
            // CopyrightView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 219);
            this.Controls.Add(this.pictureBoxVK);
            this.Controls.Add(this.pictureBoxTg);
            this.Controls.Add(this.pictureBoxEmail);
            this.Controls.Add(this.labelVK);
            this.Controls.Add(this.labelTelegram);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTitle);
            this.Name = "CopyrightView";
            this.Text = "Copyright";
            this.Load += new System.EventHandler(this.CopyrightView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelVK;
        private System.Windows.Forms.Label labelTelegram;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxEmail;
        private System.Windows.Forms.PictureBox pictureBoxTg;
        private System.Windows.Forms.PictureBox pictureBoxVK;
    }
}