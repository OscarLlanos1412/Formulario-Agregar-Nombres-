
namespace Ventana_num4_ListBox
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txtbox_nombre = new System.Windows.Forms.TextBox();
            this.list_nombres = new System.Windows.Forms.ListBox();
            this.btn_eli_nom = new System.Windows.Forms.Button();
            this.btn_edi_nom = new System.Windows.Forms.Button();
            this.textbox_cambio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(39, 191);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(111, 40);
            this.btn_aceptar.TabIndex = 0;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(353, 191);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(111, 40);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(36, 24);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txtbox_nombre
            // 
            this.txtbox_nombre.Location = new System.Drawing.Point(128, 24);
            this.txtbox_nombre.Name = "txtbox_nombre";
            this.txtbox_nombre.Size = new System.Drawing.Size(100, 20);
            this.txtbox_nombre.TabIndex = 3;
            // 
            // list_nombres
            // 
            this.list_nombres.FormattingEnabled = true;
            this.list_nombres.Location = new System.Drawing.Point(288, 12);
            this.list_nombres.Name = "list_nombres";
            this.list_nombres.Size = new System.Drawing.Size(153, 95);
            this.list_nombres.TabIndex = 4;
            this.list_nombres.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_eli_nom
            // 
            this.btn_eli_nom.Location = new System.Drawing.Point(245, 126);
            this.btn_eli_nom.Name = "btn_eli_nom";
            this.btn_eli_nom.Size = new System.Drawing.Size(75, 23);
            this.btn_eli_nom.TabIndex = 5;
            this.btn_eli_nom.Text = "Eliminar ";
            this.btn_eli_nom.UseVisualStyleBackColor = true;
            this.btn_eli_nom.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_edi_nom
            // 
            this.btn_edi_nom.Location = new System.Drawing.Point(389, 126);
            this.btn_edi_nom.Name = "btn_edi_nom";
            this.btn_edi_nom.Size = new System.Drawing.Size(75, 23);
            this.btn_edi_nom.TabIndex = 6;
            this.btn_edi_nom.Text = "Editar";
            this.btn_edi_nom.UseVisualStyleBackColor = true;
            this.btn_edi_nom.Click += new System.EventHandler(this.btn_edi_nom_Click);
            // 
            // textbox_cambio
            // 
            this.textbox_cambio.Location = new System.Drawing.Point(128, 68);
            this.textbox_cambio.Name = "textbox_cambio";
            this.textbox_cambio.Size = new System.Drawing.Size(100, 20);
            this.textbox_cambio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre a cambiar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_cambio);
            this.Controls.Add(this.btn_edi_nom);
            this.Controls.Add(this.btn_eli_nom);
            this.Controls.Add(this.list_nombres);
            this.Controls.Add(this.txtbox_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_aceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txtbox_nombre;
        private System.Windows.Forms.ListBox list_nombres;
        private System.Windows.Forms.Button btn_eli_nom;
        private System.Windows.Forms.Button btn_edi_nom;
        private System.Windows.Forms.TextBox textbox_cambio;
        private System.Windows.Forms.Label label1;
    }
}

