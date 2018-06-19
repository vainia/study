namespace ImageWithSecretForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureHide = new System.Windows.Forms.PictureBox();
            this.hideModeSwitcher = new System.Windows.Forms.Button();
            this.hideModeLabel = new System.Windows.Forms.Label();
            this.textToHide = new System.Windows.Forms.TextBox();
            this.pictureHider = new System.Windows.Forms.PictureBox();
            this.pictureHidden = new System.Windows.Forms.PictureBox();
            this.labelHidden = new System.Windows.Forms.Label();
            this.listOfCompressions = new System.Windows.Forms.CheckedListBox();
            this.labelSettings = new System.Windows.Forms.Label();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.labelCompression = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listOfEncryptions = new System.Windows.Forms.CheckedListBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpenDialogHider = new System.Windows.Forms.Button();
            this.labelDropHider = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonReload = new System.Windows.Forms.Button();
            this.labelDropHide = new System.Windows.Forms.Label();
            this.buttonOpenDialogHide = new System.Windows.Forms.Button();
            this.labelHider = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textKey = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.checkInteractive = new System.Windows.Forms.CheckBox();
            this.checkBoxTips = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHidden)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureHide
            // 
            this.pictureHide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureHide.Location = new System.Drawing.Point(10, 50);
            this.pictureHide.Name = "pictureHide";
            this.pictureHide.Size = new System.Drawing.Size(445, 288);
            this.pictureHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHide.TabIndex = 0;
            this.pictureHide.TabStop = false;
            this.pictureHide.Visible = false;
            // 
            // hideModeSwitcher
            // 
            this.hideModeSwitcher.BackColor = System.Drawing.Color.Transparent;
            this.hideModeSwitcher.Location = new System.Drawing.Point(121, 6);
            this.hideModeSwitcher.Margin = new System.Windows.Forms.Padding(0);
            this.hideModeSwitcher.Name = "hideModeSwitcher";
            this.hideModeSwitcher.Size = new System.Drawing.Size(333, 38);
            this.hideModeSwitcher.TabIndex = 1;
            this.hideModeSwitcher.Text = "Text";
            this.hideModeSwitcher.UseVisualStyleBackColor = false;
            this.hideModeSwitcher.Click += new System.EventHandler(this.HideModeSwitcher_Click);
            // 
            // hideModeLabel
            // 
            this.hideModeLabel.AutoSize = true;
            this.hideModeLabel.Location = new System.Drawing.Point(10, 20);
            this.hideModeLabel.Name = "hideModeLabel";
            this.hideModeLabel.Size = new System.Drawing.Size(112, 25);
            this.hideModeLabel.TabIndex = 2;
            this.hideModeLabel.Text = "Hide mode:";
            // 
            // textToHide
            // 
            this.textToHide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textToHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textToHide.Location = new System.Drawing.Point(9, 50);
            this.textToHide.Multiline = true;
            this.textToHide.Name = "textToHide";
            this.textToHide.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textToHide.Size = new System.Drawing.Size(443, 287);
            this.textToHide.TabIndex = 3;
            // 
            // pictureHider
            // 
            this.pictureHider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureHider.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureHider.Location = new System.Drawing.Point(10, 375);
            this.pictureHider.Name = "pictureHider";
            this.pictureHider.Size = new System.Drawing.Size(445, 289);
            this.pictureHider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHider.TabIndex = 4;
            this.pictureHider.TabStop = false;
            // 
            // pictureHidden
            // 
            this.pictureHidden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureHidden.BackColor = System.Drawing.Color.Transparent;
            this.pictureHidden.Location = new System.Drawing.Point(461, 50);
            this.pictureHidden.Name = "pictureHidden";
            this.pictureHidden.Size = new System.Drawing.Size(569, 458);
            this.pictureHidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHidden.TabIndex = 6;
            this.pictureHidden.TabStop = false;
            // 
            // labelHidden
            // 
            this.labelHidden.AutoSize = true;
            this.labelHidden.Location = new System.Drawing.Point(461, 18);
            this.labelHidden.Name = "labelHidden";
            this.labelHidden.Size = new System.Drawing.Size(138, 25);
            this.labelHidden.TabIndex = 7;
            this.labelHidden.Text = "Hidden image:";
            this.labelHidden.Visible = false;
            // 
            // listOfCompressions
            // 
            this.listOfCompressions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfCompressions.FormattingEnabled = true;
            this.listOfCompressions.Location = new System.Drawing.Point(1036, 297);
            this.listOfCompressions.Name = "listOfCompressions";
            this.listOfCompressions.Size = new System.Drawing.Size(451, 172);
            this.listOfCompressions.TabIndex = 8;
            // 
            // labelSettings
            // 
            this.labelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSettings.AutoSize = true;
            this.labelSettings.Location = new System.Drawing.Point(1036, 20);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(89, 25);
            this.labelSettings.TabIndex = 9;
            this.labelSettings.Text = "Settings:";
            // 
            // panelDivider
            // 
            this.panelDivider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDivider.BackColor = System.Drawing.Color.SteelBlue;
            this.panelDivider.Location = new System.Drawing.Point(1036, 50);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(451, 10);
            this.panelDivider.TabIndex = 10;
            // 
            // labelCompression
            // 
            this.labelCompression.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCompression.AutoSize = true;
            this.labelCompression.Location = new System.Drawing.Point(1036, 268);
            this.labelCompression.Name = "labelCompression";
            this.labelCompression.Size = new System.Drawing.Size(144, 25);
            this.labelCompression.TabIndex = 9;
            this.labelCompression.Text = "• Compression:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1036, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "• Encryption:";
            // 
            // listOfEncryptions
            // 
            this.listOfEncryptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfEncryptions.FormattingEnabled = true;
            this.listOfEncryptions.Location = new System.Drawing.Point(1036, 94);
            this.listOfEncryptions.Name = "listOfEncryptions";
            this.listOfEncryptions.Size = new System.Drawing.Size(451, 148);
            this.listOfEncryptions.TabIndex = 8;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.buttonEncrypt.Enabled = false;
            this.buttonEncrypt.Location = new System.Drawing.Point(1036, 477);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(222, 71);
            this.buttonEncrypt.TabIndex = 11;
            this.buttonEncrypt.Text = "Hide";
            this.buttonEncrypt.UseVisualStyleBackColor = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.ButtonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.buttonDecrypt.Enabled = false;
            this.buttonDecrypt.Location = new System.Drawing.Point(1265, 477);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(222, 71);
            this.buttonDecrypt.TabIndex = 12;
            this.buttonDecrypt.Text = "Reveal";
            this.buttonDecrypt.UseVisualStyleBackColor = false;
            this.buttonDecrypt.Click += new System.EventHandler(this.ButtonDecrypt_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.Location = new System.Drawing.Point(1036, 555);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(451, 109);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonOpenDialogHider
            // 
            this.buttonOpenDialogHider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenDialogHider.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenDialogHider.Location = new System.Drawing.Point(32, 432);
            this.buttonOpenDialogHider.Name = "buttonOpenDialogHider";
            this.buttonOpenDialogHider.Size = new System.Drawing.Size(198, 174);
            this.buttonOpenDialogHider.TabIndex = 14;
            this.buttonOpenDialogHider.Text = "Choose image";
            this.buttonOpenDialogHider.UseVisualStyleBackColor = false;
            this.buttonOpenDialogHider.Click += new System.EventHandler(this.ButtonOpenDialog_Click);
            // 
            // labelDropHider
            // 
            this.labelDropHider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDropHider.AutoSize = true;
            this.labelDropHider.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelDropHider.Location = new System.Drawing.Point(236, 507);
            this.labelDropHider.Name = "labelDropHider";
            this.labelDropHider.Size = new System.Drawing.Size(199, 25);
            this.labelDropHider.TabIndex = 15;
            this.labelDropHider.Text = "or drag and drop here";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonReload
            // 
            this.buttonReload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReload.Location = new System.Drawing.Point(461, 555);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(569, 109);
            this.buttonReload.TabIndex = 16;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.ButtonReload_Click);
            // 
            // labelDropHide
            // 
            this.labelDropHide.AutoSize = true;
            this.labelDropHide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelDropHide.Location = new System.Drawing.Point(236, 180);
            this.labelDropHide.Name = "labelDropHide";
            this.labelDropHide.Size = new System.Drawing.Size(199, 25);
            this.labelDropHide.TabIndex = 15;
            this.labelDropHide.Text = "or drag and drop here";
            this.labelDropHide.Visible = false;
            // 
            // buttonOpenDialogHide
            // 
            this.buttonOpenDialogHide.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenDialogHide.Location = new System.Drawing.Point(32, 106);
            this.buttonOpenDialogHide.Name = "buttonOpenDialogHide";
            this.buttonOpenDialogHide.Size = new System.Drawing.Size(198, 174);
            this.buttonOpenDialogHide.TabIndex = 14;
            this.buttonOpenDialogHide.Text = "Choose image";
            this.buttonOpenDialogHide.UseVisualStyleBackColor = false;
            this.buttonOpenDialogHide.Visible = false;
            this.buttonOpenDialogHide.Click += new System.EventHandler(this.ButtonOpenDialog_Click);
            // 
            // labelHider
            // 
            this.labelHider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHider.AutoSize = true;
            this.labelHider.Location = new System.Drawing.Point(9, 344);
            this.labelHider.Name = "labelHider";
            this.labelHider.Size = new System.Drawing.Size(126, 25);
            this.labelHider.TabIndex = 17;
            this.labelHider.Text = "Picture hider:";
            // 
            // textKey
            // 
            this.textKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textKey.Location = new System.Drawing.Point(520, 514);
            this.textKey.Multiline = true;
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(322, 34);
            this.textKey.TabIndex = 18;
            this.textKey.TextChanged += new System.EventHandler(this.TextKey_TextChanged);
            // 
            // labelKey
            // 
            this.labelKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(461, 523);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(53, 25);
            this.labelKey.TabIndex = 19;
            this.labelKey.Text = "Key:";
            this.labelKey.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkInteractive
            // 
            this.checkInteractive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkInteractive.AutoSize = true;
            this.checkInteractive.Location = new System.Drawing.Point(848, 516);
            this.checkInteractive.Name = "checkInteractive";
            this.checkInteractive.Size = new System.Drawing.Size(182, 29);
            this.checkInteractive.TabIndex = 20;
            this.checkInteractive.Text = "Interactive Mode";
            this.checkInteractive.UseVisualStyleBackColor = true;
            // 
            // checkBoxTips
            // 
            this.checkBoxTips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTips.AutoSize = true;
            this.checkBoxTips.Checked = true;
            this.checkBoxTips.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTips.Location = new System.Drawing.Point(1411, 12);
            this.checkBoxTips.Name = "checkBoxTips";
            this.checkBoxTips.Size = new System.Drawing.Size(76, 29);
            this.checkBoxTips.TabIndex = 21;
            this.checkBoxTips.Text = "Tips";
            this.checkBoxTips.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1496, 671);
            this.Controls.Add(this.checkBoxTips);
            this.Controls.Add(this.checkInteractive);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.labelHider);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.labelDropHide);
            this.Controls.Add(this.labelDropHider);
            this.Controls.Add(this.buttonOpenDialogHide);
            this.Controls.Add(this.buttonOpenDialogHider);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.panelDivider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCompression);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.listOfEncryptions);
            this.Controls.Add(this.listOfCompressions);
            this.Controls.Add(this.labelHidden);
            this.Controls.Add(this.pictureHidden);
            this.Controls.Add(this.pictureHider);
            this.Controls.Add(this.textToHide);
            this.Controls.Add(this.hideModeLabel);
            this.Controls.Add(this.hideModeSwitcher);
            this.Controls.Add(this.pictureHide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1520, 735);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Image With Secret";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.MainForm_DragOver);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHidden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureHide;
        private System.Windows.Forms.Button hideModeSwitcher;
        private System.Windows.Forms.Label hideModeLabel;
        private System.Windows.Forms.TextBox textToHide;
        private System.Windows.Forms.PictureBox pictureHider;
        private System.Windows.Forms.PictureBox pictureHidden;
        private System.Windows.Forms.Label labelHidden;
        private System.Windows.Forms.CheckedListBox listOfCompressions;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Panel panelDivider;
        private System.Windows.Forms.Label labelCompression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox listOfEncryptions;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpenDialogHider;
        private System.Windows.Forms.Label labelDropHider;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Label labelDropHide;
        private System.Windows.Forms.Button buttonOpenDialogHide;
        private System.Windows.Forms.Label labelHider;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.CheckBox checkInteractive;
        private System.Windows.Forms.CheckBox checkBoxTips;
    }
}

