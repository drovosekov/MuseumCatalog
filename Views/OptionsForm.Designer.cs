
namespace MuseumCatalog.Views
{
    partial class OptionsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddPlace = new System.Windows.Forms.Button();
            this.btnEditPlace = new System.Windows.Forms.Button();
            this.btnDeletePlace = new System.Windows.Forms.Button();
            this.dgPlaces = new System.Windows.Forms.DataGridView();
            this.colPlaceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMuseumName = new System.Windows.Forms.Label();
            this.txtMuseumName = new System.Windows.Forms.TextBox();
            this.lblDbPath = new System.Windows.Forms.Label();
            this.txtDbPath = new System.Windows.Forms.TextBox();
            this.btnBrowseDb = new System.Windows.Forms.Button();
            this.lblTemplatePath = new System.Windows.Forms.Label();
            this.txtTemplatePath = new System.Windows.Forms.TextBox();
            this.btnBrowseTemplate = new System.Windows.Forms.Button();
            this.lblPCId = new System.Windows.Forms.Label();
            this.txtPCId = new System.Windows.Forms.TextBox();
            this.btnCreateDb = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnViewAudit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddPlace);
            this.groupBox1.Controls.Add(this.btnEditPlace);
            this.groupBox1.Controls.Add(this.btnDeletePlace);
            this.groupBox1.Controls.Add(this.dgPlaces);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(210, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 342);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Места хранения";
            // 
            // btnAddPlace
            // 
            this.btnAddPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPlace.Location = new System.Drawing.Point(11, 306);
            this.btnAddPlace.Name = "btnAddPlace";
            this.btnAddPlace.Size = new System.Drawing.Size(120, 30);
            this.btnAddPlace.TabIndex = 3;
            this.btnAddPlace.Text = "Добавить";
            this.btnAddPlace.UseVisualStyleBackColor = true;
            this.btnAddPlace.Click += new System.EventHandler(this.BtnAddPlace_Click);
            // 
            // btnEditPlace
            // 
            this.btnEditPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditPlace.Location = new System.Drawing.Point(137, 306);
            this.btnEditPlace.Name = "btnEditPlace";
            this.btnEditPlace.Size = new System.Drawing.Size(120, 30);
            this.btnEditPlace.TabIndex = 4;
            this.btnEditPlace.Text = "Изменить";
            this.btnEditPlace.UseVisualStyleBackColor = true;
            this.btnEditPlace.Click += new System.EventHandler(this.BtnEditPlace_Click);
            // 
            // btnDeletePlace
            // 
            this.btnDeletePlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeletePlace.Location = new System.Drawing.Point(263, 306);
            this.btnDeletePlace.Name = "btnDeletePlace";
            this.btnDeletePlace.Size = new System.Drawing.Size(120, 30);
            this.btnDeletePlace.TabIndex = 5;
            this.btnDeletePlace.Text = "Удалить";
            this.btnDeletePlace.UseVisualStyleBackColor = true;
            this.btnDeletePlace.Click += new System.EventHandler(this.BtnDeletePlace_Click);
            // 
            // dgPlaces
            // 
            this.dgPlaces.AllowUserToAddRows = false;
            this.dgPlaces.AllowUserToDeleteRows = false;
            this.dgPlaces.AllowUserToResizeColumns = false;
            this.dgPlaces.AllowUserToResizeRows = false;
            this.dgPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlaces.ColumnHeadersVisible = false;
            this.dgPlaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPlaceID,
            this.colPlaceName});
            this.dgPlaces.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgPlaces.Location = new System.Drawing.Point(6, 25);
            this.dgPlaces.MultiSelect = false;
            this.dgPlaces.Name = "dgPlaces";
            this.dgPlaces.ReadOnly = true;
            this.dgPlaces.RowHeadersVisible = false;
            this.dgPlaces.RowHeadersWidth = 30;
            this.dgPlaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPlaces.Size = new System.Drawing.Size(488, 275);
            this.dgPlaces.TabIndex = 1;
            // 
            // colPlaceID
            // 
            this.colPlaceID.DataPropertyName = "ID";
            this.colPlaceID.HeaderText = "ID";
            this.colPlaceID.MinimumWidth = 6;
            this.colPlaceID.Name = "colPlaceID";
            this.colPlaceID.ReadOnly = true;
            this.colPlaceID.Visible = false;
            this.colPlaceID.Width = 50;
            // 
            // colPlaceName
            // 
            this.colPlaceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlaceName.DataPropertyName = "PlaceName";
            this.colPlaceName.HeaderText = "Название";
            this.colPlaceName.MinimumWidth = 6;
            this.colPlaceName.Name = "colPlaceName";
            this.colPlaceName.ReadOnly = true;
            // 
            // lblMuseumName
            // 
            this.lblMuseumName.AutoSize = true;
            this.lblMuseumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMuseumName.Location = new System.Drawing.Point(39, 15);
            this.lblMuseumName.Name = "lblMuseumName";
            this.lblMuseumName.Size = new System.Drawing.Size(164, 17);
            this.lblMuseumName.TabIndex = 14;
            this.lblMuseumName.Text = "Название организации:";
            // 
            // txtMuseumName
            // 
            this.txtMuseumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMuseumName.Location = new System.Drawing.Point(210, 12);
            this.txtMuseumName.Name = "txtMuseumName";
            this.txtMuseumName.Size = new System.Drawing.Size(500, 23);
            this.txtMuseumName.TabIndex = 15;
            // 
            // lblDbPath
            // 
            this.lblDbPath.AutoSize = true;
            this.lblDbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDbPath.Location = new System.Drawing.Point(68, 50);
            this.lblDbPath.Name = "lblDbPath";
            this.lblDbPath.Size = new System.Drawing.Size(135, 17);
            this.lblDbPath.TabIndex = 16;
            this.lblDbPath.Text = "Путь к БД (SQLite):";
            // 
            // txtDbPath
            // 
            this.txtDbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDbPath.Location = new System.Drawing.Point(210, 47);
            this.txtDbPath.Name = "txtDbPath";
            this.txtDbPath.ReadOnly = true;
            this.txtDbPath.Size = new System.Drawing.Size(500, 23);
            this.txtDbPath.TabIndex = 17;
            // 
            // btnBrowseDb
            // 
            this.btnBrowseDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowseDb.Location = new System.Drawing.Point(720, 45);
            this.btnBrowseDb.Name = "btnBrowseDb";
            this.btnBrowseDb.Size = new System.Drawing.Size(75, 27);
            this.btnBrowseDb.TabIndex = 18;
            this.btnBrowseDb.Text = "Обзор...";
            this.btnBrowseDb.UseVisualStyleBackColor = true;
            this.btnBrowseDb.Click += new System.EventHandler(this.BtnBrowseDb_Click);
            // 
            // lblTemplatePath
            // 
            this.lblTemplatePath.AutoSize = true;
            this.lblTemplatePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTemplatePath.Location = new System.Drawing.Point(87, 85);
            this.lblTemplatePath.Name = "lblTemplatePath";
            this.lblTemplatePath.Size = new System.Drawing.Size(116, 17);
            this.lblTemplatePath.TabIndex = 19;
            this.lblTemplatePath.Text = "Путь к шаблону:";
            // 
            // txtTemplatePath
            // 
            this.txtTemplatePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTemplatePath.Location = new System.Drawing.Point(210, 82);
            this.txtTemplatePath.Name = "txtTemplatePath";
            this.txtTemplatePath.ReadOnly = true;
            this.txtTemplatePath.Size = new System.Drawing.Size(500, 23);
            this.txtTemplatePath.TabIndex = 20;
            // 
            // btnBrowseTemplate
            // 
            this.btnBrowseTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowseTemplate.Location = new System.Drawing.Point(720, 80);
            this.btnBrowseTemplate.Name = "btnBrowseTemplate";
            this.btnBrowseTemplate.Size = new System.Drawing.Size(75, 27);
            this.btnBrowseTemplate.TabIndex = 21;
            this.btnBrowseTemplate.Text = "Обзор...";
            this.btnBrowseTemplate.UseVisualStyleBackColor = true;
            this.btnBrowseTemplate.Click += new System.EventHandler(this.BtnBrowseTemplate_Click);
            // 
            // lblPCId
            // 
            this.lblPCId.AutoSize = true;
            this.lblPCId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPCId.Location = new System.Drawing.Point(62, 120);
            this.lblPCId.Name = "lblPCId";
            this.lblPCId.Size = new System.Drawing.Size(141, 17);
            this.lblPCId.TabIndex = 22;
            this.lblPCId.Text = "Идентификатор ПК:";
            // 
            // txtPCId
            // 
            this.txtPCId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPCId.Location = new System.Drawing.Point(210, 117);
            this.txtPCId.Name = "txtPCId";
            this.txtPCId.ReadOnly = true;
            this.txtPCId.Size = new System.Drawing.Size(500, 23);
            this.txtPCId.TabIndex = 23;
            // 
            // btnCreateDb
            // 
            this.btnCreateDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateDb.Location = new System.Drawing.Point(801, 45);
            this.btnCreateDb.Name = "btnCreateDb";
            this.btnCreateDb.Size = new System.Drawing.Size(108, 27);
            this.btnCreateDb.TabIndex = 24;
            this.btnCreateDb.Text = "Создать БД";
            this.btnCreateDb.UseVisualStyleBackColor = true;
            this.btnCreateDb.Click += new System.EventHandler(this.BtnCreateDb_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveSettings.Location = new System.Drawing.Point(720, 432);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(189, 59);
            this.btnSaveSettings.TabIndex = 25;
            this.btnSaveSettings.Text = "Сохранить настройки";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettings_Click);
            // 
            // btnViewAudit
            // 
            this.btnViewAudit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewAudit.Location = new System.Drawing.Point(720, 149);
            this.btnViewAudit.Name = "btnViewAudit";
            this.btnViewAudit.Size = new System.Drawing.Size(189, 40);
            this.btnViewAudit.TabIndex = 27;
            this.btnViewAudit.Text = "Журнал работы";
            this.btnViewAudit.UseVisualStyleBackColor = true;
            this.btnViewAudit.Click += new System.EventHandler(this.BtnViewAudit_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 507);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMuseumName);
            this.Controls.Add(this.txtMuseumName);
            this.Controls.Add(this.lblDbPath);
            this.Controls.Add(this.txtDbPath);
            this.Controls.Add(this.btnBrowseDb);
            this.Controls.Add(this.lblTemplatePath);
            this.Controls.Add(this.txtTemplatePath);
            this.Controls.Add(this.btnBrowseTemplate);
            this.Controls.Add(this.lblPCId);
            this.Controls.Add(this.txtPCId);
            this.Controls.Add(this.btnCreateDb);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.btnViewAudit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки программы";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddPlace;
        private System.Windows.Forms.Button btnEditPlace;
        private System.Windows.Forms.Button btnDeletePlace;
        private System.Windows.Forms.DataGridView dgPlaces;
        private System.Windows.Forms.Label lblMuseumName;
        private System.Windows.Forms.TextBox txtMuseumName;
        private System.Windows.Forms.Label lblDbPath;
        private System.Windows.Forms.TextBox txtDbPath;
        private System.Windows.Forms.Button btnBrowseDb;
        private System.Windows.Forms.Label lblTemplatePath;
        private System.Windows.Forms.TextBox txtTemplatePath;
        private System.Windows.Forms.Button btnBrowseTemplate;
        private System.Windows.Forms.Label lblPCId;
        private System.Windows.Forms.TextBox txtPCId;
        private System.Windows.Forms.Button btnCreateDb;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnViewAudit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaceName;
    }
}