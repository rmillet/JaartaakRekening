namespace JaartaakRekening_Forms
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblRekeningstand = new System.Windows.Forms.Label();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "voeg verrichting toe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRekeningstand
            // 
            this.lblRekeningstand.AutoSize = true;
            this.lblRekeningstand.Location = new System.Drawing.Point(303, 20);
            this.lblRekeningstand.Name = "lblRekeningstand";
            this.lblRekeningstand.Size = new System.Drawing.Size(88, 13);
            this.lblRekeningstand.TabIndex = 1;
            this.lblRekeningstand.Text = "Rekeningstand : ";
            // 
            // lstInfo
            // 
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.Location = new System.Drawing.Point(21, 20);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(235, 147);
            this.lstInfo.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(308, 50);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 192);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lstInfo);
            this.Controls.Add(this.lblRekeningstand);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRekeningstand;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.Label lbl;
    }
}

