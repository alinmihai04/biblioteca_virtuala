using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Virtuala
{
    public partial class fLogin : Form
    {
        private fMain mainForm = null;
        private fAdminPin pinForm = null;
        private fRegister registerForm = null;

        private DB database = new DB();
        private User meObject = null;
        private Main mainObject = new Main();

        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            if(!database.Connect())
            {
                MessageBox.Show("Conexiunea la baza de date a esuat!");

                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ePassword.Text == string.Empty || eUsername.Text== string.Empty)
            {
                MessageBox.Show("Nu lasa campuri necompletate!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            meObject = database.LoginUser(eUsername.Text, ePassword.Text);

            if(meObject == null)
            {
                MessageBox.Show("Nu exista niciun cont cu acest username/parola!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mainObject.ConnectedUsers.Add(meObject);

            if (mainForm == null)
            {
                mainForm = new fMain(database, mainObject, meObject);
            }

            if(meObject is Administrator)
            {
                if(pinForm == null)
                {
                    pinForm = new fAdminPin(this, meObject as Administrator, database);
                }

                pinForm.ShowDialog();
            }
            else
            {
                mainForm.Show();
                this.Hide();
            }
        }

        public void AdminPinResponse(bool response)
        {
            if(response)
            {
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("PIN-ul de admin a fost introdus gresit de prea multe ori! Aplicatia se va inchide!", "Acces neautorizat", MessageBoxButtons.OK);
                this.Dispose();
            }
        }

        private void registerLinkLabel_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(registerForm == null)
            {
                registerForm = new fRegister(this, database);
            }
            registerForm.Show();
            this.Hide();
        }



    }
}
