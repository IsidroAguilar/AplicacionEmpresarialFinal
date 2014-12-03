namespace AppAdmin
{
    partial class MainA
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
            this.tabRecepcion = new System.Windows.Forms.TabControl();
            this.tabEntrada = new System.Windows.Forms.TabPage();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.cmbHabiDisponible = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAccess = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSalida = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabBloqueos = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabHabita = new System.Windows.Forms.TabPage();
            this.dataGridHabitaciones = new System.Windows.Forms.DataGridView();
            this.RoomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRecepcion.SuspendLayout();
            this.tabEntrada.SuspendLayout();
            this.tabSalida.SuspendLayout();
            this.tabBloqueos.SuspendLayout();
            this.tabHabita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRecepcion
            // 
            this.tabRecepcion.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabRecepcion.Controls.Add(this.tabEntrada);
            this.tabRecepcion.Controls.Add(this.tabSalida);
            this.tabRecepcion.Controls.Add(this.tabBloqueos);
            this.tabRecepcion.Controls.Add(this.tabHabita);
            this.tabRecepcion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRecepcion.Location = new System.Drawing.Point(1, 0);
            this.tabRecepcion.Name = "tabRecepcion";
            this.tabRecepcion.SelectedIndex = 0;
            this.tabRecepcion.Size = new System.Drawing.Size(443, 539);
            this.tabRecepcion.TabIndex = 0;
            // 
            // tabEntrada
            // 
            this.tabEntrada.Controls.Add(this.btnIngresar);
            this.tabEntrada.Controls.Add(this.cmbHabiDisponible);
            this.tabEntrada.Controls.Add(this.txtPassword);
            this.tabEntrada.Controls.Add(this.txtEmail);
            this.tabEntrada.Controls.Add(this.txtAccess);
            this.tabEntrada.Controls.Add(this.txtApellidos);
            this.tabEntrada.Controls.Add(this.txtNombre);
            this.tabEntrada.Controls.Add(this.label6);
            this.tabEntrada.Controls.Add(this.label5);
            this.tabEntrada.Controls.Add(this.label4);
            this.tabEntrada.Controls.Add(this.label3);
            this.tabEntrada.Controls.Add(this.label2);
            this.tabEntrada.Controls.Add(this.label1);
            this.tabEntrada.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEntrada.Location = new System.Drawing.Point(4, 34);
            this.tabEntrada.Name = "tabEntrada";
            this.tabEntrada.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntrada.Size = new System.Drawing.Size(435, 501);
            this.tabEntrada.TabIndex = 0;
            this.tabEntrada.Text = "Entrada";
            this.tabEntrada.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(191, 347);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(151, 47);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "Ingresar Huésped";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // cmbHabiDisponible
            // 
            this.cmbHabiDisponible.FormattingEnabled = true;
            this.cmbHabiDisponible.Location = new System.Drawing.Point(237, 95);
            this.cmbHabiDisponible.Name = "cmbHabiDisponible";
            this.cmbHabiDisponible.Size = new System.Drawing.Size(105, 26);
            this.cmbHabiDisponible.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(166, 279);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(176, 25);
            this.txtPassword.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(166, 243);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 25);
            this.txtEmail.TabIndex = 9;
            // 
            // txtAccess
            // 
            this.txtAccess.Location = new System.Drawing.Point(166, 205);
            this.txtAccess.Name = "txtAccess";
            this.txtAccess.Size = new System.Drawing.Size(176, 25);
            this.txtAccess.TabIndex = 8;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(166, 167);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(176, 25);
            this.txtApellidos.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 131);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 25);
            this.txtNombre.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Access Card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Habitacion";
            // 
            // tabSalida
            // 
            this.tabSalida.Controls.Add(this.button1);
            this.tabSalida.Controls.Add(this.comboBox1);
            this.tabSalida.Controls.Add(this.label8);
            this.tabSalida.Location = new System.Drawing.Point(4, 34);
            this.tabSalida.Name = "tabSalida";
            this.tabSalida.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalida.Size = new System.Drawing.Size(435, 501);
            this.tabSalida.TabIndex = 1;
            this.tabSalida.Text = "Salida";
            this.tabSalida.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 47);
            this.button1.TabIndex = 16;
            this.button1.Text = "Retirar de Huésped";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(220, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 30);
            this.comboBox1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Habitacion";
            // 
            // tabBloqueos
            // 
            this.tabBloqueos.Controls.Add(this.button2);
            this.tabBloqueos.Controls.Add(this.comboBox2);
            this.tabBloqueos.Controls.Add(this.label7);
            this.tabBloqueos.Location = new System.Drawing.Point(4, 34);
            this.tabBloqueos.Name = "tabBloqueos";
            this.tabBloqueos.Size = new System.Drawing.Size(435, 501);
            this.tabBloqueos.TabIndex = 2;
            this.tabBloqueos.Text = "Bloqueos";
            this.tabBloqueos.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 47);
            this.button2.TabIndex = 19;
            this.button2.Text = "Bloquear Habitación";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(222, 147);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(105, 30);
            this.comboBox2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Habitacion";
            // 
            // tabHabita
            // 
            this.tabHabita.Controls.Add(this.dataGridHabitaciones);
            this.tabHabita.Location = new System.Drawing.Point(4, 34);
            this.tabHabita.Name = "tabHabita";
            this.tabHabita.Size = new System.Drawing.Size(435, 501);
            this.tabHabita.TabIndex = 3;
            this.tabHabita.Text = "Habitaciones";
            this.tabHabita.UseVisualStyleBackColor = true;
            // 
            // dataGridHabitaciones
            // 
            this.dataGridHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNum,
            this.RoomStatus});
            this.dataGridHabitaciones.Location = new System.Drawing.Point(68, 40);
            this.dataGridHabitaciones.Name = "dataGridHabitaciones";
            this.dataGridHabitaciones.Size = new System.Drawing.Size(294, 408);
            this.dataGridHabitaciones.TabIndex = 0;
            // 
            // RoomNum
            // 
            this.RoomNum.HeaderText = "Habitación";
            this.RoomNum.Name = "RoomNum";
            // 
            // RoomStatus
            // 
            this.RoomStatus.HeaderText = "Estado";
            this.RoomStatus.Name = "RoomStatus";
            this.RoomStatus.Width = 120;
            // 
            // MainA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 537);
            this.Controls.Add(this.tabRecepcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caribe Resort Playa";
            this.Load += new System.EventHandler(this.MainA_Load);
            this.tabRecepcion.ResumeLayout(false);
            this.tabEntrada.ResumeLayout(false);
            this.tabEntrada.PerformLayout();
            this.tabSalida.ResumeLayout(false);
            this.tabSalida.PerformLayout();
            this.tabBloqueos.ResumeLayout(false);
            this.tabBloqueos.PerformLayout();
            this.tabHabita.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabitaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRecepcion;
        private System.Windows.Forms.TabPage tabEntrada;
        private System.Windows.Forms.TabPage tabSalida;
        private System.Windows.Forms.TabPage tabBloqueos;
        private System.Windows.Forms.TabPage tabHabita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHabiDisponible;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAccess;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridHabitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomStatus;
    }
}