using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text;
using MySql;
namespace ConexionDB
{
    class Conexion      
    {
      private MySqlConnection conex = new MySqlConnection();
      static string servidor ="localhost";
      static string BD ="Csharp";
      static string usuario ="root";
      static string puerto = "3306";
      static string contra = "root";
      static string Cadena_Conexion = "server=localhost;port=3306;user id=root;password=root;database=Csharp;";
    public MySql.Data.MySqlClient.MySqlConnection Conectar(){
        try{
            conex.ConnectionString = Cadena_Conexion;
            conex.Open();
            Conexion conexion = new Conexion();
            string query = "SELECT * FROM autos";
            MySqlCommand comando = new MySqlCommand(query,conex);
            System.Console.WriteLine("Se conecto");
            System.Console.WriteLine(conex);
            return conex;

        }
        catch(MySqlException e){
            conex.ConnectionString = Cadena_Conexion;
            conex.Open();
            Conexion conexion = new Conexion();
            string query = "SELECT * FROM autos";
            MySqlCommand comando = new MySqlCommand(query,conex);
            System.Console.WriteLine("Se conecto");
            return conex;
            System.Console.WriteLine("algo fallo"+e.ToString());
            return conex;
        }
    }
  
}
}