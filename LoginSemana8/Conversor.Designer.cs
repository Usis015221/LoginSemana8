
namespace LoginSemana8
{
    partial class Conversor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de Unidades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libras";
            // 
            // txtLb
            // 
            this.txtLb.Location = new System.Drawing.Point(225, 195);
            this.txtLb.Name = "txtLb";
            this.txtLb.Size = new System.Drawing.Size(223, 26);
            this.txtLb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "A";
            // 
            // txtkg
            // 
            this.txtkg.Location = new System.Drawing.Point(406, 343);
            this.txtkg.Name = "txtkg";
            this.txtkg.Size = new System.Drawing.Size(223, 26);
            this.txtkg.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.Location = new System.Drawing.Point(461, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Resultado";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kilogramos",
            "Toneladas",
            "Gramos",
            "Onza"});
            this.comboBox1.Location = new System.Drawing.Point(597, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Honeydew;
            this.button2.Location = new System.Drawing.Point(1, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "Inicio";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1011, 662);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtkg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Conversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.Conversor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}