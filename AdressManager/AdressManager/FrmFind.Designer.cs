namespace AdressManager
{
    partial class FrmFind
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.lv_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_TelePhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Adress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 검색";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(179, 28);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(271, 41);
            this.tbSearch.TabIndex = 1;
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
            this.listView.Location = new System.Drawing.Point(39, 95);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1074, 405);
            this.listView.TabIndex = 2;
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(493, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 41);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 529);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FrmFind";
            this.Text = "검색";
            this.Load += new System.EventHandler(this.FrmFind_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader lv_Number;
        private System.Windows.Forms.ColumnHeader lv_Name;
        private System.Windows.Forms.ColumnHeader lv_TelePhone;
        private System.Windows.Forms.ColumnHeader lv_Adress;
        private System.Windows.Forms.ColumnHeader lv_Email;
        private System.Windows.Forms.Button btnSearch;
    }
}