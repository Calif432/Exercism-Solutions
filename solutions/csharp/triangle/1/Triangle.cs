public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
         bool inequality = side1 + side2 > side3 && side1+ side3 > side2 && side2 + side3 > side1;
       if(side1 != side2 && side1 != side3 && side3!=side2 && inequality == true)return true;
           return false;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        bool inequality = side1 + side2 > side3 && side1+ side3 > side2 && side2 + side3 > side1;
        if(((side1 == side2 && side1 == side3 || side2 ==side3 ) || (side2 == side1 && side2 == side3 || side1 == side3) || (side3 == side2 && side3 == side1 || side1 == side2)) && inequality == true)return true;
        return false;
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        bool inequality = side1 + side2 > side3 && side1+ side3 > side2 && side2 + side3 > side1;
       if(side1 == side2 && side1 == side3 && side2 == side3 && inequality == true) return true;
         return false;
    }
}