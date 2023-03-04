namespace PckStudio.Forms.Editor
{
    partial class LOCEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOCEditor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDisplayIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDisplayIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.addLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locSort = new PckStudio.Forms.MyTablePanel();
            this.buttonReplaceAll = new System.Windows.Forms.Button();
            this.dataGridViewLocEntryData = new System.Windows.Forms.DataGridView();
            this.textBoxReplaceAll = new System.Windows.Forms.TextBox();
            this.treeViewLocKeys = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.GridContextMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.locSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocEntryData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDisplayIDToolStripMenuItem,
            this.deleteDisplayIDToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // addDisplayIDToolStripMenuItem
            // 
            this.addDisplayIDToolStripMenuItem.Name = "addDisplayIDToolStripMenuItem";
            resources.ApplyResources(this.addDisplayIDToolStripMenuItem, "addDisplayIDToolStripMenuItem");
            this.addDisplayIDToolStripMenuItem.Click += new System.EventHandler(this.addDisplayIDToolStripMenuItem_Click);
            // 
            // deleteDisplayIDToolStripMenuItem
            // 
            this.deleteDisplayIDToolStripMenuItem.Name = "deleteDisplayIDToolStripMenuItem";
            resources.ApplyResources(this.deleteDisplayIDToolStripMenuItem, "deleteDisplayIDToolStripMenuItem");
            this.deleteDisplayIDToolStripMenuItem.Click += new System.EventHandler(this.deleteDisplayIDToolStripMenuItem_Click);
            // 
            // GridContextMenu
            // 
            this.GridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLanguageToolStripMenuItem,
            this.removeLanguageToolStripMenuItem});
            this.GridContextMenu.Name = "GridContextMenu";
            resources.ApplyResources(this.GridContextMenu, "GridContextMenu");
            this.GridContextMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // addLanguageToolStripMenuItem
            // 
            this.addLanguageToolStripMenuItem.Name = "addLanguageToolStripMenuItem";
            resources.ApplyResources(this.addLanguageToolStripMenuItem, "addLanguageToolStripMenuItem");
            this.addLanguageToolStripMenuItem.Click += new System.EventHandler(this.addLanguageToolStripMenuItem_Click);
            // 
            // removeLanguageToolStripMenuItem
            // 
            this.removeLanguageToolStripMenuItem.Name = "removeLanguageToolStripMenuItem";
            resources.ApplyResources(this.removeLanguageToolStripMenuItem, "removeLanguageToolStripMenuItem");
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.menuStrip.BackgroundImage = global::PckStudio.Properties.Resources.menucontexbar;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // locSort
            // 
            this.locSort.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            resources.ApplyResources(this.locSort, "locSort");
            this.locSort.Controls.Add(this.buttonReplaceAll, 2, 0);
            this.locSort.Controls.Add(this.dataGridViewLocEntryData, 1, 1);
            this.locSort.Controls.Add(this.textBoxReplaceAll, 1, 0);
            this.locSort.Controls.Add(this.treeViewLocKeys, 0, 0);
            this.locSort.Name = "locSort";
            // 
            // buttonReplaceAll
            // 
            this.buttonReplaceAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonReplaceAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonReplaceAll.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.buttonReplaceAll, "buttonReplaceAll");
            this.buttonReplaceAll.ForeColor = System.Drawing.Color.Silver;
            this.buttonReplaceAll.Name = "buttonReplaceAll";
            this.buttonReplaceAll.UseVisualStyleBackColor = false;
            this.buttonReplaceAll.Click += new System.EventHandler(this.buttonReplaceAll_Click);
            // 
            // dataGridViewLocEntryData
            // 
            this.dataGridViewLocEntryData.AllowUserToAddRows = false;
            this.dataGridViewLocEntryData.AllowUserToDeleteRows = false;
            this.dataGridViewLocEntryData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.dataGridViewLocEntryData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLocEntryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLocEntryData.ColumnHeadersVisible = false;
            this.locSort.SetColumnSpan(this.dataGridViewLocEntryData, 2);
            this.dataGridViewLocEntryData.ContextMenuStrip = this.GridContextMenu;
            resources.ApplyResources(this.dataGridViewLocEntryData, "dataGridViewLocEntryData");
            this.dataGridViewLocEntryData.Name = "dataGridViewLocEntryData";
            this.dataGridViewLocEntryData.RowHeadersVisible = false;
            this.dataGridViewLocEntryData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // textBoxReplaceAll
            // 
            this.textBoxReplaceAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxReplaceAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxReplaceAll, "textBoxReplaceAll");
            this.textBoxReplaceAll.ForeColor = System.Drawing.Color.Silver;
            this.textBoxReplaceAll.Name = "textBoxReplaceAll";
            // 
            // treeViewLocKeys
            // 
            this.treeViewLocKeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.treeViewLocKeys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewLocKeys.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.treeViewLocKeys, "treeViewLocKeys");
            this.treeViewLocKeys.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.treeViewLocKeys.LabelEdit = true;
            this.treeViewLocKeys.Name = "treeViewLocKeys";
            this.locSort.SetRowSpan(this.treeViewLocKeys, 2);
            this.treeViewLocKeys.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewLocKeys_AfterSelect);
            this.treeViewLocKeys.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp_1);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.button1.Image = global::PckStudio.Properties.Resources.Close;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Name = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp_1);
            // 
            // LOCEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.locSort);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LOCEditor";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LOCEditor_FormClosing);
            this.Load += new System.EventHandler(this.LOCEditor_Load);
            this.Resize += new System.EventHandler(this.LOCEditor_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.GridContextMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.locSort.ResumeLayout(false);
            this.locSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocEntryData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewLocKeys;
        private System.Windows.Forms.DataGridView dataGridViewLocEntryData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addDisplayIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDisplayIDToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxReplaceAll;
        private PckStudio.Forms.MyTablePanel locSort;
        private System.Windows.Forms.Button buttonReplaceAll;
        private MetroFramework.Controls.MetroContextMenu GridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeLanguageToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}