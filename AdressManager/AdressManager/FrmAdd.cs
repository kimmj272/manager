using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AdressManager
{
    public partial class FrmMain : Form
    {
        public int m_Id = 0;
        public List<NameCard> m_listNameCard = new List<NameCard>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddListView();
        }

        private void btnOpenList_Click(object sender, EventArgs e)
        {
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbTelephone.Text = "";
            tbAdress.Text = "";
            tbEmail.Text = "";
        }

        private void AddListView()
        {
            //FrmOutput kFrmOutput = new FrmOutput();
            NameCard kNameCard = new NameCard();

            kNameCard.m_ID = m_Id++;
            kNameCard.m_Name = tbName.Text;
            kNameCard.m_Number = tbTelephone.Text;
            kNameCard.m_Adress = tbAdress.Text;
            kNameCard.m_Email = tbEmail.Text;

            //m_kFrmOutput.AddListView(kNameCard);
            //m_kFrmFind.AddListView(kNameCard);

            SaveInfo(kNameCard);
            AddListViewItem(kNameCard);
        }

        public void AddListViewItem(NameCard nameCard)
        {
            ListViewItem item = new ListViewItem(nameCard.m_ID.ToString());
            item.SubItems.Add(nameCard.m_Name);
            item.SubItems.Add(nameCard.m_Number);
            item.SubItems.Add(nameCard.m_Adress);
            item.SubItems.Add(nameCard.m_Email);
            listView.Items.Add(item);
        }

        public void SaveInfo(NameCard nameCard)
        {
            FileStream fs = new FileStream("NameData.bin", FileMode.Create, FileAccess.Write);

            m_listNameCard.Add(nameCard);
        }
    }
}
