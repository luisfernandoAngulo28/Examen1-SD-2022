﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cApp
{
    public class clsSpar
    {
         /*ATRIBUTOS*/
       
        const int Max=1000;                         // Maxima Cantidad de elementos en el arreglo V alternativo
        public int[,] V = new int[Max,3];           // Vector donde se almacena los datos de las Matris A original
        public int Cant = 0;                        // Cantidad de celdas llenas en el vector V
        public int m = 0;                           // Cantidad de columnas de la Matriz A original
        public int n = 0;                           // Cantidad de filas de la Matriz A original
     

        /*CONSTRUCTORES*/
        public clsSpar() 
        { 
            Cant = 0;
            n= 0;
            m = 0;
            int i = 0;
            while (i < Max)
            {
               V[i, 0] = 0;
               V[i, 1] = 0;
               V[i, 2] = 0;  
               i++;
            }
        }
        
        public clsSpar(clsSpar x)
        {
            Cant = x.Cant;
            n = x.n;
            m = x.m;
            int i = 0;  
            while (i < Max)
            {
               V[i, 0] = x.V[i, 0];
               V[i, 1] = x.V[i, 1];
               V[i, 2] = x.V[i, 2];
               i++;
            }
        }

        // Limpiar el Arreglo V 
        public void ClearArreglo()
        {
            int i = 0; Cant = 0;
            while (i < Max)
            {
                V[i, 0] = 0;
                V[i, 1] = 0;
                V[i, 2] = 0;  
                i++;
            }
        }
     
        // Funcion para mostrar la Matriz A 
        public string MostraArreglo(int[,] M)
        {
            int i, j = 0;
            string cad = "";
            for (i = 0; i < n; i++)
            {
                cad += "\n";
                for (j = 0; j < m; j++)
                    cad += "[" + M[i, j] + "]";
            }
            return cad;
        }


 	// Funcion para mostrar Vector V 
        public string MostrarVector()
        {
            string s = "";
            
            for (int i = 0; i < Cant; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                s += " [" + V[i,j] + "]" ; 
                }
                s += "\n";
            }
            return s;
        }





        //Escriba AQUI las funciones solictadas
        //
        public clsSpar CopyAtoV(int[,] A)
        {
           
            clsSpar S = new clsSpar();
            





            return S;
        }
   
        
        public clsSpar Traspose(clsSpar A)
        {
            clsSpar S =  new clsSpar();
            





            return S;
        }
        
    }
    }


