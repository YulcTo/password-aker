using System;
using password_maker;


namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            (int digits,bool usemark)=Function.ParseArgse(args);
            var rand=new System.Random();

            char[] bigletters = new char[]
            {
                'A','B','C','D','E','F','G','H','I','J','K',
                'L','M','N','O','P','Q','R','S','T','U','V',
                'W','X','Y','Z'};
            char[] litteleLetters = new char[]
            {
                'a','b','c','d','e','f','g','h','i','j','k',
                'l','m','n','o','p','q','r','s','t','u','v',
                'w','x','y','z'};
            char[] numberletters = new char[]
            {
                '0','1','2','3','4','5','6','7','8','9'
            };

            char[] markletters = new char[]
            {
                '-','_','+','*','#','$','%','&'
            };


            Console.WriteLine("ボタンを押すとランダムに文字が入力されます。:");
               Console.ReadLine();
            string result="";
            for (int i = 0; i < digits; i++)
            {
                char letter =
                Function.GetRandomLetter
                (bigletters, litteleLetters, numberletters,markletters , rand, usemark);

                result += letter;
            }
            Console.WriteLine(result);

         
           

        }
    }
}














