
namespace Deliveries
{
    partial class Stocks
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
            this.components = new System.ComponentModel.Container();
            this.stockNameLabel = new System.Windows.Forms.Label();
            this.stockDateLabel = new System.Windows.Forms.Label();
            this.stockDurabilityLabel = new System.Windows.Forms.Label();
            this.stockPriceLabel = new System.Windows.Forms.Label();
            this.stockMeasureLabel = new System.Windows.Forms.Label();
            this.stockNameField = new System.Windows.Forms.TextBox();
            this.stockDurabilityField = new System.Windows.Forms.TextBox();
            this.stockPriceField = new System.Windows.Forms.TextBox();
            this.stockDatePicker = new System.Windows.Forms.DateTimePicker();
            this.stockAddButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // stockNameLabel
            // 
            this.stockNameLabel.AutoSize = true;
            this.stockNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNameLabel.Location = new System.Drawing.Point(95, 19);
            this.stockNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stockNameLabel.Name = "stockNameLabel";
            this.stockNameLabel.Size = new System.Drawing.Size(149, 24);
            this.stockNameLabel.TabIndex = 0;
            this.stockNameLabel.Text = "Наименование:";
            // 
            // stockDateLabel
            // 
            this.stockDateLabel.AutoSize = true;
            this.stockDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDateLabel.Location = new System.Drawing.Point(60, 68);
            this.stockDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stockDateLabel.Name = "stockDateLabel";
            this.stockDateLabel.Size = new System.Drawing.Size(194, 24);
            this.stockDateLabel.TabIndex = 1;
            this.stockDateLabel.Text = "Дата производство:";
            // 
            // stockDurabilityLabel
            // 
            this.stockDurabilityLabel.AutoSize = true;
            this.stockDurabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDurabilityLabel.Location = new System.Drawing.Point(144, 121);
            this.stockDurabilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stockDurabilityLabel.Name = "stockDurabilityLabel";
            this.stockDurabilityLabel.Size = new System.Drawing.Size(101, 24);
            this.stockDurabilityLabel.TabIndex = 2;
            this.stockDurabilityLabel.Text = "Трайност:";
            // 
            // stockPriceLabel
            // 
            this.stockPriceLabel.AutoSize = true;
            this.stockPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockPriceLabel.Location = new System.Drawing.Point(183, 168);
            this.stockPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stockPriceLabel.Name = "stockPriceLabel";
            this.stockPriceLabel.Size = new System.Drawing.Size(59, 24);
            this.stockPriceLabel.TabIndex = 3;
            this.stockPriceLabel.Text = "Цена:";
            // 
            // stockMeasureLabel
            // 
            this.stockMeasureLabel.AutoSize = true;
            this.stockMeasureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockMeasureLabel.Location = new System.Drawing.Point(62, 245);
            this.stockMeasureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stockMeasureLabel.Name = "stockMeasureLabel";
            this.stockMeasureLabel.Size = new System.Drawing.Size(180, 24);
            this.stockMeasureLabel.TabIndex = 4;
            this.stockMeasureLabel.Text = "Мярка количество:";
            // 
            // stockNameField
            // 
            this.stockNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNameField.Location = new System.Drawing.Point(255, 19);
            this.stockNameField.Margin = new System.Windows.Forms.Padding(2);
            this.stockNameField.Name = "stockNameField";
            this.stockNameField.Size = new System.Drawing.Size(165, 29);
            this.stockNameField.TabIndex = 5;
            // 
            // stockDurabilityField
            // 
            this.stockDurabilityField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDurabilityField.Location = new System.Drawing.Point(255, 119);
            this.stockDurabilityField.Margin = new System.Windows.Forms.Padding(2);
            this.stockDurabilityField.Name = "stockDurabilityField";
            this.stockDurabilityField.Size = new System.Drawing.Size(76, 29);
            this.stockDurabilityField.TabIndex = 7;
            this.stockDurabilityField.Validating += new System.ComponentModel.CancelEventHandler(this.trajnostValidating);
            // 
            // stockPriceField
            // 
            this.stockPriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockPriceField.Location = new System.Drawing.Point(255, 165);
            this.stockPriceField.Margin = new System.Windows.Forms.Padding(2);
            this.stockPriceField.Name = "stockPriceField";
            this.stockPriceField.Size = new System.Drawing.Size(76, 29);
            this.stockPriceField.TabIndex = 8;
            this.stockPriceField.Validating += new System.ComponentModel.CancelEventHandler(this.price_Validating);
            // 
            // stockDatePicker
            // 
            this.stockDatePicker.CustomFormat = "dd.MM.yyyy";
            this.stockDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stockDatePicker.Location = new System.Drawing.Point(255, 68);
            this.stockDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.stockDatePicker.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.stockDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.stockDatePicker.Name = "stockDatePicker";
            this.stockDatePicker.Size = new System.Drawing.Size(165, 29);
            this.stockDatePicker.TabIndex = 10;
            // 
            // stockAddButton
            // 
            this.stockAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockAddButton.Location = new System.Drawing.Point(187, 320);
            this.stockAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.stockAddButton.Name = "stockAddButton";
            this.stockAddButton.Size = new System.Drawing.Size(196, 40);
            this.stockAddButton.TabIndex = 11;
            this.stockAddButton.Text = "Добави запис";
            this.stockAddButton.UseVisualStyleBackColor = true;
            this.stockAddButton.Click += new System.EventHandler(this.addStockButtonAction);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "kg",
            "l",
            "g",
            "ml",
            "mg"});
            this.listBox1.Location = new System.Drawing.Point(247, 204);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 108);
            this.listBox1.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 366);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.stockAddButton);
            this.Controls.Add(this.stockDatePicker);
            this.Controls.Add(this.stockPriceField);
            this.Controls.Add(this.stockDurabilityField);
            this.Controls.Add(this.stockNameField);
            this.Controls.Add(this.stockMeasureLabel);
            this.Controls.Add(this.stockPriceLabel);
            this.Controls.Add(this.stockDurabilityLabel);
            this.Controls.Add(this.stockDateLabel);
            this.Controls.Add(this.stockNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Stocks";
            this.Text = "frmStoki";
            this.Load += new System.EventHandler(this.Stocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stockNameLabel;
        private System.Windows.Forms.Label stockDateLabel;
        private System.Windows.Forms.Label stockDurabilityLabel;
        private System.Windows.Forms.Label stockPriceLabel;
        private System.Windows.Forms.Label stockMeasureLabel;
        private System.Windows.Forms.TextBox stockNameField;
        private System.Windows.Forms.TextBox stockDurabilityField;
        private System.Windows.Forms.TextBox stockPriceField;
        private System.Windows.Forms.DateTimePicker stockDatePicker;
        private System.Windows.Forms.Button stockAddButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}