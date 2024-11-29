namespace AdressManager
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.txtTelephon = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.lv_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_TelePhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Adress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(41, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(71, 29);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "이름";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(127, 84);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(406, 41);
            this.tbName.TabIndex = 1;
            // 
            // txtTelephon
            // 
            this.txtTelephon.AutoSize = true;
            this.txtTelephon.Location = new System.Drawing.Point(41, 153);
            this.txtTelephon.Name = "txtTelephon";
            this.txtTelephon.Size = new System.Drawing.Size(71, 29);
            this.txtTelephon.TabIndex = 2;
            this.txtTelephon.Text = "전화";
            this.txtTelephon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAdress
            // 
            this.txtAdress.AutoSize = true;
            this.txtAdress.Location = new System.Drawing.Point(41, 225);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(71, 29);
            this.txtAdress.TabIndex = 3;
            this.txtAdress.Text = "주소";
            this.txtAdress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(12, 295);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 29);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "이메일";
            this.txtEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(127, 222);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(406, 41);
            this.tbAdress.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(127, 292);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(406, 41);
            this.tbEmail.TabIndex = 6;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(127, 150);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(406, 41);
            this.tbTelephone.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(555, 287);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 44);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(895, 287);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 44);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "명함 정보 입력";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(726, 287);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(152, 44);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "명함 찾기";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv_Number,
            this.lv_Name,
            this.lv_TelePhone,
            this.lv_Adress,
            this.lv_Email});
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(28, 373);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1019, 289);
            this.listView.TabIndex = 13;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // lv_Number
            // 
            this.lv_Number.Text = "순번";
            this.lv_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lv_Number.Width = 71;
            // 
            // lv_Name
            // 
            this.lv_Name.Text = "이름";
            this.lv_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lv_Name.Width = 126;
            // 
            // lv_TelePhone
            // 
            this.lv_TelePhone.Text = "전화";
            this.lv_TelePhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lv_TelePhone.Width = 189;
            // 
            // lv_Adress
            // 
            this.lv_Adress.Text = "주소";
            this.lv_Adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lv_Adress.Width = 255;
            // 
            // lv_Email
            // 
            this.lv_Email.Text = "이메일";
            this.lv_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lv_Email.Width = 432;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 677);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtTelephon);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FrmMain";
            this.Text = "명함 추가";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label txtTelephon;
        private System.Windows.Forms.Label txtAdress;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader lv_Number;
        private System.Windows.Forms.ColumnHeader lv_Name;
        private System.Windows.Forms.ColumnHeader lv_TelePhone;
        private System.Windows.Forms.ColumnHeader lv_Adress;
        private System.Windows.Forms.ColumnHeader lv_Email;
    }
}

