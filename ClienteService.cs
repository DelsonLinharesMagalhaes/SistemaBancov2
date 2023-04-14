using System;


namespace M1S3_SistemaBanco
{
    public class ClienteService : IClienteService
    {
        public static List<Cliente> clientes = new();

        public void CriarConta()
        {
            Console.WriteLine("Qual o tipo de conta?");
            Console.WriteLine("1 - Pessoa Física");
            Console.WriteLine("2 - Pessoa Jurídica");

            var opcao = Console.ReadLine();

            if (opcao == "1")
            {
                var cliente = PessoaFisica.CriarConta();
                clientes.Add(cliente);
            }

            if (opcao == "2")
            {
                var empresa = PessoaJuridica.AbrirEmpresa();
                clientes.Add(empresa);
            }
        }

        public Cliente BuscarCliente()
        {
            Console.WriteLine("Digite o número da conta");
            var opcao = int.Parse(Console.ReadLine());

            var cliente = clientes.Find(x => x.NumeroConta == opcao);
            return cliente;
        }

        public void ExibirClientes()
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente.ResumoCliente());
            }
        }

    }
}
