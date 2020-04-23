using MongoDB.Driver;
using MongoDB.Bson;
using System.Windows.Forms;
using System;
using System.Linq.Expressions;

namespace Controle_de_Estoque
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameApp = new System.Windows.Forms.Label();
            this.myName = new System.Windows.Forms.Label();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.registerMessage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.registerPasswd1 = new System.Windows.Forms.TextBox();
            this.registerPasswd = new System.Windows.Forms.TextBox();
            this.buttonRegisterPanel = new System.Windows.Forms.Button();
            this.buttonBackLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.registerLogin = new System.Windows.Forms.TextBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.loginMessage = new System.Windows.Forms.Label();
            this.panelLabel = new System.Windows.Forms.Label();
            this.loginPasswd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.loginLogin = new System.Windows.Forms.TextBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.panelLoginGeral = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.panelLoginGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 93);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // nameApp
            // 
            this.nameApp.AutoSize = true;
            this.nameApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.nameApp.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameApp.ForeColor = System.Drawing.Color.White;
            this.nameApp.Location = new System.Drawing.Point(12, 23);
            this.nameApp.Name = "nameApp";
            this.nameApp.Size = new System.Drawing.Size(339, 39);
            this.nameApp.TabIndex = 3;
            this.nameApp.Text = "Controle de Estoque";
            // 
            // myName
            // 
            this.myName.AutoSize = true;
            this.myName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.myName.ForeColor = System.Drawing.Color.White;
            this.myName.Location = new System.Drawing.Point(247, 63);
            this.myName.Name = "myName";
            this.myName.Size = new System.Drawing.Size(93, 13);
            this.myName.TabIndex = 2;
            this.myName.Text = "by: Thiago Comelli";
            // 
            // panelCadastro
            // 
            this.panelCadastro.Controls.Add(this.registerMessage);
            this.panelCadastro.Controls.Add(this.label8);
            this.panelCadastro.Controls.Add(this.registerPasswd1);
            this.panelCadastro.Controls.Add(this.registerPasswd);
            this.panelCadastro.Controls.Add(this.buttonRegisterPanel);
            this.panelCadastro.Controls.Add(this.buttonBackLogin);
            this.panelCadastro.Controls.Add(this.label5);
            this.panelCadastro.Controls.Add(this.registerLogin);
            this.panelCadastro.Controls.Add(this.pictureBox11);
            this.panelCadastro.Controls.Add(this.pictureBox6);
            this.panelCadastro.Controls.Add(this.pictureBox7);
            this.panelCadastro.Controls.Add(this.label7);
            this.panelCadastro.Controls.Add(this.label6);
            this.panelCadastro.Controls.Add(this.pictureBox10);
            this.panelCadastro.Controls.Add(this.pictureBox8);
            this.panelCadastro.Controls.Add(this.pictureBox9);
            this.panelCadastro.Location = new System.Drawing.Point(12, 99);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(339, 333);
            this.panelCadastro.TabIndex = 1;
            // 
            // registerMessage
            // 
            this.registerMessage.AutoSize = true;
            this.registerMessage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.registerMessage.Location = new System.Drawing.Point(48, 251);
            this.registerMessage.Name = "registerMessage";
            this.registerMessage.Size = new System.Drawing.Size(0, 18);
            this.registerMessage.TabIndex = 0;
            this.registerMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(100, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tela de Cadastro";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerPasswd1
            // 
            this.registerPasswd1.AcceptsTab = true;
            this.registerPasswd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.registerPasswd1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerPasswd1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPasswd1.ForeColor = System.Drawing.Color.White;
            this.registerPasswd1.HideSelection = false;
            this.registerPasswd1.Location = new System.Drawing.Point(93, 140);
            this.registerPasswd1.Name = "registerPasswd1";
            this.registerPasswd1.Size = new System.Drawing.Size(226, 14);
            this.registerPasswd1.TabIndex = 2;
            this.registerPasswd1.UseSystemPasswordChar = true;
            // 
            // registerPasswd
            // 
            this.registerPasswd.AcceptsTab = true;
            this.registerPasswd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.registerPasswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerPasswd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPasswd.ForeColor = System.Drawing.Color.White;
            this.registerPasswd.HideSelection = false;
            this.registerPasswd.Location = new System.Drawing.Point(93, 103);
            this.registerPasswd.Name = "registerPasswd";
            this.registerPasswd.Size = new System.Drawing.Size(226, 14);
            this.registerPasswd.TabIndex = 1;
            this.registerPasswd.UseSystemPasswordChar = true;
            // 
            // buttonRegisterPanel
            // 
            this.buttonRegisterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonRegisterPanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonRegisterPanel.FlatAppearance.BorderSize = 3;
            this.buttonRegisterPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonRegisterPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterPanel.ForeColor = System.Drawing.Color.White;
            this.buttonRegisterPanel.Location = new System.Drawing.Point(216, 191);
            this.buttonRegisterPanel.Name = "buttonRegisterPanel";
            this.buttonRegisterPanel.Size = new System.Drawing.Size(113, 29);
            this.buttonRegisterPanel.TabIndex = 3;
            this.buttonRegisterPanel.Text = "Cadastrar";
            this.buttonRegisterPanel.UseVisualStyleBackColor = false;
            this.buttonRegisterPanel.Click += new System.EventHandler(this.buttonRegisterPanel_Click);
            // 
            // buttonBackLogin
            // 
            this.buttonBackLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonBackLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonBackLogin.FlatAppearance.BorderSize = 3;
            this.buttonBackLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonBackLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackLogin.ForeColor = System.Drawing.Color.White;
            this.buttonBackLogin.Location = new System.Drawing.Point(216, 301);
            this.buttonBackLogin.Name = "buttonBackLogin";
            this.buttonBackLogin.Size = new System.Drawing.Size(113, 29);
            this.buttonBackLogin.TabIndex = 7;
            this.buttonBackLogin.Text = "Voltar";
            this.buttonBackLogin.UseVisualStyleBackColor = false;
            this.buttonBackLogin.Click += new System.EventHandler(this.buttonBackLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Login:";
            // 
            // registerLogin
            // 
            this.registerLogin.AcceptsTab = true;
            this.registerLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.registerLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLogin.ForeColor = System.Drawing.Color.White;
            this.registerLogin.HideSelection = false;
            this.registerLogin.Location = new System.Drawing.Point(93, 67);
            this.registerLogin.Name = "registerLogin";
            this.registerLogin.Size = new System.Drawing.Size(226, 14);
            this.registerLogin.TabIndex = 0;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox11.Location = new System.Drawing.Point(84, 132);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(245, 31);
            this.pictureBox11.TabIndex = 9;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox6.Location = new System.Drawing.Point(84, 95);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(245, 31);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox7.Location = new System.Drawing.Point(84, 58);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(245, 31);
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Senha:";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox10.Location = new System.Drawing.Point(15, 132);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(63, 31);
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox8.Location = new System.Drawing.Point(15, 58);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(63, 31);
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox9.Location = new System.Drawing.Point(15, 95);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(63, 31);
            this.pictureBox9.TabIndex = 16;
            this.pictureBox9.TabStop = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.loginMessage);
            this.panelLogin.Controls.Add(this.panelLabel);
            this.panelLogin.Controls.Add(this.loginPasswd);
            this.panelLogin.Controls.Add(this.label11);
            this.panelLogin.Controls.Add(this.buttonRegister);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.loginLogin);
            this.panelLogin.Controls.Add(this.pictureBox13);
            this.panelLogin.Controls.Add(this.pictureBox14);
            this.panelLogin.Controls.Add(this.label13);
            this.panelLogin.Controls.Add(this.pictureBox16);
            this.panelLogin.Controls.Add(this.pictureBox17);
            this.panelLogin.Location = new System.Drawing.Point(12, 99);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(339, 333);
            this.panelLogin.TabIndex = 0;
            // 
            // loginMessage
            // 
            this.loginMessage.AutoSize = true;
            this.loginMessage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginMessage.Location = new System.Drawing.Point(133, 301);
            this.loginMessage.Name = "loginMessage";
            this.loginMessage.Size = new System.Drawing.Size(0, 18);
            this.loginMessage.TabIndex = 0;
            this.loginMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLabel
            // 
            this.panelLabel.AutoSize = true;
            this.panelLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLabel.ForeColor = System.Drawing.Color.White;
            this.panelLabel.Location = new System.Drawing.Point(117, 21);
            this.panelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(119, 19);
            this.panelLabel.TabIndex = 1;
            this.panelLabel.Text = "Tela de Login";
            this.panelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginPasswd
            // 
            this.loginPasswd.AcceptsTab = true;
            this.loginPasswd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.loginPasswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPasswd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswd.ForeColor = System.Drawing.Color.White;
            this.loginPasswd.HideSelection = false;
            this.loginPasswd.Location = new System.Drawing.Point(93, 103);
            this.loginPasswd.Name = "loginPasswd";
            this.loginPasswd.Size = new System.Drawing.Size(226, 14);
            this.loginPasswd.TabIndex = 1;
            this.loginPasswd.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(27, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Login:";
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonRegister.FlatAppearance.BorderSize = 3;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(216, 191);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(113, 29);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Cadastrar";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonLogin.FlatAppearance.BorderSize = 3;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(84, 191);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(113, 29);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Entrar";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // loginLogin
            // 
            this.loginLogin.AcceptsTab = true;
            this.loginLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.loginLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLogin.ForeColor = System.Drawing.Color.White;
            this.loginLogin.HideSelection = false;
            this.loginLogin.Location = new System.Drawing.Point(93, 67);
            this.loginLogin.Name = "loginLogin";
            this.loginLogin.Size = new System.Drawing.Size(226, 14);
            this.loginLogin.TabIndex = 0;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox13.Location = new System.Drawing.Point(84, 95);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(245, 31);
            this.pictureBox13.TabIndex = 4;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox14.Location = new System.Drawing.Point(84, 58);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(245, 31);
            this.pictureBox14.TabIndex = 5;
            this.pictureBox14.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(24, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Senha:";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox16.Location = new System.Drawing.Point(15, 58);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(63, 31);
            this.pictureBox16.TabIndex = 7;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox17.Location = new System.Drawing.Point(15, 95);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(63, 31);
            this.pictureBox17.TabIndex = 8;
            this.pictureBox17.TabStop = false;
            // 
            // panelLoginGeral
            // 
            this.panelLoginGeral.Controls.Add(this.panelLogin);
            this.panelLoginGeral.Controls.Add(this.myName);
            this.panelLoginGeral.Controls.Add(this.panelCadastro);
            this.panelLoginGeral.Controls.Add(this.nameApp);
            this.panelLoginGeral.Controls.Add(this.pictureBox1);
            this.panelLoginGeral.Location = new System.Drawing.Point(0, 0);
            this.panelLoginGeral.Name = "panelLoginGeral";
            this.panelLoginGeral.Size = new System.Drawing.Size(360, 450);
            this.panelLoginGeral.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(361, 444);
            this.Controls.Add(this.panelLoginGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Controle de Estoque - Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.panelLoginGeral.ResumeLayout(false);
            this.panelLoginGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        

        public class BD
        {
            public static void ConnectToMongoService()
            {
                const string connectionString = "mongodb+srv://thiago:1234@cluster0-jhejj.gcp.mongodb.net/test?retryWrites=true&w=majority";
                IMongoClient clients = new MongoClient(connectionString);
                IMongoDatabase databases = clients.GetDatabase("estoque");
                IMongoCollection<Entity> collections = databases.GetCollection<Entity>("estoque-dados");
                IMongoCollection<User> collectionsLogin = databases.GetCollection<User>("estoque-users");

                Global.client = clients;
                Global.database = databases;
                Global.collectionDados = collections;
                Global.collectionLogin = collectionsLogin;
            }

            public static bool registerBD(string login,string passwd)
            {
                try
                {
                    Global.collectionLogin.InsertOne(new User { _id = login, password = passwd, mode = "Normal"});
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public static bool loginBD(string login,string passwd)
            {
                try
                {
                    var results = Global.collectionLogin.Find(x => x._id == login && x.password == passwd).ToList();

                    if(results.Count == 1)
                    {
                        Global.user = login;
                        Global.mode = results[0].mode;
                        return true;
                    } else
                    {
                        return false;
                    }

                }
                catch
                {
                    return false;
                }
            }

        }

        

        #endregion
        private System.Windows.Forms.TextBox loginLogin;
        private System.Windows.Forms.TextBox loginPasswd;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameApp;
        private System.Windows.Forms.Label myName;
        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.TextBox registerLogin;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox registerPasswd;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TextBox registerPasswd1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRegisterPanel;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.Label panelLabel;
        private System.Windows.Forms.Button buttonBackLogin;
        private System.Windows.Forms.Label registerMessage;
        private System.Windows.Forms.Label loginMessage;
        private System.Windows.Forms.Panel panelLoginGeral;
    }

    public class Global
    {
        public static IMongoClient client;
        public static IMongoDatabase database;
        public static IMongoCollection<Entity> collectionDados;
        public static IMongoCollection<User> collectionLogin;
        public static string user = null;
        public static string mode = null;
    }

    public class Entity
    {
        public string _id { get; set; }
        public int quant { get; set; }
        public int preco { get; set; }
    }

    public class User
    {
        public string _id { get; set; }
        public string password { get; set; }
        public string mode { get; set; }
    }
}

