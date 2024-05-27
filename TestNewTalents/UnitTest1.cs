using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using NewTalents;

namespace TestNewTalents;

public class UnitTest1
{

    public Calculadora construirClasse(){
        string data = "02/02/2020"; 
        Calculadora calc = new Calculadora(data);
        return calc;
    }

    [Theory]
    [InlineData(1,2,3)]
    [InlineData(4,5,9)]
    public void TesteSomar(int v1, int v2, int resultado){
        Calculadora calc = construirClasse();
        int resultadoCalculdora = calc.Somar(v1,v2);

        Assert.Equal(resultado, resultadoCalculdora);

    }

    [Theory]
    [InlineData(6,2,4)]
    [InlineData(5,5,0)]
    public void TesteSubtrair(int v1, int v2, int resultado){
        Calculadora calc = construirClasse();
        int resultadoCalculdora = calc.Subtrair(v1,v2);

        Assert.Equal(resultado, resultadoCalculdora);

    }

    [Theory]
    [InlineData(1,2,2)]
    [InlineData(4,5,20)]
    public void TesteMultiplicar(int v1, int v2, int resultado){
        Calculadora calc = construirClasse();
        int resultadoCalculdora = calc.Multiplicar(v1,v2);

        Assert.Equal(resultado, resultadoCalculdora);

    }

    [Theory]
    [InlineData(6,2,3)]
    [InlineData(5,5,1)]
    public void TesteDividir(int v1, int v2, int resultado){
        Calculadora calc = construirClasse();
        int resultadoCalculdora = calc.Dividir(v1,v2);

        Assert.Equal(resultado, resultadoCalculdora);

    }

    [Fact]
    public void TesteDividirPorZero(){
        Calculadora calc = construirClasse();
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
    }

    [Fact]
    public void TesteHistorico(){
        Calculadora calc = construirClasse();
        
        calc.Somar(1,2);
        calc.Somar(9,8);
        calc.Somar(0,6);
        calc.Somar(7,2);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);

    }




}