﻿using PckStudio.Classes.FileTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using RichPresenceClient;
using PckStudio.Forms.Additional_Popups.Loc;
using PckStudio.Classes.IO.LOC;
using System.IO;

namespace PckStudio.Forms.Editor
{
	public partial class LOCEditor : MetroForm
    {
		DataTable tbl;
		LOCFile currentLoc;
		PCKFile.FileData _file;

		public LOCEditor(PCKFile.FileData file)
		{
			InitializeComponent();
			_file = file;
            using (var ms = new MemoryStream(file.data))
            {
                currentLoc = LOCFileReader.Read(ms);
            }
			tbl = new DataTable();
			tbl.Columns.Add(new DataColumn("Language") { ReadOnly = true });
			tbl.Columns.Add("Display Name");
			dataGridViewLocEntryData.DataSource = tbl;
            DataGridViewColumn column = dataGridViewLocEntryData.Columns[1];
            column.Width = dataGridViewLocEntryData.Width;
        }

		private void LOCEditor_Load(object sender, EventArgs e)
		{
			RPC.SetPresence("LOC Editor", "Editing localization File.");
			foreach(string locKey in currentLoc.LocKeys.Keys)
				treeViewLocKeys.Nodes.Add(locKey);
		}

        private void LOCEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
			RPC.SetPresence("An Open Source .PCK File Editor", "Program by PhoenixARC");
        }

		private void treeViewLocKeys_AfterSelect(object sender, TreeViewEventArgs e)
		{
			var node = e.Node;
			if (node == null ||
				!currentLoc.LocKeys.ContainsKey(node.Text))
			{
				MessageBox.Show("Selected Node does not seem to be in the loc file");
				return;
			}
			ReloadTranslationTable();
		}

		private void addDisplayIDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (treeViewLocKeys.SelectedNode is TreeNode)
				using (RenamePrompt prompt = new RenamePrompt(""))
				{
					prompt.OKButton.Text = "Add";
					if (prompt.ShowDialog() == DialogResult.OK && 
						!currentLoc.LocKeys.ContainsKey(prompt.NewText) &&
						currentLoc.AddLocKey(prompt.NewText, ""))
					{
						treeViewLocKeys.Nodes.Add(prompt.NewText);
					}
				}
        }

        private void deleteDisplayIDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (treeViewLocKeys.SelectedNode is TreeNode t && currentLoc.RemoveLocKey(t.Text))
			{
				treeViewLocKeys.SelectedNode.Remove();
            }
		}

		private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex != 1 ||
				treeViewLocKeys.SelectedNode == null)
            {
				MessageBox.Show("something went wrong");
				return;
            }
			currentLoc.SetLocEntry(treeViewLocKeys.SelectedNode.Text, tbl.Rows[e.RowIndex][0].ToString(), tbl.Rows[e.RowIndex][1].ToString());
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Delete)
				deleteDisplayIDToolStripMenuItem_Click(sender, e);
		}

		private void buttonReplaceAll_Click(object sender, EventArgs e)
		{
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                tbl.Rows[i][1] = textBoxReplaceAll.Text;
            }

			currentLoc.SetLocEntry(treeViewLocKeys.SelectedNode.Text, textBoxReplaceAll.Text);
		}

        private void LOCEditor_Resize(object sender, EventArgs e)
        {
			DataGridViewColumn column = dataGridViewLocEntryData.Columns[1];
			column.Width = dataGridViewLocEntryData.Width - dataGridViewLocEntryData.Columns[0].Width;
		}

		private void ReloadTranslationTable()
        {
			tbl.Rows.Clear();
			foreach (var l in currentLoc.GetLocEntries(treeViewLocKeys.SelectedNode.Text))
				tbl.Rows.Add(l.Key, l.Value);
		}

		private IEnumerable<string> GetAvailableLanguages()
        {
			foreach (var lang in LOCFile.ValidLanguages)
			{
				if (currentLoc.Languages.Contains(lang)) continue;
				yield return lang;
			}
			yield break;
		}

		private void addLanguageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string[] avalibleLang = GetAvailableLanguages().ToArray();
			using (var dialog = new AddLanguage(avalibleLang))
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					currentLoc.AddLanguage(dialog.SelectedLanguage);
					ReloadTranslationTable();
				}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
            using (var ms = new MemoryStream())
            {
                LOCFileWriter.Write(ms, currentLoc);
                _file.SetData(ms.ToArray());
            }
			DialogResult = DialogResult.OK;
        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{

		}

		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{

		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{

		}
	}
}
