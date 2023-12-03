using System;

namespace entero
{
    class inicio
    {
        static void Main(string[] args)
        {
            const string NumEnter = "Introduce un la nota del alumno: ";
            const string Mal = "La nota introducida no era un n�mero natural, prueba otra vez: ";
            const string Aprobados = "La cantidad de aprobados �s: ";
            const string Suspendidos = "La cantidad de suspendidos �s: ";
            const string AprobadosMedia = "La media de aprobados �s: ";
            const string SuspendidosMedia = "La media de suspendidos �s: ";
            const int TotalNum = 0;
            float num;
            float passed = 0, failed = 0;
            float totalPass = 0, totalFail = 0;
            for (int i = TotalNum; i < 8; i++)
            {
                Console.WriteLine(NumEnter);
                num = Convert.ToSingle(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine(Mal);
                    Console.WriteLine(NumEnter);
                    num = Convert.ToSingle(Console.ReadLine());
                }
                else if (num >= 5)
                {
                    totalPass++;
                    passed += num;
                } 
                else
                {
                    totalFail++;
                    failed += num;
                }    
                        
            }
            Console.WriteLine(Aprobados + totalPass);
            Console.WriteLine(Suspendidos + totalFail);
            Console.WriteLine(AprobadosMedia + ( passed / totalPass));
            Console.WriteLine(SuspendidosMedia + ( failed / totalFail));
        }
    }
}