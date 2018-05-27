using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Market.Models;

namespace Market.Forms
{
    public partial class History : Form
    {
        AllForm allForm;
        List<Date> events = new List<Date>();

        public History(AllForm allForm, bool onlySentMoves)
        {
            this.allForm = allForm;
            InitializeComponent();
            
            if (onlySentMoves)
            {
                foreach (Models.BonusMove move in DataBase.getAllBonusMoves())
                {
                    if (move.moveType == 1)
                    {
                        events.Add(move);
                    }
                }
            }
            else
            {
                events.AddRange(DataBase.getAllSales());
                foreach (Models.BonusMove move in DataBase.getAllBonusMoves())
                {
                    if (move.moveType != 3)
                    {
                        events.Add(move);
                    }
                }
            }

            events.Sort(Models.Date.compareBydate);
            setFields();
        }

        private void setFields()
        {
            dataGridView.Rows.Clear();
            foreach (Date e in events)
            {

                if (e.GetType() == typeof(Sale))
                {
                    Sale sale = (Sale)e;
                    dataGridView.Rows.Add(new object[] { sale.date.ToString(), sale.firstName + " " + sale.secondName, "Покупка", sale.sum, sale.bonus, "Обычные" });
                }
                else
                {
                    Models.BonusMove move = (Models.BonusMove)e;
                    string firstName = move.firstName == null ? "Общий" : move.firstName;
                    string secondName = move.secondName == null ? "Счет" : move.secondName;
                    string bonusType = move.bonusType == 1 ? "ТА" : "Обычные";
                    string moveType = move.getMoveTypeAsString();
                    dataGridView.Rows.Add(new object[] { move.date.ToString(), firstName + " " + secondName, moveType, move.sum, "-", bonusType });
                }
            }
        }

        private void cancel_Click(object sender, System.EventArgs e)
        {
            allForm.Show();
            Hide();
        }


        private void dataGridView_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowId = e.RowIndex;
            Date eventt = events[rowId];
            if (eventt.GetType() == typeof(Sale))
            {
                Sale sale = (Sale)eventt;
                if (sale.opened)
                {
                    for (int i = 0; i < sale.salesCount; i++)
                    {
                        events.RemoveAt(rowId + 1);
                    }
                    sale.opened = false;
                }
                else
                {
                    List<Models.BonusMove> moves = DataBase.getBonusMoveBySaleId(sale.id);
                    foreach (Models.BonusMove move in moves)
                    {
                        events.Insert(rowId + 1, move);
                    }
                    sale.salesCount = moves.Count;
                    sale.opened = true;
                }
                setFields();
            }
        }

    }
}
