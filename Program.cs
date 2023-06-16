//By Silktz

int valor = -1;

Console.WriteLine("--- Entrada Válida ---");

Thread.Sleep(1500);

while (valor < 0 || valor >9)
{
    Console.WriteLine("Digite um número entre 1 e 9 (ou 0 para cancelar)...:");
    valor = Convert.ToInt32(Console.ReadLine()!.Trim());
}
if (valor >= 10)
{
Console.WriteLine("Valor Invalido, Digite um numero de 1 a 9 ");
}
else
{
if (valor == 0)
{
    Console.WriteLine("Operação Cancelada.");

    Thread.Sleep(1500);

    Console.WriteLine("Encerrando.....");
    Environment.Exit(1);

}
else
{
    Console.WriteLine($"Número Selecionado: {valor} é valido");
}}