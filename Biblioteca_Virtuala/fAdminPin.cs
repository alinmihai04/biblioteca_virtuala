using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Virtuala
{
    public partial class fAdminPin : Form
    {
        private fLogin loginForm;
        private Administrator meObject;
        private DB database;

        private int tries = 2;

        public fAdminPin(fLogin loginForm, Administrator meObject, DB database)
        {
            InitializeComponent();

            this.loginForm = loginForm;
            this.meObject = meObject;
            this.database = database;

            if(meObject.CheckAdminPin("change"))
            {
                labelPin.Text = "Change PIN";
            }
            else
            {
                labelPin.Text = "PIN";
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(ePin.Text == string.Empty)
            {
                MessageBox.Show("Completeaza casuta!");
                return;
            }
            if(ePin.Text.Length < 4 || ePin.Text.Length > 6)
            {
                MessageBox.Show("PIN-ul poate fi format din minim 4 si maxim 6 caractere");
                return;
            }

            if (meObject.CheckAdminPin("change"))
            {
                database.SqlQuery = new MySql.Data.MySqlClient.MySqlCommand("update users set AdminPin='" + ePin.Text + "' where id='" + meObject.GetID + "'", database.Conn);
                database.SqlQuery.ExecuteNonQuery();

                meObject.ChangeAdminPin(ePin.Text);
            }

            if (!meObject.CheckAdminPin(ePin.Text))
            {
                if(tries == 0)
                {
                    loginForm.AdminPinResponse(false);
                    this.Close();
                }
                else
                {
                    tries--;
                    label1.Text = "PIN incorect, mai ai " + tries + " incercari!";
                    label1.Visible = true;

                    ePin.Clear();
                }
            }
            else
            {
                this.Close();
                loginForm.AdminPinResponse(true);
            }
        }
    }
}
