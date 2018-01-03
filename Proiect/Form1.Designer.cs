namespace Proiect
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATANASTERIIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vARSTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pACIENTIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Proiect.DataSet1();
            this.pACIENTITableAdapter = new Proiect.DataSet1TableAdapters.PACIENTITableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultatiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textCNPPacient = new System.Windows.Forms.TextBox();
            this.textAdresa = new System.Windows.Forms.TextBox();
            this.textVarsta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdaugaPacient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textDataNasterii = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNPDataGridViewTextBoxColumn,
            this.aDRESADataGridViewTextBoxColumn,
            this.dATANASTERIIDataGridViewTextBoxColumn,
            this.vARSTADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pACIENTIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(263, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // aDRESADataGridViewTextBoxColumn
            // 
            this.aDRESADataGridViewTextBoxColumn.DataPropertyName = "ADRESA";
            this.aDRESADataGridViewTextBoxColumn.HeaderText = "ADRESA";
            this.aDRESADataGridViewTextBoxColumn.Name = "aDRESADataGridViewTextBoxColumn";
            // 
            // dATANASTERIIDataGridViewTextBoxColumn
            // 
            this.dATANASTERIIDataGridViewTextBoxColumn.DataPropertyName = "DATA_NASTERII";
            this.dATANASTERIIDataGridViewTextBoxColumn.HeaderText = "DATA_NASTERII";
            this.dATANASTERIIDataGridViewTextBoxColumn.Name = "dATANASTERIIDataGridViewTextBoxColumn";
            // 
            // vARSTADataGridViewTextBoxColumn
            // 
            this.vARSTADataGridViewTextBoxColumn.DataPropertyName = "VARSTA";
            this.vARSTADataGridViewTextBoxColumn.HeaderText = "VARSTA";
            this.vARSTADataGridViewTextBoxColumn.Name = "vARSTADataGridViewTextBoxColumn";
            // 
            // pACIENTIBindingSource
            // 
            this.pACIENTIBindingSource.DataMember = "PACIENTI";
            this.pACIENTIBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pACIENTITableAdapter
            // 
            this.pACIENTITableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientiToolStripMenuItem,
            this.consultatiiToolStripMenuItem,
            this.rapoarteToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientiToolStripMenuItem
            // 
            this.pacientiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.stergereToolStripMenuItem,
            this.modificareToolStripMenuItem,
            this.cautareToolStripMenuItem});
            this.pacientiToolStripMenuItem.Name = "pacientiToolStripMenuItem";
            this.pacientiToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pacientiToolStripMenuItem.Text = "Pacienti";
            this.pacientiToolStripMenuItem.Click += new System.EventHandler(this.pacientiToolStripMenuItem_Click);
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            this.adaugareToolStripMenuItem.Click += new System.EventHandler(this.adaugareToolStripMenuItem_Click);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.stergereToolStripMenuItem.Text = "Stergere";
            // 
            // modificareToolStripMenuItem
            // 
            this.modificareToolStripMenuItem.Name = "modificareToolStripMenuItem";
            this.modificareToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.modificareToolStripMenuItem.Text = "Modificare";
            // 
            // cautareToolStripMenuItem
            // 
            this.cautareToolStripMenuItem.Name = "cautareToolStripMenuItem";
            this.cautareToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.cautareToolStripMenuItem.Text = "Cautare";
            // 
            // consultatiiToolStripMenuItem
            // 
            this.consultatiiToolStripMenuItem.Name = "consultatiiToolStripMenuItem";
            this.consultatiiToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.consultatiiToolStripMenuItem.Text = "Consultatii";
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.rapoarteToolStripMenuItem.Text = "Rapoarte";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.iesireToolStripMenuItem.Text = "Iesire";
            // 
            // textCNPPacient
            // 
            this.textCNPPacient.Location = new System.Drawing.Point(124, 54);
            this.textCNPPacient.Name = "textCNPPacient";
            this.textCNPPacient.Size = new System.Drawing.Size(121, 20);
            this.textCNPPacient.TabIndex = 4;
            this.textCNPPacient.Visible = false;
            this.textCNPPacient.TextChanged += new System.EventHandler(this.textCNPPacient_TextChanged);
            this.textCNPPacient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCNPPacient_KeyPress);
            this.textCNPPacient.Leave += new System.EventHandler(this.textCNPPacient_Leave);
            // 
            // textAdresa
            // 
            this.textAdresa.Location = new System.Drawing.Point(124, 89);
            this.textAdresa.Name = "textAdresa";
            this.textAdresa.Size = new System.Drawing.Size(121, 20);
            this.textAdresa.TabIndex = 5;
            this.textAdresa.Visible = false;
            // 
            // textVarsta
            // 
            this.textVarsta.Enabled = false;
            this.textVarsta.Location = new System.Drawing.Point(124, 184);
            this.textVarsta.Name = "textVarsta";
            this.textVarsta.Size = new System.Drawing.Size(121, 20);
            this.textVarsta.TabIndex = 7;
            this.textVarsta.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CNP";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Adresa";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Varsta";
            this.label4.Visible = false;
            // 
            // btnAdaugaPacient
            // 
            this.btnAdaugaPacient.Location = new System.Drawing.Point(124, 336);
            this.btnAdaugaPacient.Name = "btnAdaugaPacient";
            this.btnAdaugaPacient.Size = new System.Drawing.Size(121, 23);
            this.btnAdaugaPacient.TabIndex = 12;
            this.btnAdaugaPacient.Text = "Adaugare pacient";
            this.btnAdaugaPacient.UseVisualStyleBackColor = true;
            this.btnAdaugaPacient.Visible = false;
            this.btnAdaugaPacient.Click += new System.EventHandler(this.btnAdaugaPacient_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data nasterii";
            this.label3.Visible = false;
            // 
            // textDataNasterii
            // 
            this.textDataNasterii.Location = new System.Drawing.Point(124, 139);
            this.textDataNasterii.Name = "textDataNasterii";
            this.textDataNasterii.Size = new System.Drawing.Size(121, 20);
            this.textDataNasterii.TabIndex = 15;
            this.textDataNasterii.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 412);
            this.Controls.Add(this.textDataNasterii);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdaugaPacient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textVarsta);
            this.Controls.Add(this.textAdresa);
            this.Controls.Add(this.textCNPPacient);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pACIENTIBindingSource;
        private DataSet1TableAdapters.PACIENTITableAdapter pACIENTITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATANASTERIIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vARSTADataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultatiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.TextBox textCNPPacient;
        private System.Windows.Forms.TextBox textAdresa;
        private System.Windows.Forms.TextBox textVarsta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdaugaPacient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDataNasterii;
    }
}

