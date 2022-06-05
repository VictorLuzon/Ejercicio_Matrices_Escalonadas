using System;

namespace Ejercicio_Matrices
{
    /*Programa que nos pide la evaluación de un curso.
        - Pedir al usuario cuantas clases va a evaluar.
        - Pedir al usuario cuantos alumnos tiene cada clase.
        - Pedir al usuario que introduzca la nota de cada alumno en cada clase.
    Imprimir por pantalla las siguientes instrucciones:
        - Nota media.
        - Nota mínima.
        - Nota máxima.
    */
    
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos todas las variables.
            int clases;
            int numeroAlumnos;
            double sumaNotas = 0;
            double sumaAlumnos = 0;
            double mediaNotas;
            double notaMin = 10;
            double notaMax = 0;

            //Pedimos el nº de clases que vamos a evaluar.
            Console.WriteLine("¿Cuántas clases vas a evaluar?");
            clases = Int32.Parse(Console.ReadLine());

            //Limpiamos la pantalla para tener más claridad.
            Console.Clear();

            //Instanciamos la matriz escalonada, donde vemos que el tamaño de las filas va a ser del nº de clases.
            double[][] notas = new double[clases][];    

            //Recorremos el nº de clases pidiendo al usuario que nos diga cuantos alumnos tiene cada clase. Los cuales vamos a evaluar.
            for(int i = 0; i < clases; i++){
                Console.WriteLine($"¿Cuántos alumnos vas a evaluar para la clase {i + 1}?");
                numeroAlumnos = Int32.Parse(Console.ReadLine());

                //Nos quedamos con el nº total de alumnos.
                sumaAlumnos += numeroAlumnos;

                //Asignamos una nota para cada alumno.
                notas[i] = new double[numeroAlumnos];
            }
            //Limpiamos la pantalla para tener más claridad.
            Console.Clear();

            //Recorremos las clases, y ponemos la nota de cada alumno.
            for(int i = 0; i < clases; i++){
                Console.WriteLine($"Clase nº {i + 1}:");
                for(int j = 0; j < notas[i].Length; j++){
                    Console.WriteLine($"Escribe la nota del alumno {j + 1}");
                    notas[i][j] = double.Parse(Console.ReadLine());
                    //Sumamos las notas de los alumnos de la clase x.
                    sumaNotas += notas[i][j];
                }
            }

            //Calculamos la nota media de todos los alumnos en todas las clases. Todas las notas de todos los alumnos en todas las clases / el nº total de alumnos.
            mediaNotas = sumaNotas / sumaAlumnos;

            //Calculamos la nota mínima total, es decir, recorremos todas las notas de todos los alumnos de todas las clases, y nos quedamos con la más baja.
            for(int i = 0; i < clases; i++){
                for(int j = 0; j < notas[i].Length; j++){
                    if(notas[i][j] < notaMin){
                        notaMin = notas[i][j];
                    }
                }
            }

            //Calculamos la nota máxima total, es decir, recorremos todas las notas de todos los alumnos de todas las clases y nos quedamos con la más alta.
            for(int i = 0; i < clases; i++){
                for(int j = 0; j < notas[i].Length; j++){
                    if(notas[i][j] > notaMax){
                        notaMax = notas[i][j];
                    }
                }
            }

            //Limpiamos para tener más claridad.
            /*Este clear es opcional, puesto que si queremos comprobar que el programa ha funcionado correctamente, podemos no ponerlo
            para que de esa forma podamos comprobar las notas que hemos puesto y ver si es correcta la media, la mínima y la máxima.*/
            Console.Clear();

            //Imprimimos en consola la media, la mínima y la máxima.
            Console.WriteLine($"La nota media de todas las clases es: {mediaNotas}");
            Console.WriteLine($"\nLa nota mínima de todas las clases es: {notaMin}");
            Console.WriteLine($"\nLa nota máxima de todas las clases es: {notaMax}");
        }
    }
}
