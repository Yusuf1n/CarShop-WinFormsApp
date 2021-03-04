namespace CarShopGUI
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Create_Car = new System.Windows.Forms.Button();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.txt_Colour = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_Make = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_Catalogue = new System.Windows.Forms.ListBox();
            this.btn_Add_To_Cart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lst_Cart = new System.Windows.Forms.ListBox();
            this.btn_Checkout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Create_Car);
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.txt_Year);
            this.groupBox1.Controls.Add(this.txt_Colour);
            this.groupBox1.Controls.Add(this.txt_Model);
            this.groupBox1.Controls.Add(this.txt_Make);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a Car";
            // 
            // btn_Create_Car
            // 
            this.btn_Create_Car.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create_Car.Location = new System.Drawing.Point(75, 165);
            this.btn_Create_Car.Name = "btn_Create_Car";
            this.btn_Create_Car.Size = new System.Drawing.Size(80, 27);
            this.btn_Create_Car.TabIndex = 10;
            this.btn_Create_Car.Text = "Create a Car";
            this.btn_Create_Car.UseVisualStyleBackColor = true;
            this.btn_Create_Car.Click += new System.EventHandler(this.btn_Create_Car_Click);
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(65, 130);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 20);
            this.txt_Price.TabIndex = 9;
            // 
            // txt_Year
            // 
            this.txt_Year.Location = new System.Drawing.Point(65, 104);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(100, 20);
            this.txt_Year.TabIndex = 8;
            // 
            // txt_Colour
            // 
            this.txt_Colour.Location = new System.Drawing.Point(65, 78);
            this.txt_Colour.Name = "txt_Colour";
            this.txt_Colour.Size = new System.Drawing.Size(100, 20);
            this.txt_Colour.TabIndex = 7;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(65, 52);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(100, 20);
            this.txt_Model.TabIndex = 6;
            // 
            // txt_Make
            // 
            this.txt_Make.Location = new System.Drawing.Point(65, 26);
            this.txt_Make.Name = "txt_Make";
            this.txt_Make.Size = new System.Drawing.Size(100, 20);
            this.txt_Make.TabIndex = 5;
            this.txt_Make.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Colour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_Catalogue);
            this.groupBox2.Location = new System.Drawing.Point(220, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 381);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Catalogue";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lst_Catalogue
            // 
            this.lst_Catalogue.FormattingEnabled = true;
            this.lst_Catalogue.Location = new System.Drawing.Point(6, 18);
            this.lst_Catalogue.Name = "lst_Catalogue";
            this.lst_Catalogue.Size = new System.Drawing.Size(259, 355);
            this.lst_Catalogue.TabIndex = 0;
            // 
            // btn_Add_To_Cart
            // 
            this.btn_Add_To_Cart.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_To_Cart.Location = new System.Drawing.Point(305, 402);
            this.btn_Add_To_Cart.Name = "btn_Add_To_Cart";
            this.btn_Add_To_Cart.Size = new System.Drawing.Size(75, 27);
            this.btn_Add_To_Cart.TabIndex = 2;
            this.btn_Add_To_Cart.Text = "Add to Cart";
            this.btn_Add_To_Cart.UseVisualStyleBackColor = true;
            this.btn_Add_To_Cart.Click += new System.EventHandler(this.btn_Add_To_Cart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lst_Cart);
            this.groupBox3.Location = new System.Drawing.Point(509, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 236);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cart";
            // 
            // lst_Cart
            // 
            this.lst_Cart.FormattingEnabled = true;
            this.lst_Cart.Location = new System.Drawing.Point(11, 15);
            this.lst_Cart.Name = "lst_Cart";
            this.lst_Cart.Size = new System.Drawing.Size(259, 212);
            this.lst_Cart.TabIndex = 0;
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Checkout.Location = new System.Drawing.Point(613, 264);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(75, 27);
            this.btn_Checkout.TabIndex = 4;
            this.btn_Checkout.Text = "Checkout";
            this.btn_Checkout.UseVisualStyleBackColor = true;
            this.btn_Checkout.Click += new System.EventHandler(this.btn_Checkout_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(600, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Cost:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(658, 300);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(36, 21);
            this.lbl_Total.TabIndex = 6;
            this.lbl_Total.Text = "£0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Checkout);
            this.Controls.Add(this.btn_Add_To_Cart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Create_Car;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.TextBox txt_Colour;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.TextBox txt_Make;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_Catalogue;
        private System.Windows.Forms.Button btn_Add_To_Cart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lst_Cart;
        private System.Windows.Forms.Button btn_Checkout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Total;
    }
}

