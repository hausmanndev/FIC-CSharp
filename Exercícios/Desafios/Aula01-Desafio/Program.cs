// See https://aka.ms/new-console-template for more information

//# DESAFIO 15/03
//Crie um programa de console em C# que simule um sistema de acesso a informações governamentais. O usuário deve inserir um nome de usuário e uma senha pré-definidos, 
//tendo no máximo três tentativas antes do sistema ser bloqueado. Se o login for bem-sucedido, o programa solicitará a idade do usuário e permitirá escolher um 
//dos três níveis de acesso disponíveis. O **Nível 1** é acessível para qualquer idade, o **Nível 2** apenas para maiores de 18 anos, e o **Nível 3** exige 
//que o usuário tenha pelo menos 21 anos e insira uma senha de segurança adicional. Caso o usuário tente acessar um nível sem atender aos requisitos, 
//uma mensagem informará a restrição.
string usuario = "admin";
string senha = "Admin2@25";

Console.Write("Usuario: ");
string usuarioInserido = Console.ReadLine();
Console.Write("Senha: ");
string senhaInserida = Console.ReadLine();

if(usuarioInserido == usuario && senhaInserida == senha)
{

}
