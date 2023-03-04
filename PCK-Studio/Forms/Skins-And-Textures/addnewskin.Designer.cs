namespace PckStudio
{
    partial class addNewSkin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addNewSkin));
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.textTheme = new System.Windows.Forms.TextBox();
            this.contextMenuSkin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCape = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.replaceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonModelGen = new System.Windows.Forms.Button();
            this.buttonCape = new System.Windows.Forms.Button();
            this.buttonSkin = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.PictureBox();
            this.radioAUTO = new System.Windows.Forms.RadioButton();
            this.radioLOCAL = new System.Windows.Forms.RadioButton();
            this.labelSelectTexture = new System.Windows.Forms.Label();
            this.radioSERVER = new System.Windows.Forms.RadioButton();
            this.textSkinID = new MetroFramework.Controls.MetroTextBox();
            this.textSkinName = new MetroFramework.Controls.MetroTextBox();
            this.textThemeName = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAnimGen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.closeskincreator = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.capePictureBox = new PckStudio.PictureBoxWithInterpolationMode();
            this.skinPictureBoxTexture = new PckStudio.PictureBoxWithInterpolationMode();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.contextMenuSkin.SuspendLayout();
            this.contextMenuCape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBoxTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = System.Drawing.Color.White;
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = System.Drawing.Color.White;
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = System.Drawing.Color.White;
            label1.Name = "label1";
            // 
            // textTheme
            // 
            resources.ApplyResources(this.textTheme, "textTheme");
            this.textTheme.Name = "textTheme";
            // 
            // contextMenuSkin
            // 
            this.contextMenuSkin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replaceToolStripMenuItem});
            this.contextMenuSkin.Name = "contextMenuSkin";
            resources.ApplyResources(this.contextMenuSkin, "contextMenuSkin");
            // 
            // replaceToolStripMenuItem
            // 
            resources.ApplyResources(this.replaceToolStripMenuItem, "replaceToolStripMenuItem");
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // contextMenuCape
            // 
            this.contextMenuCape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replaceToolStripMenuItem1});
            this.contextMenuCape.Name = "contextMenuCape";
            resources.ApplyResources(this.contextMenuCape, "contextMenuCape");
            // 
            // replaceToolStripMenuItem1
            // 
            resources.ApplyResources(this.replaceToolStripMenuItem1, "replaceToolStripMenuItem1");
            this.replaceToolStripMenuItem1.Name = "replaceToolStripMenuItem1";
            this.replaceToolStripMenuItem1.Click += new System.EventHandler(this.replaceToolStripMenuItem1_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            resources.ApplyResources(this.buttonDone, "buttonDone");
            this.buttonDone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonDone.FlatAppearance.BorderSize = 2;
            this.buttonDone.ForeColor = System.Drawing.Color.White;
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // buttonModelGen
            // 
            this.buttonModelGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonModelGen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonModelGen.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.buttonModelGen, "buttonModelGen");
            this.buttonModelGen.ForeColor = System.Drawing.Color.White;
            this.buttonModelGen.Name = "buttonModelGen";
            this.buttonModelGen.UseVisualStyleBackColor = false;
            this.buttonModelGen.Click += new System.EventHandler(this.CreateCustomModel_Click);
            // 
            // buttonCape
            // 
            resources.ApplyResources(this.buttonCape, "buttonCape");
            this.buttonCape.Name = "buttonCape";
            this.buttonCape.UseVisualStyleBackColor = true;
            this.buttonCape.Click += new System.EventHandler(this.buttonCape_Click);
            // 
            // buttonSkin
            // 
            resources.ApplyResources(this.buttonSkin, "buttonSkin");
            this.buttonSkin.Name = "buttonSkin";
            this.buttonSkin.UseVisualStyleBackColor = true;
            this.buttonSkin.Click += new System.EventHandler(this.buttonSkin_Click);
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.displayBox.BackgroundImage = global::PckStudio.Properties.Resources.skincreator_model_view;
            resources.ApplyResources(this.displayBox, "displayBox");
            this.displayBox.Name = "displayBox";
            this.displayBox.TabStop = false;
            // 
            // radioAUTO
            // 
            resources.ApplyResources(this.radioAUTO, "radioAUTO");
            this.radioAUTO.ForeColor = System.Drawing.Color.White;
            this.radioAUTO.Name = "radioAUTO";
            this.radioAUTO.UseVisualStyleBackColor = true;
            this.radioAUTO.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioLOCAL
            // 
            resources.ApplyResources(this.radioLOCAL, "radioLOCAL");
            this.radioLOCAL.Checked = true;
            this.radioLOCAL.ForeColor = System.Drawing.Color.White;
            this.radioLOCAL.Name = "radioLOCAL";
            this.radioLOCAL.TabStop = true;
            this.radioLOCAL.UseVisualStyleBackColor = true;
            this.radioLOCAL.CheckedChanged += new System.EventHandler(this.radioLOCAL_CheckedChanged);
            // 
            // labelSelectTexture
            // 
            resources.ApplyResources(this.labelSelectTexture, "labelSelectTexture");
            this.labelSelectTexture.ForeColor = System.Drawing.Color.White;
            this.labelSelectTexture.Name = "labelSelectTexture";
            this.labelSelectTexture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioSERVER
            // 
            resources.ApplyResources(this.radioSERVER, "radioSERVER");
            this.radioSERVER.ForeColor = System.Drawing.Color.White;
            this.radioSERVER.Name = "radioSERVER";
            this.radioSERVER.UseVisualStyleBackColor = true;
            this.radioSERVER.CheckedChanged += new System.EventHandler(this.radioSERVER_CheckedChanged);
            // 
            // textSkinID
            // 
            // 
            // 
            // 
            this.textSkinID.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.textSkinID.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.textSkinID.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.textSkinID.CustomButton.Name = "";
            this.textSkinID.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.textSkinID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textSkinID.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.textSkinID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textSkinID.CustomButton.UseSelectable = true;
            this.textSkinID.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.textSkinID.ForeColor = System.Drawing.Color.White;
            this.textSkinID.Lines = new string[0];
            resources.ApplyResources(this.textSkinID, "textSkinID");
            this.textSkinID.MaxLength = 32767;
            this.textSkinID.Name = "textSkinID";
            this.textSkinID.PasswordChar = '\0';
            this.textSkinID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textSkinID.SelectedText = "";
            this.textSkinID.SelectionLength = 0;
            this.textSkinID.SelectionStart = 0;
            this.textSkinID.ShortcutsEnabled = true;
            this.textSkinID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textSkinID.UseSelectable = true;
            this.textSkinID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textSkinID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textSkinID.TextChanged += new System.EventHandler(this.textSkinID_TextChanged);
            // 
            // textSkinName
            // 
            // 
            // 
            // 
            this.textSkinName.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.textSkinName.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.textSkinName.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.textSkinName.CustomButton.Name = "";
            this.textSkinName.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.textSkinName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textSkinName.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.textSkinName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textSkinName.CustomButton.UseSelectable = true;
            this.textSkinName.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.textSkinName.ForeColor = System.Drawing.Color.White;
            this.textSkinName.Lines = new string[0];
            resources.ApplyResources(this.textSkinName, "textSkinName");
            this.textSkinName.MaxLength = 32767;
            this.textSkinName.Name = "textSkinName";
            this.textSkinName.PasswordChar = '\0';
            this.textSkinName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textSkinName.SelectedText = "";
            this.textSkinName.SelectionLength = 0;
            this.textSkinName.SelectionStart = 0;
            this.textSkinName.ShortcutsEnabled = true;
            this.textSkinName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textSkinName.UseSelectable = true;
            this.textSkinName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textSkinName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textThemeName
            // 
            // 
            // 
            // 
            this.textThemeName.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.textThemeName.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.textThemeName.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.textThemeName.CustomButton.Name = "";
            this.textThemeName.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.textThemeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textThemeName.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.textThemeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textThemeName.CustomButton.UseSelectable = true;
            this.textThemeName.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.textThemeName.ForeColor = System.Drawing.Color.White;
            this.textThemeName.Lines = new string[0];
            resources.ApplyResources(this.textThemeName, "textThemeName");
            this.textThemeName.MaxLength = 32767;
            this.textThemeName.Name = "textThemeName";
            this.textThemeName.PasswordChar = '\0';
            this.textThemeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textThemeName.SelectedText = "";
            this.textThemeName.SelectionLength = 0;
            this.textThemeName.SelectionStart = 0;
            this.textThemeName.ShortcutsEnabled = true;
            this.textThemeName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textThemeName.UseSelectable = true;
            this.textThemeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textThemeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.replaceToolStripMenuItem1_Click);
            // 
            // buttonAnimGen
            // 
            this.buttonAnimGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonAnimGen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonAnimGen.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.buttonAnimGen, "buttonAnimGen");
            this.buttonAnimGen.ForeColor = System.Drawing.Color.White;
            this.buttonAnimGen.Name = "buttonAnimGen";
            this.buttonAnimGen.UseVisualStyleBackColor = false;
            this.buttonAnimGen.Click += new System.EventHandler(this.buttonAnimGen_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.closeskincreator);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp_1);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackgroundImage = global::PckStudio.Properties.Resources.Minimize;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // closeskincreator
            // 
            resources.ApplyResources(this.closeskincreator, "closeskincreator");
            this.closeskincreator.BackgroundImage = global::PckStudio.Properties.Resources.Close;
            this.closeskincreator.FlatAppearance.BorderSize = 0;
            this.closeskincreator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.closeskincreator.Name = "closeskincreator";
            this.closeskincreator.UseVisualStyleBackColor = true;
            this.closeskincreator.Click += new System.EventHandler(this.closeskincreator_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Name = "label5";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            this.label5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp_1);
            // 
            // capePictureBox
            // 
            resources.ApplyResources(this.capePictureBox, "capePictureBox");
            this.capePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.capePictureBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
            this.capePictureBox.Name = "capePictureBox";
            this.capePictureBox.TabStop = false;
            this.capePictureBox.Click += new System.EventHandler(this.replaceToolStripMenuItem1_Click);
            // 
            // skinPictureBoxTexture
            // 
            resources.ApplyResources(this.skinPictureBoxTexture, "skinPictureBoxTexture");
            this.skinPictureBoxTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinPictureBoxTexture.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
            this.skinPictureBoxTexture.Name = "skinPictureBoxTexture";
            this.skinPictureBoxTexture.TabStop = false;
            this.skinPictureBoxTexture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PckStudio.Properties.Resources.melon_Foxx_logo11;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // addNewSkin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAnimGen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textThemeName);
            this.Controls.Add(this.textSkinName);
            this.Controls.Add(this.textSkinID);
            this.Controls.Add(this.radioSERVER);
            this.Controls.Add(this.labelSelectTexture);
            this.Controls.Add(this.radioLOCAL);
            this.Controls.Add(this.radioAUTO);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonModelGen);
            this.Controls.Add(this.buttonCape);
            this.Controls.Add(this.buttonSkin);
            this.Controls.Add(this.capePictureBox);
            this.Controls.Add(this.skinPictureBoxTexture);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "addNewSkin";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.addnewskin_Load);
            this.contextMenuSkin.ResumeLayout(false);
            this.contextMenuCape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBoxTexture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textTheme;
        private System.Windows.Forms.ContextMenuStrip contextMenuSkin;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuCape;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem1;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonModelGen;
        private System.Windows.Forms.Button buttonCape;
        private System.Windows.Forms.Button buttonSkin;
        private PictureBoxWithInterpolationMode capePictureBox;
        private System.Windows.Forms.PictureBox displayBox;
        private System.Windows.Forms.RadioButton radioAUTO;
        private System.Windows.Forms.RadioButton radioLOCAL;
        private System.Windows.Forms.Label labelSelectTexture;
        private System.Windows.Forms.RadioButton radioSERVER;
		private MetroFramework.Controls.MetroTextBox textSkinID;
		private MetroFramework.Controls.MetroTextBox textSkinName;
		private MetroFramework.Controls.MetroTextBox textThemeName;
		private System.Windows.Forms.Label label4;
		private PictureBoxWithInterpolationMode skinPictureBoxTexture;
		private System.Windows.Forms.Button buttonAnimGen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button closeskincreator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}