using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllatBolt.Models.Manager;
using AllatBolt.Models.Records;

namespace AllatBolt
{
    public partial class Bolt : Form
    {
        List<Boltok> rekords_BoltokList;
        AllatokTabla bolttablaManager;
        BackgroundWorker bgWorker;
        public Bolt()
        {
            InitializeComponent();
            bolttablaManager = new AllatokTabla();
            rekords_BoltokList = bolttablaManager.BoltSelect();
            bgWorker = new BackgroundWorker();
        }

        private void Bolt_Load(object sender, EventArgs e)
        {
            bgWorker.WorkerSupportsCancellation = true;
            InDataGridView();
            UpdateDgv_boltok();
        }

        public void UpdateDgv_boltok()
        {
            dgv_bolt.Rows.Clear();
            AllatokTabla boltokTabla = new AllatokTabla();
            foreach (Boltok b in boltokTabla.BoltSelect())
            {
                dgv_bolt.Rows.Add(new object[]
                {
                    b.id,
                    b.nev
                });
            }
        }

        private void Fill_DataGridView()
        {
            DataGridViewRow[] dataGridViewRows = new DataGridViewRow[rekords_BoltokList.Count];

            for (int i = 0; i < rekords_BoltokList.Count; i++)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();

                DataGridViewCell idCell = new DataGridViewTextBoxCell();
                idCell.Value = rekords_BoltokList[i].id;
                dataGridViewRow.Cells.Add(idCell);

                DataGridViewCell NevCell = new DataGridViewTextBoxCell();
                NevCell.Value = rekords_BoltokList[i].nev;
                dataGridViewRow.Cells.Add(NevCell);
                dataGridViewRows[i] = dataGridViewRow;
            }
            dgv_bolt.Rows.AddRange(dataGridViewRows);

        }
        private void InDataGridView()
        {
            dgv_bolt.Columns.Clear();
            dgv_bolt.Rows.Clear();
            dgv_bolt.AutoGenerateColumns = false;
            dgv_bolt.Columns.Add("id", "Azonosító");
            dgv_bolt.Columns.Add("nev", "Név");
        }

        private void b_vissza_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
