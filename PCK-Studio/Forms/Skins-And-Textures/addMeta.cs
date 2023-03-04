using PckStudio.Classes.FileTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PckStudio
{
    public partial class addMeta : MetroFramework.Forms.MetroForm
    {

        public string PropertyName => textBox1.Text;
        public string PropertyValue => textBox2.Text;

        public addMeta(string name, string value)
        {
            InitializeComponent();
            textBox1.Text = name;
            textBox2.Text = value;
        }

        public addMeta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // Drag panel
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}