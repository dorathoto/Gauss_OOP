using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss_OOP.Composicao
{
    public class Motor
    {
        public string Modelo { get; set; }
        public void Ligar()
        {
            Console.WriteLine("Motor ligado");
        }
    }


    public class Roda
    {
        public void Girar()
        {
            Console.WriteLine("Roda girando");
        }
    }

    public class Carro
    {
        public Motor _motor;
        private Roda[] _rodas;

        public Carro()
        {
            _motor = new Motor(){ Modelo = "Turbo"};
            _rodas = new Roda[4];

            for (int i = 0; i < _rodas.Length; i++)
            {
                _rodas[i] = new Roda();
            }
        }

        public void LigarCarro()
        {
            _motor.Ligar();
        }

        public void GirarRodas()
        {
            foreach (Roda roda in _rodas)
            {
                roda.Girar();
            }
        }
    }

}
