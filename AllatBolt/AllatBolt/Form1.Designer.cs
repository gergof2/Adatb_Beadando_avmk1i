
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.b_frissit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allatok)).BeginInit();
            this.SuspendLayout();
            // 
            // b_insert
            // 
            this.b_insert.Location = new System.Drawing.Point(31, 314);
            this.b_insert.Name = "b_insert";
            this.b_insert.Size = new System.Drawing.Size(115, 30);
            this.b_insert.TabIndex = 1;
            this.b_insert.Text = "Hozzáadás";
            this.b_insert.UseVisualStyleBackColor = true;
            this.b_insert.Click += new System.EventHandler(this.b_insert_Click);
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(31, 354);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(116, 30);
            this.b_delete.TabIndex = 3;
            this.b_delete.Text = "Törlés";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(240, 315);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(153, 20);
            this.tb_id.TabIndex = 4;
            this.tb_id.Text = "ID";
            // 
            // tb_faj
            // 
            this.tb_faj.Location = new System.Drawing.Point(240, 360);
            this.tb_faj.Name = "tb_faj";
            this.tb_faj.Size = new System.Drawing.Size(153, 20);
            this.tb_faj.TabIndex = 5;
            this.tb_faj.Text = "Fajta";
            // 
            // tb_ar
            // 
            this.tb_ar.Location = new System.Drawing.Point(481, 360);
            this.tb_ar.Name = "tb_ar";
            this.tb_ar.Size = new System.Drawing.Size(152, 20);
            this.tb_ar.TabIndex = 8;
            this.tb_ar.Text = "Ár";
            // 
            // tb_bolt
            // 
            this.tb_bolt.Location = new System.Drawing.Point(481, 404);
            this.tb_bolt.Name = "tb_bolt";
            this.tb_bolt.Size = new System.Drawing.Size(152, 20);
            this.tb_bolt.TabIndex = 9;
            this.tb_bolt.Text = "Melyik bolt? (ID)";
            // 
            // cb_nem
            // 
            this.cb_nem.FormattingEnabled = true;
            this.cb_nem.Location = new System.Drawing.Point(240, 403);
            this.cb_nem.Name = "cb_nem";
            this.cb_nem.Size = new System.Drawing.Size(152, 21);
            this.cb_nem.TabIndex = 10;
            // 
            // cb_etkezes
            // 
            this.cb_etkezes.FormattingEnabled = true;
            this.cb_etkezes.Location = new System.Drawing.Point(481, 314);
            this.cb_etkezes.Name = "cb_etkezes";
            this.cb_etkezes.Size = new System.Drawing.Size(153, 21);
            this.cb_etkezes.TabIndex = 11;
            // 
            // dgv_allatok
            // 
            this.dgv_allatok.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_allatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allatok.Location = new System.Drawing.Point(13, 13);
            this.dgv_allatok.Name = "dgv_allatok";
            this.dgv_allatok.RowTemplate.Height = 6;
            this.dgv_allatok.Size = new System.Drawing.Size(644, 294);
            this.dgv_allatok.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fajta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Neme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mit eszik?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ára:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Bolt ID:";
            // 
            // b_frissit
            // 
            this.b_frissit.Location = new System.Drawing.Point(31, 397);
            this.b_frissit.Name = "b_frissit";
            this.b_frissit.Size = new System.Drawing.Size(116, 30);
            this.b_frissit.TabIndex = 18;
            this.b_frissit.Text = "Frissít";
            this.b_frissit.UseVisualStyleBackColor = true;
            this.b_frissit.Click += new System.EventHandler(this.b_frissit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 437);
            this.Controls.Add(this.b_frissit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_frissit;
    }
}

