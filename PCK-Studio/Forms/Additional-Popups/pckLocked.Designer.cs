namespace PckStudio.Forms
{
    partial class pckLocked
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pckLocked));
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonUnlocked = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPass.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.textBoxPass, "textBoxPass");
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Click += new System.EventHandler(this.textBoxPass_Click);
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            this.textBoxPass.Enter += new System.EventHandler(this.textBoxPass_Enter);
            // 
            // buttonUnlocked
            // 
            this.buttonUnlocked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonUnlocked.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonUnlocked.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonUnlocked.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.buttonUnlocked, "buttonUnlocked");
            this.buttonUnlocked.ForeColor = System.Drawing.Color.White;
            this.buttonUnlocked.Name = "buttonUnlocked";
            this.buttonUnlocked.UseVisualStyleBackColor = false;
            this.buttonUnlocked.Click += new System.EventHandler(this.buttonUnlocked_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackgroundImage = global::PckStudio.Properties.Resources.Minimize;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackgroundImage = global::PckStudio.Properties.Resources.Close;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Name = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pckLocked
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonUnlocked);
            this.Controls.Add(this.textBoxPass);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pckLocked";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonUnlocked;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}