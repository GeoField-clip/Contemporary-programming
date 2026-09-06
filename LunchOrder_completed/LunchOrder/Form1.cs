namespace LunchOrder
{
    public partial class Form1 : Form
    {
        private const decimal TaxRate = 0.0775m;

        // George Feldmann
        public Form1()
        {
            InitializeComponent();
        }
        
        // George Feldmann
        private void ClearTotals()
        {
            txtSubtotal.Clear();
            txtSalesTax.Clear();
            txtOrderTotal.Clear();
        }
        
        // George Feldmann
        private void ClearAddOns()
        {
            chkAddOn1.Checked = false;
            chkAddOn2.Checked = false;
            chkAddOn3.Checked = false;
        }
        
        // George Feldmann
        private void MainCourse_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedMainCourse = (RadioButton)sender;

            if (!selectedMainCourse.Checked)
            {
                return;
            }

            if (rdoHamburger.Checked)
            {
                gbxAddOns.Text = "Add-on items ($.75/each)";
                chkAddOn1.Text = "Lettuce, tomato, and onions";
                chkAddOn2.Text = "Ketchup, mustard, and mayo";
                chkAddOn3.Text = "French fries";
            }
            else if (rdoPizza.Checked)
            {
                gbxAddOns.Text = "Add-on items ($.50/each)";
                chkAddOn1.Text = "Pepperoni";
                chkAddOn2.Text = "Sausage";
                chkAddOn3.Text = "Olives";
            }
            else if (rdoSalad.Checked)
            {
                gbxAddOns.Text = "Add-on items ($.25/each)";
                chkAddOn1.Text = "Croutons";
                chkAddOn2.Text = "Bacon bits";
                chkAddOn3.Text = "Bread sticks";
            }

            ClearAddOns();
            ClearTotals();
        }
        
        // George Feldmann
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal mainCoursePrice;
            decimal addOnPrice;

            if (rdoHamburger.Checked)
            {
                mainCoursePrice = 6.95m;
                addOnPrice = 0.75m;
            }
            else if (rdoPizza.Checked)
            {
                mainCoursePrice = 5.95m;
                addOnPrice = 0.50m;
            }
            else
            {
                mainCoursePrice = 4.95m;
                addOnPrice = 0.25m;
            }

            int addOnCount = 0;
            if (chkAddOn1.Checked) addOnCount++;
            if (chkAddOn2.Checked) addOnCount++;
            if (chkAddOn3.Checked) addOnCount++;

            decimal subtotal = mainCoursePrice + (addOnCount * addOnPrice);
            decimal tax = subtotal * TaxRate;
            decimal orderTotal = subtotal + tax;

            txtSubtotal.Text = subtotal.ToString("c");
            txtSalesTax.Text = tax.ToString("c");
            txtOrderTotal.Text = orderTotal.ToString("c");
        }
        
        // George Feldmann
        private void AddOn_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }
        
        // George Feldmann
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
