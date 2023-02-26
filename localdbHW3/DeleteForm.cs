using localdbHW3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace localdbHW3
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LocaldbTable data = new LocaldbTable()
            {
                Name = textBox1.Text.Trim(),
                Num = textBox2.Text.Trim(),
                Price = textBox3.Text.Trim(),
                Pdtype = textBox4.Text.Trim()

            };
            try
            {
                localdbModel context = new localdbModel();
                context.LocaldbTable.Remove(data);
                context.SaveChanges();
                MessageBox.Show("存檔完成");
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤{ex.ToString()}");
            }
        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
