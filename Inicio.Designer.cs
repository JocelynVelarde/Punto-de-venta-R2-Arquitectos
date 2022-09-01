namespace Proyecto
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblstatus1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblstatus2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.menuMantenimiento = new FontAwesome.Sharp.IconButton();
            this.menuProveedores = new FontAwesome.Sharp.IconButton();
            this.menuProductos = new FontAwesome.Sharp.IconButton();
            this.menuClientes = new FontAwesome.Sharp.IconButton();
            this.menuCompras = new FontAwesome.Sharp.IconButton();
            this.menuVentas = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(784, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "SISTEMA DE VENTAS ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.PeachPuff;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.lblstatus1,
            this.toolStripStatusLabel1,
            this.lblstatus2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 53);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(6, 3, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(101, 17);
            this.toolStripStatusLabel2.Text = "Nombre Usuario:";
            // 
            // lblstatus1
            // 
            this.lblstatus1.BackColor = System.Drawing.SystemColors.Control;
            this.lblstatus1.Name = "lblstatus1";
            this.lblstatus1.Size = new System.Drawing.Size(118, 17);
            this.lblstatus1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(30, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(125, 17);
            this.toolStripStatusLabel1.Text = "Fecha / Hora Ingreso:";
            // 
            // lblstatus2
            // 
            this.lblstatus2.BackColor = System.Drawing.SystemColors.Control;
            this.lblstatus2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblstatus2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblstatus2.Name = "lblstatus2";
            this.lblstatus2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblstatus2.Size = new System.Drawing.Size(118, 17);
            this.lblstatus2.Text = "toolStripStatusLabel1";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnsalir.IconColor = System.Drawing.Color.White;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.IconSize = 50;
            this.btnsalir.Location = new System.Drawing.Point(0, 1);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.btnsalir.Size = new System.Drawing.Size(53, 53);
            this.btnsalir.TabIndex = 13;
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // menuMantenimiento
            // 
            this.menuMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.menuMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMantenimiento.ForeColor = System.Drawing.Color.White;
            this.menuMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuMantenimiento.IconColor = System.Drawing.Color.White;
            this.menuMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMantenimiento.IconSize = 80;
            this.menuMantenimiento.Location = new System.Drawing.Point(517, 399);
            this.menuMantenimiento.Name = "menuMantenimiento";
            this.menuMantenimiento.Size = new System.Drawing.Size(119, 108);
            this.menuMantenimiento.TabIndex = 10;
            this.menuMantenimiento.Text = "Mantenimiento";
            this.menuMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuMantenimiento.UseVisualStyleBackColor = false;
            this.menuMantenimiento.Click += new System.EventHandler(this.menuMantenimiento_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.menuProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProveedores.ForeColor = System.Drawing.Color.White;
            this.menuProveedores.IconChar = FontAwesome.Sharp.IconChar.ShippingFast;
            this.menuProveedores.IconColor = System.Drawing.Color.White;
            this.menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProveedores.IconSize = 80;
            this.menuProveedores.Location = new System.Drawing.Point(346, 399);
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(119, 108);
            this.menuProveedores.TabIndex = 9;
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuProveedores.UseVisualStyleBackColor = false;
            this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
            // 
            // menuProductos
            // 
            this.menuProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.menuProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProductos.ForeColor = System.Drawing.Color.White;
            this.menuProductos.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.menuProductos.IconColor = System.Drawing.Color.White;
            this.menuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProductos.IconSize = 80;
            this.menuProductos.Location = new System.Drawing.Point(517, 205);
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.Size = new System.Drawing.Size(119, 108);
            this.menuProductos.TabIndex = 8;
            this.menuProductos.Text = "Productos";
            this.menuProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuProductos.UseVisualStyleBackColor = false;
            this.menuProductos.Click += new System.EventHandler(this.menuProductos_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.menuClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuClientes.ForeColor = System.Drawing.Color.White;
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menuClientes.IconColor = System.Drawing.Color.White;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 80;
            this.menuClientes.Location = new System.Drawing.Point(171, 399);
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(119, 108);
            this.menuClientes.TabIndex = 7;
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuClientes.UseVisualStyleBackColor = false;
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.menuCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCompras.ForeColor = System.Drawing.Color.White;
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.menuCompras.IconColor = System.Drawing.Color.White;
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.IconSize = 80;
            this.menuCompras.Location = new System.Drawing.Point(346, 205);
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(119, 108);
            this.menuCompras.TabIndex = 6;
            this.menuCompras.Text = "Compras";
            this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuCompras.UseVisualStyleBackColor = false;
            this.menuCompras.Click += new System.EventHandler(this.menuCompras_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.menuVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentas.ForeColor = System.Drawing.Color.White;
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuVentas.IconColor = System.Drawing.Color.White;
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.IconSize = 80;
            this.menuVentas.Location = new System.Drawing.Point(171, 205);
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(119, 108);
            this.menuVentas.TabIndex = 5;
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuVentas.UseVisualStyleBackColor = false;
            this.menuVentas.Click += new System.EventHandler(this.menuVentas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.LogoCanal;
            this.pictureBox1.Location = new System.Drawing.Point(539, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.LogoCanal;
            this.pictureBox2.Location = new System.Drawing.Point(367, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proyecto.Properties.Resources.LogoCanal;
            this.pictureBox3.Location = new System.Drawing.Point(190, 421);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(639, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(145, 53);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "Seleccione el movimiento a realizar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuMantenimiento);
            this.Controls.Add(this.menuProveedores);
            this.Controls.Add(this.menuProductos);
            this.Controls.Add(this.menuClientes);
            this.Controls.Add(this.menuCompras);
            this.Controls.Add(this.menuVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(681, 524);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUNTO DE VENTA";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton menuVentas;
        private FontAwesome.Sharp.IconButton menuCompras;
        private FontAwesome.Sharp.IconButton menuClientes;
        private FontAwesome.Sharp.IconButton menuProductos;
        private FontAwesome.Sharp.IconButton menuProveedores;
        private FontAwesome.Sharp.IconButton menuMantenimiento;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblstatus1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblstatus2;
        private FontAwesome.Sharp.IconButton btnsalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
    }
}

