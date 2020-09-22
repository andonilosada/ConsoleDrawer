

namespace ConsoleDrawer {

    public class Dibujo {

        private Figura[] _figuras;
        public Dibujo(){

         _figuras = new Figura[10];
         _figuras[0] = new Texto(10, 5, "Hola a todos");
         
        }

        public void Dibujar() {

            for (int i=0; i< _figuras.Length; i++) {

                _figuras[i]?.Dibujar();
               
            }
        }

    }

}