using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrucoSmileSolution.Models;

public class Card
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public Suites Naipe { get; set; }
    public int Strenght { get; set; }
    public bool Manilha { get; set; }
    public bool Avaliable { get; set; }
    public bool DiscartPile { get; set; }
    public string Description { get; set; }


    public Card() { }

    public Card(int id, string name,Suites naipe, int strenght,bool manilha, bool avaliable, bool discartPile,string description)
    {
        Id = id;
        Name = name;
        Naipe = naipe;
        Strenght = strenght;
        Manilha = manilha;
        Avaliable = avaliable;
        DiscartPile = discartPile;
        Description = description;

    }

}
