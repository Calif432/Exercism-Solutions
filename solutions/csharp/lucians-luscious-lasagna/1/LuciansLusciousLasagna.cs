class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method

    public int ExpectedMinutesInOven(){
       
        return 40;
    }
    public int RemainingMinutesInOven(int ActualMinutes){
        int remainingMinutes = ExpectedMinutesInOven() - ActualMinutes;
        return remainingMinutes;
    }

    public int PreparationTimeInMinutes(int layers){
        int TimeSpent = layers * 2;
         return TimeSpent;
        
    }
    public int ElapsedTimeInMinutes(int numberOfLayers, int minutesInOven){
        
        int ElapsedMinutes = PreparationTimeInMinutes(numberOfLayers) + minutesInOven;
        return ElapsedMinutes;
    }
}
