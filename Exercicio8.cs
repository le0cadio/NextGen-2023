/* Um grande amigo seu mora numa cidade pequena, onde existem apenas duas empresas de táxi - a Empresa 1 e a Empresa 2. Ambas mudam suas taxas a cada dia e calculam o valor de suas corridas da seguinte forma: uma taxa fixa mais um valor por quilômetro rodado.
Seu amigo é fisioterapeuta e pega táxis diariamente para visitar seus clientes ao redor da cidade. Você decidiu escrever um código para ajudá-lo a decidir qual empresa escolher para cada uma das corridas, baseado no preço.

Sua função receberá 4 valores: TF1 (a taxa fixa da empresa 1), VQR1 (o valor por quilômetro rodado da empresa 1), TF2 (a taxa fixa da empresa 2), VQR2 (o valor por quilômetro rodado da empresa 2), todos em formato string. Seu retorno deve ser uma string em uma das seguintes formas:

“Tanto faz” - para o caso de o valor das duas empresas para qualquer corrida ser igual
“Empresa 1” - se o valor da Empresa 1 for sempre menor que o da Empresa 2
“Empresa 2” - para o caso contrário do citado acima
“Empresa Xpto quando a distância < N, Tanto faz quando a distância = N, Empresa Ypto quando a distância > N” para o caso de a escolha depender da distância a ser percorrida (onde Xpto e Ypto representa 1 ou 2 e N representa a distância).
Exemplo:
TF1 = 2,50
VQR1 = 1,00
TF2 = 5,00
VQR2 = 0,75
Output:
“Empresa 1 quando a distância < 10.0, Tanto faz quando a distância = 10.0, Empresa 2 quando a distância > 10.0” */

using System;
using System.Linq;

public class Challenge
{
    public static string EscolheTaxi(string tf1, string vqr1, string tf2, string vqr2)
    {
        double TF1 = Convert.ToDouble(tf1.Replace('.', ','));
        double VQR1 = Convert.ToDouble(vqr1.Replace('.', ','));
        double TF2 = Convert.ToDouble(tf2.Replace('.', ','));
        double VQR2 = Convert.ToDouble(vqr2.Replace('.', ','));
        double[] distancias = new double[] { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        var valores1 = distancias.Select(x => TF1 + VQR1 * x);
        var valores2 = distancias.Select(x => TF2 + VQR2 * x);
        if (valores1.Min() == valores2.Min() && valores1.Max() == valores2.Max())
        {
            return "Tanto faz";
        }
        else if (valores1.Min() < valores2.Min() && valores1.Max() < valores2.Max())
        {
            return "Empresa 1";
        }
        else if (valores1.Min() > valores2.Min() && valores1.Max() > valores2.Max())
        {
            return "Empresa 2";
        }
        else
        {
            return $"Empresa 1 quando a distância < {valores1.Min()}, Tanto faz quando a distância = {valores1.Min()}, Empresa 2 quando a distância > {valores1.Min()}";
        }
    }
}
