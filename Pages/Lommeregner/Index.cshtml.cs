using MatchMakerDBU.Model;
using MatchMakerDBU.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MatchMakerDBU.Pages.Lommeregner
{

    //Bjørn og Nikolaj

    public class IndexModel : PageModel
    {
        private ISpillerService _service;

        public IndexModel(ISpillerService service)
        {
            _service = service;
        }

        public List<Spiller> Spillere { get; set; }
        public string Resultat { get; set; }

        public void OnGet()
        {
            Spillere = _service.GetAllSpillere();

            //Nikolaj laver gennemsnsitsmetode
            double GennemsnitHold1 = UdregnGennemsnit(1);
            double GennemsnitHold2 = UdregnGennemsnit(2);


            Resultat = CalculateWinner();


            //////  Hack
            //SpillerServiceJson service = new SpillerServiceJson();
            //foreach (var spiller in _service.GetAllSpillere())
            //{
            //    service.Add(spiller);
            //}
            ////// slut hack



        }

        public double UdregnGennemsnit(int hold)
        {

            var players = Spillere.Where(s => s.Hold == hold);


            double sum = 0;
            foreach (var player in players)
            {
                sum += player.Rating;
            }


            double average = sum / players.Count();

            return average;
        }

        public string CalculateWinner()
        {
            double gennemsnitHold1 = UdregnGennemsnit(1);
            double gennemsnitHold2 = UdregnGennemsnit(2);

            if (gennemsnitHold1 > gennemsnitHold2)
            {
                return "Hold 1 vinder";
            }
            else if (gennemsnitHold2 > gennemsnitHold1)
            {
                return "Hold 2 vinder";
            }
            else
            {
                return "Uafgjort";
            }
        }

    }
}
