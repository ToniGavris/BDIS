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
        OracleConnection connection;
        OracleCommand comanda;
        OracleCommandBuilder comand;
        OracleDataAdapter da, da1, da2, da3, da4;
        DataSet ds, ds1, ds2, ds3, ds4;
        double[] numbers = new double[13];
        string str, str1, str2, str3,strSql;

        private void txtCautareCons_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAfisareCons_Click(object sender, EventArgs e)
        {
            try
            {
                str1 = "Select * from CONSULTATII";
                da1 = new OracleDataAdapter(str1, connection);
                ds1 = new DataSet();
                da1.Fill(ds1, "CONSULTATII");
                dataGridView2.DataSource = ds1.Tables["CONSULTATII"];
                comand = new OracleCommandBuilder(da1);
                txtCautareCons.Text = "";
                label2.Text = "";
            }
            catch(OracleException ex)
            {
                label2.Text = "Eroare" + ex.Message.ToString();
            }

            txtCautareCons.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                str2 = "Select * from VEDERE where CNP = " + "'" + textBox1.Text + "'";
                da2 = new OracleDataAdapter(str2, connection);
                ds2 = new DataSet();
                da2.Fill(ds2, "vedere");
                dataGridView3.DataSource = ds2.Tables["vedere"];
                
            }
            catch (OracleException ex)
            {
                label4.Text = "Eroare" + ex.Message.ToString();
            }

            CrystalReport1 raport = new CrystalReport1();
            raport.SetDataSource(ds2.Tables["vedere"]);
            crystalReportViewer1.ReportSource = raport;
        }

        private void btnCautareAfectiune_Click(object sender, EventArgs e)
        {
            try
            {
                str3 = "Select * from AFECTIUNI where diagnostic = " + "'" + txtCautareAfectiune.Text + "'";
                da3 = new OracleDataAdapter(str3, connection);
                ds3 = new DataSet();
                da3.Fill(ds3, "AFECTIUNI");
                dataGridView4.DataSource = ds3.Tables["AFECTIUNI"];
            }
            catch (OracleException ex)
            {
                label6.Text = "Eroare" + ex.Message.ToString();
            }

            CrystalReport2 raport2 = new CrystalReport2();
            raport2.SetDataSource(ds3.Tables["AFECTIUNI"]);
            crystalReportViewer2.ReportSource = raport2;
        }

        private void btnCautareCons_Click(object sender, EventArgs e)
        {
            try
            {
                str1 = "Select * from CONSULTATII where CNP = " + "'" + txtCautareCons.Text + "'";
                da1 = new OracleDataAdapter(str1, connection);
                ds1 = new DataSet();
                da1.Fill(ds1, "CONSULTATII");
                dataGridView2.DataSource = ds1.Tables["CONSULTATII"];
            }
            catch (OracleException ex)
            {
                label2.Text = "Eroare" + ex.Message.ToString();
            }
        }

        private void btnAfisarePacienti_Click(object sender, EventArgs e)
        {
            try
            {
                str = "Select * from Pacienti";
                da = new OracleDataAdapter(str, connection);
                ds = new DataSet();
                da.Fill(ds, "PACIENTI");
                dataGridView1.DataSource = ds.Tables["PACIENTI"];
                comand = new OracleCommandBuilder(da);
                txtCautare.Text = "";
                label1.Text = "";
            }
            catch(OracleException ex)
            {
                label1.Text = "Eroare" + ex.Message.ToString();
            }

            try
            {
                str1 = "Select * from CONSULTATII";
                da1 = new OracleDataAdapter(str1, connection);
                ds1 = new DataSet();
                da1.Fill(ds1, "CONSULTATII");
                dataGridView2.DataSource = ds1.Tables["CONSULTATII"];
                comand = new OracleCommandBuilder(da1);
                txtCautareCons.Text = "";
                label2.Text = "";
            }
            catch (OracleException ex)
            {
                label2.Text = "Eroare" + ex.Message.ToString();
            }

            txtCautare.Text = "";
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            label1.Text = "Date gresite";
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            label2.Text = "Date gresite";
            
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            str2 = "Select * from VEDERE";
            da2 = new OracleDataAdapter(str2, connection);
            ds2 = new DataSet();
            da2.Fill(ds2, "VEDERE");
            dataGridView3.DataSource = ds2.Tables["VEDERE"];
            comand = new OracleCommandBuilder(da2);
            textBox1.Text = "";
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            str3 = "Select * from AFECTIUNI";
            da3 = new OracleDataAdapter(str3, connection);
            ds3 = new DataSet();
            da3.Fill(ds3, "AFECTIUNI");
            dataGridView4.DataSource = ds3.Tables["AFECTIUNI"];
            comand = new OracleCommandBuilder(da3);
            txtCautareAfectiune.Text = "";
        }

        private void btnPieChart_Click(object sender, EventArgs e)
        {
            strSql = "Select count(cnp) from pacienti";
            comanda = new OracleCommand(strSql, connection);
            comanda.Connection.Open();
            int numaru = Convert.ToInt32(comanda.ExecuteScalar());
            strSql = "Select count(nr_consultatie) from consultatii";
            comanda = new OracleCommand(strSql, connection);
            int numaru2 = Convert.ToInt32(comanda.ExecuteScalar());
            strSql = "Select count(diagnostic) from consultatii where diagnostic = 'luxatie'";
            comanda = new OracleCommand(strSql, connection);
            int numaru3 = Convert.ToInt32(comanda.ExecuteScalar());
            float total = numaru + numaru2+ numaru3;
            float deg1 = (numaru / total) * 360;
            float deg2 = (numaru2 / total) * 360;
            float deg3 = (numaru3 / total) * 360;
            Graphics graphics = pictureBox1.CreateGraphics();
            Rectangle rect = new Rectangle(10, 10, 150, 150);
            Brush brush1 = new SolidBrush(Color.Red);
            Brush brush2 = new SolidBrush(Color.Blue);
            Brush brush3 = new SolidBrush(Color.Yellow);
            graphics.Clear(pictureBox1.BackColor);
            graphics.FillPie(brush1, rect, 0, deg1);
            graphics.FillPie(brush2, rect, deg1, deg2);
            graphics.FillPie(brush3, rect, deg1+deg2, deg3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pACIENTIBindingSource.CancelEdit();
            ds.RejectChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cONSULTATIIBindingSource1.CancelEdit();
            ds1.RejectChanges();
        }

        private void btnModCons_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommandBuilder comanda = new OracleCommandBuilder(da1);
                da1.Update(ds1.Tables["CONSULTATII"]);
                label2.Text = "Date medificate!";
            }
            catch (OracleException ex)
            {
                label2.Text = "Eroare" + ex.Message.ToString();
            }
        }

        private void btnAdaugareCons_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommandBuilder comanda = new OracleCommandBuilder(da1);
                da1.Update(ds1.Tables["CONSULTATII"]);
                label2.Text = "Consultatie adaugata cu succes";
            }
            catch (OracleException ex)
            {
                label2.Text = "Eroare" + ex.Message.ToString();
            }
        }

        private void btnStergeCons_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Doriti sa stergeti aceasta consultatie?", "Stergere", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (ds1.Tables["CONSULTATII"].Rows.Count > 0)
                    {
                        int rownum = (dataGridView2.CurrentCell.RowIndex);
                        DataRow Linie = ds1.Tables["CONSULTATII"].Rows[rownum];
                        Linie.Delete();
                        OracleCommandBuilder comanda = new OracleCommandBuilder(da1);
                        da1.Update(ds1.Tables["CONSULTATII"]);
                        label2.Text = "Stergere efectuata cu succes!";
                    }
                }
            }
            catch (OracleException ex)
            {
                label2.Text = "Eroare" + ex.Message.ToString();
            }
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            try
            {
                str = "Select * from PACIENTI where CNP = " + "'" + txtCautare.Text + "'";
                da = new OracleDataAdapter(str, connection);
                ds = new DataSet();
                da.Fill(ds, "PACIENTI");
                dataGridView1.DataSource = ds.Tables["PACIENTI"];
                comand = new OracleCommandBuilder(da);                       
            }
            catch (OracleException ex)
            {
                label1.Text = "Eroare" + ex.Message.ToString();
            }

            try
            {
                str1 = "Select * from CONSULTATII where CNP = " + "'" + txtCautare.Text + "'";
                da1 = new OracleDataAdapter(str1, connection);
                ds1 = new DataSet();
                da1.Fill(ds1, "CONSULTATII");
                dataGridView2.DataSource = ds1.Tables["CONSULTATII"];
            }
            catch (OracleException ex)
            {
                label2.Text = "Eroare" + ex.Message.ToString();
            }

        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommandBuilder comanda = new OracleCommandBuilder(da);
                da.Update(ds.Tables["PACIENTI"]);
                label1.Text = "Date medificate!";
            }
            catch (OracleException ex)
            {
                label1.Text = "Eroare" + ex.Message.ToString();
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Doriti sa stergeti acest pacient?", "Stergere", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (ds.Tables["PACIENTI"].Rows.Count > 0)
                    {
                        int rownum = (dataGridView1.CurrentCell.RowIndex);
                        DataRow Linie = ds.Tables["PACIENTI"].Rows[rownum];
                        Linie.Delete();
                        OracleCommandBuilder comanda = new OracleCommandBuilder(da);
                        da.Update(ds.Tables["PACIENTI"]);
                        label1.Text = "Stergere efectuata cu succes!";
                    }
                }
            }
            catch (OracleException ex)
            {
                label1.Text = "Eroare" + ex.Message.ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.cONSULTATIITableAdapter1.Fill(this.dataSet9.CONSULTATII);
            this.aFECTIUNITableAdapter.Fill(this.dataSet7.AFECTIUNI);
            this.vEDERETableAdapter.Fill(this.dataSet6.VEDERE);
            this.pACIENTITableAdapter.Fill(this.dataSet4.PACIENTI);
            this.pACIENTITableAdapter.Fill(this.dataSet4.PACIENTI);

            connection = new OracleConnection("DATA SOURCE=localhost:1521/XE;PASSWORD=student;PERSIST SECURITY INFO=True;USER ID=STUDENT");

            str = "Select * from Pacienti";
            da = new OracleDataAdapter(str, connection);
            ds = new DataSet();
            da.Fill(ds, "PACIENTI");
            dataGridView1.DataSource = ds.Tables["PACIENTI"];
            comand = new OracleCommandBuilder(da);

            str1 = "Select * from CONSULTATII";
            da1 = new OracleDataAdapter(str1, connection);
            ds1 = new DataSet();
            da1.Fill(ds1, "CONSULTATII");
            dataGridView2.DataSource = ds1.Tables["CONSULTATII"];
            comand = new OracleCommandBuilder(da1);

            str2 = "Select * from VEDERE";
            da2 = new OracleDataAdapter(str2, connection);
            ds2 = new DataSet();
            da2.Fill(ds2, "VEDERE");
            dataGridView3.DataSource = ds2.Tables["VEDERE"];
            comand = new OracleCommandBuilder(da2);

            str3 = "Select * from AFECTIUNI";
            da3 = new OracleDataAdapter(str3, connection);
            ds3 = new DataSet();
            da3.Fill(ds3, "AFECTIUNI");
            dataGridView4.DataSource = ds3.Tables["AFECTIUNI"];
            comand = new OracleCommandBuilder(da3);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdaugaPacient_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommandBuilder comanda = new OracleCommandBuilder(da);
                da.Update(ds.Tables["PACIENTI"]);
                label1.Text = "Pacient adaugat cu succes";
            }
            catch (OracleException ex)
            {
                label1.Text = "Eroare" + ex.Message.ToString();
            }
        }
    }
}
