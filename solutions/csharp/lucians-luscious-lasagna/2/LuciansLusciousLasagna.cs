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
         return  ExpectedMinutesInOven() - ActualMinutes;
       
    }

    public int PreparationTimeInMinutes(int layers){
        
         return  layers * 2;
        
    }
    public int ElapsedTimeInMinutes(int numberOfLayers, int minutesInOven){
        
        return PreparationTimeInMinutes(numberOfLayers) + minutesInOven;
        
    }
}
