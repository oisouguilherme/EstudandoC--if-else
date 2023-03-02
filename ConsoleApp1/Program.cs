internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite sua idade");
        int idade = int.Parse(Console.ReadLine());

        if (idade>=0 && idade <=11)
        {
            Console.WriteLine("É criança");
        } else if (idade >=12 && idade <=18)
        {
            Console.WriteLine("É adolescente");
        } else if (idade >= 19 && idade <= 60)
        {
            Console.WriteLine("É adulto");
        } else
        {
            Console.WriteLine("É idoso");
        }
        Console.ReadLine();
        
    }
}