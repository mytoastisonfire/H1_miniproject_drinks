using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;

namespace Drinks
{
    public partial class Form1 : Form
    {
        static string[] combination = new string[8];

        public Form1()
        {
            InitializeComponent();
        }
        #region GUI
        private static void buttonGetDrinks_Click(object sender, EventArgs e)
        {

        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
        #endregion GUI

        #region Logic
        private static void AlcoholLogic(CheckedListBox listAlcohol)
        {
            MessageBox.Show(listAlcohol.CheckedItems.ToString());
            string selectedAlcohol = "";
            if (listAlcohol.CheckedItems.Count == 0)
            {
                listAlcohol.SetItemCheckState(0, CheckState.Checked);
            }
            for (int x = 0; x < listAlcohol.CheckedItems.Count; x++)
            {
                
            }
            MessageBox.Show(selectedAlcohol);
            combination = selectedAlcohol.Split(',');
        }

        private static void LiquorLogic(CheckedListBox listLiquor)
        {
            string selectedLiquor = "";
            if (listLiquor.CheckedItems.Count == 0)
            {
                listLiquor.SetItemCheckState(0, CheckState.Checked);
            }
            for (int x = 0; x < listLiquor.Items.Count; x++)
            {
                
            }
            MessageBox.Show(selectedLiquor);
            combination = selectedLiquor.Split(",");
        }

        private static void SyrupLogic(CheckedListBox listSyrup)
        {
            string selectedSyrup = "";
            if (listSyrup.CheckedItems.Count == 0)
            {
                listSyrup.SetItemCheckState(0, CheckState.Checked);
            }
            for (int x = 0; x < listSyrup.CheckedItems.Count; x++)
            {
                selectedSyrup = selectedSyrup + listSyrup.CheckedItems[x];
            }
            MessageBox.Show(selectedSyrup);
            combination = selectedSyrup.Split(",");
        }

        private static void SoftDrinkLogic(CheckedListBox listSoft_Drink)
        {
            string selectedSoft_Drink = "";
            if (listSoft_Drink.CheckedItems.Count == 0)
            {
                listSoft_Drink.SetItemCheckState(0, CheckState.Checked);
            }
            for (int x = 0; x < listSoft_Drink.CheckedItems.Count; x++)
            {
                selectedSoft_Drink = selectedSoft_Drink + "Checked item " + (x + 1).ToString() + " = " + listSoft_Drink.CheckedItems[x].ToString() + "\n";
            }
            MessageBox.Show(selectedSoft_Drink);
            combination = selectedSoft_Drink.Split(",");
        }

        private static void JuiceLogic(CheckedListBox listJuice)
        {
            string selectedJuice = "";
            if (listJuice.CheckedItems.Count == 0)
            {
                listJuice.SetItemCheckState(0, CheckState.Checked);
            }
            for (int x = 0; x < listJuice.CheckedItems.Count; x++)
            {
                selectedJuice = selectedJuice + "Checked item " + (x + 1).ToString() + " = " + listJuice.CheckedItems[x].ToString() + "\n";
            }
            MessageBox.Show(selectedJuice);
            combination = selectedJuice.Split(",");
        }

        private static void FruitGreenLogic(CheckedListBox listFruit_Green)
        {
            string selectedFruit_Green = "";
            if (listFruit_Green.CheckedItems.Count == 0)
            {
                listFruit_Green.SetItemCheckState(0, CheckState.Checked);
            }
            for (int x = 0; x < listFruit_Green.CheckedItems.Count; x++)
            {
                selectedFruit_Green = selectedFruit_Green + "Checked item " + (x + 1).ToString() + " = " + listFruit_Green.CheckedItems[x].ToString() + "\n";
            }
            MessageBox.Show(selectedFruit_Green);
            combination = selectedFruit_Green.Split(',');
        }

        private static void ExtrasLogic(CheckedListBox listExtras)
        {
            string selectedExtras = "";
            if (listExtras.CheckedItems.Count == 0)
            {
                listExtras.SetItemCheckState(0, CheckState.Checked);
            }
            for (int x = 0; x < listExtras.CheckedItems.Count; x++)
            {
                selectedExtras = selectedExtras + "Checked item " + (x + 1).ToString() + " = " + listExtras.CheckedItems[x].ToString() + "\n";
            }
            MessageBox.Show(selectedExtras);
            combination = selectedExtras.Split(",");
        }

        private static void IceCubesLogic(CheckedListBox listIceCubes)
        {
            string selectedIceCubes = "";
            if (listIceCubes.CheckedItems.Count == 0)
            {
                listIceCubes.SetItemCheckState(0, CheckState.Checked);
            }
            for (int x = 0; x < listIceCubes.CheckedItems.Count; x++)
            {
                selectedIceCubes = selectedIceCubes + "Checked item " + (x + 1).ToString() + " = " + listIceCubes.CheckedItems[x].ToString() + "\n";
            }
            MessageBox.Show(selectedIceCubes);
            
        }

        private static CheckedListBox.CheckedItemCollection GetCheckedItems(CheckedListBox listAlcohol)
        {
            return listAlcohol.CheckedItems;
        }
        #endregion Logic

        #region DAL
        private static string[] DAL()
        {
            string[] alcohol = GetAlcohol();
            return alcohol;
        }
        private static string[] GetAlcohol()
        {
            //Connecting to database
            string connectionString = "Server=ZBC-S-MATI7077\\MSSQLSERVER01;Database=Drinks;User Id = MKC; Password=MKC";
            string queryString = "SELECT COUNT(*) AS count FROM dbo.Alcohol";
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        count = reader.GetInt32("count");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            //Getting the names of different alcohol
            queryString = "SELECT AlcoholName FROM dbo.Alcohol";
            string[] alcohol = new string[count];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    int i = 0;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        alcohol[i] = reader.GetString(0);
                        i++;
                    }
                    return alcohol;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return null;
        }
        private static string[] GetLiquor()
        {
            string connectionString = "Server=ZBC-S-MATI7077\\MSSQLSERVER01;Database=Drinks;User Id = MKC; Password=MKC";
            string queryString = "SELECT COUNT(*) AS count FROM dbo.Liquor";
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        count = reader.GetInt32("count");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            queryString = "SELECT LiquorName FROM dbo.Liquor";
            string[] liquor = new string[count];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    int i = 0;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        liquor[i] = reader.GetString(0);
                        i++;
                    }
                    return liquor;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return null;
        }
        private static string[] GetSyrup()
        {
            string connectionString = "Server=ZBC-S-MATI7077\\MSSQLSERVER01;Database=Drinks;User Id = MKC; Password=MKC";
            string queryString = "SELECT COUNT(*) AS count FROM dbo.Syrup";
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        count = reader.GetInt32("count");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            queryString = "SELECT SyrupName FROM dbo.Syrup";
            string[] syrup = new string[count];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    int i = 0;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        syrup[i] = reader.GetString(0);
                        i++;
                    }
                    return syrup;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return null;
        }
        private static string[] GetSoftDrink()
        {
            string connectionString = "Server=ZBC-S-MATI7077\\MSSQLSERVER01;Database=Drinks;User Id = MKC; Password=MKC";
            string queryString = "SELECT COUNT(*) AS count FROM dbo.SoftDrink";
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        count = reader.GetInt32("count");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            queryString = "SELECT SoftDrinkName FROM dbo.SoftDrink";
            string[] softDrink = new string[count];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    int i = 0;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        softDrink[i] = reader.GetString(0);
                        i++;
                    }
                    return softDrink;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return null;
        }
        private static string[] GetJuice()
        {
            string connectionString = "Server=ZBC-S-MATI7077\\MSSQLSERVER01;Database=Drinks;User Id = MKC; Password=MKC";
            string queryString = "SELECT COUNT(*) AS count FROM dbo.Juice";
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        count = reader.GetInt32("count");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            queryString = "SELECT JuiceName FROM dbo.Juice";
            string[] juice = new string[count];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    int i = 0;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        juice[i] = reader.GetString(0);
                        i++;
                    }
                    return juice;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return null;
        }
        private static string[] GetFruitAndGreen()
        {
            string connectionString = "Server=ZBC-S-MATI7077\\MSSQLSERVER01;Database=Drinks;User Id = MKC; Password=MKC";
            string queryString = "SELECT COUNT(*) AS count FROM dbo.FruitAndGreen";
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        count = reader.GetInt32("count");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            queryString = "SELECT FruitAndGreenName FROM dbo.FruitAndGreen";
            string[] fruitGreen = new string[count];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    int i = 0;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        fruitGreen[i] = reader.GetString(0);
                        i++;
                    }
                    return fruitGreen;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return null;
        }
        private static string[] GetExtras()
        {
            string connectionString = "Server=ZBC-S-MATI7077\\MSSQLSERVER01;Database=Drinks;User Id = MKC; Password=MKC";
            string queryString = "SELECT COUNT(*) AS count FROM dbo.Ingredients";
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        count = reader.GetInt32("count");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            queryString = "SELECT IngredientName FROM dbo.Ingredients";
            string[] extras = new string[count];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    int i = 0;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        extras[i] = reader.GetString(0);
                        i++;
                    }
                    return extras;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return null;
        }
        private static string[] GetIce()
        {
            string connectionString = "Server=ZBC-S-MATI7077\\MSSQLSERVER01;Database=Drinks;User Id = MKC; Password=MKC";
            string queryString = "SELECT COUNT(*) AS count FROM dbo.IceTypes";
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        count = reader.GetInt32("count");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            queryString = "SELECT IceType FROM dbo.IceTypes";
            string[] iceTypes = new string[count];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    int i = 0;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        iceTypes[i] = reader.GetString(0);
                        i++;
                    }
                    return iceTypes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return null;
        }
        private static void GetCombinations()
        {
            string connectionString = "Server=ZBC-S-MATI7077\\MSSQLSERVER01;Database=Drinks;User Id = MKC; Password=MKC";
            string queryString = "SELECT COUNT(*) AS count FROM dbo.Combinations";
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        count = reader.GetInt32("count");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            MessageBox.Show(combination[0]);
            queryString = "SELECT combinationID FROM dbo.Combinations WHERE dbo.AlcoholID = " + combination[0].ToString();
            string[] iceTypes = new string[count];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    int i = 0;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        iceTypes[i] = reader.GetString(0);
                        i++;
                    }
                    //return iceTypes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        #endregion DAL


        private void Form1_Load(object sender, EventArgs e)
        {
            listAlcohol.Items.Clear();
           /* listLiquor.Items.Clear();
            listSyrup.Items.Clear();
            listSoft_Drink.Items.Clear();
            listJuice.Items.Clear();
            listFruit_Green.Items.Clear();
            listExtras.Items.Clear();
            */listIceCubes.Items.Clear();
            string[] alcohol = GetAlcohol();
            listAlcohol.Items.AddRange(alcohol);
            /*string[] liquor = GetLiquor();
            listLiquor.Items.AddRange(liquor);
            string[] syrup = GetSyrup();
            listSyrup.Items.AddRange(syrup);
            string[] softDrink = GetSoftDrink();
            listSoft_Drink.Items.AddRange(softDrink);
            string[] juice = GetJuice();
            listJuice.Items.AddRange(juice);
            string[] fruitGreen = GetFruitAndGreen();
            listFruit_Green.Items.AddRange(fruitGreen);
            string[] extras = GetExtras();
            listExtras.Items.AddRange(extras);
            string[] iceTypes = GetIce();
            listIceCubes.Items.AddRange(iceTypes);
        */}

        private void buttonGetDrinks_Click_1(object sender, EventArgs e)
        {
            AlcoholLogic(listAlcohol);
            /*LiquorLogic(listLiquor);
            SyrupLogic(listSyrup);
            SoftDrinkLogic(listSoft_Drink);
            JuiceLogic(listJuice);
            FruitGreenLogic(listFruit_Green);
            ExtrasLogic(listExtras);
            IceCubesLogic(listIceCubes);
            */GetCombinations();
        }
    }
}