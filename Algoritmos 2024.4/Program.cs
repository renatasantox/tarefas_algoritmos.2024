/*
void Mensagem()
{
    Console.WriteLine("Hello, World!");
}

//Mensagem();

void Escreva(string msg)
{
    Console.WriteLine(msg);
}

Escreva("Olá de novo");

string minhaMsg = "testando...";

//Escreva(minhaMsg);

void MostrarIdade(string nome, int idade)
{
    Escreva($"{nome} tem {idade} anos");
}

MostrarIdade("Fulano", 16);
MostrarIdade("Sicrano", 14);

void    CalcularIdade(string nome, int ano)
{
    int idade = 2024 - ano;
    MostrarIdade(nome,idade);
}

CalcularIdade("Fulaninho", 2010);

int MaiorEntre(int a, int b)
{
    if(a >= b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

Console.WriteLine(MaiorEntre(90,200));
Console.WriteLine(MaiorEntre(15,7));
Console.WriteLine(MaiorEntre(1,1));

*/

void Soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}

void Subtracao(float a, float b){
    float resultado = a - b;
    Console.WriteLine($"{a} - {b} = {resultado}");
}

void Multiplicacao(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} * {b} = {resultado}");
}

void Divisao(float a, float b){
    if(b == 0){
        Console.WriteLine("Erro de divisão por zero");
        return;
    }
    float resultado = a / b;
    Console.WriteLine($"{a} / {b} = {resultado}");
}

//Variáveis globais
float a;
float b;

void DigitarAeB(string operacao)
{
    Console.WriteLine(operacao);
    Console.WriteLine($"Digite o valor de a");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o valor de b");
    b = float.Parse(Console.ReadLine());
}

//MENU
Console.WriteLine("--- CALCULADORA ---");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Sair");
Console.WriteLine("-------------------");
Console.WriteLine("Digite a opção desejada:");

int opcao = int.Parse(Console.ReadLine());

if(opcao == 1){
    DigitarAeB("Soma");
    Soma(a,b);
}
else if(opcao == 2)
{
    DigitarAeB("Subtração");
    Subtracao(a,b);
}
else if(opcao == 3){
    DigitarAeB("Multiplicação");
    Multiplicacao(a,b);
}
else if(opcao == 4){
    DigitarAeB("Divisão");
    Divisao(a,b);
}
else if(opcao == 5){
    Console.WriteLine("saindo...");
}
else
{
    Console.WriteLine("Opção inválida");
}