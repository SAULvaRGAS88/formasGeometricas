using FormasGeometricas;

namespace FormasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instâncias de formas geométricas
            Forma quadrado = new Quadrado("Quadrado", 5);
            Forma circulo = new Circulo("Círculo", 5);
            Forma triangulo = new Triangulo("Triângulo", 3, 3, 3);
            Forma trianguloRetangulo = new TrianguloRetangulo("Triângulo Retângulo", 2, 6);

            // Exibindo os nomes e áreas das formas geométricas
            foreach (Forma forma in new Forma[] { quadrado, circulo, triangulo, trianguloRetangulo })
            {
                Console.WriteLine($"{forma.Nome} - Área: {forma.Area()}");
            }

            //Casos de testes
            Forma quadrado1 = new Quadrado("Quadrado", -5);
            quadrado1.TestarForma();

            Forma circulo2 = new Circulo("Círculo", -5);
            circulo2.TestarForma();

            Forma triangulo3 = new Triangulo("Triângulo", 3, 3, -3);
            triangulo3.TestarForma();

            Forma trianguloRetangulo4 = new TrianguloRetangulo("Triângulo Retângulo", 2, -6);
            trianguloRetangulo4.TestarForma();
        }
    }
}