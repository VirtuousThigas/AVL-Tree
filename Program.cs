using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
        class Program
        {
            static void Main(string[] args)
            {
                int escolha;
                bool saida = false;
                AVL arvore1= new AVL();
                while(saida==false)
                {
                    Console.WriteLine("1- Cadastrar um paciente");
                    Console.WriteLine("2- Remover um paciente.");
                    Console.WriteLine("3- Pesquisar um paciente.");
                    Console.WriteLine("4- Mostrar os nomes de todos os pacientes");
                    Console.WriteLine("5- Mostrar os CPFs de todos pacientes");
                    Console.WriteLine("6- Mostrar os e-mails de todos pacientes");
                    Console.WriteLine("7- Sair");
                    escolha=int.Parse(Console.ReadLine());
                    switch(escolha)
                    {
                        case 1:
                            Console.WriteLine("Insira o CPF:");
                            int cpf = int.Parse(Console.ReadLine());
                            Console.WriteLine("Insira o nome:");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Insira o email:");
                            string email = Console.ReadLine();
                            Console.WriteLine("Insira o telefone:");
                            string telefone = Console.ReadLine();
                            Paciente novopaciente= new Paciente(cpf,nome,email,telefone);
                            arvore1.Inserir(novopaciente);
                            break;
                        case 2:
                            Console.WriteLine("Insira o CPF:");
                            int cpfremover=int.Parse(Console.ReadLine());
                            arvore1.Remover(cpfremover);
                            break;
                        case 3:
                            Console.WriteLine("Insira o CPF:");
                            int cpfpesquisar=int.Parse(Console.ReadLine());
                            if (arvore1.Pesquisar(cpfpesquisar) == false)
                            {
                                Console.WriteLine("Paciente não cadastrado.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Mostrando todos os nomes dos pacientes");
                            arvore1.CaminharCentral();
                            break;
                        case 5:
                            Console.WriteLine("Mostrando CPFs de todos os pacientes");
                            arvore1.CaminharPos();
                            break;
                        case 6:
                            Console.WriteLine("Mostrar todos os Emails dos pacientes");
                            arvore1.CaminharPre();
                            break;
                        case 7:
                            Console.WriteLine("saindo...");
                            saida = true;
                            break;
                    }
                    
                }
                Console.ReadKey();

            }
        }
}

