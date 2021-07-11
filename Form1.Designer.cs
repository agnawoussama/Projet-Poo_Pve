
namespace Projet_Poo_Pve
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
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Afficher = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Sauvegarder = new System.Windows.Forms.Button();
            this.btn_total = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(44, 346);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(117, 44);
            this.btn_Ajouter.TabIndex = 0;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Afficher
            // 
            this.btn_Afficher.Location = new System.Drawing.Point(290, 346);
            this.btn_Afficher.Name = "btn_Afficher";
            this.btn_Afficher.Size = new System.Drawing.Size(117, 44);
            this.btn_Afficher.TabIndex = 1;
            this.btn_Afficher.Text = "Afficher";
            this.btn_Afficher.UseVisualStyleBackColor = true;
            this.btn_Afficher.Click += new System.EventHandler(this.btn_Afficher_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(429, 346);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(117, 44);
            this.btn_Supprimer.TabIndex = 2;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 26);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(641, 299);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_Sauvegarder
            // 
            this.btn_Sauvegarder.Location = new System.Drawing.Point(167, 346);
            this.btn_Sauvegarder.Name = "btn_Sauvegarder";
            this.btn_Sauvegarder.Size = new System.Drawing.Size(117, 44);
            this.btn_Sauvegarder.TabIndex = 4;
            this.btn_Sauvegarder.Text = "Sauvegarder";
            this.btn_Sauvegarder.UseVisualStyleBackColor = true;
            this.btn_Sauvegarder.Click += new System.EventHandler(this.btn_Sauvegarder_Click);
            // 
            // btn_total
            // 
            this.btn_total.Location = new System.Drawing.Point(562, 346);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(114, 44);
            this.btn_total.TabIndex = 5;
            this.btn_total.Text = "Total";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 402);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.btn_Sauvegarder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Afficher);
            this.Controls.Add(this.btn_Ajouter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Afficher;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Sauvegarder;
        private System.Windows.Forms.Button btn_total;
    }
}

