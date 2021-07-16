
namespace JuegoMateTest
{
    partial class frmMate
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
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTiempoRestante = new System.Windows.Forms.Label();
            this.lblIzquierdaSuma = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblDerechaSuma = new System.Windows.Forms.Label();
            this.lblSumaIgual = new System.Windows.Forms.Label();
            this.nudSuma = new System.Windows.Forms.NumericUpDown();
            this.nudResta = new System.Windows.Forms.NumericUpDown();
            this.lblRestaIgual = new System.Windows.Forms.Label();
            this.lblDerechaResta = new System.Windows.Forms.Label();
            this.lblResta = new System.Windows.Forms.Label();
            this.lblIziquierdaResta = new System.Windows.Forms.Label();
            this.nudMulti = new System.Windows.Forms.NumericUpDown();
            this.lblMultiIgual = new System.Windows.Forms.Label();
            this.lblDerechaMulti = new System.Windows.Forms.Label();
            this.lblMulti = new System.Windows.Forms.Label();
            this.lblIzquierdaMulti = new System.Windows.Forms.Label();
            this.nudDiv = new System.Windows.Forms.NumericUpDown();
            this.lblDivIgual = new System.Windows.Forms.Label();
            this.lblDerechaDiv = new System.Windows.Forms.Label();
            this.lblDiv = new System.Windows.Forms.Label();
            this.lblIzquierdaDiv = new System.Windows.Forms.Label();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.timerTiempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudSuma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMulti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTiempo
            // 
            this.lblTiempo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTiempo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(617, 33);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(198, 38);
            this.lblTiempo.TabIndex = 0;
            // 
            // lblTiempoRestante
            // 
            this.lblTiempoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoRestante.Location = new System.Drawing.Point(396, 33);
            this.lblTiempoRestante.Name = "lblTiempoRestante";
            this.lblTiempoRestante.Size = new System.Drawing.Size(215, 38);
            this.lblTiempoRestante.TabIndex = 1;
            this.lblTiempoRestante.Text = "Tiempo Restante";
            // 
            // lblIzquierdaSuma
            // 
            this.lblIzquierdaSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzquierdaSuma.Location = new System.Drawing.Point(87, 188);
            this.lblIzquierdaSuma.Name = "lblIzquierdaSuma";
            this.lblIzquierdaSuma.Size = new System.Drawing.Size(102, 38);
            this.lblIzquierdaSuma.TabIndex = 2;
            this.lblIzquierdaSuma.Text = "?";
            this.lblIzquierdaSuma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSuma
            // 
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(231, 188);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(102, 38);
            this.lblSuma.TabIndex = 3;
            this.lblSuma.Text = "+";
            this.lblSuma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDerechaSuma
            // 
            this.lblDerechaSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerechaSuma.Location = new System.Drawing.Point(375, 188);
            this.lblDerechaSuma.Name = "lblDerechaSuma";
            this.lblDerechaSuma.Size = new System.Drawing.Size(102, 38);
            this.lblDerechaSuma.TabIndex = 4;
            this.lblDerechaSuma.Text = "?";
            this.lblDerechaSuma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSumaIgual
            // 
            this.lblSumaIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaIgual.Location = new System.Drawing.Point(519, 188);
            this.lblSumaIgual.Name = "lblSumaIgual";
            this.lblSumaIgual.Size = new System.Drawing.Size(102, 38);
            this.lblSumaIgual.TabIndex = 5;
            this.lblSumaIgual.Text = "=";
            this.lblSumaIgual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
       
            // 
            // nudSuma
            // 
            this.nudSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSuma.Location = new System.Drawing.Point(663, 188);
            this.nudSuma.Name = "nudSuma";
            this.nudSuma.Size = new System.Drawing.Size(152, 34);
            this.nudSuma.TabIndex = 6;
            this.nudSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudResta
            // 
            this.nudResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudResta.Location = new System.Drawing.Point(663, 263);
            this.nudResta.Name = "nudResta";
            this.nudResta.Size = new System.Drawing.Size(152, 34);
            this.nudResta.TabIndex = 11;
            this.nudResta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRestaIgual
            // 
            this.lblRestaIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaIgual.Location = new System.Drawing.Point(519, 263);
            this.lblRestaIgual.Name = "lblRestaIgual";
            this.lblRestaIgual.Size = new System.Drawing.Size(102, 38);
            this.lblRestaIgual.TabIndex = 10;
            this.lblRestaIgual.Text = "=";
            this.lblRestaIgual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDerechaResta
            // 
            this.lblDerechaResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerechaResta.Location = new System.Drawing.Point(375, 263);
            this.lblDerechaResta.Name = "lblDerechaResta";
            this.lblDerechaResta.Size = new System.Drawing.Size(102, 38);
            this.lblDerechaResta.TabIndex = 9;
            this.lblDerechaResta.Text = "?";
            this.lblDerechaResta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblResta
            // 
            this.lblResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResta.Location = new System.Drawing.Point(231, 263);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(102, 38);
            this.lblResta.TabIndex = 8;
            this.lblResta.Text = "-";
            this.lblResta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIziquierdaResta
            // 
            this.lblIziquierdaResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIziquierdaResta.Location = new System.Drawing.Point(87, 263);
            this.lblIziquierdaResta.Name = "lblIziquierdaResta";
            this.lblIziquierdaResta.Size = new System.Drawing.Size(102, 38);
            this.lblIziquierdaResta.TabIndex = 7;
            this.lblIziquierdaResta.Text = "?";
            this.lblIziquierdaResta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudMulti
            // 
            this.nudMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMulti.Location = new System.Drawing.Point(663, 338);
            this.nudMulti.Name = "nudMulti";
            this.nudMulti.Size = new System.Drawing.Size(152, 34);
            this.nudMulti.TabIndex = 16;
            this.nudMulti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMultiIgual
            // 
            this.lblMultiIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiIgual.Location = new System.Drawing.Point(519, 338);
            this.lblMultiIgual.Name = "lblMultiIgual";
            this.lblMultiIgual.Size = new System.Drawing.Size(102, 38);
            this.lblMultiIgual.TabIndex = 15;
            this.lblMultiIgual.Text = "=";
            this.lblMultiIgual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDerechaMulti
            // 
            this.lblDerechaMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerechaMulti.Location = new System.Drawing.Point(375, 338);
            this.lblDerechaMulti.Name = "lblDerechaMulti";
            this.lblDerechaMulti.Size = new System.Drawing.Size(102, 38);
            this.lblDerechaMulti.TabIndex = 14;
            this.lblDerechaMulti.Text = "?";
            this.lblDerechaMulti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMulti
            // 
            this.lblMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMulti.Location = new System.Drawing.Point(231, 338);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(102, 38);
            this.lblMulti.TabIndex = 13;
            this.lblMulti.Text = "X";
            this.lblMulti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIzquierdaMulti
            // 
            this.lblIzquierdaMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzquierdaMulti.Location = new System.Drawing.Point(87, 338);
            this.lblIzquierdaMulti.Name = "lblIzquierdaMulti";
            this.lblIzquierdaMulti.Size = new System.Drawing.Size(102, 38);
            this.lblIzquierdaMulti.TabIndex = 12;
            this.lblIzquierdaMulti.Text = "?";
            this.lblIzquierdaMulti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudDiv
            // 
            this.nudDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiv.Location = new System.Drawing.Point(663, 413);
            this.nudDiv.Name = "nudDiv";
            this.nudDiv.Size = new System.Drawing.Size(152, 34);
            this.nudDiv.TabIndex = 21;
            this.nudDiv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDivIgual
            // 
            this.lblDivIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivIgual.Location = new System.Drawing.Point(519, 413);
            this.lblDivIgual.Name = "lblDivIgual";
            this.lblDivIgual.Size = new System.Drawing.Size(102, 38);
            this.lblDivIgual.TabIndex = 20;
            this.lblDivIgual.Text = "=";
            this.lblDivIgual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDerechaDiv
            // 
            this.lblDerechaDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerechaDiv.Location = new System.Drawing.Point(375, 413);
            this.lblDerechaDiv.Name = "lblDerechaDiv";
            this.lblDerechaDiv.Size = new System.Drawing.Size(102, 38);
            this.lblDerechaDiv.TabIndex = 19;
            this.lblDerechaDiv.Text = "?";
            this.lblDerechaDiv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDiv
            // 
            this.lblDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiv.Location = new System.Drawing.Point(231, 413);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(102, 38);
            this.lblDiv.TabIndex = 18;
            this.lblDiv.Text = "/";
            this.lblDiv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIzquierdaDiv
            // 
            this.lblIzquierdaDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzquierdaDiv.Location = new System.Drawing.Point(87, 413);
            this.lblIzquierdaDiv.Name = "lblIzquierdaDiv";
            this.lblIzquierdaDiv.Size = new System.Drawing.Size(102, 38);
            this.lblIzquierdaDiv.TabIndex = 17;
            this.lblIzquierdaDiv.Text = "?";
            this.lblIzquierdaDiv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpezar.Location = new System.Drawing.Point(40, 24);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(327, 76);
            this.btnEmpezar.TabIndex = 22;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // timerTiempo
            // 
            this.timerTiempo.Interval = 1000;
            this.timerTiempo.Tick += new System.EventHandler(this.timerTiempo_Tick);
            // 
            // frmMate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(920, 490);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.nudDiv);
            this.Controls.Add(this.lblDivIgual);
            this.Controls.Add(this.lblDerechaDiv);
            this.Controls.Add(this.lblDiv);
            this.Controls.Add(this.lblIzquierdaDiv);
            this.Controls.Add(this.nudMulti);
            this.Controls.Add(this.lblMultiIgual);
            this.Controls.Add(this.lblDerechaMulti);
            this.Controls.Add(this.lblMulti);
            this.Controls.Add(this.lblIzquierdaMulti);
            this.Controls.Add(this.nudResta);
            this.Controls.Add(this.lblRestaIgual);
            this.Controls.Add(this.lblDerechaResta);
            this.Controls.Add(this.lblResta);
            this.Controls.Add(this.lblIziquierdaResta);
            this.Controls.Add(this.nudSuma);
            this.Controls.Add(this.lblSumaIgual);
            this.Controls.Add(this.lblDerechaSuma);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblIzquierdaSuma);
            this.Controls.Add(this.lblTiempoRestante);
            this.Controls.Add(this.lblTiempo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMate";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MateTest";
            this.Load += new System.EventHandler(this.frmMate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSuma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMulti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTiempoRestante;
        private System.Windows.Forms.Label lblIzquierdaSuma;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblDerechaSuma;
        private System.Windows.Forms.Label lblSumaIgual;
        private System.Windows.Forms.NumericUpDown nudSuma;
        private System.Windows.Forms.NumericUpDown nudResta;
        private System.Windows.Forms.Label lblRestaIgual;
        private System.Windows.Forms.Label lblDerechaResta;
        private System.Windows.Forms.Label lblResta;
        private System.Windows.Forms.Label lblIziquierdaResta;
        private System.Windows.Forms.NumericUpDown nudMulti;
        private System.Windows.Forms.Label lblMultiIgual;
        private System.Windows.Forms.Label lblDerechaMulti;
        private System.Windows.Forms.Label lblMulti;
        private System.Windows.Forms.Label lblIzquierdaMulti;
        private System.Windows.Forms.NumericUpDown nudDiv;
        private System.Windows.Forms.Label lblDivIgual;
        private System.Windows.Forms.Label lblDerechaDiv;
        private System.Windows.Forms.Label lblDiv;
        private System.Windows.Forms.Label lblIzquierdaDiv;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Timer timerTiempo;
    }
}

