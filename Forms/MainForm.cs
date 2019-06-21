namespace HemSoft.TCE.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using HemSoft.TCE.Data;

    public partial class MainForm : Form
    {
        public List<BuyerMaster> Buyers;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshData();
            UpdateStatusStrip();
        }

        private void RefreshData()
        {
            Buyers = BuyerManager.GetAllBuyerMasters();
        }

        private void UpdateStatusStrip()
        {
            tsLabel.Text = $@"{ Buyers.Count() } buyers.";
        }
    }
}
