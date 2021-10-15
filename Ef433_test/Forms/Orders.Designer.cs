
namespace Ef433_test.Forms
{
    partial class Orders
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.OrderDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderDateColumn,
            this.UserFioColumn,
            this.ProductColumn,
            this.ProductSumColumn});
            this.dgvOrders.Location = new System.Drawing.Point(12, 24);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(697, 349);
            this.dgvOrders.TabIndex = 0;
            // 
            // OrderDateColumn
            // 
            this.OrderDateColumn.HeaderText = "Date";
            this.OrderDateColumn.Name = "OrderDateColumn";
            this.OrderDateColumn.ReadOnly = true;
            // 
            // UserFioColumn
            // 
            this.UserFioColumn.HeaderText = "FIO";
            this.UserFioColumn.Name = "UserFioColumn";
            this.UserFioColumn.ReadOnly = true;
            // 
            // ProductColumn
            // 
            this.ProductColumn.HeaderText = "Products";
            this.ProductColumn.Name = "ProductColumn";
            this.ProductColumn.ReadOnly = true;
            // 
            // ProductSumColumn
            // 
            this.ProductSumColumn.HeaderText = "Sum";
            this.ProductSumColumn.Name = "ProductSumColumn";
            this.ProductSumColumn.ReadOnly = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOrders);
            this.Name = "Orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSumColumn;
    }
}