using System.Security.Cryptography.X509Certificates;

class Usuarios
{
    // public: outras Classes podem Chamar
    // Static: chama-se pelo nome da classe, sem criar objeto

    public static List<string> nomes = new List<string>();
    public static List<string> logins = new List<string>();
    public static List<string> senhas = new List<string>();

    public static void Cadastrar()
    {
       Console.Write("Nome: ");
       string nome = Console.ReadLine();
       Console.Write("Usuário: ");
       string login = Console.ReadLine();
       Console.Write("senha (minimo 4 caracteres): ");
       string senha = Console.ReadLine();

        if (login == "" || senha.Length < 4)
        {
            Console.WriteLine("Dados inválidos!");
        }
        else if (logins.Contains(login))
        {
            Console.WriteLine("Esse usuário ja existe!");
        }
        else
        {
            nomes.Add(nome);
            logins.Add(login);
            senhas.Add(senha);
            Console.WriteLine("Usuário cadastrado!");
        }
    }


    public static void Listar()
    {
        
    }
}