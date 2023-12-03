using System;

namespace entero {
  class inicio {
    static void Main(string[] args){
        const string NumEnter1 = "Introduce el primer n�mero: ";
        const string NumEnter2 = "Introduce el segundo n�mero para ver si el primero es m�ltiple de este: ";
        const string NoNatural = "Uno de los dos n�mero no era un entero, vuelve a hacerlo: ";
        int num1, num2;
        int modulo = 0;
        string final;
        Console.WriteLine(NumEnter1);
        num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(NumEnter2);
        num2 = Convert.ToInt16(Console.ReadLine());
        modulo = (num1%num2);
        while ((num1 < 0) || (num2 < 0)){
            Console.WriteLine(NoNatural);
            Console.WriteLine(NumEnter1);
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(NumEnter2);
            num2 = Convert.ToInt16(Console.ReadLine());            
        }
        final = modulo !=0 ? num1 + " No es m�ltiple de: " + num2 : num1 + " S� es m�ltiple de: " + num2;
        Console.WriteLine(final);
    }
  }
}