
namespace Deliveries
{
    partial class Delivors
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
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyNameField = new System.Windows.Forms.TextBox();
            this.delivorAddButton = new System.Windows.Forms.Button();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressField = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.employeeField = new System.Windows.Forms.TextBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.outStocksForDelivorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.Location = new System.Drawing.Point(93, 28);
            this.companyNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(142, 24);
            this.companyNameLabel.TabIndex = 1;
            this.companyNameLabel.Text = "Име на фирма:";
            // 
            // companyNameField
            // 
            this.companyNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameField.Location = new System.Drawing.Point(246, 28);
            this.companyNameField.Margin = new System.Windows.Forms.Padding(2);
            this.companyNameField.Name = "companyNameField";
            this.companyNameField.Size = new System.Drawing.Size(165, 29);
            this.companyNameField.TabIndex = 6;
            // 
            // delivorAddButton
            // 
            this.delivorAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivorAddButton.Location = new System.Drawing.Point(215, 278);
            this.delivorAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.delivorAddButton.Name = "delivorAddButton";
            this.delivorAddButton.Size = new System.Drawing.Size(196, 40);
            this.delivorAddButton.TabIndex = 12;
            this.delivorAddButton.Text = "Добави запис";
            this.delivorAddButton.UseVisualStyleBackColor = true;
            this.delivorAddButton.Click += new System.EventHandler(this.delivorAddButton_Click);
            // 
            // phoneField
            // 
            this.phoneField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneField.Location = new System.Drawing.Point(246, 158);
            this.phoneField.Margin = new System.Windows.Forms.Padding(2);
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(165, 29);
            this.phoneField.TabIndex = 14;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(56, 158);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(179, 24);
            this.phoneLabel.TabIndex = 13;
            this.phoneLabel.Text = "Телефонен номер:";
            // 
            // addressField
            // 
            this.addressField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressField.Location = new System.Drawing.Point(246, 92);
            this.addressField.Margin = new System.Windows.Forms.Padding(2);
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(165, 29);
            this.addressField.TabIndex = 16;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(156, 92);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(72, 24);
            this.addressLabel.TabIndex = 15;
            this.addressLabel.Text = "Адрес:";
            // 
            // employeeField
            // 
            this.employeeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeField.Location = new System.Drawing.Point(246, 216);
            this.employeeField.Margin = new System.Windows.Forms.Padding(2);
            this.employeeField.Name = "employeeField";
            this.employeeField.Size = new System.Drawing.Size(165, 29);
            this.employeeField.TabIndex = 18;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.Location = new System.Drawing.Point(75, 216);
            this.employeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(160, 24);
            this.employeeLabel.TabIndex = 17;
            this.employeeLabel.Text = "Лице за контакт:";
            // 
            // outStocksForDelivorButton
            // 
            this.outStocksForDelivorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outStocksForDelivorButton.Location = new System.Drawing.Point(110, 353);
            this.outStocksForDelivorButton.Margin = new System.Windows.Forms.Padding(2);
            this.outStocksForDelivorButton.Name = "outStocksForDelivorButton";
            this.outStocksForDelivorButton.Size = new System.Drawing.Size(301, 40);
            this.outStocksForDelivorButton.TabIndex = 19;
            this.outStocksForDelivorButton.Text = "Доставени стоки за доставчик";
            this.outStocksForDelivorButton.UseVisualStyleBackColor = true;
            this.outStocksForDelivorButton.Click += new System.EventHandler(this.outStocksForDelivorButton_Click);
            // 
            // Delivors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 410);
            this.Controls.Add(this.outStocksForDelivorButton);
            this.Controls.Add(this.employeeField);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneField);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.delivorAddButton);
            this.Controls.Add(this.companyNameField);
            this.Controls.Add(this.companyNameLabel);
            this.Name = "Delivors";
            this.Text = "Delivors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TextBox companyNameField;
        private System.Windows.Forms.Button delivorAddButton;
        private System.Windows.Forms.TextBox phoneField;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox employeeField;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Button outStocksForDelivorButton;
    }
}