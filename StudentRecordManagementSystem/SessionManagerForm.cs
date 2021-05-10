using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using DataAccess.Models;
using DataAccess;
using System.Windows.Forms;

namespace StudentRecordManagementSystem
{
    public partial class SessionManagerForm : MaterialForm
    {
        private int selectedId = 0;
        public SessionManagerForm()
        {
            InitializeComponent();
        }

        private void SessionManagerForm_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            dtGridSession.SelectionChanged += DtGridSession_SelectionChanged;

            dtGridSession.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridSession.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGridSession.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtGridSession.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dtGridSession.AutoGenerateColumns = false;
            dtGridSession.Columns[0].DataPropertyName = "id";
            dtGridSession.Columns[1].DataPropertyName = "year";
            dtGridSession.Columns[2].DataPropertyName = "month";

            fillGrid();
        }

        private void DtGridSession_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int allGridRows = dtGridSession.RowCount;
                if (allGridRows < 2)
                    return;
                int id = (int)dtGridSession.SelectedRows[0].Cells[0].Value;
                selectedId = id;
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        public void fillGrid()
        {
            try
            {
                List<SessionModel> sessions = SessionManager.getSessions();
                dtGridSession.DataSource = sessions;
            } catch(Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SessionModel session = getSessionInput();
                SessionManager.addSession(session);
                MessageBox.Show("Saved details successfully", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private SessionModel getSessionInput()
        {
            SessionModel session = new SessionModel();
            session.Month = (int)numMonth.Value;
            session.Year = (int)numYear.Value;

            return session;
        }
        private void showErrorMessage(string msg)
        {
            MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SessionModel session = getSessionInput();
                session.ID = selectedId;
                SessionManager.updateSession(session);
                MessageBox.Show("Updated successfully", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                fillGrid();
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }
    }
}
