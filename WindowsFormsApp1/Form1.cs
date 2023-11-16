using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int children;
        string placement;
        string name;
        string surname;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;
            btnCalculate.Visible = false;

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            try
            {
                //variables
                int therapyLvl = 0;
                placement = null;
                string relation = null;
                name = txtName.Text;
                surname = txtSurname.Text;
                children = int.Parse(txtNumKids.Text);

                if(children > 4 || children < 0)
                {
                    MessageBox.Show("Unfortunately We cannot assist victims with more than 4 children");
                }
                else
                {
                   

                    //therapy level
                    if(radioNo.Checked)
                    {
                        therapyLvl = 1;
                    }
                    else if(radioYesOnce.Checked)
                    {
                        therapyLvl = 2;
                    }
                    else if(radioYesMore.Checked)
                    {
                        therapyLvl = 3;
                    }
                    else
                    {
                        MessageBox.Show("Please Select One of the radio buttons");
                        radioNo.Focus();
                    }

                    if (therapyLvl != 0)//the therapy level will not be 0 if one of the radio buttons were checked
                    {
                        //data validation is successful
                        btnCalculate.Visible = true;

                        //use only the name since the safehome is common on all placements i will concatenate it after assigning
                        switch (children)
                        {
                            case 0:
                            case 1:
                                placement = "Omgee";
                                break;
                            case 2:
                                placement = "Lovely";
                                break;
                            case 3:
                                placement = "Lerato";
                                break;
                            case 4:
                                placement = "Family";
                                break;
                            default:
                                break;
                        }
                        placement += " SafeHome";//concatenate it with SafeHome
                        relation = lstRelation.SelectedItem.ToString();
                        //output
                        lstOutput.Items.Add("Victim information for " + name + " " + surname + " Abused by her " + relation + " has been captured");
                        lstOutput.Items.Add("Allocated safehouse: " + placement + " The allocated therapy level is: " + therapyLvl + ". This is confirmed for Victim and:");

                        for(int i = 1; i <=  children; i++)
                        {
                            lstOutput.Items.Add("Child number: " + i);
                        }

                    }
               
                }
            }
            catch(Exception)
            {
                MessageBox.Show("You have entered incorrect data\nMore info\n");

            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //calculate the cost
            int children = int.Parse(txtNumKids.Text);
            
            Form2 form = new Form2();
            form.label2.Text = "Abafazi wethu will pay "+(form.GovGrant(children)).ToString("c") + " for "+ name + " " + surname + " to stay at " + placement;
            form.ShowDialog();
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSurname.Clear();
            txtNumKids.Clear();
            lstOutput.Items.Clear();
            lstRelation.SelectedIndex = -1;
            txtName.Focus();
            radioNo.Checked = false;
            radioYesMore.Checked = false;
            radioYesOnce.Checked = false;
        }
    }
}
