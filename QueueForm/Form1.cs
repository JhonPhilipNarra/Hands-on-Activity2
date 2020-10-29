using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueForm
{
    public partial class QueueForm : Form
    {
        private CahierClass cashier;
        public QueueForm()
        {
            InitializeComponent();
            cashier = new CahierClass();

            CashierWindowQueue cwqf = new CashierWindowQueue();
            cwqf.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CahierClass.getNumberInQueue = lblQueue.Text;
            CahierClass.CashierQueue.Enqueue(CahierClass.getNumberInQueue);

        }
    }
}
