
namespace AllatBolt
{
    partial class Bolt
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
            this.dgv_bolt = new System.Windows.Forms.DataGridView();
            this.b_vissza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bolt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_bolt
            // 
            this.dgv_bolt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bolt.Location = new System.Drawing.Point(12, 12);
            this.dgv_bolt.Name = "dgv_bolt";
            this.dgv_bolt.Size = new System.Drawing.Size(248, 138);
            this.dgv_bolt.TabIndex = 0;
            // 
            // b_vissza
            // 
            this.b_vissza.Location = new System.Drawing.Point(12, 156);
            this.b_vissza.Name = "b_vissza";
            this.b_vissza.Size = new System.Drawing.Size(248, 23);
            this.b_vissza.TabIndex = 1;
            this.b_vissza.Text = "Vissza";
            this.b_vissza.UseVisualStyleBackColor = true;
            this.b_vissza.Click += new System.EventHandler(this.b_vissza_Click);
            // 
            // Bolt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 185);
            this.Controls.Add(this.b_vissza);
            this.Controls.Add(this.dgv_bolt);
            this.Name = "Bolt";
            this.Text = "Bolt";
            this.Load += new System.EventHandler(this.Bolt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bolt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bolt;
        private System.Windows.Forms.Button b_vissza;
    }
}