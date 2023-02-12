namespace PckStudio.Forms.Utilities.Skins
{
	partial class ANIMEditor
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
            this.closeButton = new MetroFramework.Controls.MetroButton();
            this.copyButton = new MetroFramework.Controls.MetroButton();
            this.importButton = new MetroFramework.Controls.MetroButton();
            this.exportButton = new MetroFramework.Controls.MetroButton();
            this.animValue = new MetroFramework.Controls.MetroLabel();
            this.uncheckButton = new MetroFramework.Controls.MetroButton();
            this.checkButton = new MetroFramework.Controls.MetroButton();
            this.toolTip = new MetroFramework.Components.MetroToolTip();
            this.resetButton = new MetroFramework.Controls.MetroButton();
            this.templateButton = new MetroFramework.Controls.MetroButton();
            this.rightLegOCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.headOCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.leftLegOCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.leftArmOCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.bodyOCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.rightLegCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.slimCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.headCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.leftLegCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.rightArmCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.leftArmCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.bodyCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.classicCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.rightArmOCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.rightLeggingCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.helmetCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.leftLeggingCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.rightArmorCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.leftArmorCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.chestplateCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.unknownCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.crouchCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.dinnerboneCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.noArmorCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.bobbingCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.santaCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.syncLegsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.staticArmsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.syncArmsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.statueCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.zombieCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.staticLegsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(56, 358);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(126, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Save";
            this.closeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.closeButton.UseSelectable = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(23, 237);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(186, 23);
            this.copyButton.TabIndex = 22;
            this.copyButton.Text = "Copy ANIM Value";
            this.copyButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.copyButton.UseSelectable = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(23, 179);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(186, 23);
            this.importButton.TabIndex = 23;
            this.importButton.Text = "Import ANIM";
            this.importButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.importButton.UseSelectable = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(23, 150);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(186, 23);
            this.exportButton.TabIndex = 24;
            this.exportButton.Text = "Export Template Texture";
            this.exportButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.exportButton.UseSelectable = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // animValue
            // 
            this.animValue.AutoSize = true;
            this.animValue.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.animValue.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.animValue.Location = new System.Drawing.Point(63, 300);
            this.animValue.Name = "animValue";
            this.animValue.Size = new System.Drawing.Size(110, 25);
            this.animValue.TabIndex = 25;
            this.animValue.Text = "0x00000000";
            this.animValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.animValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // uncheckButton
            // 
            this.uncheckButton.Location = new System.Drawing.Point(23, 92);
            this.uncheckButton.Name = "uncheckButton";
            this.uncheckButton.Size = new System.Drawing.Size(186, 23);
            this.uncheckButton.TabIndex = 26;
            this.uncheckButton.Text = "Uncheck All";
            this.uncheckButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uncheckButton.UseSelectable = true;
            this.uncheckButton.Click += new System.EventHandler(this.uncheckButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.checkButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkButton.Location = new System.Drawing.Point(23, 63);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(186, 23);
            this.checkButton.TabIndex = 27;
            this.checkButton.Text = "Check All";
            this.checkButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkButton.UseSelectable = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // toolTip
            // 
            this.toolTip.StripAmpersands = true;
            this.toolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolTip.StyleManager = null;
            this.toolTip.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(23, 208);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(186, 23);
            this.resetButton.TabIndex = 28;
            this.resetButton.Text = "Restore ANIM";
            this.resetButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.resetButton.UseSelectable = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // templateButton
            // 
            this.templateButton.Location = new System.Drawing.Point(23, 121);
            this.templateButton.Name = "templateButton";
            this.templateButton.Size = new System.Drawing.Size(186, 23);
            this.templateButton.TabIndex = 29;
            this.templateButton.Text = "Skin Presets";
            this.templateButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.templateButton.UseSelectable = true;
            this.templateButton.Click += new System.EventHandler(this.templateButton_Click);
            // 
            // rightLegOCheckBox
            // 
            this.rightLegOCheckBox.AutoSize = true;
            this.rightLegOCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rightLegOCheckBox.Location = new System.Drawing.Point(416, 256);
            this.rightLegOCheckBox.Name = "rightLegOCheckBox";
            this.rightLegOCheckBox.Size = new System.Drawing.Size(199, 19);
            this.rightLegOCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.rightLegOCheckBox.TabIndex = 43;
            this.rightLegOCheckBox.Text = "Remove Right Leg Layer Box";
            this.rightLegOCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.rightLegOCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
            this.rightLegOCheckBox.UseSelectable = true;
            // 
            // headOCheckBox
            // 
            this.headOCheckBox.AutoSize = true;
            this.headOCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.headOCheckBox.Location = new System.Drawing.Point(416, 98);
            this.headOCheckBox.Name = "headOCheckBox";
            this.headOCheckBox.Size = new System.Drawing.Size(173, 19);
            this.headOCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.headOCheckBox.TabIndex = 42;
            this.headOCheckBox.Text = "Remove Head Layer Box";
            this.headOCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.headOCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
            this.headOCheckBox.UseSelectable = true;
            // 
            // leftLegOCheckBox
            // 
            this.leftLegOCheckBox.AutoSize = true;
            this.leftLegOCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.leftLegOCheckBox.Location = new System.Drawing.Point(416, 222);
            this.leftLegOCheckBox.Name = "leftLegOCheckBox";
            this.leftLegOCheckBox.Size = new System.Drawing.Size(190, 19);
            this.leftLegOCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.leftLegOCheckBox.TabIndex = 41;
            this.leftLegOCheckBox.Text = "Remove Left Leg Layer Box";
            this.leftLegOCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.leftLegOCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
            this.leftLegOCheckBox.UseSelectable = true;
            // 
            // leftArmOCheckBox
            // 
            this.leftArmOCheckBox.AutoSize = true;
            this.leftArmOCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.leftArmOCheckBox.Location = new System.Drawing.Point(416, 160);
            this.leftArmOCheckBox.Name = "leftArmOCheckBox";
            this.leftArmOCheckBox.Size = new System.Drawing.Size(194, 19);
            this.leftArmOCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.leftArmOCheckBox.TabIndex = 39;
            this.leftArmOCheckBox.Text = "Remove Left Arm Layer Box";
            this.leftArmOCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.leftArmOCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
            this.leftArmOCheckBox.UseSelectable = true;
            // 
            // bodyOCheckBox
            // 
            this.bodyOCheckBox.AutoSize = true;
            this.bodyOCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.bodyOCheckBox.Location = new System.Drawing.Point(416, 129);
            this.bodyOCheckBox.Name = "bodyOCheckBox";
            this.bodyOCheckBox.Size = new System.Drawing.Size(172, 19);
            this.bodyOCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.bodyOCheckBox.TabIndex = 38;
            this.bodyOCheckBox.Text = "Remove Body Layer Box";
            this.bodyOCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.bodyOCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
            this.bodyOCheckBox.UseSelectable = true;
            // 
            // rightLegCheckBox
            // 
            this.rightLegCheckBox.AutoSize = true;
            this.rightLegCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rightLegCheckBox.Location = new System.Drawing.Point(242, 256);
            this.rightLegCheckBox.Name = "rightLegCheckBox";
            this.rightLegCheckBox.Size = new System.Drawing.Size(162, 19);
            this.rightLegCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.rightLegCheckBox.TabIndex = 37;
            this.rightLegCheckBox.Text = "Remove Right Leg Box";
            this.rightLegCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.rightLegCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
            this.rightLegCheckBox.UseSelectable = true;
            // 
            // slimCheckBox
            // 
            this.slimCheckBox.AutoSize = true;
            this.slimCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.slimCheckBox.Location = new System.Drawing.Point(416, 67);
            this.slimCheckBox.Name = "slimCheckBox";
            this.slimCheckBox.Size = new System.Drawing.Size(151, 19);
            this.slimCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.slimCheckBox.TabIndex = 36;
            this.slimCheckBox.Text = "64x64 Alex/Slim Skin";
            this.slimCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.slimCheckBox, "          The 1.8 style skin type with slim arms, overlays for each part, and sep" +
        "arate textures for right and left limbs. Resolution is also set to 64x64.       " +
        "   ");
            this.slimCheckBox.UseSelectable = true;
            // 
            // headCheckBox
            // 
            this.headCheckBox.AutoSize = true;
            this.headCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.headCheckBox.Location = new System.Drawing.Point(242, 98);
            this.headCheckBox.Name = "headCheckBox";
            this.headCheckBox.Size = new System.Drawing.Size(136, 19);
            this.headCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.headCheckBox.TabIndex = 35;
            this.headCheckBox.Text = "Remove Head Box";
            this.headCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.headCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
            this.headCheckBox.UseSelectable = true;
            // 
            // leftLegCheckBox
            // 
            this.leftLegCheckBox.AutoSize = true;
            this.leftLegCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.leftLegCheckBox.Location = new System.Drawing.Point(242, 222);
            this.leftLegCheckBox.Name = "leftLegCheckBox";
            this.leftLegCheckBox.Size = new System.Drawing.Size(153, 19);
            this.leftLegCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.leftLegCheckBox.TabIndex = 34;
            this.leftLegCheckBox.Text = "Remove Left Leg Box";
            this.leftLegCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.leftLegCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
            this.leftLegCheckBox.UseSelectable = true;
            // 
            // rightArmCheckBox
            // 
            this.rightArmCheckBox.AutoSize = true;
            this.rightArmCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rightArmCheckBox.Location = new System.Drawing.Point(242, 191);
            this.rightArmCheckBox.Name = "rightArmCheckBox";
            this.rightArmCheckBox.Size = new System.Drawing.Size(166, 19);
            this.rightArmCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.rightArmCheckBox.TabIndex = 33;
            this.rightArmCheckBox.Text = "Remove Right Arm Box";
            this.rightArmCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.rightArmCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
            this.rightArmCheckBox.UseSelectable = true;
            // 
            // leftArmCheckBox
            // 
            this.leftArmCheckBox.AutoSize = true;
            this.leftArmCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.leftArmCheckBox.Location = new System.Drawing.Point(242, 160);
            this.leftArmCheckBox.Name = "leftArmCheckBox";
            this.leftArmCheckBox.Size = new System.Drawing.Size(157, 19);
            this.leftArmCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.leftArmCheckBox.TabIndex = 32;
            this.leftArmCheckBox.Text = "Remove Left Arm Box";
            this.leftArmCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.leftArmCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
            this.leftArmCheckBox.UseSelectable = true;
            // 
            // bodyCheckBox
            // 
            this.bodyCheckBox.AutoSize = true;
            this.bodyCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.bodyCheckBox.Location = new System.Drawing.Point(242, 129);
            this.bodyCheckBox.Name = "bodyCheckBox";
            this.bodyCheckBox.Size = new System.Drawing.Size(135, 19);
            this.bodyCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.bodyCheckBox.TabIndex = 31;
            this.bodyCheckBox.Text = "Remove Body Box";
            this.bodyCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.bodyCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
            this.bodyCheckBox.UseSelectable = true;
            // 
            // classicCheckBox
            // 
            this.classicCheckBox.AutoSize = true;
            this.classicCheckBox.Checked = true;
            this.classicCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.classicCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.classicCheckBox.Location = new System.Drawing.Point(242, 67);
            this.classicCheckBox.Name = "classicCheckBox";
            this.classicCheckBox.Size = new System.Drawing.Size(136, 19);
            this.classicCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.classicCheckBox.TabIndex = 30;
            this.classicCheckBox.Text = "64x64 Classic Skin";
            this.classicCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.classicCheckBox, "          The 1.8 style skin type with overlays for each part and separate textur" +
        "es for right and left limbs. Resolution is also set to 64x64.         ");
            this.classicCheckBox.UseSelectable = true;
            // 
            // rightArmOCheckBox
            // 
            this.rightArmOCheckBox.AutoSize = true;
            this.rightArmOCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.rightArmOCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rightArmOCheckBox.Location = new System.Drawing.Point(416, 191);
            this.rightArmOCheckBox.Name = "rightArmOCheckBox";
            this.rightArmOCheckBox.Size = new System.Drawing.Size(203, 19);
            this.rightArmOCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.rightArmOCheckBox.TabIndex = 40;
            this.rightArmOCheckBox.Text = "Remove Right Arm Layer Box";
            this.rightArmOCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.rightArmOCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
            this.rightArmOCheckBox.UseSelectable = true;
            // 
            // rightLeggingCheckBox
            // 
            this.rightLeggingCheckBox.AutoSize = true;
            this.rightLeggingCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rightLeggingCheckBox.Location = new System.Drawing.Point(638, 222);
            this.rightLeggingCheckBox.Name = "rightLeggingCheckBox";
            this.rightLeggingCheckBox.Size = new System.Drawing.Size(173, 19);
            this.rightLeggingCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.rightLeggingCheckBox.TabIndex = 49;
            this.rightLeggingCheckBox.Text = "Render Right Leg Armor";
            this.rightLeggingCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.rightLeggingCheckBox, " Forcefully enables the specified armor piece.");
            this.rightLeggingCheckBox.UseSelectable = true;
            // 
            // helmetCheckBox
            // 
            this.helmetCheckBox.AutoSize = true;
            this.helmetCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.helmetCheckBox.Location = new System.Drawing.Point(638, 67);
            this.helmetCheckBox.Name = "helmetCheckBox";
            this.helmetCheckBox.Size = new System.Drawing.Size(147, 19);
            this.helmetCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.helmetCheckBox.TabIndex = 48;
            this.helmetCheckBox.Text = "Render Head Armor";
            this.helmetCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.helmetCheckBox, " Forcefully enables the specified armor piece.");
            this.helmetCheckBox.UseSelectable = true;
            // 
            // leftLeggingCheckBox
            // 
            this.leftLeggingCheckBox.AutoSize = true;
            this.leftLeggingCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.leftLeggingCheckBox.Location = new System.Drawing.Point(638, 191);
            this.leftLeggingCheckBox.Name = "leftLeggingCheckBox";
            this.leftLeggingCheckBox.Size = new System.Drawing.Size(164, 19);
            this.leftLeggingCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.leftLeggingCheckBox.TabIndex = 47;
            this.leftLeggingCheckBox.Text = "Render Left Leg Armor";
            this.leftLeggingCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.leftLeggingCheckBox, " Forcefully enables the specified armor piece.");
            this.leftLeggingCheckBox.UseSelectable = true;
            // 
            // rightArmorCheckBox
            // 
            this.rightArmorCheckBox.AutoSize = true;
            this.rightArmorCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rightArmorCheckBox.Location = new System.Drawing.Point(638, 160);
            this.rightArmorCheckBox.Name = "rightArmorCheckBox";
            this.rightArmorCheckBox.Size = new System.Drawing.Size(177, 19);
            this.rightArmorCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.rightArmorCheckBox.TabIndex = 46;
            this.rightArmorCheckBox.Text = "Render Right Arm Armor";
            this.rightArmorCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.rightArmorCheckBox, " Forcefully enables the specified armor piece.");
            this.rightArmorCheckBox.UseSelectable = true;
            // 
            // leftArmorCheckBox
            // 
            this.leftArmorCheckBox.AutoSize = true;
            this.leftArmorCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.leftArmorCheckBox.Location = new System.Drawing.Point(638, 129);
            this.leftArmorCheckBox.Name = "leftArmorCheckBox";
            this.leftArmorCheckBox.Size = new System.Drawing.Size(168, 19);
            this.leftArmorCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.leftArmorCheckBox.TabIndex = 45;
            this.leftArmorCheckBox.Text = "Render Left Arm Armor";
            this.leftArmorCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.leftArmorCheckBox, " Forcefully enables the specified armor piece.");
            this.leftArmorCheckBox.UseSelectable = true;
            // 
            // chestplateCheckBox
            // 
            this.chestplateCheckBox.AutoSize = true;
            this.chestplateCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chestplateCheckBox.Location = new System.Drawing.Point(638, 98);
            this.chestplateCheckBox.Name = "chestplateCheckBox";
            this.chestplateCheckBox.Size = new System.Drawing.Size(146, 19);
            this.chestplateCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.chestplateCheckBox.TabIndex = 44;
            this.chestplateCheckBox.Text = "Render Body Armor";
            this.chestplateCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.chestplateCheckBox, " Forcefully enables the specified armor piece.");
            this.chestplateCheckBox.UseSelectable = true;
            // 
            // unknownCheckBox
            // 
            this.unknownCheckBox.AutoSize = true;
            this.unknownCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.unknownCheckBox.Location = new System.Drawing.Point(359, 377);
            this.unknownCheckBox.Name = "unknownCheckBox";
            this.unknownCheckBox.Size = new System.Drawing.Size(84, 19);
            this.unknownCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.unknownCheckBox.TabIndex = 61;
            this.unknownCheckBox.Text = "Unknown";
            this.unknownCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.unknownCheckBox, "   If you figure out what this is. Please reach out to MNL#8935 on Discord. (:   " +
        "");
            this.unknownCheckBox.UseSelectable = true;
            // 
            // crouchCheckBox
            // 
            this.crouchCheckBox.AutoSize = true;
            this.crouchCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.crouchCheckBox.Location = new System.Drawing.Point(359, 346);
            this.crouchCheckBox.Name = "crouchCheckBox";
            this.crouchCheckBox.Size = new System.Drawing.Size(137, 19);
            this.crouchCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.crouchCheckBox.TabIndex = 60;
            this.crouchCheckBox.Text = "Backwards Crouch";
            this.crouchCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.crouchCheckBox, "      The crouch animation is reversed so that the arms and body lean back. Usefu" +
        "l for small skins.     ");
            this.crouchCheckBox.UseSelectable = true;
            // 
            // dinnerboneCheckBox
            // 
            this.dinnerboneCheckBox.AutoSize = true;
            this.dinnerboneCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.dinnerboneCheckBox.Location = new System.Drawing.Point(359, 315);
            this.dinnerboneCheckBox.Name = "dinnerboneCheckBox";
            this.dinnerboneCheckBox.Size = new System.Drawing.Size(97, 19);
            this.dinnerboneCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.dinnerboneCheckBox.TabIndex = 59;
            this.dinnerboneCheckBox.Text = "Dinnerbone";
            this.dinnerboneCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dinnerboneCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.dinnerboneCheckBox, "   Flips the skin upside down like Dinnerbone\'s skin, a Minecraft developer.  ");
            this.dinnerboneCheckBox.UseSelectable = true;
            // 
            // noArmorCheckBox
            // 
            this.noArmorCheckBox.AutoSize = true;
            this.noArmorCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.noArmorCheckBox.Location = new System.Drawing.Point(653, 377);
            this.noArmorCheckBox.Name = "noArmorCheckBox";
            this.noArmorCheckBox.Size = new System.Drawing.Size(131, 19);
            this.noArmorCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.noArmorCheckBox.TabIndex = 58;
            this.noArmorCheckBox.Text = "Disable All Armor";
            this.noArmorCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.noArmorCheckBox, " Disables all armor desptie the armor flags.  ");
            this.noArmorCheckBox.UseSelectable = true;
            // 
            // bobbingCheckBox
            // 
            this.bobbingCheckBox.AutoSize = true;
            this.bobbingCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.bobbingCheckBox.Location = new System.Drawing.Point(505, 346);
            this.bobbingCheckBox.Name = "bobbingCheckBox";
            this.bobbingCheckBox.Size = new System.Drawing.Size(124, 19);
            this.bobbingCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.bobbingCheckBox.TabIndex = 57;
            this.bobbingCheckBox.Text = "Disable Bobbing";
            this.bobbingCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.bobbingCheckBox, " Disables the bobbing effect in first person.");
            this.bobbingCheckBox.UseSelectable = true;
            // 
            // santaCheckBox
            // 
            this.santaCheckBox.AutoSize = true;
            this.santaCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.santaCheckBox.Location = new System.Drawing.Point(653, 346);
            this.santaCheckBox.Name = "santaCheckBox";
            this.santaCheckBox.Size = new System.Drawing.Size(86, 19);
            this.santaCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.santaCheckBox.TabIndex = 56;
            this.santaCheckBox.Text = "Bad Santa";
            this.santaCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.santaCheckBox, "       The skin sits down after about 10 seconds of no controller input. Made for" +
        " Bad Santa in the \"Festive\" skin pack.       ");
            this.santaCheckBox.UseSelectable = true;
            // 
            // syncLegsCheckBox
            // 
            this.syncLegsCheckBox.AutoSize = true;
            this.syncLegsCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.syncLegsCheckBox.Location = new System.Drawing.Point(505, 315);
            this.syncLegsCheckBox.Name = "syncLegsCheckBox";
            this.syncLegsCheckBox.Size = new System.Drawing.Size(136, 19);
            this.syncLegsCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.syncLegsCheckBox.TabIndex = 55;
            this.syncLegsCheckBox.Text = "Synchronous Legs";
            this.syncLegsCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.syncLegsCheckBox, "   These parts will move at the same time and angle as each other.  ");
            this.syncLegsCheckBox.UseSelectable = true;
            // 
            // staticArmsCheckBox
            // 
            this.staticArmsCheckBox.AutoSize = true;
            this.staticArmsCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.staticArmsCheckBox.Location = new System.Drawing.Point(239, 315);
            this.staticArmsCheckBox.Name = "staticArmsCheckBox";
            this.staticArmsCheckBox.Size = new System.Drawing.Size(94, 19);
            this.staticArmsCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.staticArmsCheckBox.TabIndex = 54;
            this.staticArmsCheckBox.Text = "Static Arms";
            this.staticArmsCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.staticArmsCheckBox, " These parts will not move in most animations. ");
            this.staticArmsCheckBox.UseSelectable = true;
            // 
            // syncArmsCheckBox
            // 
            this.syncArmsCheckBox.AutoSize = true;
            this.syncArmsCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.syncArmsCheckBox.Location = new System.Drawing.Point(653, 315);
            this.syncArmsCheckBox.Name = "syncArmsCheckBox";
            this.syncArmsCheckBox.Size = new System.Drawing.Size(140, 19);
            this.syncArmsCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.syncArmsCheckBox.TabIndex = 53;
            this.syncArmsCheckBox.Text = "Synchronous Arms";
            this.syncArmsCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.syncArmsCheckBox, "   These parts will move at the same time and angle as each other.  ");
            this.syncArmsCheckBox.UseSelectable = true;
            // 
            // statueCheckBox
            // 
            this.statueCheckBox.AutoSize = true;
            this.statueCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.statueCheckBox.Location = new System.Drawing.Point(505, 377);
            this.statueCheckBox.Name = "statueCheckBox";
            this.statueCheckBox.Size = new System.Drawing.Size(126, 19);
            this.statueCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.statueCheckBox.TabIndex = 52;
            this.statueCheckBox.Text = "Statue of Liberty";
            this.statueCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.statueCheckBox, "       The right arm is lifted likt the Statue of Liberty. Made for Angel of Libe" +
        "rty in the \"Doctor Who Volume I\" skin pack.       ");
            this.statueCheckBox.UseSelectable = true;
            // 
            // zombieCheckBox
            // 
            this.zombieCheckBox.AutoSize = true;
            this.zombieCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.zombieCheckBox.Location = new System.Drawing.Point(239, 377);
            this.zombieCheckBox.Name = "zombieCheckBox";
            this.zombieCheckBox.Size = new System.Drawing.Size(107, 19);
            this.zombieCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.zombieCheckBox.TabIndex = 51;
            this.zombieCheckBox.Text = "Zombie Arms";
            this.zombieCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.zombieCheckBox, " Both arms will stick up like a Zombie. ");
            this.zombieCheckBox.UseSelectable = true;
            // 
            // staticLegsCheckBox
            // 
            this.staticLegsCheckBox.AutoSize = true;
            this.staticLegsCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.staticLegsCheckBox.Location = new System.Drawing.Point(239, 346);
            this.staticLegsCheckBox.Name = "staticLegsCheckBox";
            this.staticLegsCheckBox.Size = new System.Drawing.Size(90, 19);
            this.staticLegsCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.staticLegsCheckBox.TabIndex = 50;
            this.staticLegsCheckBox.Text = "Static Legs";
            this.staticLegsCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip.SetToolTip(this.staticLegsCheckBox, " These parts will not move in most animations. ");
            this.staticLegsCheckBox.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 25);
            this.panel1.TabIndex = 62;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp_1);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImage = global::PckStudio.Properties.Resources.Minimize;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(761, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 26);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::PckStudio.Properties.Resources.Close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(804, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 26);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(233, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Special Animations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(233, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Skin Flags";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(625, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Armor Flags";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ANIM Editor";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp_1);
            // 
            // ANIMEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 415);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.unknownCheckBox);
            this.Controls.Add(this.crouchCheckBox);
            this.Controls.Add(this.dinnerboneCheckBox);
            this.Controls.Add(this.noArmorCheckBox);
            this.Controls.Add(this.bobbingCheckBox);
            this.Controls.Add(this.santaCheckBox);
            this.Controls.Add(this.syncLegsCheckBox);
            this.Controls.Add(this.staticArmsCheckBox);
            this.Controls.Add(this.syncArmsCheckBox);
            this.Controls.Add(this.statueCheckBox);
            this.Controls.Add(this.zombieCheckBox);
            this.Controls.Add(this.staticLegsCheckBox);
            this.Controls.Add(this.rightLeggingCheckBox);
            this.Controls.Add(this.helmetCheckBox);
            this.Controls.Add(this.leftLeggingCheckBox);
            this.Controls.Add(this.rightArmorCheckBox);
            this.Controls.Add(this.leftArmorCheckBox);
            this.Controls.Add(this.chestplateCheckBox);
            this.Controls.Add(this.rightLegOCheckBox);
            this.Controls.Add(this.headOCheckBox);
            this.Controls.Add(this.leftLegOCheckBox);
            this.Controls.Add(this.leftArmOCheckBox);
            this.Controls.Add(this.bodyOCheckBox);
            this.Controls.Add(this.rightLegCheckBox);
            this.Controls.Add(this.slimCheckBox);
            this.Controls.Add(this.headCheckBox);
            this.Controls.Add(this.leftLegCheckBox);
            this.Controls.Add(this.rightArmCheckBox);
            this.Controls.Add(this.leftArmCheckBox);
            this.Controls.Add(this.bodyCheckBox);
            this.Controls.Add(this.classicCheckBox);
            this.Controls.Add(this.rightArmOCheckBox);
            this.Controls.Add(this.templateButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.uncheckButton);
            this.Controls.Add(this.animValue);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.closeButton);
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "ANIMEditor";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroButton closeButton;
		private MetroFramework.Controls.MetroButton copyButton;
		private MetroFramework.Controls.MetroButton importButton;
		private MetroFramework.Controls.MetroButton exportButton;
		private MetroFramework.Controls.MetroLabel animValue;
		private MetroFramework.Controls.MetroButton uncheckButton;
		private MetroFramework.Controls.MetroButton checkButton;
		private MetroFramework.Components.MetroToolTip toolTip;
		private MetroFramework.Controls.MetroButton resetButton;
		private MetroFramework.Controls.MetroButton templateButton;
        private MetroFramework.Controls.MetroCheckBox rightLegOCheckBox;
        private MetroFramework.Controls.MetroCheckBox headOCheckBox;
        private MetroFramework.Controls.MetroCheckBox leftLegOCheckBox;
        private MetroFramework.Controls.MetroCheckBox leftArmOCheckBox;
        private MetroFramework.Controls.MetroCheckBox bodyOCheckBox;
        private MetroFramework.Controls.MetroCheckBox rightLegCheckBox;
        private MetroFramework.Controls.MetroCheckBox slimCheckBox;
        private MetroFramework.Controls.MetroCheckBox headCheckBox;
        private MetroFramework.Controls.MetroCheckBox leftLegCheckBox;
        private MetroFramework.Controls.MetroCheckBox rightArmCheckBox;
        private MetroFramework.Controls.MetroCheckBox leftArmCheckBox;
        private MetroFramework.Controls.MetroCheckBox bodyCheckBox;
        private MetroFramework.Controls.MetroCheckBox classicCheckBox;
        private MetroFramework.Controls.MetroCheckBox rightArmOCheckBox;
        private MetroFramework.Controls.MetroCheckBox rightLeggingCheckBox;
        private MetroFramework.Controls.MetroCheckBox helmetCheckBox;
        private MetroFramework.Controls.MetroCheckBox leftLeggingCheckBox;
        private MetroFramework.Controls.MetroCheckBox rightArmorCheckBox;
        private MetroFramework.Controls.MetroCheckBox leftArmorCheckBox;
        private MetroFramework.Controls.MetroCheckBox chestplateCheckBox;
        private MetroFramework.Controls.MetroCheckBox unknownCheckBox;
        private MetroFramework.Controls.MetroCheckBox crouchCheckBox;
        private MetroFramework.Controls.MetroCheckBox dinnerboneCheckBox;
        private MetroFramework.Controls.MetroCheckBox noArmorCheckBox;
        private MetroFramework.Controls.MetroCheckBox bobbingCheckBox;
        private MetroFramework.Controls.MetroCheckBox santaCheckBox;
        private MetroFramework.Controls.MetroCheckBox syncLegsCheckBox;
        private MetroFramework.Controls.MetroCheckBox staticArmsCheckBox;
        private MetroFramework.Controls.MetroCheckBox syncArmsCheckBox;
        private MetroFramework.Controls.MetroCheckBox statueCheckBox;
        private MetroFramework.Controls.MetroCheckBox zombieCheckBox;
        private MetroFramework.Controls.MetroCheckBox staticLegsCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}