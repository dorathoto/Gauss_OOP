namespace Gauss_OOP
{
    public abstract class Animal
    {
        public int TipoAnimal { get; init; }

        public int Idade { get; set; }
        public float Peso { get; set; }

        // Método abstrato que será implementado nas classes filhas
        public abstract void FazerSom();

        //não é um método abastrato então não é necessário herdar
        public void Mamar() => Console.WriteLine("Estou mamando");
        public Animal(int tipo)
        {
            this.TipoAnimal = tipo;
        }
    }
}
