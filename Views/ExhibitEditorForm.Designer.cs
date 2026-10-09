namespace MuseumCatalog.Views
{
    partial class ExhibitEditorForm
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
            this.lblCipher = new System.Windows.Forms.Label();
            this.TxtCipher = new System.Windows.Forms.TextBox();
            this.lblKPNumber = new System.Windows.Forms.Label();
            this.TxtKPNumber = new System.Windows.Forms.TextBox();
            this.lblTimeStamp = new System.Windows.Forms.Label();
            this.DpTimeStamp = new System.Windows.Forms.DateTimePicker();
            this.lblSource = new System.Windows.Forms.Label();
            this.TxtSource = new System.Windows.Forms.TextBox();
            this.lblActNumber = new System.Windows.Forms.Label();
            this.TxtActNumber = new System.Windows.Forms.TextBox();
            this.lblMaterialTechnique = new System.Windows.Forms.Label();
            this.TxtMaterialTechnique = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.TxtItemName = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.TxtCondition = new System.Windows.Forms.TextBox();
            this.lblStoragePlace = new System.Windows.Forms.Label();
            this.CbStoragePlace = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.PicPhoto = new System.Windows.Forms.PictureBox();
            this.panelPhotoButtons = new System.Windows.Forms.Panel();
            this.BtnLoadPhoto = new System.Windows.Forms.Button();
            this.BtnClearPhoto = new System.Windows.Forms.Button();
            this.BtnViewPhoto = new System.Windows.Forms.Button();
            this.panelBottomButtons = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicPhoto)).BeginInit();
            this.panelPhotoButtons.SuspendLayout();
            this.panelBottomButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCipher
            // 
            this.lblCipher.AutoSize = true;
            this.lblCipher.Location = new System.Drawing.Point(92, 15);
            this.lblCipher.Name = "lblCipher";
            this.lblCipher.Size = new System.Drawing.Size(51, 19);
            this.lblCipher.TabIndex = 0;
            this.lblCipher.Text = "Шифр:";
            this.lblCipher.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtCipher
            // 
            this.TxtCipher.Location = new System.Drawing.Point(149, 12);
            this.TxtCipher.Name = "TxtCipher";
            this.TxtCipher.Size = new System.Drawing.Size(456, 26);
            this.TxtCipher.TabIndex = 1;
            // 
            // lblKPNumber
            // 
            this.lblKPNumber.AutoSize = true;
            this.lblKPNumber.Location = new System.Drawing.Point(73, 45);
            this.lblKPNumber.Name = "lblKPNumber";
            this.lblKPNumber.Size = new System.Drawing.Size(70, 19);
            this.lblKPNumber.TabIndex = 2;
            this.lblKPNumber.Text = "№ по КП:";
            this.lblKPNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtKPNumber
            // 
            this.TxtKPNumber.Location = new System.Drawing.Point(149, 42);
            this.TxtKPNumber.Name = "TxtKPNumber";
            this.TxtKPNumber.Size = new System.Drawing.Size(289, 26);
            this.TxtKPNumber.TabIndex = 3;
            // 
            // lblTimeStamp
            // 
            this.lblTimeStamp.AutoSize = true;
            this.lblTimeStamp.Location = new System.Drawing.Point(444, 45);
            this.lblTimeStamp.Name = "lblTimeStamp";
            this.lblTimeStamp.Size = new System.Drawing.Size(42, 19);
            this.lblTimeStamp.TabIndex = 4;
            this.lblTimeStamp.Text = "Дата:";
            // 
            // DpTimeStamp
            // 
            this.DpTimeStamp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DpTimeStamp.Location = new System.Drawing.Point(492, 42);
            this.DpTimeStamp.Name = "DpTimeStamp";
            this.DpTimeStamp.Size = new System.Drawing.Size(113, 26);
            this.DpTimeStamp.TabIndex = 5;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(70, 75);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(73, 19);
            this.lblSource.TabIndex = 6;
            this.lblSource.Text = "Источник:";
            this.lblSource.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtSource
            // 
            this.TxtSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtSource.Location = new System.Drawing.Point(149, 72);
            this.TxtSource.Name = "TxtSource";
            this.TxtSource.Size = new System.Drawing.Size(456, 26);
            this.TxtSource.TabIndex = 7;
            // 
            // lblActNumber
            // 
            this.lblActNumber.AutoSize = true;
            this.lblActNumber.Location = new System.Drawing.Point(84, 105);
            this.lblActNumber.Name = "lblActNumber";
            this.lblActNumber.Size = new System.Drawing.Size(59, 19);
            this.lblActNumber.TabIndex = 8;
            this.lblActNumber.Text = "№ акта:";
            this.lblActNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtActNumber
            // 
            this.TxtActNumber.Location = new System.Drawing.Point(149, 102);
            this.TxtActNumber.Name = "TxtActNumber";
            this.TxtActNumber.Size = new System.Drawing.Size(456, 26);
            this.TxtActNumber.TabIndex = 9;
            // 
            // lblMaterialTechnique
            // 
            this.lblMaterialTechnique.AutoSize = true;
            this.lblMaterialTechnique.Location = new System.Drawing.Point(12, 135);
            this.lblMaterialTechnique.Name = "lblMaterialTechnique";
            this.lblMaterialTechnique.Size = new System.Drawing.Size(131, 19);
            this.lblMaterialTechnique.TabIndex = 10;
            this.lblMaterialTechnique.Text = "Материал, техника:";
            this.lblMaterialTechnique.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtMaterialTechnique
            // 
            this.TxtMaterialTechnique.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtMaterialTechnique.Location = new System.Drawing.Point(149, 132);
            this.TxtMaterialTechnique.Name = "TxtMaterialTechnique";
            this.TxtMaterialTechnique.Size = new System.Drawing.Size(456, 26);
            this.TxtMaterialTechnique.TabIndex = 11;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(36, 165);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(107, 19);
            this.lblItemName.TabIndex = 12;
            this.lblItemName.Text = "Наименование:";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtItemName
            // 
            this.TxtItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtItemName.Location = new System.Drawing.Point(149, 162);
            this.TxtItemName.Name = "TxtItemName";
            this.TxtItemName.Size = new System.Drawing.Size(456, 26);
            this.TxtItemName.TabIndex = 13;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(85, 195);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(58, 19);
            this.lblSize.TabIndex = 14;
            this.lblSize.Text = "Размер:";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtSize
            // 
            this.TxtSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtSize.Location = new System.Drawing.Point(149, 192);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(200, 26);
            this.TxtSize.TabIndex = 15;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(370, 195);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(93, 19);
            this.lblCondition.TabIndex = 16;
            this.lblCondition.Text = "Сохранность:";
            // 
            // TxtCondition
            // 
            this.TxtCondition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtCondition.Location = new System.Drawing.Point(469, 192);
            this.TxtCondition.Name = "TxtCondition";
            this.TxtCondition.Size = new System.Drawing.Size(136, 26);
            this.TxtCondition.TabIndex = 17;
            // 
            // lblStoragePlace
            // 
            this.lblStoragePlace.AutoSize = true;
            this.lblStoragePlace.Location = new System.Drawing.Point(28, 225);
            this.lblStoragePlace.Name = "lblStoragePlace";
            this.lblStoragePlace.Size = new System.Drawing.Size(115, 19);
            this.lblStoragePlace.TabIndex = 18;
            this.lblStoragePlace.Text = "Место хранения:";
            this.lblStoragePlace.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CbStoragePlace
            // 
            this.CbStoragePlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbStoragePlace.FormattingEnabled = true;
            this.CbStoragePlace.Location = new System.Drawing.Point(149, 222);
            this.CbStoragePlace.Name = "CbStoragePlace";
            this.CbStoragePlace.Size = new System.Drawing.Size(456, 27);
            this.CbStoragePlace.TabIndex = 19;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(68, 255);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 19);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Описание:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtDescription
            // 
            this.TxtDescription.AcceptsReturn = true;
            this.TxtDescription.Location = new System.Drawing.Point(149, 252);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDescription.Size = new System.Drawing.Size(456, 72);
            this.TxtDescription.TabIndex = 21;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(99, 330);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(44, 19);
            this.lblPhoto.TabIndex = 22;
            this.lblPhoto.Text = "Фото:";
            this.lblPhoto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PicPhoto
            // 
            this.PicPhoto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PicPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicPhoto.Location = new System.Drawing.Point(149, 330);
            this.PicPhoto.Name = "PicPhoto";
            this.PicPhoto.Size = new System.Drawing.Size(200, 160);
            this.PicPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicPhoto.TabIndex = 23;
            this.PicPhoto.TabStop = false;
            this.PicPhoto.DoubleClick += new System.EventHandler(this.PicPhoto_DoubleClick);
            // 
            // panelPhotoButtons
            // 
            this.panelPhotoButtons.Controls.Add(this.BtnLoadPhoto);
            this.panelPhotoButtons.Controls.Add(this.BtnClearPhoto);
            this.panelPhotoButtons.Controls.Add(this.BtnViewPhoto);
            this.panelPhotoButtons.Location = new System.Drawing.Point(364, 330);
            this.panelPhotoButtons.Name = "panelPhotoButtons";
            this.panelPhotoButtons.Size = new System.Drawing.Size(241, 160);
            this.panelPhotoButtons.TabIndex = 24;
            // 
            // BtnLoadPhoto
            // 
            this.BtnLoadPhoto.Location = new System.Drawing.Point(3, 5);
            this.BtnLoadPhoto.Name = "BtnLoadPhoto";
            this.BtnLoadPhoto.Size = new System.Drawing.Size(120, 30);
            this.BtnLoadPhoto.TabIndex = 0;
            this.BtnLoadPhoto.Text = "Загрузить фото";
            this.BtnLoadPhoto.UseVisualStyleBackColor = true;
            this.BtnLoadPhoto.Click += new System.EventHandler(this.BtnLoadPhoto_Click);
            // 
            // BtnClearPhoto
            // 
            this.BtnClearPhoto.Location = new System.Drawing.Point(3, 42);
            this.BtnClearPhoto.Name = "BtnClearPhoto";
            this.BtnClearPhoto.Size = new System.Drawing.Size(120, 30);
            this.BtnClearPhoto.TabIndex = 1;
            this.BtnClearPhoto.Text = "Удалить фото";
            this.BtnClearPhoto.UseVisualStyleBackColor = true;
            this.BtnClearPhoto.Click += new System.EventHandler(this.BtnClearPhoto_Click);
            // 
            // BtnViewPhoto
            // 
            this.BtnViewPhoto.Location = new System.Drawing.Point(3, 79);
            this.BtnViewPhoto.Name = "BtnViewPhoto";
            this.BtnViewPhoto.Size = new System.Drawing.Size(120, 30);
            this.BtnViewPhoto.TabIndex = 2;
            this.BtnViewPhoto.Text = "Просмотр";
            this.BtnViewPhoto.UseVisualStyleBackColor = true;
            this.BtnViewPhoto.Click += new System.EventHandler(this.BtnViewPhoto_Click);
            // 
            // panelBottomButtons
            // 
            this.panelBottomButtons.Controls.Add(this.BtnSave);
            this.panelBottomButtons.Controls.Add(this.BtnCancel);
            this.panelBottomButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomButtons.Location = new System.Drawing.Point(0, 502);
            this.panelBottomButtons.Name = "panelBottomButtons";
            this.panelBottomButtons.Size = new System.Drawing.Size(612, 45);
            this.panelBottomButtons.TabIndex = 25;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.BtnSave.Location = new System.Drawing.Point(480, 8);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(120, 30);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnCancel.Location = new System.Drawing.Point(354, 8);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(120, 30);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ExhibitEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 547);
            this.Controls.Add(this.lblCipher);
            this.Controls.Add(this.TxtCipher);
            this.Controls.Add(this.lblKPNumber);
            this.Controls.Add(this.TxtKPNumber);
            this.Controls.Add(this.lblTimeStamp);
            this.Controls.Add(this.DpTimeStamp);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.TxtSource);
            this.Controls.Add(this.lblActNumber);
            this.Controls.Add(this.TxtActNumber);
            this.Controls.Add(this.lblMaterialTechnique);
            this.Controls.Add(this.TxtMaterialTechnique);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.TxtItemName);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.TxtCondition);
            this.Controls.Add(this.lblStoragePlace);
            this.Controls.Add(this.CbStoragePlace);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.PicPhoto);
            this.Controls.Add(this.panelPhotoButtons);
            this.Controls.Add(this.panelBottomButtons);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExhibitEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Карточка экспоната";
            this.Load += new System.EventHandler(this.ExhibitEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicPhoto)).EndInit();
            this.panelPhotoButtons.ResumeLayout(false);
            this.panelBottomButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCipher;
        private System.Windows.Forms.TextBox TxtCipher;
        private System.Windows.Forms.Label lblKPNumber;
        private System.Windows.Forms.TextBox TxtKPNumber;
        private System.Windows.Forms.Label lblTimeStamp;
        private System.Windows.Forms.DateTimePicker DpTimeStamp;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox TxtSource;
        private System.Windows.Forms.Label lblActNumber;
        private System.Windows.Forms.TextBox TxtActNumber;
        private System.Windows.Forms.Label lblMaterialTechnique;
        private System.Windows.Forms.TextBox TxtMaterialTechnique;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox TxtItemName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox TxtSize;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.TextBox TxtCondition;
        private System.Windows.Forms.Label lblStoragePlace;
        private System.Windows.Forms.ComboBox CbStoragePlace;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.PictureBox PicPhoto;
        private System.Windows.Forms.Panel panelPhotoButtons;
        private System.Windows.Forms.Button BtnLoadPhoto;
        private System.Windows.Forms.Button BtnClearPhoto;
        private System.Windows.Forms.Button BtnViewPhoto;
        private System.Windows.Forms.Panel panelBottomButtons;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
    }
}
