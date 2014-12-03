namespace AdministracionForms
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPedidos = new System.Windows.Forms.TabPage();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.tabPlatillos = new System.Windows.Forms.TabPage();
            this.tabRestaurant = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPedidos);
            this.tabControl1.Controls.Add(this.tabHistorial);
            this.tabControl1.Controls.Add(this.tabRestaurant);
            this.tabControl1.Controls.Add(this.tabPlatillos);
            this.tabControl1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(853, 565);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPedidos
            // 
            this.tabPedidos.Controls.Add(this.label1);
            this.tabPedidos.Controls.Add(this.btnCancelarPedido);
            this.tabPedidos.Controls.Add(this.comboBox1);
            this.tabPedidos.Controls.Add(this.dataGridView1);
            this.tabPedidos.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPedidos.Location = new System.Drawing.Point(4, 29);
            this.tabPedidos.Name = "tabPedidos";
            this.tabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidos.Size = new System.Drawing.Size(845, 532);
            this.tabPedidos.TabIndex = 0;
            this.tabPedidos.Text = "Pedidos Activos";
            this.tabPedidos.UseVisualStyleBackColor = true;
            // 
            // tabHistorial
            // 
            this.tabHistorial.Location = new System.Drawing.Point(4, 29);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorial.Size = new System.Drawing.Size(845, 532);
            this.tabHistorial.TabIndex = 1;
            this.tabHistorial.Text = "Historial Pedidos";
            this.tabHistorial.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alhambra",
            "Caribe Café",
            "Capri",
            "El Arrecife",
            "Le Gourmet",
            "Pagoda"});
            this.comboBox1.Location = new System.Drawing.Point(558, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 26);
            this.comboBox1.TabIndex = 1;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.btnCancelarPedido.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPedido.ForeColor = System.Drawing.Color.White;
            this.btnCancelarPedido.Location = new System.Drawing.Point(731, 242);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(93, 53);
            this.btnCancelarPedido.TabIndex = 2;
            this.btnCancelarPedido.Text = "Cancelar Pedido";
            this.btnCancelarPedido.UseVisualStyleBackColor = false;
            // 
            // tabPlatillos
            // 
            this.tabPlatillos.Location = new System.Drawing.Point(4, 29);
            this.tabPlatillos.Name = "tabPlatillos";
            this.tabPlatillos.Size = new System.Drawing.Size(845, 532);
            this.tabPlatillos.TabIndex = 2;
            this.tabPlatillos.Text = "Platillos";
            this.tabPlatillos.UseVisualStyleBackColor = true;
            // 
            // tabRestaurant
            // 
            this.tabRestaurant.Location = new System.Drawing.Point(4, 29);
            this.tabRestaurant.Name = "tabRestaurant";
            this.tabRestaurant.Size = new System.Drawing.Size(845, 532);
            this.tabRestaurant.TabIndex = 3;
            this.tabRestaurant.Text = "Restaurants";
            this.tabRestaurant.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Restaurnat";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 564);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.tabPedidos.ResumeLayout(false);
            this.tabPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPedidos;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabRestaurant;
        private System.Windows.Forms.TabPage tabPlatillos;
        private System.Windows.Forms.Label label1;
    }
}