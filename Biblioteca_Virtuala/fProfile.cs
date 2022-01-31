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
    public partial class fProfile : Form
    {
        private User userObject;
        public fProfile(User userObject)
        {
            InitializeComponent();

            this.userObject = userObject;
        }

        private void fProfile_Load(object sender, EventArgs e)
        {
            string[] info = userObject.ProfileInfo();

            this.Text = "Profilul lui " + info[0];

            lUsername.Text = "Nume de utilizator: " + info[0];
            lName.Text = "Nume: " + info[1];
            lJoined.Text = "Inregistrat la: " + info[2];
            lEmail.Text = "Email: " + info[3];
            lExtra.Text = "Grad: " + info[4];
        }
    }
}
