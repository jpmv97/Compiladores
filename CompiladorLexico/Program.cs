using System;
using System.Collections.Generic;
using System.IO;
using System.Text;



namespace CompiladorLexico
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Dictionary<string, string> palabras_reservadas = new Dictionary<string, string>()
        {
            { "int", "dataTypeInt"},
            { "string", "dataTypeString"},
            { "float", "dataTypefloat"},
            { "bool", "dataTypeBool"},
            { "char", "dataTypeChar"}
        };
            foreach (string line in File.ReadLines(@"D:\Jose Pablo Montoya\Documents\Tec\Compiladores\compilador.txt", Encoding.UTF8))
            {
                Console.WriteLine(line);
                String palabra_actual = "";
                String estado_siguiente;
                foreach (char c in line) {
                    palabra_actual += c;
                    if (palabras_reservadas.TryGetValue(palabra_actual, out estado_siguiente)) {
                        Console.WriteLine(palabras_reservadas[palabra_actual]);
                        palabra_actual = "";
                    }
                }
                
            }
            Console.ReadKey();
        }
    }
}
