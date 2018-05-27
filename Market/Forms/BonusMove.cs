using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Forms
{
    public partial class BonusMove : Form
    {
        History historyForm;
        int saleId;
        public BonusMove(History historyForm, int saleId)
        {
            this.historyForm = historyForm;
            this.saleId = saleId;
            InitializeComponent();

            List<Models.BonusMove> bonusMoves = DataBase.getBonusMoveBySaleId(saleId);

            foreach (Models.BonusMove move in bonusMoves)
            {
                string agent = move.bonusType == 0 ? "Нет" : "Да";
                if (move.firstName == null && move.secondName == null && move.phone == null)
                {
                    dataGridView1.Rows.Add(new object[] { $"Общий счет", "-", move.sum, agent });
                }
                else
                {
                    dataGridView1.Rows.Add(new object[] { $"{move.firstName} {move.secondName}", move.phone, move.sum, agent });
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            historyForm.Show();
            Hide();
        }
    }
}
