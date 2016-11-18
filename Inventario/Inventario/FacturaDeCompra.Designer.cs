namespace Inventario
{
    partial class FacturaDeCompra
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
            this.lblNomEst = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbNomEst = new System.Windows.Forms.ComboBox();
            this.lblProd = new System.Windows.Forms.Label();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblValPar = new System.Windows.Forms.Label();
            this.txtValPar = new System.Windows.Forms.TextBox();
            this.lblPreVen = new System.Windows.Forms.Label();
            this.txtPreVen = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomEst
            // 
            this.lblNomEst.AutoSize = true;
            this.lblNomEst.Location = new System.Drawing.Point(12, 18);
            this.lblNomEst.Name = "lblNomEst";
            this.lblNomEst.Size = new System.Drawing.Size(121, 13);
            this.lblNomEst.TabIndex = 2;
            this.lblNomEst.Text = "Nombre Establecimiento";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(55, 57);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 9;
            this.lblCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(148, 52);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 10;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // cmbNomEst
            // 
            this.cmbNomEst.FormattingEnabled = true;
            this.cmbNomEst.Location = new System.Drawing.Point(148, 15);
            this.cmbNomEst.Name = "cmbNomEst";
            this.cmbNomEst.Size = new System.Drawing.Size(121, 21);
            this.cmbNomEst.TabIndex = 11;
            this.cmbNomEst.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Location = new System.Drawing.Point(326, 52);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(50, 13);
            this.lblProd.TabIndex = 12;
            this.lblProd.Text = "Producto";
            // 
            // cmbProd
            // 
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(399, 49);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(121, 21);
            this.cmbProd.TabIndex = 13;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(55, 92);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 14;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(148, 89);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 15;
            // 
            // lblValPar
            // 
            this.lblValPar.AutoSize = true;
            this.lblValPar.Location = new System.Drawing.Point(326, 89);
            this.lblValPar.Name = "lblValPar";
            this.lblValPar.Size = new System.Drawing.Size(66, 13);
            this.lblValPar.TabIndex = 16;
            this.lblValPar.Text = "Valor Parcial";
            // 
            // txtValPar
            // 
            this.txtValPar.Location = new System.Drawing.Point(399, 86);
            this.txtValPar.Name = "txtValPar";
            this.txtValPar.Size = new System.Drawing.Size(100, 20);
            this.txtValPar.TabIndex = 17;
            // 
            // lblPreVen
            // 
            this.lblPreVen.AutoSize = true;
            this.lblPreVen.Location = new System.Drawing.Point(36, 127);
            this.lblPreVen.Name = "lblPreVen";
            this.lblPreVen.Size = new System.Drawing.Size(68, 13);
            this.lblPreVen.TabIndex = 18;
            this.lblPreVen.Text = "Precio Venta";
            // 
            // txtPreVen
            // 
            this.txtPreVen.Location = new System.Drawing.Point(148, 124);
            this.txtPreVen.Name = "txtPreVen";
            this.txtPreVen.Size = new System.Drawing.Size(100, 20);
            this.txtPreVen.TabIndex = 19;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(211, 217);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(124, 32);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar Venta";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FacturaDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 261);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtPreVen);
            this.Controls.Add(this.lblPreVen);
            this.Controls.Add(this.txtValPar);
            this.Controls.Add(this.lblValPar);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbProd);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.cmbNomEst);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblNomEst);
            this.Name = "FacturaDeCompra";
            this.Text = "FacturaDeCompra";
            this.Load += new System.EventHandler(this.FacturaDeCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomEst;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbNomEst;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblValPar;
        private System.Windows.Forms.TextBox txtValPar;
        private System.Windows.Forms.Label lblPreVen;
        private System.Windows.Forms.TextBox txtPreVen;
        private System.Windows.Forms.Button btnRegistrar;
    }
}