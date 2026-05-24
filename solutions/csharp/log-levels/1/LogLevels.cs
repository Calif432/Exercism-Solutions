static class LogLine
{
    public static string Message(string logLine) =>logLine.Split(": ")[1].Trim();

    public static string LogLevel(string logLine)
    {
        
        int end = logLine.IndexOf("]");
        return logLine.Substring(1,end -1).ToLower();
    }

    public static string Reformat(string logLine)
    {
        int end = logLine.IndexOf("]");
        
        string[] parts = logLine.Split(": ");
        //return String.Format("{1} {0}",
           // parts[1], 
           // parts[0].Substring(1,end-1).ToLower());
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
