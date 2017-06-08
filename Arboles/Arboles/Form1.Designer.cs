namespace Arboles
{
    partial class Form1
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
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.txtBxDato = new System.Windows.Forms.TextBox();
            this.bttnpreOrder = new System.Windows.Forms.Button();
            this.bttninOrder = new System.Windows.Forms.Button();
            this.bttnpostOrder = new System.Windows.Forms.Button();
            this.txtBxPreInPost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bttnBusBinaria = new System.Windows.Forms.Button();
            this.txtBxVector = new System.Windows.Forms.TextBox();
            this.txtBxNumBuscar = new System.Windows.Forms.TextBox();
            this.bttnBuscarArbol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.AutoSize = true;
            this.bttnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgregar.Location = new System.Drawing.Point(25, 30);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(122, 39);
            this.bttnAgregar.TabIndex = 0;
            this.bttnAgregar.Text = "Agregar";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // txtBxDato
            // 
            this.txtBxDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDato.Location = new System.Drawing.Point(25, 93);
            this.txtBxDato.Name = "txtBxDato";
            this.txtBxDato.Size = new System.Drawing.Size(122, 34);
            this.txtBxDato.TabIndex = 1;
            // 
            // bttnpreOrder
            // 
            this.bttnpreOrder.AutoSize = true;
            this.bttnpreOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnpreOrder.Location = new System.Drawing.Point(174, 88);
            this.bttnpreOrder.Name = "bttnpreOrder";
            this.bttnpreOrder.Size = new System.Drawing.Size(130, 39);
            this.bttnpreOrder.TabIndex = 2;
            this.bttnpreOrder.Text = "Pre Order";
            this.bttnpreOrder.UseVisualStyleBackColor = true;
            this.bttnpreOrder.Click += new System.EventHandler(this.bttnpreOrder_Click);
            // 
            // bttninOrder
            // 
            this.bttninOrder.AutoSize = true;
            this.bttninOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttninOrder.Location = new System.Drawing.Point(326, 88);
            this.bttninOrder.Name = "bttninOrder";
            this.bttninOrder.Size = new System.Drawing.Size(140, 39);
            this.bttninOrder.TabIndex = 3;
            this.bttninOrder.Text = "In Order";
            this.bttninOrder.UseVisualStyleBackColor = true;
            this.bttninOrder.Click += new System.EventHandler(this.bttninOrder_Click);
            // 
            // bttnpostOrder
            // 
            this.bttnpostOrder.AutoSize = true;
            this.bttnpostOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnpostOrder.Location = new System.Drawing.Point(326, 30);
            this.bttnpostOrder.Name = "bttnpostOrder";
            this.bttnpostOrder.Size = new System.Drawing.Size(140, 39);
            this.bttnpostOrder.TabIndex = 4;
            this.bttnpostOrder.Text = "Post Order";
            this.bttnpostOrder.UseVisualStyleBackColor = true;
            this.bttnpostOrder.Click += new System.EventHandler(this.bttnpostOrder_Click);
            // 
            // txtBxPreInPost
            // 
            this.txtBxPreInPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPreInPost.Location = new System.Drawing.Point(25, 154);
            this.txtBxPreInPost.Name = "txtBxPreInPost";
            this.txtBxPreInPost.Size = new System.Drawing.Size(441, 34);
            this.txtBxPreInPost.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(112, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Llenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnBusBinaria
            // 
            this.bttnBusBinaria.AutoSize = true;
            this.bttnBusBinaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBusBinaria.Location = new System.Drawing.Point(112, 303);
            this.bttnBusBinaria.Name = "bttnBusBinaria";
            this.bttnBusBinaria.Size = new System.Drawing.Size(132, 68);
            this.bttnBusBinaria.TabIndex = 7;
            this.bttnBusBinaria.Text = "Búsqueda\r\nBinaria";
            this.bttnBusBinaria.UseVisualStyleBackColor = true;
            this.bttnBusBinaria.Click += new System.EventHandler(this.bttnBusBinaria_Click);
            // 
            // txtBxVector
            // 
            this.txtBxVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxVector.Location = new System.Drawing.Point(275, 233);
            this.txtBxVector.Multiline = true;
            this.txtBxVector.Name = "txtBxVector";
            this.txtBxVector.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxVector.Size = new System.Drawing.Size(93, 210);
            this.txtBxVector.TabIndex = 8;
            // 
            // txtBxNumBuscar
            // 
            this.txtBxNumBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNumBuscar.Location = new System.Drawing.Point(112, 409);
            this.txtBxNumBuscar.Name = "txtBxNumBuscar";
            this.txtBxNumBuscar.Size = new System.Drawing.Size(132, 34);
            this.txtBxNumBuscar.TabIndex = 9;
            // 
            // bttnBuscarArbol
            // 
            this.bttnBuscarArbol.AutoSize = true;
            this.bttnBuscarArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBuscarArbol.Location = new System.Drawing.Point(174, 30);
            this.bttnBuscarArbol.Name = "bttnBuscarArbol";
            this.bttnBuscarArbol.Size = new System.Drawing.Size(130, 39);
            this.bttnBuscarArbol.TabIndex = 10;
            this.bttnBuscarArbol.Text = "Buscar";
            this.bttnBuscarArbol.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 469);
            this.Controls.Add(this.bttnBuscarArbol);
            this.Controls.Add(this.txtBxNumBuscar);
            this.Controls.Add(this.txtBxVector);
            this.Controls.Add(this.bttnBusBinaria);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBxPreInPost);
            this.Controls.Add(this.bttnpostOrder);
            this.Controls.Add(this.bttninOrder);
            this.Controls.Add(this.bttnpreOrder);
            this.Controls.Add(this.txtBxDato);
            this.Controls.Add(this.bttnAgregar);
            this.Name = "Form1";
            this.Text = "Arboles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.TextBox txtBxDato;
        private System.Windows.Forms.Button bttnpreOrder;
        private System.Windows.Forms.Button bttninOrder;
        private System.Windows.Forms.Button bttnpostOrder;
        private System.Windows.Forms.TextBox txtBxPreInPost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttnBusBinaria;
        private System.Windows.Forms.TextBox txtBxVector;
        private System.Windows.Forms.TextBox txtBxNumBuscar;
        private System.Windows.Forms.Button bttnBuscarArbol;
    }
}

