using System;
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
            List<Models.BonusMove> moves = DataBase.getAllBonusMoves();

            sales.Sort(new Comparison<Models.Sale>(Models.Sale.compareByDate));
            moves.Sort(new Comparison<Models.BonusMove>(Models.BonusMove.compareBydate));

            for (int i = 0, j = 0; i < sales.Count || j < moves.Count;)
            {
                bool useSale = true;
                if (i < sales.Count && j < moves.Count)
                {
                    if (moves[j].date < sales[i].date)
                    {
                        useSale = false;
                    } else
                    {
                        if (j < moves.Count)
                        {
                            useSale = false;
                        }
                    }
                }

                if (useSale)
                {
                    Models.Sale sale = sales[i];
                    dataGridView.Rows.Add(new object[] {sale.date.ToString(), sale.firstName + " " + sale.lastName, "Покупка", sale.sum, sale.bonus, "Обычные" });
                    i++;
                } else
                {
                    Models.BonusMove move = moves[j];
                    //dataGridView.Rows.Add(new object[] { move.date.ToString(), sale.firstName + " " + sale.lastName, "Перевод", sale.sum, sale.bonus, "Обычные" });
                    j++;
                }
            }

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


      //  private void dataGridView_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
       // {
       //     int rowId = e.RowIndex;
       //     int saleId = System.Convert.ToInt32(dataGridView.Rows[rowId].Cells[0].Value);
       //     new BonusMove(this, saleId).Show();
       //     Hide();
       // }

    }
}
