using System;
using System.Collections.Generic;
using System.Text;
namespace prueba_Interfaz
{
    interface Icualquiernombre      //Defino interfaz con Inombre_interfaz
    {
        public bool cuatroxcuatro {get;set;}    //todos los atributos que DEBE tener una clase para pasar la interfaz
        public void mostrar_4x4(){
            System.Console.WriteLine(this.cuatroxcuatro);
        }
    }
}