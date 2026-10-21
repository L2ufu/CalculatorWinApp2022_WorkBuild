namespace calculator_winApp
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        bool newOperation = true;
        double firstValue;
        double secondValue;
        double result = 0.0;

        private void allBtnClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (newOperation)
            {
                lblDsplay.Text = "";
                newOperation = false;
            }
            if (btn.Text == ",")
            {
                var val = lblDsplay.Text.IndexOf(",");
                if (val > 0);
                return;
            }
            lblDsplay.Text += btn.Text;
            if(btn.Text != ",")
            {
                firstValue = Convert.ToDouble(btn.Text);
            }

        }

       
        
    }

}
