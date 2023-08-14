﻿using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

          //Declaracion de variables de tipo texto

          string? textoCadena="";
          string? primerNombre="Wilfredo";
          string? primerApellido="Portillo";

          //Declaracion de variables de tipo date

          DateTime fechaActual = DateTime.Now;

          DateTime fechaEspecifica = new DateTime(2023, 8, 13, 1, 45, 0);

          //CAPTURAR EL VALOR DE CADENA DE TEXTO

          Console.Write("\n\n*******************************************************\n");
          Console.Write("\n ---- Captura de datos tipo texto ---");
          Console.Write("\n ---- Ingresar valor de tipo texto >>>> ");
          textoCadena=Convert.ToString(Console.ReadLine());
          Console.Write("\n\n****************************************************\n\n");

          //APLICACION DE FUNCIONES DE CADENA

          //Funcion de minuscula

          string? funcionMinuscula = textoCadena.ToLower();

          //Funcion de mayuscula

          string? funcionMayuscula = textoCadena.ToUpper();

          //Funcion de tamaño de cadena
          int longitudCadena=textoCadena.Length; 

          //Funcion de concatenado
          string? cadenaConcatenada= primerNombre + " " + primerApellido; 

          //funcion de comparar
          bool compararVaria= primerNombre.Equals(primerApellido);

          //APLICACION DE FUNCIONES PARA FECHA

          int dia= fechaEspecifica.Day; 
          int mes= fechaEspecifica.Month; 
          int año= fechaEspecifica.Year;

          //Funcion para formatear fecha
          string? fechaFormateda= fechaEspecifica.ToString("dd/MM/yyyy"); 
          
          //Funcion para adicionar o restar dias,horas a una fecha
          DateTime fechaSumada= fechaActual.AddDays(1);
          DateTime fechaSumada2= fechaEspecifica.AddDays(2);

          //Funcion para comparar fechas
          
          bool fechasIguales= fechaActual == fechaEspecifica; 
          bool fechaActual1= fechaActual > fechaEspecifica; 
          bool fechaEspecifica1= fechaActual < fechaEspecifica;

          //IMPRESION DE LOS RESULTADO

          //Impresion de funciones de cadena de textos

          Console.Write("\n\n******************************************************\n\n");
          Console.Write("\n------- IMPRESION DE FUNCIONES DE CADENA ---------" );
          Console.Write("\n----Texto Ingresado en cosola >>>> " + textoCadena);
          Console.Write("\n----Funcion en minusculas >>>> " + funcionMinuscula);
          Console.Write("\n----Funcion en mayuscula >>>> " + funcionMayuscula);
          Console.Write("\n----Funcion de tamaño de cadena >>>> " + longitudCadena);
          Console.Write("\n----Funcion de concatenado >>>> " + cadenaConcatenada);
          Console.Write("\n----Funcion de comparacion >>>> " + compararVaria);
          Console.Write("\n---------- FIN DE IMPRESION DE CADENAS ----------\n");
          Console.Write("\n\n******************************************************\n\n");

          //Impresion de funciones de fecha

          Console.Write("\n\n******************************************************\n\n");
          Console.Write("\n------- IMPRESION DE FUNCIONES DE FECHA -------" );
          Console.Write("\n----Fecha actual >>>> " + fechaActual);
          Console.Write("\n----Fecha Especifica formateada >>>> " + fechaFormateda);
          Console.Write("\n----Fecha actual + suma de 1 dias >>>> " + fechaSumada);
          Console.Write("\n----Fecha especifica + suma de 2 dias >>>> " + fechaSumada2);
          Console.Write("\n----Fechas iguales >>>> " + fechasIguales);
          Console.Write("\n----Fecha actual mayor >>>> " + fechaActual1);
          Console.Write("\n----Fecha especifica menor >>>> " + fechaEspecifica1);
          Console.Write("\n---------- FIN DE IMPRESION DE FECHA -----------\n");
          Console.Write("\n\n******************************************************\n\n");
          

          //U20230820 WILFREDO PORTILLO VILLALTA

          //AUTOEVALUACION 9 DE 10.


        }
    }
}