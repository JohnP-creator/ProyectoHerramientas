namespace PresentacionHerramientas
{
    partial class frmRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistros));
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.Navy;
            this.txtNombres.Location = new System.Drawing.Point(124, 125);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(327, 22);
            this.txtNombres.TabIndex = 0;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.Navy;
            this.txtApellidos.Location = new System.Drawing.Point(124, 188);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(327, 22);
            this.txtApellidos.TabIndex = 1;
            // 
            // txtFecha
            // 
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.Navy;
            this.txtFecha.Location = new System.Drawing.Point(124, 300);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(327, 22);
            this.txtFecha.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Navy;
            this.txtUsuario.Location = new System.Drawing.Point(124, 361);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(151, 22);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtContra
            // 
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContra.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.ForeColor = System.Drawing.Color.Navy;
            this.txtContra.Location = new System.Drawing.Point(348, 361);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(169, 22);
            this.txtContra.TabIndex = 4;
            // 
            // txtRFC
            // 
            this.txtRFC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRFC.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFC.ForeColor = System.Drawing.Color.Navy;
            this.txtRFC.Location = new System.Drawing.Point(124, 241);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(327, 22);
            this.txtRFC.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGuardar.Location = new System.Drawing.Point(493, 401);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 31);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // frmRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentacionHerramientas.Properties.Resources.REGISTRAR_uSUAIRO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(677, 453);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Button btnGuardar;
    }
}