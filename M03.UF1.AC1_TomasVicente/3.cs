 using System;

namespace entero {
  class inicio {
    static void Main(string[] args){
        const string NumEnter = "Introduce un n�mero: ";
        const string Mal =  "El n�mero introducido no era un n�mero entero, prueba otra vez: ";
        const string Even = "Los n�meros pares s�n: ";
        const string Odd = "Los n�meros impares s�n: ";
        const int TotalNum = 0;
        float num;
        int odd = 0, even = 0;
        string final;
        for (int i = TotalNum; i < 20; i++){
            Console.WriteLine(NumEnter);
            num = Convert.ToSingle(Console.ReadLine());
            if (num % 1 != 0){
                Console.WriteLine(Mal);
                Console.WriteLine(NumEnter);
                num = Convert.ToSingle(Console.ReadLine());
            }
            else {
                final = (num % 2 == 0) ? Even + even++ : Odd +odd++;
            }
        }
        Console.WriteLine(Even + even);
        Console.WriteLine(Odd + odd);
    }
  }
}