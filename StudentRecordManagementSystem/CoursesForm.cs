using System;
using System.Collections;
using DataAccess.Models;
using DataAccess;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace StudentRecordManagementSystem
{
    public partial class CoursesForm : MaterialForm
    {
        public CoursesForm()
        {
            InitializeComponent();
        }

        private void CoursesForm_Load(object sender, EventArgs e)
        {
            // Grid Size Config
            dtGridCourses.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGridCourses.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGridCourses.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGridCourses.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            updateCourses();
        }
        private void updateCourses()
        {
            try
            {
                ArrayList departments = DepartmentManager.getDepartmentsList();
                foreach (DepartmentModel department in departments)
                {
                    cboDepartments.Items.Add(new ComboBoxItem(department.DepartmentName, department.DepartmentId));
                }
            } catch (Exception)
            {
                showErrorMessage("Failed to load departments");
            }
        }

        private void showErrorMessage(string v)
        {
            MessageBox.Show(v, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validateForm())
                return;
            if (saveNewCourse())
                MessageBox.Show("Saved new course details successfully", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool saveNewCourse()
        {
            bool saved = false;
            try
            {
                CourseModel course = getCourseInputData();
                if (CourseManager.saveNewCourse(course))
                    saved = true;
            }
            catch (Exception ex)
            {
                showerrorMessage(ex.Message);
            }

            return saved;
        }

        private CourseModel getCourseInputData()
        {
            CourseModel input = new CourseModel();
            input.CourseName = txtCourse.Text;
            input.CourseCode = txtCourseCode.Text;
            input.Duration = (int) txtSemesters.Value;
            input.Department = getSelectedDepartment();

            return input;
        }

        private DepartmentModel getSelectedDepartment()
        {
            ComboBoxItem item = (ComboBoxItem)cboDepartments.SelectedItem;
            DepartmentModel department = new DepartmentModel();
            department.DepartmentId = (int)item.Tag;
            department.DepartmentName = item.Message;

            return department;
        }

        private bool validateForm()
        {
            bool valid = true;

            if (txtCourse.Text.Length == 0)
            {
                setRequiredErrorMessage(txtCourse, "Course name");
                valid = false;
            }
            if (txtCourseCode.Text.Length == 0)
            {
                setRequiredErrorMessage(txtCourseCode, "Course Code");
                valid = false;
            }
            if (txtSemesters.Value < 1)
            {
                showerrorMessage("Course duration should be atleast 1 semester");
                valid = false;
            }

            return valid;
        }

        private void setRequiredErrorMessage(Control txtCourse, string field)
        {
            errorProvider.SetError(txtCourse, string.Format("{0} is required.", field));
        }

        private void showerrorMessage(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
