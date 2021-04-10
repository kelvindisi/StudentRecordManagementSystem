using System;
using System.Collections.Generic;
using MaterialSkin;
using MaterialSkin.Controls;

namespace StudentRecordManagementSystem
{
    public partial class CourseUnitsManager : MaterialForm
    {
        public CourseUnitsManager()
        {
            InitializeComponent();

        }

        private void CourseUnitsManager_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.BlueGrey500, 
                Accent.LightBlue200, TextShade.WHITE);
        }
    }
}
