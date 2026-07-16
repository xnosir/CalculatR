//amal tarixi birinchi son ikkinchi son amal, natija 
//vazifasi: faqat ma'lumot saqlash 
using System.Data;
using System.Net.Security;

namespace CalculatR.Models;//Calculation klassi models papkasiga tegishli ekanini bildiradi keyinchalik boshqa fayllar undan foydalana oladi
public class Calculation//Calculation yangi ma'lumot turi  bitta hisoblashni ifodalaydi
{
    private double _firstNumber;//nima uchun double? chunki foydalanuvchi 5,5 kabi sonlar kiritishi ham mumkin  . nima uchun public? chunki CalculatorService bu qiymatni o'qishi va o'zgartirishi kerak . nima uchun get; set;  chunki bu property u qiymatni o'qish va yozish imkonini beradi yaniy get qiymatni o'qish olish set qiymatni o'zgartirish yozish uchun ishlatiladi
    //encapsulation qo'shish  nega _ qo'yildi chunki field ekanini darrov ajratish . yashirin ma'lumot !
    public double FirstNumber
    {
        get
        {
            return _firstNumber;//firstNumber uchun o dan katta bo'lsin degan validation qo'ymaymiz chunki bu calkulator manfiy musbat sonlar foydalanuvchi tomonidan kiritilisi mumkim
        }
        set
        
        
        {
            _firstNumber=value;//Foydalanuvchi nima qiymat bersa, o'shani _firstNumber ga saqla 
        }
        
    }
    private double _secondNumber;
    public double SecondNumber
    {
        get
        {
            return _secondNumber;
        }
        set
        {
            _secondNumber=value;
        }
    }
    private string _operation;
    public string Operation //nega string ? chunki son emas amal + - 5
    {
        get
        {
           return _operation;
        }
        set
        {
            _operation=value;
        }
    }
    private double _result;
    public double Result  // nega Result  ham double bo'lishi kerak ? Result ni double qilamiz, chunki matematik amallar natijasi butun son ham kasr son ham bo'lishi mumkin
    {
        get
        {
            return _result;
        }
        set
        {
            _result=value;
        }
    }
    private DateTime _calculationDate;
    public DateTime CalculationDate
    //nega datatime? sana va vaqtni to'g'ri saqlaydi sana bo'yicha saralash OrderBy mumkin.
    {
        get
        {
            return _calculationDate;
        }
        set
        {
            _calculationDate=value;
        }
    }
    public Calculation (//class yaratildi property yozildi constructor yozildi construktor orqali propertylarga qiymat berish tushunildi private field bor get set bor constructor bor constructor orqali propertylarga qiymat berildi encapsulationning asosiy ko'rinishi
    double firstNumber, 
    double secondNumber, 
    string operation, 
    double result, 
     DateTime calculationDate )
    {
      FirstNumber=firstNumber;
      SecondNumber=secondNumber;
      Operation=operation;
      Result=result;
      CalculationDate=calculationDate;
    }
    public override string ToString()
    {
        return $"{FirstNumber} {Operation} {SecondNumber} = {Result} | Sana: {CalculationDate}";
    }
}


