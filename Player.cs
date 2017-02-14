namespace RockPaperScissors
{
    public class Player
    {
        public string Name { get; set; }
        public int Hand { get; set; }
        public int RoundsWon { get; set; }
    }
    //Hand_never_negavite : Hand >= 0
    //RoundsWon_never_negative : RoundsWon >= 0
}