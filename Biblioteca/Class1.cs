using System.Security.Cryptography.X509Certificates;

namespace Biblioteca
{
    public class Class1
    {
        private double a;
        private double b;

        public Class1(double x, double y) {
            a = x;
            b= y;
        }
        public double suma() {
            return a + b;
        }
        public double resta()
        {
            return a - b;
        }
        public double multiplicacion()
        {
            return a * b;
        }
        public double division()
        {
            return a / b;
        }
    }
}