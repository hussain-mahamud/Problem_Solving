using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace OOPPRACTICE
{
    public class FirstRound
    {
        public void FindReturnNumber()
        {
            int[] num=new int[3] {1,2,3};
            int result = 0, temp = 0, reminder = 0, new_arr_elem = 0,count=0,decrement=24;
            for(int i=0;i<num.Length;i++)
            {
                result = result * 10 + num[i];
            }
            new_arr_elem = result - decrement;
            temp = new_arr_elem;
            while(temp != 0)
            {
                temp = temp / 10;
                count++;
            }
            int[]res_arr=new int[count];
            int len = count - 1;
            while (new_arr_elem != 0)
            {
                reminder = new_arr_elem % 10;
                res_arr[len--] =reminder;
                new_arr_elem = new_arr_elem / 10;
                
            }
            foreach(int ab in res_arr)
            {
                Console.Write("{0},", ab);
            }

            //Console.WriteLine(count);  

        }
        public void StackProblem()
        {
            Stack stk = new Stack();
            stk.Push("Mahamud");
            stk.Push("Hussain");
            stk.Push("Eshan");
            stk.Pop();
            foreach(var elem in stk)
            {
                Console.Write("{0} ", elem);
            }
        }
    }
}
