using System;
namespace calcularHora
{
    public class Funcionario
    {
        
        private int hora;
        public int Hora{
            get{return hora;}
            set{hora = value;}
        }
        private float salario;
        private int sPorHORA = 40;
          public int SPorHora{
            get{return sPorHORA;}
            set{sPorHORA = value;}
            }

        public float CalcularHoras(){
        return ( hora * sPorHORA); 
        }

    }
}