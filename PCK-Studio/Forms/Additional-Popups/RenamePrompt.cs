using System;
using System.Windows;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Drawing;
using Point = System.Drawing.Point;

namespace PckStudio
{
    public partial class RenamePrompt : MetroForm
	{
		/// <summary>
		/// Text entered <c>only access when DialogResult == DialogResult.OK</c>
		/// </summary>
		public string NewText => InputTextBox.Text;

		public RenamePrompt(string InitialText) : this(InitialText, -1)
		{ }

		public RenamePrompt(string InitialText, int maxChar)
		{
			InitializeComponent();
			InputTextBox.Text = InitialText;
			InputTextBox.MaxLength = maxChar < 0 ? short.MaxValue : maxChar;
			FormBorderStyle = FormBorderStyle.None;
		}

        private void OKBtn_Click(object sender, EventArgs e)
        {
			DialogResult = DialogResult.OK;
        }

        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter)
				OKBtn_Click(sender, e);
        }

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        bool mousedown;
        private Point offset;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
