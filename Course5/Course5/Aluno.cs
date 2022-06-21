namespace Course5
{
    internal class Aluno
    {
        public string nome;
        public double n1, n2, n3;
        public double soma;

        public double NotaFinal()
        {
            soma = n1 + n2 + n3;
            return soma;
        }
    }
}
