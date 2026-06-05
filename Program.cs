//Programa de Progressão Aritmética feito por Isabella Diniz Pin 1°ano A
Console.WriteLine("Bem vindo ao Programa de progressões aritméticas");
Console.WriteLine("Qual o termo incial da sua PA?");
int TermoInicial = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos termos sua PA deve ter?");
int termos = int.Parse(Console.ReadLine());
Console.WriteLine("Qual deve ser a razão da sua PA?");
int r = int.Parse(Console.ReadLine());
Console.WriteLine("");
for (int i = 1; i <= termos; i++) {
    int TermoAtual = TermoInicial + (i - 1) * r;
    Console.Write($"{TermoAtual} ");
}


