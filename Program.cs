using System;

namespace ConsoleDrawer
{

    //caso de uso paso por valor y paso por referencia
    struct Test {

        public int I {get; set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Nuevo dibujo");
            Console.WriteLine("2 - Salir");


                var i = new Test();
                i.I = 10;
                Foo( i);

            bool opcion = DrawMenu();
            while (!opcion) {
               opcion = DrawMenu();
            }

        }

            //implementamos el metodo Foo de ejemplo
            static void Foo(Test i) {
               
                i.I = 2;
               
            }



        static bool DrawMenu() {

            ConsoleKeyInfo info = Console.ReadKey();
            if (info.KeyChar == '1' ) {
                Dibujo dibujo = new Dibujo();
                dibujo.Dibujar();
                Console.ReadKey();
                return true;

            }
            else if (info.KeyChar == '2') {

                return true;
            }
            else {

                Console.WriteLine("Seleccione 1 ó 2");
                return false;
            }
        }
    }
}
