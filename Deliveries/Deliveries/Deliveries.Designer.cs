
namespace Deliveries
{
    partial class Deliveries
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
            this.stockIDField = new System.Windows.Forms.TextBox();
            this.stockIDLabel = new System.Windows.Forms.Label();
            this.delivorIDField = new System.Windows.Forms.TextBox();
            this.delivorIDLabel = new System.Windows.Forms.Label();
            this.documentField = new System.Windows.Forms.TextBox();
            this.documentLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.deliveryAmountLabel = new System.Windows.Forms.Label();
            this.deliveryAmountField = new System.Windows.Forms.TextBox();
            this.deliveryAddButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // stockIDField
            // 
            this.stockIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockIDField.Location = new System.Drawing.Point(322, 38);
            this.stockIDField.Margin = new System.Windows.Forms.Padding(2);
            this.stockIDField.Name = "stockIDField";
            this.stockIDField.Size = new System.Drawing.Size(165, 29);
            this.stockIDField.TabIndex = 7;
            // 
            // stockIDLabel
            // 
            this.stockIDLabel.AutoSize = true;
            this.stockIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockIDLabel.Location = new System.Drawing.Point(162, 38);
            this.stockIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stockIDLabel.Name = "stockIDLabel";
            this.stockIDLabel.Size = new System.Drawing.Size(112, 24);
            this.stockIDLabel.TabIndex = 6;
            this.stockIDLabel.Text = "ID за стока:";
            // 
            // delivorIDField
            // 
            this.delivorIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivorIDField.Location = new System.Drawing.Point(322, 107);
            this.delivorIDField.Margin = new System.Windows.Forms.Padding(2);
            this.delivorIDField.Name = "delivorIDField";
            this.delivorIDField.Size = new System.Drawing.Size(165, 29);
            this.delivorIDField.TabIndex = 9;
            // 
            // delivorIDLabel
            // 
            this.delivorIDLabel.AutoSize = true;
            this.delivorIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivorIDLabel.Location = new System.Drawing.Point(118, 107);
            this.delivorIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.delivorIDLabel.Name = "delivorIDLabel";
            this.delivorIDLabel.Size = new System.Drawing.Size(156, 24);
            this.delivorIDLabel.TabIndex = 8;
            this.delivorIDLabel.Text = "ID за доставчик:";
            // 
            // documentField
            // 
            this.documentField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentField.Location = new System.Drawing.Point(322, 172);
            this.documentField.Margin = new System.Windows.Forms.Padding(2);
            this.documentField.Name = "documentField";
            this.documentField.Size = new System.Drawing.Size(165, 29);
            this.documentField.TabIndex = 11;
            // 
            // documentLabel
            // 
            this.documentLabel.AutoSize = true;
            this.documentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentLabel.Location = new System.Drawing.Point(83, 172);
            this.documentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.documentLabel.Name = "documentLabel";
            this.documentLabel.Size = new System.Drawing.Size(191, 24);
            this.documentLabel.TabIndex = 10;
            this.documentLabel.Text = "Номер на документ:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(322, 236);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 29);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(101, 232);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(173, 24);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Дата на достаква:";
            // 
            // deliveryAmountLabel
            // 
            this.deliveryAmountLabel.AutoSize = true;
            this.deliveryAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryAmountLabel.Location = new System.Drawing.Point(18, 291);
            this.deliveryAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deliveryAmountLabel.Name = "deliveryAmountLabel";
            this.deliveryAmountLabel.Size = new System.Drawing.Size(256, 24);
            this.deliveryAmountLabel.TabIndex = 14;
            this.deliveryAmountLabel.Text = "Количество на доставката:";
            // 
            // deliveryAmountField
            // 
            this.deliveryAmountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryAmountField.Location = new System.Drawing.Point(322, 291);
            this.deliveryAmountField.Margin = new System.Windows.Forms.Padding(2);
            this.deliveryAmountField.Name = "deliveryAmountField";
            this.deliveryAmountField.Size = new System.Drawing.Size(165, 29);
            this.deliveryAmountField.TabIndex = 15;
            this.deliveryAmountField.Validating += new System.ComponentModel.CancelEventHandler(this.amount_Validating);
            // 
            // deliveryAddButton
            // 
            this.deliveryAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryAddButton.Location = new System.Drawing.Point(206, 399);
            this.deliveryAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.deliveryAddButton.Name = "deliveryAddButton";
            this.deliveryAddButton.Size = new System.Drawing.Size(196, 40);
            this.deliveryAddButton.TabIndex = 16;
            this.deliveryAddButton.Text = "Добави запис";
            this.deliveryAddButton.UseVisualStyleBackColor = true;
            this.deliveryAddButton.Click += new System.EventHandler(this.deliveryAddButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Deliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.deliveryAddButton);
            this.Controls.Add(this.deliveryAmountField);
            this.Controls.Add(this.deliveryAmountLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.documentField);
            this.Controls.Add(this.documentLabel);
            this.Controls.Add(this.delivorIDField);
            this.Controls.Add(this.delivorIDLabel);
            this.Controls.Add(this.stockIDField);
            this.Controls.Add(this.stockIDLabel);
            this.Name = "Deliveries";
            this.Text = "Deliveries";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stockIDField;
        private System.Windows.Forms.Label stockIDLabel;
        private System.Windows.Forms.TextBox delivorIDField;
        private System.Windows.Forms.Label delivorIDLabel;
        private System.Windows.Forms.TextBox documentField;
        private System.Windows.Forms.Label documentLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label deliveryAmountLabel;
        private System.Windows.Forms.TextBox deliveryAmountField;
        private System.Windows.Forms.Button deliveryAddButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}