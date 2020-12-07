
namespace Deliveries
{
    partial class ShowDeliveredStocks
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
            this.delivorIDField = new System.Windows.Forms.TextBox();
            this.delivorIDLabel = new System.Windows.Forms.Label();
            this.outputButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // delivorIDField
            // 
            this.delivorIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivorIDField.Location = new System.Drawing.Point(304, 39);
            this.delivorIDField.Margin = new System.Windows.Forms.Padding(2);
            this.delivorIDField.Name = "delivorIDField";
            this.delivorIDField.Size = new System.Drawing.Size(165, 29);
            this.delivorIDField.TabIndex = 8;
            // 
            // delivorIDLabel
            // 
            this.delivorIDLabel.AutoSize = true;
            this.delivorIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivorIDLabel.Location = new System.Drawing.Point(92, 39);
            this.delivorIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.delivorIDLabel.Name = "delivorIDLabel";
            this.delivorIDLabel.Size = new System.Drawing.Size(157, 24);
            this.delivorIDLabel.TabIndex = 7;
            this.delivorIDLabel.Text = "ID на доставчик:";
            // 
            // outputButton
            // 
            this.outputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputButton.Location = new System.Drawing.Point(225, 113);
            this.outputButton.Margin = new System.Windows.Forms.Padding(2);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(127, 40);
            this.outputButton.TabIndex = 13;
            this.outputButton.Text = "Изведи";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 242);
            this.dataGridView1.TabIndex = 14;
            // 
            // ShowDeliveredStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.delivorIDField);
            this.Controls.Add(this.delivorIDLabel);
            this.Name = "ShowDeliveredStocks";
            this.Text = "ShowDeliveredStocks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox delivorIDField;
        private System.Windows.Forms.Label delivorIDLabel;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}