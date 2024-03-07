namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        public decimal precoPorHora;

        public string Placa { get; set; }
        public int Horas { get; set; }


        private List<Estacionamento> veiculos = new List<Estacionamento>();


        public Estacionamento()
        {

        }

        public Estacionamento(int Horas, string Placa, decimal precoInicial, decimal precoPorHora)
        {
            this.Horas = Horas;
            this.Placa = Placa;
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Estacionamento est = new Estacionamento();

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();


            est.Placa = placa;

            veiculos.Add(est);


        }


        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            for (int i = 0; i < veiculos.Count; i++)
            {
                // Verifica se o veículo existe
                if (veiculos != null)
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    Horas = Convert.ToInt32(Console.ReadLine());


                    // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                    // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                    // *IMPLEMENTE AQUI*
                    decimal valorTotal = (precoInicial + precoPorHora) * Horas;

                    // TODO: Remover a placa digitada da lista de veículos
                    // *IMPLEMENTE AQUI*



                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    veiculos.RemoveAt(i);

                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }


            }


        }


        public void informacao()
        {
            Console.WriteLine("Placa: " + Placa);
        }

        public void ListarVeiculos()
        {
            foreach (var veiculo in veiculos)
            {
                if (veiculo is Estacionamento estacionamento)
                {
                    estacionamento.informacao();
                }

            }

        }
        public decimal getPrecoInicial()
        {
            return precoInicial;
        }


        public void setPrecoInicial(decimal precoInicial)
        {
            this.precoInicial = precoInicial;
        }

         public decimal getPrecoPorHora()
        {
            return precoPorHora;
        }


        public void setPrecoPorHora(decimal precoPorHora)
        {
            this.precoPorHora = precoPorHora;
        }


    }
}