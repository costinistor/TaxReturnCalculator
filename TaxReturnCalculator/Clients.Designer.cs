namespace TaxReturnCalculator
{
    partial class Clients
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.passClient = new System.Windows.Forms.Label();
            this.idClient = new System.Windows.Forms.Label();
            this.nameClient = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listClientsBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.inputPassClient = new System.Windows.Forms.TextBox();
            this.inputIdClient = new System.Windows.Forms.TextBox();
            this.inputNameClient = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.btnChangeClient = new System.Windows.Forms.Button();
            this.secondPassClient = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputSecondPassClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.secondPassClient);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.passClient);
            this.panel1.Controls.Add(this.idClient);
            this.panel1.Controls.Add(this.nameClient);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(272, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 175);
            this.panel1.TabIndex = 0;
            // 
            // passClient
            // 
            this.passClient.AutoSize = true;
            this.passClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passClient.Location = new System.Drawing.Point(114, 90);
            this.passClient.Name = "passClient";
            this.passClient.Size = new System.Drawing.Size(114, 17);
            this.passClient.TabIndex = 5;
            this.passClient.Text = "Your first pass";
            // 
            // idClient
            // 
            this.idClient.AutoSize = true;
            this.idClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idClient.Location = new System.Drawing.Point(114, 57);
            this.idClient.Name = "idClient";
            this.idClient.Size = new System.Drawing.Size(60, 17);
            this.idClient.TabIndex = 4;
            this.idClient.Text = "Your id";
            // 
            // nameClient
            // 
            this.nameClient.AutoSize = true;
            this.nameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameClient.Location = new System.Drawing.Point(114, 24);
            this.nameClient.Name = "nameClient";
            this.nameClient.Size = new System.Drawing.Size(86, 17);
            this.nameClient.TabIndex = 3;
            this.nameClient.Text = "Your name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pass one:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // listClientsBox
            // 
            this.listClientsBox.FormattingEnabled = true;
            this.listClientsBox.ItemHeight = 17;
            this.listClientsBox.Location = new System.Drawing.Point(33, 46);
            this.listClientsBox.Name = "listClientsBox";
            this.listClientsBox.Size = new System.Drawing.Size(232, 446);
            this.listClientsBox.Sorted = true;
            this.listClientsBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Clients";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(271, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Insert new client";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.inputSecondPassClient);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelError);
            this.panel2.Controls.Add(this.btnUpdateClient);
            this.panel2.Controls.Add(this.btnAddClient);
            this.panel2.Controls.Add(this.inputPassClient);
            this.panel2.Controls.Add(this.inputIdClient);
            this.panel2.Controls.Add(this.inputNameClient);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(272, 266);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 262);
            this.panel2.TabIndex = 6;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelError.Location = new System.Drawing.Point(240, 169);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(111, 13);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "All fields are requared!";
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUpdateClient.Location = new System.Drawing.Point(36, 201);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(84, 30);
            this.btnUpdateClient.TabIndex = 7;
            this.btnUpdateClient.Text = "Update";
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddClient.Location = new System.Drawing.Point(270, 201);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(84, 30);
            this.btnAddClient.TabIndex = 6;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // inputPassClient
            // 
            this.inputPassClient.Location = new System.Drawing.Point(110, 99);
            this.inputPassClient.Name = "inputPassClient";
            this.inputPassClient.Size = new System.Drawing.Size(244, 23);
            this.inputPassClient.TabIndex = 5;
            // 
            // inputIdClient
            // 
            this.inputIdClient.Location = new System.Drawing.Point(110, 63);
            this.inputIdClient.MaxLength = 12;
            this.inputIdClient.Name = "inputIdClient";
            this.inputIdClient.Size = new System.Drawing.Size(244, 23);
            this.inputIdClient.TabIndex = 4;
            // 
            // inputNameClient
            // 
            this.inputNameClient.Location = new System.Drawing.Point(110, 27);
            this.inputNameClient.Name = "inputNameClient";
            this.inputNameClient.Size = new System.Drawing.Size(244, 23);
            this.inputNameClient.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Pass one:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(269, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Info client";
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Location = new System.Drawing.Point(33, 498);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(75, 30);
            this.btnRemoveClient.TabIndex = 8;
            this.btnRemoveClient.Text = "Remove";
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            this.btnRemoveClient.Click += new System.EventHandler(this.btnRemoveClient_Click);
            // 
            // btnChangeClient
            // 
            this.btnChangeClient.Location = new System.Drawing.Point(114, 498);
            this.btnChangeClient.Name = "btnChangeClient";
            this.btnChangeClient.Size = new System.Drawing.Size(75, 30);
            this.btnChangeClient.TabIndex = 9;
            this.btnChangeClient.Text = "Edit";
            this.btnChangeClient.UseVisualStyleBackColor = true;
            this.btnChangeClient.Click += new System.EventHandler(this.btnChangeClient_Click);
            // 
            // secondPassClient
            // 
            this.secondPassClient.AutoSize = true;
            this.secondPassClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondPassClient.Location = new System.Drawing.Point(114, 124);
            this.secondPassClient.Name = "secondPassClient";
            this.secondPassClient.Size = new System.Drawing.Size(138, 17);
            this.secondPassClient.TabIndex = 7;
            this.secondPassClient.Text = "Your second pass";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pass two:";
            // 
            // inputSecondPassClient
            // 
            this.inputSecondPassClient.Location = new System.Drawing.Point(110, 137);
            this.inputSecondPassClient.Name = "inputSecondPassClient";
            this.inputSecondPassClient.Size = new System.Drawing.Size(244, 23);
            this.inputSecondPassClient.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pass two:";
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 549);
            this.Controls.Add(this.btnChangeClient);
            this.Controls.Add(this.btnRemoveClient);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listClientsBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Clients";
            this.Text = "Clients";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label passClient;
        private System.Windows.Forms.Label idClient;
        private System.Windows.Forms.Label nameClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listClientsBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox inputPassClient;
        private System.Windows.Forms.TextBox inputIdClient;
        private System.Windows.Forms.TextBox inputNameClient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnChangeClient;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label secondPassClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputSecondPassClient;
        private System.Windows.Forms.Label label6;
    }
}