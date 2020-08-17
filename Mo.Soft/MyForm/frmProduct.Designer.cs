namespace Mo.Soft.MyForm
{
    partial class frmProduct
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label goods_nameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label qTYLabel;
            System.Windows.Forms.Label reg_dateLabel;
            System.Windows.Forms.Label commentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.good_listDataGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.goods_nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.qTYTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reg_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.good_listBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.good_listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.good_listBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            goods_nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            qTYLabel = new System.Windows.Forms.Label();
            reg_dateLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.good_listDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.good_listBindingNavigator)).BeginInit();
            this.good_listBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.good_listBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // good_listDataGridView
            // 
            this.good_listDataGridView.AutoGenerateColumns = false;
            this.good_listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.good_listDataGridView.DataSource = this.good_listBindingSource;
            this.good_listDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.good_listDataGridView.Location = new System.Drawing.Point(0, 288);
            this.good_listDataGridView.Name = "good_listDataGridView";
            this.good_listDataGridView.RowHeadersWidth = 51;
            this.good_listDataGridView.Size = new System.Drawing.Size(800, 162);
            this.good_listDataGridView.TabIndex = 4;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.good_listBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(236, 27);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(50, 22);
            this.idTextBox.TabIndex = 1;
            // 
            // goods_nameTextBox
            // 
            this.goods_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.good_listBindingSource, "goods_name", true));
            this.goods_nameTextBox.Location = new System.Drawing.Point(236, 54);
            this.goods_nameTextBox.Name = "goods_nameTextBox";
            this.goods_nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.goods_nameTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.good_listBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(236, 81);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 22);
            this.priceTextBox.TabIndex = 5;
            // 
            // qTYTextBox
            // 
            this.qTYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.good_listBindingSource, "QTY", true));
            this.qTYTextBox.Location = new System.Drawing.Point(236, 108);
            this.qTYTextBox.Name = "qTYTextBox";
            this.qTYTextBox.Size = new System.Drawing.Size(200, 22);
            this.qTYTextBox.TabIndex = 7;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.good_listBindingSource, "comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(236, 162);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(200, 22);
            this.commentTextBox.TabIndex = 11;
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(goods_nameLabel);
            this.groupBox1.Controls.Add(this.goods_nameTextBox);
            this.groupBox1.Controls.Add(priceLabel);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(qTYLabel);
            this.groupBox1.Controls.Add(this.qTYTextBox);
            this.groupBox1.Controls.Add(reg_dateLabel);
            this.groupBox1.Controls.Add(this.reg_dateDateTimePicker);
            this.groupBox1.Controls.Add(commentLabel);
            this.groupBox1.Controls.Add(this.commentTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 216);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(184, 30);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 0;
            idLabel.Text = "id:";
            // 
            // goods_nameLabel
            // 
            goods_nameLabel.AutoSize = true;
            goods_nameLabel.Location = new System.Drawing.Point(117, 57);
            goods_nameLabel.Name = "goods_nameLabel";
            goods_nameLabel.Size = new System.Drawing.Size(90, 17);
            goods_nameLabel.TabIndex = 2;
            goods_nameLabel.Text = "goods name:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(164, 84);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(43, 17);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "price:";
            // 
            // qTYLabel
            // 
            qTYLabel.AutoSize = true;
            qTYLabel.Location = new System.Drawing.Point(166, 111);
            qTYLabel.Name = "qTYLabel";
            qTYLabel.Size = new System.Drawing.Size(41, 17);
            qTYLabel.TabIndex = 6;
            qTYLabel.Text = "QTY:";
            // 
            // reg_dateLabel
            // 
            reg_dateLabel.AutoSize = true;
            reg_dateLabel.Location = new System.Drawing.Point(142, 139);
            reg_dateLabel.Name = "reg_dateLabel";
            reg_dateLabel.Size = new System.Drawing.Size(65, 17);
            reg_dateLabel.TabIndex = 8;
            reg_dateLabel.Text = "reg date:";
            // 
            // reg_dateDateTimePicker
            // 
            this.reg_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.good_listBindingSource, "reg_date", true));
            this.reg_dateDateTimePicker.Location = new System.Drawing.Point(236, 135);
            this.reg_dateDateTimePicker.Name = "reg_dateDateTimePicker";
            this.reg_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.reg_dateDateTimePicker.TabIndex = 9;
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(138, 165);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(69, 17);
            commentLabel.TabIndex = 10;
            commentLabel.Text = "comment:";
            // 
            // good_listBindingNavigator
            // 
            this.good_listBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.good_listBindingNavigator.BindingSource = this.good_listBindingSource;
            this.good_listBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.good_listBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.good_listBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.good_listBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.good_listBindingNavigatorSaveItem});
            this.good_listBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.good_listBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.good_listBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.good_listBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.good_listBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.good_listBindingNavigator.Name = "good_listBindingNavigator";
            this.good_listBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.good_listBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.good_listBindingNavigator.TabIndex = 3;
            this.good_listBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // good_listBindingSource
            // 
            this.good_listBindingSource.DataMember = "good_list";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(92, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(77, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // good_listBindingNavigatorSaveItem
            // 
            this.good_listBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("good_listBindingNavigatorSaveItem.Image")));
            this.good_listBindingNavigatorSaveItem.Name = "good_listBindingNavigatorSaveItem";
            this.good_listBindingNavigatorSaveItem.Size = new System.Drawing.Size(100, 28);
            this.good_listBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.good_listDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.good_listBindingNavigator);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            ((System.ComponentModel.ISupportInitialize)(this.good_listDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.good_listBindingNavigator)).EndInit();
            this.good_listBindingNavigator.ResumeLayout(false);
            this.good_listBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.good_listBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton good_listBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView good_listDataGridView;
        private System.Windows.Forms.BindingSource good_listBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox goods_nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox qTYTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker reg_dateDateTimePicker;
        private System.Windows.Forms.BindingNavigator good_listBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    }
}