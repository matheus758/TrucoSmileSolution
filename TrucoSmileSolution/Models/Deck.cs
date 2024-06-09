using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrucoSmileSolution.Models;

public class Deck
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Card> Cards { get; set; }

    public Deck(int id, string name) {
    Id = id;
        Name = name;
        Cards = DeckSantista();
    }

    public List<Card> DeckSantista()
    {
        List<Card> list = new List<Card>();
        for (int i = 0; i < 4; i++)
        {
            int id = 0;
            Suites suites = new Suites();
            suites = (Suites)i;

            list.Add(new Card(id + i, "Dama " + suites.ToString(), suites, -3, false, true, false, "Dama de " + suites.ToString()));
            list.Add(new Card(id + i + 4, "Valete " + suites.ToString(), suites, -2, false, true, false, "Valete de " + suites.ToString()));
            list.Add(new Card(id + i + 8, "Rei " + suites.ToString(), suites, -1, false, true, false, "Rei de " + suites.ToString()));

            list.Add(new Card(id + i + 12, "Ás " + suites.ToString(), suites, 0, false, true, false, "Ás de " + suites.ToString()));
            list.Add(new Card(id + i + 16, "2 " + suites.ToString(), suites, 1, false, true, false, "2 de " + suites.ToString()));
            list.Add(new Card(id + i + 20, "3 " + suites.ToString(), suites, 2, false, true, false, "3 de " + suites.ToString()));

            id++;

        }

        list.OrderBy(x => x.Id);
        return list;
    }

}

