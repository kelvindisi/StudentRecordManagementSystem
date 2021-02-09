using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace StudentRecordManagementSystem
{
    public partial class DepartmentForm : MaterialForm
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        
    }
}
