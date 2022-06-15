
namespace CommodityQuotationTool
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabProduct = new System.Windows.Forms.TabControl();
            this.tabQuote = new System.Windows.Forms.TabPage();
            this.DataColumns = new System.Windows.Forms.DataGridView();
            this.tabOption = new System.Windows.Forms.TabPage();
            this.btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRealPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEfficacy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabProduct.SuspendLayout();
            this.tabQuote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataColumns)).BeginInit();
            this.tabOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.tabQuote);
            this.tabProduct.Controls.Add(this.tabOption);
            this.tabProduct.Location = new System.Drawing.Point(12, 12);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.SelectedIndex = 0;
            this.tabProduct.Size = new System.Drawing.Size(702, 532);
            this.tabProduct.TabIndex = 0;
            // 
            // tabQuote
            // 
            this.tabQuote.Controls.Add(this.DataColumns);
            this.tabQuote.Location = new System.Drawing.Point(4, 25);
            this.tabQuote.Name = "tabQuote";
            this.tabQuote.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuote.Size = new System.Drawing.Size(694, 503);
            this.tabQuote.TabIndex = 0;
            this.tabQuote.Text = "tabPage1";
            this.tabQuote.UseVisualStyleBackColor = true;
            // 
            // DataColumns
            // 
            this.DataColumns.AllowUserToAddRows = false;
            this.DataColumns.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataColumns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colPrice,
            this.colDiscount,
            this.colRealPrice,
            this.colEfficacy});
            this.DataColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataColumns.Location = new System.Drawing.Point(3, 3);
            this.DataColumns.Name = "DataColumns";
            this.DataColumns.ReadOnly = true;
            this.DataColumns.RowHeadersWidth = 51;
            this.DataColumns.RowTemplate.Height = 27;
            this.DataColumns.Size = new System.Drawing.Size(688, 497);
            this.DataColumns.TabIndex = 0;
            // 
            // tabOption
            // 
            this.tabOption.Controls.Add(this.dataGridView1);
            this.tabOption.Location = new System.Drawing.Point(4, 25);
            this.tabOption.Name = "tabOption";
            this.tabOption.Padding = new System.Windows.Forms.Padding(3);
            this.tabOption.Size = new System.Drawing.Size(694, 503);
            this.tabOption.TabIndex = 1;
            this.tabOption.Text = "tabPage2";
            this.tabOption.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(19, 550);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(119, 38);
            this.btn.TabIndex = 1;
            this.btn.Text = "button1";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(688, 497);
            this.dataGridView1.TabIndex = 1;
            // 
            // colName
            // 
            this.colName.HeaderText = "Column1";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 125;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Column1";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 125;
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "Column1";
            this.colDiscount.MinimumWidth = 6;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            this.colDiscount.Width = 125;
            // 
            // colRealPrice
            // 
            this.colRealPrice.HeaderText = "Column1";
            this.colRealPrice.MinimumWidth = 6;
            this.colRealPrice.Name = "colRealPrice";
            this.colRealPrice.ReadOnly = true;
            this.colRealPrice.Width = 125;
            // 
            // colEfficacy
            // 
            this.colEfficacy.HeaderText = "Column1";
            this.colEfficacy.MinimumWidth = 6;
            this.colEfficacy.Name = "colEfficacy";
            this.colEfficacy.ReadOnly = true;
            this.colEfficacy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEfficacy.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn5.Items.AddRange(new object[] {
            "ENABLE",
            "DISABLE"});
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 658);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.tabProduct);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabProduct.ResumeLayout(false);
            this.tabQuote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataColumns)).EndInit();
            this.tabOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProduct;
        private System.Windows.Forms.TabPage tabQuote;
        private System.Windows.Forms.TabPage tabOption;
        private System.Windows.Forms.DataGridView DataColumns;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRealPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEfficacy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
    }
}

