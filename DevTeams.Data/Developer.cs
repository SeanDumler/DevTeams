
//P.O.C.O. -> Plain Old C# Object
//Domain Object
public class Developer
{
    public Developer()
    {
        
    }

    public Developer(string firstName, string lastName, bool hasPluralsight)
    {
        FirstName = firstName;
        LastName = lastName;
        HasPluralsight = hasPluralsight; 
    }
    
    //We need a Primary key
    public int ID { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }

    public bool HasPluralsight { get; set; }

    //Is everytime I do: Developer.ToString()
    public override string ToString()
    {
        var str = $"ID: {ID}\n"+
                    $"Full Name: {FullName}\n"+
                    $"Has Pluralsight Access: {HasPluralsight}\n"+
                    "=========================================\n";

        return str;
    }
}
