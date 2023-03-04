using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PckStudio;

namespace PckStudio.Forms
{
    public partial class pckLocked : MetroFramework.Forms.MetroForm
    {
        bool mousedown;
        private Point offset;
        string pass;

        public pckLocked(string pass)
        {
            this.pass = pass;
            InitializeComponent();
        }

        private void textBoxPass_Click(object sender, EventArgs e)
        {
        }

        private void buttonUnlocked_Click(object sender, EventArgs e)
        {
            if (MD5(textBoxPass.Text) == pass || MD5(textBoxPass.Text) == MD5(pass))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect password!");
                DialogResult = DialogResult.Abort;
                textBoxPass.Text = "";
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
        }

        public string MD5(string s)
        {
            using (var provider = System.Security.Cryptography.MD5.Create())
            {
                StringBuilder builder = new StringBuilder();

                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());

                return builder.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
    }
}
