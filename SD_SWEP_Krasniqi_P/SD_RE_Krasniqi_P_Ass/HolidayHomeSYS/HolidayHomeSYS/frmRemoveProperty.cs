using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolidayHomeSYS
{
    public partial class frmRemoveProperty : Form
    {
        public frmRemoveProperty()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtPropno.Text.All(char.IsDigit))
            {

            }
            else
            {
                MessageBox.Show("Numbers Only");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPropno.Text))
            {
                MessageBox.Show("Error! Fields must not be left empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPropno.Focus();
                return;
            }
            
                MessageBox.Show("Property removed successfully","Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);

            txtPropno.Text = "";
            txtPropno.Focus();
            return;

        }
    }
}
