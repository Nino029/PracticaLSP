using System.Drawing;
using LSPDomain;

class Program
{
    static void Main(string[] args)
    {
        /*
         CODIGO  CON FALLAS EN EL METODO CUADRADO:
        FiguraGeometrica figura = new FiguraGeometrica { Base = 5, Altura = 4 };
        Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 4 };
        Cuadrado cuadrado = new Cuadrado { Base = 5, Altura = 4 };
        Aquí El programa tendria un  fallo debido a la implementación incorrecta en la clase Cuadrado

        Console.WriteLine("\n");
        Console.WriteLine("=====Área de la figura=====: " + (figura.Base * figura.Altura));
        Console.WriteLine("\n");
        Console.WriteLine("=====Área del rectángulo=====: " + rectangulo.CalcularArea());
        Console.WriteLine("\n");
        Console.WriteLine("=====Área del cuadrado=====: " + cuadrado.CalcularArea());*/
    

    //CODIGO SOLUCIONADO:
    FiguraGeometrica figura = new FiguraGeometrica { Base = 5, Altura = 4 };
    Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 4 };
    Cuadrado cuadrado = new Cuadrado { Base = 5 };

        Console.WriteLine("\n");
        Console.WriteLine("=====Área de la figura=====: " + (figura.Base * figura.Altura));
        Console.WriteLine("\n");
        Console.WriteLine("=====Área del rectángulo=====: " + rectangulo.CalcularArea());
        Console.WriteLine("\n");
        Console.WriteLine("=====Área del cuadrado=====: " + cuadrado.CalcularArea()); 
    }

}