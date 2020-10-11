using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_de_contraseñas
{
    public partial class Form1 : Form
    {
        int numero_contraseñas = 10;
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_generar_Click(object sender, EventArgs e)
        {
            string caracteres = "abcdefghijklmnopqrstuvwxyz";
            if (check_mayusculas.Checked)
            {
                caracteres += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if (check_caracteres.Checked)
            {
                caracteres += "0123456789";
            }
            if (check_simbolos.Checked)
            {
                caracteres += "#@$%*&!?/|+-.:;";
            }

            list_Contraseñas.Items.Clear();
            Random rnd = new Random();

            for( int n = 1; n <= numero_contraseñas; n++)
            {
                StringBuilder str = new StringBuilder();
                for( int m = 1; m <= Contador_caracteres.Value; m++)
                {
                    int pos = rnd.Next(0, caracteres.Length);
                    str.Append(caracteres[pos].ToString());
                }
                list_Contraseñas.Items.Add(str.ToString());
            }
        }
        

        private void list_Contraseñas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Codigo para poder copiar el texto seleccionado con Ctrl + C
            string s = "";
            foreach (object o in list_Contraseñas.SelectedItems)
            {
                s += o.ToString() + "  ";
            }
            Clipboard.SetText(s);
        }
    }
}
