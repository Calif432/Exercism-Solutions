class RemoteControlCar
{
    private int _distance;
    public  double batteryPercentage = 100.0;
    public int Distance{
        get;
        set;
    }
    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay() => $"Driven {Distance} meters";
    
       
        
    

    public string BatteryDisplay()
    {
       
            if(batteryPercentage > 0)
      return $"Battery at {batteryPercentage}%";
           return "Battery empty";
    }

    public void Drive()
    {
        DistanceDisplay();
        BatteryDisplay();
        if (batteryPercentage != 0){
            batteryPercentage -= 1;
            Distance += 20;
        }
             
         
       
            
         
    }
}
