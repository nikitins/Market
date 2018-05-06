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
                dataGridView.Rows.Add(new object[] {sale.date.ToString(), sale.firstName + " " + sale.lastName, sale.phone, sale.sum, sale.bonus});
            }
        }

        private void cancel_Click(object sender, System.EventArgs e)
        {
            mainForm.Show();
            Hide();
        }
    }
}
