// using System;
// using System.Collections.Generic;
// using MySql.Data.MySqlClient;
// using WorldData;
//
// namespace WorldData.Models
// {
//     public class City
//     {
//         private int _id;
//         private string _name;
//         private string _country;
//         private int _population;
//
//         public City(int Id, string Name, string Country, int Population)
//         {
//           _id = Id;
//           _name = Name;
//           _country = Country;
//           _population = Population;
//         }
//
//         public int GetId()
//         {
//           return _id;
//         }
//
//         public string GetName()
//         {
//           return _name;
//         }
//
//         public string GetCountry()
//         {
//           return _country;
//         }
//
//         public int GetPopulation()
//         {
//           return _population;
//         }
//
//         public static List<City> GetSome(string userFilter, string userOrder)
//         {
//           List<City> allCities = new List<City> {};
//           MySqlConnection conn = DB.Connection();
//           conn.Open();
//           MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
//           cmd.CommandText = @" SELECT Id, Name, CountryCode, Population FROM city ORDER BY " + userFilter + " " + userOrder + " ;";
//           MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
//           while(rdr.Read())
//           {
//             int Id = rdr.GetInt32(0);
//             string Name = rdr.GetString(1);
//             string CountryCode = rdr.GetString(2);
//             int Population = rdr.GetInt32(3);
//             City newCity = new City(Id, Name, CountryCode, Population);
//             allCities.Add(newCity);
//           }
//           conn.Close();
//           if(conn != null)
//           {
//             conn.Dispose();
//           }
//           return allCities;
//
//         }
//     }
//
//
//
// }
