// See https://aka.ms/new-console-template for more information
namespace Exercise1
{
    class UnitConversion
    {

        // Convert All Units to their lowest common denomiator (CM and L)
        public static double ConvertToLCD(double inputNumber, string inputUnit)
        {

            switch (inputUnit)
            {
                case "CM":
                    return inputNumber;
                case "IN":
                    return inputNumber * 2.54;
                case "FT":
                    return inputNumber * 12 * 2.54;
                case "YD":
                    return inputNumber * 3 * 12 * 2.54;
                case "L":
                    return inputNumber;
                case "G":
                    return inputNumber * 3.8;
                case "LB":
                    return inputNumber * 3.8 * 8;
                case "KG":
                    return inputNumber * 3.8 * 8 * 2.2;


            }

            return inputNumber;
                    
        }

        // Taking the Lowest Common Denominator and converting it to the right units
        public static double Conversion(double lcd, string outputUnit)
        {
            double result;
            switch (outputUnit)
            {
                case "CM":
                    return lcd;
                  
                case "FT":
                    result = lcd / 30.48;
                    return result;
                   
                case "IN":
                    result = lcd / 2.54;
                    return result;

                case "YD":
                    result = lcd / 91.44;
                    return result;

                case "L":
                    return lcd;
                case "G":
                    result = lcd / 3.8;
                    return result;
                case "LB":
                    result = lcd / 30.4;
                    return result;

                case "KG":
                    result = lcd / 66.88;
                    return result;
                default:
                    return -1.0;
            }
        }


        // checking if the source units and target units are valid
        public static Boolean isValidUnitConversion(string sourceUnit, string targetUnit)
        {
            switch (sourceUnit)
            {
                case "CM":
                case "IN":
                case "FT":
                case "YD":
                    switch (targetUnit)
                    {
                        case "CM":
                        case "IN":
                        case "FT":
                        case "YD":
                            return true;
                        default:
                            return false;
                    }
                    

                case "G":
                case "LB":
                case "L":
                    switch (targetUnit)
                    {
                        case "G":
                        case "LB":
                        case "L":
                            return true;
                        default:
                            return false;
                    }
                   
                default:
                    return false;
                        
            }
        }
        
        static void Main(string[] args)

        {
            string source = "";
            string target = "";
            string quantity ="";
            double quantityDouble=0.0;
            double lowestCommonDenom;
            double conversionResult;
            Boolean isValidUnits = false;


            while (isValidUnits == false) {
                try
                {
                    Console.WriteLine("Please Input the Quantity of Product: ");
                    quantity = Console.ReadLine();
                    quantityDouble = Convert.ToDouble(quantity);
                    Console.WriteLine("Please Input Source Unit Type (G,L,LB,KG,FT,IN,CM,YD): ");
                    source = Console.ReadLine();
                    source = source.ToUpper();
                    Console.WriteLine("Please Input Desired Unit Type (G,L,LB,KG,FT,IN,CM,YD): ");
                    target = Console.ReadLine();
                    target = target.ToUpper();


                    isValidUnits = isValidUnitConversion(source, target);
                    if (isValidUnits == false)
                    {
                        Console.WriteLine("Invalid Inputs Please Try Again");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Inputs Please Input a number");
                }


            }


            lowestCommonDenom = ConvertToLCD(quantityDouble, source);
            conversionResult = Conversion (lowestCommonDenom, target);
            Console.WriteLine(conversionResult + " "+ target);
                   

               
         

           


            


        }
    }

}
