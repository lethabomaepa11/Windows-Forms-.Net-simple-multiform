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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int BASIC_GRANT = 9850;
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public int GovGrant(int children)
        {
            int cost = 0;
            switch (children)
            {
                case 0:
                    cost = BASIC_GRANT;
                    break;
                case 1:
                case 2:
                    cost = BASIC_GRANT + (4700 * children);
                    break;
                case 3:
                case 4:
                    cost = BASIC_GRANT + (3500 * children);
                    break;
                default:
                    break;

            }
            return cost;
        }
        void SaveToFile(string message)
        {
            StreamWriter outfile;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outfile = File.AppendText(saveFileDialog1.FileName);
                outfile.WriteLine(message);
                outfile.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Closing...");
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveToFile(label2.Text);
        }
    }
}
