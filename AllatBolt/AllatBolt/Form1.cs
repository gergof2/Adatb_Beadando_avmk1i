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
            rekords_AllatokList = new List<Allatok>();
            bgWorker = new BackgroundWorker();
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            int ToroltSorok = 0;
            foreach(DataGridViewRow selectedRows in dgv_allatok.SelectedRows)
            {
                Allatok TorlendoRekord = new Allatok();
                TorlendoRekord.Allat_id = selectedRows.Cells["idszam"].Value.ToString();

                ToroltSorok += tablaManager.Delete(TorlendoRekord);
            }

            MessageBox.Show(string.Format("{0} sor lett törölve!", ToroltSorok));
            if (ToroltSorok != 0)
                bgWorker.RunWorkerAsync();
        }

        private void b_insert_Click(object sender, EventArgs e)
        {
            Allatok allat = new Allatok()
            {
                Allat_id = tb_id.Text,
                Faj = tb_faj.Text,
                Nem = cb_nem.SelectedItem.ToString(),
                Etkezes = cb_etkezes.SelectedItem.ToString(),
                Ar = int.Parse(tb_ar.Text),
                Bolt = tb_bolt.Text
            };

            tablaManager.Insert(allat);
            bgWorker.RunWorkerAsync();

            MessageBox.Show("Sikeres feltöltés!");
            tb_id.Clear();
            tb_faj.Clear();
            tb_ar.Clear();
            tb_bolt.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bgWorker.WorkerSupportsCancellation = true;
            cb_nem.DataSource = Enum.GetValues(typeof(Nem));
            cb_etkezes.DataSource = Enum.GetValues(typeof(Etkezes));

            InitDataGridView();
        }

        private void InitDataGridView()
        {
            dgv_allatok.Rows.Clear();
            dgv_allatok.Columns.Clear();
            var allat = this.rekords_AllatokList;
            dgv_allatok.DataSource = allat;

            //DataGridViewColumn IdColumn = new DataGridViewColumn()
            //{
            //    Name = "id",
            //    HeaderText = "ID",
            //    Visible = true,
            //    AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            //};
            //dgv_allatok.Columns.Add(IdColumn);
            //
            //DataGridViewColumn FajColumn = new DataGridViewColumn()
            //{
            //    Name = "faj",
            //    HeaderText = "Faj",
            //    Visible = true,
            //    AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            //};
            //dgv_allatok.Columns.Add(FajColumn);
            //
            //DataGridViewColumn NemColumn = new DataGridViewColumn()
            //{
            //    Name = "nem",
            //    HeaderText = "Nem",
            //    Visible = true,
            //    AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            //};
            //dgv_allatok.Columns.Add(NemColumn);
            //
            //DataGridViewColumn EtkezesColumn = new DataGridViewColumn()
            //{
            //    Name = "etkezes",
            //    HeaderText = "Étkezés",
            //    Visible = true,
            //    AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            //};
            //dgv_allatok.Columns.Add(EtkezesColumn);
            //
            //DataGridViewColumn ArColumn = new DataGridViewColumn()
            //{
            //    Name = "ar",
            //    HeaderText = "Ár",
            //    Visible = true,
            //    AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            //};
            //dgv_allatok.Columns.Add(ArColumn);
            //
            //DataGridViewColumn BoltColumn = new DataGridViewColumn()
            //{
            //    Name = "bolt",
            //    HeaderText = "Bolt",
            //    Visible = true,
            //    AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            //};
            //dgv_allatok.Columns.Add(BoltColumn);
        }


        private void BgWorker_RunWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            FillDataGridView();
        }

        private void BgWorekr_DoWork(object sender, DoWorkEventArgs e)
        {
            rekords_AllatokList = tablaManager.Select();
        }

        private void FillDataGridView()
        {
            DataGridViewRow[] dataGridViewRows = new DataGridViewRow[rekords_AllatokList.Count];

            for(int i = 0; i< rekords_AllatokList.Count; i++)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();

                DataGridViewCell IdCell = new DataGridViewTextBoxCell();
                IdCell.Value = rekords_AllatokList[i].Allat_id;
                dataGridViewRow.Cells.Add(IdCell);

                DataGridViewCell BoltCell = new DataGridViewTextBoxCell();
                BoltCell.Value = rekords_AllatokList[i].Bolt;
                dataGridViewRow.Cells.Add(BoltCell);

                DataGridViewCell NemCell = new DataGridViewTextBoxCell();
                NemCell.Value = rekords_AllatokList[i].Nem;
                dataGridViewRow.Cells.Add(NemCell);

                dataGridViewRows[i] = dataGridViewRow;
            }
            dgv_allatok.Rows.Clear();
            dgv_allatok.Rows.AddRange(dataGridViewRows);
        }

        private void tb_id_Leave(object sender, EventArgs e)
        {
            string actual = tb_id.Text;
            bool Correct = tablaManager.CheckIdszam(actual);
            tb_id.BackColor = Correct ? Color.White : Color.Red;
        }
    }
}
