using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDomain
{
    public class Cuadrado : FiguraGeometrica
    {
        public override double CalcularArea()
        {
            /* return Base * Altura;
            ¡Aquí es donde violamos LSP!
             Devolvemos el área de un rectángulo en lugar del área de un cuadrado.*/

            // Esta es la SOLUCIÓN Donde Calculamos el área de un cuadrado correctamente:
            return Base * Base;
        }
    }
}
