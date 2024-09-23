namespace ferreteria_capa
{
    partial class Form2
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
            this.ver = new System.Windows.Forms.PictureBox();
            this.eliminar = new System.Windows.Forms.PictureBox();
            this.agregar = new System.Windows.Forms.PictureBox();
            this.editar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ver
            // 
            this.ver.Image = global::ferreteria_capa.Properties.Resources.ojo__1_;
            this.ver.Location = new System.Drawing.Point(23, 256);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(48, 45);
            this.ver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ver.TabIndex = 4;
            this.ver.TabStop = false;
            this.ver.Click += new System.EventHandler(this.ver_Click);
            // 
            // eliminar
            // 
            this.eliminar.Image = global::ferreteria_capa.Properties.Resources.eliminar_usuario;
            this.eliminar.Location = new System.Drawing.Point(426, 256);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(53, 45);
            this.eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eliminar.TabIndex = 3;
            this.eliminar.TabStop = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // agregar
            // 
            this.agregar.Image = global::ferreteria_capa.Properties.Resources.usuario_verificado;
            this.agregar.Location = new System.Drawing.Point(426, 21);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(53, 46);
            this.agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.agregar.TabIndex = 2;
            this.agregar.TabStop = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // editar
            // 
            this.editar.Image = global::ferreteria_capa.Properties.Resources.editar_usuario;
            this.editar.Location = new System.Drawing.Point(23, 21);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(48, 46);
            this.editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editar.TabIndex = 1;
            this.editar.TabStop = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ferreteria_capa.Properties.Resources.nino;
            this.pictureBox1.Location = new System.Drawing.Point(129, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(513, 324);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.ver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox editar;
        private System.Windows.Forms.PictureBox agregar;
        private System.Windows.Forms.PictureBox eliminar;
        private System.Windows.Forms.PictureBox ver;
    }
}