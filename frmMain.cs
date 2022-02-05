using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Aromatherapy_Master
{
    public partial class frmMain : Form
    {
        public static String currentplant;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Aromatherapy2;Integrated Security=True");
            string CmdString = "SELECT Name,Breeder FROM Plant WHERE Name LIKE '%'+@Parameter1+'%' OR Breeder LIKE '%'+@Parameter1+'%'";
            SqlCommand com = new SqlCommand(CmdString, con);
            com.Parameters.Add(new SqlParameter("parameter1", txtSearch.Text));
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dtgSearch.DataSource = dtbl;
            //Jesli tylko 1 pasuje 
            if  (dtbl.Rows.Count == 1)
            {
                String clicked = dtbl.Rows[0]["Name"].ToString();
                string CmdString2 = "SELECT plant.PlantID,Temperature, Name,Breeder,Relaxed,Happy,Euphoric,Uplifted,Hungry,Energetic,DryEyes,DryMouth,Paranoid,Dizzy,Anxious,Headache,Stress,Anxiety,Pain,Depression,Insomnia,NoApetite FROM Plant LEFT JOIN Feeling ON Plant.PlantID =Feeling.PlantID LEFT JOIN Negative ON Plant.PlantID = Negative.PlantID LEFT JOIN Help ON Plant.PlantID = Help.PlantID WHERE Name=@Parameter1";
                SqlCommand com2 = new SqlCommand(CmdString2, con);
                com2.Parameters.Add(new SqlParameter("parameter1", clicked));
                SqlDataAdapter sda2 = new SqlDataAdapter(com2);
                DataTable dtbl2 = new DataTable();
                sda2.Fill(dtbl2);
                lblName.Text = clicked;
                String breeder = dtbl2.Rows[0]["Breeder"].ToString();
                lblBreeder.Text = breeder;
                String temp = dtbl2.Rows[0]["Temperature"].ToString();
                lblTemperature.Text = temp;
                currentplant = dtbl2.Rows[0]["PlantID"].ToString();
                //Gwiazdki Relaxed///////////////////////////////////////////////////////
                String RelaxedStars = dtbl2.Rows[0]["Relaxed"].ToString();
                if (RelaxedStars == "5")
                {
                    pbRelaxed1.Show();
                    pbRelaxed2.Show();
                    pbRelaxed3.Show();
                    pbRelaxed4.Show();
                    pbRelaxed5.Show();
                }
                else if (RelaxedStars == "4")
                {
                    pbRelaxed1.Show();
                    pbRelaxed2.Show();
                    pbRelaxed3.Show();
                    pbRelaxed4.Show();
                    pbRelaxed5.Hide();
                }
                else if (RelaxedStars == "3")
                {
                    pbRelaxed1.Show();
                    pbRelaxed2.Show();
                    pbRelaxed3.Show();
                    pbRelaxed4.Hide();
                    pbRelaxed5.Hide();
                }
                else if (RelaxedStars == "2")
                {
                    pbRelaxed1.Show();
                    pbRelaxed2.Show();
                    pbRelaxed3.Hide();
                    pbRelaxed4.Hide();
                    pbRelaxed5.Hide();
                }
                else if (RelaxedStars == "1")
                {
                    pbRelaxed1.Show();
                    pbRelaxed2.Hide();
                    pbRelaxed3.Hide();
                    pbRelaxed4.Hide();
                    pbRelaxed5.Hide();
                }
                else if (RelaxedStars == "0")
                {
                    pbRelaxed1.Hide();
                    pbRelaxed2.Hide();
                    pbRelaxed3.Hide();
                    pbRelaxed4.Hide();
                    pbRelaxed5.Hide();
                }
                //Gwiazdki Happy//////////////////////////////////////////////////////
                String HappyStars = dtbl2.Rows[0]["Happy"].ToString();
                if (RelaxedStars == "5")
                {
                    pbHappy1.Show();
                    pbHappy2.Show();
                    pbHappy3.Show();
                    pbHappy4.Show();
                    pbHappy5.Show();
                }
                else if (RelaxedStars == "4")
                {
                    pbHappy1.Show();
                    pbHappy2.Show();
                    pbHappy3.Show();
                    pbHappy4.Show();
                    pbHappy5.Hide();
                }
                else if (RelaxedStars == "3")
                {
                    pbHappy1.Show();
                    pbHappy2.Show();
                    pbHappy3.Show();
                    pbHappy4.Hide();
                    pbHappy5.Hide();
                }
                else if (RelaxedStars == "2")
                {
                    pbHappy1.Show();
                    pbHappy2.Show();
                    pbHappy3.Hide();
                    pbHappy4.Hide();
                    pbHappy5.Hide();
                }
                else if (RelaxedStars == "1")
                {
                    pbHappy1.Show();
                    pbHappy2.Hide();
                    pbHappy3.Hide();
                    pbHappy4.Hide();
                    pbHappy5.Hide();
                }
                else if (RelaxedStars == "0")
                {
                    pbHappy1.Hide();
                    pbHappy2.Hide();
                    pbHappy3.Hide();
                    pbHappy4.Hide();
                    pbHappy5.Hide();
                }
                //Gwiazdki Euphoric////////////////////////////////////////////////////////////
                String EuphoricStars = dtbl2.Rows[0]["Euphoric"].ToString();
                if (EuphoricStars == "5")
                {
                    pbEuphoric1.Show();
                    pbEuphoric2.Show();
                    pbEuphoric3.Show();
                    pbEuphoric4.Show();
                    pbEuphoric5.Show();
                }
                else if (EuphoricStars == "4")
                {
                    pbEuphoric1.Show();
                    pbEuphoric2.Show();
                    pbEuphoric3.Show();
                    pbEuphoric4.Show();
                    pbEuphoric5.Hide();
                }
                else if (EuphoricStars == "3")
                {
                    pbEuphoric1.Show();
                    pbEuphoric2.Show();
                    pbEuphoric3.Show();
                    pbEuphoric4.Hide();
                    pbEuphoric5.Hide();
                }
                else if (EuphoricStars == "2")
                {
                    pbEuphoric1.Show();
                    pbEuphoric2.Show();
                    pbEuphoric3.Hide();
                    pbEuphoric4.Hide();
                    pbEuphoric5.Hide();
                }
                else if (EuphoricStars == "1")
                {
                    pbEuphoric1.Show();
                    pbEuphoric2.Hide();
                    pbEuphoric3.Show();
                    pbEuphoric4.Hide();
                    pbEuphoric5.Hide();
                }
                else if (EuphoricStars == "0")
                {
                    pbEuphoric1.Hide();
                    pbEuphoric2.Hide();
                    pbEuphoric3.Show();
                    pbEuphoric4.Hide();
                    pbEuphoric5.Hide();
                }
                //Gwiazdki Uplifted////////////////////////////////////////////////////////
                String UpliftedStars = dtbl2.Rows[0]["Uplifted"].ToString();
                if (UpliftedStars == "5")
                {
                    pbUplifted1.Show();
                    pbUplifted2.Show();
                    pbUplifted3.Show();
                    pbUplifted4.Show();
                    pbUplifted5.Show();
                }
                else if (UpliftedStars == "4")
                {
                    pbUplifted1.Show();
                    pbUplifted2.Show();
                    pbUplifted3.Show();
                    pbUplifted4.Show();
                    pbUplifted5.Hide();
                }
                else if (UpliftedStars == "3")
                {
                    pbUplifted1.Show();
                    pbUplifted2.Show();
                    pbUplifted3.Show();
                    pbUplifted4.Hide();
                    pbUplifted5.Hide();
                }
                else if (UpliftedStars == "2")
                {
                    pbUplifted1.Show();
                    pbUplifted2.Show();
                    pbUplifted3.Hide();
                    pbUplifted4.Hide();
                    pbUplifted5.Hide();
                }
                else if (UpliftedStars == "1")
                {
                    pbUplifted1.Show();
                    pbUplifted2.Hide();
                    pbUplifted3.Hide();
                    pbUplifted4.Hide();
                    pbUplifted5.Hide();
                }
                else if (UpliftedStars == "0")
                {
                    pbUplifted1.Hide();
                    pbUplifted2.Hide();
                    pbUplifted3.Hide();
                    pbUplifted4.Hide();
                    pbUplifted5.Hide();
                }
                //Gwiazdki Hungry////////////////////////////////////////////////////
                String HungryStars = dtbl2.Rows[0]["Hungry"].ToString();
                if (HungryStars == "5")
                {
                    pbHungry1.Show();
                    pbHungry2.Show();
                    pbHungry3.Show();
                    pbHungry4.Show();
                    pbHungry5.Show();
                }
                else if (HungryStars == "4")
                {
                    pbHungry1.Show();
                    pbHungry2.Show();
                    pbHungry3.Show();
                    pbHungry4.Show();
                    pbHungry5.Hide();
                }
                else if (HungryStars == "3")
                {
                    pbHungry1.Show();
                    pbHungry2.Show();
                    pbHungry3.Show();
                    pbHungry4.Hide();
                    pbHungry5.Hide();
                }
                else if (HungryStars == "2")
                {
                    pbHungry1.Show();
                    pbHungry2.Show();
                    pbHungry3.Hide();
                    pbHungry4.Hide();
                    pbHungry5.Hide();
                }
                else if (HungryStars == "1")
                {
                    pbHungry1.Show();
                    pbHungry2.Hide();
                    pbHungry3.Hide();
                    pbHungry4.Hide();
                    pbHungry5.Hide();
                }
                else if (HungryStars == "0")
                {
                    pbHungry1.Hide();
                    pbHungry2.Hide();
                    pbHungry3.Hide();
                    pbHungry4.Hide();
                    pbHungry5.Hide();
                }
                //Gwiazdki Energetic///////////////////////////////////////////////
                String EnergeticStars = dtbl2.Rows[0]["Energetic"].ToString();
                if (EnergeticStars == "5")
                {
                    pbEnergetic1.Show();
                    pbEnergetic2.Show();
                    pbEnergetic3.Show();
                    pbEnergetic4.Show();
                    pbEnergetic5.Show();
                }
                else if (EnergeticStars == "4")
                {
                    pbEnergetic1.Show();
                    pbEnergetic2.Show();
                    pbEnergetic3.Show();
                    pbEnergetic4.Show();
                    pbEnergetic5.Hide();
                }
                else if (EnergeticStars == "3")
                {
                    pbEnergetic1.Show();
                    pbEnergetic2.Show();
                    pbEnergetic3.Show();
                    pbEnergetic4.Hide();
                    pbEnergetic5.Hide();
                }
                else if (EnergeticStars == "2")
                {
                    pbEnergetic1.Show();
                    pbEnergetic2.Show();
                    pbEnergetic3.Hide();
                    pbEnergetic4.Hide();
                    pbEnergetic5.Hide();
                }
                else if (EnergeticStars == "1")
                {
                    pbEnergetic1.Show();
                    pbEnergetic2.Hide();
                    pbEnergetic3.Hide();
                    pbEnergetic4.Hide();
                    pbEnergetic5.Hide();
                }
                else if (EnergeticStars == "0")
                {
                    pbEnergetic1.Hide();
                    pbEnergetic2.Hide();
                    pbEnergetic3.Hide();
                    pbEnergetic4.Hide();
                    pbEnergetic5.Hide();
                }
                //Gwiazdki DryEyes////////////////////////////////////////////////////
                String DryEyesStars = dtbl2.Rows[0]["DryEyes"].ToString();
                if (DryEyesStars == "5")
                {
                    pbDryEyes1.Show();
                    pbDryEyes2.Show();
                    pbDryEyes3.Show();
                    pbDryEyes4.Show();
                    pbDryEyes5.Show();
                }
                else if (DryEyesStars == "4")
                {
                    pbDryEyes1.Show();
                    pbDryEyes2.Show();
                    pbDryEyes3.Show();
                    pbDryEyes4.Show();
                    pbDryEyes5.Hide();
                }
                else if (DryEyesStars == "3")
                {
                    pbDryEyes1.Show();
                    pbDryEyes2.Show();
                    pbDryEyes3.Show();
                    pbDryEyes4.Hide();
                    pbDryEyes5.Hide();
                }
                else if (DryEyesStars == "2")
                {
                    pbDryEyes1.Show();
                    pbDryEyes2.Show();
                    pbDryEyes3.Hide();
                    pbDryEyes4.Hide();
                    pbDryEyes5.Hide();
                }
                else if (DryEyesStars == "1")
                {
                    pbDryEyes1.Show();
                    pbDryEyes2.Hide();
                    pbDryEyes3.Hide();
                    pbDryEyes4.Hide();
                    pbDryEyes5.Hide();
                }
                else if (DryEyesStars == "0")
                {
                    pbDryEyes1.Hide();
                    pbDryEyes2.Hide();
                    pbDryEyes3.Hide();
                    pbDryEyes4.Hide();
                    pbDryEyes5.Hide();
                }
                //Gwiazdki DryMouth////////////////////////////////////////////////////
                String DryMouthStars = dtbl2.Rows[0]["DryMouth"].ToString();
                if (DryMouthStars == "5")
                {
                    pbDryMouth1.Show();
                    pbDryMouth2.Show();
                    pbDryMouth3.Show();
                    pbDryMouth4.Show();
                    pbDryMouth5.Show();
                }
                else if (DryMouthStars == "4")
                {
                    pbDryMouth1.Show();
                    pbDryMouth2.Show();
                    pbDryMouth3.Show();
                    pbDryMouth4.Show();
                    pbDryMouth5.Hide();
                }
                else if (DryMouthStars == "3")
                {
                    pbDryMouth1.Show();
                    pbDryMouth2.Show();
                    pbDryMouth3.Show();
                    pbDryMouth4.Hide();
                    pbDryMouth5.Hide();
                }
                else if (DryMouthStars == "2")
                {
                    pbDryMouth1.Show();
                    pbDryMouth2.Show();
                    pbDryMouth3.Hide();
                    pbDryMouth4.Hide();
                    pbDryMouth5.Hide();
                }
                else if (DryMouthStars == "1")
                {
                    pbDryMouth1.Show();
                    pbDryMouth2.Hide();
                    pbDryMouth3.Hide();
                    pbDryMouth4.Hide();
                    pbDryMouth5.Hide();
                }
                else if (DryMouthStars == "0")
                {
                    pbDryMouth1.Hide();
                    pbDryMouth2.Hide();
                    pbDryMouth3.Hide();
                    pbDryMouth4.Hide();
                    pbDryMouth5.Hide();
                }
                //Gwiazdki Paranoid////////////////////////////////////////////////////
                String ParanoidStars = dtbl2.Rows[0]["Paranoid"].ToString();
                if (ParanoidStars == "5")
                {
                    pbParanoid1.Show();
                    pbParanoid2.Show();
                    pbParanoid3.Show();
                    pbParanoid4.Show();
                    pbParanoid5.Show();
                }
                else if (ParanoidStars == "4")
                {
                    pbParanoid1.Show();
                    pbParanoid2.Show();
                    pbParanoid3.Show();
                    pbParanoid4.Show();
                    pbParanoid5.Hide();
                }
                else if (ParanoidStars == "3")
                {
                    pbParanoid1.Show();
                    pbParanoid2.Show();
                    pbParanoid3.Show();
                    pbParanoid4.Hide();
                    pbParanoid5.Hide();
                }
                else if (ParanoidStars == "2")
                {
                    pbParanoid1.Show();
                    pbParanoid2.Show();
                    pbParanoid3.Hide();
                    pbParanoid4.Hide();
                    pbParanoid5.Hide();
                }
                else if (ParanoidStars == "1")
                {
                    pbParanoid1.Show();
                    pbParanoid2.Hide();
                    pbParanoid3.Hide();
                    pbParanoid4.Hide();
                    pbParanoid5.Hide();
                }
                else if (ParanoidStars == "0")
                {
                    pbParanoid1.Hide();
                    pbParanoid2.Hide();
                    pbParanoid3.Hide();
                    pbParanoid4.Hide();
                    pbParanoid5.Hide();
                }
                //gwiazdki Dizzy/////////////////////////////////////////////////////////
                String DizzyStars = dtbl2.Rows[0]["Dizzy"].ToString();
                if (DizzyStars == "5")
                {
                    pbDizzy1.Show();
                    pbDizzy2.Show();
                    pbDizzy3.Show();
                    pbDizzy4.Show();
                    pbDizzy5.Show();
                }
                else if (DizzyStars == "4")
                {
                    pbDizzy1.Show();
                    pbDizzy2.Show();
                    pbDizzy3.Show();
                    pbDizzy4.Show();
                    pbDizzy5.Hide();
                }
                else if (DizzyStars == "3")
                {
                    pbDizzy1.Show();
                    pbDizzy2.Show();
                    pbDizzy3.Show();
                    pbDizzy4.Hide();
                    pbDizzy5.Hide();
                }
                else if (DizzyStars == "2")
                {
                    pbDizzy1.Show();
                    pbDizzy2.Show();
                    pbDizzy3.Hide();
                    pbDizzy4.Hide();
                    pbDizzy5.Hide();
                }
                else if (DizzyStars == "1")
                {
                    pbDizzy1.Show();
                    pbDizzy2.Hide();
                    pbDizzy3.Hide();
                    pbDizzy4.Hide();
                    pbDizzy5.Hide();
                }
                else if (DizzyStars == "0")
                {
                    pbDizzy1.Hide();
                    pbDizzy2.Hide();
                    pbDizzy3.Hide();
                    pbDizzy4.Hide();
                    pbDizzy5.Hide();
                }
                //Gwiazdki Anxious//////////////////////////////////////////////
                String AnxiousStars = dtbl2.Rows[0]["Anxious"].ToString();
                if (AnxiousStars == "5")
                {
                    pbAnxious1.Show();
                    pbAnxious2.Show();
                    pbAnxious3.Show();
                    pbAnxious4.Show();
                    pbAnxious5.Show();
                }
                else if (AnxiousStars == "4")
                {
                    pbAnxious1.Show();
                    pbAnxious2.Show();
                    pbAnxious3.Show();
                    pbAnxious4.Show();
                    pbAnxious5.Hide();
                }
                else if (AnxiousStars == "3")
                {
                    pbAnxious1.Show();
                    pbAnxious2.Show();
                    pbAnxious3.Show();
                    pbAnxious4.Hide();
                    pbAnxious5.Hide();
                }
                else if (AnxiousStars == "2")
                {
                    pbAnxious1.Show();
                    pbAnxious2.Show();
                    pbAnxious3.Hide();
                    pbAnxious4.Hide();
                    pbAnxious5.Hide();
                }
                else if (AnxiousStars == "1")
                {
                    pbAnxious1.Show();
                    pbAnxious2.Hide();
                    pbAnxious3.Hide();
                    pbAnxious4.Hide();
                    pbAnxious5.Hide();
                }
                else if (AnxiousStars == "0")
                {
                    pbAnxious1.Hide();
                    pbAnxious2.Hide();
                    pbAnxious3.Hide();
                    pbAnxious4.Hide();
                    pbAnxious5.Hide();
                }
                //Gwiazdki Headache//////////////////////////////////////////////////
                String HeadacheStars = dtbl2.Rows[0]["Headache"].ToString();
                if (HeadacheStars == "5")
                {
                    pbHeadache1.Show();
                    pbHeadache2.Show();
                    pbHeadache3.Show();
                    pbHeadache4.Show();
                    pbHeadache5.Show();
                }
                else if (HeadacheStars == "4")
                {
                    pbHeadache1.Show();
                    pbHeadache2.Show();
                    pbHeadache3.Show();
                    pbHeadache4.Show();
                    pbHeadache5.Hide();
                }
                else if (HeadacheStars == "3")
                {
                    pbHeadache1.Show();
                    pbHeadache2.Show();
                    pbHeadache3.Show();
                    pbHeadache4.Hide();
                    pbHeadache5.Hide();
                }
                else if (HeadacheStars == "2")
                {
                    pbHeadache1.Show();
                    pbHeadache2.Show();
                    pbHeadache3.Hide();
                    pbHeadache4.Hide();
                    pbHeadache5.Hide();
                }
                else if (HeadacheStars == "1")
                {
                    pbHeadache1.Show();
                    pbHeadache2.Hide();
                    pbHeadache3.Hide();
                    pbHeadache4.Hide();
                    pbHeadache5.Hide();
                }
                else if (HeadacheStars == "0")
                {
                    pbHeadache1.Hide();
                    pbHeadache2.Hide();
                    pbHeadache3.Hide();
                    pbHeadache4.Hide();
                    pbHeadache5.Hide();
                }
                //Gwiazdki Stress///////////////////////////////////////
                String StressStars = dtbl2.Rows[0]["Stress"].ToString();
                if (StressStars == "5")
                {
                    pbStress1.Show();
                    pbStress2.Show();
                    pbStress3.Show();
                    pbStress4.Show();
                    pbStress5.Show();
                }
                else if (StressStars == "4")
                {
                    pbStress1.Show();
                    pbStress2.Show();
                    pbStress3.Show();
                    pbStress4.Show();
                    pbStress5.Hide();
                }
                else if (StressStars == "3")
                {
                    pbStress1.Show();
                    pbStress2.Show();
                    pbStress3.Show();
                    pbStress4.Hide();
                    pbStress5.Hide();
                }
                else if (StressStars == "2")
                {
                    pbStress1.Show();
                    pbStress2.Show();
                    pbStress3.Hide();
                    pbStress4.Hide();
                    pbStress5.Hide();
                }
                else if (StressStars == "1")
                {
                    pbStress1.Show();
                    pbStress2.Hide();
                    pbStress3.Hide();
                    pbStress4.Hide();
                    pbStress5.Hide();
                }
                else if (StressStars == "0")
                {
                    pbStress1.Hide();
                    pbStress2.Hide();
                    pbStress3.Hide();
                    pbStress4.Hide();
                    pbStress5.Hide();
                }
                //Gwiazdki Anxiety/////////////////////////////////
                String AnxietyStars = dtbl2.Rows[0]["Anxiety"].ToString();
                if (AnxietyStars == "5")
                {
                    pbAnxiety1.Show();
                    pbAnxiety2.Show();
                    pbAnxiety3.Show();
                    pbAnxiety4.Show();
                    pbAnxiety5.Show();
                }
                else if (AnxietyStars == "4")
                {
                    pbAnxiety1.Show();
                    pbAnxiety2.Show();
                    pbAnxiety3.Show();
                    pbAnxiety4.Show();
                    pbAnxiety5.Hide();
                }
                else if (AnxietyStars == "3")
                {
                    pbAnxiety1.Show();
                    pbAnxiety2.Show();
                    pbAnxiety3.Show();
                    pbAnxiety4.Hide();
                    pbAnxiety5.Hide();
                }
                else if (AnxietyStars == "2")
                {
                    pbAnxiety1.Show();
                    pbAnxiety2.Show();
                    pbAnxiety3.Hide();
                    pbAnxiety4.Hide();
                    pbAnxiety5.Hide();
                }
                else if (AnxietyStars == "1")
                {
                    pbAnxiety1.Show();
                    pbAnxiety2.Hide();
                    pbAnxiety3.Hide();
                    pbAnxiety4.Hide();
                    pbAnxiety5.Hide();
                }
                else if (AnxietyStars == "0")
                {
                    pbAnxiety1.Hide();
                    pbAnxiety2.Hide();
                    pbAnxiety3.Hide();
                    pbAnxiety4.Hide();
                    pbAnxiety5.Hide();
                }
                //Gwiazdki Pain////////////////////////////////////
                String PainStars = dtbl2.Rows[0]["Pain"].ToString();
                if (PainStars == "5")
                {
                    pbPain1.Show();
                    pbPain2.Show();
                    pbPain3.Show();
                    pbPain4.Show();
                    pbPain5.Show();
                }
                else if (PainStars == "4")
                {
                    pbPain1.Show();
                    pbPain2.Show();
                    pbPain3.Show();
                    pbPain4.Show();
                    pbPain5.Hide();
                }
                else if (PainStars == "3")
                {
                    pbPain1.Show();
                    pbPain2.Show();
                    pbPain3.Show();
                    pbPain4.Hide();
                    pbPain5.Hide();
                }
                else if (PainStars == "2")
                {
                    pbPain1.Show();
                    pbPain2.Show();
                    pbPain3.Hide();
                    pbPain4.Hide();
                    pbPain5.Hide();
                }
                else if (PainStars == "1")
                {
                    pbPain1.Show();
                    pbPain2.Hide();
                    pbPain3.Hide();
                    pbPain4.Hide();
                    pbPain5.Hide();
                }
                else if (PainStars == "0")
                {
                    pbPain1.Hide();
                    pbPain2.Hide();
                    pbPain3.Hide();
                    pbPain4.Hide();
                    pbPain5.Hide();
                }
                //Gwiazdki Depression ///////////////////////////////////
                String DepressionStars = dtbl2.Rows[0]["Depression"].ToString();
                if (DepressionStars == "5")
                {
                    pbDepression1.Show();
                    pbDepression2.Show();
                    pbDepression3.Show();
                    pbDepression4.Show();
                    pbDepression5.Show();
                }
                else if (DepressionStars == "4")
                {
                    pbDepression1.Show();
                    pbDepression2.Show();
                    pbDepression3.Show();
                    pbDepression4.Show();
                    pbDepression5.Hide();
                }
                else if (DepressionStars == "3")
                {
                    pbDepression1.Show();
                    pbDepression2.Show();
                    pbDepression3.Show();
                    pbDepression4.Hide();
                    pbDepression5.Hide();
                }
                else if (DepressionStars == "2")
                {
                    pbDepression1.Show();
                    pbDepression2.Show();
                    pbDepression3.Hide();
                    pbDepression4.Hide();
                    pbDepression5.Hide();
                }
                else if (DepressionStars == "1")
                {
                    pbDepression1.Show();
                    pbDepression2.Hide();
                    pbDepression3.Hide();
                    pbDepression4.Hide();
                    pbDepression5.Hide();
                }
                else if (DepressionStars == "0")
                {
                    pbDepression1.Hide();
                    pbDepression2.Hide();
                    pbDepression3.Hide();
                    pbDepression4.Hide();
                    pbDepression5.Hide();
                }
                //Gwiazdki Insomnia//////////////////////////////////////
                String InsomniaStars = dtbl2.Rows[0]["Insomnia"].ToString();
                if (InsomniaStars == "5")
                {
                    pbInsomnia1.Show();
                    pbInsomnia2.Show();
                    pbInsomnia3.Show();
                    pbInsomnia4.Show();
                    pbInsomnia5.Show();
                }
                else if (InsomniaStars == "4")
                {
                    pbInsomnia1.Show();
                    pbInsomnia2.Show();
                    pbInsomnia3.Show();
                    pbInsomnia4.Show();
                    pbInsomnia5.Hide();
                }
                else if (InsomniaStars == "3")
                {
                    pbInsomnia1.Show();
                    pbInsomnia2.Show();
                    pbInsomnia3.Show();
                    pbInsomnia4.Hide();
                    pbInsomnia5.Hide();
                }
                else if (InsomniaStars == "2")
                {
                    pbInsomnia1.Show();
                    pbInsomnia2.Show();
                    pbInsomnia3.Hide();
                    pbInsomnia4.Hide();
                    pbInsomnia5.Hide();
                }
                else if (InsomniaStars == "1")
                {
                    pbInsomnia1.Show();
                    pbInsomnia2.Hide();
                    pbInsomnia3.Hide();
                    pbInsomnia4.Hide();
                    pbInsomnia5.Hide();
                }
                else if (InsomniaStars == "0")
                {
                    pbInsomnia1.Hide();
                    pbInsomnia2.Hide();
                    pbInsomnia3.Hide();
                    pbInsomnia4.Hide();
                    pbInsomnia5.Hide();
                }
                //Gwiazdki NoApetite//////////////////////////////
                String NoApetiteStars = dtbl2.Rows[0]["NoApetite"].ToString();
                if (NoApetiteStars == "5")
                {
                    pbNoApetite1.Show();
                    pbNoApetite2.Show();
                    pbNoApetite3.Show();
                    pbNoApetite4.Show();
                    pbNoApetite5.Show();
                }
                else if (NoApetiteStars == "4")
                {
                    pbNoApetite1.Show();
                    pbNoApetite2.Show();
                    pbNoApetite3.Show();
                    pbNoApetite4.Show();
                    pbNoApetite5.Hide();
                }
                else if (NoApetiteStars == "3")
                {
                    pbNoApetite1.Show();
                    pbNoApetite2.Show();
                    pbNoApetite3.Show();
                    pbNoApetite4.Hide();
                    pbNoApetite5.Hide();
                }
                else if (NoApetiteStars == "2")
                {
                    pbNoApetite1.Show();
                    pbNoApetite2.Show();
                    pbNoApetite3.Hide();
                    pbNoApetite4.Hide();
                    pbNoApetite5.Hide();
                }
                else if (NoApetiteStars == "1")
                {
                    pbNoApetite1.Show();
                    pbNoApetite2.Hide();
                    pbNoApetite3.Hide();
                    pbNoApetite4.Hide();
                    pbNoApetite5.Hide();
                }
                else if (NoApetiteStars == "0")
                {
                    pbNoApetite1.Hide();
                    pbNoApetite2.Hide();
                    pbNoApetite3.Hide();
                    pbNoApetite4.Hide();
                    pbNoApetite5.Hide();
                }
                //Srednia ocena/////////////////////////////////////////////
                string CmdString4 = "SELECT ROUND(AVG(CAST(score AS float)),2) AS AVERAGE FROM Review LEFT JOIN Plant ON Review.PlantID = Plant.PlantID WHERE name=@Parameter1";
                SqlCommand com4 = new SqlCommand(CmdString4, con);
                com4.Parameters.Add(new SqlParameter("Parameter1", lblName.Text));
                SqlDataAdapter sda4 = new SqlDataAdapter(com4);
                DataTable dtbl4 = new DataTable();
                sda4.Fill(dtbl4);
                lblScore.Text = dtbl4.Rows[0]["AVERAGE"].ToString();
                //Reviews///////////////////////////////////////////////
                string CmdString3 = "SELECT users.Name, Comment, Score FROM Review LEFT JOIN Users ON Review.UserID=Users.UserID LEFT JOIN Plant ON Review.PlantID=Plant.PlantID WHERE plant.Name = @Parameter1";
                SqlCommand com3 = new SqlCommand(CmdString3, con);
                com3.Parameters.Add(new SqlParameter("Parameter1", lblName.Text));
                SqlDataAdapter sda3 = new SqlDataAdapter(com3);
                DataTable dtbl3 = new DataTable();
                sda3.Fill(dtbl3);
                dtgReview.DataSource = dtbl3;
            }

            con.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Aromatherapy2;Integrated Security=True");
            string CmdString = "SELECT Name,Breeder FROM Plant ";
            SqlCommand com = new SqlCommand(CmdString, con);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dtgSearch.DataSource = dtbl;
            if(frmLogin.loggedrole=="Admin")
            {
                btnAdminForm.Show();
            }
            con.Close();
        }

        private void dtgSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String clicked = dtgSearch.Rows[e.RowIndex].Cells[0].Value.ToString();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Aromatherapy2;Integrated Security=True");
            string CmdString = "SELECT plant.PlantID,Temperature, Name,Breeder,Relaxed,Happy,Euphoric,Uplifted,Hungry,Energetic,DryEyes,DryMouth,Paranoid,Dizzy,Anxious,Headache,Stress,Anxiety,Pain,Depression,Insomnia,NoApetite FROM Plant LEFT JOIN Feeling ON Plant.PlantID =Feeling.PlantID LEFT JOIN Negative ON Plant.PlantID = Negative.PlantID LEFT JOIN Help ON Plant.PlantID = Help.PlantID WHERE Name=@Parameter1";
            SqlCommand com = new SqlCommand(CmdString, con);
            com.Parameters.Add(new SqlParameter("parameter1", clicked));
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            String name = dtbl.Rows[0]["Name"].ToString();
            lblName.Text = name;
            String breeder = dtbl.Rows[0]["Breeder"].ToString();
            lblBreeder.Text = breeder;
            currentplant = dtbl.Rows[0]["PlantID"].ToString();
            String temp = dtbl.Rows[0]["Temperature"].ToString();
            lblTemperature.Text = temp;

            //Gwiazdki Relaxed///////////////////////////////////////////////////////
            String RelaxedStars = dtbl.Rows[0]["Relaxed"].ToString();
            if(RelaxedStars=="5")
            {
                pbRelaxed1.Show();
                pbRelaxed2.Show();
                pbRelaxed3.Show();
                pbRelaxed4.Show();
                pbRelaxed5.Show();
            }
            else if(RelaxedStars == "4")
            {
                pbRelaxed1.Show();
                pbRelaxed2.Show();
                pbRelaxed3.Show();
                pbRelaxed4.Show();
                pbRelaxed5.Hide();
            }
            else if (RelaxedStars == "3")
            {
                pbRelaxed1.Show();
                pbRelaxed2.Show();
                pbRelaxed3.Show();
                pbRelaxed4.Hide();
                pbRelaxed5.Hide();
            }
            else if (RelaxedStars == "2")
            {
                pbRelaxed1.Show();
                pbRelaxed2.Show();
                pbRelaxed3.Hide();
                pbRelaxed4.Hide();
                pbRelaxed5.Hide();
            }
            else if (RelaxedStars == "1")
            {
                pbRelaxed1.Show();
                pbRelaxed2.Hide();
                pbRelaxed3.Hide();
                pbRelaxed4.Hide();
                pbRelaxed5.Hide();
            }
            else if (RelaxedStars == "0")
            {
                pbRelaxed1.Hide();
                pbRelaxed2.Hide();
                pbRelaxed3.Hide();
                pbRelaxed4.Hide();
                pbRelaxed5.Hide();
            }
            //Gwiazdki Happy//////////////////////////////////////////////////////
            String HappyStars = dtbl.Rows[0]["Happy"].ToString();
            if (RelaxedStars == "5")
            {
                pbHappy1.Show();
                pbHappy2.Show();
                pbHappy3.Show();
                pbHappy4.Show();
                pbHappy5.Show();
            }
            else if (RelaxedStars == "4")
            {
                pbHappy1.Show();
                pbHappy2.Show();
                pbHappy3.Show();
                pbHappy4.Show();
                pbHappy5.Hide();
            }
            else if (RelaxedStars == "3")
            {
                pbHappy1.Show();
                pbHappy2.Show();
                pbHappy3.Show();
                pbHappy4.Hide();
                pbHappy5.Hide();
            }
            else if (RelaxedStars == "2")
            {
                pbHappy1.Show();
                pbHappy2.Show();
                pbHappy3.Hide();
                pbHappy4.Hide();
                pbHappy5.Hide();
            }
            else if (RelaxedStars == "1")
            {
                pbHappy1.Show();
                pbHappy2.Hide();
                pbHappy3.Hide();
                pbHappy4.Hide();
                pbHappy5.Hide();
            }
            else if (RelaxedStars == "0")
            {
                pbHappy1.Hide();
                pbHappy2.Hide();
                pbHappy3.Hide();
                pbHappy4.Hide();
                pbHappy5.Hide();
            }
            //Gwiazdki Euphoric////////////////////////////////////////////////////////////
            String EuphoricStars = dtbl.Rows[0]["Euphoric"].ToString();
            if (EuphoricStars == "5")
            {
                pbEuphoric1.Show();
                pbEuphoric2.Show();
                pbEuphoric3.Show();
                pbEuphoric4.Show();
                pbEuphoric5.Show();
            }
            else if (EuphoricStars == "4")
            {
                pbEuphoric1.Show();
                pbEuphoric2.Show();
                pbEuphoric3.Show();
                pbEuphoric4.Show();
                pbEuphoric5.Hide();
            }
            else if (EuphoricStars == "3")
            {
                pbEuphoric1.Show();
                pbEuphoric2.Show();
                pbEuphoric3.Show();
                pbEuphoric4.Hide();
                pbEuphoric5.Hide();
            }
            else if (EuphoricStars == "2")
            {
                pbEuphoric1.Show();
                pbEuphoric2.Show();
                pbEuphoric3.Hide();
                pbEuphoric4.Hide();
                pbEuphoric5.Hide();
            }
            else if (EuphoricStars == "1")
            {
                pbEuphoric1.Show();
                pbEuphoric2.Hide();
                pbEuphoric3.Show();
                pbEuphoric4.Hide();
                pbEuphoric5.Hide();
            }
            else if (EuphoricStars == "0")
            {
                pbEuphoric1.Hide();
                pbEuphoric2.Hide();
                pbEuphoric3.Show();
                pbEuphoric4.Hide();
                pbEuphoric5.Hide();
            }
            //Gwiazdki Uplifted////////////////////////////////////////////////////////
            String UpliftedStars = dtbl.Rows[0]["Uplifted"].ToString();
            if (UpliftedStars == "5")
            {
                pbUplifted1.Show();
                pbUplifted2.Show();
                pbUplifted3.Show();
                pbUplifted4.Show();
                pbUplifted5.Show();
            }
            else if (UpliftedStars == "4")
            {
                pbUplifted1.Show();
                pbUplifted2.Show();
                pbUplifted3.Show();
                pbUplifted4.Show();
                pbUplifted5.Hide();
            }
            else if (UpliftedStars == "3")
            {
                pbUplifted1.Show();
                pbUplifted2.Show();
                pbUplifted3.Show();
                pbUplifted4.Hide();
                pbUplifted5.Hide();
            }
            else if (UpliftedStars == "2")
            {
                pbUplifted1.Show();
                pbUplifted2.Show();
                pbUplifted3.Hide();
                pbUplifted4.Hide();
                pbUplifted5.Hide();
            }
            else if (UpliftedStars == "1")
            {
                pbUplifted1.Show();
                pbUplifted2.Hide();
                pbUplifted3.Hide();
                pbUplifted4.Hide();
                pbUplifted5.Hide();
            }
            else if (UpliftedStars == "0")
            {
                pbUplifted1.Hide();
                pbUplifted2.Hide();
                pbUplifted3.Hide();
                pbUplifted4.Hide();
                pbUplifted5.Hide();
            }
            //Gwiazdki Hungry////////////////////////////////////////////////////
            String HungryStars = dtbl.Rows[0]["Hungry"].ToString();
            if (HungryStars == "5")
            {
                pbHungry1.Show();
                pbHungry2.Show();
                pbHungry3.Show();
                pbHungry4.Show();
                pbHungry5.Show();
            }
            else if (HungryStars == "4")
            {
                pbHungry1.Show();
                pbHungry2.Show();
                pbHungry3.Show();
                pbHungry4.Show();
                pbHungry5.Hide();
            }
            else if (HungryStars == "3")
            {
                pbHungry1.Show();
                pbHungry2.Show();
                pbHungry3.Show();
                pbHungry4.Hide();
                pbHungry5.Hide();
            }
            else if (HungryStars == "2")
            {
                pbHungry1.Show();
                pbHungry2.Show();
                pbHungry3.Hide();
                pbHungry4.Hide();
                pbHungry5.Hide();
            }
            else if (HungryStars == "1")
            {
                pbHungry1.Show();
                pbHungry2.Hide();
                pbHungry3.Hide();
                pbHungry4.Hide();
                pbHungry5.Hide();
            }
            else if (HungryStars == "0")
            {
                pbHungry1.Hide();
                pbHungry2.Hide();
                pbHungry3.Hide();
                pbHungry4.Hide();
                pbHungry5.Hide();
            }
            //Gwiazdki Energetic///////////////////////////////////////////////
            String EnergeticStars = dtbl.Rows[0]["Energetic"].ToString();
            if (EnergeticStars == "5")
            {
                pbEnergetic1.Show();
                pbEnergetic2.Show();
                pbEnergetic3.Show();
                pbEnergetic4.Show();
                pbEnergetic5.Show();
            }
            else if (EnergeticStars == "4")
            {
                pbEnergetic1.Show();
                pbEnergetic2.Show();
                pbEnergetic3.Show();
                pbEnergetic4.Show();
                pbEnergetic5.Hide();
            }
            else if (EnergeticStars == "3")
            {
                pbEnergetic1.Show();
                pbEnergetic2.Show();
                pbEnergetic3.Show();
                pbEnergetic4.Hide();
                pbEnergetic5.Hide();
            }
            else if (EnergeticStars == "2")
            {
                pbEnergetic1.Show();
                pbEnergetic2.Show();
                pbEnergetic3.Hide();
                pbEnergetic4.Hide();
                pbEnergetic5.Hide();
            }
            else if (EnergeticStars == "1")
            {
                pbEnergetic1.Show();
                pbEnergetic2.Hide();
                pbEnergetic3.Hide();
                pbEnergetic4.Hide();
                pbEnergetic5.Hide();
            }
            else if (EnergeticStars == "0")
            {
                pbEnergetic1.Hide();
                pbEnergetic2.Hide();
                pbEnergetic3.Hide();
                pbEnergetic4.Hide();
                pbEnergetic5.Hide();
            }
            //Gwiazdki DryEyes////////////////////////////////////////////////////
            String DryEyesStars = dtbl.Rows[0]["DryEyes"].ToString();
            if (DryEyesStars == "5")
            {
                pbDryEyes1.Show();
                pbDryEyes2.Show();
                pbDryEyes3.Show();
                pbDryEyes4.Show();
                pbDryEyes5.Show();
            }
            else if (DryEyesStars == "4")
            {
                pbDryEyes1.Show();
                pbDryEyes2.Show();
                pbDryEyes3.Show();
                pbDryEyes4.Show();
                pbDryEyes5.Hide();
            }
            else if (DryEyesStars == "3")
            {
                pbDryEyes1.Show();
                pbDryEyes2.Show();
                pbDryEyes3.Show();
                pbDryEyes4.Hide();
                pbDryEyes5.Hide();
            }
            else if (DryEyesStars == "2")
            {
                pbDryEyes1.Show();
                pbDryEyes2.Show();
                pbDryEyes3.Hide();
                pbDryEyes4.Hide();
                pbDryEyes5.Hide();
            }
            else if (DryEyesStars == "1")
            {
                pbDryEyes1.Show();
                pbDryEyes2.Hide();
                pbDryEyes3.Hide();
                pbDryEyes4.Hide();
                pbDryEyes5.Hide();
            }
            else if (DryEyesStars == "0")
            {
                pbDryEyes1.Hide();
                pbDryEyes2.Hide();
                pbDryEyes3.Hide();
                pbDryEyes4.Hide();
                pbDryEyes5.Hide();
            }
            //Gwiazdki DryMouth////////////////////////////////////////////////////
            String DryMouthStars = dtbl.Rows[0]["DryMouth"].ToString();
            if (DryMouthStars == "5")
            {
                pbDryMouth1.Show();
                pbDryMouth2.Show();
                pbDryMouth3.Show();
                pbDryMouth4.Show();
                pbDryMouth5.Show();
            }
            else if (DryMouthStars == "4")
            {
                pbDryMouth1.Show();
                pbDryMouth2.Show();
                pbDryMouth3.Show();
                pbDryMouth4.Show();
                pbDryMouth5.Hide();
            }
            else if (DryMouthStars == "3")
            {
                pbDryMouth1.Show();
                pbDryMouth2.Show();
                pbDryMouth3.Show();
                pbDryMouth4.Hide();
                pbDryMouth5.Hide();
            }
            else if (DryMouthStars == "2")
            {
                pbDryMouth1.Show();
                pbDryMouth2.Show();
                pbDryMouth3.Hide();
                pbDryMouth4.Hide();
                pbDryMouth5.Hide();
            }
            else if (DryMouthStars == "1")
            {
                pbDryMouth1.Show();
                pbDryMouth2.Hide();
                pbDryMouth3.Hide();
                pbDryMouth4.Hide();
                pbDryMouth5.Hide();
            }
            else if (DryMouthStars == "0")
            {
                pbDryMouth1.Hide();
                pbDryMouth2.Hide();
                pbDryMouth3.Hide();
                pbDryMouth4.Hide();
                pbDryMouth5.Hide();
            }
            //Gwiazdki Paranoid////////////////////////////////////////////////////
            String ParanoidStars = dtbl.Rows[0]["Paranoid"].ToString();
            if (ParanoidStars == "5")
            {
                pbParanoid1.Show();
                pbParanoid2.Show();
                pbParanoid3.Show();
                pbParanoid4.Show();
                pbParanoid5.Show();
            }
            else if (ParanoidStars == "4")
            {
                pbParanoid1.Show();
                pbParanoid2.Show();
                pbParanoid3.Show();
                pbParanoid4.Show();
                pbParanoid5.Hide();
            }
            else if (ParanoidStars == "3")
            {
                pbParanoid1.Show();
                pbParanoid2.Show();
                pbParanoid3.Show();
                pbParanoid4.Hide();
                pbParanoid5.Hide();
            }
            else if (ParanoidStars == "2")
            {
                pbParanoid1.Show();
                pbParanoid2.Show();
                pbParanoid3.Hide();
                pbParanoid4.Hide();
                pbParanoid5.Hide();
            }
            else if (ParanoidStars == "1")
            {
                pbParanoid1.Show();
                pbParanoid2.Hide();
                pbParanoid3.Hide();
                pbParanoid4.Hide();
                pbParanoid5.Hide();
            }
            else if (ParanoidStars == "0")
            {
                pbParanoid1.Hide();
                pbParanoid2.Hide();
                pbParanoid3.Hide();
                pbParanoid4.Hide();
                pbParanoid5.Hide();
            }
            //gwiazdki Dizzy/////////////////////////////////////////////////////////
            String DizzyStars = dtbl.Rows[0]["Dizzy"].ToString();
            if (DizzyStars == "5")
            {
                pbDizzy1.Show();
                pbDizzy2.Show();
                pbDizzy3.Show();
                pbDizzy4.Show();
                pbDizzy5.Show();
            }
            else if (DizzyStars == "4")
            {
                pbDizzy1.Show();
                pbDizzy2.Show();
                pbDizzy3.Show();
                pbDizzy4.Show();
                pbDizzy5.Hide();
            }
            else if (DizzyStars == "3")
            {
                pbDizzy1.Show();
                pbDizzy2.Show();
                pbDizzy3.Show();
                pbDizzy4.Hide();
                pbDizzy5.Hide();
            }
            else if (DizzyStars == "2")
            {
                pbDizzy1.Show();
                pbDizzy2.Show();
                pbDizzy3.Hide();
                pbDizzy4.Hide();
                pbDizzy5.Hide();
            }
            else if (DizzyStars == "1")
            {
                pbDizzy1.Show();
                pbDizzy2.Hide();
                pbDizzy3.Hide();
                pbDizzy4.Hide();
                pbDizzy5.Hide();
            }
            else if (DizzyStars == "0")
            {
                pbDizzy1.Hide();
                pbDizzy2.Hide();
                pbDizzy3.Hide();
                pbDizzy4.Hide();
                pbDizzy5.Hide();
            }
            //Gwiazdki Anxious//////////////////////////////////////////////
            String AnxiousStars = dtbl.Rows[0]["Anxious"].ToString();
            if (AnxiousStars == "5")
            {
                pbAnxious1.Show();
                pbAnxious2.Show();
                pbAnxious3.Show();
                pbAnxious4.Show();
                pbAnxious5.Show();
            }
            else if (AnxiousStars == "4")
            {
                pbAnxious1.Show();
                pbAnxious2.Show();
                pbAnxious3.Show();
                pbAnxious4.Show();
                pbAnxious5.Hide();
            }
            else if (AnxiousStars == "3")
            {
                pbAnxious1.Show();
                pbAnxious2.Show();
                pbAnxious3.Show();
                pbAnxious4.Hide();
                pbAnxious5.Hide();
            }
            else if (AnxiousStars == "2")
            {
                pbAnxious1.Show();
                pbAnxious2.Show();
                pbAnxious3.Hide();
                pbAnxious4.Hide();
                pbAnxious5.Hide();
            }
            else if (AnxiousStars == "1")
            {
                pbAnxious1.Show();
                pbAnxious2.Hide();
                pbAnxious3.Hide();
                pbAnxious4.Hide();
                pbAnxious5.Hide();
            }
            else if (AnxiousStars == "0")
            {
                pbAnxious1.Hide();
                pbAnxious2.Hide();
                pbAnxious3.Hide();
                pbAnxious4.Hide();
                pbAnxious5.Hide();
            }
            //Gwiazdki Headache//////////////////////////////////////////////////
            String HeadacheStars = dtbl.Rows[0]["Headache"].ToString();
            if (HeadacheStars == "5")
            {
                pbHeadache1.Show();
                pbHeadache2.Show();
                pbHeadache3.Show();
                pbHeadache4.Show();
                pbHeadache5.Show();
            }
            else if (HeadacheStars == "4")
            {
                pbHeadache1.Show();
                pbHeadache2.Show();
                pbHeadache3.Show();
                pbHeadache4.Show();
                pbHeadache5.Hide();
            }
            else if (HeadacheStars == "3")
            {
                pbHeadache1.Show();
                pbHeadache2.Show();
                pbHeadache3.Show();
                pbHeadache4.Hide();
                pbHeadache5.Hide();
            }
            else if (HeadacheStars == "2")
            {
                pbHeadache1.Show();
                pbHeadache2.Show();
                pbHeadache3.Hide();
                pbHeadache4.Hide();
                pbHeadache5.Hide();
            }
            else if (HeadacheStars == "1")
            {
                pbHeadache1.Show();
                pbHeadache2.Hide();
                pbHeadache3.Hide();
                pbHeadache4.Hide();
                pbHeadache5.Hide();
            }
            else if (HeadacheStars == "0")
            {
                pbHeadache1.Hide();
                pbHeadache2.Hide();
                pbHeadache3.Hide();
                pbHeadache4.Hide();
                pbHeadache5.Hide();
            }
            //Gwiazdki Stress///////////////////////////////////////
            String StressStars = dtbl.Rows[0]["Stress"].ToString();
            if (StressStars == "5")
            {
                pbStress1.Show();
                pbStress2.Show();
                pbStress3.Show();
                pbStress4.Show();
                pbStress5.Show();
            }
            else if (StressStars == "4")
            {
                pbStress1.Show();
                pbStress2.Show();
                pbStress3.Show();
                pbStress4.Show();
                pbStress5.Hide();
            }
            else if (StressStars == "3")
            {
                pbStress1.Show();
                pbStress2.Show();
                pbStress3.Show();
                pbStress4.Hide();
                pbStress5.Hide();
            }
            else if (StressStars == "2")
            {
                pbStress1.Show();
                pbStress2.Show();
                pbStress3.Hide();
                pbStress4.Hide();
                pbStress5.Hide();
            }
            else if (StressStars == "1")
            {
                pbStress1.Show();
                pbStress2.Hide();
                pbStress3.Hide();
                pbStress4.Hide();
                pbStress5.Hide();
            }
            else if (StressStars == "0")
            {
                pbStress1.Hide();
                pbStress2.Hide();
                pbStress3.Hide();
                pbStress4.Hide();
                pbStress5.Hide();
            }
            //Gwiazdki Anxiety/////////////////////////////////
            String AnxietyStars = dtbl.Rows[0]["Anxiety"].ToString();
            if (AnxietyStars == "5")
            {
                pbAnxiety1.Show();
                pbAnxiety2.Show();
                pbAnxiety3.Show();
                pbAnxiety4.Show();
                pbAnxiety5.Show();
            }
            else if (AnxietyStars == "4")
            {
                pbAnxiety1.Show();
                pbAnxiety2.Show();
                pbAnxiety3.Show();
                pbAnxiety4.Show();
                pbAnxiety5.Hide();
            }
            else if (AnxietyStars == "3")
            {
                pbAnxiety1.Show();
                pbAnxiety2.Show();
                pbAnxiety3.Show();
                pbAnxiety4.Hide();
                pbAnxiety5.Hide();
            }
            else if (AnxietyStars == "2")
            {
                pbAnxiety1.Show();
                pbAnxiety2.Show();
                pbAnxiety3.Hide();
                pbAnxiety4.Hide();
                pbAnxiety5.Hide();
            }
            else if (AnxietyStars == "1")
            {
                pbAnxiety1.Show();
                pbAnxiety2.Hide();
                pbAnxiety3.Hide();
                pbAnxiety4.Hide();
                pbAnxiety5.Hide();
            }
            else if (AnxietyStars == "0")
            {
                pbAnxiety1.Hide();
                pbAnxiety2.Hide();
                pbAnxiety3.Hide();
                pbAnxiety4.Hide();
                pbAnxiety5.Hide();
            }
            //Gwiazdki Pain////////////////////////////////////
            String PainStars = dtbl.Rows[0]["Pain"].ToString();
            if (PainStars == "5")
            {
                pbPain1.Show();
                pbPain2.Show();
                pbPain3.Show();
                pbPain4.Show();
                pbPain5.Show();
            }
            else if (PainStars == "4")
            {
                pbPain1.Show();
                pbPain2.Show();
                pbPain3.Show();
                pbPain4.Show();
                pbPain5.Hide();
            }
            else if (PainStars == "3")
            {
                pbPain1.Show();
                pbPain2.Show();
                pbPain3.Show();
                pbPain4.Hide();
                pbPain5.Hide();
            }
            else if (PainStars == "2")
            {
                pbPain1.Show();
                pbPain2.Show();
                pbPain3.Hide();
                pbPain4.Hide();
                pbPain5.Hide();
            }
            else if (PainStars == "1")
            {
                pbPain1.Show();
                pbPain2.Hide();
                pbPain3.Hide();
                pbPain4.Hide();
                pbPain5.Hide();
            }
            else if (PainStars == "0")
            {
                pbPain1.Hide();
                pbPain2.Hide();
                pbPain3.Hide();
                pbPain4.Hide();
                pbPain5.Hide();
            }
            //Gwiazdki Depression ///////////////////////////////////
            String DepressionStars = dtbl.Rows[0]["Depression"].ToString();
            if (DepressionStars == "5")
            {
                pbDepression1.Show();
                pbDepression2.Show();
                pbDepression3.Show();
                pbDepression4.Show();
                pbDepression5.Show();
            }
            else if (DepressionStars == "4")
            {
                pbDepression1.Show();
                pbDepression2.Show();
                pbDepression3.Show();
                pbDepression4.Show();
                pbDepression5.Hide();
            }
            else if (DepressionStars == "3")
            {
                pbDepression1.Show();
                pbDepression2.Show();
                pbDepression3.Show();
                pbDepression4.Hide();
                pbDepression5.Hide();
            }
            else if (DepressionStars == "2")
            {
                pbDepression1.Show();
                pbDepression2.Show();
                pbDepression3.Hide();
                pbDepression4.Hide();
                pbDepression5.Hide();
            }
            else if (DepressionStars == "1")
            {
                pbDepression1.Show();
                pbDepression2.Hide();
                pbDepression3.Hide();
                pbDepression4.Hide();
                pbDepression5.Hide();
            }
            else if (DepressionStars == "0")
            {
                pbDepression1.Hide();
                pbDepression2.Hide();
                pbDepression3.Hide();
                pbDepression4.Hide();
                pbDepression5.Hide();
            }
            //Gwiazdki Insomnia//////////////////////////////////////
            String InsomniaStars = dtbl.Rows[0]["Insomnia"].ToString();
            if (InsomniaStars == "5")
            {
                pbInsomnia1.Show();
                pbInsomnia2.Show();
                pbInsomnia3.Show();
                pbInsomnia4.Show();
                pbInsomnia5.Show();
            }
            else if (InsomniaStars == "4")
            {
                pbInsomnia1.Show();
                pbInsomnia2.Show();
                pbInsomnia3.Show();
                pbInsomnia4.Show();
                pbInsomnia5.Hide();
            }
            else if (InsomniaStars == "3")
            {
                pbInsomnia1.Show();
                pbInsomnia2.Show();
                pbInsomnia3.Show();
                pbInsomnia4.Hide();
                pbInsomnia5.Hide();
            }
            else if (InsomniaStars == "2")
            {
                pbInsomnia1.Show();
                pbInsomnia2.Show();
                pbInsomnia3.Hide();
                pbInsomnia4.Hide();
                pbInsomnia5.Hide();
            }
            else if (InsomniaStars == "1")
            {
                pbInsomnia1.Show();
                pbInsomnia2.Hide();
                pbInsomnia3.Hide();
                pbInsomnia4.Hide();
                pbInsomnia5.Hide();
            }
            else if (InsomniaStars == "0")
            {
                pbInsomnia1.Hide();
                pbInsomnia2.Hide();
                pbInsomnia3.Hide();
                pbInsomnia4.Hide();
                pbInsomnia5.Hide();
            }
            //Gwiazdki NoApetite//////////////////////////////
            String NoApetiteStars = dtbl.Rows[0]["NoApetite"].ToString();
            if (NoApetiteStars == "5")
            {
                pbNoApetite1.Show();
                pbNoApetite2.Show();
                pbNoApetite3.Show();
                pbNoApetite4.Show();
                pbNoApetite5.Show();
            }
            else if (NoApetiteStars == "4")
            {
                pbNoApetite1.Show();
                pbNoApetite2.Show();
                pbNoApetite3.Show();
                pbNoApetite4.Show();
                pbNoApetite5.Hide();
            }
            else if (NoApetiteStars == "3")
            {
                pbNoApetite1.Show();
                pbNoApetite2.Show();
                pbNoApetite3.Show();
                pbNoApetite4.Hide();
                pbNoApetite5.Hide();
            }
            else if (NoApetiteStars == "2")
            {
                pbNoApetite1.Show();
                pbNoApetite2.Show();
                pbNoApetite3.Hide();
                pbNoApetite4.Hide();
                pbNoApetite5.Hide();
            }
            else if (NoApetiteStars == "1")
            {
                pbNoApetite1.Show();
                pbNoApetite2.Hide();
                pbNoApetite3.Hide();
                pbNoApetite4.Hide();
                pbNoApetite5.Hide();
            }
            else if (NoApetiteStars == "0")
            {
                pbNoApetite1.Hide();
                pbNoApetite2.Hide();
                pbNoApetite3.Hide();
                pbNoApetite4.Hide();
                pbNoApetite5.Hide();
            }
            //Srednia ocena/////////////////////////////////////////////
            string CmdString2 = "SELECT ROUND(AVG(CAST(score AS float)),2) AS AVERAGE FROM Review LEFT JOIN Plant ON Review.PlantID = Plant.PlantID WHERE name=@Parameter1";
            SqlCommand com2 = new SqlCommand(CmdString2, con);
            com2.Parameters.Add(new SqlParameter("Parameter1", lblName.Text));
            SqlDataAdapter sda2 = new SqlDataAdapter(com2);
            DataTable dtbl2 = new DataTable();
            sda2.Fill(dtbl2);
            lblScore.Text = dtbl2.Rows[0]["AVERAGE"].ToString();
            //Reviews///////////////////////////////////////////////
            string CmdString3 = "SELECT users.Name, Comment, Score FROM Review LEFT JOIN Users ON Review.UserID=Users.UserID LEFT JOIN Plant ON Review.PlantID=Plant.PlantID WHERE plant.Name = @Parameter1";
            SqlCommand com3 = new SqlCommand(CmdString3, con);
            com3.Parameters.Add(new SqlParameter("Parameter1", lblName.Text));
            SqlDataAdapter sda3 = new SqlDataAdapter(com3);
            DataTable dtbl3 = new DataTable();
            sda3.Fill(dtbl3);
            dtgReview.DataSource = dtbl3;
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            con.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmitComment_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Aromatherapy2;Integrated Security=True");
            con.Open();
            //Sprawdzenie czy koment tego usera juz istnieje 
            string CmdString2 = "SELECT UserID,PlantID FROM Review WHERE plantID=@Parameter1 AND UserID=@Parameter2";
            SqlCommand com2 = new SqlCommand(CmdString2, con);
            com2.Parameters.Add(new SqlParameter("Parameter1", currentplant));
            com2.Parameters.Add(new SqlParameter("Parameter2", frmLogin.logged));
            SqlDataAdapter sda2 = new SqlDataAdapter(com2);
            DataTable dtbl2 = new DataTable();
            sda2.Fill(dtbl2);
            //Jesli tak edytowanie komentarza
            if (dtbl2.Rows.Count == 1)
            {
                string CmdString4 = "UPDATE Review SET Comment = @Parameter1, Score = @Parameter2 Where UserID = @Parameter3 AND PlantID = @Parameter4";
                SqlCommand com4 = new SqlCommand(CmdString4, con);
                com4.Parameters.Add(new SqlParameter("Parameter4", currentplant));
                com4.Parameters.Add(new SqlParameter("Parameter3", frmLogin.logged));
                com4.Parameters.Add(new SqlParameter("Parameter2", cbScore.Text));
                com4.Parameters.Add(new SqlParameter("Parameter1", txtComment.Text));
                com4.ExecuteNonQuery();
                MessageBox.Show("Review Edited");
            }
            else
            //Dodawanie Komentarza
            {

                string CmdString = "INSERT INTO Review (PlantID,UserID,Score,Comment) VALUES (@Parameter1,@Parameter2,@Parameter3,@Parameter4)";
                SqlCommand com = new SqlCommand(CmdString, con);
                com.Parameters.Add(new SqlParameter("Parameter1", currentplant));
                com.Parameters.Add(new SqlParameter("Parameter2", frmLogin.logged));
                com.Parameters.Add(new SqlParameter("Parameter3", cbScore.Text));
                com.Parameters.Add(new SqlParameter("Parameter4", txtComment.Text));               
                SqlDataAdapter sda = new SqlDataAdapter(com);
                com.ExecuteNonQuery();
                MessageBox.Show("Review added");
            }
            //Odswiezanie komentarzy
            string CmdString3 = "SELECT users.Name, Comment, Score FROM Review LEFT JOIN Users ON Review.UserID=Users.UserID LEFT JOIN Plant ON Review.PlantID=Plant.PlantID WHERE plant.Name = @Parameter1";
            SqlCommand com3 = new SqlCommand(CmdString3, con);
            com3.Parameters.Add(new SqlParameter("Parameter1", lblName.Text));
            SqlDataAdapter sda3 = new SqlDataAdapter(com3);
            DataTable dtbl3 = new DataTable();
            sda3.Fill(dtbl3);
            dtgReview.DataSource = dtbl3;           
            con.Close();
        }

        private void txtComment_Enter(object sender, EventArgs e)
        {
            if(txtComment.Text == "Write your comment (max 400 signs)")
            {
                txtComment.Text = "";
            }
        }

        private void btnAdminForm_Click(object sender, EventArgs e)
        {
            if (frmLogin.loggedrole == "Admin")
            { 
                frmAdmin objfrmAdmin = new frmAdmin();
                this.Hide();
                objfrmAdmin.Show();
            }

        }
    }
}
