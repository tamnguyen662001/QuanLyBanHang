using QLBH_HQTCSDL.DAO;
using QLBH_HQTCSDL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_HQTCSDL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            loadTable();        
        }


        #region METHOD

        void loadTable()
        {
            List<TableDTO> tablelist = LoadTableDAO.Instance.loadListTable();
            foreach (TableDTO item in tablelist)
            {
                Button btn = new Button() { Width = LoadTableDAO.width, Height = LoadTableDAO.heigh };
                
                btn.Text = item.Tenban + Environment.NewLine + item.Trangthai;

                btn.Click += Btn_Click;
                btn.Tag = item;

                if (item.Trangthai == "Trống")
                    btn.BackColor = Color.Cyan;
                else
                    btn.BackColor = Color.LightGreen;
                fllayoutpanelTable.Controls.Add(btn);
            }
        }

        void showBill(int id)
        {
            listView1.Items.Clear();
            List<BillDetailDTO> billDetailDTOs = BillDetailDAO.Instance.GetlistBillDetail(BillDAO.Instance.UncheckBillByTableId(id));

            foreach (BillDetailDTO item in billDetailDTOs)
            {
                ListViewItem lvitem = new ListViewItem(item.Idhoadon.ToString());
                lvitem.SubItems.Add(item.Sl.ToString());
                listView1.Items.Add(lvitem);
            }
        }

        #endregion

        #region EVENT

        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as TableDTO).Id;
            showBill(tableID);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAcount f = new FormAcount();
            //this.Hide();
            f.ShowDialog();
            //this.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin f = new FormAdmin();
            f.ShowDialog();
        }
        #endregion
    }
}
