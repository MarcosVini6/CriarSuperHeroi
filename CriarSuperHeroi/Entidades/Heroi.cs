using CriarSuperHeroi.Enum;

namespace CriarSuperHeroi.Entidades
{
    public class Heroi
    {
        public string Nome { get; set; }
        public List<Poder> Poderes { get; set; }

        public override string ToString()
        {
            var retorno = $"O herói {Nome} foi criado e seus poderes são:";
            foreach (var poder in Poderes)
            {
                retorno += $"\n {poder}";
            }
            return retorno;
        }
    }
}
