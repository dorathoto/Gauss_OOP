namespace Gauss_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cachorro = new Cachorro(1)
            {
                Idade = 2,
                Peso = 3
            };
            cachorro.FazerSom();
            cachorro.Mamar();

            PitBull? t = cachorro as PitBull; //sempre será null (pai -> filho)

            PitBull pitBull = new PitBull(1)
            {
                Idade = 2,
                Raca = "PitBull",
                EBravo = true
            };

            // aqui será permitido, já que o pitbull é um animal (filho -> pai)
            Cachorro animal = pitBull as Cachorro;
            

            //exemplo com interface
            IBase t1 = new Base();
            
            Derivada t2 = t1 as Derivada;

            var pit = new PitBull(cachorro.TipoAnimal)
            {
                Idade = cachorro.Idade,
                Peso = cachorro.Peso
            };
            Console.WriteLine(pit.Raca.ToString());

            Console.WriteLine("# # # # # Outro exemplo # # # # #");

            Quadrado q = new();
            Console.WriteLine(q.Descricao());

            Console.WriteLine("Informe o valor do lado do quadrado em metros.");

            q.Lado = Convert.ToInt32(Console.ReadLine());

            q.CalcularArea();
            q.CalcularPerimetro();
            Console.WriteLine("A área do quadrado é : " + q.Area + " m2 ");
            Console.WriteLine("O perímetro do quadrado é : " + q.Perimetro + " m ");

            Console.ReadKey();
        }
    }
}