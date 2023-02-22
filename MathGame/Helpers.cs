namespace MathGame
{
    internal class Helpers
    {
        public int GetRandomNumber(int num1, int num2) {
            Random rnd = new Random();
            int randomNumber = rnd.Next(num1, num2);
            return randomNumber;
        }

    }
}
