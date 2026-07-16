using CalculatR.Models;//calculation classi models papkasida joylashgan. bu using bo'lmasa tanimaydi
using CalculatR.Services;
CalculatorService
calculatorService = new CalculatorService();
ReportService reportService = new ReportService();

List<Calculation> calculations = new List<Calculation>();
while (true)
{
Console.Write("Birinchi sonni kiriting:");
double firstNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Ikkinchi sonni kiriting:");
double secondNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Amalni kiriting (+, -, *, /,);");
string operation = Console.ReadLine();
Calculation calculation = calculatorService.Calculate(firstNumber,secondNumber,operation);
calculations.Add(calculation);
reportService.ShowReport(calculations);
Console.Write("Yana hisoblashni xohlaysizmi? (ha/yo'q)");
string answer = Console.ReadLine();
if (answer == "yo'q")
    {
        break;
    }
}

