namespace Prueba_prototipo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBuffer = new System.Windows.Forms.TextBox();
            this.BtnEnviarDatosRA = new System.Windows.Forms.Button();
            this.BtnRiegoManual = new System.Windows.Forms.Button();
            this.RdOptionAutomatico = new System.Windows.Forms.RadioButton();
            this.RdOptionManual = new System.Windows.Forms.RadioButton();
            this.GbModos = new System.Windows.Forms.GroupBox();
            this.LvDatos1 = new System.Windows.Forms.ListView();
            this.CHFecha1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHTemp1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHHumedad1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHHumedadSuelo1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpPuertos = new System.IO.Ports.SerialPort(this.components);
            this.txtValorMax = new System.Windows.Forms.TextBox();
            this.txtValorMin = new System.Windows.Forms.TextBox();
            this.lblValorMax = new System.Windows.Forms.Label();
            this.lblValorMin = new System.Windows.Forms.Label();
            this.LvDatos2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GbModos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "NODO 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1089, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 32);
            this.label10.TabIndex = 10;
            this.label10.Text = "NODO 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(547, 469);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 29);
            this.label11.TabIndex = 17;
            this.label11.Text = "Sistema de Riego";
            // 
            // txtBuffer
            // 
            this.txtBuffer.Location = new System.Drawing.Point(16, 705);
            this.txtBuffer.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuffer.Name = "txtBuffer";
            this.txtBuffer.Size = new System.Drawing.Size(121, 22);
            this.txtBuffer.TabIndex = 32;
            this.txtBuffer.TextChanged += new System.EventHandler(this.txtBuffer_TextChanged);
            // 
            // BtnEnviarDatosRA
            // 
            this.BtnEnviarDatosRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviarDatosRA.Location = new System.Drawing.Point(943, 535);
            this.BtnEnviarDatosRA.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEnviarDatosRA.Name = "BtnEnviarDatosRA";
            this.BtnEnviarDatosRA.Size = new System.Drawing.Size(103, 57);
            this.BtnEnviarDatosRA.TabIndex = 35;
            this.BtnEnviarDatosRA.Text = "Aceptar";
            this.BtnEnviarDatosRA.UseVisualStyleBackColor = true;
            this.BtnEnviarDatosRA.Visible = false;
            this.BtnEnviarDatosRA.Click += new System.EventHandler(this.BtnEnviarDatosRA_Click);
            // 
            // BtnRiegoManual
            // 
            this.BtnRiegoManual.BackColor = System.Drawing.Color.Green;
            this.BtnRiegoManual.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BtnRiegoManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRiegoManual.Location = new System.Drawing.Point(717, 535);
            this.BtnRiegoManual.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRiegoManual.Name = "BtnRiegoManual";
            this.BtnRiegoManual.Size = new System.Drawing.Size(328, 71);
            this.BtnRiegoManual.TabIndex = 37;
            this.BtnRiegoManual.Text = "Encender";
            this.BtnRiegoManual.UseVisualStyleBackColor = false;
            this.BtnRiegoManual.Click += new System.EventHandler(this.BtnRiegoManual_Click);
            // 
            // RdOptionAutomatico
            // 
            this.RdOptionAutomatico.AutoSize = true;
            this.RdOptionAutomatico.Location = new System.Drawing.Point(19, 31);
            this.RdOptionAutomatico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RdOptionAutomatico.Name = "RdOptionAutomatico";
            this.RdOptionAutomatico.Size = new System.Drawing.Size(160, 24);
            this.RdOptionAutomatico.TabIndex = 38;
            this.RdOptionAutomatico.Text = "Modo Automatico";
            this.RdOptionAutomatico.UseVisualStyleBackColor = true;
            this.RdOptionAutomatico.CheckedChanged += new System.EventHandler(this.RdOptionAutomatico_CheckedChanged);
            // 
            // RdOptionManual
            // 
            this.RdOptionManual.AutoSize = true;
            this.RdOptionManual.Checked = true;
            this.RdOptionManual.Location = new System.Drawing.Point(19, 58);
            this.RdOptionManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RdOptionManual.Name = "RdOptionManual";
            this.RdOptionManual.Size = new System.Drawing.Size(130, 24);
            this.RdOptionManual.TabIndex = 39;
            this.RdOptionManual.TabStop = true;
            this.RdOptionManual.Text = "Modo Manual";
            this.RdOptionManual.UseVisualStyleBackColor = true;
            this.RdOptionManual.CheckedChanged += new System.EventHandler(this.RdModoManual_CheckedChanged);
            // 
            // GbModos
            // 
            this.GbModos.Controls.Add(this.RdOptionAutomatico);
            this.GbModos.Controls.Add(this.RdOptionManual);
            this.GbModos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbModos.Location = new System.Drawing.Point(496, 512);
            this.GbModos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbModos.Name = "GbModos";
            this.GbModos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbModos.Size = new System.Drawing.Size(200, 100);
            this.GbModos.TabIndex = 40;
            this.GbModos.TabStop = false;
            this.GbModos.Text = "Modos de riego";
            // 
            // LvDatos1
            // 
            this.LvDatos1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHFecha1,
            this.CHTemp1,
            this.CHHumedad1,
            this.CHHumedadSuelo1});
            this.LvDatos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvDatos1.GridLines = true;
            this.LvDatos1.HideSelection = false;
            this.LvDatos1.Location = new System.Drawing.Point(36, 103);
            this.LvDatos1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LvDatos1.Name = "LvDatos1";
            this.LvDatos1.Size = new System.Drawing.Size(695, 301);
            this.LvDatos1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.LvDatos1.TabIndex = 41;
            this.LvDatos1.UseCompatibleStateImageBehavior = false;
            this.LvDatos1.View = System.Windows.Forms.View.Details;
            // 
            // CHFecha1
            // 
            this.CHFecha1.Text = "Fecha";
            this.CHFecha1.Width = 188;
            // 
            // CHTemp1
            // 
            this.CHTemp1.Text = "Temperatura";
            this.CHTemp1.Width = 102;
            // 
            // CHHumedad1
            // 
            this.CHHumedad1.Text = "Humedad";
            this.CHHumedad1.Width = 89;
            // 
            // CHHumedadSuelo1
            // 
            this.CHHumedadSuelo1.Text = "Humedad del suelo";
            this.CHHumedadSuelo1.Width = 232;
            // 
            // txtValorMax
            // 
            this.txtValorMax.Location = new System.Drawing.Point(835, 535);
            this.txtValorMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorMax.Name = "txtValorMax";
            this.txtValorMax.Size = new System.Drawing.Size(100, 22);
            this.txtValorMax.TabIndex = 46;
            this.txtValorMax.Visible = false;
            // 
            // txtValorMin
            // 
            this.txtValorMin.Location = new System.Drawing.Point(835, 569);
            this.txtValorMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorMin.Name = "txtValorMin";
            this.txtValorMin.Size = new System.Drawing.Size(100, 22);
            this.txtValorMin.TabIndex = 49;
            this.txtValorMin.Visible = false;
            // 
            // lblValorMax
            // 
            this.lblValorMax.AutoSize = true;
            this.lblValorMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMax.Location = new System.Drawing.Point(713, 535);
            this.lblValorMax.Name = "lblValorMax";
            this.lblValorMax.Size = new System.Drawing.Size(116, 20);
            this.lblValorMax.TabIndex = 50;
            this.lblValorMax.Text = "Valor Maximo:";
            this.lblValorMax.Visible = false;
            // 
            // lblValorMin
            // 
            this.lblValorMin.AutoSize = true;
            this.lblValorMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMin.Location = new System.Drawing.Point(713, 569);
            this.lblValorMin.Name = "lblValorMin";
            this.lblValorMin.Size = new System.Drawing.Size(112, 20);
            this.lblValorMin.TabIndex = 51;
            this.lblValorMin.Text = "Valor Minimo:";
            this.lblValorMin.Visible = false;
            // 
            // LvDatos2
            // 
            this.LvDatos2.BackgroundImageTiled = true;
            this.LvDatos2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LvDatos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvDatos2.GridLines = true;
            this.LvDatos2.HideSelection = false;
            this.LvDatos2.Location = new System.Drawing.Point(765, 103);
            this.LvDatos2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LvDatos2.Name = "LvDatos2";
            this.LvDatos2.Size = new System.Drawing.Size(695, 301);
            this.LvDatos2.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.LvDatos2.TabIndex = 52;
            this.LvDatos2.UseCompatibleStateImageBehavior = false;
            this.LvDatos2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 188;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Temperatura";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Humedad";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Humedad del suelo";
            this.columnHeader4.Width = 232;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1501, 655);
            this.Controls.Add(this.LvDatos2);
            this.Controls.Add(this.lblValorMin);
            this.Controls.Add(this.lblValorMax);
            this.Controls.Add(this.txtValorMin);
            this.Controls.Add(this.txtValorMax);
            this.Controls.Add(this.LvDatos1);
            this.Controls.Add(this.GbModos);
            this.Controls.Add(this.BtnRiegoManual);
            this.Controls.Add(this.BtnEnviarDatosRA);
            this.Controls.Add(this.txtBuffer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema prototipo para monitorizar/automatizar cultivos en invernaderos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbModos.ResumeLayout(false);
            this.GbModos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBuffer;
        private System.Windows.Forms.Button BtnEnviarDatosRA;
        private System.Windows.Forms.Button BtnRiegoManual;
        private System.Windows.Forms.RadioButton RdOptionAutomatico;
        private System.Windows.Forms.RadioButton RdOptionManual;
        private System.Windows.Forms.GroupBox GbModos;
        private System.Windows.Forms.ListView LvDatos1;
        private System.Windows.Forms.ColumnHeader CHTemp1;
        private System.Windows.Forms.ColumnHeader CHHumedad1;
        private System.Windows.Forms.ColumnHeader CHHumedadSuelo1;
        private System.IO.Ports.SerialPort SpPuertos;
        private System.Windows.Forms.TextBox txtValorMax;
        private System.Windows.Forms.TextBox txtValorMin;
        private System.Windows.Forms.Label lblValorMax;
        private System.Windows.Forms.Label lblValorMin;
        private System.Windows.Forms.ColumnHeader CHFecha1;
        private System.Windows.Forms.ListView LvDatos2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

