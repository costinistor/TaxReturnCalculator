namespace TaxReturnCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddPay = new System.Windows.Forms.Button();
            this.inputPay = new System.Windows.Forms.TextBox();
            this.listInvoice = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.resultGross = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.resultNet = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.resultTax = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectMetCalc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBackNum = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnNum_0 = new System.Windows.Forms.Button();
            this.btnNum_9 = new System.Windows.Forms.Button();
            this.btnNum_3 = new System.Windows.Forms.Button();
            this.btnNum_2 = new System.Windows.Forms.Button();
            this.btnNum_8 = new System.Windows.Forms.Button();
            this.btnNum_1 = new System.Windows.Forms.Button();
            this.btnNum_7 = new System.Windows.Forms.Button();
            this.btnNum_5 = new System.Windows.Forms.Button();
            this.btnNum_4 = new System.Windows.Forms.Button();
            this.btnNum_6 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.feeInputSimbol = new System.Windows.Forms.Label();
            this.radioFixedFee = new System.Windows.Forms.RadioButton();
            this.radioPercentageFee = new System.Windows.Forms.RadioButton();
            this.inputAdminFee = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.invoicesCount = new System.Windows.Forms.Label();
            this.btnOpenClients = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tax Return Calculator";
            // 
            // AddPay
            // 
            this.AddPay.BackColor = System.Drawing.Color.Bisque;
            this.AddPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPay.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.AddPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood;
            this.AddPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.AddPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPay.Location = new System.Drawing.Point(139, 39);
            this.AddPay.Name = "AddPay";
            this.AddPay.Size = new System.Drawing.Size(50, 28);
            this.AddPay.TabIndex = 1;
            this.AddPay.Text = "Add";
            this.AddPay.UseVisualStyleBackColor = false;
            this.AddPay.Click += new System.EventHandler(this.AddPay_Click);
            // 
            // inputPay
            // 
            this.inputPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPay.Location = new System.Drawing.Point(14, 40);
            this.inputPay.Name = "inputPay";
            this.inputPay.Size = new System.Drawing.Size(116, 27);
            this.inputPay.TabIndex = 0;
            this.inputPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listInvoice
            // 
            this.listInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listInvoice.FormattingEnabled = true;
            this.listInvoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listInvoice.ItemHeight = 18;
            this.listInvoice.Location = new System.Drawing.Point(266, 116);
            this.listInvoice.Name = "listInvoice";
            this.listInvoice.Size = new System.Drawing.Size(127, 274);
            this.listInvoice.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(551, 396);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 28);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // resultGross
            // 
            this.resultGross.AutoSize = true;
            this.resultGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultGross.ForeColor = System.Drawing.Color.DarkRed;
            this.resultGross.Location = new System.Drawing.Point(99, 12);
            this.resultGross.Name = "resultGross";
            this.resultGross.Size = new System.Drawing.Size(49, 18);
            this.resultGross.TabIndex = 4;
            this.resultGross.Text = "£0.00";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(343, 396);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(266, 396);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(63, 28);
            this.btnClearAll.TabIndex = 6;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(407, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 130);
            this.panel1.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.resultNet);
            this.panel7.Location = new System.Drawing.Point(0, 86);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(217, 42);
            this.panel7.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Net";
            // 
            // resultNet
            // 
            this.resultNet.AutoSize = true;
            this.resultNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultNet.ForeColor = System.Drawing.Color.DarkRed;
            this.resultNet.Location = new System.Drawing.Point(99, 12);
            this.resultNet.Name = "resultNet";
            this.resultNet.Size = new System.Drawing.Size(49, 18);
            this.resultNet.TabIndex = 5;
            this.resultNet.Text = "£0.00";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.resultTax);
            this.panel6.Location = new System.Drawing.Point(0, 43);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(217, 42);
            this.panel6.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Taxes";
            // 
            // resultTax
            // 
            this.resultTax.AutoSize = true;
            this.resultTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTax.ForeColor = System.Drawing.Color.DarkRed;
            this.resultTax.Location = new System.Drawing.Point(99, 12);
            this.resultTax.Name = "resultTax";
            this.resultTax.Size = new System.Drawing.Size(49, 18);
            this.resultTax.TabIndex = 6;
            this.resultTax.Text = "£0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gross";
            // 
            // selectMetCalc
            // 
            this.selectMetCalc.AutoSize = true;
            this.selectMetCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMetCalc.Location = new System.Drawing.Point(50, 89);
            this.selectMetCalc.Name = "selectMetCalc";
            this.selectMetCalc.Size = new System.Drawing.Size(121, 20);
            this.selectMetCalc.TabIndex = 8;
            this.selectMetCalc.Text = "Gross Invoices";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.AddPay);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.inputPay);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(47, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 80);
            this.panel2.TabIndex = 9;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(140, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 26);
            this.button7.TabIndex = 12;
            this.button7.Text = "Tax Pay";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.chooseMet3_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(72, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 26);
            this.button6.TabIndex = 11;
            this.button6.Text = "Net Pay";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.chooseMet2_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 26);
            this.button5.TabIndex = 10;
            this.button5.Text = "Gross Pay";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.chooseMet1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnBackNum);
            this.panel3.Controls.Add(this.btnDecimal);
            this.panel3.Controls.Add(this.btnNum_0);
            this.panel3.Controls.Add(this.btnNum_9);
            this.panel3.Controls.Add(this.btnNum_3);
            this.panel3.Controls.Add(this.btnNum_2);
            this.panel3.Controls.Add(this.btnNum_8);
            this.panel3.Controls.Add(this.btnNum_1);
            this.panel3.Controls.Add(this.btnNum_7);
            this.panel3.Controls.Add(this.btnNum_5);
            this.panel3.Controls.Add(this.btnNum_4);
            this.panel3.Controls.Add(this.btnNum_6);
            this.panel3.Location = new System.Drawing.Point(47, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 220);
            this.panel3.TabIndex = 10;
            // 
            // btnBackNum
            // 
            this.btnBackNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackNum.Location = new System.Drawing.Point(134, 161);
            this.btnBackNum.Name = "btnBackNum";
            this.btnBackNum.Size = new System.Drawing.Size(50, 40);
            this.btnBackNum.TabIndex = 11;
            this.btnBackNum.Text = "<=";
            this.btnBackNum.UseVisualStyleBackColor = true;
            this.btnBackNum.Click += new System.EventHandler(this.btnBackNum_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(76, 161);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(50, 40);
            this.btnDecimal.TabIndex = 10;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnNum_0
            // 
            this.btnNum_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNum_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum_0.Location = new System.Drawing.Point(18, 161);
            this.btnNum_0.Name = "btnNum_0";
            this.btnNum_0.Size = new System.Drawing.Size(50, 40);
            this.btnNum_0.TabIndex = 9;
            this.btnNum_0.Text = "0";
            this.btnNum_0.UseVisualStyleBackColor = true;
            this.btnNum_0.Click += new System.EventHandler(this.btnNum_0_Click);
            // 
            // btnNum_9
            // 
            this.btnNum_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNum_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum_9.Location = new System.Drawing.Point(134, 17);
            this.btnNum_9.Name = "btnNum_9";
            this.btnNum_9.Size = new System.Drawing.Size(50, 40);
            this.btnNum_9.TabIndex = 8;
            this.btnNum_9.Text = "9";
            this.btnNum_9.UseVisualStyleBackColor = true;
            this.btnNum_9.Click += new System.EventHandler(this.btnNum_9_Click);
            // 
            // btnNum_3
            // 
            this.btnNum_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNum_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum_3.Location = new System.Drawing.Point(134, 113);
            this.btnNum_3.Name = "btnNum_3";
            this.btnNum_3.Size = new System.Drawing.Size(50, 40);
            this.btnNum_3.TabIndex = 2;
            this.btnNum_3.Text = "3";
            this.btnNum_3.UseVisualStyleBackColor = true;
            this.btnNum_3.Click += new System.EventHandler(this.btnNum_3_Click);
            // 
            // btnNum_2
            // 
            this.btnNum_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNum_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum_2.Location = new System.Drawing.Point(76, 113);
            this.btnNum_2.Name = "btnNum_2";
            this.btnNum_2.Size = new System.Drawing.Size(50, 40);
            this.btnNum_2.TabIndex = 1;
            this.btnNum_2.Text = "2";
            this.btnNum_2.UseVisualStyleBackColor = true;
            this.btnNum_2.Click += new System.EventHandler(this.btnNum_2_Click);
            // 
            // btnNum_8
            // 
            this.btnNum_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNum_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum_8.Location = new System.Drawing.Point(76, 17);
            this.btnNum_8.Name = "btnNum_8";
            this.btnNum_8.Size = new System.Drawing.Size(50, 40);
            this.btnNum_8.TabIndex = 7;
            this.btnNum_8.Text = "8";
            this.btnNum_8.UseVisualStyleBackColor = true;
            this.btnNum_8.Click += new System.EventHandler(this.btnNum_8_Click);
            // 
            // btnNum_1
            // 
            this.btnNum_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNum_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum_1.Location = new System.Drawing.Point(18, 113);
            this.btnNum_1.Name = "btnNum_1";
            this.btnNum_1.Size = new System.Drawing.Size(50, 40);
            this.btnNum_1.TabIndex = 0;
            this.btnNum_1.Text = "1";
            this.btnNum_1.UseVisualStyleBackColor = true;
            this.btnNum_1.Click += new System.EventHandler(this.btnNum_1_Click);
            // 
            // btnNum_7
            // 
            this.btnNum_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNum_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum_7.Location = new System.Drawing.Point(18, 17);
            this.btnNum_7.Name = "btnNum_7";
            this.btnNum_7.Size = new System.Drawing.Size(50, 40);
            this.btnNum_7.TabIndex = 6;
            this.btnNum_7.Text = "7";
            this.btnNum_7.UseVisualStyleBackColor = true;
            this.btnNum_7.Click += new System.EventHandler(this.btnNum_7_Click);
            // 
            // btnNum_5
            // 
            this.btnNum_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNum_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum_5.Location = new System.Drawing.Point(76, 65);
            this.btnNum_5.Name = "btnNum_5";
            this.btnNum_5.Size = new System.Drawing.Size(50, 40);
            this.btnNum_5.TabIndex = 4;
            this.btnNum_5.Text = "5";
            this.btnNum_5.UseVisualStyleBackColor = true;
            this.btnNum_5.Click += new System.EventHandler(this.btnNum_5_Click);
            // 
            // btnNum_4
            // 
            this.btnNum_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNum_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum_4.Location = new System.Drawing.Point(18, 65);
            this.btnNum_4.Name = "btnNum_4";
            this.btnNum_4.Size = new System.Drawing.Size(50, 40);
            this.btnNum_4.TabIndex = 3;
            this.btnNum_4.Text = "4";
            this.btnNum_4.UseVisualStyleBackColor = true;
            this.btnNum_4.Click += new System.EventHandler(this.btnNum_4_Click);
            // 
            // btnNum_6
            // 
            this.btnNum_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNum_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum_6.Location = new System.Drawing.Point(134, 65);
            this.btnNum_6.Name = "btnNum_6";
            this.btnNum_6.Size = new System.Drawing.Size(50, 40);
            this.btnNum_6.TabIndex = 5;
            this.btnNum_6.Text = "6";
            this.btnNum_6.UseVisualStyleBackColor = true;
            this.btnNum_6.Click += new System.EventHandler(this.btnNum_6_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.feeInputSimbol);
            this.panel4.Controls.Add(this.radioFixedFee);
            this.panel4.Controls.Add(this.radioPercentageFee);
            this.panel4.Controls.Add(this.inputAdminFee);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(407, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 127);
            this.panel4.TabIndex = 11;
            // 
            // feeInputSimbol
            // 
            this.feeInputSimbol.AutoSize = true;
            this.feeInputSimbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeInputSimbol.Location = new System.Drawing.Point(107, 90);
            this.feeInputSimbol.Name = "feeInputSimbol";
            this.feeInputSimbol.Size = new System.Drawing.Size(21, 18);
            this.feeInputSimbol.TabIndex = 4;
            this.feeInputSimbol.Text = "%";
            // 
            // radioFixedFee
            // 
            this.radioFixedFee.AutoSize = true;
            this.radioFixedFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFixedFee.Location = new System.Drawing.Point(23, 58);
            this.radioFixedFee.Name = "radioFixedFee";
            this.radioFixedFee.Size = new System.Drawing.Size(81, 20);
            this.radioFixedFee.TabIndex = 3;
            this.radioFixedFee.TabStop = true;
            this.radioFixedFee.Text = "Fixed fee";
            this.radioFixedFee.UseVisualStyleBackColor = true;
            this.radioFixedFee.CheckedChanged += new System.EventHandler(this.radioFixedFee_CheckedChanged);
            // 
            // radioPercentageFee
            // 
            this.radioPercentageFee.AutoSize = true;
            this.radioPercentageFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPercentageFee.Location = new System.Drawing.Point(23, 31);
            this.radioPercentageFee.Name = "radioPercentageFee";
            this.radioPercentageFee.Size = new System.Drawing.Size(118, 20);
            this.radioPercentageFee.TabIndex = 2;
            this.radioPercentageFee.TabStop = true;
            this.radioPercentageFee.Text = "Percentage fee";
            this.radioPercentageFee.UseVisualStyleBackColor = true;
            this.radioPercentageFee.CheckedChanged += new System.EventHandler(this.radioPercentageFee_CheckedChanged);
            // 
            // inputAdminFee
            // 
            this.inputAdminFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAdminFee.Location = new System.Drawing.Point(23, 87);
            this.inputAdminFee.Name = "inputAdminFee";
            this.inputAdminFee.Size = new System.Drawing.Size(81, 24);
            this.inputAdminFee.TabIndex = 1;
            this.inputAdminFee.Text = "0";
            this.inputAdminFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Administration fee";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.resultGross);
            this.panel5.Location = new System.Drawing.Point(408, 261);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 42);
            this.panel5.TabIndex = 12;
            // 
            // invoicesCount
            // 
            this.invoicesCount.AutoSize = true;
            this.invoicesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicesCount.Location = new System.Drawing.Point(192, 89);
            this.invoicesCount.Name = "invoicesCount";
            this.invoicesCount.Size = new System.Drawing.Size(46, 20);
            this.invoicesCount.TabIndex = 13;
            this.invoicesCount.Text = "No: 0";
            // 
            // btnOpenClients
            // 
            this.btnOpenClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenClients.Location = new System.Drawing.Point(539, 80);
            this.btnOpenClients.Name = "btnOpenClients";
            this.btnOpenClients.Size = new System.Drawing.Size(86, 29);
            this.btnOpenClients.TabIndex = 14;
            this.btnOpenClients.Text = "Clients";
            this.btnOpenClients.UseVisualStyleBackColor = true;
            this.btnOpenClients.Click += new System.EventHandler(this.btnOpenClients_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(673, 473);
            this.Controls.Add(this.btnOpenClients);
            this.Controls.Add(this.invoicesCount);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.selectMetCalc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.listInvoice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tax Return Calc";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddPay;
        private System.Windows.Forms.TextBox inputPay;
        private System.Windows.Forms.ListBox listInvoice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label resultGross;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label resultTax;
        private System.Windows.Forms.Label resultNet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label selectMetCalc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNum_1;
        private System.Windows.Forms.Button btnBackNum;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnNum_0;
        private System.Windows.Forms.Button btnNum_9;
        private System.Windows.Forms.Button btnNum_3;
        private System.Windows.Forms.Button btnNum_2;
        private System.Windows.Forms.Button btnNum_8;
        private System.Windows.Forms.Button btnNum_7;
        private System.Windows.Forms.Button btnNum_5;
        private System.Windows.Forms.Button btnNum_4;
        private System.Windows.Forms.Button btnNum_6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label feeInputSimbol;
        private System.Windows.Forms.RadioButton radioFixedFee;
        private System.Windows.Forms.RadioButton radioPercentageFee;
        private System.Windows.Forms.TextBox inputAdminFee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label invoicesCount;
        private System.Windows.Forms.Button btnOpenClients;
    }
}

