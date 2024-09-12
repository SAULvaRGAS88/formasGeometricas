using System;

namespace FormasGeometricas
{
    // Classe abstrata Forma
    public abstract class Forma
    {
        public string Nome { get; set; }

        // Construtor da classe Forma
        // protected referece a Somente a própria classe Forma e suas classes derivadas
        // (como Triangulo, Quadrado, Circulo) podem chamar esse construtor diretamente.
        protected Forma(string nome)
        {
            Nome = nome;
        }

        // Método abstrato para calcular a área
        public abstract double Area();

        public void TestarForma()
        {
            try
            {
                Console.WriteLine($"{Nome} - Área: {Area()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}