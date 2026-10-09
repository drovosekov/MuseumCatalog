namespace MuseumCatalog.Views
{
    partial class SettingsForm
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
            this.lblMuseumName = new System.Windows.Forms.Label();
            this.txtMuseumName = new System.Windows.Forms.TextBox();
            this.lblDbPath = new System.Windows.Forms.Label();
            this.txtDbPath = new System.Windows.Forms.TextBox();
            this.btnBrowseDb = new System.Windows.Forms.Button();
            this.lblCreateDb = new System.Windows.Forms.Label();
            this.btnCreateDb = new System.Windows.Forms.Button();
            this.lblTemplatePath = new System.Windows.Forms.Label();
            this.txtTemplatePath = new System.Windows.Forms.TextBox();
            this.btnBrowseTemplate = new System.Windows.Forms.Button();
            this.lblPCId = new System.Windows.Forms.Label();
            this.txtPCId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMuseumName
            // 
            this.lblMuseumName.AutoSize = true;
            this.lblMuseumName.Location = new System.Drawing.Point(20, 25);
            this.lblMuseumName.Name = "lblMuseumName";
            this.lblMuseumName.Size = new System.Drawing.Size(113, 19);
            this.lblMuseumName.TabIndex = 0;
            this.lblMuseumName.Text = "Название музея:";
            // 
            // txtMuseumName
            // 
            this.txtMuseumName.Location = new System.Drawing.Point(170, 22);
            this.txtMuseumName.Name = "txtMuseumName";
            this.txtMuseumName.Size = new System.Drawing.Size(300, 26);
            this.txtMuseumName.TabIndex = 1;
            // 
            // lblDbPath
            // 
            this.lblDbPath.AutoSize = true;
            this.lblDbPath.Location = new System.Drawing.Point(20, 55);
            this.lblDbPath.Name = "lblDbPath";
            this.lblDbPath.Size = new System.Drawing.Size(127, 19);
            this.lblDbPath.TabIndex = 2;
            this.lblDbPath.Text = "Путь к БД (SQLite):";
            // 
            // txtDbPath
            // 
            this.txtDbPath.Location = new System.Drawing.Point(170, 52);
            this.txtDbPath.Name = "txtDbPath";
            this.txtDbPath.ReadOnly = true;
            this.txtDbPath.Size = new System.Drawing.Size(300, 26);
            this.txtDbPath.TabIndex = 3;
            // 
            // btnBrowseDb
            // 
            this.btnBrowseDb.Location = new System.Drawing.Point(476, 51);
            this.btnBrowseDb.Name = "btnBrowseDb";
            this.btnBrowseDb.Size = new System.Drawing.Size(76, 27);
            this.btnBrowseDb.TabIndex = 4;
            this.btnBrowseDb.Text = "Обзор";
            this.btnBrowseDb.UseVisualStyleBackColor = true;
            this.btnBrowseDb.Click += new System.EventHandler(this.BtnBrowseDb_Click);
            // 
            // lblCreateDb
            // 
            this.lblCreateDb.AutoSize = true;
            this.lblCreateDb.Location = new System.Drawing.Point(20, 88);
            this.lblCreateDb.Name = "lblCreateDb";
            this.lblCreateDb.Size = new System.Drawing.Size(108, 19);
            this.lblCreateDb.TabIndex = 5;
            this.lblCreateDb.Text = "Создать новую:";
            // 
            // btnCreateDb
            // 
            this.btnCreateDb.Location = new System.Drawing.Point(170, 85);
            this.btnCreateDb.Name = "btnCreateDb";
            this.btnCreateDb.Size = new System.Drawing.Size(120, 28);
            this.btnCreateDb.TabIndex = 6;
            this.btnCreateDb.Text = "Создать БД";
            this.btnCreateDb.UseVisualStyleBackColor = true;
            this.btnCreateDb.Click += new System.EventHandler(this.BtnCreateDb_Click);
            // 
            // lblTemplatePath
            // 
            this.lblTemplatePath.AutoSize = true;
            this.lblTemplatePath.Location = new System.Drawing.Point(20, 125);
            this.lblTemplatePath.Name = "lblTemplatePath";
            this.lblTemplatePath.Size = new System.Drawing.Size(113, 19);
            this.lblTemplatePath.TabIndex = 7;
            this.lblTemplatePath.Text = "Путь к шаблону:";
            // 
            // txtTemplatePath
            // 
            this.txtTemplatePath.Location = new System.Drawing.Point(170, 122);
            this.txtTemplatePath.Name = "txtTemplatePath";
            this.txtTemplatePath.ReadOnly = true;
            this.txtTemplatePath.Size = new System.Drawing.Size(300, 26);
            this.txtTemplatePath.TabIndex = 8;
            // 
            // btnBrowseTemplate
            // 
            this.btnBrowseTemplate.Location = new System.Drawing.Point(476, 121);
            this.btnBrowseTemplate.Name = "btnBrowseTemplate";
            this.btnBrowseTemplate.Size = new System.Drawing.Size(76, 27);
            this.btnBrowseTemplate.TabIndex = 9;
            this.btnBrowseTemplate.Text = "Обзор";
            this.btnBrowseTemplate.UseVisualStyleBackColor = true;
            this.btnBrowseTemplate.Click += new System.EventHandler(this.BtnBrowseTemplate_Click);
            // 
            // lblPCId
            // 
            this.lblPCId.AutoSize = true;
            this.lblPCId.Location = new System.Drawing.Point(20, 158);
            this.lblPCId.Name = "lblPCId";
            this.lblPCId.Size = new System.Drawing.Size(135, 19);
            this.lblPCId.TabIndex = 10;
            this.lblPCId.Text = "Идентификатор ПК:";
            // 
            // txtPCId
            // 
            this.txtPCId.Location = new System.Drawing.Point(170, 155);
            this.txtPCId.Name = "txtPCId";
            this.txtPCId.ReadOnly = true;
            this.txtPCId.Size = new System.Drawing.Size(300, 26);
            this.txtPCId.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(360, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 32);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(244, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 32);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 234);
            this.Controls.Add(this.lblMuseumName);
            this.Controls.Add(this.txtMuseumName);
            this.Controls.Add(this.lblDbPath);
            this.Controls.Add(this.txtDbPath);
            this.Controls.Add(this.btnBrowseDb);
            this.Controls.Add(this.lblCreateDb);
            this.Controls.Add(this.btnCreateDb);
            this.Controls.Add(this.lblTemplatePath);
            this.Controls.Add(this.txtTemplatePath);
            this.Controls.Add(this.btnBrowseTemplate);
            this.Controls.Add(this.lblPCId);
            this.Controls.Add(this.txtPCId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMuseumName;
        private System.Windows.Forms.TextBox txtMuseumName;
        private System.Windows.Forms.Label lblDbPath;
        private System.Windows.Forms.TextBox txtDbPath;
        private System.Windows.Forms.Button btnBrowseDb;
        private System.Windows.Forms.Label lblCreateDb;
        private System.Windows.Forms.Button btnCreateDb;
        private System.Windows.Forms.Label lblTemplatePath;
        private System.Windows.Forms.TextBox txtTemplatePath;
        private System.Windows.Forms.Button btnBrowseTemplate;
        private System.Windows.Forms.Label lblPCId;
        private System.Windows.Forms.TextBox txtPCId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
