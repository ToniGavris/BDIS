using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form1 : Form
    {
        OracleConnection connection = new OracleConnection("DATA SOURCE=localhost:1521/XE;PASSWORD=student;PERSIST SECURITY INFO=True;USER ID=STUDENT");
        OracleCommand comand;
        OracleDataAdapter da, da1, da2, da3;
        DataSet ds, ds1, ds2, ds3;
        string str, str1, str2, str3, newYear,strSql;
        string dbMonth;
        string dbYear;
        string dbDay;
        double cnp;
        int anul, luna, zi, sex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pACIENTITableAdapter.Fill(this.dataSet1.PACIENTI); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pacientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dataGridView1.Visible = true;
        }

        private void btnAdaugaPacient_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            string cnpPacient = textCNPPacient.Text;
            getDBDate(cnpPacient);
            string adresa = textAdresa.Text;
            DateTime today = DateTime.Today;
            DateTime birthDay = DateTime.Today;
            //DateTime birthDay = dateTimePicker1.Value;
            double day = (today - birthDay).TotalDays;
            int varsta = Convert.ToInt16(day) / 365;
            string dbDate = dbDay + "-" + dbMonth + "-" + dbYear;
            try
            {
                connection.Open();
                strSql = "Insert into pacienti values(" + cnpPacient + ",'" +
                    adresa + "','" + dbDate + "'," + varsta + ")" ;
                comand = new OracleCommand(strSql, connection);
                comand.ExecuteNonQuery();
                textCNPPacient.Clear();
                textAdresa.Clear();
                this.dataGridView1.Update();
                this.dataGridView1.Refresh();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void putTextFieldsOnVisible(TextBox text1, TextBox text2, TextBox text3, TextBox text4)
        {
            text1.Visible = true;
            text2.Visible = true;
            text3.Visible = true;
            text4.Visible = true;
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            putTextFieldsOnVisible(textCNPPacient, textAdresa,textDataNasterii, textVarsta);
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            btnAdaugaPacient.Visible = true;
        }

        private void textCNPPacient_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch!=8)
            {
                e.Handled = true;
            }
        }

        private void getDBDate(string luna)
        {
            //double partialCnp = Convert.ToInt64(cnp) / 100000000;
            //double partialForDay = Convert.ToInt64(cnp) / 1000000;
            //double month = partialCnp % 100;
            //dbYear = (Convert.ToInt16(partialCnp % 10000)/100).ToString();
           // dbDay = (partialForDay % 10).ToString();
            switch (Convert.ToInt32(luna))
            {
                case 1:
                    dbMonth = "JAN";
                    break;
                case 2:
                    dbMonth = "FEB";
                    break;
                case 3:
                    dbMonth = "MAR";
                    break;
                case 4:
                    dbMonth = "APR";
                    break;
                case 5:
                    dbMonth = "MAY";
                    break;
                case 6:
                    dbMonth = "JUN";
                    break;
                case 7:
                    dbMonth = "JUL";
                    break;
                case 8:
                    dbMonth = "AUG";
                    break;
                case 9:
                    dbMonth = "SEPT";
                    break;
                case 10:
                    dbMonth = "OCT";
                    break;
                case 11:
                    dbMonth = "NOV";
                    break;
                case 12:
                    dbMonth = "DEC";
                    break;
            }
        }

        private void textCNPPacient_TextChanged(object sender, EventArgs e)
        {
            cnp = Convert.ToDouble(textCNPPacient.Text);
            anul = (Convert.ToInt32(cnp / 10000000000)) % 100;
            luna = ((Convert.ToInt32(cnp / 100000000)) % 10000) % 100;
            zi = ((Convert.ToInt32(cnp / 1000000)) % 1000000) % 100;
        }

        private void textCNPPacient_Leave(object sender, EventArgs e)
        {
            cnp = Convert.ToDouble(textCNPPacient.Text);
            sex = Convert.ToInt32(cnp / 1000000000000)-1;
            anul =( Convert.ToInt32(cnp / 10000000000)) % 100;
            luna = ((Convert.ToInt32(cnp / 100000000)) % 10000) % 100;
            zi = ((Convert.ToInt32(cnp / 1000000)) % 1000000) % 100;
            DateTime today = DateTime.Today;
            DateTime birthDay = Convert.ToDateTime("0" + zi + "/0" + luna + "/" + anul);
            double day = (today - birthDay).TotalDays;
            int varsta = Convert.ToInt16(day) / 365;
            getDBDate(luna.ToString());
            determineBirthdayYear(sex, anul.ToString());
            textDataNasterii.Text = zi.ToString() + "/" + dbMonth + "/" + newYear;
            //  textVarsta.Text = varsta.ToString();
            textVarsta.Text = newYear.ToString();
        }
        
        private void determineBirthdayYear(int sex, string an) 
        {
            if(sex == 1 || sex==2)
            {
                newYear = "19" + an;
            }
            else if(sex == 3 || sex == 4)
            {
                newYear = "18" + an;
            }
            else if(sex == 5 || sex == 6)
            {
                newYear = "20" + an;
            }
        }
    }
}
