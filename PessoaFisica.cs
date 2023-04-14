

namespace M1S3_SistemaBanco
{
    public class PessoaFisica : Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get { return (int)(Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.25)); } private set { } }


        public override string ResumoCliente()
        {
            return $"{NumeroConta}  |  {Nome}  | {CPF}  |  {Telefone}  |  {Endereco}";
        }
        public bool EhMaior()
        {
            return Idade >= 18;
        }

        public static Cliente CriarConta()
        {

            PessoaFisica pessoaFisica = new PessoaFisica();

            Console.WriteLine("Data de Nascimento do cliente:");
            pessoaFisica.DataNascimento = DateTime.Parse(Console.ReadLine());
            if (!pessoaFisica.EhMaior())
            {
                Console.WriteLine("não é possivel abrir a conta pois o cliente é menor de idade");
                return null;
            }
            Console.WriteLine("A idade do cliente é " + pessoaFisica.Idade);
            Console.WriteLine("Nome do cliente?");
            pessoaFisica.Nome = Console.ReadLine();
            Console.WriteLine("CPF do cliente?");
            pessoaFisica.CPF = Console.ReadLine();
            Console.WriteLine("Endereco do cliente?");
            pessoaFisica.Endereco = Console.ReadLine();
            Console.WriteLine("Telefone do cliente?");
            pessoaFisica.Telefone = Console.ReadLine();
            Console.WriteLine("E-mail do cliente?");
            pessoaFisica.Email = Console.ReadLine();
            Console.WriteLine("Numero da Conta do cliente?");
            pessoaFisica.NumeroConta = int.Parse(Console.ReadLine());

            return pessoaFisica;
        }

    }
}
