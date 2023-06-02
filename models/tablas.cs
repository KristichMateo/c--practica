using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text;
using MySql;
using ConexionDB;
namespace Tablas
{
    class Tabla_auto      
    {
    public void Crear_Tablas(){
        Conexion conexion = new Conexion();
        string query = "SELECT * FROM autos";
        MySqlCommand comando = new MySqlCommand(query, conexion.Conectar());
    }
    
}
}