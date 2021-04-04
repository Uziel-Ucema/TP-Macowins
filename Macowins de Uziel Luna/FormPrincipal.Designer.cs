
namespace Macowins_de_Uziel_Luna
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelGanancias = new System.Windows.Forms.Label();
            this.txtRegistros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtFdePago = new System.Windows.Forms.TextBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSalir.Location = new System.Drawing.Point(1165, 435);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 60);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 226);
            this.dataGridView1.TabIndex = 5;
            // 
            // labelGanancias
            // 
            this.labelGanancias.AutoSize = true;
            this.labelGanancias.BackColor = System.Drawing.Color.Transparent;
            this.labelGanancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.labelGanancias.Location = new System.Drawing.Point(14, 285);
            this.labelGanancias.Name = "labelGanancias";
            this.labelGanancias.Size = new System.Drawing.Size(558, 42);
            this.labelGanancias.TabIndex = 6;
            this.labelGanancias.Text = "Las ganancias de hoy son de: $ ";
            // 
            // txtRegistros
            // 
            this.txtRegistros.Location = new System.Drawing.Point(21, 347);
            this.txtRegistros.Multiline = true;
            this.txtRegistros.Name = "txtRegistros";
            this.txtRegistros.Size = new System.Drawing.Size(802, 148);
            this.txtRegistros.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(970, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(947, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(866, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "Forma de pago:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.txtCodigo.Location = new System.Drawing.Point(1095, 57);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(80, 40);
            this.txtCodigo.TabIndex = 12;
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.txtCant.Location = new System.Drawing.Point(1095, 111);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(80, 40);
            this.txtCant.TabIndex = 13;
            // 
            // txtFdePago
            // 
            this.txtFdePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.txtFdePago.Location = new System.Drawing.Point(1095, 165);
            this.txtFdePago.Name = "txtFdePago";
            this.txtFdePago.Size = new System.Drawing.Size(80, 40);
            this.txtFdePago.TabIndex = 14;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnVender.Location = new System.Drawing.Point(931, 306);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(200, 71);
            this.btnVender.TabIndex = 15;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Location = new System.Drawing.Point(872, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 83);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nota: ingrese 0 si se va a pagar en efectivo, 1 si es con tarjeta en un pago, 2 s" +
    "i es con tarjeta y 6 cuotas, 3 si es con tarjeta y 12 cuotas. Cualquier otra opc" +
    "ion hara que no se procese la venta";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 507);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.txtFdePago);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegistros);
            this.Controls.Add(this.labelGanancias);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Name = "FormPrincipal";
            this.Text = "Servicio de venta Macowins";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelGanancias;
        private System.Windows.Forms.TextBox txtRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtFdePago;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label label5;
    }
}

