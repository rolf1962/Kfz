namespace Kfz.WinApp
{
    partial class frmKosten
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label kosten_idLabel;
            System.Windows.Forms.Label fahrzeug_idLabel;
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label kostenartLabel;
            System.Windows.Forms.Label km_altLabel;
            System.Windows.Forms.Label km_neuLabel;
            System.Windows.Forms.Label mengeLabel;
            System.Windows.Forms.Label betragLabel;
            System.Windows.Forms.Label bemerkungLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKosten));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxFahrzeug = new System.Windows.Forms.ComboBox();
            this.bindingSourceFahrzeug = new System.Windows.Forms.BindingSource(this.components);
            this._dsKfz = new Kfz.Database.dsKfz();
            this.dataGridViewKosten = new System.Windows.Forms.DataGridView();
            this.kostenidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fahrzeugidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kostenartDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingSourceKostenart = new System.Windows.Forms.BindingSource(this.components);
            this.kmaltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmneuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mengeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.betragDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bemerkungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceKosten = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageListe = new System.Windows.Forms.TabPage();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.kosten_idTextBox = new System.Windows.Forms.TextBox();
            this.fahrzeug_idTextBox = new System.Windows.Forms.TextBox();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kostenartTextBox = new System.Windows.Forms.TextBox();
            this.km_altTextBox = new System.Windows.Forms.TextBox();
            this.km_neuTextBox = new System.Windows.Forms.TextBox();
            this.mengeTextBox = new System.Windows.Forms.TextBox();
            this.betragTextBox = new System.Windows.Forms.TextBox();
            this.bemerkungTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorKosten = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            kosten_idLabel = new System.Windows.Forms.Label();
            fahrzeug_idLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            kostenartLabel = new System.Windows.Forms.Label();
            km_altLabel = new System.Windows.Forms.Label();
            km_neuLabel = new System.Windows.Forms.Label();
            mengeLabel = new System.Windows.Forms.Label();
            betragLabel = new System.Windows.Forms.Label();
            bemerkungLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFahrzeug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dsKfz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKosten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKostenart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKosten)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageListe.SuspendLayout();
            this.tabPageDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKosten)).BeginInit();
            this.bindingNavigatorKosten.SuspendLayout();
            this.SuspendLayout();
            // 
            // kosten_idLabel
            // 
            kosten_idLabel.AutoSize = true;
            kosten_idLabel.Location = new System.Drawing.Point(30, 49);
            kosten_idLabel.Name = "kosten_idLabel";
            kosten_idLabel.Size = new System.Drawing.Size(21, 13);
            kosten_idLabel.TabIndex = 1;
            kosten_idLabel.Text = "ID:";
            // 
            // fahrzeug_idLabel
            // 
            fahrzeug_idLabel.AutoSize = true;
            fahrzeug_idLabel.Location = new System.Drawing.Point(30, 75);
            fahrzeug_idLabel.Name = "fahrzeug_idLabel";
            fahrzeug_idLabel.Size = new System.Drawing.Size(54, 13);
            fahrzeug_idLabel.TabIndex = 3;
            fahrzeug_idLabel.Text = "Fahrzeug:";
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(30, 102);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(41, 13);
            datumLabel.TabIndex = 5;
            datumLabel.Text = "Datum:";
            // 
            // kostenartLabel
            // 
            kostenartLabel.AutoSize = true;
            kostenartLabel.Location = new System.Drawing.Point(30, 127);
            kostenartLabel.Name = "kostenartLabel";
            kostenartLabel.Size = new System.Drawing.Size(55, 13);
            kostenartLabel.TabIndex = 7;
            kostenartLabel.Text = "Kostenart:";
            // 
            // km_altLabel
            // 
            km_altLabel.AutoSize = true;
            km_altLabel.Location = new System.Drawing.Point(30, 153);
            km_altLabel.Name = "km_altLabel";
            km_altLabel.Size = new System.Drawing.Size(46, 13);
            km_altLabel.TabIndex = 9;
            km_altLabel.Text = "KM (alt):";
            // 
            // km_neuLabel
            // 
            km_neuLabel.AutoSize = true;
            km_neuLabel.Location = new System.Drawing.Point(30, 179);
            km_neuLabel.Name = "km_neuLabel";
            km_neuLabel.Size = new System.Drawing.Size(53, 13);
            km_neuLabel.TabIndex = 11;
            km_neuLabel.Text = "KM (neu):";
            // 
            // mengeLabel
            // 
            mengeLabel.AutoSize = true;
            mengeLabel.Location = new System.Drawing.Point(30, 205);
            mengeLabel.Name = "mengeLabel";
            mengeLabel.Size = new System.Drawing.Size(43, 13);
            mengeLabel.TabIndex = 13;
            mengeLabel.Text = "Menge:";
            // 
            // betragLabel
            // 
            betragLabel.AutoSize = true;
            betragLabel.Location = new System.Drawing.Point(30, 231);
            betragLabel.Name = "betragLabel";
            betragLabel.Size = new System.Drawing.Size(41, 13);
            betragLabel.TabIndex = 15;
            betragLabel.Text = "Betrag:";
            // 
            // bemerkungLabel
            // 
            bemerkungLabel.AutoSize = true;
            bemerkungLabel.Location = new System.Drawing.Point(30, 257);
            bemerkungLabel.Name = "bemerkungLabel";
            bemerkungLabel.Size = new System.Drawing.Size(64, 13);
            bemerkungLabel.TabIndex = 17;
            bemerkungLabel.Text = "Bemerkung:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxFahrzeug);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewKosten);
            this.splitContainer1.Size = new System.Drawing.Size(693, 423);
            this.splitContainer1.SplitterDistance = 42;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(281, 13);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(66, 21);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "&Speichern";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxFahrzeug
            // 
            this.comboBoxFahrzeug.DataSource = this.bindingSourceFahrzeug;
            this.comboBoxFahrzeug.DisplayMember = "typ";
            this.comboBoxFahrzeug.FormattingEnabled = true;
            this.comboBoxFahrzeug.Location = new System.Drawing.Point(13, 13);
            this.comboBoxFahrzeug.Name = "comboBoxFahrzeug";
            this.comboBoxFahrzeug.Size = new System.Drawing.Size(261, 21);
            this.comboBoxFahrzeug.TabIndex = 0;
            this.comboBoxFahrzeug.ValueMember = "fahrzeug_id";
            this.comboBoxFahrzeug.SelectedIndexChanged += new System.EventHandler(this.comboBoxFahrzeug_SelectedIndexChanged);
            // 
            // bindingSourceFahrzeug
            // 
            this.bindingSourceFahrzeug.DataMember = "tbl_fahrzeug";
            this.bindingSourceFahrzeug.DataSource = this._dsKfz;
            this.bindingSourceFahrzeug.Sort = "typ";
            // 
            // _dsKfz
            // 
            this._dsKfz.DataSetName = "dsKfz";
            this._dsKfz.EnforceConstraints = false;
            this._dsKfz.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewKosten
            // 
            this.dataGridViewKosten.AutoGenerateColumns = false;
            this.dataGridViewKosten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKosten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKosten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kostenidDataGridViewTextBoxColumn,
            this.fahrzeugidDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.kostenartDataGridViewComboBoxColumn,
            this.kmaltDataGridViewTextBoxColumn,
            this.kmneuDataGridViewTextBoxColumn,
            this.mengeDataGridViewTextBoxColumn,
            this.betragDataGridViewTextBoxColumn,
            this.bemerkungDataGridViewTextBoxColumn});
            this.dataGridViewKosten.DataSource = this.bindingSourceKosten;
            this.dataGridViewKosten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKosten.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewKosten.Name = "dataGridViewKosten";
            this.dataGridViewKosten.Size = new System.Drawing.Size(693, 377);
            this.dataGridViewKosten.TabIndex = 0;
            // 
            // kostenidDataGridViewTextBoxColumn
            // 
            this.kostenidDataGridViewTextBoxColumn.DataPropertyName = "kosten_id";
            this.kostenidDataGridViewTextBoxColumn.HeaderText = "kosten_id";
            this.kostenidDataGridViewTextBoxColumn.Name = "kostenidDataGridViewTextBoxColumn";
            this.kostenidDataGridViewTextBoxColumn.Visible = false;
            // 
            // fahrzeugidDataGridViewTextBoxColumn
            // 
            this.fahrzeugidDataGridViewTextBoxColumn.DataPropertyName = "fahrzeug_id";
            this.fahrzeugidDataGridViewTextBoxColumn.HeaderText = "fahrzeug_id";
            this.fahrzeugidDataGridViewTextBoxColumn.Name = "fahrzeugidDataGridViewTextBoxColumn";
            this.fahrzeugidDataGridViewTextBoxColumn.Visible = false;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // kostenartDataGridViewComboBoxColumn
            // 
            this.kostenartDataGridViewComboBoxColumn.DataPropertyName = "kostenart";
            this.kostenartDataGridViewComboBoxColumn.DataSource = this.bindingSourceKostenart;
            this.kostenartDataGridViewComboBoxColumn.DisplayMember = "kostenart";
            this.kostenartDataGridViewComboBoxColumn.HeaderText = "kostenart";
            this.kostenartDataGridViewComboBoxColumn.Name = "kostenartDataGridViewComboBoxColumn";
            this.kostenartDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kostenartDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kostenartDataGridViewComboBoxColumn.ValueMember = "kostenart";
            // 
            // bindingSourceKostenart
            // 
            this.bindingSourceKostenart.DataMember = "tlkp_kostenart";
            this.bindingSourceKostenart.DataSource = this._dsKfz;
            // 
            // kmaltDataGridViewTextBoxColumn
            // 
            this.kmaltDataGridViewTextBoxColumn.DataPropertyName = "km-alt";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.kmaltDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.kmaltDataGridViewTextBoxColumn.HeaderText = "km-alt";
            this.kmaltDataGridViewTextBoxColumn.Name = "kmaltDataGridViewTextBoxColumn";
            // 
            // kmneuDataGridViewTextBoxColumn
            // 
            this.kmneuDataGridViewTextBoxColumn.DataPropertyName = "km-neu";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.kmneuDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.kmneuDataGridViewTextBoxColumn.HeaderText = "km-neu";
            this.kmneuDataGridViewTextBoxColumn.Name = "kmneuDataGridViewTextBoxColumn";
            // 
            // mengeDataGridViewTextBoxColumn
            // 
            this.mengeDataGridViewTextBoxColumn.DataPropertyName = "menge";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.mengeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.mengeDataGridViewTextBoxColumn.HeaderText = "menge";
            this.mengeDataGridViewTextBoxColumn.Name = "mengeDataGridViewTextBoxColumn";
            // 
            // betragDataGridViewTextBoxColumn
            // 
            this.betragDataGridViewTextBoxColumn.DataPropertyName = "betrag";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.betragDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.betragDataGridViewTextBoxColumn.HeaderText = "betrag";
            this.betragDataGridViewTextBoxColumn.Name = "betragDataGridViewTextBoxColumn";
            // 
            // bemerkungDataGridViewTextBoxColumn
            // 
            this.bemerkungDataGridViewTextBoxColumn.DataPropertyName = "bemerkung";
            this.bemerkungDataGridViewTextBoxColumn.HeaderText = "bemerkung";
            this.bemerkungDataGridViewTextBoxColumn.Name = "bemerkungDataGridViewTextBoxColumn";
            // 
            // bindingSourceKosten
            // 
            this.bindingSourceKosten.DataMember = "tbl_kosten";
            this.bindingSourceKosten.DataSource = this._dsKfz;
            this.bindingSourceKosten.Sort = "datum";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageListe);
            this.tabControl.Controls.Add(this.tabPageDetails);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(707, 455);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageListe
            // 
            this.tabPageListe.Controls.Add(this.splitContainer1);
            this.tabPageListe.Location = new System.Drawing.Point(4, 22);
            this.tabPageListe.Name = "tabPageListe";
            this.tabPageListe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListe.Size = new System.Drawing.Size(699, 429);
            this.tabPageListe.TabIndex = 0;
            this.tabPageListe.Text = "Liste";
            this.tabPageListe.UseVisualStyleBackColor = true;
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Controls.Add(kosten_idLabel);
            this.tabPageDetails.Controls.Add(this.kosten_idTextBox);
            this.tabPageDetails.Controls.Add(fahrzeug_idLabel);
            this.tabPageDetails.Controls.Add(this.fahrzeug_idTextBox);
            this.tabPageDetails.Controls.Add(datumLabel);
            this.tabPageDetails.Controls.Add(this.datumDateTimePicker);
            this.tabPageDetails.Controls.Add(kostenartLabel);
            this.tabPageDetails.Controls.Add(this.kostenartTextBox);
            this.tabPageDetails.Controls.Add(km_altLabel);
            this.tabPageDetails.Controls.Add(this.km_altTextBox);
            this.tabPageDetails.Controls.Add(km_neuLabel);
            this.tabPageDetails.Controls.Add(this.km_neuTextBox);
            this.tabPageDetails.Controls.Add(mengeLabel);
            this.tabPageDetails.Controls.Add(this.mengeTextBox);
            this.tabPageDetails.Controls.Add(betragLabel);
            this.tabPageDetails.Controls.Add(this.betragTextBox);
            this.tabPageDetails.Controls.Add(bemerkungLabel);
            this.tabPageDetails.Controls.Add(this.bemerkungTextBox);
            this.tabPageDetails.Controls.Add(this.bindingNavigatorKosten);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(699, 429);
            this.tabPageDetails.TabIndex = 1;
            this.tabPageDetails.Text = "Details";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // kosten_idTextBox
            // 
            this.kosten_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceKosten, "kosten_id", true));
            this.kosten_idTextBox.Location = new System.Drawing.Point(99, 46);
            this.kosten_idTextBox.Name = "kosten_idTextBox";
            this.kosten_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.kosten_idTextBox.TabIndex = 2;
            // 
            // fahrzeug_idTextBox
            // 
            this.fahrzeug_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceKosten, "fahrzeug_id", true));
            this.fahrzeug_idTextBox.Location = new System.Drawing.Point(99, 72);
            this.fahrzeug_idTextBox.Name = "fahrzeug_idTextBox";
            this.fahrzeug_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.fahrzeug_idTextBox.TabIndex = 4;
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceKosten, "datum", true));
            this.datumDateTimePicker.Location = new System.Drawing.Point(99, 98);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumDateTimePicker.TabIndex = 6;
            // 
            // kostenartTextBox
            // 
            this.kostenartTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceKosten, "kostenart", true));
            this.kostenartTextBox.Location = new System.Drawing.Point(99, 124);
            this.kostenartTextBox.Name = "kostenartTextBox";
            this.kostenartTextBox.Size = new System.Drawing.Size(200, 20);
            this.kostenartTextBox.TabIndex = 8;
            // 
            // km_altTextBox
            // 
            this.km_altTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceKosten, "km-alt", true));
            this.km_altTextBox.Location = new System.Drawing.Point(99, 150);
            this.km_altTextBox.Name = "km_altTextBox";
            this.km_altTextBox.Size = new System.Drawing.Size(200, 20);
            this.km_altTextBox.TabIndex = 10;
            // 
            // km_neuTextBox
            // 
            this.km_neuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceKosten, "km-neu", true));
            this.km_neuTextBox.Location = new System.Drawing.Point(99, 176);
            this.km_neuTextBox.Name = "km_neuTextBox";
            this.km_neuTextBox.Size = new System.Drawing.Size(200, 20);
            this.km_neuTextBox.TabIndex = 12;
            // 
            // mengeTextBox
            // 
            this.mengeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceKosten, "menge", true));
            this.mengeTextBox.Location = new System.Drawing.Point(99, 202);
            this.mengeTextBox.Name = "mengeTextBox";
            this.mengeTextBox.Size = new System.Drawing.Size(200, 20);
            this.mengeTextBox.TabIndex = 14;
            // 
            // betragTextBox
            // 
            this.betragTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceKosten, "betrag", true));
            this.betragTextBox.Location = new System.Drawing.Point(99, 228);
            this.betragTextBox.Name = "betragTextBox";
            this.betragTextBox.Size = new System.Drawing.Size(200, 20);
            this.betragTextBox.TabIndex = 16;
            // 
            // bemerkungTextBox
            // 
            this.bemerkungTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceKosten, "bemerkung", true));
            this.bemerkungTextBox.Location = new System.Drawing.Point(99, 254);
            this.bemerkungTextBox.Name = "bemerkungTextBox";
            this.bemerkungTextBox.Size = new System.Drawing.Size(200, 20);
            this.bemerkungTextBox.TabIndex = 18;
            // 
            // bindingNavigatorKosten
            // 
            this.bindingNavigatorKosten.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorKosten.BindingSource = this.bindingSourceKosten;
            this.bindingNavigatorKosten.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorKosten.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorKosten.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorKosten.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigatorKosten.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorKosten.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorKosten.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorKosten.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorKosten.Name = "bindingNavigatorKosten";
            this.bindingNavigatorKosten.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorKosten.Size = new System.Drawing.Size(693, 25);
            this.bindingNavigatorKosten.TabIndex = 0;
            this.bindingNavigatorKosten.Text = "Kosten";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // frmKosten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 455);
            this.Controls.Add(this.tabControl);
            this.Name = "frmKosten";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Kosten";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFahrzeug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dsKfz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKosten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKostenart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKosten)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageListe.ResumeLayout(false);
            this.tabPageDetails.ResumeLayout(false);
            this.tabPageDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKosten)).EndInit();
            this.bindingNavigatorKosten.ResumeLayout(false);
            this.bindingNavigatorKosten.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBoxFahrzeug;
        private System.Windows.Forms.DataGridView dataGridViewKosten;
        private Database.dsKfz _dsKfz;
        private System.Windows.Forms.BindingSource bindingSourceFahrzeug;
        private System.Windows.Forms.BindingSource bindingSourceKosten;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.BindingSource bindingSourceKostenart;
        private System.Windows.Forms.DataGridViewTextBoxColumn kostenidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fahrzeugidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn kostenartDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmaltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmneuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mengeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn betragDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bemerkungDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageListe;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.TextBox kosten_idTextBox;
        private System.Windows.Forms.TextBox fahrzeug_idTextBox;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.TextBox kostenartTextBox;
        private System.Windows.Forms.TextBox km_altTextBox;
        private System.Windows.Forms.TextBox km_neuTextBox;
        private System.Windows.Forms.TextBox mengeTextBox;
        private System.Windows.Forms.TextBox betragTextBox;
        private System.Windows.Forms.TextBox bemerkungTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigatorKosten;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}

