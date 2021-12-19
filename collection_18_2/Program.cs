using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_18_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = "({()}([{}])[])[]";
            char[] array = startString.ToCharArray();
            List<char> charList = new List<char>();
            charList.AddRange(array);

            Stack<char> que = new Stack<char>();

            for (int i = 0; i < charList.Count; i++)
            {

                switch (charList[i])
                {
                    case '(':
                        que.Push(')');
                        break;
                    case '{':
                        que.Push('}');
                        break;
                    case '[':
                        que.Push(']');
                        break;
                }
                char chEx;
                switch (charList[i])
                {
                    case ')':
                        chEx=que.Pop();
                        if (chEx ==')')
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Скобки расставлены не корректно");
                            Console.ReadKey();
                            return;
                        }
                    case '}':
                        chEx = que.Pop();
                        if (chEx == '}')
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Скобки расставлены не корректно");
                            Console.ReadKey();
                            return;
                        }
                    case ']':
                        chEx = que.Pop();
                        if (chEx == ']')
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Скобки расставлены не корректно");
                            Console.ReadKey();
                            return;
                        }
                        
                }
            }
            if (que.Count==0)
            {
                Console.WriteLine("Скобки расставлены корректно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены не корректно");
            }    
            Console.ReadKey();
        }
    }
}
