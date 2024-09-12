using FormasGeometricas;

public class Quadrado : Forma
{
    public double Lado { get; set; }

    // Construtor da classe Quadrado
    public Quadrado(string nome, double lado) : base(nome)
    {
        Lado = lado;
    }

    // Implementação do cálculo da área
    public override double Area()
    {
        if (Lado <= 0)
        {
            throw new ArgumentException("O valor do lado deve ser maior que zero.");
        }
        return Lado * Lado;
    }
}