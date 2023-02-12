
namespace PckStudio.Forms
{
    partial class AddPCKPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPCKPassword));
            this.buttonUnlocked = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUnlocked
            // 
            this.buttonUnlocked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.buttonUnlocked.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonUnlocked.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUnlocked.ForeColor = System.Drawing.Color.Silver;
            this.buttonUnlocked.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonUnlocked.Location = new System.Drawing.Point(252, 96);
            this.buttonUnlocked.Name = "buttonUnlocked";
            this.buttonUnlocked.Size = new System.Drawing.Size(108, 23);
            this.buttonUnlocked.TabIndex = 3;
            this.buttonUnlocked.Text = "Lock!";
            this.buttonUnlocked.UseVisualStyleBackColor = false;
            this.buttonUnlocked.Click += new System.EventHandler(this.buttonUnlocked_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxPass.Location = new System.Drawing.Point(60, 59);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(244, 13);
            this.textBoxPass.TabIndex = 2;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.panel1.Location = new System.Drawing.Point(52, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 22);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 18);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.Image = global::PckStudio.Properties.Resources.wd_cl10;
            this.button1.Location = new System.Drawing.Point(338, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 18);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Password";
            // 
            // AddPCKPassword
            // 
            this.AcceptButton = this.buttonUnlocked;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 125);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonUnlocked);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "AddPCKPassword";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUnlocked;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}