using System.Data.SqlClient;
using System.Resources;
using System.Configuration;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace WFA_beadando_0104
{
    public partial class FilmekMain : Form
    {

        private int selectedID = -1;

        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=musorok;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlCommand cmd;

        public FilmekMain()
        {
            InitializeComponent();

            //beolvas�s
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                conn.Open();
                dgv.Rows.Clear();
                SqlDataReader reader = new SqlCommand(
                "SELECT id, cime, mufaja, kiadas_eve FROM filmek;",
                 conn)
                .ExecuteReader();

                while (reader.Read())
                {
                    dgv.Rows.Add(
                        reader[0],
                        reader[1],
                        reader[2],
                        reader[3]
                    );
                }
                conn.Close();

            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedID = (int)dgv[0, e.RowIndex].Value;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //row hozz�ad�sa
        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                conn.Open();
                SqlDataAdapter sda = new()
                {
                    InsertCommand = new(
                    cmdText: "INSERT INTO filmek (cime, leirasa, mufaja, kiadas_eve, borito_path) VALUES ('" + fieldCim.Text + "', '" + fieldLeiras.Text + "', '" + fieldMufaj.Text + "', '" + fieldEv.Text + "', '" + fieldPath.Text + "' )",
                    connection: conn),
                };

                sda.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Sikeresen hozz�adva a rendszerhez!");
                conn.Close();

            }
        }

        //row friss�t�se
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                conn.Open();
                SqlDataAdapter sda = new()
                {
                    InsertCommand = new(
                    cmdText: "UPDATE filmek SET cime = '" + fieldUjcim.Text + "', mufaj = '" + fieldUjmufaj.Text + "', kiadas_eve = '" + fieldUjkiev.Text + "' WHERE id = '" + selectedID + "')",
                    connection: conn),
                };

                sda.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Sikeresen m�dos�tva!");
                conn.Close();

            }
        }

        //row t�rl�se
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                 caption: "Figyelmeztet�s",
                 text: "Biztosan t�r�lni szeretn� az adott sort? Minden adat v�gleg el fog veszni.",
                 icon: MessageBoxIcon.Warning,
                 buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlDataAdapter sqldel = new()
                    {
                        DeleteCommand = new(
                        cmdText: "DELETE FROM filmek" +
                        $"WHERE id = {selectedID};",
                        connection: conn),
                    };
                    sqldel.DeleteCommand.ExecuteNonQuery();
                }
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                //adatlap
                conn.Open();
                SqlDataReader reader = new SqlCommand(
                "SELECT cime, leirasa, kiadas_eve, szereplo FROM filmek INNER JOIN szereplok WHERE id = '" + selectedID + "';",
                conn)
                .ExecuteReader();

                while (reader.Read())
                {
                    dgv.Rows.Add(
                        reader[0],
                        reader[1],
                        reader[2],
                        reader[3]
                    );
                }

                adatlapCim.Text = adatlapCim.Text.Replace("�res", "" + reader[0]);
                adatlapLeiras.Text = adatlapLeiras.Text.Replace("�res", "" + reader[1]);
                adatlapEv.Text = adatlapEv.Text.Replace("�res", "" + reader[2]);
                adatlapSzereplo.Text = adatlapSzereplo.Text.Replace("�res", "" + reader[3]);


                conn.Close();

            }
        }
    }
}