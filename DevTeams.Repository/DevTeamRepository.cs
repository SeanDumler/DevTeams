
public class DevTeamRepository
{
    private readonly DeveloperRepository _devRepo;
    private List<DeveloperTeam> _devTeamDb = new List<DeveloperTeam>();

    private int _count = 0;
    private DeveloperRepository dRepo;

    public DevTeamRepository(DeveloperRepository devRepo)
    {
        _devRepo = devRepo;
    }

    //Create
    public bool AddDevTeam(DeveloperTeam developerTeam)
    {
        if (developerTeam is null)
        {
            return false;
        }
        else
        {
            _count++;
            developerTeam.ID = _count;
            _devTeamDb.Add(developerTeam);
            return true;
        }
    }

    //Read All
    public List<DeveloperTeam> GetAllDeveloperTeams()
    {
        return _devTeamDb;
    }

    //Read by ID
    public DeveloperTeam GetDeveloperTeam(int id)
    {
        foreach (DeveloperTeam devTeam in _devTeamDb)
        {
            if (devTeam.ID == id)
            {
                return devTeam;
            }
        }
        return null;
    }

    //Update
    public bool UpdateDeveloperTeam(int originalDevTeam, DeveloperTeam updatedDevTeam)
    {
        DeveloperTeam oldDevTeam = GetDeveloperTeam(originalDevTeam);

        if (oldDevTeam != null)
        {
            oldDevTeam.TeamName = updatedDevTeam.TeamName;

            if (updatedDevTeam.Developers.Count() > 0)
            {
                oldDevTeam.Developers = updatedDevTeam.Developers;
            }
            return true;
        }
        return false;
    }

    //Delete
        public bool DeleteDeveloperTeam(int developerTeam)
    {
        DeveloperTeam oldDevTeam = GetDeveloperTeam(developerTeam);

        if (oldDevTeam != null)
        {
            return _devTeamDb.Remove(oldDevTeam);
        }
        return false;
    }

    // public List<DeveloperTeam> GetDeveloperTeamByName(string teamName)
    // {
    //     var dTTeamName = new List<DeveloperTeam>();

    //     foreach (DeveloperTeam developerTeam in _devTeamDb)
    //     {
    //         if (developerTeam.TeamName == teamName)
    //         {
    //             return dTTeamName;
    //         }
    //     }
    //     return null;
    // }

    //todo: need to get a list of members on a developer team
    //     public List<DeveloperTeam> GetDeveloperTeamMembers(List<Developer> developers)
    // {
    //     var dTMembers = new List<DeveloperTeam>();

    //     foreach (DeveloperTeam dTMembers in _devTeamDb)
    //     {
    //         if (developerTeam.TeamName == teamName)
    //         {
    //             return dTTeamName;
    //         }
    //     }
    //     return null;
    // }

    public bool AddMultipleDevelopers(int developerTeam, List<Developer> developersToAdd)
    {
        DeveloperTeam devTeamInDb = GetDeveloperTeam(developerTeam);

        if (devTeamInDb != null)
        {
            devTeamInDb.Developers.AddRange(developersToAdd);
            return true;
        }
        return false;
    }
}
