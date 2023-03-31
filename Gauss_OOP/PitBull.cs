namespace Gauss_OOP
{
    public class PitBull : Cachorro
    {
        public bool EBravo { get; set; }
        public PitBull(int tipo) : base(tipo)
        {
            this.Raca = "PitBull";
        }
        public override void FazerSom()
        {
            Console.WriteLine("Au au! Eu sou um PitBull");
        }
    }
}
