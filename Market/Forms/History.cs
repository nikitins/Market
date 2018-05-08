using System.Collections.Generic;
using System.Windows.Forms;

namespace Market.Forms
{
    public partial class History : Form
    {
        Main mainForm;
        public History(Main mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            List<Models.Sale> sales = DataBase.getAllSales();

            foreach (Models.Sale sale in sales)
            {
                dataGridView.Rows.Add(new object[] {sale.id, sale.date.ToString(), sale.firstName + " " + sale.lastName, sale.phone, sale.sum, sale.bonus});
            }
        }

        private void cancel_Click(object sender, System.EventArgs e)
        {
            mainForm.Show();
            Hide();
        }


        private void dataGridView_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowId = e.RowIndex;
            int saleId = System.Convert.ToInt32(dataGridView.Rows[rowId].Cells[0].Value);
            new BonusMove(this, saleId).Show();
            Hide();
        }

    }
}
