using System.Data;
using System.IO.Pipelines;
using CalculatR.Models;

namespace CalculatR.Services;
public class CalculatorService
{
    public Calculation Calculate(double firstNumber, double secondNumber, string operation)
    {
        double result;
        switch(operation)//nega switch ko'p variant bo'lgani uchun switch aniqroq o'qishga qulayroq 
        {
            case "+":
               result = firstNumber + secondNumber;
               break;
            case "-":
               result = firstNumber - secondNumber;
               break;
            case "*":
               result = firstNumber * secondNumber;
               break;
            case "/":
               result = firstNumber / secondNumber;
               break;
            default:
                 throw new Exception ("Bunday amal mavjud emas");//xato holatini bildirish uchun
        }

         return new Calculation(
            firstNumber,
            secondNumber,
            operation,
            result,
            DateTime.Now 
            );
        
    }
}
