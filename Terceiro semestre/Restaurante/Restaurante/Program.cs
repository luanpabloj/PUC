namespace Restaurante
{
    internal class Restaurant
    {
        private string[] mesas;
        private int disponivel;
 
        public Restaurant()
        {
            this.mesas = new string[10];
            this.disponivel = 0;
        }

        public bool addClient(string name)
        {

            if (disponivel < mesas.Length)
            {
                mesas[disponivel] = name;
                disponivel += 1;
                Console.WriteLine("Cliente alocado na mesa: " +  disponivel);
                return true;
            }
            else
            {
                Console.WriteLine("Não há mesas disponíveis");
                return false;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool teste = false;
            Restaurant restaurant = new Restaurant();
            do
            {
                Console.WriteLine("Digite o nome do cliente a ser cadastrado em uma mesa: ");
                string name = Console.ReadLine();
                teste = restaurant.addClient(name);
            }while (teste == true);

            Console.WriteLine("Fim do programa. O restaurante está cheio");
        }
    }
}
