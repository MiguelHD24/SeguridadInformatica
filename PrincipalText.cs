using EncryptDoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomWare
{
    //Miguel Angel Mendez Lopez
    public partial class PrincipalText : Form
    {
        private TextBox txtTexto = new TextBox();
        private Label lbltxtTexto = new();
        private Button btnEncriptar = new();
        private Button btnDesencriptar = new();
        private Button btnRegresar = new();
        public PrincipalText()
        {
            SuspendLayout();
            Text = "Principal";
            ClientSize = new Size(400, 300);
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;

            //Controles 
            lbltxtTexto.Name = "lblTexto";
            lbltxtTexto.Text = "Ingrese un Texto";
            lbltxtTexto.Location = new Point(10, 10);
            Controls.Add(lbltxtTexto);

            txtTexto.Location = new Point(10, 35);
            txtTexto.Size = new Size(350, 30);
            txtTexto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTexto.Name = "txtTexto";
            Controls.Add(txtTexto);

            btnEncriptar.Text = "Encriptar";
            btnEncriptar.Name = "btnEncriptar";
            btnEncriptar.Location = new Point(10, 65);
            btnEncriptar.Size = new Size(110, 40);
            btnEncriptar.Click += ClickEncriptar;
            Controls.Add(btnEncriptar);

            btnDesencriptar.Text = "Desencriptar";
            btnDesencriptar.Name = "btnDesencriptar";
            btnDesencriptar.Location = new Point(120, 65);
            btnDesencriptar.Size = new Size(110, 40);
            btnDesencriptar.Click += ClickDesencriptar;
            Controls.Add(btnDesencriptar);

            btnRegresar.Text = "Regresar";
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Location = new Point(290, 155);
            btnRegresar.Size = new Size(110, 40);
            btnRegresar.Click += ClickRegresar;
            Controls.Add(btnRegresar);



            ResumeLayout();
            PerformLayout();
        }

        private void ClickRegresar(object? sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
        private void ClickEncriptar(object? sender, EventArgs e)
        {

            txtTexto.Text = Encripty.Encrypt(txtTexto.Text);

        }

        private void ClickDesencriptar(object? sender, EventArgs e)
        {
            txtTexto.Text = Encripty.Decrypt(txtTexto.Text);

        }

        private void InitializeComponent()
        {

        }

    }
}
