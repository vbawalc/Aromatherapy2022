using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aromatherapy_Master
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void AddPlant_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Aromatherapy2;Integrated Security=True");
            con.Open();
            //Sprawdzenie czy roslinka juz istnieje 
            string CmdString1 = "SELECT Name, PlantID FROM Plant WHERE Name=@Parameter1";
            SqlCommand com1 = new SqlCommand(CmdString1, con);
            com1.Parameters.Add(new SqlParameter("Parameter1", txtPlantName.Text));
            SqlDataAdapter sda1 = new SqlDataAdapter(com1);
            DataTable dtbl1 = new DataTable();
            sda1.Fill(dtbl1);
            
            //Jesli tak edytowanie komentarza
            if (dtbl1.Rows.Count == 1)
            {
                string plantid = dtbl1.Rows[0]["plantid"].ToString();
                //FEELING
                string CmdString4 = "UPDATE Feeling SET  Relaxed = @Parameter1, Happy = @Parameter2, Euphoric = @Parameter3,Uplifted = @Parameter4, Hungry = @Parameter5, Energetic = @Parameter6 WHERE PlantID = @Parameter7";
                SqlCommand com4 = new SqlCommand(CmdString4, con);
                com4.Parameters.Add(new SqlParameter("Parameter1", cbRelaxed.Text.ToString()));
                com4.Parameters.Add(new SqlParameter("Parameter2", cbHappy.Text.ToString()));
                com4.Parameters.Add(new SqlParameter("Parameter3", cbEuphoric.Text.ToString()));
                com4.Parameters.Add(new SqlParameter("Parameter4", cbUplifted.Text.ToString()));
                com4.Parameters.Add(new SqlParameter("Parameter5", cbHungry.Text.ToString()));
                com4.Parameters.Add(new SqlParameter("Parameter6", cbEnergetic.Text.ToString()));
                com4.Parameters.Add(new SqlParameter("Parameter7", plantid));
                com4.ExecuteNonQuery();               
                //Negative
                string CmdString5 = "UPDATE Negative SET DryEyes=@Parameter7,DryMouth=@Parameter8, Paranoid=@Parameter9,Dizzy=@Parameter10,Anxious=@Parameter11,Headache=@Parameter12 WHERE PlantID=@Parameter13";
                SqlCommand com5 = new SqlCommand(CmdString5, con);
                com5.Parameters.Add(new SqlParameter("Parameter7", cbDryEyes.Text.ToString()));
                com5.Parameters.Add(new SqlParameter("Parameter8", cbDryMouth.Text.ToString()));
                com5.Parameters.Add(new SqlParameter("Parameter9", cbParanoid.Text.ToString()));
                com5.Parameters.Add(new SqlParameter("Parameter10", cbDizzy.Text.ToString()));
                com5.Parameters.Add(new SqlParameter("Parameter11", cbAnxious.Text.ToString()));
                com5.Parameters.Add(new SqlParameter("Parameter12", cbHeadache.Text.ToString()));
                com5.Parameters.Add(new SqlParameter("Parameter13", plantid));
                com5.ExecuteNonQuery();
                //Helpwith
                string CmdString6 = "UPDATE Help SET Stress=@Parameter1,Anxiety=@Parameter2, Pain=@Parameter3,Depression=@Parameter4,Insomnia=@Parameter5,NoApetite=@Parameter6 WHERE PlantID=@Parameter7";
                SqlCommand com6 = new SqlCommand(CmdString6, con);
                com6.Parameters.Add(new SqlParameter("Parameter1", cbStress.Text.ToString()));
                com6.Parameters.Add(new SqlParameter("Parameter2", cbAnxiety.Text.ToString()));
                com6.Parameters.Add(new SqlParameter("Parameter3", cbPain.Text.ToString()));
                com6.Parameters.Add(new SqlParameter("Parameter4", cbDepression.Text.ToString()));
                com6.Parameters.Add(new SqlParameter("Parameter5", cbInsomnia.Text.ToString()));
                com6.Parameters.Add(new SqlParameter("Parameter6", cbNoApetite.Text.ToString()));
                com6.Parameters.Add(new SqlParameter("Parameter7", plantid));
                com6.ExecuteNonQuery();
                MessageBox.Show("Plant Edited");
            }
            else
            //Dodawanie Planta
            {
                //Dodanie do Plant
                string CmdString7 = "INSERT INTO Plant (Name,Breeder,Temperature) VALUES (@Parameter1,@Parameter2,@Parameter3)";
                SqlCommand com7 = new SqlCommand(CmdString7, con);
                com7.Parameters.Add(new SqlParameter("Parameter1", txtPlantName.Text));
                com7.Parameters.Add(new SqlParameter("Parameter2", txtBreeder.Text));
                com7.Parameters.Add(new SqlParameter("Parameter3", txtTemperature.Text));
                com7.ExecuteNonQuery();
                //pobieranie PLANTID nowo dodanego planta
                string CmdString11 = "SELECT Name, PlantID FROM Plant WHERE Name=@Parameter1";
                SqlCommand com11 = new SqlCommand(CmdString11, con);
                com11.Parameters.Add(new SqlParameter("Parameter1", txtPlantName.Text));
                SqlDataAdapter sda11 = new SqlDataAdapter(com11);
                DataTable dtbl11 = new DataTable();
                sda11.Fill(dtbl11);
                string plantid = dtbl11.Rows[0]["plantid"].ToString();
                //Dodanie do Feeling
                string CmdString8 = "INSERT INTO Feeling (Relaxed, Happy, Euphoric, Uplifted, Hungry, Energetic,PlantID) VALUES (@Parameter1,@Parameter2,@Parameter3,@Parameter4,@Parameter5,@Parameter6,@Parameter7)";
                SqlCommand com8 = new SqlCommand(CmdString8, con);
                com8.Parameters.Add(new SqlParameter("Parameter1", cbRelaxed.Text.ToString()));
                com8.Parameters.Add(new SqlParameter("Parameter2", cbHappy.Text.ToString()));
                com8.Parameters.Add(new SqlParameter("Parameter3", cbEuphoric.Text.ToString()));
                com8.Parameters.Add(new SqlParameter("Parameter4", cbUplifted.Text.ToString()));
                com8.Parameters.Add(new SqlParameter("Parameter5", cbHungry.Text.ToString()));
                com8.Parameters.Add(new SqlParameter("Parameter6", cbEnergetic.Text.ToString()));
                com8.Parameters.Add(new SqlParameter("Parameter7", plantid));
                com8.ExecuteNonQuery();
                //Dodanie do Negative
                string CmdString9 = "INSERT INTO Negative (DryEyes,DryMouth, Paranoid,Dizzy,Anxious,Headache,PlantID) VALUES (@Parameter1,@Parameter2,@Parameter3,@Parameter4,@Parameter5,@Parameter6,@Parameter7)";
                SqlCommand com9 = new SqlCommand(CmdString9, con);
                com9.Parameters.Add(new SqlParameter("Parameter1", cbDryEyes.Text.ToString()));
                com9.Parameters.Add(new SqlParameter("Parameter2", cbDryMouth.Text.ToString()));
                com9.Parameters.Add(new SqlParameter("Parameter3", cbParanoid.Text.ToString()));
                com9.Parameters.Add(new SqlParameter("Parameter4", cbDizzy.Text.ToString()));
                com9.Parameters.Add(new SqlParameter("Parameter5", cbAnxious.Text.ToString()));
                com9.Parameters.Add(new SqlParameter("Parameter6", cbHeadache.Text.ToString()));
                com9.Parameters.Add(new SqlParameter("Parameter7", plantid));
                com9.ExecuteNonQuery();
                //Dodanie do Help
                string CmdString10 = "INSERT INTO Help (Stress,Anxiety, Pain,Depression,Insomnia,NoApetite,PlantID) VALUES (@Parameter1,@Parameter2,@Parameter3,@Parameter4,@Parameter5,@Parameter6,@Parameter7)";
                SqlCommand com10 = new SqlCommand(CmdString10, con);
                com10.Parameters.Add(new SqlParameter("Parameter1", cbStress.Text.ToString()));
                com10.Parameters.Add(new SqlParameter("Parameter2", cbAnxiety.Text.ToString()));
                com10.Parameters.Add(new SqlParameter("Parameter3", cbPain.Text.ToString()));
                com10.Parameters.Add(new SqlParameter("Parameter4", cbDepression.Text.ToString()));
                com10.Parameters.Add(new SqlParameter("Parameter5", cbInsomnia.Text.ToString()));
                com10.Parameters.Add(new SqlParameter("Parameter6", cbNoApetite.Text.ToString()));
                com10.Parameters.Add(new SqlParameter("Parameter7", plantid));
                com10.ExecuteNonQuery();
                MessageBox.Show("Plant added");
            }
        }

        private void btnMainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            frmMain objFrmMain = new frmMain();
            this.Hide();
            objFrmMain.Show();
            
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Aromatherapy2;Integrated Security=True");
            string CmdString = "SELECT Login,Name,Type FROM Users ";
            SqlCommand com = new SqlCommand(CmdString, con);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dtgUsers.DataSource = dtbl;
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Aromatherapy2;Integrated Security=True");
            con.Open();
            string CmdString = "DELETE FROM Users WHERE login = @Parameter1";
            SqlCommand com = new SqlCommand(CmdString, con);
            com.Parameters.Add(new SqlParameter("Parameter1", lblUser.Text));
            com.ExecuteNonQuery();
            MessageBox.Show("User Banned");
            string CmdString2 = "SELECT Login,Name,Type FROM Users ";
            SqlCommand com2 = new SqlCommand(CmdString2, con);
            SqlDataAdapter sda = new SqlDataAdapter(com2);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dtgUsers.DataSource = dtbl;
            con.Close();
        }

        private void dtgUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*String clicked = dtgUsers.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            lblUser.Text = clicked;*/
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Aromatherapy2;Integrated Security=True");
            con.Open();
            string CmdString = "UPDATE Users SET Type='Admin' WHERE login = @Parameter1";
            SqlCommand com = new SqlCommand(CmdString, con);
            com.Parameters.Add(new SqlParameter("Parameter1", lblUser.Text));
            com.ExecuteNonQuery();
            MessageBox.Show("User Promoted");
            string CmdString2 = "SELECT Login,Name,Type FROM Users ";
            SqlCommand com2 = new SqlCommand(CmdString2, con);
            SqlDataAdapter sda = new SqlDataAdapter(com2);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dtgUsers.DataSource = dtbl;
            con.Close();
        }

        private void dtgUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String clicked = dtgUsers.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            lblUser.Text = clicked;
        }
    }
}
