using System;
using System.Collections.Generic;


  public struct Zutat
  {
    public string zutat;
    public int menge;
    public Zutat(string z, int m)
    {
      this.zutat = z;
      this.menge = m;
    }
  }

class Program 
{

  
  public static void Main (string[] args) 
  {
  string[] all_lebensmittel = {"mehl", "zucker", "salz", "apfel"};
  string[] rezepte = {"Kuchen", "Kekse", "Brot", "Pizza"};
  string[,] rezept_zutaten = new string[,]{{"mehl", "zucker"}, {"zucker", "salz"}, {"mehl", "salz"}, {"mehl", "apfel"}};
  int[,] zutaten_mengen = new int[,]{{350, 200}, {200, 100}, {500, 100}, {400, 100}};
  int[] machbar_zutaten = {};
  int[] machbar_mengen = {};
  List<Zutat> vorhandene_zutaten = new List<Zutat>();
  string temp_zutat;
  int temp_menge;
  string temp_inp;

  do
  {
    Console.WriteLine("Welche Zutat ist am Start?");
    temp_zutat = Console.ReadLine();
    Console.WriteLine("Wie viel davon?");
    temp_menge = Convert.ToInt32(Console.ReadLine());
    vorhandene_zutaten.Add(new Zutat(temp_zutat, temp_menge));
    do
    {
      Console.WriteLine("Weitere Zutaten? (J/N)");
      temp_inp = Console.ReadLine();
    } while(temp_inp!="J" && temp_inp!="j" && temp_inp!="N" && temp_inp!="n");
    if (temp_inp == "J" || temp_inp == "j") continue;
    else if (temp_inp == "N" || temp_inp == "n") break;  
  } while(true);

  Console.WriteLine("Wir haben: \n");
  foreach (Zutat z in vorhandene_zutaten)
  {
    Console.WriteLine(z.zutat + ":\t" + z.menge + "g\n");
  }
      



  }


  
}