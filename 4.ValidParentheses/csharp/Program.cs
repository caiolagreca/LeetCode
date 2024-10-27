/* 
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
An input string is valid if:
Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.

Example 1:
Input: s = "()"
Output: true

Example 2:
Input: s = "()[]{}"
Output: true

Example 3:
Input: s = "(]"
Output: false

Example 4:
Input: s = "([])"
Output: true

Constraints:
1 <= s.length <= 104
s consists of parentheses only '()[]{}'.
 */
namespace LeetCode
{
    class Program1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(IsValid("[()]"));

        }

        static bool IsValid(string s)
        {
            //Criamos um dicitonary para mapear os parenteses de fechamento com seu par de abertura;
            Dictionary<char, char> dic = new Dictionary<char, char>
            {
                {')', '('},
                {'}', '{' },
                {']', '['},
            };


            //Criamos uma pilha para inserir os parenteses de abertura (pilha eh "Last In First Out");
            var stack = new Stack<char>();

            //Iteramos cada caractere da string.
            foreach (char item in s)
            {
                //Verificamos se o item iterado atualmente corresponde a um item key do dictionary, ou seja se eh um parenteses de fechamento, visto que um dictionary funciona como "key, value";
                if (dic.ContainsKey(item))
                {
                    //Sabendo que o item atual eh um item de fechamento, agora precisamos saber se a lista nao esta vazia. Caso nao esteja, utilizamos o metodo Pop(), especifico da Stack, no qual ira remover o ultimo item adicionado na Stack e retorna-lo (lembrando que apenas os parenteses de abertura sao adicionados na stack - isso ocorre mais a frente no codigo);
                    var lastStackItem = stack.Count > 0 ? stack.Pop() : '#';
                    //Agora que temos o ultimo item da stack (um parentese de abertura), vamos verificar se ele eh o par correspondente do item que estamos iterando atualmente (e sabemos que eh um parentese de fechamento);
                    if (lastStackItem != dic[item])
                    {
                        //Caso o parentese de abertura nao seja o par do item iterado atual, a string eh invalida (return false);
                        return false;
                    }
                }
                else
                {
                    //Se o item atual iterado nao for uma "key" no dictionary, ou seja, nao eh um parentese de fechamento, assumimos que é um parêntese de abertura e inserimos o mesmo na stack para futura verificacao com os parenteses de fechamento.
                    stack.Push(item);
                }
            }
            //Apos iterar toda a string, verificamos se a stack esta vazia. Caso esteja, significa que todos os parenteses foram correspondidos. Caso nao esteja vazia, ha parenteses sem seu par, entao retornamos false;
            return stack.Count == 0;
        }
    }

    /* STARTING WITH OPEN PARENTESES NOW IN THE IF-ELSE STATEMENT */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("()[]{}"));

        }

        static bool IsValid(string s)
        {
            Dictionary<char, char> peers = new Dictionary<char, char>
            {
                {'{', '}'},
                {'(', ')'},
                {'[', ']'}
            };

            Stack<char> stack = new Stack<char>();

            // "({})[]"
            foreach (char charactere in s)
            {
                if (peers.ContainsKey(charactere))
                {
                    stack.Push(charactere);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    var topStackItem = stack.Pop();
                    if (charactere != peers[topStackItem])
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}