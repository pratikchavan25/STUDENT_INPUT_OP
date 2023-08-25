using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace STUDENT_INPUT_OP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-1-AUG\Student.dat";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter binaryWriter = new BinaryWriter(fileStream);
                binaryWriter.Write(Convert.ToInt32(txtrollnumber.Text));
                binaryWriter.Write(txtname.Text);
                binaryWriter.Write(Convert.ToDouble(txtpercentage.Text));
                binaryWriter.Close();
                fileStream.Close();
                MessageBox.Show("Student added sucessfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-1-AUG\Student.dat";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                txtrollnumber.Text = binaryReader.ReadInt32().ToString();
                txtname.Text = binaryReader.ReadString();
                txtpercentage.Text = binaryReader.ReadDouble().ToString();
                binaryReader.Close();
                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
