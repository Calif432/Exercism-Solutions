class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method

    public int ExpectedMinutesInOven() => 40;
       
       
    public int RemainingMinutesInOven(int ActualMinutes) =>ExpectedMinutesInOven() - ActualMinutes;
         
       
    

    public int PreparationTimeInMinutes(int layers) => layers * 2;
        
         
        
    
    public int ElapsedTimeInMinutes(int numberOfLayers, int minutesInOven) => PreparationTimeInMinutes(numberOfLayers) + minutesInOven;
        
      
        
    
}
