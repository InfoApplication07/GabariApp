using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GabariApplication
{
    public partial class FrmWaitingList : Form
    {
        


        public FrmWaitingList()
        {
            InitializeComponent();
            ImportDataFromDB();
        }
        DataTable Entree = new DataTable();
        DataTable EnCharge = new DataTable();
        DataTable Sortie = new DataTable();

        void ImportDataFromDB()
        {
            Entree.Columns.Add("Chauffeur");
            Entree.Columns.Add("Matricule");
            Entree.Columns.Add("Client");
            Entree.Columns.Add("Depot");
            Entree.Columns.Add("Mlivraison");
            Entree.Columns.Add("WeightOne");
            Entree.Columns.Add("WeightSeconde");




            DataRow row = Entree.NewRow();
            row[0] = "AMIN1";
            row[1] = "1234";
            row[2] = "SAMI";
            row[3] = "Baraka";
            row[4] = "Expedition";
            row[5] = "98765";
            row[6] = "12342342";

            Entree.Rows.Add(row);


            DataRow row1 = Entree.NewRow();
            row1[0] = "AMIN2";
            row1[1] = "1234";
            row1[2] = "SAMI";
            row1[3] = "Baraka";
            row1[4] = "Expedition";
            row1[5] = "98765";
            row1[6] = "12342342";

            Entree.Rows.Add(row1);


            DataRow row2 = Entree.NewRow();
            row2[0] = "AMIN3";
            row2[1] = "1234";
            row2[2] = "SAMI";
            row2[3] = "Baraka";
            row2[4] = "Expedition";
            row2[5] = "98765";
            row2[6] = "12342342";

            Entree.Rows.Add(row2);

            

           DataRow row4 = Entree.NewRow();
           row4[0] = "AMIN4";
           row4[1] = "1234";
           row4[2] = "SAMI";
           row4[3] = "Baraka";
           row4[4] = "Expedition";
           row4[5] = "98765";
           row4[6] = "12342342";

           Entree.Rows.Add(row4);

            fillDataEntree();

        }

        
        void fillDataEntree()
        {
           
            dataGridView1.DataSource= Entree;
        }

        void fillDataEnCharge()
        {

            dataGridView2.DataSource = EnCharge;
        }
        void fillDataSortie()
        {

            dataGridView3.DataSource = Sortie;
        }

        private void FrmWaitingList_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {



            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            

            //MessageBox.Show(Chaine.Count().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRow row = Entree.NewRow();
            row[0] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            row[1] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            row[2] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            row[3] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            row[4] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            row[5] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            row[6] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            Entree.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            Entree.Rows.InsertAt(row, 0);

            fillDataEntree();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow row = Entree.NewRow();
            row[0] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            row[1] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            row[2] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            row[3] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            row[4] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            row[5] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            row[6] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            Entree.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            Entree.Rows.InsertAt(row,dataGridView1.Rows.Count);
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count-2].Cells[0];
            dataGridView1.Rows[dataGridView1.Rows.Count-2].Selected = true;

            fillDataEntree();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataRow row = Entree.NewRow();
            row[0] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            row[1] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            row[2] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            row[3] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            row[4] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            row[5] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            row[6] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            Entree.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            Entree.Rows.InsertAt(row, dataGridView1.CurrentRow.Index +1);
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[0];
            dataGridView1.Rows[dataGridView1.CurrentRow.Index ].Selected = true;
            fillDataEntree();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataRow row = Entree.NewRow();
            row[0] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            row[1] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            row[2] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            row[3] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            row[4] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            row[5] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            row[6] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            Entree.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            Entree.Rows.InsertAt(row, dataGridView1.CurrentRow.Index - 1);
            //dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index+1].Cells[0];
            //dataGridView1.Rows[dataGridView1.CurrentRow.Index +1].Selected = true;

            fillDataEntree();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //EnCharge.Columns.Clear();

            if (Entree.Rows.Count > 0)
            {

          
            if (int.Parse(textBox2.Text) > 1000)
            {
                if(EnCharge.Columns.Count==0)
                {
                    EnCharge.Columns.Add("Chauffeur");
                    EnCharge.Columns.Add("Matricule");
                    EnCharge.Columns.Add("Client");
                    EnCharge.Columns.Add("Depot");
                    EnCharge.Columns.Add("Mlivraison");
                    EnCharge.Columns.Add("WeightOne");
                    EnCharge.Columns.Add("WeightSeconde");

                }
    
                DataRow row = EnCharge.NewRow();
                row[0] = Entree.Rows[0][0].ToString();
                row[1] = Entree.Rows[0][1].ToString();
                row[2] = Entree.Rows[0][2].ToString();
                row[3] = Entree.Rows[0][3].ToString();
                row[4] = Entree.Rows[0][4].ToString();
                row[5] = textBox2.Text;
                row[6] = "0";
                EnCharge.Rows.Add(row);
                Entree.Rows.RemoveAt(0);
                fillDataEnCharge();
                fillDataEntree();
            }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (EnCharge.Rows.Count > 0)
            {


                if (int.Parse(textBox2.Text) > 1000)
                {
                    if (Sortie.Columns.Count == 0)
                    {
                        Sortie.Columns.Add("Chauffeur");
                        Sortie.Columns.Add("Matricule");
                        Sortie.Columns.Add("Client");
                        Sortie.Columns.Add("Depot");
                        Sortie.Columns.Add("Mlivraison");
                        Sortie.Columns.Add("WeightOne");
                        Sortie.Columns.Add("WeightSeconde");
                        Sortie.Columns.Add("WeightNet");

                    }


                    DataRow row = Sortie.NewRow();
                    row[0] = EnCharge.Rows[0][0].ToString();
                    row[1] = EnCharge.Rows[0][1].ToString();
                    row[2] = EnCharge.Rows[0][2].ToString();
                    row[3] = EnCharge.Rows[0][3].ToString();
                    row[4] = EnCharge.Rows[0][4].ToString();
                    row[5] = EnCharge.Rows[0][5].ToString();
                    row[6] = textBox2.Text;
                    row[7] = (int.Parse(textBox2.Text)-int.Parse(EnCharge.Rows[0][5].ToString())).ToString();
                    Sortie.Rows.Add(row);
                    EnCharge.Rows.RemoveAt(0);
                    fillDataEnCharge();
                    fillDataSortie();

                }
            }
        }
    }
    }

