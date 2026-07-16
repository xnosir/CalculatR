//tarix 
using System.Collections.Generic;

using CalculatR.Models;//Calculation modelidan foydalanish uchun
namespace CalculatR.Services;//ReportService ham CalculatorService kabi Service papkasiga tegishli
public class ReportService//yangi servis yaratish 
{
    public void 
    ShowReport(List<Calculation>calculations)
    {
        if(calculations.Count == 0)
        {
            Console.WriteLine("Hisob-kitoblar mavjud emas. ");
        }
    
    //showreport hisobotni ekranga chiqarish .List calculation obyektlardan iborat ro'yxat calculation shu ro'yxatni nomi
    
        foreach (Calculation calculation in calculations)//foreach ro'yxatdagi har bir elementni bittadan olib ishlash uchun ishlatiladi 1chi kalkulation type ikkinchisi men bergan nom
        {
            Console.WriteLine($"{calculation.FirstNumber}{calculation.Operation}{calculation.SecondNumber} = {calculation.Result}");
        }
    }
}
