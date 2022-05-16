using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Activity14
{
    public partial class ShapeMaker : Form
    {
        // variables for concatenation
        string shape = "";
        string color = "";
        
        string filename = "";

        public ShapeMaker()
        {
            InitializeComponent();
        }

        
        private void btn_display_Click(object sender, EventArgs e) // on button click
        {
            // if radioBtn_white is checked, set color to white
            if (radioBtn_white.Checked)
            {
                color = "white";
            }
            else if (radioBtn_black.Checked)
            {
                color = "black";
            }

            // listBox_Shape selection is set to the shape
            shape = listBox_Shape.SelectedItem.ToString();

            // create the filename
            filename = color + shape + ".png";

            // set pictureBox1 to the filename
            if (!File.Exists(@"C:\Users\Tyson\source\repos\Topic 6\" + filename))
            {
                MessageBox.Show("File does not exist");
            }
            else
            {
                Image image = Image.FromFile(@"C:\Users\Tyson\source\repos\Topic 6\" + filename);
                this.pictureBox1.Image = image;
            }

            // if name checked, label update
            if (checkBox_name.Checked)
            {
                lbl_name.Text = listBox_Shape.SelectedItem.ToString();
            }
            else
            {
                lbl_name.Text = "";
            }

            // if date checked, label update
            if (checkBox_date.Checked)
            {
                lbl_date.Text = DateTime.Now.ToString();
            }
            else
            {
                lbl_date.Text = "";
            }

        }






        
        private void listBox_Shape_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShapeMaker_Load(object sender, EventArgs e)
        {

        }

    }
}
