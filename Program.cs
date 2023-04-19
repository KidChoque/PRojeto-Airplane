// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair





Console.WriteLine(@$"
*********************************
-Seja bem vindo a Lucas Airlines-
*********************************
");

int indexPassageiro = 0;
string[] nomePassageiros = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];


Console.Write(@$"Digite a senha para acessar o menu:");

string senha = Console.ReadLine();

while (senha != "1234")
{
    Console.Write(@$"Senha incorreta.Digite Novamente:");
    senha = Console.ReadLine();

}

Console.WriteLine(@$"


Bem vindo ao menu.

1- Cadastrar passagem
2- Listar Passagens
0- Sair


");

int escolhaMenu = 0;

Console.WriteLine($"Escolha uma das opções");

escolhaMenu = int.Parse(Console.ReadLine());


switch (escolhaMenu)
{
    case 1:
        if (escolhaMenu == 1)
        {
            Console.WriteLine($"Cadastre sua passagem");

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"Digite o nome:");
                nomePassageiros[indexPassageiro] = Console.ReadLine();

                Console.WriteLine($"Qual é a origem da viagem ?");
                origem[indexPassageiro] = Console.ReadLine();

                Console.WriteLine($"Digite o destino da viagem:");
                destino[indexPassageiro] = Console.ReadLine();


                Console.WriteLine($"Qual é a data da viagem ?");
                data[indexPassageiro] = Console.ReadLine();

                indexPassageiro++;
            }

            Console.WriteLine($"Deseja continuar sim - s ou não - n ?");
            char sn = char.Parse(Console.ReadLine());

            if (sn == 's')
            {
                Console.Clear();
                Console.WriteLine($"Okay okay");

                Console.WriteLine(@$"


                 Bem vindo ao menu.

                1- Cadastrar passagem
                2- Listar Passagens
                0- Sair


                                         ");

                escolhaMenu = int.Parse(Console.ReadLine());



                if (escolhaMenu == 2)
                {
                    Console.WriteLine($"Listar Passagens");

                    for (int i = 0; i < indexPassageiro; i++)
                    {
                        Console.WriteLine(@$"
            
            {i + 1}º {nomePassageiros[i]}
            {i + 1}º {origem[i]}
            {i + 1}º {destino[i]}
            {i + 1}º {data[i]}
            
            ");
                    }

                }



            }
            else
            {
                Console.WriteLine($"********************************************************");
                Console.WriteLine($"*****Obrigado pela preferência em nossos serviços.******");
                Console.WriteLine($"********************************************************");

            }





        }
        break;
    case 2:
        if (escolhaMenu == 2)
        {
            Console.WriteLine($"Listar Passagens");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(@$"
            
            {i + 1}º {nomePassageiros[indexPassageiro]}
            {i + 1}º {origem[indexPassageiro]}
            {i + 1}º {destino[indexPassageiro]}
            {i + 1}º {data[indexPassageiro]}
            
            ");
            }

            

        }
        break;
    case 0:
        if (escolhaMenu == 0)
        {
            Console.WriteLine($"Até a próxima");

        }
        break;
    default:

        break;

}











