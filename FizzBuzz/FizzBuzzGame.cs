namespace FizzBuzz
{
    public static class FizzBuzzGame
    {
        public static string Play(int number)
        {
            if(number % 15 == 0)
                return "FizzBuzz";
            if(number % 5 == 0)
                return "Buzz";
            if(number % 3 == 0)
                return "Fizz";
            return number.ToString();
        }

        
    }
}
