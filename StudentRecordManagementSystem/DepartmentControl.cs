using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRecordManagementSystem
{
    public partial class DepartmentControl : UserControl
    {
        public DepartmentControl()
        {
            InitializeComponent();
        }

        private void DepartmentControl_Load(object sender, EventArgs e)
        {

        }

        private void btnEnrollStudent_Click(object sender, EventArgs e)
        {
            BioDataForm studentForm = new BioDataForm();
            try
            {
                studentForm.ShowDialog();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
