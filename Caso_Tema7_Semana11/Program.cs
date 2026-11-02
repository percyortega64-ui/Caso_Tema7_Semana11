using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_Tema7_Semana11
{
    internal class Program
    {
        static public void numero_naturales()
        {
            Console.Write("Ingresar numero de N:");
            int N = int.Parse(Console.ReadLine());
            int S = 0;
            for (int c = 1; c <= N; c++)
            {
                S = S + c;
            }
            Console.WriteLine("La suma es: " + S);
        }
        static public int sumaNN_con_recursividad(int N)
        {
            if(N == 1)
            {
                return 1;
            }
            return N + sumaNN_con_recursividad(N - 1);
        }
        static public long sumaNN_con_R_Par(int P)
        {
            if(P==2)
            {
                return 2;
            }
            return P + sumaNN_con_R_Par(P-2);
        }
        static public int Factorial_con_R(int F)
        {
            if (F == 1)
            {
                return 1;
            }
            return F * Factorial_con_R(F - 1);
        }
        static public long factorial(int F)
        {
            if (F == 1)
            {
                return 1;
            }
            return F * factorial(F - 1);
        }
        static public long potencia(int B, int P )
        {
            if (P == 1)
            {
                return B;
            }
            return B * potencia(B, P - 1);
        }
        static public void Conteo_R(int N)
        {
            if (N < 0)
            {
                return;
            }
            Console.WriteLine(N);
            Conteo_R(N - 1);
            
        }
        static public int suma_de_Arreglo(int[] numeros,int indice)
        {
            if (indice >=numeros.Length)
            {
                return 0;
            }
            return numeros[indice]+suma_de_Arreglo(numeros, indice+1);
        }
        static void Main(string[] args)
        {
            int opc;
            bool valor=true;
            while (valor)
            {
                Console.Clear();
                Console.WriteLine("**************************");
                Console.WriteLine("\t\tMenu de opciones");
                Console.WriteLine("**************************");

                Console.WriteLine("[1] Suma de numeros naturales");
                Console.WriteLine("[2] Suma de N numeros naturales recursividad");
                Console.WriteLine("[3] Suma de N numeros pares con recursividad");
                Console.WriteLine("[4] Factorial");
                Console.WriteLine("[5] Potencia");
                Console.WriteLine("[6] Conteo regresivo");
                Console.WriteLine("[7] Arreglo");
                Console.WriteLine("[8] Salir");
                Console.WriteLine("**************************");
                opc =int.Parse(Console.ReadLine());
                switch (opc) 
                {
                    case 1:
                        numero_naturales();
                        break;
                    case 2:
                        Console.Write("Ingrese el numero N ");
                        int N=int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma es:"+sumaNN_con_recursividad(N));
                        break;
                    case 3:
                        Console.Write("Ingrese el numero N de pares ");
                        int N1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma de pares es:" + sumaNN_con_R_Par(N1*2));
                        break;
                    case 4:
                        Console.Write("Ingrese el Factorial ");
                        int N2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El factorial es :" + factorial(N2));
                        break;
                    case 5:
                        Console.Write("Ingrese la base de la potencia ");
                        int B = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el exponente de la potencia ");
                        int P = int.Parse(Console.ReadLine());
                        Console.WriteLine(B+"^"+P+"="+potencia(B, P));
                        break;
                    case 6:
                        int N3;
                        Console.WriteLine("Ingrese el valor de la cuenta regresiva ");
                          N3 = int.Parse(Console.ReadLine());
                        Conteo_R(N3);
                        break;
                    case 7:
                        int[] Numeros = { 10, 15, 20, 25, 30 };
                        Console.WriteLine("la suma del arreglo es: " +suma_de_Arreglo(Numeros,0));
                        break;
                        

                        break;
                    case 8:
                        valor = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida ");
                        break;
                }
                Console.ReadKey();
            }
             
        }
    }
}
