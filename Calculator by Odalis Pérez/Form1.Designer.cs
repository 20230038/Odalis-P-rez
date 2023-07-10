namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new System.Windows.Forms.TextBox();
            btnUno = new System.Windows.Forms.Button();
            btnDos = new System.Windows.Forms.Button();
            btnTres = new System.Windows.Forms.Button();
            btnSeis = new System.Windows.Forms.Button();
            btnCinco = new System.Windows.Forms.Button();
            btnCuatro = new System.Windows.Forms.Button();
            btnQuitar = new System.Windows.Forms.Button();
            btnBorrarTodo = new System.Windows.Forms.Button();
            btnBorrar = new System.Windows.Forms.Button();
            btnNueve = new System.Windows.Forms.Button();
            btnOcho = new System.Windows.Forms.Button();
            btnSiete = new System.Windows.Forms.Button();
            btnCuadrado = new System.Windows.Forms.Button();
            btnRaizCuadrada = new System.Windows.Forms.Button();
            btnMultiplicar = new System.Windows.Forms.Button();
            btnDividir = new System.Windows.Forms.Button();
            btnRestar = new System.Windows.Forms.Button();
            btnSumar = new System.Windows.Forms.Button();
            btnResultado = new System.Windows.Forms.Button();
            btnPunto = new System.Windows.Forms.Button();
            btnCero = new System.Windows.Forms.Button();
            btnSigno = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtResultado.Location = new System.Drawing.Point(13, 13);
            txtResultado.MaxLength = 21;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new System.Drawing.Size(316, 45);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            btnUno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUno.Location = new System.Drawing.Point(13, 249);
            btnUno.Name = "btnUno";
            btnUno.Size = new System.Drawing.Size(52, 45);
            btnUno.TabIndex = 1;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += agregarNumero;
            // 
            // btnDos
            // 
            btnDos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDos.Location = new System.Drawing.Point(70, 249);
            btnDos.Name = "btnDos";
            btnDos.Size = new System.Drawing.Size(52, 45);
            btnDos.TabIndex = 2;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += agregarNumero;
            // 
            // btnTres
            // 
            btnTres.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnTres.Location = new System.Drawing.Point(127, 249);
            btnTres.Name = "btnTres";
            btnTres.Size = new System.Drawing.Size(52, 45);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += agregarNumero;
            // 
            // btnSeis
            // 
            btnSeis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSeis.Location = new System.Drawing.Point(127, 190);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new System.Drawing.Size(52, 45);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += agregarNumero;
            // 
            // btnCinco
            // 
            btnCinco.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCinco.Location = new System.Drawing.Point(70, 190);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new System.Drawing.Size(52, 45);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += agregarNumero;
            // 
            // btnCuatro
            // 
            btnCuatro.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCuatro.Location = new System.Drawing.Point(13, 190);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new System.Drawing.Size(52, 45);
            btnCuatro.TabIndex = 4;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            btnCuatro.Click += agregarNumero;
            // 
            // btnQuitar
            // 
            btnQuitar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnQuitar.Location = new System.Drawing.Point(128, 71);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new System.Drawing.Size(52, 45);
            btnQuitar.TabIndex = 12;
            btnQuitar.Text = "<-";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBorrarTodo.Location = new System.Drawing.Point(70, 71);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new System.Drawing.Size(52, 45);
            btnBorrarTodo.TabIndex = 11;
            btnBorrarTodo.Text = "C";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBorrar.Location = new System.Drawing.Point(13, 71);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new System.Drawing.Size(52, 45);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "CE";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnNueve
            // 
            btnNueve.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnNueve.Location = new System.Drawing.Point(127, 131);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new System.Drawing.Size(52, 45);
            btnNueve.TabIndex = 9;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = true;
            btnNueve.Click += agregarNumero;
            // 
            // btnOcho
            // 
            btnOcho.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOcho.Location = new System.Drawing.Point(70, 131);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new System.Drawing.Size(52, 45);
            btnOcho.TabIndex = 8;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = true;
            btnOcho.Click += agregarNumero;
            // 
            // btnSiete
            // 
            btnSiete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSiete.Location = new System.Drawing.Point(13, 131);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new System.Drawing.Size(52, 45);
            btnSiete.TabIndex = 7;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            btnSiete.Click += agregarNumero;
            // 
            // btnCuadrado
            // 
            btnCuadrado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCuadrado.Location = new System.Drawing.Point(277, 71);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new System.Drawing.Size(52, 45);
            btnCuadrado.TabIndex = 14;
            btnCuadrado.Tag = "²";
            btnCuadrado.Text = "x²";
            btnCuadrado.UseVisualStyleBackColor = true;
            btnCuadrado.Click += clickOperador;
            // 
            // btnRaizCuadrada
            // 
            btnRaizCuadrada.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRaizCuadrada.Location = new System.Drawing.Point(219, 71);
            btnRaizCuadrada.Name = "btnRaizCuadrada";
            btnRaizCuadrada.Size = new System.Drawing.Size(52, 45);
            btnRaizCuadrada.TabIndex = 13;
            btnRaizCuadrada.Tag = "√";
            btnRaizCuadrada.Text = "√";
            btnRaizCuadrada.UseVisualStyleBackColor = true;
            btnRaizCuadrada.Click += clickOperador;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMultiplicar.Location = new System.Drawing.Point(277, 131);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new System.Drawing.Size(52, 45);
            btnMultiplicar.TabIndex = 16;
            btnMultiplicar.Tag = "X";
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += clickOperador;
            // 
            // btnDividir
            // 
            btnDividir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDividir.Location = new System.Drawing.Point(219, 131);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new System.Drawing.Size(52, 45);
            btnDividir.TabIndex = 15;
            btnDividir.Tag = "∕";
            btnDividir.Text = "∕";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += clickOperador;
            // 
            // btnRestar
            // 
            btnRestar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRestar.Location = new System.Drawing.Point(277, 190);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new System.Drawing.Size(52, 45);
            btnRestar.TabIndex = 18;
            btnRestar.Tag = "−";
            btnRestar.Text = "−";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += clickOperador;
            // 
            // btnSumar
            // 
            btnSumar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSumar.Location = new System.Drawing.Point(219, 190);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new System.Drawing.Size(52, 45);
            btnSumar.TabIndex = 17;
            btnSumar.Tag = "+";
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += clickOperador;
            // 
            // btnResultado
            // 
            btnResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnResultado.Location = new System.Drawing.Point(219, 249);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new System.Drawing.Size(110, 45);
            btnResultado.TabIndex = 19;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnPunto
            // 
            btnPunto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPunto.Location = new System.Drawing.Point(127, 310);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new System.Drawing.Size(52, 45);
            btnPunto.TabIndex = 22;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnCero
            // 
            btnCero.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCero.Location = new System.Drawing.Point(70, 310);
            btnCero.Name = "btnCero";
            btnCero.Size = new System.Drawing.Size(52, 45);
            btnCero.TabIndex = 21;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += agregarNumero;
            // 
            // btnSigno
            // 
            btnSigno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSigno.Location = new System.Drawing.Point(13, 310);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new System.Drawing.Size(52, 45);
            btnSigno.TabIndex = 20;
            btnSigno.Text = "+/-";
            btnSigno.UseVisualStyleBackColor = true;
            btnSigno.Click += btnSigno_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(341, 365);
            Controls.Add(btnPunto);
            Controls.Add(btnCero);
            Controls.Add(btnSigno);
            Controls.Add(btnResultado);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDividir);
            Controls.Add(btnCuadrado);
            Controls.Add(btnRaizCuadrada);
            Controls.Add(btnQuitar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnBorrar);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(txtResultado);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Calculator by Odalis Pérez";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnRaizCuadrada;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnSigno;
    }
}
