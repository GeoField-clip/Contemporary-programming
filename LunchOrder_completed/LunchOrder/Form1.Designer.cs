namespace LunchOrder
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            gbxMainCourse = new GroupBox();
            rdoSalad = new RadioButton();
            rdoPizza = new RadioButton();
            rdoHamburger = new RadioButton();
            gbxAddOns = new GroupBox();
            chkAddOn3 = new CheckBox();
            chkAddOn2 = new CheckBox();
            chkAddOn1 = new CheckBox();
            groupBox2 = new GroupBox();
            txtOrderTotal = new TextBox();
            label3 = new Label();
            txtSalesTax = new TextBox();
            label2 = new Label();
            txtSubtotal = new TextBox();
            label1 = new Label();
            btnPlaceOrder = new Button();
            btnExit = new Button();
            gbxMainCourse.SuspendLayout();
            gbxAddOns.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // gbxMainCourse
            // 
            gbxMainCourse.Controls.Add(rdoSalad);
            gbxMainCourse.Controls.Add(rdoPizza);
            gbxMainCourse.Controls.Add(rdoHamburger);
            gbxMainCourse.Location = new Point(49, 28);
            gbxMainCourse.Name = "gbxMainCourse";
            gbxMainCourse.Size = new Size(227, 163);
            gbxMainCourse.TabIndex = 0;
            gbxMainCourse.TabStop = false;
            gbxMainCourse.Text = "Main Course";
            // 
            // rdoSalad
            // 
            rdoSalad.AutoSize = true;
            rdoSalad.Location = new Point(27, 114);
            rdoSalad.Name = "rdoSalad";
            rdoSalad.Size = new Size(141, 29);
            rdoSalad.TabIndex = 2;
            rdoSalad.Text = "Salad - $4.95";
            rdoSalad.UseVisualStyleBackColor = true;
            rdoSalad.CheckedChanged += MainCourse_CheckedChanged;
            // 
            // rdoPizza
            // 
            rdoPizza.AutoSize = true;
            rdoPizza.Location = new Point(27, 76);
            rdoPizza.Name = "rdoPizza";
            rdoPizza.Size = new Size(137, 29);
            rdoPizza.TabIndex = 1;
            rdoPizza.Text = "Pizza - $5.95";
            rdoPizza.UseVisualStyleBackColor = true;
            rdoPizza.CheckedChanged += MainCourse_CheckedChanged;
            // 
            // rdoHamburger
            // 
            rdoHamburger.AutoSize = true;
            rdoHamburger.Checked = true;
            rdoHamburger.Location = new Point(27, 38);
            rdoHamburger.Name = "rdoHamburger";
            rdoHamburger.Size = new Size(189, 29);
            rdoHamburger.TabIndex = 0;
            rdoHamburger.TabStop = true;
            rdoHamburger.Text = "Hamburger - $6.95";
            rdoHamburger.UseVisualStyleBackColor = true;
            rdoHamburger.CheckedChanged += MainCourse_CheckedChanged;
            // 
            // gbxAddOns
            // 
            gbxAddOns.Controls.Add(chkAddOn3);
            gbxAddOns.Controls.Add(chkAddOn2);
            gbxAddOns.Controls.Add(chkAddOn1);
            gbxAddOns.Location = new Point(304, 28);
            gbxAddOns.Name = "gbxAddOns";
            gbxAddOns.Size = new Size(264, 163);
            gbxAddOns.TabIndex = 1;
            gbxAddOns.TabStop = false;
            gbxAddOns.Text = "Add-on items ($.75/each)";
            // 
            // chkAddOn3
            // 
            chkAddOn3.AutoSize = true;
            chkAddOn3.Location = new Point(19, 114);
            chkAddOn3.Name = "chkAddOn3";
            chkAddOn3.Size = new Size(128, 29);
            chkAddOn3.TabIndex = 2;
            chkAddOn3.Text = "French fries";
            chkAddOn3.UseVisualStyleBackColor = true;
            chkAddOn3.CheckedChanged += AddOn_CheckedChanged;
            // 
            // chkAddOn2
            // 
            chkAddOn2.AutoSize = true;
            chkAddOn2.Location = new Point(19, 76);
            chkAddOn2.Name = "chkAddOn2";
            chkAddOn2.Size = new Size(266, 29);
            chkAddOn2.TabIndex = 1;
            chkAddOn2.Text = "Ketchup, mustard, and mayo";
            chkAddOn2.UseVisualStyleBackColor = true;
            chkAddOn2.CheckedChanged += AddOn_CheckedChanged;
            // 
            // chkAddOn1
            // 
            chkAddOn1.AutoSize = true;
            chkAddOn1.Location = new Point(19, 38);
            chkAddOn1.Name = "chkAddOn1";
            chkAddOn1.Size = new Size(260, 29);
            chkAddOn1.TabIndex = 0;
            chkAddOn1.Text = "Lettuce, tomato, and onions";
            chkAddOn1.UseVisualStyleBackColor = true;
            chkAddOn1.CheckedChanged += AddOn_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtOrderTotal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtSalesTax);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSubtotal);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(49, 222);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(371, 192);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(160, 127);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new Size(150, 31);
            txtOrderTotal.TabIndex = 5;
            txtOrderTotal.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 132);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 4;
            label3.Text = "Order Total:";
            // 
            // txtSalesTax
            // 
            txtSalesTax.Location = new Point(160, 83);
            txtSalesTax.Name = "txtSalesTax";
            txtSalesTax.ReadOnly = true;
            txtSalesTax.Size = new Size(150, 31);
            txtSalesTax.TabIndex = 3;
            txtSalesTax.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 88);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 2;
            label2.Text = "Tax (7.75%):";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(160, 38);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(150, 31);
            txtSubtotal.TabIndex = 1;
            txtSubtotal.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 43);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(457, 238);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(111, 42);
            btnPlaceOrder.TabIndex = 3;
            btnPlaceOrder.Text = "Place &Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(457, 370);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(111, 42);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnPlaceOrder;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(619, 457);
            Controls.Add(gbxAddOns);
            Controls.Add(btnExit);
            Controls.Add(btnPlaceOrder);
            Controls.Add(groupBox2);
            Controls.Add(gbxMainCourse);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "George Feldmann Lunch Order App";
            gbxMainCourse.ResumeLayout(false);
            gbxMainCourse.PerformLayout();
            gbxAddOns.ResumeLayout(false);
            gbxAddOns.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoHamburger;
        private System.Windows.Forms.GroupBox gbxAddOns;
        private System.Windows.Forms.CheckBox chkAddOn3;
        private System.Windows.Forms.CheckBox chkAddOn2;
        private System.Windows.Forms.CheckBox chkAddOn1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
    }
}
