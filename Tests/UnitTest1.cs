namespace Tests;
using NewTalents.Services;

public class UnitTest1
{
    public Calculadora construirClasse(){
        string data = "05/11/2024";
        Calculadora calc = new Calculadora(data);

        return calc;

    }
    [Theory]
    [InlineData(1,2,3)]
    [InlineData(4,5,9)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        var resultadoSoma = calc.Somar(val1,val2);

        Assert.Equal(resultado, resultadoSoma);
       
    }

    [Theory]
    [InlineData(1,2,2)]
    [InlineData(4,5,20)]
    public void TesteMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        var resultadoSoma = calc.Multiplicar(val1,val2);

        Assert.Equal(resultado, resultadoSoma);
       
    }

    [Theory]
    [InlineData(2,1,2)]
    [InlineData(6,2,3)]
    public void TesteDividir(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        var resultadoSoma = calc.Dividr(val1,val2);

        Assert.Equal(resultado, resultadoSoma);
       
    }

    [Theory]
    [InlineData(2,1,1)]
    [InlineData(6,2,4)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        var resultadoSoma = calc.Subtrair(val1,val2);

        Assert.Equal(resultado, resultadoSoma);
       
    }
    
    [Fact]
    public void TestarDivisaoPorZero(){


        Calculadora calc = construirClasse();

        Assert.Throws<DivideByZeroException>(()=>calc.Dividr(3,0));

    }
    [Fact]
    public void TestarHistorico(){

        Calculadora calc = construirClasse();

        calc.Somar(1,2);
        calc.Somar(2,8);
        calc.Somar(3,7);
        calc.Somar(4,1);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3,lista.Count);

    }













}