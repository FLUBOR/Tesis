
namespace Prueba_prototipo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnconectar = new System.Windows.Forms.Button();
            this.cmbpuerto = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnconectar
            // 
            this.btnconectar.Enabled = false;
            this.btnconectar.Location = new System.Drawing.Point(86, 121);
            this.btnconectar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(188, 41);
            this.btnconectar.TabIndex = 0;
            this.btnconectar.Text = "CONECTAR";
            this.btnconectar.UseVisualStyleBackColor = true;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // cmbpuerto
            // 
            this.cmbpuerto.FormattingEnabled = true;
            this.cmbpuerto.Location = new System.Drawing.Point(86, 96);
            this.cmbpuerto.Name = "cmbpuerto";
            this.cmbpuerto.Size = new System.Drawing.Size(188, 21);
            this.cmbpuerto.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(98, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Selecciona el Puerto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "BIENVENIDO ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReload.BackgroundImage")));
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.Location = new System.Drawing.Point(280, 96);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(20, 20);
            this.btnReload.TabIndex = 37;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.Form2_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(387, 243);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbpuerto);
            this.Controls.Add(this.btnconectar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema prototipo para monitorizar/automatizar cultivos en invernaderos";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.ComboBox cmbpuerto;
        private System.Windows.Forms.Label label12;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReload;
    }
}