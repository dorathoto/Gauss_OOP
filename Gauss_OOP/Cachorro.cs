namespace Gauss_OOP
{
    public class Cachorro : Animal
    {
        public Cachorro(int tipo) : base(tipo)
        {
        }

        public void Mamar()
        {
            Console.WriteLine("Estou mamando junto com meus 12 irmãos");
        }
        // Atributo específico da classe Cachorro
        public string Raca { get; set; }

        // Implementação do método abstrato FazerSom() da classe Animal
        public override void FazerSom()
        {
            Console.WriteLine("Au au!");
        }
    }
}
