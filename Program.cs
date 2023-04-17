// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair





Console.WriteLine(@$"

Seja bem vindo a Lucas Airlines

");


Console.Write(@$"Digite a senha para acessar o menu:");

string senha = Console.ReadLine();

while( senha != "1234" )
{
 Console.Write(@$"Senha incorreta.Digite Novamente:");
 senha = Console.ReadLine();
  
}

Console.WriteLine(@$"


Bem vindo ao menu


");




