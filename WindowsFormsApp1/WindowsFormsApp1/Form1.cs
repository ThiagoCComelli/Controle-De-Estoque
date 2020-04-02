using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            Conecta.ConnectToMongoService();

            InitializeComponent();

            Conecta.start(listView1);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acao(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            acao(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            excluir();
        }

        private void excluir()
        {
            if (textBox1.Text != "" && listView1.Items.Count != 0)
            {
                var item = listView1.FindItemWithText(textBox1.Text, false, 0, false);

                if (item != null)
                {
                    listView1.Items.Remove(item);
                }
            }
            Conecta.excluirDb(Global.collection, textBox1.Text);

        }
        private void acao(bool op)
        {

            if (op)
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    ListViewItem prod = new ListViewItem(textBox1.Text);
                    prod.SubItems.Add(textBox2.Text);

                    if (listView1.Items.Count == 0)
                    {
                        listView1.Items.Add(prod);
                    }
                    else
                    {
                        var item = listView1.FindItemWithText(textBox1.Text, false, 0, false);

                        if (item == null)
                        {
                            listView1.Items.Add(prod);
                        }
                        else
                        {
                            errorProvider1.Clear();
                            item.SubItems[1].Text = (Int32.Parse(textBox2.Text) + Int32.Parse(item.SubItems[1].Text)).ToString();
                        }

                    }
                    Conecta.adicionar(Global.collection, textBox1.Text, Int32.Parse(textBox2.Text),op);

                }
            } else
            {
                if(listView1.Items.Count != 0)
                {
                    var item = listView1.FindItemWithText(textBox1.Text, false, 0, false);

                    if (item != null)
                    {
                        int val = Int32.Parse(item.SubItems[1].Text) - Int32.Parse(textBox2.Text);

                        if (val < 0)
                        {
                            errorProvider1.SetError(label2, "VALOR INVALIDO");
                        }
                        else
                        {
                            errorProvider1.Clear();
                            item.SubItems[1].Text = (Int32.Parse(item.SubItems[1].Text) - Int32.Parse(textBox2.Text)).ToString();
                        }
                        Conecta.adicionar(Global.collection, textBox1.Text, Int32.Parse(textBox2.Text), op);

                    }
                }
            }
        }
    }
}
