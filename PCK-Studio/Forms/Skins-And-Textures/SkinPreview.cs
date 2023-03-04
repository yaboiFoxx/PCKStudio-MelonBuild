using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PckStudio.Models;

namespace PckStudio.Forms
{
    public partial class SkinPreview : Form
    {
        Image Texture;
        ModelBase Model;

        public SkinPreview(Image img, ModelBase model = null)
        {
            InitializeComponent();
            Texture = img;
            Model = model ?? new Steve64x32Model(Texture);
        }

        private void SkinPreview_Load(object sender, EventArgs e) => RenderModel(Texture);
        
        public void RenderModel(Image source)
        {
			Model.AddToModelView(ModelView);
		}

        private void button1_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
