// 4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
// SP – R$67.836,43
// RJ – R$36.678,66
// MG – R$29.229,88
// ES – R$27.165,48
// outros – R$19.849,53
// Escreva um programa na linguagem que desejar onde calcule o percentual de 
// representação que cada estado teve dentro do valor total mensal da distribuidora.

class program
{

    public static void Main(string[] args)
    {
        var SP = 67_836.43;
        var RJ = 36_678.66;
        var MG = 29_229.88;
        var ES = 27_165.48;
        var outros = 19_848.53;

        var soma = SP + RJ + MG + ES + outros;
        System.Console.WriteLine("A Distribuidora teve um faturamento mensal de R$ {0} (Reais)", soma);

        var percentualContribSP = (SP/soma)*100;        
        System.Console.WriteLine("A contribuição mensal de SP é de {0:00.00}% do total da Distribuidora.", percentualContribSP);
        
        var percentualContribRJ = (RJ/soma)*100;        
        System.Console.WriteLine("A contribuição mensal de RJ é de {0:00.00}% do total da Distribuidora.", percentualContribRJ);

        var percentualContribMG = (MG/soma)*100;        
        System.Console.WriteLine("A contribuição mensal de MG é de {0:00.00}% do total da Distribuidora.", percentualContribMG);

        var percentualContribES = (ES/soma)*100;
        
        System.Console.WriteLine("A contribuição mensal de ES é de {0:00.00}% do total da Distribuidora.", percentualContribES);

        var percentualContribOutros = (outros/soma)*100;        
        System.Console.WriteLine("A contribuição mensal de Outros Estados é de {0:00.00}% do total da Distribuidora.", percentualContribOutros);


    }
}