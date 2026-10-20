class RemoteControlCar
{
    private int _distance;
    public  double batteryPercentage = 100.0;
    public int Distance{
        get;
        set;
    }
    public static RemoteControlCar Buy() => new RemoteControlCar();
    
        
        
    

    public string DistanceDisplay() => $"Driven {Distance} meters";
    
       
        
    

    public string BatteryDisplay()
    {
       
            if(batteryPercentage > 0)
      return $"Battery at {batteryPercentage}%";
           return "Battery empty";
    }

    public void Drive()
    {
       
        if (batteryPercentage != 0){
            batteryPercentage -= 1;
            Distance += 20;
        }
             
         
       
            
         
    }
}
