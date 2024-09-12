using FormasGeometricas;

public class Triangulo : Forma
{
    public double LadoA { get; set; }
    public double LadoB { get; set; }
    public double LadoC { get; set; }

    // Construtor da classe Triangulo que recebe o nome e os lados, sendo que nome é herda de Forma
    public Triangulo(string nome, double ladoA, double ladoB, double ladoC) : base(nome)
    {
        LadoA = ladoA;
        LadoB = ladoB;
        LadoC = ladoC;
    }

    // Implementação do cálculo da área usando a fórmula de Herão   
    public override double Area()
    {
        if (LadoA <= 0 || LadoB <= 0 || LadoC <= 0)
        {
            throw new ArgumentException("Nenhum dos lados deve ser menor ou igual a zero");
        }
        else
        {
            double semiperimetro = (LadoA + LadoB + LadoC) / 2;
            return Math.Sqrt(semiperimetro * (semiperimetro - LadoA) * (semiperimetro - LadoB) * (semiperimetro - LadoC));
        }
       
    }

}