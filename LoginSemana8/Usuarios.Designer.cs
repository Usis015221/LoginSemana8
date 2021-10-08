
namespace LoginSemana8
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.tusuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseLoginDataSet = new LoginSemana8.BaseLoginDataSet();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtnivel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tusuarioTableAdapter = new LoginSemana8.BaseLoginDataSetTableAdapters.tusuarioTableAdapter();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tusuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseLoginDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Primero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Anterior";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(341, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 57);
            this.button3.TabIndex = 3;
            this.button3.Text = "Siguiente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(487, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 57);
            this.button4.TabIndex = 4;
            this.button4.Text = "Ultimo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(60, 352);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 57);
            this.button5.TabIndex = 5;
            this.button5.Text = "Nuevo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(211, 352);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 57);
            this.button6.TabIndex = 6;
            this.button6.Text = "Eliminar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(341, 352);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 57);
            this.button7.TabIndex = 7;
            this.button7.Text = "Modificar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(487, 352);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 57);
            this.button8.TabIndex = 8;
            this.button8.Text = "Salir";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(60, 428);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(114, 57);
            this.button9.TabIndex = 9;
            this.button9.Text = "Guardar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(341, 428);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(114, 57);
            this.button10.TabIndex = 10;
            this.button10.Text = "Actualizar";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nivel";
            // 
            // txtusuario
            // 
            this.txtusuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tusuarioBindingSource, "usuario", true));
            this.txtusuario.Location = new System.Drawing.Point(369, 81);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(181, 26);
            this.txtusuario.TabIndex = 14;
            // 
            // tusuarioBindingSource
            // 
            this.tusuarioBindingSource.DataMember = "tusuario";
            this.tusuarioBindingSource.DataSource = this.baseLoginDataSet;
            // 
            // baseLoginDataSet
            // 
            this.baseLoginDataSet.DataSetName = "BaseLoginDataSet";
            this.baseLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtclave
            // 
            this.txtclave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tusuarioBindingSource, "password", true));
            this.txtclave.Location = new System.Drawing.Point(369, 130);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(181, 26);
            this.txtclave.TabIndex = 15;
            // 
            // txtnivel
            // 
            this.txtnivel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tusuarioBindingSource, "nivel", true));
            this.txtnivel.FormattingEnabled = true;
            this.txtnivel.Location = new System.Drawing.Point(369, 177);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(181, 28);
            this.txtnivel.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "INGRESO DE USUARIOS AL SISTEMA";
            // 
            // tusuarioTableAdapter
            // 
            this.tusuarioTableAdapter.ClearBeforeFill = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 12);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 57);
            this.button11.TabIndex = 18;
            this.button11.Text = "Inicio";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(680, 497);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tusuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseLoginDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.ComboBox txtnivel;
        private System.Windows.Forms.Label label4;
        private BaseLoginDataSet baseLoginDataSet;
        private System.Windows.Forms.BindingSource tusuarioBindingSource;
        private BaseLoginDataSetTableAdapters.tusuarioTableAdapter tusuarioTableAdapter;
        private System.Windows.Forms.Button button11;
    }
}