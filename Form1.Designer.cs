
namespace MediaNotas
{
    partial class Form1
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
            this.txtNota1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNota1
            // 
            this.txtNota1.AutoSize = true;
            this.txtNota1.Location = new System.Drawing.Point(83, 72);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(39, 13);
            this.txtNota1.TabIndex = 0;
            this.txtNota1.Text = "Nota 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // txtNota2
            // 
            this.txtNota2.AutoSize = true;
            this.txtNota2.Location = new System.Drawing.Point(83, 105);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(39, 13);
            this.txtNota2.TabIndex = 2;
            this.txtNota2.Text = "Nota 2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // txtNota3
            // 
            this.txtNota3.AutoSize = true;
            this.txtNota3.Location = new System.Drawing.Point(83, 140);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(39, 13);
            this.txtNota3.TabIndex = 4;
            this.txtNota3.Text = "Nota 3";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(135, 175);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // txtNota4
            // 
            this.txtNota4.AutoSize = true;
            this.txtNota4.Location = new System.Drawing.Point(83, 178);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(39, 13);
            this.txtNota4.TabIndex = 6;
            this.txtNota4.Text = "Nota 4";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(135, 263);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // txtMedia
            // 
            this.txtMedia.AutoSize = true;
            this.txtMedia.Location = new System.Drawing.Point(83, 266);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(36, 13);
            this.txtMedia.TabIndex = 8;
            this.txtMedia.Text = "Média";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(135, 218);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "Resultado";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 377);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNota1);
            this.Name = "Form1";
            this.Text = "Média de notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNota1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtNota2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtNota3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txtNota4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label txtMedia;
        private System.Windows.Forms.Button btnOK;
    }
}

