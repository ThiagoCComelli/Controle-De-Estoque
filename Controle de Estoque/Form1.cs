using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            BD.ConnectToMongoService();

            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

        private void buttonBackLogin_Click(object sender, EventArgs e)
        {
            loginLogin.Text = "";
            loginPasswd.Text = "";
            loginMessage.Text = "";
            panelLogin.BringToFront();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            registerLogin.Text = "";
            registerPasswd.Text = "";
            registerPasswd1.Text = "";
            registerMessage.Text = "";
            panelCadastro.BringToFront();
        }

        private void buttonRegisterPanel_Click(object sender, EventArgs e)
        {
            if (registerLogin.Text != "" && registerPasswd.Text != "" && (registerPasswd.Text == registerPasswd1.Text))
            {
                bool register = BD.registerBD(registerLogin.Text,registerPasswd.Text);
                if (register)
                {
                    registerMessage.ForeColor = System.Drawing.Color.Lime;
                    registerMessage.Text = "Cadastro efetuado com sucesso!";
                } else
                {
                    registerMessage.ForeColor = System.Drawing.Color.Red;
                    registerMessage.Text = "Falha ao criar, usuario ja cadastrado!";
                }
                
            } else
            {
                registerMessage.ForeColor = System.Drawing.Color.Red;
                registerMessage.Text = "Falha ao criar, verifique seus dados!";
            }

            registerMessage.Left = (ClientSize.Width / 2) - (registerMessage.Width / 2);

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (loginLogin.Text != "" && loginPasswd.Text != "")
            {
                bool login = BD.loginBD(loginLogin.Text, loginPasswd.Text);

                if (login)
                {
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                    this.Close();
                }
                else
                {
                    loginMessage.ForeColor = System.Drawing.Color.Red;
                    loginMessage.Text = "Falha ao acessar, senha ou usuario errado!";
                }

            }
            else
            {
                loginMessage.ForeColor = System.Drawing.Color.Red;
                loginMessage.Text = "Falha ao acessar, verifique seus dados!";
            }

            loginMessage.Left = (ClientSize.Width / 2) - (loginMessage.Width / 2);
        }
    }
}
