using System;
using System.Collections.Generic;

class Programa
{
    static bool PuestoLimonadasPila(int[] billetes)
    {
        Stack<int> pila5 = new Stack<int>();
        Stack<int> pila10 = new Stack<int>();

        foreach (var billete in billetes)
        {
            if (billete == 5)
            {
                pila5.Push(billete); 
            }
            else if (billete == 10)
            {
                if (pila5.Count > 0)
                {
                    pila5.Pop(); 
                    pila10.Push(billete); 
                }
                else
                {
                    return false; 
                }
            }
            else if (billete == 20)
            {
                
                if (pila10.Count > 0 && pila5.Count > 0)
                {
                    pila10.Pop();
                    pila5.Pop();
                }
               
                else if (pila5.Count >= 3)
                {
                    pila5.Pop();
                    pila5.Pop();
                    pila5.Pop();
                }
                else
                {
                    return false; 
                }
            }
        }
        return true; 
    }

    static void Main()
    {
        Console.WriteLine(PuestoLimonadasPila(new int[] { 5, 5, 5, 10, 20 })); // ➞ true
        Console.WriteLine(PuestoLimonadasPila(new int[] { 5, 5, 10, 10, 20 })); // ➞ false
        Console.WriteLine(PuestoLimonadasPila(new int[] { 10, 10 })); // ➞ false
        Console.WriteLine(PuestoLimonadasPila(new int[] { 5, 5, 10 })); // ➞ true
    }
}
