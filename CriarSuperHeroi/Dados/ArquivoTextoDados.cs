namespace CriarSuperHeroi.Dados
{
    //T representa o tipo generico, aceita qualquer objeto.
    public class ArquivoTextoDados
    {
        public void SalvarEmArquivo<T>(T objeto)
        {
            const string filePath = @"C:\Users\Marcos\OneDrive\Área de Trabalho\heroiCriado\heroiCriado.txt";
            using var file = File.AppendText(filePath);
            file.WriteLine(objeto.ToString());
            file.WriteLine("-------------------------------------");
            file.Close();
        }
    }
}
