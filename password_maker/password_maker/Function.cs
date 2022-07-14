using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace password_maker
{
     class Function
    {
        /*桁数も指定*/
        public static (int,bool) ParseArgse(string[] args)
        {
                  /*ここのreturnのあとの数字をいじることで文字数を決めれる*/
            if (args.Length < 1) return (3,true);

            int digits;
            if(!int.TryParse(args[0],out digits))
            {
                digits= 10;
            }


            if(args.Length < 2) return (10,true);

            bool useMark = args[1] != "0";
       
            return (digits,useMark);
        }



        public static char GetRandomLetter
            (char[] big,char[] little,char[] number,char[] mark,System.Random rand ,bool usemark)
        {
            char[] target;

            int RandMax;
            if (usemark)
              RandMax = 4;
            else
              RandMax = 3;


           
            /*どの配列から文字を選ぶかサイコロをふる*/
            switch (rand.Next(RandMax))
            {
                case 3:
                    target = mark;
                    break;
                case 0:
                    target = big;
                    break;

                case 1:
                    target = little;
                    break;

                default:
                case 2:
                    target = number;
                    break;
            }
            /*次にtargetの中からランダムな文字を選ぶ*/
           return target[rand.Next(target.Length)];
           

        }


    }
}
