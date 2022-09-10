using MySql.Data.MySqlClient;

namespace Cardapio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string conexao = " server = 127.0.0.1; port = 3306; UID= root; pwd = 30334212Rt#; database= cardapio";

        private void btn_Inicial_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(conexao);
                conn.Open();

                MySqlCommand cmd1 = new MySqlCommand("select nome from restaurante where id_restaurante = 1;", conn);
                MySqlDataReader ler1 = cmd1.ExecuteReader();
                while(ler1.Read())
                {
                    txt_Restaurante1.Text = ler1.GetString("nome");
                }
                conn.Close();

                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand("select nome from restaurante where id_restaurante = 2;", conn);
                MySqlDataReader ler2 = cmd2.ExecuteReader();
                while(ler2.Read())
                {
                    txt_restaurante2.Text = ler2.GetString("nome");
                }
                

                conn.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void btn_opcao1_Click(object sender, EventArgs e)
        {
            try
            {
                fmr_comida comidas = new fmr_comida();
                comidas.Show();

                

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_Opcao2_Click(object sender, EventArgs e)
        {
            frm_Drinks drinks = new frm_Drinks();
            drinks.Show();
        }
    }
}