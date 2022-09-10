using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cardapio
{
    public partial class fmr_comida : Form
    {
        public fmr_comida()
        {
            InitializeComponent();
        }

        string conexao = " server = 127.0.0.1; port = 3306; UID= root; pwd = 30334212Rt#; database= cardapio";
        private void fmr_comida_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conexao);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select A.nome from pratos A inner join restaurante B " +
                "on A.id_restaurante= B.id_restaurante where A.id_prato = 21 ;", conn);
            MySqlDataReader ler = cmd.ExecuteReader();
            while(ler.Read())
            {
                label1.Text = ler.GetString("nome");
            }
            conn.Close();

            conn.Open();

            MySqlCommand cmd1 = new MySqlCommand("select A.nome from pratos A inner join restaurante B " +
                "on A.id_restaurante= B.id_restaurante where A.id_prato = 22 ;", conn);
            MySqlDataReader ler1 = cmd1.ExecuteReader();
            while (ler1.Read())
            {
                label2.Text = ler1.GetString("nome");
            }
            conn.Close();

            conn.Open();

            MySqlCommand cmd2 = new MySqlCommand("select A.nome from pratos A inner join restaurante B " +
                "on A.id_restaurante= B.id_restaurante where A.id_prato = 23 ;", conn);
            MySqlDataReader ler2 = cmd2.ExecuteReader();
            while (ler2.Read())
            {
                label3.Text = ler2.GetString("nome");
            }
            conn.Close();

            conn.Open();

            MySqlCommand cmd4 = new MySqlCommand("select A.nome from pratos A inner join restaurante B " +
                "on A.id_restaurante= B.id_restaurante where A.id_prato = 24 ;", conn);
            MySqlDataReader ler4 = cmd4.ExecuteReader();
            while (ler4.Read())
            {
                label4.Text = ler4.GetString("nome");
            }
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
