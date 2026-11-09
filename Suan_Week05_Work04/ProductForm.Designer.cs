namespace Suan_Week05_Work04
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblbarcode = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.lblbarcodeisavailable = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.lblcategory = new System.Windows.Forms.Label();
            this.cbocategory = new System.Windows.Forms.ComboBox();
            this.lblorigin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoabroad = new System.Windows.Forms.RadioButton();
            this.rdolocal = new System.Windows.Forms.RadioButton();
            this.lblstatus = new System.Windows.Forms.Label();
            this.chkactive = new System.Windows.Forms.CheckBox();
            this.lblcost = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtmarkup = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblbarcode
            // 
            this.lblbarcode.AutoSize = true;
            this.lblbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarcode.Location = new System.Drawing.Point(200, 31);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(53, 15);
            this.lblbarcode.TabIndex = 0;
            this.lblbarcode.Text = "Barcode";
            this.lblbarcode.Click += new System.EventHandler(this.lblbarcode_Click);
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(278, 31);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(257, 20);
            this.txtbarcode.TabIndex = 1;
            this.txtbarcode.TextChanged += new System.EventHandler(this.txtbarcode_TextChanged);
            // 
            // lblbarcodeisavailable
            // 
            this.lblbarcodeisavailable.AutoSize = true;
            this.lblbarcodeisavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarcodeisavailable.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblbarcodeisavailable.Location = new System.Drawing.Point(275, 54);
            this.lblbarcodeisavailable.Name = "lblbarcodeisavailable";
            this.lblbarcodeisavailable.Size = new System.Drawing.Size(134, 16);
            this.lblbarcodeisavailable.TabIndex = 2;
            this.lblbarcodeisavailable.Text = "Barcode is available.";
            this.lblbarcodeisavailable.Click += new System.EventHandler(this.lblbarcodeisavailable_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(200, 84);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(41, 15);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(278, 84);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(257, 20);
            this.txtname.TabIndex = 4;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(200, 110);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(69, 15);
            this.lbldescription.TabIndex = 5;
            this.lbldescription.Text = "Description";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(278, 110);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(257, 45);
            this.txtdescription.TabIndex = 6;
            this.txtdescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.Location = new System.Drawing.Point(200, 161);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(55, 15);
            this.lblcategory.TabIndex = 7;
            this.lblcategory.Text = "Category";
            this.lblcategory.Click += new System.EventHandler(this.lblcategory_Click);
            // 
            // cbocategory
            // 
            this.cbocategory.FormattingEnabled = true;
            this.cbocategory.Location = new System.Drawing.Point(278, 161);
            this.cbocategory.Name = "cbocategory";
            this.cbocategory.Size = new System.Drawing.Size(257, 21);
            this.cbocategory.TabIndex = 8;
            // 
            // lblorigin
            // 
            this.lblorigin.AutoSize = true;
            this.lblorigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorigin.Location = new System.Drawing.Point(202, 188);
            this.lblorigin.Name = "lblorigin";
            this.lblorigin.Size = new System.Drawing.Size(40, 15);
            this.lblorigin.TabIndex = 9;
            this.lblorigin.Text = "Origin";
            this.lblorigin.Click += new System.EventHandler(this.lblorigin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoabroad);
            this.groupBox1.Controls.Add(this.rdolocal);
            this.groupBox1.Location = new System.Drawing.Point(278, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 61);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manufactured";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoabroad
            // 
            this.rdoabroad.AutoSize = true;
            this.rdoabroad.Location = new System.Drawing.Point(143, 31);
            this.rdoabroad.Name = "rdoabroad";
            this.rdoabroad.Size = new System.Drawing.Size(59, 17);
            this.rdoabroad.TabIndex = 1;
            this.rdoabroad.TabStop = true;
            this.rdoabroad.Text = "Abroad";
            this.rdoabroad.UseVisualStyleBackColor = true;
            // 
            // rdolocal
            // 
            this.rdolocal.AutoSize = true;
            this.rdolocal.Location = new System.Drawing.Point(57, 31);
            this.rdolocal.Name = "rdolocal";
            this.rdolocal.Size = new System.Drawing.Size(51, 17);
            this.rdolocal.TabIndex = 0;
            this.rdolocal.TabStop = true;
            this.rdolocal.Text = "Local";
            this.rdolocal.UseVisualStyleBackColor = true;
            this.rdolocal.CheckedChanged += new System.EventHandler(this.rdolocal_CheckedChanged);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(202, 268);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(41, 15);
            this.lblstatus.TabIndex = 11;
            this.lblstatus.Text = "Status";
            this.lblstatus.Click += new System.EventHandler(this.lblstatus_Click);
            // 
            // chkactive
            // 
            this.chkactive.AutoSize = true;
            this.chkactive.Location = new System.Drawing.Point(278, 264);
            this.chkactive.Name = "chkactive";
            this.chkactive.Size = new System.Drawing.Size(56, 17);
            this.chkactive.TabIndex = 12;
            this.chkactive.Text = "Active";
            this.chkactive.UseVisualStyleBackColor = true;
            this.chkactive.CheckedChanged += new System.EventHandler(this.chkactive_CheckedChanged);
            // 
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcost.Location = new System.Drawing.Point(202, 304);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(31, 15);
            this.lblcost.TabIndex = 13;
            this.lblcost.Text = "Cost";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(286, 304);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(35, 15);
            this.lblprice.TabIndex = 14;
            this.lblprice.Text = "Price";
            this.lblprice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Markup (%)";
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(203, 320);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(80, 20);
            this.txtcost.TabIndex = 16;
            this.txtcost.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(289, 320);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(82, 20);
            this.txtprice.TabIndex = 17;
            // 
            // txtmarkup
            // 
            this.txtmarkup.Location = new System.Drawing.Point(440, 320);
            this.txtmarkup.Name = "txtmarkup";
            this.txtmarkup.Size = new System.Drawing.Size(95, 20);
            this.txtmarkup.TabIndex = 18;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(203, 363);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(80, 31);
            this.btncancel.TabIndex = 19;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(289, 363);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(82, 31);
            this.btnclear.TabIndex = 20;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(440, 363);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(95, 31);
            this.btnsave.TabIndex = 21;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtmarkup);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblcost);
            this.Controls.Add(this.chkactive);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblorigin);
            this.Controls.Add(this.cbocategory);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblbarcodeisavailable);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.lblbarcode);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbarcode;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label lblbarcodeisavailable;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.ComboBox cbocategory;
        private System.Windows.Forms.Label lblorigin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoabroad;
        private System.Windows.Forms.RadioButton rdolocal;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.CheckBox chkactive;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtmarkup;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
    }
}

