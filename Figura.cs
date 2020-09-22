namespace ConsoleDrawer {

    public abstract class Figura {
        public int Fila {get; }
        public int Columna {get; }

        public Figura (int fila, int columna) {

            Fila = fila;
            Columna = columna;

        }

        public abstract void Dibujar();

        
    }

}
