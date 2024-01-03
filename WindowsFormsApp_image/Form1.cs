using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApp_image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Image image= Image.FromFile("im.jpg");
            label1.AutoSize= false;
            label1.Size = new Size(image.Width,image.Height);
            label1.Image = image;
            wplayer.URL = "Jingle-Bells.mp3";
            wplayer.controls.play();
        }
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
    }
}
