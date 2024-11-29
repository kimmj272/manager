namespace AdressManager
{
    partial class FrmOutput
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
            this.listView = new System.Windows.Forms.ListView();
            this.lv_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_TelePhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Adress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.listView.Location = new System.Drawing.Point(12, 87);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1074, 405);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
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
            // FrmOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 519);
            this.Controls.Add(this.listView);
            this.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FrmOutput";
            this.Text = "명함 목록";
            this.Load += new System.EventHandler(this.FrmOutput_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader lv_Name;
        private System.Windows.Forms.ColumnHeader lv_TelePhone;
        private System.Windows.Forms.ColumnHeader lv_Adress;
        private System.Windows.Forms.ColumnHeader lv_Email;
        private System.Windows.Forms.ColumnHeader lv_Number;
    }
}