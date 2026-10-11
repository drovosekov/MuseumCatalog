namespace MuseumCatalog.Views
{
    partial class AuditLogForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblFilterPC;
        private System.Windows.Forms.TextBox txtFilterPC;
        private System.Windows.Forms.Label lblFilterOp;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFilterFrom;
        private System.Windows.Forms.DateTimePicker dtpFilterFrom;
        private System.Windows.Forms.Label lblFilterTo;
        private System.Windows.Forms.DateTimePicker dtpFilterTo;
        private System.Windows.Forms.DataGridView dgAudit;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnViewCard;
        private System.Windows.Forms.Button btnRestore;

        private void InitializeComponent()
        {
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.txtFilterOp = new System.Windows.Forms.ComboBox();
            this.lblFilterPC = new System.Windows.Forms.Label();
            this.txtFilterPC = new System.Windows.Forms.TextBox();
            this.lblFilterOp = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFilterFrom = new System.Windows.Forms.Label();
            this.dtpFilterFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFilterTo = new System.Windows.Forms.Label();
            this.dtpFilterTo = new System.Windows.Forms.DateTimePicker();
            this.dgAudit = new System.Windows.Forms.DataGridView();
            this.colAuditID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditOp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditExhID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnViewCard = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAudit)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlFilters.Controls.Add(this.txtFilterOp);
            this.pnlFilters.Controls.Add(this.lblFilterPC);
            this.pnlFilters.Controls.Add(this.txtFilterPC);
            this.pnlFilters.Controls.Add(this.lblFilterOp);
            this.pnlFilters.Controls.Add(this.btnApply);
            this.pnlFilters.Controls.Add(this.btnClear);
            this.pnlFilters.Controls.Add(this.lblFilterFrom);
            this.pnlFilters.Controls.Add(this.dtpFilterFrom);
            this.pnlFilters.Controls.Add(this.lblFilterTo);
            this.pnlFilters.Controls.Add(this.dtpFilterTo);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(0, 0);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(929, 62);
            this.pnlFilters.TabIndex = 0;
            // 
            // txtFilterOp
            // 
            this.txtFilterOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFilterOp.FormattingEnabled = true;
            this.txtFilterOp.Items.AddRange(new object[] {
            "OPEN_DB",
            "RESTORE_EXHIBIT",
            "RESTORE_EXHIBIT_NEW",
            "ADD_EXHIBIT",
            "EDIT_EXHIBIT",
            "DELETE_EXHIBIT"});
            this.txtFilterOp.Location = new System.Drawing.Point(332, 5);
            this.txtFilterOp.Name = "txtFilterOp";
            this.txtFilterOp.Size = new System.Drawing.Size(174, 25);
            this.txtFilterOp.TabIndex = 9;
            // 
            // lblFilterPC
            // 
            this.lblFilterPC.AutoSize = true;
            this.lblFilterPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilterPC.Location = new System.Drawing.Point(12, 8);
            this.lblFilterPC.Name = "lblFilterPC";
            this.lblFilterPC.Size = new System.Drawing.Size(31, 17);
            this.lblFilterPC.TabIndex = 0;
            this.lblFilterPC.Text = "ПК:";
            // 
            // txtFilterPC
            // 
            this.txtFilterPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFilterPC.Location = new System.Drawing.Point(47, 6);
            this.txtFilterPC.Name = "txtFilterPC";
            this.txtFilterPC.Size = new System.Drawing.Size(212, 23);
            this.txtFilterPC.TabIndex = 1;
            // 
            // lblFilterOp
            // 
            this.lblFilterOp.AutoSize = true;
            this.lblFilterOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilterOp.Location = new System.Drawing.Point(265, 8);
            this.lblFilterOp.Name = "lblFilterOp";
            this.lblFilterOp.Size = new System.Drawing.Size(70, 17);
            this.lblFilterOp.TabIndex = 2;
            this.lblFilterOp.Text = "Событие:";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApply.Location = new System.Drawing.Point(512, 7);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(114, 51);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Применить";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(632, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 51);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Сбросить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lblFilterFrom
            // 
            this.lblFilterFrom.AutoSize = true;
            this.lblFilterFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilterFrom.Location = new System.Drawing.Point(10, 38);
            this.lblFilterFrom.Name = "lblFilterFrom";
            this.lblFilterFrom.Size = new System.Drawing.Size(65, 17);
            this.lblFilterFrom.TabIndex = 7;
            this.lblFilterFrom.Text = "Дата от:";
            // 
            // dtpFilterFrom
            // 
            this.dtpFilterFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpFilterFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpFilterFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterFrom.Location = new System.Drawing.Point(81, 35);
            this.dtpFilterFrom.Name = "dtpFilterFrom";
            this.dtpFilterFrom.ShowCheckBox = true;
            this.dtpFilterFrom.Size = new System.Drawing.Size(178, 23);
            this.dtpFilterFrom.TabIndex = 3;
            // 
            // lblFilterTo
            // 
            this.lblFilterTo.AutoSize = true;
            this.lblFilterTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilterTo.Location = new System.Drawing.Point(297, 38);
            this.lblFilterTo.Name = "lblFilterTo";
            this.lblFilterTo.Size = new System.Drawing.Size(28, 17);
            this.lblFilterTo.TabIndex = 8;
            this.lblFilterTo.Text = "до:";
            // 
            // dtpFilterTo
            // 
            this.dtpFilterTo.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpFilterTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpFilterTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterTo.Location = new System.Drawing.Point(331, 35);
            this.dtpFilterTo.Name = "dtpFilterTo";
            this.dtpFilterTo.ShowCheckBox = true;
            this.dtpFilterTo.Size = new System.Drawing.Size(175, 23);
            this.dtpFilterTo.TabIndex = 4;
            // 
            // dgAudit
            // 
            this.dgAudit.AllowUserToAddRows = false;
            this.dgAudit.AllowUserToDeleteRows = false;
            this.dgAudit.AllowUserToResizeRows = false;
            this.dgAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAudit.BackgroundColor = System.Drawing.Color.White;
            this.dgAudit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAudit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAuditID,
            this.colAuditDate,
            this.colAuditPC,
            this.colAuditOp,
            this.colAuditExhID});
            this.dgAudit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgAudit.Location = new System.Drawing.Point(0, 62);
            this.dgAudit.Margin = new System.Windows.Forms.Padding(2);
            this.dgAudit.Name = "dgAudit";
            this.dgAudit.ReadOnly = true;
            this.dgAudit.RowHeadersVisible = false;
            this.dgAudit.RowHeadersWidth = 47;
            this.dgAudit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAudit.Size = new System.Drawing.Size(929, 413);
            this.dgAudit.TabIndex = 1;
            this.dgAudit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAudit_CellDoubleClick);
            // 
            // colAuditID
            // 
            this.colAuditID.DataPropertyName = "ID";
            this.colAuditID.HeaderText = "№";
            this.colAuditID.MinimumWidth = 6;
            this.colAuditID.Name = "colAuditID";
            this.colAuditID.ReadOnly = true;
            this.colAuditID.Visible = false;
            this.colAuditID.Width = 60;
            // 
            // colAuditDate
            // 
            this.colAuditDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAuditDate.DataPropertyName = "OperationDate";
            this.colAuditDate.HeaderText = "Дата события";
            this.colAuditDate.MinimumWidth = 6;
            this.colAuditDate.Name = "colAuditDate";
            this.colAuditDate.ReadOnly = true;
            this.colAuditDate.Width = 125;
            // 
            // colAuditPC
            // 
            this.colAuditPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAuditPC.DataPropertyName = "PCIdentifier";
            this.colAuditPC.HeaderText = "ПК";
            this.colAuditPC.MinimumWidth = 6;
            this.colAuditPC.Name = "colAuditPC";
            this.colAuditPC.ReadOnly = true;
            this.colAuditPC.Width = 56;
            // 
            // colAuditOp
            // 
            this.colAuditOp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAuditOp.DataPropertyName = "OperationType";
            this.colAuditOp.HeaderText = "Действие";
            this.colAuditOp.MinimumWidth = 100;
            this.colAuditOp.Name = "colAuditOp";
            this.colAuditOp.ReadOnly = true;
            // 
            // colAuditExhID
            // 
            this.colAuditExhID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAuditExhID.DataPropertyName = "ExhibitID";
            this.colAuditExhID.HeaderText = "ID";
            this.colAuditExhID.MinimumWidth = 6;
            this.colAuditExhID.Name = "colAuditExhID";
            this.colAuditExhID.ReadOnly = true;
            this.colAuditExhID.Width = 52;
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlActions.Controls.Add(this.button1);
            this.pnlActions.Controls.Add(this.btnViewCard);
            this.pnlActions.Controls.Add(this.btnRestore);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(0, 474);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(929, 46);
            this.pnlActions.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Х";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.BtnClearLog_Click);
            // 
            // btnViewCard
            // 
            this.btnViewCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewCard.Location = new System.Drawing.Point(49, 3);
            this.btnViewCard.Name = "btnViewCard";
            this.btnViewCard.Size = new System.Drawing.Size(180, 37);
            this.btnViewCard.TabIndex = 0;
            this.btnViewCard.Text = "Открыть карточку";
            this.btnViewCard.UseVisualStyleBackColor = true;
            this.btnViewCard.Click += new System.EventHandler(this.BtnViewCard_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestore.Location = new System.Drawing.Point(235, 3);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(214, 37);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Восстановить карточку";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // AuditLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.dgAudit);
            this.Controls.Add(this.pnlActions);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(603, 353);
            this.Name = "AuditLogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Журнал работы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuditLogForm_FormClosing);
            this.Load += new System.EventHandler(this.AuditLogForm_Load);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAudit)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox txtFilterOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuditID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuditDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuditPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuditOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuditExhID;
        internal System.Windows.Forms.Button button1;
    }
}
