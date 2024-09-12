// Classe Circulo que herda de Forma
using FormasGeometricas;

public class Circulo : Forma
{
    public double Raio { get; set; }

    // Construtor da classe Circulo
    public Circulo(string nome, double raio) : base(nome)
    {
        Raio = raio;
    }

    // Implementação do cálculo da área
    public override double Area()
    {
        if (Raio <= 0)
        {
            throw new ArgumentException("O valor do raio deve ser maior que zero");
        }
        else
        {
            return Math.PI * Raio * Raio;
        }
    }
}