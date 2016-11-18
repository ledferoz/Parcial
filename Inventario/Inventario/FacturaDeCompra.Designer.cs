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
            this.lblIdEst = new System.Windows.Forms.Label();
            this.lblNomEst = new System.Windows.Forms.Label();
            this.txtNomEst = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.txtIdCom = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.fechaCompra = new System.Windows.Forms.DateTimePicker();
            this.cmbRut = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblIdEst
            // 
            this.lblIdEst.AutoSize = true;
            this.lblIdEst.Location = new System.Drawing.Point(13, 13);
            this.lblIdEst.Name = "lblIdEst";
            this.lblIdEst.Size = new System.Drawing.Size(30, 13);
            this.lblIdEst.TabIndex = 0;
            this.lblIdEst.Text = "RUT";
            // 
            // lblNomEst
            // 
            this.lblNomEst.AutoSize = true;
            this.lblNomEst.Location = new System.Drawing.Point(256, 16);
            this.lblNomEst.Name = "lblNomEst";
            this.lblNomEst.Size = new System.Drawing.Size(121, 13);
            this.lblNomEst.TabIndex = 2;
            this.lblNomEst.Text = "Nombre Establecimiento";
            // 
            // txtNomEst
            // 
            this.txtNomEst.Location = new System.Drawing.Point(383, 13);
            this.txtNomEst.Name = "txtNomEst";
            this.txtNomEst.Size = new System.Drawing.Size(100, 20);
            this.txtNomEst.TabIndex = 3;
            // 
            // lblIdCli
            // 
            this.lblIdCli.AutoSize = true;
            this.lblIdCli.Location = new System.Drawing.Point(13, 51);
            this.lblIdCli.Name = "lblIdCli";
            this.lblIdCli.Size = new System.Drawing.Size(70, 13);
            this.lblIdCli.TabIndex = 4;
            this.lblIdCli.Text = "Id Comprador";
            // 
            // txtIdCom
            // 
            this.txtIdCom.Location = new System.Drawing.Point(100, 51);
            this.txtIdCom.Name = "txtIdCom";
            this.txtIdCom.Size = new System.Drawing.Size(100, 20);
            this.txtIdCom.TabIndex = 5;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(259, 57);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(101, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de la compra";
            this.lblFecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // fechaCompra
            // 
            this.fechaCompra.Location = new System.Drawing.Point(383, 57);
            this.fechaCompra.Name = "fechaCompra";
            this.fechaCompra.Size = new System.Drawing.Size(200, 20);
            this.fechaCompra.TabIndex = 7;
            // 
            // cmbRut
            // 
            this.cmbRut.FormattingEnabled = true;
            this.cmbRut.Location = new System.Drawing.Point(79, 10);
            this.cmbRut.Name = "cmbRut";
            this.cmbRut.Size = new System.Drawing.Size(121, 21);
            this.cmbRut.TabIndex = 8;
            // 
            // FacturaDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 261);
            this.Controls.Add(this.cmbRut);
            this.Controls.Add(this.fechaCompra);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtIdCom);
            this.Controls.Add(this.lblIdCli);
            this.Controls.Add(this.txtNomEst);
            this.Controls.Add(this.lblNomEst);
            this.Controls.Add(this.lblIdEst);
            this.Name = "FacturaDeCompra";
            this.Text = "FacturaDeCompra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdEst;
        private System.Windows.Forms.Label lblNomEst;
        private System.Windows.Forms.TextBox txtNomEst;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.TextBox txtIdCom;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker fechaCompra;
        private System.Windows.Forms.ComboBox cmbRut;
    }
}