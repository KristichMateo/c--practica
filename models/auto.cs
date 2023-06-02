using System;
namespace modelo_auto   //usado para llamar este modulo
{
    class Auto
    {
        public int precio {get; set;}
        public string marca{get; set;} //atributo string ambos publicos

        public int asientos{get; set;} //atributo entero
        public Auto(string marca, int asientos, int precio){        //Constructor lleva el mismo nombre
            this.marca = marca;                     //Inicializo atributo, this hace referencia a esta clase.atributo
            this.asientos = asientos;   
            this.precio = precio;           
        }
        public void Restar_Asientos (int asientos_restar){  //defino metodo
            this.asientos -= asientos_restar;       //manipulo atributo en el metodo
            System.Console.WriteLine(asientos);
        }           
    }
}