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
    public partial class FrmOutput : Form
    {
        public FrmOutput()
        {
            InitializeComponent();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
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

        private void FrmOutput_Load(object sender, EventArgs e)
        {
            Console.WriteLine("output loading...,\n");
        }
    }
}
