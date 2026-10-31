namespace ProjetoLeonardo;

class Program
{
    static void Main()
    {
       int opcao = 1;
       while (opcao != 0)
        {
            Console.WriteLine("1 - Cadastrar usuários");
            Console.WriteLine("2 - Listar usuários");
            Console.WriteLine("0 - sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Usuarios.Cadastrar(); break;
                case 2: Usuarios.Listar();  break;
            }
        } 
    }
}
