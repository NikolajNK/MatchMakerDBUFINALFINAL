using MatchMakerDBU.Model;
//Bjørn med tilføjelser fra Nikolaj
namespace MatchMakerDBU.DK
{
    public class Danmark : Holdspiller
    {
        private List<Spiller> _spillere = new List<Spiller>()

        {
            new Spiller(1,"Kasper Schmeichel", 83, SpillerType.Målmand, 1),
            new Spiller(16,"Oliver Christensen", 73, SpillerType.Målmand, 1),
            new Spiller(22,"Frederik Rønnow",75, SpillerType.Målmand, 1),
            new Spiller(4,"Simon Kjær", 82, SpillerType.Forsvar ,1),
            new Spiller(2,"Joachim Andersen", 77, SpillerType.Forsvar, 1),
            new Spiller(6,"Andreas Christensen", 82, SpillerType.Forsvar, 1),
            new Spiller(3,"Victor Nelsson", 75, SpillerType.Forsvar, 1),
            new Spiller(5,"Joakim Mæhle", 75, SpillerType.Forsvar, 1),
            new Spiller(12,"Rasmus Nissen Kristensen", 77, SpillerType.Forsvar, 1),
            new Spiller(18,"Daniel Wass", 79, SpillerType.Forsvar, 1),
            new Spiller(17,"Jens Stryger Larsen", 75, SpillerType.Forsvar, 1),
            new Spiller(26,"Alenxander Bah", 78, SpillerType.Forsvar, 1),
            new Spiller(10,"Christian Eriksen", 82, SpillerType.Midtbane, 1),
            new Spiller(8,"Thomas Delaney", 81, SpillerType.Midtbane, 1),
            new Spiller(23,"Pierre-Emile Højbjerg", 84, SpillerType.Midtbane, 1),
            new Spiller(7,"Mathias Jensen", 75, SpillerType.Midtbane, 1),
            new Spiller(15,"Christian Nørgaard", 76, SpillerType.Midtbane, 1),
            new Spiller(11,"Andreas Skov Olsen", 76, SpillerType.Angriber, 1),
            new Spiller(9,"Marting Braithwaite", 76, SpillerType.Angriber, 1),
            new Spiller(12,"Kasper Dolberg", 77, SpillerType.Angriber, 1),
            new Spiller(14,"Mikkel Damsgaard", 76, SpillerType.Angriber,1),
            new Spiller(27,"Jesper Lindstrøm", 76, SpillerType.Angriber,1),
            new Spiller(19,"Jonas Wind", 76, SpillerType.Angriber,1),
            new Spiller(21,"Andreas Cornelius", 75, SpillerType.Angriber,1),
            new Spiller(20,"Yussuf Poulsen", 77, SpillerType.Angriber,1),
            new Spiller(24,"Robert Skov", 74, SpillerType.Angriber,1)

        };



        public List<Spiller> GetAllSpillere()
        {
            return new List<Spiller>(_spillere);
        }

        public void Add(Spiller spiller)
        {
            _spillere.Add(spiller);
        }

        public void DeleteSpiller(int nummer)
        {
            Spiller sletSpiller = FindSpiller(nummer);
            _spillere.Remove(sletSpiller);

        }

        public Spiller FindSpiller(int nummer)
        {
            foreach (Spiller s in _spillere)
            {
                if (s.Nummer == nummer)
                {
                    return s;
                }

            }

            throw new KeyNotFoundException();

        }


        public void EditSpiller(Spiller newValues)
        {
            Spiller editSpiller = FindSpiller(newValues.Nummer);

            editSpiller.Name = newValues.Name;
            editSpiller.Rating = newValues.Rating;
            editSpiller.Type = newValues.Type;
            editSpiller.Hold = newValues.Hold;
        }


    }
}
