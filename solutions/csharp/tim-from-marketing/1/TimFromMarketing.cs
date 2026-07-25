static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
          department ??= "owner";
        if(id != null)
            return  $"[{id}] - {name} - {department.ToUpper()}";
        else if(department == null)
        {
          
            if(id != null)
                return  $"[{id}] - {name} - {department.ToUpper()}";
            else 
                return  $"{name} - {department.ToUpper()}";
        } 
            
        else
            return $"{name} - {department.ToUpper()}";
        
        
    }
}
