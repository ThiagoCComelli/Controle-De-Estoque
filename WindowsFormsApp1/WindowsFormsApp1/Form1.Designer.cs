using MongoDB.Driver;
using MongoDB.Bson;
using System.Windows.Forms;
using System;

namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ch_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_code,
            this.ch_quantity});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(370, 97);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ch_code
            // 
            this.ch_code.Text = "CODE";
            this.ch_code.Width = 100;
            // 
            // ch_quantity
            // 
            this.ch_quantity.Text = "QUANTIDADE";
            this.ch_quantity.Width = 100;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantidade:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "ADICIONAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 10;
            this.button2.Text = "REMOVER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(388, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 145);
            this.button3.TabIndex = 11;
            this.button3.Text = "EXCLUIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 169);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Controle de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public class Global
        {
            public static IMongoClient client;
            public static IMongoDatabase database;
            public static IMongoCollection<Entity> collection;
        }

        public class Conecta
        {

            public static void ConnectToMongoService()
            {
                const string connectionString = "botar seu cluster";
                IMongoClient clients = new MongoClient(connectionString);
                IMongoDatabase databases = clients.GetDatabase("estoque");
                IMongoCollection<Entity> collections = databases.GetCollection<Entity>("estoque-dados");

                Global.client = clients;
                Global.database = databases;
                Global.collection = collections;
            }


            public static void adicionar(IMongoCollection<Entity> lista, string id, int quanti,bool op)
            {
                try
                {
                    lista.InsertOne(new Entity { _id = id, quant = quanti });
                } catch
                {
                    update(lista,id,quanti,op);
                }
            }
            
            public static void excluirDb(IMongoCollection<Entity> lista, string id)
            {
                string filter = "{'_id':'" + id + "'}";
                var replacementfilter = filter.Replace("elemento", id);
                BsonDocument filterdoc = BsonDocument.Parse(filter);

                lista.DeleteOne(filterdoc);
            }
           
            public static void update(IMongoCollection<Entity> lista, string id, int quanti,bool op)
            {
                if (!op)
                {
                    quanti = -quanti;
                }

                string param = "{$inc: {'quant':" + quanti.ToString() + "} }";
                string filter = "{'_id':'" + id + "'}";

                var replacementparam = filter.Replace("y", quanti.ToString());
                var replacementfilter = filter.Replace("elemento",id);

                BsonDocument filterdoc = BsonDocument.Parse(filter);
                BsonDocument document = BsonDocument.Parse(param);

                lista.UpdateOne(filterdoc, document);
            }

            public static void start(ListView listview)
            {
                var documents = Global.collection.Find(new BsonDocument()).ToList();
                ListViewItem prod;

                foreach (var i in documents)
                {
                    prod = new ListViewItem(i._id);
                    prod.SubItems.Add(i.quant.ToString());

                    listview.Items.Add(prod);

                }
            }
        }

        public class Entity
        {
            public string _id { get; set; }
            public int quant { get; set; }
        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ch_code;
        private System.Windows.Forms.ColumnHeader ch_quantity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button3;

        
    }
}

