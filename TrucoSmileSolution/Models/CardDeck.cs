using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class CardDeck
    {

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Card> Deck { get; set; }

    public CardDeck() { }

    public CardDeck(int id, string name, string description, List<Card> deck)
    {
        Id = id;
        Name = name;
        Description = description;
        Deck = deck;
    }

    
}
