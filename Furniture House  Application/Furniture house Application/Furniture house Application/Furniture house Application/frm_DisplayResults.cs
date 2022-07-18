using System;
using System.Windows.Forms;

namespace Furniture_house_Application
{
    public partial class frm_DisplayResults : Form
    {
        private double dblActualPrice;
        private double dblFinalPrice;
        private int intRebatePercent;

        public frm_DisplayResults()
        {
            InitializeComponent();
        }

        public frm_DisplayResults(double dblActualPrice, int intRebatePercent, double dblFinalPrice)
        {
            InitializeComponent();
            this.dblActualPrice = dblActualPrice;
            this.intRebatePercent = intRebatePercent;
            this.dblFinalPrice = dblFinalPrice;
        }

        private void frm_DisplayResults_Load(object sender, EventArgs e)
        {
            lbl_ActualAmountResult.Text = dblActualPrice.ToString();
            lbl_DiscountPercentResult.Text = intRebatePercent.ToString();
            lbl_FinalAmountResult.Text = dblFinalPrice.ToString();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
