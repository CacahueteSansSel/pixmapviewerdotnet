namespace Nightek.PBM
{
    partial class ImportImageDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportImageDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.ImagePathBox = new DarkUI.Controls.DarkTextBox();
            this.ChangePathBtn = new DarkUI.Controls.DarkButton();
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FormatBox = new DarkUI.Controls.DarkComboBox();
            this.ImportButton = new DarkUI.Controls.DarkButton();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Import an image";
            // 
            // ImagePathBox
            // 
            this.ImagePathBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.ImagePathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePathBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagePathBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ImagePathBox.Location = new System.Drawing.Point(16, 55);
            this.ImagePathBox.Name = "ImagePathBox";
            this.ImagePathBox.ReadOnly = true;
            this.ImagePathBox.Size = new System.Drawing.Size(243, 23);
            this.ImagePathBox.TabIndex = 3;
            // 
            // ChangePathBtn
            // 
            this.ChangePathBtn.Location = new System.Drawing.Point(265, 55);
            this.ChangePathBtn.Name = "ChangePathBtn";
            this.ChangePathBtn.Padding = new System.Windows.Forms.Padding(5);
            this.ChangePathBtn.Size = new System.Drawing.Size(87, 23);
            this.ChangePathBtn.TabIndex = 4;
            this.ChangePathBtn.Text = "Change";
            this.ChangePathBtn.Click += new System.EventHandler(this.ChangePathBtn_Click);
            // 
            // PreviewBox
            // 
            this.PreviewBox.BackColor = System.Drawing.Color.Black;
            this.PreviewBox.Location = new System.Drawing.Point(367, 24);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(295, 255);
            this.PreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviewBox.TabIndex = 5;
            this.PreviewBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(364, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Preview";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pixmap Format";
            // 
            // FormatBox
            // 
            this.FormatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.FormatBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.FormatBox.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.FormatBox.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.FormatBox.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("FormatBox.ButtonIcon")));
            this.FormatBox.DrawDropdownHoverOutline = false;
            this.FormatBox.DrawFocusRectangle = false;
            this.FormatBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.FormatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormatBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormatBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormatBox.FormattingEnabled = true;
            this.FormatBox.Location = new System.Drawing.Point(16, 113);
            this.FormatBox.Name = "FormatBox";
            this.FormatBox.Size = new System.Drawing.Size(127, 21);
            this.FormatBox.TabIndex = 9;
            this.FormatBox.Text = "P3";
            this.FormatBox.TextPadding = new System.Windows.Forms.Padding(2);
            this.FormatBox.SelectedIndexChanged += new System.EventHandler(this.FormatBox_SelectedIndexChanged);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(16, 242);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Padding = new System.Windows.Forms.Padding(5);
            this.ImportButton.Size = new System.Drawing.Size(118, 37);
            this.ImportButton.TabIndex = 10;
            this.ImportButton.Text = "Import";
            this.ImportButton.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // ImportImageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(674, 302);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.FormatBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PreviewBox);
            this.Controls.Add(this.ChangePathBtn);
            this.Controls.Add(this.ImagePathBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportImageDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import an image";
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DarkUI.Controls.DarkTextBox ImagePathBox;
        private DarkUI.Controls.DarkButton ChangePathBtn;
        private System.Windows.Forms.PictureBox PreviewBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DarkUI.Controls.DarkComboBox FormatBox;
        private DarkUI.Controls.DarkButton ImportButton;
    }
}