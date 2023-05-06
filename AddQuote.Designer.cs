namespace Mega_Desk_Kamisaki
{
    partial class AddQuote
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
            this.deskLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthValue = new System.Windows.Forms.NumericUpDown();
            this.depthValue = new System.Windows.Forms.NumericUpDown();
            this.drawerLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.drawerValue = new System.Windows.Forms.NumericUpDown();
            this.materialList = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.newQuoteLabel = new System.Windows.Forms.Label();
            this.getQuoteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.widthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerValue)).BeginInit();
            this.SuspendLayout();
            // 
            // deskLabel
            // 
            this.deskLabel.AutoSize = true;
            this.deskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskLabel.Location = new System.Drawing.Point(328, 162);
            this.deskLabel.Name = "deskLabel";
            this.deskLabel.Size = new System.Drawing.Size(68, 29);
            this.deskLabel.TabIndex = 0;
            this.deskLabel.Text = "Desk";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(23, 215);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(125, 22);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width (inches)";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(23, 259);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(127, 22);
            this.depthLabel.TabIndex = 2;
            this.depthLabel.Text = "Depth (inches)";
            // 
            // widthValue
            // 
            this.widthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthValue.Location = new System.Drawing.Point(206, 210);
            this.widthValue.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthValue.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthValue.Name = "widthValue";
            this.widthValue.Size = new System.Drawing.Size(120, 27);
            this.widthValue.TabIndex = 3;
            this.widthValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthValue.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // depthValue
            // 
            this.depthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthValue.Location = new System.Drawing.Point(206, 254);
            this.depthValue.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthValue.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthValue.Name = "depthValue";
            this.depthValue.Size = new System.Drawing.Size(120, 27);
            this.depthValue.TabIndex = 4;
            this.depthValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.depthValue.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // drawerLabel
            // 
            this.drawerLabel.AutoSize = true;
            this.drawerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerLabel.Location = new System.Drawing.Point(23, 302);
            this.drawerLabel.Name = "drawerLabel";
            this.drawerLabel.Size = new System.Drawing.Size(162, 22);
            this.drawerLabel.TabIndex = 5;
            this.drawerLabel.Text = "Number of drawers";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(412, 213);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(140, 22);
            this.materialLabel.TabIndex = 6;
            this.materialLabel.Text = "Surface material";
            // 
            // drawerValue
            // 
            this.drawerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerValue.Location = new System.Drawing.Point(206, 297);
            this.drawerValue.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerValue.Name = "drawerValue";
            this.drawerValue.Size = new System.Drawing.Size(120, 27);
            this.drawerValue.TabIndex = 7;
            this.drawerValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // materialList
            // 
            this.materialList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialList.FormattingEnabled = true;
            this.materialList.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.materialList.Location = new System.Drawing.Point(558, 210);
            this.materialList.Name = "materialList";
            this.materialList.Size = new System.Drawing.Size(168, 30);
            this.materialList.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(72, 109);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(190, 25);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Customer Full Name";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.Location = new System.Drawing.Point(415, 259);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(99, 22);
            this.orderLabel.TabIndex = 11;
            this.orderLabel.Text = "Rush order";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3 days",
            "5 days",
            "7 days",
            "14 days (Normal)"});
            this.comboBox1.Location = new System.Drawing.Point(558, 256);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 30);
            this.comboBox1.TabIndex = 12;
            // 
            // newQuoteLabel
            // 
            this.newQuoteLabel.AutoSize = true;
            this.newQuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuoteLabel.Location = new System.Drawing.Point(297, 32);
            this.newQuoteLabel.Name = "newQuoteLabel";
            this.newQuoteLabel.Size = new System.Drawing.Size(163, 36);
            this.newQuoteLabel.TabIndex = 13;
            this.newQuoteLabel.Text = "New Quote";
            // 
            // getQuoteButton
            // 
            this.getQuoteButton.BackColor = System.Drawing.Color.Lime;
            this.getQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getQuoteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getQuoteButton.Location = new System.Drawing.Point(232, 357);
            this.getQuoteButton.Name = "getQuoteButton";
            this.getQuoteButton.Size = new System.Drawing.Size(130, 40);
            this.getQuoteButton.TabIndex = 14;
            this.getQuoteButton.Text = "Get Quote";
            this.getQuoteButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(405, 357);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(130, 40);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(268, 109);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(363, 28);
            this.nameText.TabIndex = 16;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(747, 437);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.getQuoteButton);
            this.Controls.Add(this.newQuoteLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.materialList);
            this.Controls.Add(this.drawerValue);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.drawerLabel);
            this.Controls.Add(this.depthValue);
            this.Controls.Add(this.widthValue);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.deskLabel);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.widthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deskLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.NumericUpDown widthValue;
        private System.Windows.Forms.NumericUpDown depthValue;
        private System.Windows.Forms.Label drawerLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.NumericUpDown drawerValue;
        private System.Windows.Forms.ComboBox materialList;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label newQuoteLabel;
        private System.Windows.Forms.Button getQuoteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameText;
    }
}