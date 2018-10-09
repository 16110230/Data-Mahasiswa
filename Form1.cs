using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace CRUD
{
    public partial class Form1 : Form
    {
        private const string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|E:/TUGAS/Work/CRUD/CRUD Fix|/Akademik.mdb";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();


        public Form1()
        {
            InitializeComponent();

           
            dgv.Columns[0].Name = "nim";
            dgv.Columns[1].Name = "nama";
            dgv.Columns[2].Name = "alamat";
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //SELECTION MODE
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.mahasiswa_tb' table. You can move, or remove it, as needed.
            this.mahasiswa_tbTableAdapter.Fill(this.appData.mahasiswa_tb);
            mahasiswatbBindingSource.DataSource = this.appData.mahasiswa_tb;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            add(txtNim.Text, txtNama.Text, txtAlamat.Text);
        }
        private void add(string nim, string nama, string alamat)
        {
            //SQL STMT
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|E:/TUGAS/Work/CRUD/CRUD Fix|/Akademik.mdb";
            string sql = "INSERT INTO mahasiswa_tb(nim,nama,alamat) VALUES(@NIM,@NAME,@ADDRESS)";
            cmd = new OleDbCommand(sql, con);

            //ADD PARAMS
            cmd.Parameters.AddWithValue("@NIM", nim);
            cmd.Parameters.AddWithValue("@NAME", nama);
            cmd.Parameters.AddWithValue("@ADDRESS", alamat);

            //OPEN CON AND EXEC INSERT
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    
                    MessageBox.Show(@"Successfully Inserted");
                }
                con.Close();
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnBaiki_Click(object sender, EventArgs e)
        {
            txtNama.Focus();
        }

        private void btnCari1_Click(object sender, EventArgs e)
        {
    
        }

        private void btnCari1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtNama.Text))
                    dgv.DataSource = mahasiswatbBindingSource;
                else
                {
                    var query = from o in this.appData.mahasiswa_tb
                                where o.nama.Contains(txtNama.Text)
                                select o;
                    dgv.DataSource = query.ToList();
                }
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
