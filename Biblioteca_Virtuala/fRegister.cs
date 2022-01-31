using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteca_Virtuala
{
    public partial class fRegister : Form
    {
        private Form loginForm;
        private DB database;

        public fRegister(Form loginForm, DB database)
        {
            InitializeComponent();

            this.loginForm = loginForm;
            this.database = database;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(ePassword.Text == string.Empty || ePasswordConfirm.Text == string.Empty || eUsername.Text == string.Empty || eFullname.Text == string.Empty || eEmail.Text == string.Empty || eAge.Text == string.Empty)
            {
                MessageBox.Show("Toate campurile sunt obligatorii!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(ePassword.Text != ePasswordConfirm.Text)
            {
                MessageBox.Show("Parolele difera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ePassword.Text.Length < 4 || ePassword.Text.Length > 16)
            {
                MessageBox.Show("Parola poate contine intre 4 si 16 caractere.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!int.TryParse(eAge.Text, out int userage))
            {
                MessageBox.Show("Varsta poate fi doar o valoare numerica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int response = database.RegisterUser(eUsername.Text, ePassword.Text, eEmail.Text, eFullname.Text, userage);

            if(response == -1) // -1 = exista deja un cont cu acel username
            {
                MessageBox.Show("Exista deja un utilizator cu acel nume de utilizator, inecarca altul!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(response == 0) // 0 = ceva a esuat in blocul try-catch
            {
                MessageBox.Show("A aparut o eroare in timpul crearii contului! Incearca mai tarziu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Contul tau a fost creat cu succes! Logheaza-te cu datele introduse.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loginForm.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm.Show();
            this.Hide();
        }

        private void fRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
