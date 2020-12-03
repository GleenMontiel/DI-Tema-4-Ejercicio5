using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "") 
            {
                listBox1.Items.Add(textBox1.Text.Trim());
                label1.Text = listBox1.Items.Count.ToString();
                textBox1.Text = "";
                ActualizarIndice();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eliminar();
            ActualizarIndice();
        }

        public void ActualizarIndice()
        {
            label2.Text = "";
            if (listBox1.SelectedItems.Count != 0)
            {
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                    label2.Text += listBox1.Items.IndexOf(listBox1.SelectedItems[i]) + ",";
                }
                label2.Text = label2.Text.Substring(0, label2.Text.Length - 1);
            }
        }

        public void Eliminar() 
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                ListBox.SelectedObjectCollection seleccionados = listBox1.SelectedItems;

                for (int i = seleccionados.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.RemoveAt(listBox1.Items.IndexOf(seleccionados[i]));
                }
                label1.Text = listBox1.Items.Count.ToString();
                ActualizarIndice();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection seleccionados = listBox1.SelectedItems;
            for (int i = 0; i < seleccionados.Count; i++)
            {
                listBox2.Items.Insert(0, seleccionados[i]);
            }
            label2.Text = listBox2.Items.Count.ToString();
            Eliminar();
            ActualizarIndice();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count != 0)
            {
                listBox1.Items.Insert(0, listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
                ActualizarIndice();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarIndice();
        }
    }
}
