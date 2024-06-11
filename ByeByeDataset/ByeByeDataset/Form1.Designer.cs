namespace ByeByeDataset
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label quantityPerUnitLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label unitsInStockLabel;
            System.Windows.Forms.Label unitsOnOrderLabel;
            System.Windows.Forms.Label reorderLevelLabel;
            System.Windows.Forms.Label discontinuedLabel;
            this.dataSet1 = new ByeByeDataset.DataSet1();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new ByeByeDataset.DataSet1TableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new ByeByeDataset.DataSet1TableAdapters.TableAdapterManager();
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.supplierIDTextBox = new System.Windows.Forms.TextBox();
            this.categoryIDTextBox = new System.Windows.Forms.TextBox();
            this.quantityPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.unitsInStockTextBox = new System.Windows.Forms.TextBox();
            this.unitsOnOrderTextBox = new System.Windows.Forms.TextBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.discontinuedCheckBox = new System.Windows.Forms.CheckBox();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            quantityPerUnitLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            unitsInStockLabel = new System.Windows.Forms.Label();
            unitsOnOrderLabel = new System.Windows.Forms.Label();
            reorderLevelLabel = new System.Windows.Forms.Label();
            discontinuedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.dataSet1;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomerCustomerDemoTableAdapter = null;
            this.tableAdapterManager.CustomerDemographicsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.EmployeeTerritoriesTableAdapter = null;
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ByeByeDataset.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productsBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productsBindingNavigatorSaveItem});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productsBindingNavigator.Size = new System.Drawing.Size(1353, 42);
            this.productsBindingNavigator.TabIndex = 0;
            this.productsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 19);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 32);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsBindingNavigatorSaveItem.Image")));
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.productsBindingNavigatorSaveItem.Text = "Save Data";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn1});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(37, 65);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 82;
            this.productsDataGridView.RowTemplate.Height = 33;
            this.productsDataGridView.Size = new System.Drawing.Size(563, 322);
            this.productsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SupplierID";
            this.dataGridViewTextBoxColumn3.HeaderText = "SupplierID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CategoryID";
            this.dataGridViewTextBoxColumn4.HeaderText = "CategoryID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "QuantityPerUnit";
            this.dataGridViewTextBoxColumn5.HeaderText = "QuantityPerUnit";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UnitsInStock";
            this.dataGridViewTextBoxColumn7.HeaderText = "UnitsInStock";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UnitsOnOrder";
            this.dataGridViewTextBoxColumn8.HeaderText = "UnitsOnOrder";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ReorderLevel";
            this.dataGridViewTextBoxColumn9.HeaderText = "ReorderLevel";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Discontinued";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Discontinued";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 10;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 200;
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(713, 89);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(118, 25);
            productIDLabel.TabIndex = 2;
            productIDLabel.Text = "Product ID:";
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(900, 86);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(104, 31);
            this.productIDTextBox.TabIndex = 3;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(713, 126);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(154, 25);
            productNameLabel.TabIndex = 4;
            productNameLabel.Text = "Product Name:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(900, 123);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(272, 31);
            this.productNameTextBox.TabIndex = 5;
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(713, 163);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(123, 25);
            supplierIDLabel.TabIndex = 6;
            supplierIDLabel.Text = "Supplier ID:";
            // 
            // supplierIDTextBox
            // 
            this.supplierIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "SupplierID", true));
            this.supplierIDTextBox.Location = new System.Drawing.Point(900, 160);
            this.supplierIDTextBox.Name = "supplierIDTextBox";
            this.supplierIDTextBox.Size = new System.Drawing.Size(104, 31);
            this.supplierIDTextBox.TabIndex = 7;
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(713, 200);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(131, 25);
            categoryIDLabel.TabIndex = 8;
            categoryIDLabel.Text = "Category ID:";
            // 
            // categoryIDTextBox
            // 
            this.categoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CategoryID", true));
            this.categoryIDTextBox.Location = new System.Drawing.Point(900, 197);
            this.categoryIDTextBox.Name = "categoryIDTextBox";
            this.categoryIDTextBox.Size = new System.Drawing.Size(104, 31);
            this.categoryIDTextBox.TabIndex = 9;
            // 
            // quantityPerUnitLabel
            // 
            quantityPerUnitLabel.AutoSize = true;
            quantityPerUnitLabel.Location = new System.Drawing.Point(713, 237);
            quantityPerUnitLabel.Name = "quantityPerUnitLabel";
            quantityPerUnitLabel.Size = new System.Drawing.Size(181, 25);
            quantityPerUnitLabel.TabIndex = 10;
            quantityPerUnitLabel.Text = "Quantity Per Unit:";
            // 
            // quantityPerUnitTextBox
            // 
            this.quantityPerUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "QuantityPerUnit", true));
            this.quantityPerUnitTextBox.Location = new System.Drawing.Point(900, 234);
            this.quantityPerUnitTextBox.Name = "quantityPerUnitTextBox";
            this.quantityPerUnitTextBox.Size = new System.Drawing.Size(104, 31);
            this.quantityPerUnitTextBox.TabIndex = 11;
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(713, 274);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(111, 25);
            unitPriceLabel.TabIndex = 12;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(900, 271);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(104, 31);
            this.unitPriceTextBox.TabIndex = 13;
            // 
            // unitsInStockLabel
            // 
            unitsInStockLabel.AutoSize = true;
            unitsInStockLabel.Location = new System.Drawing.Point(713, 311);
            unitsInStockLabel.Name = "unitsInStockLabel";
            unitsInStockLabel.Size = new System.Drawing.Size(150, 25);
            unitsInStockLabel.TabIndex = 14;
            unitsInStockLabel.Text = "Units In Stock:";
            // 
            // unitsInStockTextBox
            // 
            this.unitsInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitsInStock", true));
            this.unitsInStockTextBox.Location = new System.Drawing.Point(900, 308);
            this.unitsInStockTextBox.Name = "unitsInStockTextBox";
            this.unitsInStockTextBox.Size = new System.Drawing.Size(104, 31);
            this.unitsInStockTextBox.TabIndex = 15;
            // 
            // unitsOnOrderLabel
            // 
            unitsOnOrderLabel.AutoSize = true;
            unitsOnOrderLabel.Location = new System.Drawing.Point(713, 348);
            unitsOnOrderLabel.Name = "unitsOnOrderLabel";
            unitsOnOrderLabel.Size = new System.Drawing.Size(161, 25);
            unitsOnOrderLabel.TabIndex = 16;
            unitsOnOrderLabel.Text = "Units On Order:";
            // 
            // unitsOnOrderTextBox
            // 
            this.unitsOnOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitsOnOrder", true));
            this.unitsOnOrderTextBox.Location = new System.Drawing.Point(900, 345);
            this.unitsOnOrderTextBox.Name = "unitsOnOrderTextBox";
            this.unitsOnOrderTextBox.Size = new System.Drawing.Size(104, 31);
            this.unitsOnOrderTextBox.TabIndex = 17;
            // 
            // reorderLevelLabel
            // 
            reorderLevelLabel.AutoSize = true;
            reorderLevelLabel.Location = new System.Drawing.Point(713, 385);
            reorderLevelLabel.Name = "reorderLevelLabel";
            reorderLevelLabel.Size = new System.Drawing.Size(153, 25);
            reorderLevelLabel.TabIndex = 18;
            reorderLevelLabel.Text = "Reorder Level:";
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ReorderLevel", true));
            this.reorderLevelTextBox.Location = new System.Drawing.Point(900, 382);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(104, 31);
            this.reorderLevelTextBox.TabIndex = 19;
            // 
            // discontinuedLabel
            // 
            discontinuedLabel.AutoSize = true;
            discontinuedLabel.Location = new System.Drawing.Point(713, 424);
            discontinuedLabel.Name = "discontinuedLabel";
            discontinuedLabel.Size = new System.Drawing.Size(143, 25);
            discontinuedLabel.TabIndex = 20;
            discontinuedLabel.Text = "Discontinued:";
            // 
            // discontinuedCheckBox
            // 
            this.discontinuedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productsBindingSource, "Discontinued", true));
            this.discontinuedCheckBox.Location = new System.Drawing.Point(900, 419);
            this.discontinuedCheckBox.Name = "discontinuedCheckBox";
            this.discontinuedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.discontinuedCheckBox.TabIndex = 21;
            this.discontinuedCheckBox.Text = "checkBox1";
            this.discontinuedCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 469);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(supplierIDLabel);
            this.Controls.Add(this.supplierIDTextBox);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(this.categoryIDTextBox);
            this.Controls.Add(quantityPerUnitLabel);
            this.Controls.Add(this.quantityPerUnitTextBox);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(unitsInStockLabel);
            this.Controls.Add(this.unitsInStockTextBox);
            this.Controls.Add(unitsOnOrderLabel);
            this.Controls.Add(this.unitsOnOrderTextBox);
            this.Controls.Add(reorderLevelLabel);
            this.Controls.Add(this.reorderLevelTextBox);
            this.Controls.Add(discontinuedLabel);
            this.Controls.Add(this.discontinuedCheckBox);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.productsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox supplierIDTextBox;
        private System.Windows.Forms.TextBox categoryIDTextBox;
        private System.Windows.Forms.TextBox quantityPerUnitTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox unitsInStockTextBox;
        private System.Windows.Forms.TextBox unitsOnOrderTextBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.CheckBox discontinuedCheckBox;
    }
}

