using System;
using modelo_auto;
using prueba_Interfaz;
namespace Camionetamodel
{
    class Camioneta: Auto, Icualquiernombre  //clase:padre para indicar que herede
    {
        public bool cuatroxcuatro {get;set;}
        public  Camioneta(bool cuatroxcuatro): base("Toyota Hilux",5,600){    //inizializo clase, base() hace referencai al contructor del padre
            this.cuatroxcuatro = cuatroxcuatro;                                           //TENGO que pasar atributos del contructor del padre        
        }
        public void Mostrar_Datos(){
            System.Console.WriteLine(this.marca);
            System.Console.WriteLine(this.asientos);
            int[] arreglo = new int[10] {1,2,3,4,5,6,7,8,9,10}; //defino   especificando tipo de dato, new data_type[longitud] {valores por defecto}
            List<int> lista = new List<int>() {1,2,6,2,4,1,7};
            System.Console.WriteLine(lista);
            foreach (var item in arreglo)
            {
                System.Console.WriteLine("este elemento es"+arreglo);
            }
        }   
    }
}