using Kfz.Database;
using System;
using System.Windows.Forms;

namespace Kfz.WinApp
{
    public partial class frmKosten : Form
    {
        public frmKosten()
        {
            InitializeComponent();

            Database.dsKfzTableAdapters.tbl_kostenTableAdapter taKosten = new Database.dsKfzTableAdapters.tbl_kostenTableAdapter();

            // Laden der Daten
            new Database.dsKfzTableAdapters.tbl_fahrzeugTableAdapter().
                Fill(_dsKfz.tbl_fahrzeug);
            new Database.dsKfzTableAdapters.tbl_kostenTableAdapter().
                Fill(_dsKfz.tbl_kosten);
            new Database.dsKfzTableAdapters.tlkp_kostenartTableAdapter().
                Fill(_dsKfz.tlkp_kostenart);

            useFahrzeug();
        }

        private void comboBoxFahrzeug_SelectedIndexChanged(object sender, EventArgs e)
        {
            useFahrzeug();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_dsKfz.HasChanges())
            {
                int countOfChanges = ((dsKfz)_dsKfz.GetChanges()).tbl_kosten.Count;

                Cursor = Cursors.WaitCursor;
                new Database.dsKfzTableAdapters.tbl_kostenTableAdapter().Update(_dsKfz.tbl_kosten);
                Cursor = Cursors.Default;

                MessageBox.Show(this, string.Format(
                    "{0} Änderungen in der Kostentabelle gespeichert", countOfChanges),
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void useFahrzeug()
        {
            bindingSourceKosten.Filter = string.Format("{0}={1}",
                _dsKfz.tbl_kosten.fahrzeug_idColumn.ColumnName,
                comboBoxFahrzeug.SelectedValue);
            _dsKfz.tbl_kosten.fahrzeug_idColumn.DefaultValue =
                comboBoxFahrzeug.SelectedValue;

            kostenidDataGridViewTextBoxColumn.Visible = false;
        }
    }
}
