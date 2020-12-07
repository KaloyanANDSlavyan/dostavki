
namespace Deliveries
{
    partial class StockReport
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
            this.viewStocksButton = new System.Windows.Forms.Button();
            this.stockGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stockGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewStocksButton
            // 
            this.viewStocksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStocksButton.Location = new System.Drawing.Point(237, 60);
            this.viewStocksButton.Name = "viewStocksButton";
            this.viewStocksButton.Size = new System.Drawing.Size(467, 65);
            this.viewStocksButton.TabIndex = 0;
            this.viewStocksButton.Text = "Покажи всички стоки";
            this.viewStocksButton.UseVisualStyleBackColor = true;
            this.viewStocksButton.Click += new System.EventHandler(this.viewStockButtonAction);
            // 
            // stockGridView
            // 
            this.stockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockGridView.Location = new System.Drawing.Point(47, 157);
            this.stockGridView.Name = "stockGridView";
            this.stockGridView.RowHeadersWidth = 51;
            this.stockGridView.RowTemplate.Height = 24;
            this.stockGridView.Size = new System.Drawing.Size(861, 322);
            this.stockGridView.TabIndex = 1;
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 523);
            this.Controls.Add(this.stockGridView);
            this.Controls.Add(this.viewStocksButton);
            this.Name = "StockReport";
            this.Text = "StockReport";
            ((System.ComponentModel.ISupportInitialize)(this.stockGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewStocksButton;
        private System.Windows.Forms.DataGridView stockGridView;
    }
}