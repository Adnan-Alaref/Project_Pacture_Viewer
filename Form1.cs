using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Timers;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace ProjectPactureViewer1
{
    public partial class Form1 : Form
    {
        public Form1(){InitializeComponent();}
        private void Form1_Load(object sender, EventArgs e){}
        Dictionary<string, string> DictioaryOfPath = new Dictionary<string, string>();
        private void Function_Clear()
        {
            panelImages.Controls.Clear();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            /* to make size of images(Memory Freeloader) fixed in task manager*/
        }
        private void ButtonOfChooseImages_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OpenFile = new OpenFileDialog();
                OpenFile.Title = " Choose Image..!";
                OpenFile.Filter = "PNG & JPG Images|*.png;*.jpg|RAW Images|*.RAW|DNG Images|*.DNG|GIF Images|*.gif|BMP Images|*.BMP|TIFF Images|*.TIFF|JPEG Images|*.jpeg|All Extetions|*.*";
                OpenFile.Multiselect = true;
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    foreach (string str in OpenFile.FileNames)
                    {
                        string _cheack=Path.GetFileName(str);
                        if (ListBoxOfImages.Items.Contains(_cheack)==false)
                        {
                            ListBoxOfImages.Items.Add(_cheack);
                            DictioaryOfPath[Path.GetFileName(str)]=str;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You Don't Choose Images...!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "My Message");
            }
        }
        private void buttonSingle_Click(object sender, EventArgs e)
        {
            try
            {
                Function_Clear();
                statusBar1.Panels[0].Text = "";
                if (ListBoxOfImages.SelectedItems.Count > 1)
                {
                    MessageBox.Show("You can't choose more one image..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else if (ListBoxOfImages.SelectedItems.Count == 0)
                {
                    MessageBox.Show("You didn't choose any image ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    PictureBox pic = new PictureBox();
                    pic.Location = new Point(0, 0);
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Size = new Size(panelImages.Width, panelImages.Height);
                    panelImages.Controls.Add(pic);
                    string str = DictioaryOfPath[ListBoxOfImages.SelectedItem.ToString()];
                    pic.Image = Image.FromFile(str);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            try
            {
                Function_Clear();
                statusBar1.Panels[0].Text = "";
                if (ListBoxOfImages.SelectedItems.Count == 0)
                {
                    MessageBox.Show("You didn't choose any image ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    int myTop = 10;
                    int myLeft = 11;
                    foreach (string str in ListBoxOfImages.SelectedItems)
                    {
                        PictureBox pic = new PictureBox();
                        pic.Size = new Size(310, 310);
                        pic.BorderStyle = BorderStyle.Fixed3D;
                        pic.Location = new Point(myLeft, myTop);
                        myLeft += 321;
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        panelImages.Controls.Add(pic);
                        if (myLeft >= 1290)
                        {
                            myLeft = 11;
                            myTop += 320;
                        }
                        pic.Image = Image.FromFile(DictioaryOfPath[str]);
                    }
                }     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void buttonSlide_Click(object sender, EventArgs e)
        {
           try
           {
                Function_Clear();
                button3.Enabled = false;
                buttonSlide.Enabled = false;
                buttonMulti.Enabled = false;
                buttonSingle.Enabled = false;
                ButtonOfChooseImages.Enabled = false;
                contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[1].Enabled = false;
                contextMenuStrip1.Items[2].Enabled = false;
                contextMenuStrip1.Items[3].Enabled = false;
                contextMenuStrip1.Items[4].Enabled = false;
                if (ListBoxOfImages.SelectedItems.Count == 0)
                {
                    MessageBox.Show("You didn't choose any image ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    PictureBox pic = new PictureBox();
                    panelImages.Controls.Add(pic);
                    pic.Location = new Point(0, 0);
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Size = new Size(panelImages.Width, panelImages.Height);
                    foreach (string str in ListBoxOfImages.SelectedItems)
                    {
                        pic.Image = Image.FromFile(DictioaryOfPath[str]);
                        statusBar1.Panels[0].Text = str;
                        Application.DoEvents();
                        Thread.Sleep(100);
                    }
                }
                button3.Enabled = true;
                buttonSlide.Enabled = true;
                buttonMulti.Enabled = true;
                buttonSingle.Enabled = true;
                ButtonOfChooseImages.Enabled = true;
                contextMenuStrip1.Items[0].Enabled = true;
                contextMenuStrip1.Items[1].Enabled = true;
                contextMenuStrip1.Items[2].Enabled = true;
                contextMenuStrip1.Items[3].Enabled = true;
                contextMenuStrip1.Items[4].Enabled = true;
           }
           catch (Exception ex){
              MessageBox.Show(ex.Message, "Exception");
           }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                dr = MessageBox.Show("Are you need to exit from program..?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }
    }
}
