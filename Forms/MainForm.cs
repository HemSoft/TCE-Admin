namespace HemSoft.TCE.Forms
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using HemSoft.TCE.Data;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var buyers = BuyerManager.GetAllBuyerMasters();
            tsLabel.Text = $@"{ buyers.Count() } buyers.";
        }
    }
}
