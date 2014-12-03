namespace AppAdmin
{
    partial class MainR
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
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tabPedidosAct = new System.Windows.Forms.TabPage();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRestaurantsP = new System.Windows.Forms.ComboBox();
            this.dataGridPedidos = new System.Windows.Forms.DataGridView();
            this.cEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cPlatillo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.dataGridHistorial = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRestaurantH = new System.Windows.Forms.ComboBox();
            this.tabRestaurants = new System.Windows.Forms.TabPage();
            this.dataGridCatalogo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRestaurant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRestaurantR = new System.Windows.Forms.ComboBox();
            this.tabOptions.SuspendLayout();
            this.tabPedidosAct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedidos)).BeginInit();
            this.tabHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).BeginInit();
            this.tabRestaurants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.tabPedidosAct);
            this.tabOptions.Controls.Add(this.tabHistorial);
            this.tabOptions.Controls.Add(this.tabRestaurants);
            this.tabOptions.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOptions.Location = new System.Drawing.Point(-1, -1);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(881, 559);
            this.tabOptions.TabIndex = 0;
            this.tabOptions.SelectedIndexChanged += new System.EventHandler(this.tabOptions_SelectedIndexChanged);
            // 
            // tabPedidosAct
            // 
            this.tabPedidosAct.Controls.Add(this.btnEliminarPedido);
            this.tabPedidosAct.Controls.Add(this.label1);
            this.tabPedidosAct.Controls.Add(this.cmbRestaurantsP);
            this.tabPedidosAct.Controls.Add(this.dataGridPedidos);
            this.tabPedidosAct.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPedidosAct.Location = new System.Drawing.Point(4, 27);
            this.tabPedidosAct.Name = "tabPedidosAct";
            this.tabPedidosAct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidosAct.Size = new System.Drawing.Size(873, 528);
            this.tabPedidosAct.TabIndex = 0;
            this.tabPedidosAct.Text = "Pedidos Actuales";
            this.tabPedidosAct.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.btnEliminarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarPedido.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPedido.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPedido.Location = new System.Drawing.Point(762, 129);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(96, 54);
            this.btnEliminarPedido.TabIndex = 4;
            this.btnEliminarPedido.Text = "Eliminar Pedido";
            this.btnEliminarPedido.UseVisualStyleBackColor = false;
            this.btnEliminarPedido.Visible = false;
            this.btnEliminarPedido.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Restaurant";
            // 
            // cmbRestaurantsP
            // 
            this.cmbRestaurantsP.FormattingEnabled = true;
            this.cmbRestaurantsP.Items.AddRange(new object[] {
            "Alhambra",
            "Caribe Café",
            "Capri",
            "El Arrecife",
            "Le Gourmet",
            "Pagoda"});
            this.cmbRestaurantsP.Location = new System.Drawing.Point(580, 17);
            this.cmbRestaurantsP.Name = "cmbRestaurantsP";
            this.cmbRestaurantsP.Size = new System.Drawing.Size(160, 30);
            this.cmbRestaurantsP.TabIndex = 2;
            // 
            // dataGridPedidos
            // 
            this.dataGridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cEstado,
            this.cPlatillo,
            this.cRoom,
            this.cPrecio});
            this.dataGridPedidos.Location = new System.Drawing.Point(10, 55);
            this.dataGridPedidos.Name = "dataGridPedidos";
            this.dataGridPedidos.Size = new System.Drawing.Size(731, 462);
            this.dataGridPedidos.TabIndex = 1;
            this.dataGridPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPedidos_CellContentClick);
            // 
            // cEstado
            // 
            this.cEstado.HeaderText = "Estatus";
            this.cEstado.Name = "cEstado";
            this.cEstado.Width = 80;
            // 
            // cPlatillo
            // 
            this.cPlatillo.HeaderText = "Platillo";
            this.cPlatillo.Name = "cPlatillo";
            this.cPlatillo.Width = 310;
            // 
            // cRoom
            // 
            this.cRoom.HeaderText = "Habitación";
            this.cRoom.Name = "cRoom";
            this.cRoom.Width = 140;
            // 
            // cPrecio
            // 
            this.cPrecio.HeaderText = "Precio";
            this.cPrecio.Name = "cPrecio";
            this.cPrecio.Width = 120;
            // 
            // tabHistorial
            // 
            this.tabHistorial.Controls.Add(this.dataGridHistorial);
            this.tabHistorial.Controls.Add(this.label3);
            this.tabHistorial.Controls.Add(this.cmbRestaurantH);
            this.tabHistorial.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHistorial.Location = new System.Drawing.Point(4, 27);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorial.Size = new System.Drawing.Size(873, 528);
            this.tabHistorial.TabIndex = 1;
            this.tabHistorial.Text = "Historial Pedidos";
            this.tabHistorial.UseVisualStyleBackColor = true;
            // 
            // dataGridHistorial
            // 
            this.dataGridHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.dataGridHistorial.Location = new System.Drawing.Point(76, 50);
            this.dataGridHistorial.Name = "dataGridHistorial";
            this.dataGridHistorial.Size = new System.Drawing.Size(731, 462);
            this.dataGridHistorial.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Platillo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 310;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Habitación";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Estatus";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Restaurant";
            // 
            // cmbRestaurantH
            // 
            this.cmbRestaurantH.FormattingEnabled = true;
            this.cmbRestaurantH.Items.AddRange(new object[] {
            "Alhambra",
            "Caribe Café",
            "Capri",
            "El Arrecife",
            "Le Gourmet",
            "Pagoda"});
            this.cmbRestaurantH.Location = new System.Drawing.Point(647, 13);
            this.cmbRestaurantH.Name = "cmbRestaurantH";
            this.cmbRestaurantH.Size = new System.Drawing.Size(160, 30);
            this.cmbRestaurantH.TabIndex = 5;
            // 
            // tabRestaurants
            // 
            this.tabRestaurants.Controls.Add(this.dataGridCatalogo);
            this.tabRestaurants.Controls.Add(this.label2);
            this.tabRestaurants.Controls.Add(this.cmbRestaurantR);
            this.tabRestaurants.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRestaurants.Location = new System.Drawing.Point(4, 27);
            this.tabRestaurants.Name = "tabRestaurants";
            this.tabRestaurants.Size = new System.Drawing.Size(873, 528);
            this.tabRestaurants.TabIndex = 2;
            this.tabRestaurants.Text = "Restaurantes";
            this.tabRestaurants.UseVisualStyleBackColor = true;
            // 
            // dataGridCatalogo
            // 
            this.dataGridCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.cRestaurant,
            this.dataGridViewTextBoxColumn6});
            this.dataGridCatalogo.Location = new System.Drawing.Point(76, 50);
            this.dataGridCatalogo.Name = "dataGridCatalogo";
            this.dataGridCatalogo.Size = new System.Drawing.Size(659, 462);
            this.dataGridCatalogo.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Platillo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 310;
            // 
            // cRestaurant
            // 
            this.cRestaurant.HeaderText = "Restaurant";
            this.cRestaurant.Name = "cRestaurant";
            this.cRestaurant.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Restaurant";
            // 
            // cmbRestaurantR
            // 
            this.cmbRestaurantR.FormattingEnabled = true;
            this.cmbRestaurantR.Items.AddRange(new object[] {
            "Alhambra",
            "Caribe Café",
            "Capri",
            "El Arrecife",
            "Le Gourmet",
            "Pagoda"});
            this.cmbRestaurantR.Location = new System.Drawing.Point(575, 14);
            this.cmbRestaurantR.Name = "cmbRestaurantR";
            this.cmbRestaurantR.Size = new System.Drawing.Size(160, 30);
            this.cmbRestaurantR.TabIndex = 5;
            this.cmbRestaurantR.SelectedIndexChanged += new System.EventHandler(this.cmbRestaurantR_SelectedIndexChanged);
            // 
            // MainR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(884, 555);
            this.Controls.Add(this.tabOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.Load += new System.EventHandler(this.MainR_Load);
            this.tabOptions.ResumeLayout(false);
            this.tabPedidosAct.ResumeLayout(false);
            this.tabPedidosAct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedidos)).EndInit();
            this.tabHistorial.ResumeLayout(false);
            this.tabHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).EndInit();
            this.tabRestaurants.ResumeLayout(false);
            this.tabRestaurants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCatalogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage tabPedidosAct;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.TabPage tabRestaurants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRestaurantsP;
        private System.Windows.Forms.DataGridView dataGridPedidos;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRestaurantR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRestaurantH;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPlatillo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
        private System.Windows.Forms.DataGridView dataGridHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridCatalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRestaurant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}