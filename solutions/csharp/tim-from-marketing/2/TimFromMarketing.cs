static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
          department ??= "owner";
        
        return id != null ?  $"[{id}] - {name} - {department.ToUpper()}" : $"{name} - {department.ToUpper()}";
           
    }
    }
