using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressManager
{
    public partial class FrmFind : Form
    {
        public FrmMain m_FrmAdd = new FrmMain();

        public FrmFind()
        {
            InitializeComponent();
        }

        private void FrmFind_Load(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        public void AddListView(NameCard nameCard)
        {
            ListViewItem item = new ListViewItem(nameCard.m_ID.ToString());
            item.SubItems.Add(nameCard.m_Name);
            item.SubItems.Add(nameCard.m_Number);
            item.SubItems.Add(nameCard.m_Adress);
            item.SubItems.Add(nameCard.m_Email);
            listView.Items.Add(item);
        }
    }
}
