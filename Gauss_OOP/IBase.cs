namespace Gauss_OOP
{
    public interface IBase
    {
        string Descricao();
    }
    public class Base : IBase
    {
        public string Descricao()
        {
           return "Descricao na base";
        }
    }

    public class Derivada : Base
    {
        public new string Descricao()
        {
            return "Descricao na derivada";
        }
    }
}
