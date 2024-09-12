using FormasGeometricas;

public class TrianguloRetangulo : Forma
{
    public double LadoA { get; set; }
    public double LadoB { get; set; }

    // Construtor da classe TrianguloRetangulo
    public TrianguloRetangulo(string nome, double ladoA, double ladoB) : base(nome)
    {
        LadoA = ladoA;
        LadoB = ladoB;
    }

    // implementação do cálculo da área usando a fórmula do triângulo retângulo
    public override double Area()
    {
        if(LadoA <= 0 || LadoB <= 0)
        {
            throw new ArgumentException("Nenhum dos lados deve ser menor ou igual a zero, para poder calcular a área do triângulo retângulo");
        }
        else
        {
            return ((LadoA * LadoB) / 2);
        }
        
    }
}

