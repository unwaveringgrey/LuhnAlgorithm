namespace ProgrammingPractice.Models
{
    public static class LuhnAlgorithm
    {
        /*valid Luhn inputs
        *123456782
        *12345678C
        *1234E
        */
        //The Luhn algorithm sometimes uses letters instead of numbers for the check character. There doesn't seem to be a standard for the mapping of letters to numbers.
        //So the letters A - J are used to represent 0-9 respectively.
        //this could potentially be updated to take a dictionary specified letter-number pairings in the future.
        static Dictionary<string, int> LuhnsDictionary = new Dictionary<string, int>() { { "A", 0 }, { "B", 1 }, { "C", 2 }, { "D", 3 },
                                                          { "E", 4 }, { "F", 5 }, { "G", 6 }, { "H", 7 }, { "I", 8 }, { "J", 9 }};

        public static bool Validate(string input, bool allowLuhnNumbers = true)
        {
            string validator = input.Substring(input.Length - 1);
            if (!((allowLuhnNumbers && Char.IsLetterOrDigit(validator, 0)) || Char.IsLetter(validator, 0)))
                return false;
            char[] inputCharArray = input.Substring(0, input.Length - 1).ToCharArray();
            Array.Reverse(inputCharArray);
            string luhnNumbers = new string(inputCharArray);

            int total = 0;
            for (int i = 0; i < luhnNumbers.Length; i++)
            {
                if (i%2 == 0)
                {
                    total += DigitAddition((Int32.Parse(luhnNumbers.Substring(i, 1)) * 2).ToString());
                } else
                {
                    total += DigitAddition(luhnNumbers.Substring(i, 1));
                }
            }

            total = (10 - (total % 10)) % 10;

            if ( (allowLuhnNumbers && Char.IsNumber(validator, 0) && Int32.Parse(validator) == total) ||
                (Char.IsLetter(validator, 0) && LuhnsDictionary[validator] == total) )
                return true;

            return false;
        }

        private static int DigitAddition(string input)
        {
            int result;

            if (input.Length > 1)
            {
                result = 0;
                char[] inputSplit = input.ToCharArray();
                foreach (char s in inputSplit)
                {
                    result += Int16.Parse(s.ToString());
                }

                return result;
            }
            else
            {
                result = Int32.Parse(input);
                return result;
            }
        }

    }
}
