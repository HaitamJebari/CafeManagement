namespace ProjectC_
{
    partial class GuestOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ItemsG = new System.Windows.Forms.DataGridView();
            this.Cat = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SellerName = new System.Windows.Forms.TextBox();
            this.OrderNum = new System.Windows.Forms.TextBox();
            this.OrdersGV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.OrderAmnt = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 746);
            this.panel1.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(46, 611);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 29);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ItemsG
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.ItemsG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.ItemsG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemsG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemsG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemsG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.ItemsG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsG.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ItemsG.EnableHeadersVisualStyles = false;
            this.ItemsG.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.ItemsG.Location = new System.Drawing.Point(651, 62);
            this.ItemsG.Name = "ItemsG";
            this.ItemsG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsG.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ItemsG.RowHeadersVisible = false;
            this.ItemsG.RowHeadersWidth = 92;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ItemsG.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.ItemsG.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ItemsG.RowTemplate.Height = 28;
            this.ItemsG.RowTemplate.ReadOnly = true;
            this.ItemsG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsG.Size = new System.Drawing.Size(601, 283);
            this.ItemsG.TabIndex = 35;
            this.ItemsG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGV_CellContentClick);
            // 
            // Cat
            // 
            this.Cat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat.FormattingEnabled = true;
            this.Cat.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
            this.Cat.Location = new System.Drawing.Point(275, 65);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(227, 37);
            this.Cat.TabIndex = 36;
            this.Cat.Text = "Category";
            this.Cat.SelectedIndexChanged += new System.EventHandler(this.Cat_SelectedIndexChanged);
            this.Cat.SelectionChangeCommitted += new System.EventHandler(this.Cat_SelectionChangeCommitted);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Highlight;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(508, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 42);
            this.button5.TabIndex = 37;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(857, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 32);
            this.label4.TabIndex = 38;
            this.label4.Text = "Place Order";
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(351, 291);
            this.Quantity.Name = "Quantity";
            this.Quantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Quantity.Size = new System.Drawing.Size(93, 30);
            this.Quantity.TabIndex = 42;
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(275, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(262, 43);
            this.button3.TabIndex = 41;
            this.button3.Text = "Add To Cart";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SellerName
            // 
            this.SellerName.Enabled = false;
            this.SellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerName.Location = new System.Drawing.Point(292, 181);
            this.SellerName.Name = "SellerName";
            this.SellerName.Size = new System.Drawing.Size(199, 30);
            this.SellerName.TabIndex = 40;
            this.SellerName.Text = "Guest";
            // 
            // OrderNum
            // 
            this.OrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNum.Location = new System.Drawing.Point(292, 123);
            this.OrderNum.Name = "OrderNum";
            this.OrderNum.Size = new System.Drawing.Size(199, 30);
            this.OrderNum.TabIndex = 39;
            this.OrderNum.Text = "OrderNum";
            // 
            // OrdersGV
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.OrdersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.OrdersGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrdersGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdersGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrdersGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.OrdersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGV.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OrdersGV.EnableHeadersVisualStyles = false;
            this.OrdersGV.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.OrdersGV.Location = new System.Drawing.Point(398, 394);
            this.OrdersGV.Name = "OrdersGV";
            this.OrdersGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.OrdersGV.RowHeadersVisible = false;
            this.OrdersGV.RowHeadersWidth = 92;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.OrdersGV.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.OrdersGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OrdersGV.RowTemplate.Height = 28;
            this.OrdersGV.RowTemplate.ReadOnly = true;
            this.OrdersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersGV.Size = new System.Drawing.Size(750, 232);
            this.OrdersGV.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(674, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 32);
            this.label5.TabIndex = 45;
            this.label5.Text = "Your Order";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(708, 638);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(254, 43);
            this.button4.TabIndex = 44;
            this.button4.Text = "Place The Order ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // OrderAmnt
            // 
            this.OrderAmnt.AutoSize = true;
            this.OrderAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderAmnt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.OrderAmnt.Location = new System.Drawing.Point(1082, 644);
            this.OrderAmnt.Name = "OrderAmnt";
            this.OrderAmnt.Size = new System.Drawing.Size(157, 29);
            this.OrderAmnt.TabIndex = 43;
            this.OrderAmnt.Text = "OrderAmount";
            this.OrderAmnt.Click += new System.EventHandler(this.OrderAmnt_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Date.Location = new System.Drawing.Point(286, 18);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(74, 32);
            this.Date.TabIndex = 47;
            this.Date.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(988, 644);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 48;
            this.label2.Text = "Total :";
            // 
            // GuestOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.OrdersGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.OrderAmnt);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SellerName);
            this.Controls.Add(this.OrderNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Cat);
            this.Controls.Add(this.ItemsG);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestOrder";
            this.Load += new System.EventHandler(this.x);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView ItemsG;
        private System.Windows.Forms.ComboBox Cat;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox SellerName;
        private System.Windows.Forms.TextBox OrderNum;
        private System.Windows.Forms.DataGridView OrdersGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label OrderAmnt;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label2;
    }
}