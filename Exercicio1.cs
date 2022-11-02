/* Você e seu time estão desenvolvendo um sistema de indicações de postos de gasolina que ficam próximos da localização atual do veículo. No modo de direção “viagem”, a funcionalidade a ser desenvolvida é de indicar ao condutor o posto mais distante possível dentro do limite atual de combustível. E caso não exista posto de gasolina, retornar -1

A pessoa responsável por fazer a especificação do sistema informou que você terá as seguintes informações: consumo médio de combustível, quantidade de combustível restante no veículo e um array contendo distâncias dos postos de gasolinas.

Exemplo:
Combustivel (em litros): 2
Consumo médio (km/l): 8
Postos de Gasolina (km): [2, 15, 22, 10.2] */

using System.Linq;
public class Challenge
{
    public static int UltimaParada(int combustivel,int consumo,int[] postosDeGasolina)
    {
        int distancia = combustivel * consumo;
        int[] postos = postosDeGasolina.Where(x => x <= distancia).ToArray();
        return postos.Length > 0 ? postos.Max() : -1;
    }
}
