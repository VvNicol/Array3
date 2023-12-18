namespace nrojllaArrays3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz = new int[10, 10]; // declarando un entero dibimensional
            int rango = 100;

            //Creando filas
            for (int filas = 0; filas < matriz.GetLength(0); filas++)
            {
                //creando las columnas
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                { 
                    matriz[filas, columna] = rango--;
                   // Console.Write(matriz[filas, columna] + " ");
                }
            }
            //TODO crear mostrar por consola los numeros desendentes y mostrar por consola
            for (int filas = 0; filas < matriz.GetLength(0); filas++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    matriz[filas, columna] = rango++;
                    Console.WriteLine(matriz[ filas,columna] + " ");
                }
            }

        }
    }
}