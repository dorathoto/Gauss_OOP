namespace Gauss_OOP
{
    public sealed  class Gato : Animal
    {
        public Gato(int tipo) : base(tipo)
        {

        }

        // Atributo específico da classe Gato
        public string CorPelagem { get; set; }


        // Implementação do método abstrato FazerSom() da classe Animal
        public override void FazerSom()
        {
            Console.WriteLine("Miau!");
        }
    }
}
