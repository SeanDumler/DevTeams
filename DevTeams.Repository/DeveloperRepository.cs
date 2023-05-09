
public class DeveloperRepository
{
    //we need a variable container that will hold the collection of Developers
    private List<Developer> _developerDb = new List<Developer>();
    //we need to auto increment the developer Id
    private int _count = 0;

    //C.R.U.D.

    //Create
    public bool AddDeveloper(Developer developer)
    {
        if(developer is null)
        {
            return false;
        }
        else
        {
            //increment the _count
            _count++;

            //assign the developerID to _count
            developer.ID = _count;

            //save to the database
            _developerDb.Add(developer);

            return true;
        }
    }

    //Read All
    public List<Developer> GetAllDevelopers()
    {
        return _developerDb;
    }

    //Read by ID
    public Developer GetDeveloper(int id)
    {
        foreach (Developer developer in _developerDb)
        {
            if (developer.ID == id)
            {
                return developer;
            }
        }
        return null;
    }

    //Update
    public bool UpdateDeveloperDb(int originalDeveloper, Developer updatedDeveloper)
    {
        Developer oldDeveloper = GetDeveloper(originalDeveloper);

        if (oldDeveloper != null)
        {
            oldDeveloper.FirstName = updatedDeveloper.FirstName;
            oldDeveloper.LastName = updatedDeveloper.LastName;
            oldDeveloper.HasPluralsight = updatedDeveloper.HasPluralsight;
            return true;
        }
        return false;
    }

    //Delete
    public bool DeleteDeveloper(int id)
    {
        Developer oldDeveloper = GetDeveloper(id);

        if (oldDeveloper != null)
        {
            return _developerDb.Remove(oldDeveloper);
        }

        return false;
    }

    //? need to figure out how to get a list based on parameters
    // public List<DeveloperRepository> GetDevelopersByFirstName(string firstName)
    // {
    //     var dFirstName = new List<DeveloperRepository>();

    //     foreach (Developer developer in _developerDb)
    //     {
    //         if(developer.FirstName == firstName)
    //         {
    //             dFirstName.Add(developer);
    //         }
    //     }

    //     return dFirstName;
            //! this didn't work either
    //     var dFirstName = _developerDb.Where(df => df.FirstName == firstName).ToList();
    //     return dFirstName;
    // }
    // public List<Developer> GetDeveloperByFirstName(string firstName)
    // {
    //     var dFirstName = new List<Developer>();

    //     foreach (Developer developer in _developerDb)
    //     {
    //         if (developer.FirstName.ToLower() == firstName.ToLower())
    //         {
    //             return dFirstName;
    //         }
    //     }
    //     return null;
    // }

    //     public List<Developer> GetDeveloperByLastName(string lastName)
    // {
    //     var dLastName = new List<Developer>();

    //     foreach (Developer developer in _developerDb)
    //     {
    //         if (developer.LastName.ToLower() == lastName.ToLower())
    //         {
    //             return dLastName;
    //         }
    //     }
    //     return null;
    // }

    // public List<Developer> GetDeveloperByFullName(string fullName)
    // {
    //     var dFullName = new List<Developer>();

    //     foreach (Developer developer in _developerDb)
    //     {
    //         if (developer.FullName.ToLower() == fullName.ToLower())
    //         {
    //             return dFullName;
    //         }
    //     }
    //     return null;
    // }

    public List<Developer> GetAllDevelopersWithoutPluralsight()
    {
        List<Developer> developersWOPS = new List<Developer>();

        foreach (Developer developer in _developerDb)
        {
            if (developer.HasPluralsight == false)
            {
                developersWOPS.Add(developer);
            }
        }

        return developersWOPS;
    }
}
