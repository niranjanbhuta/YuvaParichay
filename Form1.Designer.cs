namespace YuvaParichay
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvBoys = new System.Windows.Forms.DataGridView();
            this.idCandidatePKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boysLikeConcatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boysLikedByConcatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteCtrlVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.boysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new YuvaParichay.DataSet1();
            this.dgvGirls = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girlsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boysTableAdapter = new YuvaParichay.DataSet1TableAdapters.BoysTableAdapter();
            this.girlsTableAdapter = new YuvaParichay.DataSet1TableAdapters.GirlsTableAdapter();
            this.tableAdapterManager = new YuvaParichay.DataSet1TableAdapters.TableAdapterManager();
            this.boysLikeTableAdapter = new YuvaParichay.DataSet1TableAdapters.BoysLikeTableAdapter();
            this.btnSaveStep1Boy = new System.Windows.Forms.Button();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvQryMatchBoyGirl = new System.Windows.Forms.DataGridView();
            this.idCandidateFKDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idILikeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLikedByDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qryMatchBoyGirlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxGirls = new System.Windows.Forms.ListBox();
            this.dgvGirlsLike = new System.Windows.Forms.DataGridView();
            this.idCandidateFKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idILikeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girlsLikeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxBoys = new System.Windows.Forms.ListBox();
            this.dgvBoysLike = new System.Windows.Forms.DataGridView();
            this.idCandidateFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idILikeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boysLikeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSql = new System.Windows.Forms.DataGridView();
            this.pnlContextHelp = new System.Windows.Forms.Panel();
            this.txtStepHelp = new System.Windows.Forms.TextBox();
            this.pnlProcessSteps = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnStep5GirlsSMS = new System.Windows.Forms.Button();
            this.btnStep5BoysSMS = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lblStep5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnStep4MatchReport = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnStep4GirlsReport = new System.Windows.Forms.Button();
            this.btnStep4BoysReport = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblStep4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnProcessData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStep2Girls = new System.Windows.Forms.Button();
            this.btnStep2Boys = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.grpStep1 = new System.Windows.Forms.GroupBox();
            this.btnStep1Girls = new System.Windows.Forms.Button();
            this.btnStep1Boys = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.btnSaveStep1Girl = new System.Windows.Forms.Button();
            this.btnSaveStep2BoyChoices = new System.Windows.Forms.Button();
            this.btnSaveStep2GirlChoices = new System.Windows.Forms.Button();
            this.girlsLikeTableAdapter = new YuvaParichay.DataSet1TableAdapters.GirlsLikeTableAdapter();
            this.boysLikedByTableAdapter1 = new YuvaParichay.DataSet1TableAdapters.BoysLikedByTableAdapter();
            this.girlsLikedByTableAdapter1 = new YuvaParichay.DataSet1TableAdapters.GirlsLikedByTableAdapter();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.progressBarShare = new System.Windows.Forms.ProgressBar();
            this.menuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.delCurDataAndRestoreFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delCurrentDataAndCreateNewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delCurrentDataAndLoadSampleDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyBackupDataToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.fillCodeToolStripMenuItemBoys = new System.Windows.Forms.ToolStripMenuItem();
            this.FillCodeToolStripMenuItemGirls = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteAtTheEndAppendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDonate = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoys)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGirls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlsBindingSource)).BeginInit();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQryMatchBoyGirl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryMatchBoyGirlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGirlsLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlsLikeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoysLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boysLikeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSql)).BeginInit();
            this.pnlContextHelp.SuspendLayout();
            this.pnlProcessSteps.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpStep1.SuspendLayout();
            this.menuStripMainMenu.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBoys
            // 
            this.dgvBoys.AutoGenerateColumns = false;
            this.dgvBoys.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvBoys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCandidatePKDataGridViewTextBoxColumn1,
            this.myNameDataGridViewTextBoxColumn1,
            this.mobileNumDataGridViewTextBoxColumn1,
            this.boysLikeConcatDataGridViewTextBoxColumn,
            this.boysLikedByConcatDataGridViewTextBoxColumn});
            this.dgvBoys.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvBoys.DataSource = this.boysBindingSource;
            this.dgvBoys.Location = new System.Drawing.Point(37, 48);
            this.dgvBoys.Name = "dgvBoys";
            this.dgvBoys.Size = new System.Drawing.Size(317, 401);
            this.dgvBoys.TabIndex = 0;
            this.dgvBoys.Visible = false;
            this.dgvBoys.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoys_CellContentClick);
            this.dgvBoys.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoys_CellEndEdit);
            this.dgvBoys.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvBoys_CellValidating);
            this.dgvBoys.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoys_RowLeave);
            this.dgvBoys.Enter += new System.EventHandler(this.dgvBoys_Enter);
            this.dgvBoys.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgData_KeyDown);
            // 
            // idCandidatePKDataGridViewTextBoxColumn1
            // 
            this.idCandidatePKDataGridViewTextBoxColumn1.DataPropertyName = "IdCandidatePK";
            this.idCandidatePKDataGridViewTextBoxColumn1.HeaderText = "Boy-Code";
            this.idCandidatePKDataGridViewTextBoxColumn1.Name = "idCandidatePKDataGridViewTextBoxColumn1";
            // 
            // myNameDataGridViewTextBoxColumn1
            // 
            this.myNameDataGridViewTextBoxColumn1.DataPropertyName = "MyName";
            this.myNameDataGridViewTextBoxColumn1.HeaderText = "Boy-Name";
            this.myNameDataGridViewTextBoxColumn1.Name = "myNameDataGridViewTextBoxColumn1";
            // 
            // mobileNumDataGridViewTextBoxColumn1
            // 
            this.mobileNumDataGridViewTextBoxColumn1.DataPropertyName = "MobileNum";
            this.mobileNumDataGridViewTextBoxColumn1.HeaderText = "MobileNum";
            this.mobileNumDataGridViewTextBoxColumn1.Name = "mobileNumDataGridViewTextBoxColumn1";
            // 
            // boysLikeConcatDataGridViewTextBoxColumn
            // 
            this.boysLikeConcatDataGridViewTextBoxColumn.DataPropertyName = "BoysLikeConcat";
            this.boysLikeConcatDataGridViewTextBoxColumn.HeaderText = "BoysLikeConcat";
            this.boysLikeConcatDataGridViewTextBoxColumn.Name = "boysLikeConcatDataGridViewTextBoxColumn";
            this.boysLikeConcatDataGridViewTextBoxColumn.Visible = false;
            // 
            // boysLikedByConcatDataGridViewTextBoxColumn
            // 
            this.boysLikedByConcatDataGridViewTextBoxColumn.DataPropertyName = "BoysLikedByConcat";
            this.boysLikedByConcatDataGridViewTextBoxColumn.HeaderText = "BoysLikedByConcat";
            this.boysLikedByConcatDataGridViewTextBoxColumn.Name = "boysLikedByConcatDataGridViewTextBoxColumn";
            this.boysLikedByConcatDataGridViewTextBoxColumn.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCtrlCToolStripMenuItem,
            this.pasteCtrlVToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(258, 48);
            // 
            // copyCtrlCToolStripMenuItem
            // 
            this.copyCtrlCToolStripMenuItem.Name = "copyCtrlCToolStripMenuItem";
            this.copyCtrlCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyCtrlCToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.copyCtrlCToolStripMenuItem.Text = "Copy  ";
            this.copyCtrlCToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteCtrlVToolStripMenuItem1
            // 
            this.pasteCtrlVToolStripMenuItem1.Name = "pasteCtrlVToolStripMenuItem1";
            this.pasteCtrlVToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteCtrlVToolStripMenuItem1.Size = new System.Drawing.Size(257, 22);
            this.pasteCtrlVToolStripMenuItem1.Text = "Paste At The End (Append)";
            this.pasteCtrlVToolStripMenuItem1.Click += new System.EventHandler(this.pasteCtrlVToolStripMenuItem_Click);
            // 
            // boysBindingSource
            // 
            this.boysBindingSource.DataMember = "Boys";
            this.boysBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvGirls
            // 
            this.dgvGirls.AutoGenerateColumns = false;
            this.dgvGirls.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvGirls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGirls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvGirls.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvGirls.DataSource = this.girlsBindingSource;
            this.dgvGirls.Location = new System.Drawing.Point(57, 38);
            this.dgvGirls.Name = "dgvGirls";
            this.dgvGirls.Size = new System.Drawing.Size(297, 385);
            this.dgvGirls.TabIndex = 1;
            this.dgvGirls.Visible = false;
            this.dgvGirls.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGirls_RowLeave);
            this.dgvGirls.Enter += new System.EventHandler(this.dgvGirls_Enter);
            this.dgvGirls.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgData_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCandidatePK";
            this.dataGridViewTextBoxColumn1.HeaderText = "Girl-Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MyName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Girl-Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MobileNum";
            this.dataGridViewTextBoxColumn3.HeaderText = "Girl-MobileNum";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // girlsBindingSource
            // 
            this.girlsBindingSource.DataMember = "Girls";
            this.girlsBindingSource.DataSource = this.dataSet1;
            // 
            // boysTableAdapter
            // 
            this.boysTableAdapter.ClearBeforeFill = true;
            // 
            // girlsTableAdapter
            // 
            this.girlsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoysLikedByTableAdapter = null;
            this.tableAdapterManager.BoysLikeTableAdapter = this.boysLikeTableAdapter;
            this.tableAdapterManager.BoysTableAdapter = this.boysTableAdapter;
            this.tableAdapterManager.GirlsLikedByTableAdapter = null;
            this.tableAdapterManager.GirlsLikeTableAdapter = null;
            this.tableAdapterManager.GirlsTableAdapter = this.girlsTableAdapter;
            this.tableAdapterManager.UpdateOrder = YuvaParichay.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // boysLikeTableAdapter
            // 
            this.boysLikeTableAdapter.ClearBeforeFill = true;
            // 
            // btnSaveStep1Boy
            // 
            this.btnSaveStep1Boy.Location = new System.Drawing.Point(219, 593);
            this.btnSaveStep1Boy.Name = "btnSaveStep1Boy";
            this.btnSaveStep1Boy.Size = new System.Drawing.Size(110, 32);
            this.btnSaveStep1Boy.TabIndex = 2;
            this.btnSaveStep1Boy.Text = "Save Boy Data";
            this.btnSaveStep1Boy.UseVisualStyleBackColor = true;
            this.btnSaveStep1Boy.Click += new System.EventHandler(this.btnSaveStep1Boy_Click);
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.AllowDrop = true;
            this.pnlDataGrid.AutoSize = true;
            this.pnlDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataGrid.Controls.Add(this.dgvQryMatchBoyGirl);
            this.pnlDataGrid.Controls.Add(this.listBoxGirls);
            this.pnlDataGrid.Controls.Add(this.dgvGirlsLike);
            this.pnlDataGrid.Controls.Add(this.listBoxBoys);
            this.pnlDataGrid.Controls.Add(this.dgvBoysLike);
            this.pnlDataGrid.Controls.Add(this.dgvBoys);
            this.pnlDataGrid.Controls.Add(this.dgvGirls);
            this.pnlDataGrid.Location = new System.Drawing.Point(213, 110);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Size = new System.Drawing.Size(752, 463);
            this.pnlDataGrid.TabIndex = 4;
            this.pnlDataGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDataGrid_Paint);
            // 
            // dgvQryMatchBoyGirl
            // 
            this.dgvQryMatchBoyGirl.AutoGenerateColumns = false;
            this.dgvQryMatchBoyGirl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQryMatchBoyGirl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCandidateFKDataGridViewTextBoxColumn3,
            this.idILikeDataGridViewTextBoxColumn2,
            this.idLikedByDataGridViewTextBoxColumn1});
            this.dgvQryMatchBoyGirl.DataSource = this.qryMatchBoyGirlBindingSource;
            this.dgvQryMatchBoyGirl.Location = new System.Drawing.Point(7, 429);
            this.dgvQryMatchBoyGirl.Name = "dgvQryMatchBoyGirl";
            this.dgvQryMatchBoyGirl.Size = new System.Drawing.Size(207, 20);
            this.dgvQryMatchBoyGirl.TabIndex = 8;
            this.dgvQryMatchBoyGirl.Visible = false;
            this.dgvQryMatchBoyGirl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQryMatchBoyGirl_CellContentClick);
            // 
            // idCandidateFKDataGridViewTextBoxColumn3
            // 
            this.idCandidateFKDataGridViewTextBoxColumn3.DataPropertyName = "IdCandidateFK";
            this.idCandidateFKDataGridViewTextBoxColumn3.HeaderText = "Boy-Code";
            this.idCandidateFKDataGridViewTextBoxColumn3.Name = "idCandidateFKDataGridViewTextBoxColumn3";
            // 
            // idILikeDataGridViewTextBoxColumn2
            // 
            this.idILikeDataGridViewTextBoxColumn2.DataPropertyName = "IdILike";
            this.idILikeDataGridViewTextBoxColumn2.HeaderText = "Girl-Code";
            this.idILikeDataGridViewTextBoxColumn2.Name = "idILikeDataGridViewTextBoxColumn2";
            // 
            // idLikedByDataGridViewTextBoxColumn1
            // 
            this.idLikedByDataGridViewTextBoxColumn1.DataPropertyName = "IdLikedBy";
            this.idLikedByDataGridViewTextBoxColumn1.HeaderText = "IdLikedBy";
            this.idLikedByDataGridViewTextBoxColumn1.Name = "idLikedByDataGridViewTextBoxColumn1";
            this.idLikedByDataGridViewTextBoxColumn1.Visible = false;
            // 
            // qryMatchBoyGirlBindingSource
            // 
            this.qryMatchBoyGirlBindingSource.DataMember = "qryMatchBoyGirl";
            this.qryMatchBoyGirlBindingSource.DataSource = this.dataSet1;
            // 
            // listBoxGirls
            // 
            this.listBoxGirls.DataSource = this.girlsBindingSource;
            this.listBoxGirls.DisplayMember = "IdCandidatePK";
            this.listBoxGirls.FormattingEnabled = true;
            this.listBoxGirls.Location = new System.Drawing.Point(240, 6);
            this.listBoxGirls.Name = "listBoxGirls";
            this.listBoxGirls.Size = new System.Drawing.Size(74, 433);
            this.listBoxGirls.TabIndex = 6;
            this.listBoxGirls.Visible = false;
            this.listBoxGirls.SelectedIndexChanged += new System.EventHandler(this.listBoxGirls_SelectedIndexChanged);
            // 
            // dgvGirlsLike
            // 
            this.dgvGirlsLike.AutoGenerateColumns = false;
            this.dgvGirlsLike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGirlsLike.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCandidateFKDataGridViewTextBoxColumn1,
            this.idILikeDataGridViewTextBoxColumn1});
            this.dgvGirlsLike.DataSource = this.girlsLikeBindingSource;
            this.dgvGirlsLike.Location = new System.Drawing.Point(373, 6);
            this.dgvGirlsLike.Name = "dgvGirlsLike";
            this.dgvGirlsLike.Size = new System.Drawing.Size(253, 388);
            this.dgvGirlsLike.TabIndex = 5;
            this.dgvGirlsLike.Visible = false;
            this.dgvGirlsLike.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGirlsLike_CellContentClick);
            this.dgvGirlsLike.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvGirlsLike_CurrentCellDirtyStateChanged);
            this.dgvGirlsLike.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGirlsLike_RowLeave);
            // 
            // idCandidateFKDataGridViewTextBoxColumn1
            // 
            this.idCandidateFKDataGridViewTextBoxColumn1.DataPropertyName = "IdCandidateFK";
            this.idCandidateFKDataGridViewTextBoxColumn1.HeaderText = "Girl-Code";
            this.idCandidateFKDataGridViewTextBoxColumn1.Name = "idCandidateFKDataGridViewTextBoxColumn1";
            // 
            // idILikeDataGridViewTextBoxColumn1
            // 
            this.idILikeDataGridViewTextBoxColumn1.DataPropertyName = "IdILike";
            this.idILikeDataGridViewTextBoxColumn1.HeaderText = "Boy-Code of Choice";
            this.idILikeDataGridViewTextBoxColumn1.Name = "idILikeDataGridViewTextBoxColumn1";
            // 
            // girlsLikeBindingSource
            // 
            this.girlsLikeBindingSource.DataMember = "GirlsLike";
            this.girlsLikeBindingSource.DataSource = this.dataSet1;
            // 
            // listBoxBoys
            // 
            this.listBoxBoys.DataSource = this.boysBindingSource;
            this.listBoxBoys.DisplayMember = "IdCandidatePK";
            this.listBoxBoys.FormattingEnabled = true;
            this.listBoxBoys.Location = new System.Drawing.Point(290, 16);
            this.listBoxBoys.Name = "listBoxBoys";
            this.listBoxBoys.Size = new System.Drawing.Size(64, 433);
            this.listBoxBoys.TabIndex = 4;
            this.listBoxBoys.Visible = false;
            this.listBoxBoys.SelectedIndexChanged += new System.EventHandler(this.listBoxBoys_SelectedIndexChanged);
            // 
            // dgvBoysLike
            // 
            this.dgvBoysLike.AutoGenerateColumns = false;
            this.dgvBoysLike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoysLike.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCandidateFKDataGridViewTextBoxColumn,
            this.idILikeDataGridViewTextBoxColumn});
            this.dgvBoysLike.DataMember = "BoysLike";
            this.dgvBoysLike.DataSource = this.boysLikeBindingSource;
            this.dgvBoysLike.Location = new System.Drawing.Point(407, 16);
            this.dgvBoysLike.Name = "dgvBoysLike";
            this.dgvBoysLike.Size = new System.Drawing.Size(243, 433);
            this.dgvBoysLike.TabIndex = 2;
            this.dgvBoysLike.Visible = false;
            this.dgvBoysLike.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoysLike_CellContentClick);
            this.dgvBoysLike.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvBoysLike_CurrentCellDirtyStateChanged);
            this.dgvBoysLike.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoysLike_RowLeave);
            this.dgvBoysLike.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvBoysLike_RowsRemoved);
            // 
            // idCandidateFKDataGridViewTextBoxColumn
            // 
            this.idCandidateFKDataGridViewTextBoxColumn.DataPropertyName = "IdCandidateFK";
            this.idCandidateFKDataGridViewTextBoxColumn.HeaderText = "Boy-Code";
            this.idCandidateFKDataGridViewTextBoxColumn.Name = "idCandidateFKDataGridViewTextBoxColumn";
            // 
            // idILikeDataGridViewTextBoxColumn
            // 
            this.idILikeDataGridViewTextBoxColumn.DataPropertyName = "IdILike";
            this.idILikeDataGridViewTextBoxColumn.HeaderText = "Girl-Code of Choice";
            this.idILikeDataGridViewTextBoxColumn.Name = "idILikeDataGridViewTextBoxColumn";
            // 
            // boysLikeBindingSource
            // 
            this.boysLikeBindingSource.DataSource = this.dataSet1;
            this.boysLikeBindingSource.Position = 0;
            // 
            // dgvSql
            // 
            this.dgvSql.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSql.Location = new System.Drawing.Point(396, 579);
            this.dgvSql.Name = "dgvSql";
            this.dgvSql.Size = new System.Drawing.Size(242, 50);
            this.dgvSql.TabIndex = 3;
            this.dgvSql.Visible = false;
            // 
            // pnlContextHelp
            // 
            this.pnlContextHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContextHelp.Controls.Add(this.txtStepHelp);
            this.pnlContextHelp.Location = new System.Drawing.Point(212, 34);
            this.pnlContextHelp.Name = "pnlContextHelp";
            this.pnlContextHelp.Size = new System.Drawing.Size(753, 77);
            this.pnlContextHelp.TabIndex = 4;
            // 
            // txtStepHelp
            // 
            this.txtStepHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStepHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStepHelp.Location = new System.Drawing.Point(0, 0);
            this.txtStepHelp.Multiline = true;
            this.txtStepHelp.Name = "txtStepHelp";
            this.txtStepHelp.Size = new System.Drawing.Size(751, 75);
            this.txtStepHelp.TabIndex = 4;
            this.txtStepHelp.TextChanged += new System.EventHandler(this.txtStepHelp_TextChanged);
            // 
            // pnlProcessSteps
            // 
            this.pnlProcessSteps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlProcessSteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProcessSteps.Controls.Add(this.label12);
            this.pnlProcessSteps.Controls.Add(this.groupBox6);
            this.pnlProcessSteps.Controls.Add(this.label3);
            this.pnlProcessSteps.Controls.Add(this.groupBox4);
            this.pnlProcessSteps.Controls.Add(this.groupBox2);
            this.pnlProcessSteps.Controls.Add(this.groupBox1);
            this.pnlProcessSteps.Controls.Add(this.grpStep1);
            this.pnlProcessSteps.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProcessSteps.Location = new System.Drawing.Point(0, 0);
            this.pnlProcessSteps.Name = "pnlProcessSteps";
            this.pnlProcessSteps.Size = new System.Drawing.Size(206, 629);
            this.pnlProcessSteps.TabIndex = 5;
            this.pnlProcessSteps.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProcessSteps_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Procedure:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.btnStep5GirlsSMS);
            this.groupBox6.Controls.Add(this.btnStep5BoysSMS);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.lblStep5);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(3, 483);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 101);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button11);
            this.groupBox7.Controls.Add(this.button12);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Location = new System.Drawing.Point(8, 279);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 100);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(133, 70);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 23);
            this.button11.TabIndex = 3;
            this.button11.Text = "Girls";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(71, 70);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(56, 23);
            this.button12.TabIndex = 2;
            this.button12.Text = "Boys";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(71, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 63);
            this.label13.TabIndex = 1;
            this.label13.Text = "Enter/Edit Primary Data (To be Completed Before Sammelan Day)\r\n";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(6, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 31);
            this.label14.TabIndex = 0;
            this.label14.Text = "Step-I ";
            // 
            // btnStep5GirlsSMS
            // 
            this.btnStep5GirlsSMS.Enabled = false;
            this.btnStep5GirlsSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStep5GirlsSMS.Location = new System.Drawing.Point(133, 70);
            this.btnStep5GirlsSMS.Name = "btnStep5GirlsSMS";
            this.btnStep5GirlsSMS.Size = new System.Drawing.Size(50, 23);
            this.btnStep5GirlsSMS.TabIndex = 3;
            this.btnStep5GirlsSMS.Text = "Girls";
            this.btnStep5GirlsSMS.UseVisualStyleBackColor = true;
            // 
            // btnStep5BoysSMS
            // 
            this.btnStep5BoysSMS.Enabled = false;
            this.btnStep5BoysSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStep5BoysSMS.Location = new System.Drawing.Point(71, 70);
            this.btnStep5BoysSMS.Name = "btnStep5BoysSMS";
            this.btnStep5BoysSMS.Size = new System.Drawing.Size(56, 23);
            this.btnStep5BoysSMS.TabIndex = 2;
            this.btnStep5BoysSMS.Text = "Boys";
            this.btnStep5BoysSMS.UseVisualStyleBackColor = true;
            this.btnStep5BoysSMS.Click += new System.EventHandler(this.btnStep5BoysSMS_Click);
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(71, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 63);
            this.label15.TabIndex = 1;
            this.label15.Text = "Optional: Send SMS of individual details from Reports of Step-4 to each Candidate" +
    "";
            // 
            // lblStep5
            // 
            this.lblStep5.Enabled = false;
            this.lblStep5.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStep5.Location = new System.Drawing.Point(6, 36);
            this.lblStep5.Name = "lblStep5";
            this.lblStep5.Size = new System.Drawing.Size(65, 31);
            this.lblStep5.TabIndex = 0;
            this.lblStep5.Text = "Step-5";
            this.lblStep5.Click += new System.EventHandler(this.lblStep5_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Click The Word \'Step-\' To Change Onscreen Help";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.btnPrint);
            this.groupBox4.Controls.Add(this.btnPreview);
            this.groupBox4.Controls.Add(this.btnStep4MatchReport);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnStep4GirlsReport);
            this.groupBox4.Controls.Add(this.btnStep4BoysReport);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.lblStep4);
            this.groupBox4.Location = new System.Drawing.Point(4, 345);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 129);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(109, 94);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.CausesValidation = false;
            this.btnPreview.Enabled = false;
            this.btnPreview.Location = new System.Drawing.Point(6, 94);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(97, 24);
            this.btnPreview.TabIndex = 8;
            this.btnPreview.Text = "Print Pre&view";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Visible = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnStep4MatchReport
            // 
            this.btnStep4MatchReport.BackColor = System.Drawing.Color.White;
            this.btnStep4MatchReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStep4MatchReport.Location = new System.Drawing.Point(104, 60);
            this.btnStep4MatchReport.Name = "btnStep4MatchReport";
            this.btnStep4MatchReport.Size = new System.Drawing.Size(90, 23);
            this.btnStep4MatchReport.TabIndex = 7;
            this.btnStep4MatchReport.Text = "MatchBoth";
            this.btnStep4MatchReport.UseVisualStyleBackColor = false;
            this.btnStep4MatchReport.Click += new System.EventHandler(this.btnStep4MatchReport_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(8, 279);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(133, 70);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Girls";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(71, 70);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Boys";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(71, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 63);
            this.label9.TabIndex = 1;
            this.label9.Text = "Enter/Edit Primary Data (To be Completed Before Sammelan Day)\r\n";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(6, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Step-I ";
            // 
            // btnStep4GirlsReport
            // 
            this.btnStep4GirlsReport.BackColor = System.Drawing.Color.White;
            this.btnStep4GirlsReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStep4GirlsReport.Location = new System.Drawing.Point(54, 59);
            this.btnStep4GirlsReport.Name = "btnStep4GirlsReport";
            this.btnStep4GirlsReport.Size = new System.Drawing.Size(50, 23);
            this.btnStep4GirlsReport.TabIndex = 3;
            this.btnStep4GirlsReport.Text = "Girls";
            this.btnStep4GirlsReport.UseVisualStyleBackColor = false;
            this.btnStep4GirlsReport.Click += new System.EventHandler(this.btnStep4GirlsReport_Click);
            // 
            // btnStep4BoysReport
            // 
            this.btnStep4BoysReport.BackColor = System.Drawing.Color.White;
            this.btnStep4BoysReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStep4BoysReport.Location = new System.Drawing.Point(1, 60);
            this.btnStep4BoysReport.Name = "btnStep4BoysReport";
            this.btnStep4BoysReport.Size = new System.Drawing.Size(51, 23);
            this.btnStep4BoysReport.TabIndex = 2;
            this.btnStep4BoysReport.Text = "Boys";
            this.btnStep4BoysReport.UseVisualStyleBackColor = false;
            this.btnStep4BoysReport.Click += new System.EventHandler(this.btnStep4BoysReport_Click);
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(71, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 53);
            this.label11.TabIndex = 1;
            this.label11.Text = "Shows Reports Generated by Step-3.";
            // 
            // lblStep4
            // 
            this.lblStep4.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStep4.Location = new System.Drawing.Point(5, 21);
            this.lblStep4.Name = "lblStep4";
            this.lblStep4.Size = new System.Drawing.Size(65, 31);
            this.lblStep4.TabIndex = 0;
            this.lblStep4.Text = "Step-4";
            this.lblStep4.Click += new System.EventHandler(this.lblStep4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnProcessData);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblStep3);
            this.groupBox2.Location = new System.Drawing.Point(4, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 105);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(8, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(133, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Girls";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(71, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Boys";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(71, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 63);
            this.label7.TabIndex = 1;
            this.label7.Text = "Enter/Edit Primary Data (To be Completed Before Sammelan Day)\r\n";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(6, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Step-I ";
            // 
            // btnProcessData
            // 
            this.btnProcessData.BackColor = System.Drawing.Color.White;
            this.btnProcessData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessData.Location = new System.Drawing.Point(6, 80);
            this.btnProcessData.Name = "btnProcessData";
            this.btnProcessData.Size = new System.Drawing.Size(190, 25);
            this.btnProcessData.TabIndex = 2;
            this.btnProcessData.Text = "Process Data of Step1-2";
            this.btnProcessData.UseVisualStyleBackColor = false;
            this.btnProcessData.Click += new System.EventHandler(this.btnProcessData_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(71, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 70);
            this.label5.TabIndex = 1;
            this.label5.Text = "It is for only processing of data of STEP-1/2. It must be done before Step-4 and " +
    "repeated if Step1/2 is modified.\r\n";
            // 
            // lblStep3
            // 
            this.lblStep3.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStep3.Location = new System.Drawing.Point(6, 16);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(65, 31);
            this.lblStep3.TabIndex = 0;
            this.lblStep3.Text = "Step-3";
            this.lblStep3.Click += new System.EventHandler(this.lblStep3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnStep2Girls);
            this.groupBox1.Controls.Add(this.btnStep2Boys);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblStep2);
            this.groupBox1.Location = new System.Drawing.Point(3, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnStep2Girls
            // 
            this.btnStep2Girls.BackColor = System.Drawing.Color.White;
            this.btnStep2Girls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStep2Girls.Location = new System.Drawing.Point(133, 70);
            this.btnStep2Girls.Name = "btnStep2Girls";
            this.btnStep2Girls.Size = new System.Drawing.Size(50, 23);
            this.btnStep2Girls.TabIndex = 3;
            this.btnStep2Girls.Text = "Girls";
            this.btnStep2Girls.UseVisualStyleBackColor = false;
            this.btnStep2Girls.Click += new System.EventHandler(this.btnStep2Girls_Click);
            // 
            // btnStep2Boys
            // 
            this.btnStep2Boys.BackColor = System.Drawing.Color.White;
            this.btnStep2Boys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStep2Boys.Location = new System.Drawing.Point(71, 70);
            this.btnStep2Boys.Name = "btnStep2Boys";
            this.btnStep2Boys.Size = new System.Drawing.Size(56, 23);
            this.btnStep2Boys.TabIndex = 2;
            this.btnStep2Boys.Text = "Boys";
            this.btnStep2Boys.UseVisualStyleBackColor = false;
            this.btnStep2Boys.Click += new System.EventHandler(this.btnStep2Boys_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(71, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter/Edit Candidate Choices after Introduction Session\r\n";
            // 
            // lblStep2
            // 
            this.lblStep2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStep2.Location = new System.Drawing.Point(6, 36);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(65, 31);
            this.lblStep2.TabIndex = 0;
            this.lblStep2.Text = "Step-2 ";
            this.lblStep2.Click += new System.EventHandler(this.lblStep2_Click);
            // 
            // grpStep1
            // 
            this.grpStep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpStep1.Controls.Add(this.btnStep1Girls);
            this.grpStep1.Controls.Add(this.btnStep1Boys);
            this.grpStep1.Controls.Add(this.label2);
            this.grpStep1.Controls.Add(this.lblStep1);
            this.grpStep1.Location = new System.Drawing.Point(3, 45);
            this.grpStep1.Name = "grpStep1";
            this.grpStep1.Size = new System.Drawing.Size(200, 100);
            this.grpStep1.TabIndex = 1;
            this.grpStep1.TabStop = false;
            this.grpStep1.Enter += new System.EventHandler(this.grpStep1_Enter);
            this.grpStep1.MouseHover += new System.EventHandler(this.grpStep1_MouseHover);
            // 
            // btnStep1Girls
            // 
            this.btnStep1Girls.BackColor = System.Drawing.Color.White;
            this.btnStep1Girls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStep1Girls.Location = new System.Drawing.Point(133, 70);
            this.btnStep1Girls.Name = "btnStep1Girls";
            this.btnStep1Girls.Size = new System.Drawing.Size(50, 23);
            this.btnStep1Girls.TabIndex = 3;
            this.btnStep1Girls.Text = "Girls";
            this.btnStep1Girls.UseVisualStyleBackColor = false;
            this.btnStep1Girls.Click += new System.EventHandler(this.btnStep1Girls_Click_1);
            // 
            // btnStep1Boys
            // 
            this.btnStep1Boys.BackColor = System.Drawing.Color.White;
            this.btnStep1Boys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStep1Boys.Location = new System.Drawing.Point(71, 70);
            this.btnStep1Boys.Name = "btnStep1Boys";
            this.btnStep1Boys.Size = new System.Drawing.Size(56, 23);
            this.btnStep1Boys.TabIndex = 2;
            this.btnStep1Boys.Text = "Boys";
            this.btnStep1Boys.UseVisualStyleBackColor = false;
            this.btnStep1Boys.Click += new System.EventHandler(this.btnStep1Boys_Click_1);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(71, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter/Edit Primary Data (To be Completed Before Sammelan Day)\r\n";
            // 
            // lblStep1
            // 
            this.lblStep1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStep1.Location = new System.Drawing.Point(6, 25);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(65, 31);
            this.lblStep1.TabIndex = 0;
            this.lblStep1.Text = "Step-1";
            this.lblStep1.Click += new System.EventHandler(this.lblStep1_Click);
            // 
            // btnSaveStep1Girl
            // 
            this.btnSaveStep1Girl.Location = new System.Drawing.Point(335, 591);
            this.btnSaveStep1Girl.Name = "btnSaveStep1Girl";
            this.btnSaveStep1Girl.Size = new System.Drawing.Size(115, 34);
            this.btnSaveStep1Girl.TabIndex = 6;
            this.btnSaveStep1Girl.Text = "Save Girl data";
            this.btnSaveStep1Girl.UseVisualStyleBackColor = true;
            this.btnSaveStep1Girl.Click += new System.EventHandler(this.btnSaveStep1Girl_Click);
            // 
            // btnSaveStep2BoyChoices
            // 
            this.btnSaveStep2BoyChoices.Location = new System.Drawing.Point(489, 591);
            this.btnSaveStep2BoyChoices.Name = "btnSaveStep2BoyChoices";
            this.btnSaveStep2BoyChoices.Size = new System.Drawing.Size(108, 34);
            this.btnSaveStep2BoyChoices.TabIndex = 7;
            this.btnSaveStep2BoyChoices.Text = "Save Boy Choices";
            this.btnSaveStep2BoyChoices.UseVisualStyleBackColor = true;
            this.btnSaveStep2BoyChoices.Click += new System.EventHandler(this.btnSaveStep2BoyChoices_Click);
            // 
            // btnSaveStep2GirlChoices
            // 
            this.btnSaveStep2GirlChoices.Location = new System.Drawing.Point(603, 591);
            this.btnSaveStep2GirlChoices.Name = "btnSaveStep2GirlChoices";
            this.btnSaveStep2GirlChoices.Size = new System.Drawing.Size(102, 33);
            this.btnSaveStep2GirlChoices.TabIndex = 8;
            this.btnSaveStep2GirlChoices.Text = "Save Girl Choices";
            this.btnSaveStep2GirlChoices.UseVisualStyleBackColor = true;
            this.btnSaveStep2GirlChoices.Click += new System.EventHandler(this.btnSaveStep2GirlChoices_Click);
            // 
            // girlsLikeTableAdapter
            // 
            this.girlsLikeTableAdapter.ClearBeforeFill = true;
            // 
            // boysLikedByTableAdapter1
            // 
            this.boysLikedByTableAdapter1.ClearBeforeFill = true;
            // 
            // girlsLikedByTableAdapter1
            // 
            this.girlsLikedByTableAdapter1.ClearBeforeFill = true;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // progressBarShare
            // 
            this.progressBarShare.Location = new System.Drawing.Point(217, 579);
            this.progressBarShare.Name = "progressBarShare";
            this.progressBarShare.Size = new System.Drawing.Size(640, 10);
            this.progressBarShare.Step = 5;
            this.progressBarShare.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarShare.TabIndex = 2;
            this.progressBarShare.UseWaitCursor = true;
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.AutoSize = false;
            this.menuStripMainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripMainMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemTools,
            this.toolStripMenuItemHelp,
            this.toolStripMenuItemDonate});
            this.menuStripMainMenu.Location = new System.Drawing.Point(212, 0);
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            this.menuStripMainMenu.Size = new System.Drawing.Size(239, 31);
            this.menuStripMainMenu.TabIndex = 10;
            this.menuStripMainMenu.Text = "MainMenu";
            this.menuStripMainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripMainMenu_ItemClicked);
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delCurDataAndRestoreFromToolStripMenuItem,
            this.delCurrentDataAndCreateNewDataToolStripMenuItem,
            this.delCurrentDataAndLoadSampleDataToolStripMenuItem,
            this.copyBackupDataToToolStripMenuItem});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(44, 27);
            this.toolStripMenuItemFile.Text = "File";
            this.toolStripMenuItemFile.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItemFile.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // delCurDataAndRestoreFromToolStripMenuItem
            // 
            this.delCurDataAndRestoreFromToolStripMenuItem.Name = "delCurDataAndRestoreFromToolStripMenuItem";
            this.delCurDataAndRestoreFromToolStripMenuItem.Size = new System.Drawing.Size(406, 24);
            this.delCurDataAndRestoreFromToolStripMenuItem.Text = "Del Current Data and Retrieve/Restore Data From";
            this.delCurDataAndRestoreFromToolStripMenuItem.Click += new System.EventHandler(this.delCurDataAndRestoreFromToolStripMenuItem_Click);
            // 
            // delCurrentDataAndCreateNewDataToolStripMenuItem
            // 
            this.delCurrentDataAndCreateNewDataToolStripMenuItem.Name = "delCurrentDataAndCreateNewDataToolStripMenuItem";
            this.delCurrentDataAndCreateNewDataToolStripMenuItem.Size = new System.Drawing.Size(406, 24);
            this.delCurrentDataAndCreateNewDataToolStripMenuItem.Text = "Del Current Data And Create New Data";
            this.delCurrentDataAndCreateNewDataToolStripMenuItem.Click += new System.EventHandler(this.delCurrentDataAndCreateNewDataToolStripMenuItem_Click);
            // 
            // delCurrentDataAndLoadSampleDataToolStripMenuItem
            // 
            this.delCurrentDataAndLoadSampleDataToolStripMenuItem.Name = "delCurrentDataAndLoadSampleDataToolStripMenuItem";
            this.delCurrentDataAndLoadSampleDataToolStripMenuItem.Size = new System.Drawing.Size(406, 24);
            this.delCurrentDataAndLoadSampleDataToolStripMenuItem.Text = "Del Current Data And Load Sample Data";
            this.delCurrentDataAndLoadSampleDataToolStripMenuItem.Click += new System.EventHandler(this.delCurrentDataAndLoadSampleDataToolStripMenuItem_Click);
            // 
            // copyBackupDataToToolStripMenuItem
            // 
            this.copyBackupDataToToolStripMenuItem.Name = "copyBackupDataToToolStripMenuItem";
            this.copyBackupDataToToolStripMenuItem.Size = new System.Drawing.Size(406, 24);
            this.copyBackupDataToToolStripMenuItem.Text = "Copy/Backup DataTo";
            this.copyBackupDataToToolStripMenuItem.Click += new System.EventHandler(this.copyBackupDataToToolStripMenuItem_Click);
            // 
            // toolStripMenuItemTools
            // 
            this.toolStripMenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillCodeToolStripMenuItemBoys,
            this.FillCodeToolStripMenuItemGirls,
            this.copyToolStripMenuItem,
            this.pasteAtTheEndAppendToolStripMenuItem});
            this.toolStripMenuItemTools.Name = "toolStripMenuItemTools";
            this.toolStripMenuItemTools.Size = new System.Drawing.Size(57, 27);
            this.toolStripMenuItemTools.Text = "Tools";
            this.toolStripMenuItemTools.Click += new System.EventHandler(this.toolStripMenuItemTools_Click);
            // 
            // fillCodeToolStripMenuItemBoys
            // 
            this.fillCodeToolStripMenuItemBoys.Name = "fillCodeToolStripMenuItemBoys";
            this.fillCodeToolStripMenuItemBoys.Size = new System.Drawing.Size(307, 24);
            this.fillCodeToolStripMenuItemBoys.Text = "Step1-Boys Append Code-Range";
            this.fillCodeToolStripMenuItemBoys.Click += new System.EventHandler(this.fillCodeToolStripMenuItemBoys_Click);
            // 
            // FillCodeToolStripMenuItemGirls
            // 
            this.FillCodeToolStripMenuItemGirls.Name = "FillCodeToolStripMenuItemGirls";
            this.FillCodeToolStripMenuItemGirls.Size = new System.Drawing.Size(307, 24);
            this.FillCodeToolStripMenuItemGirls.Text = "Step1-Girls Append Code-Range";
            this.FillCodeToolStripMenuItemGirls.Click += new System.EventHandler(this.FillCodeToolStripMenuItemGirls_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(307, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteAtTheEndAppendToolStripMenuItem
            // 
            this.pasteAtTheEndAppendToolStripMenuItem.Name = "pasteAtTheEndAppendToolStripMenuItem";
            this.pasteAtTheEndAppendToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteAtTheEndAppendToolStripMenuItem.Size = new System.Drawing.Size(307, 24);
            this.pasteAtTheEndAppendToolStripMenuItem.Text = "Paste At The End (Append)";
            this.pasteAtTheEndAppendToolStripMenuItem.Click += new System.EventHandler(this.pasteCtrlVToolStripMenuItem_Click);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(53, 27);
            this.toolStripMenuItemHelp.Text = "Help";
            this.toolStripMenuItemHelp.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItemHelp.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(166, 24);
            this.toolStripMenuItem2.Text = "View Help";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(166, 24);
            this.toolStripMenuItem3.Text = "Sample";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(166, 24);
            this.toolStripMenuItem4.Text = "Tech Support";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(166, 24);
            this.toolStripMenuItem5.Text = "About";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItemDonate
            // 
            this.toolStripMenuItemDonate.Name = "toolStripMenuItemDonate";
            this.toolStripMenuItemDonate.Size = new System.Drawing.Size(70, 27);
            this.toolStripMenuItemDonate.Text = "Donate";
            this.toolStripMenuItemDonate.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItemDonate.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBox8.Location = new System.Drawing.Point(454, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox8.Size = new System.Drawing.Size(352, 28);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Code Entry Must be Numeric Only, If it has Prefix such as M/F (Male/Female), It s" +
    "hall be entered into Prefix box as onetime entry. ";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(31, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "M";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox9.Controls.Add(this.textBox2);
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Controls.Add(this.textBox1);
            this.groupBox9.Location = new System.Drawing.Point(809, 8);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(156, 23);
            this.groupBox9.TabIndex = 13;
            this.groupBox9.TabStop = false;
            this.groupBox9.Enter += new System.EventHandler(this.groupBox9_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(27, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "F";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Female:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Male:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(711, 599);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(245, 18);
            this.label16.TabIndex = 14;
            this.label16.Text = "<-- All Data are generally auto-saved";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(977, 629);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.menuStripMainMenu);
            this.Controls.Add(this.progressBarShare);
            this.Controls.Add(this.btnSaveStep2GirlChoices);
            this.Controls.Add(this.btnSaveStep2BoyChoices);
            this.Controls.Add(this.btnSaveStep1Girl);
            this.Controls.Add(this.dgvSql);
            this.Controls.Add(this.pnlProcessSteps);
            this.Controls.Add(this.pnlContextHelp);
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.btnSaveStep1Boy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoys)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGirls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlsBindingSource)).EndInit();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQryMatchBoyGirl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryMatchBoyGirlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGirlsLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlsLikeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoysLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boysLikeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSql)).EndInit();
            this.pnlContextHelp.ResumeLayout(false);
            this.pnlContextHelp.PerformLayout();
            this.pnlProcessSteps.ResumeLayout(false);
            this.pnlProcessSteps.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpStep1.ResumeLayout(false);
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private DataSet1TableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridView dgvBoys;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource boysBindingSource;
        private DataSet1TableAdapters.BoysTableAdapter boysTableAdapter;
        private System.Windows.Forms.BindingSource girlsBindingSource;
        private DataSet1TableAdapters.GirlsTableAdapter girlsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvGirls;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyCtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteCtrlVToolStripMenuItem1;
        private System.Windows.Forms.Button btnSaveStep1Boy;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.Panel pnlContextHelp;
        private System.Windows.Forms.Panel pnlProcessSteps;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnStep5GirlsSMS;
        private System.Windows.Forms.Button btnStep5BoysSMS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblStep5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnStep4GirlsReport;
        private System.Windows.Forms.Button btnStep4BoysReport;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblStep4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnProcessData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStep3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStep2Girls;
        private System.Windows.Forms.Button btnStep2Boys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.GroupBox grpStep1;
        private System.Windows.Forms.Button btnStep1Girls;
        private System.Windows.Forms.Button btnStep1Boys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Button btnStep4MatchReport;
        private System.Windows.Forms.TextBox txtStepHelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource boysLikeBindingSource;
        private System.Windows.Forms.DataGridView dgvBoysLike;
        private DataSet1TableAdapters.BoysLikeTableAdapter boysLikeTableAdapter;
        private System.Windows.Forms.Button btnSaveStep1Girl;
        private System.Windows.Forms.Button btnSaveStep2BoyChoices;
        private System.Windows.Forms.Button btnSaveStep2GirlChoices;
        private System.Windows.Forms.DataGridView dgvSql;
        //  private DataSet2 dataSet2;
      //  private DataSet2TableAdapters.BoysTableAdapter boysTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCandidatePKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn myNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCandidatePKDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn myNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn boysLikeConcatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boysLikedByConcatDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBoxBoys;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCandidateFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idILikeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvGirlsLike;
        private System.Windows.Forms.BindingSource girlsLikeBindingSource;
        private DataSet1TableAdapters.GirlsLikeTableAdapter girlsLikeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCandidateFKDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idILikeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ListBox listBoxGirls;
        private System.Windows.Forms.Label label3;
        private DataSet1TableAdapters.qryBoysAndBoysLikedByTableAdapter qryBoysAndBoysLikedByTableAdapter;
        private System.Windows.Forms.DataGridView dgvQryMatchBoyGirl;
        private System.Windows.Forms.BindingSource qryMatchBoyGirlBindingSource;
 //       private DataSet1TableAdapters.qryMatchBoyGirlTableAdapter qryMatchBoyGirlTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCandidateFKDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idILikeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLikedByDataGridViewTextBoxColumn1;
        private DataSet1TableAdapters.BoysLikedByTableAdapter boysLikedByTableAdapter1;
        private DataSet1TableAdapters.GirlsLikedByTableAdapter girlsLikedByTableAdapter1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ProgressBar progressBarShare;
        private System.Windows.Forms.MenuStrip menuStripMainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDonate;
 //       private DataSet1TableAdapters.QueriesTableAdapter queriesTableAdapter2;
 //       private DataSet1TableAdapters.QueriesTableAdapter queriesTableAdapter3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTools;
        private System.Windows.Forms.ToolStripMenuItem fillCodeToolStripMenuItemBoys;
        private System.Windows.Forms.ToolStripMenuItem delCurDataAndRestoreFromToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem FillCodeToolStripMenuItemGirls;
        private System.Windows.Forms.ToolStripMenuItem delCurrentDataAndCreateNewDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delCurrentDataAndLoadSampleDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyBackupDataToToolStripMenuItem;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteAtTheEndAppendToolStripMenuItem;
     
    }
}