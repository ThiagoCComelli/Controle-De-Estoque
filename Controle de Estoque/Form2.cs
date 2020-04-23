using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            BDProducts.start(listView1);

            if(Global.mode == "Admin")
            {
                panelExcluir.Dispose();
            } else if (Global.mode == "Normal")
            {
                panelGeral.Dispose();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            usernameText.Text = Global.user;
            modeText.Text = Global.mode;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            acao(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acao(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selected = listView1.SelectedItems[0].Text;
            
            var item = listView1.FindItemWithText(selected, false, 0, false);

            if (item != null)
            {
                listView1.Items.Remove(item);
                BDProducts.excluir(selected);
            }
            
        }

        private void acao(bool op)
        {
            if (op)
            {
                if (codeText.Text != "" && QuantText.Value > 0)
                {
                    ListViewItem prod = new ListViewItem(codeText.Text);
                    prod.SubItems.Add((QuantText.Value).ToString());
                    prod.SubItems.Add((precoText.Value).ToString());

                    if(listView1.Items.Count == 0)
                    {
                        listView1.Items.Add(prod);
                    } else
                    {
                        var item = listView1.FindItemWithText(codeText.Text,false,0,false);
                    
                        if(item == null)
                        {
                            listView1.Items.Add(prod);
                        } else
                        {
                            item.SubItems[1].Text = (QuantText.Value + Int32.Parse(item.SubItems[1].Text)).ToString();
                        }
                    }
                    BDProducts.adicionar(Global.collectionDados,codeText.Text, Convert.ToInt32(Math.Round(QuantText.Value, 0)), Convert.ToInt32(Math.Round(precoText.Value, 0)), op);
                }
            } else
            {
                if(listView1.Items.Count != 0)
                {
                    var item = listView1.FindItemWithText(codeText.Text, false, 0, false);
                    if(item != null)
                    {
                        int val = Int32.Parse(item.SubItems[1].Text) - Convert.ToInt32(Math.Round(QuantText.Value, 0));
                        if(val < 0)
                        {

                        } else
                        {
                            item.SubItems[1].Text = (Int32.Parse(item.SubItems[1].Text) - QuantText.Value).ToString();
                            BDProducts.adicionar(Global.collectionDados, codeText.Text, Convert.ToInt32(Math.Round(QuantText.Value, 0)), Convert.ToInt32(Math.Round(precoText.Value, 0)), op);
                        }
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
