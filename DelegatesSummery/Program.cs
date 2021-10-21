using System;

namespace DelegatesSummery
{
    class Program
    {
        static Func<string, string, string> getName
            = (firstName, lastName) 
            => 
            firstName + " " + lastName;



        static Func<string, int, string> getAge = (name, age) =>
               name + " You are " + age + " years old";


        static Action<int> makeBreakfast = (numberOfGuests) =>
        {
            //MakeCofee(numberOfGuests);
            //MakeEgss(numberOfGuests);
        };


        static Func<int, bool> isAllowedToBuyGeneral = age => age >= 18;

        static Func<int, bool> isAllowedToBuyAlcohol = age => age >= 16 && DateTime.Now.Hour < 23 && DateTime.Now.Hour > 5;

        static Predicate<int> isOldMan = age => age >= 120;

        static Predicate<Sal> isOrangesCountEven = sal => sal.CountOfOranges % 2 == 0;

        static Func<DateTime> getEfraimsBirthDate = () => DateTime.Now.AddYears(-29);

        class Sal {
            public int CountOfOranges { get; set; }
        }
        static void Main(string[] args)
        {
            makeBreakfast += (numberOfHaHaHa) => {

                for (int i = 0; i < numberOfHaHaHa; i++)
                {
                   Console.Write("ח"); 
                }
            };

            makeBreakfast(2);

            Sal firstSal = new Sal() { CountOfOranges = 56 };
            
            var b = isOrangesCountEven(firstSal);
            firstSal.CountOfOranges = 51;
            b=isOrangesCountEven(firstSal);


            DateTime efraimBirthDate = getEfraimsBirthDate();

        }
    }
}
