

namespace M1S3_SistemaBanco
{
    public class PessoaJuridica : Cliente
    {

        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public List<string> Socios { get; set; } = new List<string>();
        public DateTime DataAbertura { get; set; }

        public static Cliente AbrirEmpresa()
        {

            PessoaJuridica pessoaJuridica = new PessoaJuridica();

            Console.WriteLine("Data de abetura da empresa?");
            pessoaJuridica.DataAbertura = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Razão Social da empresa?");
            pessoaJuridica.RazaoSocial = Console.ReadLine();
            Console.WriteLine("CNPJ da empresa?");
            pessoaJuridica.CNPJ = Console.ReadLine();
            Console.WriteLine("Nome Fantasia da empresa?");
            pessoaJuridica.NomeFantasia = Console.ReadLine();
            Console.WriteLine("Telefone da empresa?");
            pessoaJuridica.Telefone = Console.ReadLine();
            Console.WriteLine("E-mail da empresa?");
            pessoaJuridica.Email = Console.ReadLine();
            Console.WriteLine("Endereço da empresa?");
            pessoaJuridica.Endereco = Console.ReadLine();
            Console.WriteLine("Número da conta da empresa");
            pessoaJuridica.NumeroConta = int.Parse(Console.ReadLine());


            return pessoaJuridica;
        }

        public override string ResumoCliente()
        {
            string resumo = $"{NumeroConta}  |  {RazaoSocial}   |  {CNPJ}      |  {Telefone} |  {Endereco}";
            return resumo;

        }

    }
}
