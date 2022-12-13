using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseLib;

namespace WindowsAPI.DataBaseEditor
{
    public partial class FormEditorTable4: Form
    {
        public FormEditorTable4()
        {
            InitializeComponent();
        }

        string _tableName = "book";
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string[] args = new string[6];
            args[0] = textBox1.Text;
            args[1] = textBox2.Text;
            args[2] = textBox3.Text;
            args[3] = textBox4.Text;
            args[4] = textBox5.Text;
            args[5] = textBox5.Text;

            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Insert(args, _tableName);
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            string[] args = new string[6];
            args[0] = dataGridView1[0, currentRow].Value.ToString();

            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Delete(args, _tableName);
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            string[] args = new string[4];
            args[0] = dataGridView1[0, currentRow].Value.ToString();
            args[1] = textBox2.Text;
            args[2] = textBox3.Text;
            args[3] = textBox4.Text;
            args[4] = textBox5.Text;
            args[5] = textBox5.Text;
            button1.Enabled = true;
            button2.Enabled = true;
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Update(args, _tableName);
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }

        private void FormEditorTable4_Load(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }
    }
}

