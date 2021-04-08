using System;
using System.Collections.Generic;
using System.Collections;
using DataAccess.Models;
using DataAccess;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using StudentRecordManagementSystem.GridMapper;

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
            dtGridCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridCourses.SelectionChanged += DtGridCourses_SelectionChanged;

            dtGridCourses.AutoGenerateColumns = false;
            dtGridCourses.Columns[0].DataPropertyName = "id";
            dtGridCourses.Columns[1].DataPropertyName = "courseName";
            dtGridCourses.Columns[2].DataPropertyName = "courseCode";
            dtGridCourses.Columns[3].DataPropertyName = "semesters";
            dtGridCourses.Columns[4].DataPropertyName = "department";

            dtGridCourses.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGridCourses.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGridCourses.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGridCourses.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGridCourses.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            updateCourses();
            fillGrid();
        }

        private void DtGridCourses_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dtGridCourses.SelectedRows[0].Index;
                if (selectedIndex >= 0)
                    btnManageUnits.Enabled = true;
            }
            catch (Exception) { };
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
        private void fillGrid()
        {
            try
            {
                dtGridCourses.DataSource = null;
                List<CourseModel>courses = CourseManager.getCourses();
                List<CourseMap> gCourses = new List<CourseMap>();
                int id = 1;
                foreach(CourseModel course in courses)
                {
                    CourseMap gCourse = new CourseMap();
                    gCourse.id = id;
                    gCourse.courseName = course.CourseName;
                    gCourse.courseCode = course.CourseCode;
                    gCourse.semesters = course.Duration;
                    gCourse.department = course.Department.DepartmentName;
                    gCourses.Add(gCourse);
                    id += 1;
                }
                dtGridCourses.DataSource = gCourses;

            }catch(Exception ex)
            {
                showerrorMessage(ex.Message);
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
            {
                fillGrid();
                MessageBox.Show("Successfully saved course details", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
