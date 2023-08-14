using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declaracion de Variables de tipo texto

            string? textoCadena = " ";
            string? textoCadena2 = " ";
            string? primerNombre = "Wilfredo";
            
            //Declaracion de variables de tipo date 
            
            DateTime fechaActual = DateTime.Now;
            DateTime fechaEspecifica = new DateTime (2023, 8, 5, 10,30,0);

            //Capturar el valor de la cadena de texto.

            Console.Write("\n\n *******************************************************************************\n");
            Console.Write("\n ---  Captura de datos tipo texto ---");
            Console.Write("\n---  Ingrese un valor de tipo texto >>> ");
            textoCadena=Convert.ToString(Console.ReadLine());
            Console.Write("\n---  Ingrese otro o el mismo valor de tipo texto >>> ");
            textoCadena2=Convert.ToString(Console.ReadLine());
            Console.Write("\n *********************************************************************************\n");


            //APLICACION DE FUNCIONES DE CADENA

            //Funcion de comparacion cadenas de texto
            bool cadenaComparativa= textoCadena == textoCadena2;

            //Funcion de Minuscula
            string? funcionMinuscula = textoCadena.ToLower();

            //Funcion de Mayuscula
            string? funcionMayuscula = textoCadena.ToUpper();

            //Funcion de Concatenado
            string? cadenaConcatenada = primerNombre + " " + textoCadena;

            //Funcion de tamaño de cadena
            int llongitudCadena=textoCadena.Length;

            //APPLICACION DE FUNCIONES PARA FECHA

            int dia = fechaEspecifica.Day;
            int mes = fechaEspecifica.Month;
            int hora = fechaEspecifica.Hour;

            //Funcion para adicionar o restar dias, horas a una fecha
            DateTime fechaSumada= fechaActual.AddDays(3);
            DateTime fechaHora= fechaActual.AddHours(-2);

            //Funcion para formatiar una fecha
            string fechaFormateada= fechaEspecifica.ToString(" dd/mm/yyyy");

            //Funcion para comparar fechas
            int comparacionFechas = DateTime.Compare(fechaActual, fechaEspecifica);
            bool esFechaActualMayorQueEspecifica = comparacionFechas > 0;
            bool esFechaActualIgualAEspecifica = comparacionFechas == 0;
            bool esFechaActualMenorQueEspecifica = comparacionFechas < 0;

            //IMPRESION DE LOS RESULTADOS

            //Impresion de funciones de cadenas de texto
            Console.Write("\n\n\n*******************************************************************************");
            Console.Write("\n------------------------IMPRESION DE FUNCIONES DE CADENA---------------------------");
            Console.Write("\n--Texto ingresado en consola >>> " + textoCadena);
            Console.Write("\n--Funcion de minuscula >>> " + funcionMinuscula);
            Console.Write("\n--Funcion de Mayuscula >>> " + funcionMayuscula);
            Console.Write("\n--Funcion de concatenado >>> " + cadenaConcatenada);
            Console.Write("\n--Funcion de comparar 2 cadenas >>> " + cadenaComparativa + " " + textoCadena + " " + textoCadena2);
            Console.Write("\n--Funcion de tamaño de cadena >>> " + llongitudCadena);
            Console.Write("\n-------------------- FIN DE IMPRESION DE FUNCIONES DE CADENA ----------------------\n");
            Console.Write("***************************************************************************************");
           
            //Impresion de funciones de fecha
            Console.Write("\n\n\n********************************************************************************");
            Console.Write("\n-------------------------IMPRESION DE FUNCIONES DE FECHA----------------------------");
            Console.Write("\n--Fecha Actual >>> " + fechaActual);
            Console.Write("\n--Fecha Especifica >>> " + fechaEspecifica);
            Console.Write("\n--Fecha Especifica Dia >>> " + dia);
            Console.Write("\n--Fecha Especifica Mes >>> " + mes);
            Console.Write("\n--Fecha Especifica Hora >>> " + hora);
            Console.Write("\n--Fecha Actual + Suma de 3 dias >>> " + fechaSumada);
            Console.Write("\n--Fecha Actual - 2 horas >>> " + fechaHora);
            Console.Write("\n--Fecha Especifica formateada >>> " + fechaFormateada);
            Console.Write("\n--Fecha comparada Iguales o no>>> " + esFechaActualIgualAEspecifica);
            Console.Write("\n--Fecha comparada mayor o no>>> " + esFechaActualMayorQueEspecifica);
            Console.Write("\n--Fecha comparada menor o no>>> " +  esFechaActualMenorQueEspecifica);
            Console.Write("\n-------------------- FIN DE IMPRESION DE FUNCIONES DE FECHA ----------------------\n");
            Console.Write("**************************************************************************************");      

            //U202300820 WILFREDO PORTILLO VILLALTA
            //AUTOEVALUACION 9 DE 10


        }
    }
}