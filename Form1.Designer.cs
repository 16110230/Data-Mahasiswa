namespace CRUD
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.mahasiswatbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new CRUD.AppData();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.mahasiswatbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNamaCari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCari2 = new System.Windows.Forms.Button();
            this.btnCari1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBaiki = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.mahasiswa_tbTableAdapter = new CRUD.AppDataTableAdapters.mahasiswa_tbTableAdapter();
            this.appDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswatbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswatbBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // txtNim
            // 
            this.txtNim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswatbBindingSource, "nim", true));
            this.txtNim.Location = new System.Drawing.Point(73, 2);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(100, 20);
            this.txtNim.TabIndex = 1;
            // 
            // mahasiswatbBindingSource
            // 
            this.mahasiswatbBindingSource.DataMember = "mahasiswa_tb";
            this.mahasiswatbBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNama
            // 
            this.txtNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswatbBindingSource, "nama", true));
            this.txtNama.Location = new System.Drawing.Point(73, 28);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(329, 20);
            this.txtNama.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // txtAlamat
            // 
            this.txtAlamat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswatbBindingSource1, "alamat", true));
            this.txtAlamat.Location = new System.Drawing.Point(73, 54);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(627, 20);
            this.txtAlamat.TabIndex = 5;
            // 
            // mahasiswatbBindingSource1
            // 
            this.mahasiswatbBindingSource1.DataMember = "mahasiswa_tb";
            this.mahasiswatbBindingSource1.DataSource = this.appData;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alamat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(15, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 235);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Mahasiswa";
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nimDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.mahasiswatbBindingSource;
            this.dgv.Location = new System.Drawing.Point(0, 16);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(682, 213);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNamaCari);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnCari2);
            this.groupBox2.Location = new System.Drawing.Point(12, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 41);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pencarian Data";
            // 
            // txtNamaCari
            // 
            this.txtNamaCari.Location = new System.Drawing.Point(61, 15);
            this.txtNamaCari.Name = "txtNamaCari";
            this.txtNamaCari.Size = new System.Drawing.Size(540, 20);
            this.txtNamaCari.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nama";
            // 
            // btnCari2
            // 
            this.btnCari2.Location = new System.Drawing.Point(607, 12);
            this.btnCari2.Name = "btnCari2";
            this.btnCari2.Size = new System.Drawing.Size(75, 23);
            this.btnCari2.TabIndex = 9;
            this.btnCari2.Text = "Cari";
            this.btnCari2.UseVisualStyleBackColor = true;
            // 
            // btnCari1
            // 
            this.btnCari1.Location = new System.Drawing.Point(179, 0);
            this.btnCari1.Name = "btnCari1";
            this.btnCari1.Size = new System.Drawing.Size(75, 23);
            this.btnCari1.TabIndex = 8;
            this.btnCari1.Text = "Cari";
            this.btnCari1.UseVisualStyleBackColor = true;
            this.btnCari1.Click += new System.EventHandler(this.btnCari1_Click);
            this.btnCari1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCari1_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBaiki
            // 
            this.btnBaiki.Location = new System.Drawing.Point(99, 368);
            this.btnBaiki.Name = "btnBaiki";
            this.btnBaiki.Size = new System.Drawing.Size(75, 23);
            this.btnBaiki.TabIndex = 11;
            this.btnBaiki.Text = "Perbaiki";
            this.btnBaiki.UseVisualStyleBackColor = true;
            this.btnBaiki.Click += new System.EventHandler(this.btnBaiki_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(180, 368);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // mahasiswa_tbTableAdapter
            // 
            this.mahasiswa_tbTableAdapter.ClearBeforeFill = true;
            // 
            // appDataBindingSource
            // 
            this.appDataBindingSource.DataSource = this.appData;
            this.appDataBindingSource.Position = 0;
            // 
            // nimDataGridViewTextBoxColumn
            // 
            this.nimDataGridViewTextBoxColumn.DataPropertyName = "nim";
            this.nimDataGridViewTextBoxColumn.HeaderText = "nim";
            this.nimDataGridViewTextBoxColumn.Name = "nimDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 397);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnBaiki);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCari1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Data Mahasiswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswatbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswatbBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNim;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNamaCari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCari2;
        private System.Windows.Forms.Button btnCari1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBaiki;
        private System.Windows.Forms.Button btnHapus;
        private AppData appData;
        private System.Windows.Forms.BindingSource mahasiswatbBindingSource;
        private AppDataTableAdapters.mahasiswa_tbTableAdapter mahasiswa_tbTableAdapter;
        private System.Windows.Forms.BindingSource mahasiswatbBindingSource1;
        private System.Windows.Forms.BindingSource appDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
    }
}

