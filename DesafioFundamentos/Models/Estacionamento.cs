using Microsoft.Win32.SafeHandles;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {  
 private decimal precoInicial  = 0;
        private decimal precoPorHora  = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            //Pede para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();
            decimal valorTotal;   

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                //Pede para o usuário digitar o número de horas que o veículo permaneceu estacionado
                 if(int.TryParse(Console.ReadLine(),out int horas))
                 { 
                    //Faz o calculo do valor total = precoInicial + precoPorHora * horas
                   valorTotal = precoInicial + (precoPorHora * horas);

                    //Remove a placa digitada da lista de veiculos
                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo foi removido e o preço total do serviço foi: {valorTotal:c}");
                } 
                else
                  {
                     Console.WriteLine("Por favor, digite um valor válido para as horas.");
                  }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            //Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                //Realiza um laço de repetição, exibindo os veículos estacionados
                for (int i = 0; i < veiculos.Count; i++)
                {
                  Console.WriteLine($"{i + 1} - {veiculos[i]}");
                } 
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
