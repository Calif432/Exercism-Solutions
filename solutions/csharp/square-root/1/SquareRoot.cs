public static class SquareRoot
{
    public static int Root(int number)
    {
        if(number ==0 || number == 1){
            return number;
        }
        int guess = number;
        while (true){
            
            int next = (guess + number/guess)/2;

            if(next >= guess)
                return guess;
            guess = next;
        }
        
        
    
    }
}
