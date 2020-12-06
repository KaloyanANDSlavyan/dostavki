
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
            this.stockNameLabel = new System.Windows.Forms.Label();
            this.stockDateLabel = new System.Windows.Forms.Label();
            this.stockDurabilityLabel = new System.Windows.Forms.Label();
            this.stockPriceLabel = new System.Windows.Forms.Label();
            this.stockMeasureLabel = new System.Windows.Forms.Label();
            this.stockNameField = new System.Windows.Forms.TextBox();
            this.stockDurabilityField = new System.Windows.Forms.TextBox();
            this.stockPriceField = new System.Windows.Forms.TextBox();
            this.stockMeasureField = new System.Windows.Forms.TextBox();
            this.stockDatePicker = new System.Windows.Forms.DateTimePicker();
            this.stockAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stockNameLabel
            // 
            this.stockNameLabel.AutoSize = true;
            this.stockNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNameLabel.Location = new System.Drawing.Point(127, 53);
            this.stockNameLabel.Name = "stockNameLabel";
            this.stockNameLabel.Size = new System.Drawing.Size(195, 29);
            this.stockNameLabel.TabIndex = 0;
            this.stockNameLabel.Text = "Наименование:";
            // 
            // stockDateLabel
            // 
            this.stockDateLabel.AutoSize = true;
            this.stockDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDateLabel.Location = new System.Drawing.Point(80, 113);
            this.stockDateLabel.Name = "stockDateLabel";
            this.stockDateLabel.Size = new System.Drawing.Size(242, 29);
            this.stockDateLabel.TabIndex = 1;
            this.stockDateLabel.Text = "Дата производство:";
            // 
            // stockDurabilityLabel
            // 
            this.stockDurabilityLabel.AutoSize = true;
            this.stockDurabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDurabilityLabel.Location = new System.Drawing.Point(192, 179);
            this.stockDurabilityLabel.Name = "stockDurabilityLabel";
            this.stockDurabilityLabel.Size = new System.Drawing.Size(130, 29);
            this.stockDurabilityLabel.TabIndex = 2;
            this.stockDurabilityLabel.Text = "Трайност:";
            // 
            // stockPriceLabel
            // 
            this.stockPriceLabel.AutoSize = true;
            this.stockPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockPriceLabel.Location = new System.Drawing.Point(244, 236);
            this.stockPriceLabel.Name = "stockPriceLabel";
            this.stockPriceLabel.Size = new System.Drawing.Size(78, 29);
            this.stockPriceLabel.TabIndex = 3;
            this.stockPriceLabel.Text = "Цена:";
            // 
            // stockMeasureLabel
            // 
            this.stockMeasureLabel.AutoSize = true;
            this.stockMeasureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockMeasureLabel.Location = new System.Drawing.Point(89, 283);
            this.stockMeasureLabel.Name = "stockMeasureLabel";
            this.stockMeasureLabel.Size = new System.Drawing.Size(233, 29);
            this.stockMeasureLabel.TabIndex = 4;
            this.stockMeasureLabel.Text = "Мярка количество:";
            // 
            // stockNameField
            // 
            this.stockNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNameField.Location = new System.Drawing.Point(340, 53);
            this.stockNameField.Name = "stockNameField";
            this.stockNameField.Size = new System.Drawing.Size(219, 34);
            this.stockNameField.TabIndex = 5;
            // 
            // stockDurabilityField
            // 
            this.stockDurabilityField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDurabilityField.Location = new System.Drawing.Point(340, 176);
            this.stockDurabilityField.Name = "stockDurabilityField";
            this.stockDurabilityField.Size = new System.Drawing.Size(100, 34);
            this.stockDurabilityField.TabIndex = 7;
            // 
            // stockPriceField
            // 
            this.stockPriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockPriceField.Location = new System.Drawing.Point(340, 233);
            this.stockPriceField.Name = "stockPriceField";
            this.stockPriceField.Size = new System.Drawing.Size(100, 34);
            this.stockPriceField.TabIndex = 8;
            // 
            // stockMeasureField
            // 
            this.stockMeasureField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockMeasureField.Location = new System.Drawing.Point(340, 283);
            this.stockMeasureField.Name = "stockMeasureField";
            this.stockMeasureField.Size = new System.Drawing.Size(100, 34);
            this.stockMeasureField.TabIndex = 9;
            // 
            // stockDatePicker
            // 
            this.stockDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDatePicker.Location = new System.Drawing.Point(340, 113);
            this.stockDatePicker.Name = "stockDatePicker";
            this.stockDatePicker.Size = new System.Drawing.Size(436, 34);
            this.stockDatePicker.TabIndex = 10;
            // 
            // stockAddButton
            // 
            this.stockAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockAddButton.Location = new System.Drawing.Point(246, 349);
            this.stockAddButton.Name = "stockAddButton";
            this.stockAddButton.Size = new System.Drawing.Size(262, 49);
            this.stockAddButton.TabIndex = 11;
            this.stockAddButton.Text = "Добави запис";
            this.stockAddButton.UseVisualStyleBackColor = true;
            this.stockAddButton.Click += new System.EventHandler(this.addStockButtonAction);
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.stockAddButton);
            this.Controls.Add(this.stockDatePicker);
            this.Controls.Add(this.stockMeasureField);
            this.Controls.Add(this.stockPriceField);
            this.Controls.Add(this.stockDurabilityField);
            this.Controls.Add(this.stockNameField);
            this.Controls.Add(this.stockMeasureLabel);
            this.Controls.Add(this.stockPriceLabel);
            this.Controls.Add(this.stockDurabilityLabel);
            this.Controls.Add(this.stockDateLabel);
            this.Controls.Add(this.stockNameLabel);
            this.Name = "Stocks";
            this.Text = "frmStoki";
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
        private System.Windows.Forms.TextBox stockMeasureField;
        private System.Windows.Forms.DateTimePicker stockDatePicker;
        private System.Windows.Forms.Button stockAddButton;
    }
}