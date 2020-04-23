using MongoDB.Driver;
using MongoDB.Bson;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Controle_de_Estoque
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameApp = new System.Windows.Forms.Label();
            this.myName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modeText = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.codeText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantText = new System.Windows.Forms.NumericUpDown();
            this.precoText = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.panelExcluir = new System.Windows.Forms.Panel();
            this.panelGeral = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precoText)).BeginInit();
            this.panelAdmin.SuspendLayout();
            this.panelCadastro.SuspendLayout();
            this.panelExcluir.SuspendLayout();
            this.panelGeral.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 56);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // nameApp
            // 
            this.nameApp.AutoSize = true;
            this.nameApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.nameApp.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameApp.ForeColor = System.Drawing.Color.White;
            this.nameApp.Location = new System.Drawing.Point(12, 9);
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
            this.myName.Location = new System.Drawing.Point(357, 30);
            this.myName.Name = "myName";
            this.myName.Size = new System.Drawing.Size(93, 13);
            this.myName.TabIndex = 2;
            this.myName.Text = "by: Thiago Comelli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(542, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User:";
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.usernameText.ForeColor = System.Drawing.Color.White;
            this.usernameText.Location = new System.Drawing.Point(580, 12);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(0, 13);
            this.usernameText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(542, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mode:";
            // 
            // modeText
            // 
            this.modeText.AutoSize = true;
            this.modeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.modeText.ForeColor = System.Drawing.Color.White;
            this.modeText.Location = new System.Drawing.Point(580, 30);
            this.modeText.Name = "modeText";
            this.modeText.Size = new System.Drawing.Size(0, 13);
            this.modeText.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 94);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(461, 242);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Produto";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantidade";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Preço";
            this.columnHeader3.Width = 208;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(78, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(5, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "Adicionar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // codeText
            // 
            this.codeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.codeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeText.ForeColor = System.Drawing.Color.White;
            this.codeText.Location = new System.Drawing.Point(0, 17);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(100, 20);
            this.codeText.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(114, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quantidade:";
            // 
            // QuantText
            // 
            this.QuantText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.QuantText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantText.ForeColor = System.Drawing.Color.White;
            this.QuantText.Location = new System.Drawing.Point(117, 17);
            this.QuantText.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.QuantText.Name = "QuantText";
            this.QuantText.Size = new System.Drawing.Size(100, 20);
            this.QuantText.TabIndex = 15;
            // 
            // precoText
            // 
            this.precoText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.precoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.precoText.ForeColor = System.Drawing.Color.White;
            this.precoText.Location = new System.Drawing.Point(117, 56);
            this.precoText.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.precoText.Name = "precoText";
            this.precoText.Size = new System.Drawing.Size(100, 20);
            this.precoText.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(114, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Preço:";
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.button3);
            this.panelAdmin.Controls.Add(this.button1);
            this.panelAdmin.Location = new System.Drawing.Point(229, 4);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(149, 52);
            this.panelAdmin.TabIndex = 16;
            // 
            // panelCadastro
            // 
            this.panelCadastro.Controls.Add(this.QuantText);
            this.panelCadastro.Controls.Add(this.codeText);
            this.panelCadastro.Controls.Add(this.precoText);
            this.panelCadastro.Controls.Add(this.label2);
            this.panelCadastro.Controls.Add(this.label4);
            this.panelCadastro.Controls.Add(this.label5);
            this.panelCadastro.Location = new System.Drawing.Point(3, 3);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(220, 83);
            this.panelCadastro.TabIndex = 17;
            // 
            // panelExcluir
            // 
            this.panelExcluir.Controls.Add(this.button2);
            this.panelExcluir.Location = new System.Drawing.Point(3, 4);
            this.panelExcluir.Name = "panelExcluir";
            this.panelExcluir.Size = new System.Drawing.Size(80, 45);
            this.panelExcluir.TabIndex = 18;
            // 
            // panelGeral
            // 
            this.panelGeral.Controls.Add(this.panelCadastro);
            this.panelGeral.Controls.Add(this.panel2);
            this.panelGeral.Controls.Add(this.panelAdmin);
            this.panelGeral.Location = new System.Drawing.Point(38, 343);
            this.panelGeral.Name = "panelGeral";
            this.panelGeral.Size = new System.Drawing.Size(464, 89);
            this.panelGeral.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelExcluir);
            this.panel2.Location = new System.Drawing.Point(384, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(92, 52);
            this.panel2.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(704, 444);
            this.Controls.Add(this.panelGeral);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.modeText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameApp);
            this.Controls.Add(this.myName);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Controle de Estoque - Sistema";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precoText)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.panelExcluir.ResumeLayout(false);
            this.panelGeral.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public class BDProducts
        {
            public static void adicionar(IMongoCollection<Entity> lista, string code, int quant,int preco, bool op)
            {
                try
                {
                    lista.InsertOne(new Entity { _id=code, quant=quant ,preco=preco});
                } catch
                {
                    if (!op)
                    {
                        quant = -quant;
                    }

                    string param = "{$inc: {'quant':" + quant.ToString() + "} }";
                    string filter = "{'_id':'" + code + "'}";

                    var replacementparam = filter.Replace("y", quant.ToString());
                    var replacementfilter = filter.Replace("elemento", code);

                    BsonDocument filterdoc = BsonDocument.Parse(filter);
                    BsonDocument document = BsonDocument.Parse(param);

                    lista.UpdateOne(filterdoc, document);
                }
            }
            public static void start(ListView listview)
            {
                var documents = Global.collectionDados.Find(new BsonDocument()).ToList();
                ListViewItem prod;

                foreach(var i in documents)
                {
                    prod = new ListViewItem(i._id);
                    prod.SubItems.Add(i.quant.ToString());
                    prod.SubItems.Add(i.preco.ToString());
                    listview.Items.Add(prod);
                }
            }
            public static void excluir(string code)
            {
                string filter = "{'_id':'"+code+"'}";
                BsonDocument filterdoc = BsonDocument.Parse(filter);
                Global.collectionDados.DeleteOne(filterdoc);
            }

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameApp;
        private System.Windows.Forms.Label myName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label modeText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox codeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown QuantText;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label5;
        private NumericUpDown precoText;
        private Panel panelAdmin;
        private Panel panelCadastro;
        private Panel panelExcluir;
        private Panel panelGeral;
        private Panel panel2;
    }
}
