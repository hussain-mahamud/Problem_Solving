using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Runtime.ExceptionServices;

namespace OOPPRACTICE
{
    internal class Program
    {
        // Single ward palindrome check
        public void StringPalindromeCheck()
        {
            string text, rev = "";
            Console.WriteLine("Enter text:");
            text=Console.ReadLine();
            for(int i = text.Length - 1; i >= 0; i--)
            {
                rev+=text[i].ToString();
            }
            if (text.Equals(rev))
            {
                Console.WriteLine("This string is palindrome");
            }
        }
        // Sentence Palindrome word Count
        public bool CheckPalindrome(string word)
        {
            int n = word.Length;
            word = word.ToLower();
            for (int i = 0; i < n; i++,n--){
                if (word[i] != word[n - 1])
                {
                    return false;
                }
            }

            return true;
        }
        public void SentencePalindromeCount()
        {
            string sentence = "",word="";
            List<string> lst = new List<string>();
            Console.WriteLine("Enter text:");
            sentence = Console.ReadLine();
            sentence = sentence + " ";
            int count = 0;
            for (int i=0; i < sentence.Length; i++)
            {
                char ch = sentence[i];
                if(ch !=' ')
                {
                    word += ch;
                }
                else
                {
                    if (CheckPalindrome(word))
                    {
                        count++;
                        lst.Add(word);
                    }
                    word = "";
                }
            }
            Console.WriteLine(count);
            foreach(string list in lst)
            {
                Console.Write(list+",");
            }


        }
        // Check Anagram
        public bool CheckAnagram()
        {
            string str1,str2;
            Console.WriteLine("Enter First String:");
            str1=Console.ReadLine();
            str2=Console.ReadLine();
            int n1=str1.Length;
            int n2=str2.Length;
            if(n1 != n2)
            {
                return false;
            }
            char[] char1=str1.ToCharArray();
            char[] char2=str2.ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
            for(int i = 0; i < n1; i++)
            {
                if (char1[i] != char2[i])
                {
                    return false;
                }
            }
            return true;
        }
        public void ReverseEveryWord()
        {
            string str1;
            str1=Console.ReadLine();
            str1 = str1 + " ";
            string str2="";
            string word="";
            string temp = "";
            for(int i = 0; i < str1.Length; i++)
            {
                char ch = str1[i];
               
                if(ch !=' ')
                {
                    word+=ch.ToString();
                }
                else
                {
                    for(int j= word.Length-1;j>=0; j--)
                    {
                        temp+=word[j].ToString();
                    }
                    str2+=temp+ch.ToString();
                    word = "";
                    temp = "";
                }

            }
            Console.WriteLine(str2);

        }
        public void RotateArrayCyclicallyClockWise()
        {
            int[] arr = new int[6] { 1, 2, 3, 4, 5, 6 };
            int temp = arr[arr.Length-1];
            for(int i= arr.Length-1;i>0;i--)
            {
                arr[i]=arr[i-1];
            }
            arr[0] = temp;
            foreach(int elem in arr)
            {
                Console.Write(elem + " ");
            }
        }     
        public void RotateArrayAntiClockWise()
        {
            int[] arr = new int[6] { 1, 2, 3, 4, 5, 6 };
            int temp = arr[0];
            for(int i = 0; i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length-1] = temp;
            foreach(int elem in arr)
            {
                Console.Write(elem + " ");
            }
        }
        public void MergeTwoArrayAndSortAsc()
        {
            int[] arr1 = new int[4] { 56, 23, 1, 7 };
            int[] arr2 = new int[4] { 5, 567, 5, 8 };
            int n = arr1.Length;
            int m = arr2.Length;
            int[] merge_arr = new int[n + m];
            int a = 0, b = 0, k = 0;
            while (a < n)
            {
                merge_arr[k++]=arr1[a++];
            }
            while (b<m)
            {
                merge_arr[k++] = arr2[b++];
            }
            
            int temp = 0;
            for(int i = 0; i < merge_arr.Length - 1; i++)
            {
                for(int j = i + 1; j < merge_arr.Length; j++)
                {
                    if (merge_arr[i] > merge_arr[j])
                    {
                        temp = merge_arr[i];
                        merge_arr[i] = merge_arr[j];
                        merge_arr[j] = temp;    
                    }
                }

            }
            foreach (int elem in merge_arr)
            {
                Console.Write(elem + " ");
            }


        }
        public void MergeTwoArrayAndSortDesc()
        {
            int[] arr1 = new int[4] { 56, 23, 1, 7 };
            int[] arr2 = new int[4] { 5, 567, 5, 8 };
            int n = arr1.Length;
            int m = arr2.Length;
            int[] merge_arr = new int[n + m];
            int a = 0, b = 0, k = 0;
            while (a < n)
            {
                merge_arr[k++] = arr1[a++];
            }
            while (b < m)
            {
                merge_arr[k++] = arr2[b++];
            }

            int temp = 0;
            for (int i = 0; i < merge_arr.Length - 1; i++)
            {
                for (int j = i + 1; j < merge_arr.Length; j++)
                {
                    if (merge_arr[i] < merge_arr[j])
                    {
                        temp = merge_arr[i];
                        merge_arr[i] = merge_arr[j];
                        merge_arr[j] = temp;
                    }
                }

            }
            foreach (int elem in merge_arr)
            {
                Console.Write(elem + " ");
            }


        }
        public void AbsoluteDifferenceOfEvenAndOddNumber()
        {
            int[] arr = new int[5] { 2, 3, 4, 5,6 };
            int even_num = 0;
            int odd_num = 0;    
            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even_num+=arr[i];
                }
                else
                {
                    odd_num+=arr[i];
                }
            }
            Console.WriteLine("Absolute difference:{0}",Math.Abs(even_num-odd_num));
        }
        public bool StringAnagramCheck()
        {
            string str1 = "Silent".ToLower();
            string str2 = "Listenw".ToLower();
            if(str1.Length != str2.Length)
            {
                return false;               
            }
            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            for(int i = 0; i < ch1.Length; i++)
            {
                if(ch1[i] != ch2[i])
                {
                    return false;
                }
            }
            return true;

        }
        public void NumberPalindromeCheck()
        {
            int num = 1215;
            int temp = num,reminder=0,new_num=0;
            while(temp > 0)
            {
                reminder = temp % 10;
                new_num=new_num*10+reminder;
                temp=temp / 10;
            }
            if (num == new_num)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
        public void FindDuplicateElements()
        {
            int[] arr = new int[5] { 4, 5, 3, 4, 5 };
            //HashSet <int> lst=new HashSet<int> ();
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j=i+1;j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
            /*foreach(int a in lst)
            {
                Console.WriteLine (a);
            }*/
        }
        public void FindUniqueElement()
        {
            int[] num=new int[5] {1,2,1,3,4};
            HashSet<int> hsh = new HashSet<int>();
            for(int i = 0; i < num.Length; i++)
            {
                int count = 0;
                for(int j=0;j<num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        count++;
                    }
                }
                if(count ==1)
                {
                    Console.WriteLine(num[i]);  
                }
            }
            
            
        }
        public bool IPAddressValidation()
        {
            string ip = "191.176.107.256";
            string[] parts=ip.Split('.');
            if(parts.Length == 4)
            {
                for(int i=0;i<parts.Length;i++)
                {
                    if(i==0 && int.Parse(parts[0]) == 0)
                    {
                        return false;
                    }
                    if (int.Parse(parts[i])<0 || int.Parse(parts[i]) > 255)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;


            }
        }
        public bool CheckPangram()
        {
            string str = "Waltz, nymTh, for quick jigs vex Bud";
            str = str.ToLower();
            bool[] marks = new bool[26];
            int index = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i]>='a' && str[i] <= 'z')
                {
                    index = str[i] - 'a';
                    marks[index] = true;    
                }
            }
            for(int i = 0; i < marks.Length; i++)
            {
                if (marks[i] == false)
                {
                    return false;
                }
            }
            return true;
        }
        public void SeriesUpAndDown()
        {
            for(int i = 1; i <20; i++)
            {
                Console.Write("{0},", 10 - Math.Abs(10 - i));
            }
        }
        public void FindAvgArrayExcludeMinMax()
        {
            int[] num = new int[5] { 1,2,3,4,5 };
            int min = num[0], max = num[0];
            int sum =0;
            for(int i = 0; i < num.Length; i++)
            {
                if (min > num[i])
                {
                    min = num[i];
                }
                if (max < num[i])
                {
                    max= num[i];    
                }
                sum += num[i];
            }
            sum = (sum - min - max) / (num.Length - 2);
            Console.WriteLine("Sum is :{0}", sum);
        }
        public int GetGcd(int num,int lcm)
        {
            if (lcm == 0)
                return num;
            return GetGcd(lcm, num%lcm);
        }
        public void FindLcm()
        {
            int[] num = new int[4] { 2, 4, 8, 16 };
            int lcm = num[0];
            int gcd = num[0];
            for(int i=0; i < num.Length; i++)
            {
                gcd = GetGcd(num[i], lcm);
                lcm = num[i] * lcm / gcd;
            }
            Console.WriteLine(lcm);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            FirstRound fst = new FirstRound();
            //fst.StackProblem();
            //fst.FindReturnNumber();
            //p.FindLcm();
            //p.FindAvgArrayExcludeMinMax();
            //p.SeriesUpAndDown();
            //Console.WriteLine(p.CheckPangram());
            /*if (p.IPAddressValidation())
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Not valid");
            }*/
            //p.FindUniqueElement();
            //p.FindDuplicateElements();
            // p.NumberPalindromeCheck();
            // p.AbsoluteDifferenceOfEvenAndOddNumber();
            /*if (p.StringAnagramCheck())
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not");
            }*/
            //p.MergeTwoArrayAndSortDesc();
            //CaesarCipher ccp = new CaesarCipher();
            //string text = "Hello Sajeeb. Kmn Aso Bondhu";
            //Console.WriteLine(ccp.Encryption(text,3));
            // Console.WriteLine(ccp.Decryption(text,3));
            //p.RotateArrayCyclicallyClockWise();
            //p.RotateArrayAntiClockWise();
            //Single Word Palindrome
            //p.StringPalindromeCheck();
            // Count number of palindrome
            //p.SentencePalindromeCount();
            /*if (p.CheckAnagram())
            {
                Console.WriteLine("This is anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }*/
            //p.ReverseEveryWord();

        }
    }
}
