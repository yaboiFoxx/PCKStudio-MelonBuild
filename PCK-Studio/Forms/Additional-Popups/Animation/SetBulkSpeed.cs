﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace PckStudio.Forms.Additional_Popups.Animation
{
	public partial class SetBulkSpeed : MetroForm
	{
		public int time => (int)TimeUpDown.Value;
		public SetBulkSpeed(TreeView treeView)
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (time < 0) return;
			DialogResult = DialogResult.OK;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
