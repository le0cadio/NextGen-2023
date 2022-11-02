/*Durante uma expedição tecnológica, sua equipe encontrou o que parece ser a senha que lhes dá acesso a um grande tesouro digital. Por sorte, sua equipe é formada pelas pessoas mais feras em programação e vocês rapidamente descobriram como decifrá-la.

Com a possibilidade de que vocês encontrem mais códigos contendo outras senhas, você foi designado à tarefa de desenvolver um algoritmo que decifra os códigos para não precisarem fazer isso de forma manual.

A senha é representada por um número binário de 10 dígitos formado pelo dígito predominante de cada coluna. Caso a coluna tenha a mesma quantidade de dígitos 0 e 1, deve se considerar o número 1.

Exemplo: A primeira coluna da lista tem como dígito predominante o número 1, sendo assim, o primeiro dígito - dos 10 - da senha é 1.

0110100000
1001011111
1110001010
0111010101
0011100110
1010011001
1101100100
1011010100
1001100111
1000011000

Desenvolva um algoritmo que receba um array de valores binários (como o exemplo acima) e retorne a representação decimal da senha. */



using System.Linq;
using System;

public class Challenge
{
    public static int CalculaNumeroDaSenha(string[] senha)
    {
        string[] valores = new string[10];
        for (int i = 0; i < senha.Length; i++)
        {
            for (int j = 0; j < senha[i].Length; j++)
            {
                valores[j] += senha[i][j];
            }
        }
        return Convert.ToInt32(
            string.Join("", valores.Select(x => x.Count(y => y == '1') > 4 ? 1 : 0)),
            2
        );
    }
}
