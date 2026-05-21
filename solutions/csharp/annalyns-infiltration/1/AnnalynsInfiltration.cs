static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {   
       
        if(knightIsAwake == true){
            return false;
        }           
        return true;
        
        
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
       
        if(knightIsAwake == true || archerIsAwake == true || prisonerIsAwake ==  true){
            return true;
        }
        
            return false;
    
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
       if(archerIsAwake == true ||prisonerIsAwake == false){
           return false;
       }
        
            return true;
        
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
       if( archerIsAwake == false && petDogIsPresent == true && prisonerIsAwake == true ){
           return true;
       }
        else if(prisonerIsAwake == true && archerIsAwake == false && petDogIsPresent == false && knightIsAwake == false ){
            return true;
        }
        else if(prisonerIsAwake == false && archerIsAwake == false && petDogIsPresent == true && knightIsAwake == false){
            return true;
        }
        else if(knightIsAwake == true && petDogIsPresent == true && archerIsAwake == false ){
            return true;
        }
        
        return false;
    }
}
