namespace MuseumCatalog.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgExhibits = new System.Windows.Forms.DataGridView();
            this.colExhID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCipher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKPNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStorageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStoragePlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.lblFilterCipher = new System.Windows.Forms.Label();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.txtFilterCipher = new System.Windows.Forms.TextBox();
            this.lblFilterKP = new System.Windows.Forms.Label();
            this.txtFilterKP = new System.Windows.Forms.TextBox();
            this.lblFilterAct = new System.Windows.Forms.Label();
            this.txtFilterAct = new System.Windows.Forms.TextBox();
            this.lblFilterName = new System.Windows.Forms.Label();
            this.txtFilterName = new System.Windows.Forms.TextBox();
            this.lblFilterDesc = new System.Windows.Forms.Label();
            this.txtFilterDesc = new System.Windows.Forms.TextBox();
            this.lblFilterFrom = new System.Windows.Forms.Label();
            this.dtpFilterFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFilterTo = new System.Windows.Forms.Label();
            this.dtpFilterTo = new System.Windows.Forms.DateTimePicker();
            this.lblFilterPlace = new System.Windows.Forms.Label();
            this.cbFilterPlace = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnOptions = new System.Windows.Forms.ToolStripButton();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgExhibits)).BeginInit();
            this.groupBoxFilters.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgExhibits
            // 
            this.dgExhibits.AllowUserToAddRows = false;
            this.dgExhibits.AllowUserToDeleteRows = false;
            this.dgExhibits.AllowUserToResizeRows = false;
            this.dgExhibits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgExhibits.BackgroundColor = System.Drawing.Color.White;
            this.dgExhibits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgExhibits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExhibits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExhID,
            this.colCipher,
            this.colKPNumber,
            this.colItemName,
            this.colDescription,
            this.colTimeStamp,
            this.colSource,
            this.colActNumber,
            this.colMaterial,
            this.colSize,
            this.colCondition,
            this.colStorageID,
            this.colStoragePlace});
            this.dgExhibits.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgExhibits.Location = new System.Drawing.Point(7, 172);
            this.dgExhibits.Name = "dgExhibits";
            this.dgExhibits.ReadOnly = true;
            this.dgExhibits.RowHeadersVisible = false;
            this.dgExhibits.RowHeadersWidth = 47;
            this.dgExhibits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgExhibits.Size = new System.Drawing.Size(1159, 477);
            this.dgExhibits.TabIndex = 1;
            this.dgExhibits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgExhibits_CellDoubleClick);
            // 
            // colExhID
            // 
            this.colExhID.DataPropertyName = "ID";
            this.colExhID.HeaderText = "ID";
            this.colExhID.MinimumWidth = 6;
            this.colExhID.Name = "colExhID";
            this.colExhID.ReadOnly = true;
            this.colExhID.Width = 40;
            // 
            // colCipher
            // 
            this.colCipher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCipher.DataPropertyName = "Cipher";
            this.colCipher.HeaderText = "Шифр";
            this.colCipher.MinimumWidth = 6;
            this.colCipher.Name = "colCipher";
            this.colCipher.ReadOnly = true;
            this.colCipher.Width = 77;
            // 
            // colKPNumber
            // 
            this.colKPNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colKPNumber.DataPropertyName = "KPNumber";
            this.colKPNumber.HeaderText = "№ по КП";
            this.colKPNumber.MinimumWidth = 6;
            this.colKPNumber.Name = "colKPNumber";
            this.colKPNumber.ReadOnly = true;
            this.colKPNumber.Width = 96;
            // 
            // colItemName
            // 
            this.colItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItemName.DataPropertyName = "ItemName";
            this.colItemName.HeaderText = "Наименование";
            this.colItemName.MinimumWidth = 6;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            this.colItemName.Width = 133;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Описание";
            this.colDescription.MinimumWidth = 100;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colTimeStamp
            // 
            this.colTimeStamp.DataPropertyName = "TimeStamp";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            this.colTimeStamp.DefaultCellStyle = dataGridViewCellStyle1;
            this.colTimeStamp.HeaderText = "Время";
            this.colTimeStamp.MinimumWidth = 6;
            this.colTimeStamp.Name = "colTimeStamp";
            this.colTimeStamp.ReadOnly = true;
            this.colTimeStamp.Width = 115;
            // 
            // colSource
            // 
            this.colSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSource.DataPropertyName = "Source";
            this.colSource.HeaderText = "Источник";
            this.colSource.MinimumWidth = 6;
            this.colSource.Name = "colSource";
            this.colSource.ReadOnly = true;
            this.colSource.Width = 99;
            // 
            // colActNumber
            // 
            this.colActNumber.DataPropertyName = "ActNumber";
            this.colActNumber.HeaderText = "№ акта";
            this.colActNumber.MinimumWidth = 6;
            this.colActNumber.Name = "colActNumber";
            this.colActNumber.ReadOnly = true;
            this.colActNumber.Width = 115;
            // 
            // colMaterial
            // 
            this.colMaterial.DataPropertyName = "MaterialTechnique";
            this.colMaterial.HeaderText = "Материал";
            this.colMaterial.MinimumWidth = 6;
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.ReadOnly = true;
            this.colMaterial.Width = 115;
            // 
            // colSize
            // 
            this.colSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSize.DataPropertyName = "Size";
            this.colSize.HeaderText = "Размер";
            this.colSize.MinimumWidth = 6;
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            this.colSize.Width = 84;
            // 
            // colCondition
            // 
            this.colCondition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCondition.DataPropertyName = "Condition";
            this.colCondition.HeaderText = "Сохранность";
            this.colCondition.MinimumWidth = 6;
            this.colCondition.Name = "colCondition";
            this.colCondition.ReadOnly = true;
            this.colCondition.Width = 119;
            // 
            // colStorageID
            // 
            this.colStorageID.DataPropertyName = "StoragePlaceID";
            this.colStorageID.HeaderText = "StoragePlaceID";
            this.colStorageID.MinimumWidth = 6;
            this.colStorageID.Name = "colStorageID";
            this.colStorageID.ReadOnly = true;
            this.colStorageID.Visible = false;
            this.colStorageID.Width = 115;
            // 
            // colStoragePlace
            // 
            this.colStoragePlace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStoragePlace.DataPropertyName = "StoragePlaceName";
            this.colStoragePlace.HeaderText = "Место хранения";
            this.colStoragePlace.MinimumWidth = 6;
            this.colStoragePlace.Name = "colStoragePlace";
            this.colStoragePlace.ReadOnly = true;
            this.colStoragePlace.Width = 141;
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.lblFilterCipher);
            this.groupBoxFilters.Controls.Add(this.btnClearFilter);
            this.groupBoxFilters.Controls.Add(this.btnApplyFilter);
            this.groupBoxFilters.Controls.Add(this.txtFilterCipher);
            this.groupBoxFilters.Controls.Add(this.lblFilterKP);
            this.groupBoxFilters.Controls.Add(this.txtFilterKP);
            this.groupBoxFilters.Controls.Add(this.lblFilterAct);
            this.groupBoxFilters.Controls.Add(this.txtFilterAct);
            this.groupBoxFilters.Controls.Add(this.lblFilterName);
            this.groupBoxFilters.Controls.Add(this.txtFilterName);
            this.groupBoxFilters.Controls.Add(this.lblFilterDesc);
            this.groupBoxFilters.Controls.Add(this.txtFilterDesc);
            this.groupBoxFilters.Controls.Add(this.lblFilterFrom);
            this.groupBoxFilters.Controls.Add(this.dtpFilterFrom);
            this.groupBoxFilters.Controls.Add(this.lblFilterTo);
            this.groupBoxFilters.Controls.Add(this.dtpFilterTo);
            this.groupBoxFilters.Controls.Add(this.lblFilterPlace);
            this.groupBoxFilters.Controls.Add(this.cbFilterPlace);
            this.groupBoxFilters.Location = new System.Drawing.Point(7, 42);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(1065, 124);
            this.groupBoxFilters.TabIndex = 0;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Фильтры";
            // 
            // lblFilterCipher
            // 
            this.lblFilterCipher.AutoSize = true;
            this.lblFilterCipher.Location = new System.Drawing.Point(10, 22);
            this.lblFilterCipher.Name = "lblFilterCipher";
            this.lblFilterCipher.Size = new System.Drawing.Size(48, 19);
            this.lblFilterCipher.TabIndex = 0;
            this.lblFilterCipher.Text = "Шифр";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(880, 85);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(170, 28);
            this.btnClearFilter.TabIndex = 17;
            this.btnClearFilter.Text = "Сбросить";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.BtnClearFilter_Click);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(880, 43);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(170, 28);
            this.btnApplyFilter.TabIndex = 16;
            this.btnApplyFilter.Text = "Применить фильтр";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.BtnApplyFilter_Click);
            // 
            // txtFilterCipher
            // 
            this.txtFilterCipher.Location = new System.Drawing.Point(10, 42);
            this.txtFilterCipher.Name = "txtFilterCipher";
            this.txtFilterCipher.Size = new System.Drawing.Size(200, 26);
            this.txtFilterCipher.TabIndex = 1;
            // 
            // lblFilterKP
            // 
            this.lblFilterKP.AutoSize = true;
            this.lblFilterKP.Location = new System.Drawing.Point(225, 22);
            this.lblFilterKP.Name = "lblFilterKP";
            this.lblFilterKP.Size = new System.Drawing.Size(67, 19);
            this.lblFilterKP.TabIndex = 2;
            this.lblFilterKP.Text = "№ по КП";
            // 
            // txtFilterKP
            // 
            this.txtFilterKP.Location = new System.Drawing.Point(225, 42);
            this.txtFilterKP.Name = "txtFilterKP";
            this.txtFilterKP.Size = new System.Drawing.Size(200, 26);
            this.txtFilterKP.TabIndex = 3;
            // 
            // lblFilterAct
            // 
            this.lblFilterAct.AutoSize = true;
            this.lblFilterAct.Location = new System.Drawing.Point(440, 20);
            this.lblFilterAct.Name = "lblFilterAct";
            this.lblFilterAct.Size = new System.Drawing.Size(56, 19);
            this.lblFilterAct.TabIndex = 4;
            this.lblFilterAct.Text = "№ акта";
            // 
            // txtFilterAct
            // 
            this.txtFilterAct.Location = new System.Drawing.Point(440, 42);
            this.txtFilterAct.Name = "txtFilterAct";
            this.txtFilterAct.Size = new System.Drawing.Size(200, 26);
            this.txtFilterAct.TabIndex = 5;
            // 
            // lblFilterName
            // 
            this.lblFilterName.AutoSize = true;
            this.lblFilterName.Location = new System.Drawing.Point(655, 20);
            this.lblFilterName.Name = "lblFilterName";
            this.lblFilterName.Size = new System.Drawing.Size(104, 19);
            this.lblFilterName.TabIndex = 6;
            this.lblFilterName.Text = "Наименование";
            // 
            // txtFilterName
            // 
            this.txtFilterName.Location = new System.Drawing.Point(655, 43);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(200, 26);
            this.txtFilterName.TabIndex = 7;
            // 
            // lblFilterDesc
            // 
            this.lblFilterDesc.AutoSize = true;
            this.lblFilterDesc.Location = new System.Drawing.Point(10, 66);
            this.lblFilterDesc.Name = "lblFilterDesc";
            this.lblFilterDesc.Size = new System.Drawing.Size(72, 19);
            this.lblFilterDesc.TabIndex = 8;
            this.lblFilterDesc.Text = "Описание";
            // 
            // txtFilterDesc
            // 
            this.txtFilterDesc.Location = new System.Drawing.Point(10, 88);
            this.txtFilterDesc.Name = "txtFilterDesc";
            this.txtFilterDesc.Size = new System.Drawing.Size(200, 26);
            this.txtFilterDesc.TabIndex = 9;
            // 
            // lblFilterFrom
            // 
            this.lblFilterFrom.AutoSize = true;
            this.lblFilterFrom.Location = new System.Drawing.Point(225, 66);
            this.lblFilterFrom.Name = "lblFilterFrom";
            this.lblFilterFrom.Size = new System.Drawing.Size(57, 19);
            this.lblFilterFrom.TabIndex = 10;
            this.lblFilterFrom.Text = "Дата от";
            // 
            // dtpFilterFrom
            // 
            this.dtpFilterFrom.Checked = false;
            this.dtpFilterFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterFrom.Location = new System.Drawing.Point(225, 88);
            this.dtpFilterFrom.Name = "dtpFilterFrom";
            this.dtpFilterFrom.ShowCheckBox = true;
            this.dtpFilterFrom.Size = new System.Drawing.Size(200, 26);
            this.dtpFilterFrom.TabIndex = 11;
            // 
            // lblFilterTo
            // 
            this.lblFilterTo.AutoSize = true;
            this.lblFilterTo.Location = new System.Drawing.Point(440, 66);
            this.lblFilterTo.Name = "lblFilterTo";
            this.lblFilterTo.Size = new System.Drawing.Size(59, 19);
            this.lblFilterTo.TabIndex = 12;
            this.lblFilterTo.Text = "Дата до";
            // 
            // dtpFilterTo
            // 
            this.dtpFilterTo.Checked = false;
            this.dtpFilterTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterTo.Location = new System.Drawing.Point(440, 88);
            this.dtpFilterTo.Name = "dtpFilterTo";
            this.dtpFilterTo.ShowCheckBox = true;
            this.dtpFilterTo.Size = new System.Drawing.Size(200, 26);
            this.dtpFilterTo.TabIndex = 13;
            // 
            // lblFilterPlace
            // 
            this.lblFilterPlace.AutoSize = true;
            this.lblFilterPlace.Location = new System.Drawing.Point(655, 66);
            this.lblFilterPlace.Name = "lblFilterPlace";
            this.lblFilterPlace.Size = new System.Drawing.Size(112, 19);
            this.lblFilterPlace.TabIndex = 14;
            this.lblFilterPlace.Text = "Место хранения";
            // 
            // cbFilterPlace
            // 
            this.cbFilterPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterPlace.FormattingEnabled = true;
            this.cbFilterPlace.Location = new System.Drawing.Point(655, 87);
            this.cbFilterPlace.Name = "cbFilterPlace";
            this.cbFilterPlace.Size = new System.Drawing.Size(200, 27);
            this.cbFilterPlace.TabIndex = 15;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnPrint,
            this.btnOptions,
            this.btnAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1178, 39);
            this.toolStrip1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 36);
            this.btnAdd.Text = "Добавить запись";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 36);
            this.btnEdit.Text = "Изменить";
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 36);
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(248, 36);
            this.btnPrint.Text = "Сохранить карточку для печати";
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(36, 36);
            this.btnOptions.Text = "Настройки";
            this.btnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(36, 36);
            this.btnAbout.Text = "О программе";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 661);
            this.Controls.Add(this.dgExhibits);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBoxFilters);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Музейный каталог";
            ((System.ComponentModel.ISupportInitialize)(this.dgExhibits)).EndInit();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.Label lblFilterCipher;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.TextBox txtFilterCipher;
        private System.Windows.Forms.Label lblFilterKP;
        private System.Windows.Forms.TextBox txtFilterKP;
        private System.Windows.Forms.Label lblFilterAct;
        private System.Windows.Forms.TextBox txtFilterAct;
        private System.Windows.Forms.Label lblFilterName;
        private System.Windows.Forms.TextBox txtFilterName;
        private System.Windows.Forms.Label lblFilterDesc;
        private System.Windows.Forms.TextBox txtFilterDesc;
        private System.Windows.Forms.Label lblFilterFrom;
        private System.Windows.Forms.DateTimePicker dtpFilterFrom;
        private System.Windows.Forms.Label lblFilterTo;
        private System.Windows.Forms.DateTimePicker dtpFilterTo;
        private System.Windows.Forms.Label lblFilterPlace;
        private System.Windows.Forms.ComboBox cbFilterPlace;
        private System.Windows.Forms.DataGridView dgExhibits; 
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExhID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCipher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKPNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStorageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStoragePlace;
        private System.Windows.Forms.ToolStripButton btnAbout;
    }
}
