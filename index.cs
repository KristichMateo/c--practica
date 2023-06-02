using System;
using modelo_auto;  //namespace del otro modulo
using Camionetamodel;
using ConexionDB;
using Tablas;

namespace Index
{
    class Programa
    {
        static void Main(){
            Auto pulse = new Auto("fiat Pulse", 4, 500);
            pulse.Restar_Asientos(1);
            System.Console.WriteLine(pulse.marca);
            Camioneta hilux = new Camioneta(true);
            hilux.Mostrar_Datos();
            List<Auto> toyota = new List<Auto> {new Auto("Hilux",6,900),new Auto("SW4",5,880)}; //lista de objetos, tipo de dato el nombre de la clase, instancio los objetos dentro de {}
            toyota.Add(new Auto("palio",4,800));
            toyota.Add(new Camioneta (true));
            foreach (var item in toyota)
            {
                System.Console.WriteLine(item.marca + "la marca es");
                System.Console.WriteLine(item.precio + "su precio es");
            }
           Conexion con = new Conexion();
           con.Conectar();

        }
    }
}