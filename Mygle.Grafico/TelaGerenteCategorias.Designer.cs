﻿namespace Mygle.Grafico
{
    partial class TelaGerenteCategorias
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbCategorias = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Tipo,
            this.Check});
            this.dataGridView1.Location = new System.Drawing.Point(18, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 268);
            this.dataGridView1.TabIndex = 53;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Check
            // 
            this.Check.HeaderText = "Check";
            this.Check.Name = "Check";
            // 
            // lbCategorias
            // 
            this.lbCategorias.AutoSize = true;
            this.lbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbCategorias.Location = new System.Drawing.Point(12, 9);
            this.lbCategorias.Name = "lbCategorias";
            this.lbCategorias.Size = new System.Drawing.Size(156, 31);
            this.lbCategorias.TabIndex = 52;
            this.lbCategorias.Text = "Categorias";
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(293, 17);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(68, 27);
            this.btExcluir.TabIndex = 58;
            this.btExcluir.Text = "Adicionar";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(219, 17);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(68, 27);
            this.btRemover.TabIndex = 59;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            // 
            // TelaGerenteCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 343);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbCategorias);
            this.Name = "TelaGerenteCategorias";
            this.Text = "TelaGerenteCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.Label lbCategorias;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btRemover;
    }
}