using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WorldData;

namespace WorldData.Models
{
    public class Country
    {
        private int _id;
        private string _name;
        private string _region;
        private int _population;
        private float _gnp;
        private float _lifeExpectancy;

        public Country(int Id, string Name, string Region, int Population, float GNP, float LifeExpectancy)
        {
            _id = Id;
            _name = Name;
            _region = Region;
            _population = Population;
            _gnp = GNP;
            _lifeExpectancy = LifeExpectancy;

        }
        public int GetId()
        {
          return _id;
        }

        public string GetName()
        {
           return _name;
        }

        public string GetRegion()
        {
          return _region;
        }
        public int GetPopulation()
        {
           return _population;
        }
        public float GetGNP()
        {
           return _gnp;
        }
        public float GetLifeExpectancy()
        {
           return _lifeExpectancy;
        }

        public static List<Country> GetAll()
        {
          List<Country> allCountries = new List<Country> {};
          MySqlConnection conn = DB.Connection();
          conn.Open();
          MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
          cmd.CommandText = @"SELECT Id, Name, Region, Population, GNP, LifeExpectancy FROM country;";
          MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
          while(rdr.Read())
          {
            int Id = rdr.GetInt32(0);
            string Name = rdr.GetString(1);
            string Region = rdr.GetString(2);
            int Population = rdr.GetInt32(3);
            float GNP = rdr.GetFloat(4);
            float LifeExpectancy = rdr.GetFloat(5);
            Country newCountry = new Country(Id, Name, Region, Population, GNP, LifeExpectancy);
            allCountries.Add(newCountry);
          }
          conn.Close();
          if(conn != null)
          {
            conn.Dispose();
          }
          return allCountries;
        }

        public static List<Country> GetSome(int userInput, string userOrder)
        {
          List<Country> allCountries = new List<Country> {};
          MySqlConnection conn = DB.Connection();
          conn.Open();
          MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
          cmd.CommandText = @"SELECT Id, Name, Region, Population, GNP, LifeExpectancy FROM country WHERE LifeExpectancy <=" + userInput + " ORDER BY LifeExpectancy " + userOrder + ";";
          MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader; 
          while(rdr.Read())
          {
            int Id = rdr.GetInt32(0);
            string Name = rdr.GetString(1);
            string Region = rdr.GetString(2);
            int Population = rdr.GetInt32(3);
            float GNP = rdr.GetFloat(4);
            float LifeExpectancy = rdr.GetFloat(5);
            Country newCountry = new Country(Id, Name, Region, Population, GNP, LifeExpectancy);
            allCountries.Add(newCountry);
          }
          conn.Close();
          if(conn != null)
          {
            conn.Dispose();
          }
          return allCountries;
        }

      }


}
