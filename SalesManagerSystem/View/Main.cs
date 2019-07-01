using Sales_Manager_System;
using SalesManagerSystem.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagerSystem.View
{
    public partial class Main : Form
    {
        private readonly Login formLogin = null;
        private RegisterUser registerUser = null;
        private RegisterUnit registerUnit = null;

        public Main()
        {
            InitializeComponent();
        }

        public Main(Login form)
        {
            InitializeComponent();
            this.formLogin = form;
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(Messages.MESSAGE_EXIT_SYSTEM, Messages.MESSAGE_WARNING, MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                this.formLogin.EnableScreenLogin();
                this.Dispose();
            }
        }

        private void imnUser_Click(object sender, EventArgs e)
        {
            this.registerUser = new RegisterUser();
            this.registerUser.StartPosition = FormStartPosition.CenterScreen;
            this.registerUser.ShowDialog();
        }

        private void imnUnit_Click(object sender, EventArgs e)
        {
            this.registerUnit = new RegisterUnit();
            this.registerUnit.StartPosition = FormStartPosition.CenterScreen;
            this.registerUnit.ShowDialog();
        }
    }
}
