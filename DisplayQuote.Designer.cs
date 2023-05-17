namespace Mega_Desk_Kamisaki
{
    partial class DisplayQuote
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
            this.TextDisplay = new System.Windows.Forms.TextBox();
            this.btnmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextDisplay
            // 
            this.TextDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDisplay.Location = new System.Drawing.Point(33, 28);
            this.TextDisplay.Multiline = true;
            this.TextDisplay.Name = "TextDisplay";
            this.TextDisplay.Size = new System.Drawing.Size(723, 339);
            this.TextDisplay.TabIndex = 0;
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmenu.Location = new System.Drawing.Point(50, 390);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(122, 48);
            this.btnmenu.TabIndex = 2;
            this.btnmenu.Text = "Main Menu";
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.TextDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextDisplay;
        private System.Windows.Forms.Button btnmenu;
    }
}