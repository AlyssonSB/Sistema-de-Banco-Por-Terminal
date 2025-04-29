using Course.Entities;
using System;
using System.Globalization;
using System.Security.Cryptography;



namespace Course
{
    class program
    {
        static void Main(string[] args)
        {
            List<Account> ListAccounts = new List<Account>();
            Random random = new Random();
            string path = @"C:\\Users\\art0063186\\Desktop\\Projetos c#\\Banco do AlyShow";
           
            Console.WriteLine("------------------------");
            Console.WriteLine("----Banco do AlyShow----");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("Login:");
            try
            {
                string[] lines = File.ReadAllLines(path);

                string sourceFolderPath = Path.GetDirectoryName(path);
                string targetFolderPath = sourceFolderPath + @"\Banco do Brasil\Contas.txt";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFolderPath))
                {
                    foreach (string line in lines)
                    {

                        int number = random.Next(1000, 9999);
                        Console.WriteLine("Nome: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Email: ");
                        string email = Console.ReadLine();
                        Console.WriteLine("Senha: ");
                        string adress = Console.ReadLine();

                        Account account = new Account(name, email, adress, number);
                        ListAccounts.Add(account);

                        sw.WriteLine("Nome: " + account.Name);
                        sw.WriteLine("Número: " + account.Number);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}