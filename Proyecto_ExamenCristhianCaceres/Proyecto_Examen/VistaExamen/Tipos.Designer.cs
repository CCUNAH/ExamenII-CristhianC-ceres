namespace VistaExamen
{
    partial class Tipos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigotextBox1 = new System.Windows.Forms.TextBox();
            this.NombretextBox2 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TiposdataGridView1 = new System.Windows.Forms.DataGridView();
            this.Guardarbutton1 = new System.Windows.Forms.Button();
            this.Nuevobutton1 = new System.Windows.Forms.Button();
            this.Cancelarbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiposdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del soporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // CodigotextBox1
            // 
            this.CodigotextBox1.Location = new System.Drawing.Point(182, 62);
            this.CodigotextBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CodigotextBox1.Name = "CodigotextBox1";
            this.CodigotextBox1.Size = new System.Drawing.Size(100, 22);
            this.CodigotextBox1.TabIndex = 2;
            // 
            // NombretextBox2
            // 
            this.NombretextBox2.Location = new System.Drawing.Point(182, 92);
            this.NombretextBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NombretextBox2.Name = "NombretextBox2";
            this.NombretextBox2.Size = new System.Drawing.Size(194, 22);
            this.NombretextBox2.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TiposdataGridView1
            // 
            this.TiposdataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TiposdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TiposdataGridView1.Location = new System.Drawing.Point(28, 168);
            this.TiposdataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TiposdataGridView1.Name = "TiposdataGridView1";
            this.TiposdataGridView1.Size = new System.Drawing.Size(348, 139);
            this.TiposdataGridView1.TabIndex = 5;
            // 
            // Guardarbutton1
            // 
            this.Guardarbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Guardarbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Guardarbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton1.ForeColor = System.Drawing.Color.White;
            this.Guardarbutton1.Location = new System.Drawing.Point(165, 140);
            this.Guardarbutton1.Name = "Guardarbutton1";
            this.Guardarbutton1.Size = new System.Drawing.Size(107, 21);
            this.Guardarbutton1.TabIndex = 7;
            this.Guardarbutton1.Text = "GUARDAR";
            this.Guardarbutton1.UseVisualStyleBackColor = false;
            this.Guardarbutton1.Click += new System.EventHandler(this.Guardarbutton1_Click);
            // 
            // Nuevobutton1
            // 
            this.Nuevobutton1.BackColor = System.Drawing.Color.Green;
            this.Nuevobutton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Nuevobutton1.ForeColor = System.Drawing.Color.White;
            this.Nuevobutton1.Location = new System.Drawing.Point(27, 12);
            this.Nuevobutton1.Name = "Nuevobutton1";
            this.Nuevobutton1.Size = new System.Drawing.Size(71, 22);
            this.Nuevobutton1.TabIndex = 8;
            this.Nuevobutton1.Text = "Nuevo";
            this.Nuevobutton1.UseVisualStyleBackColor = false;
            this.Nuevobutton1.Click += new System.EventHandler(this.Nuevobutton1_Click);
            // 
            // Cancelarbutton1
            // 
            this.Cancelarbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Cancelarbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancelarbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelarbutton1.ForeColor = System.Drawing.Color.White;
            this.Cancelarbutton1.Location = new System.Drawing.Point(278, 140);
            this.Cancelarbutton1.Name = "Cancelarbutton1";
            this.Cancelarbutton1.Size = new System.Drawing.Size(98, 21);
            this.Cancelarbutton1.TabIndex = 9;
            this.Cancelarbutton1.Text = "CANCELAR";
            this.Cancelarbutton1.UseVisualStyleBackColor = false;
            this.Cancelarbutton1.Click += new System.EventHandler(this.Cancelarbutton1_Click);
            // 
            // Tipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(436, 332);
            this.Controls.Add(this.Cancelarbutton1);
            this.Controls.Add(this.Nuevobutton1);
            this.Controls.Add(this.Guardarbutton1);
            this.Controls.Add(this.TiposdataGridView1);
            this.Controls.Add(this.NombretextBox2);
            this.Controls.Add(this.CodigotextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Tipos";
            this.Text = "Tipos";
            this.Load += new System.EventHandler(this.Tipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiposdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodigotextBox1;
        private System.Windows.Forms.TextBox NombretextBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView TiposdataGridView1;
        private System.Windows.Forms.Button Guardarbutton1;
        private System.Windows.Forms.Button Nuevobutton1;
        private System.Windows.Forms.Button Cancelarbutton1;
    }
}