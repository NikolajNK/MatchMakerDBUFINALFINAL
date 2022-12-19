namespace MatchMakerDBU.Model
{//Bjørn med tilføjelser fra Nikolaj
    public class Spiller : Holdspiller
    {
        public Spiller()
        {

        }

        public Spiller(int nummer, string name, double rating, SpillerType type, int hold)
        {
            Nummer = nummer;

            Name = name;

            Rating = rating;

            Type = type;

            Hold = hold;
        }


    }

}
