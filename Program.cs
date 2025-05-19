// Exercício HorasExtras
// Escreva uma função que calcule o salário de um funcionário 
// a partir salário-hora base, o total de horas trabalhadas e 
// número de horas-extras executadas. 
// Considere que cada hora-extra é paga com acréscimo de 40%.

//Solicita entrada...
Console.Clear();
double salarioHoraBase, horasTrabalhadas, horasExtras;
// double salarioFinal = CalculaSalario(salarioHoraBase, horasTrabalhadas, horasExtras);

Console.BackgroundColor = ConsoleColor.DarkGray;

Console.WriteLine("---- Seja bem-vindo à Calculadora de Horas Extras ----");

Console.Write("Digite o valor do Salário/Hora-Base:");
salarioHoraBase = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quantidade de Horas Trabalhadas:");
horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quantidade de Horas Extras:");
horasExtras = Convert.ToDouble(Console.ReadLine());

double salario = salarioHoraBase * horasTrabalhadas;
double salarioTotal = CalculaSalario(salarioHoraBase, horasTrabalhadas, horasExtras);


//Receber a entrada do usuário e converter...
//salario = CalculaSalario(.......);
//Exibir saida

Console.WriteLine($"O salário sem horas extras é: {salario:C2}");
Console.WriteLine($"O salário com horas extras é: {salarioTotal:C2}");
Console.ResetColor();


//Executar função CalculaSalario
double CalculaSalario(double salarioHoraBase, double horasTrabalhadas, double horasExtras)
{
    double salarioSemHorasExtras = salarioHoraBase * horasTrabalhadas;
    double valorHorasExtras = horasExtras * (salarioHoraBase * 1.4);
    return salarioSemHorasExtras + valorHorasExtras;
}

// _________ CalculaSalario(.......)
// {
//     //lógica
// }
