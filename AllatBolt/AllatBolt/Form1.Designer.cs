
namespace AllatBolt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_insert = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_faj = new System.Windows.Forms.TextBox();
            this.tb_ar = new System.Windows.Forms.TextBox();
            this.tb_bolt = new System.Windows.Forms.TextBox();
            this.cb_nem = new System.Windows.Forms.ComboBox();
            this.cb_etkezes = new System.Windows.Forms.ComboBox();
            this.dgv_allatok = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allatok)).BeginInit();
            this.SuspendLayout();
            // 
            // b_insert
            // 
            this.b_insert.Location = new System.Drawing.Point(13, 314);
            this.b_insert.Name = "b_insert";
            this.b_insert.Size = new System.Drawing.Size(115, 30);
            this.b_insert.TabIndex = 1;
            this.b_insert.Text = "Hozzáadás";
            this.b_insert.UseVisualStyleBackColor = true;
            this.b_insert.Click += new System.EventHandler(this.b_insert_Click);
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(13, 350);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(116, 30);
            this.b_delete.TabIndex = 3;
            this.b_delete.Text = "Törlés";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(162, 314);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(153, 20);
            this.tb_id.TabIndex = 4;
            this.tb_id.Text = "ID";
            // 
            // tb_faj
            // 
            this.tb_faj.Location = new System.Drawing.Point(321, 314);
            this.tb_faj.Name = "tb_faj";
            this.tb_faj.Size = new System.Drawing.Size(153, 20);
            this.tb_faj.TabIndex = 5;
            this.tb_faj.Text = "Fajta";
            // 
            // tb_ar
            // 
            this.tb_ar.Location = new System.Drawing.Point(322, 350);
            this.tb_ar.Name = "tb_ar";
            this.tb_ar.Size = new System.Drawing.Size(152, 20);
            this.tb_ar.TabIndex = 8;
            this.tb_ar.Text = "Ár";
            // 
            // tb_bolt
            // 
            this.tb_bolt.Location = new System.Drawing.Point(481, 350);
            this.tb_bolt.Name = "tb_bolt";
            this.tb_bolt.Size = new System.Drawing.Size(152, 20);
            this.tb_bolt.TabIndex = 9;
            this.tb_bolt.Text = "Melyik bolt? (ID)";
            // 
            // cb_nem
            // 
            this.cb_nem.FormattingEnabled = true;
            this.cb_nem.Location = new System.Drawing.Point(481, 314);
            this.cb_nem.Name = "cb_nem";
            this.cb_nem.Size = new System.Drawing.Size(152, 21);
            this.cb_nem.TabIndex = 10;
            // 
            // cb_etkezes
            // 
            this.cb_etkezes.FormattingEnabled = true;
            this.cb_etkezes.Location = new System.Drawing.Point(162, 350);
            this.cb_etkezes.Name = "cb_etkezes";
            this.cb_etkezes.Size = new System.Drawing.Size(153, 21);
            this.cb_etkezes.TabIndex = 11;
            // 
            // dgv_allatok
            // 
            this.dgv_allatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allatok.Location = new System.Drawing.Point(13, 13);
            this.dgv_allatok.Name = "dgv_allatok";
            this.dgv_allatok.RowTemplate.Height = 6;
            this.dgv_allatok.Size = new System.Drawing.Size(620, 294);
            this.dgv_allatok.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 436);
            this.Controls.Add(this.cb_etkezes);
            this.Controls.Add(this.cb_nem);
            this.Controls.Add(this.tb_bolt);
            this.Controls.Add(this.tb_ar);
            this.Controls.Add(this.tb_faj);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_insert);
            this.Controls.Add(this.dgv_allatok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_insert;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_faj;
        private System.Windows.Forms.TextBox tb_ar;
        private System.Windows.Forms.TextBox tb_bolt;
        private System.Windows.Forms.ComboBox cb_nem;
        private System.Windows.Forms.ComboBox cb_etkezes;
        private System.Windows.Forms.DataGridView dgv_allatok;
    }
}

