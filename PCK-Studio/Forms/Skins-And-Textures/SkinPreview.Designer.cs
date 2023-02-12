
namespace PckStudio.Forms
{
    partial class SkinPreview
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
            this.ModelView = new PckStudio.Models.MinecraftModelView(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModelView
            // 
            this.ModelView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ModelView.BackGradientColor1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModelView.BackGradientColor2 = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModelView.BackgroundType = PckStudio.Models.BackgroundTypes.Color;
            this.ModelView.DegreesX = 0;
            this.ModelView.DegreesY = 0;
            this.ModelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelView.ForeColor = System.Drawing.Color.Black;
            this.ModelView.FOV = 90;
            this.ModelView.Location = new System.Drawing.Point(0, 0);
            this.ModelView.Name = "ModelView";
            this.ModelView.Projection = PckStudio.Models.ProjectionTypes.Perspective;
            this.ModelView.Size = new System.Drawing.Size(418, 568);
            this.ModelView.TabIndex = 1;
            this.ModelView.Text = "PCK Model View";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 22);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PCK Model View";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.Image = global::PckStudio.Properties.Resources.wd_cl10;
            this.button1.Location = new System.Drawing.Point(388, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 22);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SkinPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ModelView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SkinPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SkinPreview";
            this.Load += new System.EventHandler(this.SkinPreview_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PckStudio.Models.MinecraftModelView ModelView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}