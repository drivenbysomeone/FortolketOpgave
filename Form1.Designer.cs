namespace FortolketOpgave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGetData = new System.Windows.Forms.Button();
            this.listOS = new System.Windows.Forms.ListBox();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.lblUserAddInfo = new System.Windows.Forms.Label();
            this.rdbOS = new System.Windows.Forms.RadioButton();
            this.rdbBrowsers = new System.Windows.Forms.RadioButton();
            this.rdbPrograms = new System.Windows.Forms.RadioButton();
            this.rdbConnectionConfig = new System.Windows.Forms.RadioButton();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.listPrograms = new System.Windows.Forms.ListBox();
            this.listConnectionConfig = new System.Windows.Forms.ListBox();
            this.listBrowsers = new System.Windows.Forms.ListBox();
            this.lblOsInfo = new System.Windows.Forms.Label();
            this.lblBrowsersInfo = new System.Windows.Forms.Label();
            this.lblProgramsInfo = new System.Windows.Forms.Label();
            this.lblConfigInfo = new System.Windows.Forms.Label();
            this.cmbBoxPlatforms = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tk = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(443, 599);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(98, 23);
            this.btnGetData.TabIndex = 0;
            this.btnGetData.Text = "Generer opgave";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // listOS
            // 
            this.listOS.FormattingEnabled = true;
            this.listOS.Location = new System.Drawing.Point(12, 37);
            this.listOS.Name = "listOS";
            this.listOS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listOS.ScrollAlwaysVisible = true;
            this.listOS.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listOS.Size = new System.Drawing.Size(227, 134);
            this.listOS.TabIndex = 1;
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(307, 207);
            this.txtBoxInput.Multiline = true;
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxInput.Size = new System.Drawing.Size(372, 46);
            this.txtBoxInput.TabIndex = 5;
            // 
            // lblUserAddInfo
            // 
            this.lblUserAddInfo.Location = new System.Drawing.Point(304, 163);
            this.lblUserAddInfo.Name = "lblUserAddInfo";
            this.lblUserAddInfo.Size = new System.Drawing.Size(292, 41);
            this.lblUserAddInfo.TabIndex = 6;
            this.lblUserAddInfo.Text = "*Hvis en ny værdi ønskes - indtast en ny værdi der matcher én af de fire nedenstå" +
    "ende katagorier.\r\n     Vælg dernæst den matchende katagori i katagorier.\r\n";
            // 
            // rdbOS
            // 
            this.rdbOS.AutoSize = true;
            this.rdbOS.Location = new System.Drawing.Point(16, 27);
            this.rdbOS.Name = "rdbOS";
            this.rdbOS.Size = new System.Drawing.Size(118, 20);
            this.rdbOS.TabIndex = 7;
            this.rdbOS.TabStop = true;
            this.rdbOS.Text = "operativsystem";
            this.rdbOS.UseVisualStyleBackColor = true;
            // 
            // rdbBrowsers
            // 
            this.rdbBrowsers.AutoSize = true;
            this.rdbBrowsers.Location = new System.Drawing.Point(148, 27);
            this.rdbBrowsers.Name = "rdbBrowsers";
            this.rdbBrowsers.Size = new System.Drawing.Size(74, 20);
            this.rdbBrowsers.TabIndex = 8;
            this.rdbBrowsers.TabStop = true;
            this.rdbBrowsers.Text = "browser";
            this.rdbBrowsers.UseVisualStyleBackColor = true;
            // 
            // rdbPrograms
            // 
            this.rdbPrograms.AutoSize = true;
            this.rdbPrograms.Location = new System.Drawing.Point(16, 73);
            this.rdbPrograms.Name = "rdbPrograms";
            this.rdbPrograms.Size = new System.Drawing.Size(77, 20);
            this.rdbPrograms.TabIndex = 9;
            this.rdbPrograms.TabStop = true;
            this.rdbPrograms.Text = "program";
            this.rdbPrograms.UseVisualStyleBackColor = true;
            // 
            // rdbConnectionConfig
            // 
            this.rdbConnectionConfig.AutoSize = true;
            this.rdbConnectionConfig.Location = new System.Drawing.Point(148, 73);
            this.rdbConnectionConfig.Name = "rdbConnectionConfig";
            this.rdbConnectionConfig.Size = new System.Drawing.Size(90, 20);
            this.rdbConnectionConfig.TabIndex = 10;
            this.rdbConnectionConfig.TabStop = true;
            this.rdbConnectionConfig.Text = "opsætning";
            this.rdbConnectionConfig.UseVisualStyleBackColor = true;
            // 
            // btnAddValue
            // 
            this.btnAddValue.Location = new System.Drawing.Point(307, 599);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(85, 27);
            this.btnAddValue.TabIndex = 11;
            this.btnAddValue.Text = "Tilføj";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddValue_Click);
            // 
            // listPrograms
            // 
            this.listPrograms.FormattingEnabled = true;
            this.listPrograms.Location = new System.Drawing.Point(16, 492);
            this.listPrograms.Name = "listPrograms";
            this.listPrograms.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listPrograms.ScrollAlwaysVisible = true;
            this.listPrograms.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listPrograms.Size = new System.Drawing.Size(223, 134);
            this.listPrograms.TabIndex = 12;
            // 
            // listConnectionConfig
            // 
            this.listConnectionConfig.FormattingEnabled = true;
            this.listConnectionConfig.HorizontalScrollbar = true;
            this.listConnectionConfig.Location = new System.Drawing.Point(307, 37);
            this.listConnectionConfig.Name = "listConnectionConfig";
            this.listConnectionConfig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listConnectionConfig.ScrollAlwaysVisible = true;
            this.listConnectionConfig.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listConnectionConfig.Size = new System.Drawing.Size(372, 108);
            this.listConnectionConfig.TabIndex = 13;
            // 
            // listBrowsers
            // 
            this.listBrowsers.FormattingEnabled = true;
            this.listBrowsers.Location = new System.Drawing.Point(12, 266);
            this.listBrowsers.Name = "listBrowsers";
            this.listBrowsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBrowsers.ScrollAlwaysVisible = true;
            this.listBrowsers.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBrowsers.Size = new System.Drawing.Size(227, 147);
            this.listBrowsers.TabIndex = 14;
            // 
            // lblOsInfo
            // 
            this.lblOsInfo.AutoSize = true;
            this.lblOsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOsInfo.Location = new System.Drawing.Point(12, 18);
            this.lblOsInfo.Name = "lblOsInfo";
            this.lblOsInfo.Size = new System.Drawing.Size(117, 16);
            this.lblOsInfo.TabIndex = 15;
            this.lblOsInfo.Text = "Operativsystemer:";
            // 
            // lblBrowsersInfo
            // 
            this.lblBrowsersInfo.AutoSize = true;
            this.lblBrowsersInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowsersInfo.Location = new System.Drawing.Point(13, 247);
            this.lblBrowsersInfo.Name = "lblBrowsersInfo";
            this.lblBrowsersInfo.Size = new System.Drawing.Size(68, 16);
            this.lblBrowsersInfo.TabIndex = 16;
            this.lblBrowsersInfo.Text = "Browsere:";
            // 
            // lblProgramsInfo
            // 
            this.lblProgramsInfo.AutoSize = true;
            this.lblProgramsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramsInfo.Location = new System.Drawing.Point(13, 473);
            this.lblProgramsInfo.Name = "lblProgramsInfo";
            this.lblProgramsInfo.Size = new System.Drawing.Size(86, 16);
            this.lblProgramsInfo.TabIndex = 17;
            this.lblProgramsInfo.Text = "Programmer:";
            // 
            // lblConfigInfo
            // 
            this.lblConfigInfo.AutoSize = true;
            this.lblConfigInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigInfo.Location = new System.Drawing.Point(304, 18);
            this.lblConfigInfo.Name = "lblConfigInfo";
            this.lblConfigInfo.Size = new System.Drawing.Size(151, 16);
            this.lblConfigInfo.TabIndex = 18;
            this.lblConfigInfo.Text = "Opsætningsmuligheder:";
            // 
            // cmbBoxPlatforms
            // 
            this.cmbBoxPlatforms.FormattingEnabled = true;
            this.cmbBoxPlatforms.Location = new System.Drawing.Point(307, 444);
            this.cmbBoxPlatforms.Name = "cmbBoxPlatforms";
            this.cmbBoxPlatforms.Size = new System.Drawing.Size(136, 21);
            this.cmbBoxPlatforms.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPrograms);
            this.groupBox1.Controls.Add(this.rdbOS);
            this.groupBox1.Controls.Add(this.rdbBrowsers);
            this.groupBox1.Controls.Add(this.rdbConnectionConfig);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(307, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 106);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategorier:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(304, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 156);
            this.label1.TabIndex = 21;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(579, 564);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tk});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tk
            // 
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(125, 20);
            this.tk.Text = "toolStripMenuItem1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 655);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbBoxPlatforms);
            this.Controls.Add(this.lblConfigInfo);
            this.Controls.Add(this.lblProgramsInfo);
            this.Controls.Add(this.lblBrowsersInfo);
            this.Controls.Add(this.lblOsInfo);
            this.Controls.Add(this.listBrowsers);
            this.Controls.Add(this.listConnectionConfig);
            this.Controls.Add(this.listPrograms);
            this.Controls.Add(this.btnAddValue);
            this.Controls.Add(this.lblUserAddInfo);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.listOS);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Computeropsætning";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.ListBox listOS;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Label lblUserAddInfo;
        private System.Windows.Forms.RadioButton rdbOS;
        private System.Windows.Forms.RadioButton rdbBrowsers;
        private System.Windows.Forms.RadioButton rdbPrograms;
        private System.Windows.Forms.RadioButton rdbConnectionConfig;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.ListBox listPrograms;
        private System.Windows.Forms.ListBox listConnectionConfig;
        private System.Windows.Forms.ListBox listBrowsers;
        private System.Windows.Forms.Label lblOsInfo;
        private System.Windows.Forms.Label lblBrowsersInfo;
        private System.Windows.Forms.Label lblProgramsInfo;
        private System.Windows.Forms.Label lblConfigInfo;
        private System.Windows.Forms.ComboBox cmbBoxPlatforms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tk;
    }
}

