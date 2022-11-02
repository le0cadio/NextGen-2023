/* Ao se comparar se uma string é maior que outra, considera-se a ordem alfabética ou lexicográfica. No caso, “abcd” < “adbc” < “bacd”.

Escreva uma função que receba uma string A e retorne uma string B, sendo que B é composta pelos mesmos caracteres que A reordenados.

B deve obedecer às seguintes condições:

Ser maior que A
Ser a menor string possível que cumpra as condições acima
Caso não seja possível encontrar uma string que cumpra as condições, retorne a string “sem reposta”.
Por exemplo:

A = “ab”
Logo, o resultado será “ba”

A = “abcde”
Logo, o resultado será “abced”

A = “ba”
Nesse caso, o resultado será “sem resposta" */

using System.Linq;
using System;

public class Challenge
{
    public static string EncontraString(string A)
    {
        if (A.Length < 2)
            return "sem resposta";
        var chars = A.ToCharArray().OrderBy(x => x).ToArray();
        for (int i = 0; i < chars.Length - 1; i++)
        {
            if (chars[i] != chars[i + 1])
            {
                var temp = chars[i];
                chars[i] = chars[i + 1];
                chars[i + 1] = temp;
                return new string(chars);
            }
        }
        return "sem resposta";
    }
}
