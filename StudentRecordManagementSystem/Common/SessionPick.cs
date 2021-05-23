using System;
using MaterialSkin;
using MaterialSkin.Controls;
using DataAccess.Models;
using System.Windows.Forms;
using DataAccess;
using System.Collections.Generic;

namespace StudentRecordManagementSystem.Common
{
    public partial class SessionPick : MaterialForm
    {
        public SessionModel session { get; set; }
        public SessionPick()
        {
            InitializeComponent();
        }

        private void SessionPick_Load(object sender, EventArgs e)
        {

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            session = new SessionModel();
            loadSessions();

        }

        private void loadSessions()
        {
            List<SessionModel> sessions = SessionManager.getSessions();
            foreach (var _session in sessions)
            {
                int year = _session.Year;
                int month = _session.Month;
                string msg = String.Format("{0}/{1}", year, month);
                ComboBoxItem sessionItem = new ComboBoxItem(msg, _session);
                cbxSessions.Items.Add(sessionItem);
            }
        }

        private void cbxSessions_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)cbxSessions.SelectedItem;
            SessionModel selectedSession = (SessionModel)item.Tag;
            session = selectedSession;
        }
    }
}
