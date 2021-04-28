using System;
using System.Collections.Generic;

namespace Aula10
{
  public class Figura
  {
    public double area;
    public double perimetro;
  }

public class Circulo : Figura 
{
    public double raio;
    public double reserva;
    public Circulo(double value)
    {
        this.raio = value;
    }

    public void WriteDadosC()
    {
      this.AtualizarAreaEPerimetro();
      Console.WriteLine();
      Console.WriteLine("----------------");
      Console.WriteLine("Circulo");
      Console.WriteLine("Raio: " + this.raio);
      Console.WriteLine("Area" + this.area);
      Console.WriteLine("Perimetro" + this.perimetro);
      Console.WriteLine("----------------");
      Console.WriteLine();
    }
    public void AtualizarAreaEPerimetro()
    {
        if(raio < 0)
        {
          Console.WriteLine("");
          Console.WriteLine("--------------");
          Console.WriteLine("Raio inválido");
          Console.WriteLine("Utilizando a versão anterior");
          Console.WriteLine("--------------");
          Console.WriteLine("");
          raio = reserva;
        }
        else
        {
          reserva = raio;
        }
        this.area = Math.PI * this.raio * this.raio;
        this.perimetro = 2 * Math.PI * this.raio;
    }
}

public class Retangulo : Figura 
{
    private double basse;
    private double altura;

    private void Ret(double basse, double altura)
    {
      this.basse = basse;
      this.altura = altura;
    }

    public void WriteDadosC()
    {
      Console.WriteLine();
      Console.WriteLine("--------------");
      Console.WriteLine("Retangulo");
      Console.WriteLine("Base: " + this.basse);
      Console.WriteLine("Altura: " + this.altura);
      var ar = this.basse * this.altura;
      Console.WriteLine("Area: " + ar);
      var per = this.basse + this.basse + this.altura + this.altura;
      Console.WriteLine("Perimetro: " + per);
      Console.WriteLine("--------------");
      Console.WriteLine();
    }
}
  class Program
{
    static void Main(string[] args)
    {
      List<Figura> Figuras = new List<Figura>();
      Circulo circ1 = new Circulo(2.0);
      Figuras.Add(circ1);
      Circulo circ2 = new Circulo(5.0);
      Figuras.Add(circ2);
      Circulo circ3 = new Circulo(3.0);
      Figuras.Add(circ3);

      Retangulo ret1 = new Retangulo();
      Figuras.Add(ret1);
      Retangulo ret2 = new Retangulo();
      Figuras.Add(ret2);
      Retangulo ret3 = new Retangulo();
      Figuras.Add(ret3);

      



    }
}
}