using AllatBolt.Models.Manager;
using AllatBolt.Models.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace AllatBolt
{
    public partial class Form1 : Form
    {
        AllatokTabla tablaManager;
        List<Allatok> rekords_AllatokList;
        BackgroundWorker bgWorker;
        public Form1()
        {
            InitializeComponent();
            tablaManager = new AllatokTabla();
            rekords_AllatokList = tablaManager.Select();
            bgWorker = new BackgroundWorker();
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            int ToroltSorok = 0;
            foreach(DataGridViewRow selectedRows in dgv_allatok.SelectedRows)
            {
                Allatok TorlendoRekord = new Allatok();
                TorlendoRekord.idszam = selectedRows.Cells["idszam"].Value.ToString();

                ToroltSorok += tablaManager.Delete(TorlendoRekord);
            }

            MessageBox.Show(string.Format("{0} sor lett törölve!", ToroltSorok));
            if (ToroltSorok != 0)
                bgWorker.RunWorkerAsync();
            UpdateDgv_allatok();
        }

        private void b_insert_Click(object sender, EventArgs e)
        {
            try
            {
                Allatok allat = new Allatok();
                allat.idszam = tb_id.Text.ToString();
                allat.faj = tb_faj.Text.ToString();
                allat.nem = cb_nem.SelectedItem.ToString();
                allat.etkezes = cb_etkezes.SelectedItem.ToString();
                allat.ar = tb_ar.Text.ToString();
                allat.bolt_id = int.Parse(tb_bolt.Text);

                tablaManager.Insert(allat);
                bgWorker.RunWorkerAsync();

                MessageBox.Show("Sikeres feltöltés!");
                UpdateDgv_allatok();
                tb_id.Clear();
                tb_faj.Clear();
                tb_ar.Clear();
                tb_bolt.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      


        private void Form1_Load(object sender, EventArgs e)
        {
            bgWorker.WorkerSupportsCancellation = true;
            cb_nem.DataSource = Enum.GetValues(typeof(Nem));
            cb_etkezes.DataSource = Enum.GetValues(typeof(Etkezes));
            
            InitDataGridView();
            UpdateDgv_allatok();
        }

        private void FillDataGridView()
        {
            DataGridViewRow[] dataGridViewRows = new DataGridViewRow[rekords_AllatokList.Count];

            for (int i = 0; i < rekords_AllatokList.Count; i++)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();

                DataGridViewCell IdCell = new DataGridViewTextBoxCell();
                IdCell.Value = rekords_AllatokList[i].idszam;
                dataGridViewRow.Cells.Add(IdCell);

                DataGridViewCell FajCell = new DataGridViewTextBoxCell();
                FajCell.Value = rekords_AllatokList[i].faj;
                dataGridViewRow.Cells.Add(FajCell);

                DataGridViewCell NemCell = new DataGridViewTextBoxCell();
                NemCell.Value = rekords_AllatokList[i].nem;
                dataGridViewRow.Cells.Add(NemCell);

                DataGridViewCell EtkezesCell = new DataGridViewTextBoxCell();
                EtkezesCell.Value = rekords_AllatokList[i].etkezes;
                dataGridViewRow.Cells.Add(EtkezesCell);

                DataGridViewCell ArCell = new DataGridViewTextBoxCell();
                ArCell.Value = rekords_AllatokList[i].ar;
                dataGridViewRow.Cells.Add(ArCell);

                DataGridViewCell BoltCell = new DataGridViewTextBoxCell();
                BoltCell.Value = rekords_AllatokList[i].bolt_id;
                dataGridViewRow.Cells.Add(BoltCell);


                dataGridViewRows[i] = dataGridViewRow;
            }
            dgv_allatok.Rows.AddRange(dataGridViewRows);
        }

        private void InitDataGridView()
        {
            dgv_allatok.Columns.Clear();
            dgv_allatok.Rows.Clear();
            dgv_allatok.AutoGenerateColumns = false;
            dgv_allatok.Columns.Add("idszam", "Azonosító");
            dgv_allatok.Columns.Add("faj", "Faj");
            dgv_allatok.Columns.Add("nem", "Neme");
            dgv_allatok.Columns.Add("etkezes", "Mit eszik?");
            dgv_allatok.Columns.Add("ar", "Ár");
            dgv_allatok.Columns.Add("id", "Bolt ID");
        }


        private void BgWorker_RunWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            FillDataGridView();
        }

        private void BgWorekr_DoWork(object sender, DoWorkEventArgs e)
        {
            rekords_AllatokList = tablaManager.Select();
        }



        private void tb_id_Leave(object sender, EventArgs e)
        {
            string actual = tb_id.Text;
            bool Correct = tablaManager.CheckIdszam(actual);
            tb_id.BackColor = Correct ? Color.White : Color.Red;
        }

        public void UpdateDgv_allatok()
        {
            dgv_allatok.Rows.Clear();
            AllatokTabla allatokTabla = new AllatokTabla();
            foreach(Allatok a in allatokTabla.Select())
            {
                dgv_allatok.Rows.Add(new object[]
                {
                    a.idszam,
                    a.faj,
                    a.nem,
                    a.etkezes,
                    a.ar,
                    a.bolt_id
                });
            }
        }

        private void b_frissit_Click(object sender, EventArgs e)
        {
            UpdateDgv_allatok();
        }

        private void b_boltok_Click(object sender, EventArgs e)
        {
            Bolt bolt = new Bolt();
            bolt.ShowDialog();
        }
    }
}
