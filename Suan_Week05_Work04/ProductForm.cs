using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suan_Week05_Work04
{
    public partial class ProductForm : Form
    {
        private readonly List<string> savedBarcodes = new List<string>();

        public ProductForm()
        {
            InitializeComponent();

            // Category choices
            cbocategory.Items.AddRange(new object[]
                { "Beverages", "Snacks", "Canned Goods", "Household", "Personal Care" });
            cbocategory.DropDownStyle = ComboBoxStyle.DropDownList;

            // Markup is calculated automatically
            txtmarkup.ReadOnly = true;

            // ENTER = Save, ESC = Cancel
            AcceptButton = btnsave;
            CancelButton = btncancel;

            // Events wired in code
            txtcost.KeyPress += MoneyBox_KeyPress;
            txtprice.KeyPress += MoneyBox_KeyPress;
            txtcost.TextChanged += MoneyBox_TextChanged;
            txtprice.TextChanged += MoneyBox_TextChanged;
            btnclear.Click += btnclear_Click;

            ClearForm();
        }

        // ---------- Barcode availability ----------
        private void txtbarcode_TextChanged(object sender, EventArgs e)
        {
            string code = txtbarcode.Text.Trim();
            if (code == "")
            {
                lblbarcodeisavailable.Text = "";
                return;
            }

            bool taken = savedBarcodes.Contains(code, StringComparer.OrdinalIgnoreCase);
            lblbarcodeisavailable.Text = taken ? "Barcode already exists." : "Barcode is available.";
            lblbarcodeisavailable.ForeColor = taken ? Color.Firebrick : Color.Green;
        }

        // ---------- Input validation: digits and one decimal point only ----------
        private void MoneyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (char.IsControl(e.KeyChar)) return;
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.' && box.Text.IndexOf('.') < 0) return;
            e.Handled = true;
        }

        // ---------- Calculation: Markup % = (Price - Cost) / Cost * 100 ----------
        private void MoneyBox_TextChanged(object sender, EventArgs e)
        {
            decimal cost, price;
            if (decimal.TryParse(txtcost.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out cost) &&
                decimal.TryParse(txtprice.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out price) &&
                cost > 0)
            {
                txtmarkup.Text = ((price - cost) / cost * 100).ToString("N2");
            }
            else
            {
                txtmarkup.Clear();
            }
        }

        // ---------- Buttons ----------
        private void btnsave_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();
            string code = txtbarcode.Text.Trim();

            if (code == "")
                errors.Add("Barcode is required.");
            else if (savedBarcodes.Contains(code, StringComparer.OrdinalIgnoreCase))
                errors.Add("Barcode already exists.");

            if (txtname.Text.Trim() == "")
                errors.Add("Name is required.");

            if (cbocategory.SelectedIndex < 0)
                errors.Add("Please select a category.");

            decimal cost, price;
            bool costOk = decimal.TryParse(txtcost.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out cost) && cost > 0;
            bool priceOk = decimal.TryParse(txtprice.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out price) && price > 0;

            if (!costOk) errors.Add("Cost must be a number greater than 0.");
            if (!priceOk) errors.Add("Price must be a number greater than 0.");
            if (costOk && priceOk && price < cost) errors.Add("Price cannot be lower than cost.");

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors),
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            savedBarcodes.Add(code);
            string origin = rdolocal.Checked ? "Local" : "Abroad";
            string status = chkactive.Checked ? "Active" : "Inactive";

            MessageBox.Show(
                "Product saved!\n\n" +
                "Barcode: " + code + "\n" +
                "Name: " + txtname.Text.Trim() + "\n" +
                "Category: " + cbocategory.Text + "\n" +
                "Origin: " + origin + "\n" +
                "Status: " + status + "\n" +
                "Cost: " + cost.ToString("N2") + "\n" +
                "Price: " + price.ToString("N2") + "\n" +
                "Markup: " + txtmarkup.Text + "%",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Discard changes and close?", "Cancel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Close();
        }

        private void ClearForm()
        {
            txtbarcode.Clear();
            txtname.Clear();
            txtdescription.Clear();
            txtcost.Clear();
            txtprice.Clear();
            txtmarkup.Clear();
            cbocategory.SelectedIndex = -1;
            rdolocal.Checked = true;
            chkactive.Checked = false;
            lblbarcodeisavailable.Text = "";
            txtbarcode.Focus();
        }

        // ---------- Auto-generated handlers (kept so the Designer doesn't error) ----------
        private void lblbarcode_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void lblcategory_Click(object sender, EventArgs e) { }
        private void lblorigin_Click(object sender, EventArgs e) { }
        private void rdolocal_CheckedChanged(object sender, EventArgs e) { }
        private void lblstatus_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void lblPrice_Click(object sender, EventArgs e) { }
        private void chkactive_CheckedChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void lblbarcodeisavailable_Click(object sender, EventArgs e) { }
        private void lblname_Click(object sender, EventArgs e) { }
    }
}