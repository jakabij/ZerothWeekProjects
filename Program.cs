using System;

namespace ZerothWeekProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            One f1 = new One();
            f1.circleDatas();
            f1.globeDatas();
            
            Two f2 = new Two();
            f2.descending();
            
            Three f3 = new Three();
            Console.WriteLine(f3.editable());
            
            Four f4 = new Four();
            Console.WriteLine(f4.negativeOrPositive());
            
            Five f5 = new Five();
            Console.WriteLine(f5.toCalculate());
            
            Six f6 = new Six();
            f6.booleanTranslate();
            
            Seven f7 = new Seven();
            f7.avg();
            
            Eight f8 = new Eight();
            f8.dataCalculator();
            
            Nine f9 = new Nine();
            f9.datas();
            
            Ten f10 = new Ten();
            f10.toConvert();
            
            Eleven f11 = new Eleven();
            f11.divisible();
            
            Twelve f12 = new Twelve();
            f12.numberOfDigits();
            
            Thirteen f13 = new Thirteen();
            f13.seasonTime();
            
            Fourteen f14 = new Fourteen();
            f14.isItProfit();
            
            Fifteen f15 = new Fifteen();
            f15.languageAsking();
            
            Sixteen f16 = new Sixteen();
            f16.passwordCheck();
            
            Seventeen f17 = new Seventeen();
            f17.whichSeason();
            
            Eighteen f18 = new Eighteen();
            f18.avgYearCelsius();
            
            Nineteen f19 = new Nineteen();
            f19.coffeeThings();
            
            Twenty f20 = new Twenty();
            f20.cashFactor();
            
            SixtyTwoWorkers f62 = new SixtyTwoWorkers("Jani", "Kp");
            Console.WriteLine("Hello "+f62.name+" your paying category: "+f62.payingCategory);
        }
    }
}
