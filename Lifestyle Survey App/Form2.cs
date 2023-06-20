using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Boolean checkers = true;
            try
            {
                while(checkers == true)
                {
                    // text boxes
                    //Surnames -1
                    if (tb_Surname.TextLength < 1 || tb_Surname.TextLength==0)
                    {
                        checkers = false;
                    }
                    else
                    {
                        tb_Surname.Text = "ERROR";
                    }

                    //Names -2
                    if (tb_Names.TextLength < 0 || tb_Names.TextLength==0)
                    {
                        checkers = false;
                    }
                    else
                    {
                        tb_Names.Text = "ERROR";
                    }

                    //Contact Numbers -3
                    if (tb_Numbers.TextLength < 1 || tb_Numbers.TextLength == 0)
                    {
                        checkers = false;
                    }
                    else
                    {
                        tb_Numbers.Text = "ERROR";
                    }

                    //Dates -4
                    if (tb_Dates.TextLength < 1 || tb_Dates.TextLength == 0)
                    {
                        checkers = false;
                    }
                    else
                    {
                        String idate = tb_Dates.Text;
                        DateTime pdate;
                        if(DateTime.TryParseExact(idate,"dd-MM",CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out pdate))
                        {
                            pdate.ToString("dd-MM-yyyy");
                        }
                    }

                    //Age -5
                    if (tb_Age.TextLength < 1 || tb_Age.TextLength==0)
                    {
                        checkers = false;
                    }
                    else
                    {
                        age.Text = "ERROR";
                    }

                    //radio buttons
                    RadioButton picked = (RadioButton)sender;
                    // pick food out of 6 pizza, pasta, pap and wors, Chicken Stir Fry, Beef Stir fry, other
                    List <String> foods= new List<string> ();

                    if (rb_Pizza.Checked)//1
                    {
                        foods.Add("Pizza")  ;
                    }
                    if (rb_Pasta.Checked)//2
                    {
                        foods.Add("Pasta");
                    }
                    if (rb_PapWors.Checked)//3
                    {
                        foods.Add("Pap and Wors");
                    }
                    if (rb_Chicken.Checked)//4
                    {
                        foods.Add("Chicken Stir Fry");
                    }
                    if (rb_Beef.Checked)//5
                    {
                        foods.Add("Beef Stir Fry");
                    }
                    if (rb_Other.Checked)//6
                    {
                        foods.Add("Other");
                    }
                    //Eatout 1-5 Radio Button
                    if (picked.Checked)
                    {
                        if(picked == rb_EatOut_1)
                        {
                        } else if(picked == rb_EatOut_2)
                        {
                        }
                        else if (picked == rb_EatOut_3)
                        {
                        }
                        else if (picked == rb_EatOut_4)
                        {
                        }
                        else if (picked == rb_EatOut_5)
                        {
                        }
                    }
                    //Movies 1-5 Radio Button
                    if (picked.Checked)
                    {
                        if (picked == rb_Movies_1)
                        {
                        }
                        else if (picked == rb_Movies_2)
                        {
                        }
                        else if (picked == rb_Movies_3)
                        {
                        }
                        else if (picked == rb_Movies_4)
                        {
                        }
                        else if (picked == rb_Movies_5)
                        {
                        }
                    }
                    //TV 1-5 Radio Button
                    if (picked.Checked)
                    {
                        if (picked == rb_TV_1)
                        {
                        }
                        else if (picked == rb_TV_2)
                        {
                        }
                        else if (picked == rb_TV_3)
                        {
                        }
                        else if (picked == rb_TV_4)
                        {
                        }
                        else if (picked == rb_TV_5)
                        {
                        }
                    }
                    //Radio 1-5 Radio Button
                    if (picked.Checked)
                    {
                        if (picked == rb_Radio_1)
                        {
                        }
                        else if (picked == rb_Radio_2)
                        {
                        }
                        else if (picked == rb_Radio_3)
                        {
                        }
                        else if (picked == rb_Radio_4)
                        {
                        }
                        else if (picked == rb_Radio_5)
                        {
                        }
                    }

                }
                
            }
            catch (Exception )
            {
                tb_Surname.Text = "Error";
            }
           
            Form3 obj3 = new Form3();
            obj3.Show();
            this.Visible = false;
        }

        private void rb_EatOut_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_Movies_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_TV_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rb_Radio_4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
