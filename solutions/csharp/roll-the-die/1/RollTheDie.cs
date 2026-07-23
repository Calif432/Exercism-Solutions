public class Player
{
    public int RollDie()
    {
        var player = new Random();
       int die = player.Next(1,19);
           return die;
    }

    public double GenerateSpellStrength()
    {
        var playerStrength = new Random();
        double strength = playerStrength.NextDouble()*101.0 + 0.0;
        return strength;
    }
}
