
public class ProgramUI
{
    //globally scoped variable container with the DeveloperRepository Data
    private DeveloperRepository _dRepo = new DeveloperRepository();
    private DevTeamRepository _dTRepo;

    public ProgramUI()
    {
        _dTRepo = new DevTeamRepository(_dRepo);
    }
    bool continueToRun = true;

    public void Run()
    {
        RunMenu();
    }

    private void RunMenu()
    {
        continueToRun = true;
        while (continueToRun)
        {
            Console.Clear();
            System.Console.WriteLine("Welcome to Komodo Insurance.\n" +
            "Please choose from one of the following:\n" +
            "1. Search for All Developers\n" +
            "2. Search for All Developer Teams\n" +
            "3. Edit a Developer\n" +
            "4. Edit a Developer Team\n" +
            "5. Developers without Pluralsight\n" +
            "6. Exit the Application");

            string userInput = Console.ReadLine()!;

            switch (userInput)
            {
                case "1":
                    SearchForDeveloper();
                    break;
                case "2":
                    SearchForDevTeam();
                    break;
                case "3":
                    EditADeveloper();
                    break;
                case "4":
                    EditDeveloperTeam();
                    break;
                case "5":
                    DevelopersWithPluralsight();
                    break;
                case "6":
                    continueToRun = false;
                    System.Console.WriteLine("Thank you for using Komodo Insurance!");
                    PauseUntilKeyPress();
                    Console.Clear();
                    break;
                default:
                    System.Console.WriteLine("Invalid Selection. Please choose between 1-6.");
                    PauseUntilKeyPress();
                    break;
            }
        }
    }

    private void DevelopersWithPluralsight()
    {
        Console.Clear();
        List<Developer> developersWOPS = _dRepo.GetAllDevelopersWithoutPluralsight();
        if (developersWOPS.Count() > 0)
        {
            foreach (Developer developer in developersWOPS)
            {
                DisplayDeveloper(developer);
            }
        }
        else
        {
            System.Console.WriteLine("All developers have Pluralsight.");
        }
    }

    // private void SearchForDeveloper()
    // {
    //     Console.Clear();
    //     System.Console.WriteLine("How would you like to search for the Developer?\n" +
    //     "1. Search Developer by ID\n" +
    //     "2. Search Developer by First Name\n" +
    //     "3. Search Developer by Last Name\n" +
    //     "4. Search Developer by Full Name\n" +
    //     "5. Search Developer by Pluralsight Access\n" +
    //     "6. Back to Main Menu");

    //     string userInput = Console.ReadLine()!;

    //     switch (userInput)
    //     {
    //         case "1":
    //             SearchForDeveloperByID();
    //             break;
    //         case "2":
    //             SearchForDeveloperByFirstName();
    //             break;
    //         case "3":
    //             SearchForDeveloperByLastName();
    //             break;
    //         case "4":
    //             SearchForDeveloperByFullName();
    //             break;
    //         case "5":
    //             SearchForDeveloperByPluralsightAccess();
    //             break;
    //         case "6":
    //             System.Console.WriteLine("Returning to the Main Menu.");
    //             PauseUntilKeyPress();
    //             continueToRun = false;
    //             RunMenu();
    //             break;
    //         default:
    //             System.Console.WriteLine("Invalid Selection. Please choose between 1-6.");
    //             PauseUntilKeyPress();
    //             break;
    //     }
    // }

    private void SearchForDeveloper()
    {
        Console.Clear();
        ShowAllDevelopers();
        // System.Console.WriteLine("Enter Developer ID");
        // int userInput = int.Parse(Console.ReadLine()!);

        // Developer developer = _dRepo.GetDeveloper(userInput);
        // if (developer != null)
        // {
        //     DisplayDeveloper(developer);
        // }
        // else
        // {
        //     System.Console.WriteLine("Could not find Developer. Returning to Search Menu.");
        //     PauseUntilKeyPress();
        //     Console.Clear();
        //     SearchForDeveloper();
        // }

        PauseUntilKeyPress();

    }

    private void ShowAllDevelopers()
    {
        Console.Clear();
        System.Console.WriteLine("List of Developers");
        List<Developer> developersInDb = _dRepo.GetAllDevelopers();
        ValidateDeveloperDb(developersInDb);
    }

    private void ValidateDeveloperDb(List<Developer> developersInDb)
    {
        if (developersInDb.Count() > 0)
        {
            Console.Clear();
            foreach (Developer developer in developersInDb)
            {
                DisplayDeveloper(developer);
            }
        }
        else
        {
            System.Console.WriteLine("There are no Developers in the System.");
        }
    }

    private void DisplayDeveloper(Developer developer)
    {
        System.Console.WriteLine(developer);
    }

    // private void SearchForDeveloperByFirstName()
    // {
    //     Console.Clear();
    //     System.Console.WriteLine("Enter Developer First Name");
    //     string userInput = Console.ReadLine()!;

    //     List<Developer> dFirstName = _dRepo.GetDeveloperByFirstName(userInput);
    //     if (dFirstName != null)
    //     {
    //         System.Console.WriteLine($"{dFirstName}");
    //     }
    //     else
    //     {
    //         System.Console.WriteLine("Could not find Developer. Returning to Search Menu.");
    //         PauseUntilKeyPress();
    //         Console.Clear();
    //         SearchForDeveloper();
    //     }

    //     PauseUntilKeyPress();
    // }

    // private void SearchForDeveloperByLastName()
    // {
    //     Console.Clear();
    //     System.Console.WriteLine("Enter Developer Last Name");
    //     string userInput = Console.ReadLine()!;

    //     List<Developer> dLastName = _dRepo.GetDeveloperByLastName(userInput);
    //     if (dLastName != null)
    //     {
    //         System.Console.WriteLine($"{dLastName}");
    //     }
    //     else
    //     {
    //         System.Console.WriteLine("Could not find Developer. Returning to Search Menu.");
    //         PauseUntilKeyPress();
    //         Console.Clear();
    //         SearchForDeveloper();
    //     }

    //     PauseUntilKeyPress();
    // }

    // private void SearchForDeveloperByFullName()
    // {
    //     Console.Clear();
    //     System.Console.WriteLine("Enter Developer Full Name");
    //     string userInput = Console.ReadLine()!;

    //     List<Developer> dFullName = _dRepo.GetDeveloperByFullName(userInput);
    //     if (dFullName != null)
    //     {
    //         System.Console.WriteLine($"{dFullName}");
    //     }
    //     else
    //     {
    //         System.Console.WriteLine("Could not find Developer. Returning to Search Menu.");
    //         PauseUntilKeyPress();
    //         Console.Clear();
    //         SearchForDeveloper();
    //     }

    //     PauseUntilKeyPress();
    // }

    // private void SearchForDeveloperByPluralsightAccess()
    // {
    //     //todo: need to work on this
    // }

    private void SearchForDevTeam()
    {
        Console.Clear();

        ShowAllDevTeams();
        // System.Console.WriteLine("How would you like to search for the Developer Team?\n" +
        // "1. Search Developer Team by Team Name\n" +
        // "2. Search Developer Team by Team ID\n" +
        // "3. Search Team Members in Developer Team\n" +
        // "4. Back to Main Menu");

        // string userInput = Console.ReadLine()!;

        // switch (userInput)
        // {
        //     case "1":
        //         SearchForDeveloperTeamByTeamName();
        //         break;
        //     case "2":
        //         SearchForDeveloperTeamByTeamID();
        //         break;
        //     case "3":
        //         SearchForTeamMembersInDeveloperTeam();
        //         break;
        //     case "4":
        //         System.Console.WriteLine("Returning to the Main Menu.");
        //         PauseUntilKeyPress();
        //         continueToRun = false;
        //         RunMenu();
        //         break;
        //     default:
        //         System.Console.WriteLine("Invalid Selection. Please choose between 1-4.");
        //         PauseUntilKeyPress();
        //         break;
        // }
        PauseUntilKeyPress();
    }

    private void ShowAllDevTeams()
    {
        List<DeveloperTeam> developerTeams = _dTRepo.GetAllDeveloperTeams();
        if (developerTeams.Count() > 0)
        {
            foreach (DeveloperTeam devTeam in developerTeams)
            {
                DisplayDeveloperTeamInfo(devTeam);
            }
        }
        else
        {
            System.Console.WriteLine("There are no developer teams found.");
        }
    }

    private void DisplayDeveloperTeamInfo(DeveloperTeam devTeam)
    {
        System.Console.WriteLine(devTeam);
    }


    // private void SearchForDeveloperTeamByTeamName()
    // {
    //     Console.Clear();
    //     System.Console.WriteLine("Enter Developer Team Name");
    //     string userInput = Console.ReadLine()!;

    //     List<DeveloperTeam> dTName = _dTRepo.GetDeveloperTeamByName(userInput);
    //     if (dTName != null)
    //     {
    //         System.Console.WriteLine($"{dTName}");
    //     }
    //     else
    //     {
    //         System.Console.WriteLine("Could not find Developer Team. Returning to Search Menu.");
    //         PauseUntilKeyPress();
    //         Console.Clear();
    //         SearchForDevTeam();
    //     }

    //     PauseUntilKeyPress();
    // }

    private void SearchForDeveloperTeamByTeamID()
    {
        Console.Clear();
        ShowAllDevTeams();
        List<DeveloperTeam> developerTeams = _dTRepo.GetAllDeveloperTeams();
        if (developerTeams.Count() > 0)
        {
            System.Console.WriteLine("Enter Developer Team ID");
            int userInput = int.Parse(Console.ReadLine()!);
            ValidateDevTeamInfo(userInput);
        }

        // DeveloperTeam developerTeam = _dTRepo.GetDeveloperTeam(userInput);
        // if (developerTeam != null)
        // {
        //     DisplayDeveloperTeam(developerTeam);
        // }
        // else
        // {
        //     System.Console.WriteLine("Could not find Developer Team. Returning to Search Menu.");
        //     PauseUntilKeyPress();
        //     Console.Clear();
        //     SearchForDevTeam();
        // }

        PauseUntilKeyPress();
    }

    private void ValidateDevTeamInfo(int userInput)
    {
        DeveloperTeam developerTeam = _dTRepo.GetDeveloperTeam(userInput);
        if (developerTeam != null)
        {
            DisplayDeveloperTeamInfo(developerTeam);
        }
        else
        {
            System.Console.WriteLine("That developer team doesn't exist.");
        }

    }

    // private void DisplayDeveloperTeam(DeveloperTeam developerTeam)
    // {
    //     System.Console.WriteLine($"Team Name: {developerTeam.TeamName}\n" +
    //     $"Team ID: {developerTeam.ID}\n" +
    //     $"Team Members: {developerTeam.Developers}");
    // }

    // private void SearchForTeamMembersInDeveloperTeam()
    // {
    //     Console.Clear();
    //     System.Console.WriteLine("Enter Developer Team Name");
    //     string userInput = Console.ReadLine()!;

    //     //todo: need to work on this
    // }

    private void EditADeveloper()
    {
        Console.Clear();
        System.Console.WriteLine("What would you like to do?\n" +
        "1. Search for Developer ID\n" +
        "2. Add a Developer\n" +
        "3. Remove a Developer\n" +
        "4. Update a Developer\n" +
        "5. Back to Main Menu");

        string userInput = Console.ReadLine()!;

        switch (userInput)
        {
            case "1":
                SearchForDeveloperByID();
                break;
            case "2":
                AddADeveloper();
                break;
            case "3":
                RemoveADeveloper();
                break;
            case "4":
                UpdateADeveloper();
                break;
            case "5":
                System.Console.WriteLine("Returning to the Main Menu.");
                PauseUntilKeyPress();
                continueToRun = false;
                RunMenu();
                break;
            default:
                System.Console.WriteLine("Invalid Selection. Please choose between 1-5.");
                PauseUntilKeyPress();
                break;
        }
    }

    private void SearchForDeveloperByID()
    {
        Console.Clear();
        ShowAllDevelopers();

        try
        {
            System.Console.WriteLine("Please enter Developer ID");
            int userInput = int.Parse(Console.ReadLine()!);
            ValidateDeveloperInDb(userInput);
        }
        catch (Exception ex)
        {

            System.Console.WriteLine(ex.Message);
            SomethingWentWrong();
        }

        PauseUntilKeyPress();
    }

    private bool ValidateDeveloperInDb(int userInput)
    {
        Developer developer = GetDeveloperFromDb(userInput);
        if (developer != null)
        {
            Console.Clear();
            DisplayDeveloper(developer);
            return true;
        }
        else
        {
            System.Console.WriteLine("Developer was not found.");
            return false;
        }
    }

    private Developer GetDeveloperFromDb(int userInput)
    {
        return _dRepo.GetDeveloper(userInput);
    }

    private void SomethingWentWrong()
    {
        System.Console.WriteLine("Something went wrong. Please try again.");
    }

    private void AddADeveloper()
    {
        Console.Clear();

        try
        {
            Developer developer = SetupDeveloper();
            if (_dRepo.AddDeveloper(developer))
            {
                System.Console.WriteLine($"{developer.FullName} has been added to the system");
            }
            else
            {
                SomethingWentWrong();
            }
        }
        catch (Exception ex)
        {

            System.Console.WriteLine(ex.Message);
            SomethingWentWrong();
        }
        // Developer developer = new Developer();

        // System.Console.WriteLine("Please enter new Developer information.\n" +
        // "What is the Developer's First Name?");
        // developer.FirstName = Console.ReadLine()!;

        // System.Console.WriteLine("What is the Developer's Last Name?");
        // developer.LastName = Console.ReadLine()!;

        // System.Console.WriteLine("Does the Developer have Pluralsight Acces?\n" +
        // "Yes or No");
        // string userInput = Console.ReadLine()!;

        // switch (userInput.ToLower())
        // {
        //     case "yes":
        //         developer.HasPluralsight = true;
        //         System.Console.WriteLine($"Deverloper {developer.FullName} has been given access.");
        //         PauseUntilKeyPress();
        //         break;
        //     case "no":
        //         developer.HasPluralsight = false;
        //         System.Console.WriteLine($"Deverloper {developer.FullName} has not been given access.");
        //         PauseUntilKeyPress();
        //         break;
        //     default:
        //         System.Console.WriteLine("Invalid Selection. Please choose Yes or No.");
        //         PauseUntilKeyPress();
        //         break;
        // }

        // bool developerAdded = _dRepo.AddDeveloper(developer);
        // if (developerAdded)
        // {
        //     System.Console.WriteLine($"Developer {developer.FullName} has been added to the system.");
        // }
        // else
        // {
        //     System.Console.WriteLine("Developer was not added successfully. Please try again.");
        //     EditADeveloper();
        // }

        PauseUntilKeyPress();
    }

    private Developer SetupDeveloper()
    {
        Developer developer = new Developer();

        System.Console.WriteLine("Please enter Developer Information");

        System.Console.WriteLine("What is the developer's first name?");
        developer.FirstName = Console.ReadLine()!;

        System.Console.WriteLine("What is the developer's last name?");
        developer.LastName = Console.ReadLine()!;

        System.Console.WriteLine("Does the developer have Pluralsight Access?\n" +
        "1. Yes\n" +
        "2. No");

        string userInput = Console.ReadLine()!;

        switch (userInput)
        {
            case "yes":
                developer.HasPluralsight = true;
                break;
            default:
                developer.HasPluralsight = false;
                break;
        }

        return developer;

    }

    private void RemoveADeveloper()
    {
        Console.Clear();
        ShowAllDevelopers();

        try
        {
            System.Console.WriteLine("Please enter Developer ID you wish to remove.");

            int userInput = int.Parse(Console.ReadLine()!);

            var isValidated = ValidateDeveloperInDb(userInput);

            if (isValidated)
            {
                if (_dRepo.DeleteDeveloper(userInput))
                {
                    System.Console.WriteLine($"Developer was deleted.");
                }
                else
                {
                    System.Console.WriteLine($"Developer was not deleted.");
                }

            }
            else
            {
                SomethingWentWrong();
            }
        }
        catch (Exception ex)
        {

            System.Console.WriteLine(ex.Message);
            SomethingWentWrong();
        }
        //     List<Developer> developerList = _dRepo.GetAllDevelopers();

        //     if (developerList.Count() > 0)
        //     {
        //         System.Console.WriteLine("Please enter Developer ID you wish to remove.");

        //         int count = 0;
        //         foreach (var developer in developerList)
        //         {
        //             count++;
        //             System.Console.WriteLine($"{count}. {developer.FullName}");
        //         }

        //         int targetDeveloperId = int.Parse(Console.ReadLine()!);
        //         int targetDeveloper = targetDeveloperId - 1;

        //         if (targetDeveloper >= 0 && targetDeveloper < developerList.Count())
        //         {
        //             Developer desiredDeveloper = developerList[targetDeveloper];

        //             if (_dRepo.DeleteDeveloper(desiredDeveloper))
        //             {
        //                 System.Console.WriteLine($"{desiredDeveloper.FullName} was successfully removed.");
        //                 PauseUntilKeyPress();
        //             }
        //             else
        //             {
        //                 System.Console.WriteLine("Could not delete selected Developer. Please try again.");
        //                 PauseUntilKeyPress();
        //                 EditADeveloper();
        //             }
        //         }
        //         else
        //         {
        //             System.Console.WriteLine("No Developers found. Please try again.");
        //             PauseUntilKeyPress();
        //             EditADeveloper();
        //         }
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("There are no Developers in the system. please add a Developer.");
        //         PauseUntilKeyPress();
        //         EditADeveloper();
        //     }
    }

    private void UpdateADeveloper()
    {
        Console.Clear();
        ShowAllDevelopers();
        try
        {
            System.Console.WriteLine("Please select the Developer ID you would like to update.");

            int userInput = int.Parse(Console.ReadLine()!);

            Developer developerInDb = GetDeveloperFromDb(userInput);

            bool isValidated = ValidateDeveloperInDb(developerInDb.ID);

            if (isValidated)
            {
                Developer updatedDeveloper = SetupDeveloper();

                if (_dRepo.UpdateDeveloperDb(developerInDb.ID, updatedDeveloper))
                {
                    System.Console.WriteLine($"{updatedDeveloper.FullName} has been updated.");
                }
                else
                {
                    System.Console.WriteLine($"{updatedDeveloper.FullName} has not been updated.");
                }
            }
            else
            {
                System.Console.WriteLine("Developer not found.");
            }

            // if (developer != null)
            // {
            //     Console.Clear();
            //     Developer updatedDeveloper = new Developer();

            //     System.Console.WriteLine("Please enter new Developer information.\n" +
            //     "What is the Developer's First Name?");
            //     updatedDeveloper.FirstName = Console.ReadLine()!;

            //     System.Console.WriteLine("What is the Developer's Last Name?");
            //     updatedDeveloper.LastName = Console.ReadLine()!;

            //     System.Console.WriteLine("Does the Developer have Pluralsight Acces?\n" +
            //     "Yes or No");
            //     string psInput = Console.ReadLine()!;

            //     switch (psInput.ToLower())
            //     {
            //         case "yes":
            //             updatedDeveloper.HasPluralsight = true;
            //             System.Console.WriteLine($"Deverloper {updatedDeveloper.FullName} has been given access.");
            //             PauseUntilKeyPress();
            //             break;
            //         case "no":
            //             updatedDeveloper.HasPluralsight = false;
            //             System.Console.WriteLine($"Deverloper {updatedDeveloper.FullName} has not been given access.");
            //             PauseUntilKeyPress();
            //             break;
            //         default:
            //             System.Console.WriteLine("Invalid Selection. Please choose Yes or No.");
            //             PauseUntilKeyPress();
            //             break;
            //     }

            //     bool developerAdded = _dRepo.AddDeveloper(updatedDeveloper);
            //     if (developerAdded)
            //     {
            //         System.Console.WriteLine($"Developer {updatedDeveloper.FullName} has been updated the system.");
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("Developer was not added successfully. Please try again.");
            //         EditADeveloper();
            //     }

            // PauseUntilKeyPress();


        }
        catch (Exception ex)
        {

            System.Console.WriteLine(ex.Message);
        }
        PauseUntilKeyPress();
    }

    private void EditDeveloperTeam()
    {
        Console.Clear();
        System.Console.WriteLine("What would you like to do?\n" +
        "1. Add a Developer Team\n" +
        "2. Remove a Developer Team\n" +
        "3. Update a Developer Team\n" +
        "4. Add Multiple Members to a Team\n" +
        "5. Back to Main Menu");

        string userInput = Console.ReadLine()!;

        switch (userInput)
        {
            case "1":
                AddADeveloperTeam();
                break;
            case "2":
                RemoveADeveloperTeam();
                break;
            case "3":
                UpdateADeveloperTeam();
                break;
            case "4":
                AddMultipleMembersToATeam();
                break;
            case "5":
                System.Console.WriteLine("Returning to the Main Menu.");
                PauseUntilKeyPress();
                continueToRun = false;
                RunMenu();
                break;
            default:
                System.Console.WriteLine("Invalid Selection. Please choose between 1-5.");
                PauseUntilKeyPress();
                break;
        }
    }

    private void AddMultipleMembersToATeam()
    {
        try
        {
            Console.Clear();
            ShowAllDevTeams();
            List<DeveloperTeam> developerTeams = _dTRepo.GetAllDeveloperTeams();

            if (developerTeams.Count() > 0)
            {
                System.Console.WriteLine("Select a Developer Team ID you wish to add members to.");
                int userInput = int.Parse(Console.ReadLine()!);
                DeveloperTeam devTeam = _dTRepo.GetDeveloperTeam(userInput);

                List<Developer> membersInDb = _dRepo.GetAllDevelopers();

                List<Developer> developersToAdd = new List<Developer>();

                if (devTeam != null)
                {
                    bool hasAddedMembers = false;

                    while (!hasAddedMembers)
                    {
                        if (membersInDb.Count > 0)
                        {
                            DisplayDevelopersInDb(membersInDb);
                            System.Console.WriteLine("Do you want to add a developer?\n"+
                            "Yes or No");
                            string userInputYesOrNo = Console.ReadLine()!.ToLower();

                            if (userInputYesOrNo == "yes")
                            {
                                System.Console.WriteLine("Please enter the developer ID you wish to add.");
                                int userInputDevID = int.Parse(Console.ReadLine()!);
                                Developer developer = _dRepo.GetDeveloper(userInputDevID);
                                if (developer != null)
                                {
                                    developersToAdd.Add(developer);
                                    membersInDb.Remove(developer);
                                }
                                else
                                {
                                    System.Console.WriteLine("Developer doesn't exist.");
                                    PauseUntilKeyPress();
                                }
                            }
                            else
                            {
                                hasAddedMembers = true;
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("There are no developers in the system.");
                            PauseUntilKeyPress();
                            break;
                        }
                    }

                    if (_dTRepo.AddMultipleDevelopers(devTeam.ID, developersToAdd))
                    {
                        System.Console.WriteLine("Developers added.");
                    }
                    else
                    {
                        System.Console.WriteLine("Developers not added.");
                    }
                }
                else
                {
                    System.Console.WriteLine("Did not find that Develope Team.");
                }
            }

            PauseUntilKeyPress();
        }
        catch (Exception ex)
        {
            
            System.Console.WriteLine(ex.Message);
            SomethingWentWrong();
        }
    }

    private void AddADeveloperTeam()
    {
        Console.Clear();

        DeveloperTeam developerTeam = SetupDevTeam();
        if (_dTRepo.AddDevTeam(developerTeam))
        {
            System.Console.WriteLine("Developer Team was added.");
        }
        else
        {
            System.Console.WriteLine("Developer Team was not added.");
        }

        // System.Console.WriteLine("Please enter new Developer Team information.\n" +
        // "What is the Developer Team's Name?");
        // developerTeam.TeamName = Console.ReadLine()!;

        // bool developerTeamAdded = _dTRepo.AddDevTeam(developerTeam);
        // if (developerTeamAdded)
        // {
        //     System.Console.WriteLine($"Deverloper Team {developerTeam.TeamName} has been added to the system.");
        // }
        // else
        // {
        //     System.Console.WriteLine("Developer Team was not added successfully. Please try again.");
        //     EditDeveloperTeam();
        // }

        PauseUntilKeyPress();
    }

    private DeveloperTeam SetupDevTeam()
    {
        DeveloperTeam developerTeam = new DeveloperTeam();
        try
        {

            System.Console.WriteLine("What is the team name?");
            developerTeam.TeamName = Console.ReadLine()!;

            bool hasAddedMembers = false;

            List<Developer> listOfDevelopers = _dRepo.GetAllDevelopers();

            while (hasAddedMembers == false)
            {
                System.Console.WriteLine("Do you want to add any Developers?\n" +
                                        "Yes or No");
                string userInput = Console.ReadLine()!.ToLower();

                if (userInput == "yes")
                {
                    if (listOfDevelopers.Count() > 0)
                    {
                        DisplayDevelopersInDb(listOfDevelopers);
                        System.Console.WriteLine("Select the developer by ID.");
                        int userInputDevId = int.Parse(Console.ReadLine()!);
                        Developer selectedDeveloper = _dRepo.GetDeveloper(userInputDevId);

                        if (selectedDeveloper != null)
                        {
                            developerTeam.Developers.Add(selectedDeveloper);
                            listOfDevelopers.Remove(selectedDeveloper);
                        }
                        else
                        {
                            System.Console.WriteLine("Developer not found.");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No Developers left to add.");
                        PauseUntilKeyPress();
                        break;
                    }
                }
                else
                {
                    hasAddedMembers = true;
                }
            }
            return developerTeam;
        }
        catch (Exception ex)
        {

            System.Console.WriteLine(ex.Message);
            SomethingWentWrong();
        }
        return null;
    }

    private void DisplayDevelopersInDb(List<Developer> listOfDevelopers)
    {
        if (listOfDevelopers.Count() > 0)
        {
            foreach (Developer developer in listOfDevelopers)
            {
                System.Console.WriteLine(developer);
            }
        }
    }

    private void RemoveADeveloperTeam()
    {
        try
        {
            Console.Clear();
            ShowAllDevTeams();
            List<DeveloperTeam> developerTeams = _dTRepo.GetAllDeveloperTeams();

            if (developerTeams.Count() > 0)
            {
                System.Console.WriteLine("Please select Developer Team to delete.");
                int userInput = int.Parse(Console.ReadLine()!);
                DeveloperTeam devTeam = _dTRepo.GetDeveloperTeam(userInput);

                if (devTeam != null)
                {
                    if(_dTRepo.DeleteDeveloperTeam(devTeam.ID))
                    {
                        System.Console.WriteLine("Developer Team was deleted.");
                    }
                    else
                    {
                        System.Console.WriteLine("Developer Team was not deleted.");
                    }
                }
                else
                {
                    System.Console.WriteLine("No Developer Teams Available");
                }
            }
            else
            {
                System.Console.WriteLine("No Developer Teams Available.");
            }
            PauseUntilKeyPress();
        }
        catch (Exception ex)
        {
            
            System.Console.WriteLine(ex.Message);
        }
        // List<DeveloperTeam> developerTeamList = _dTRepo.GetAllDeveloperTeams();

        // if (developerTeamList.Count() > 0)
        // {
        //     System.Console.WriteLine("Please enter Developer Team ID you wish to remove.");

        //     int count = 0;
        //     foreach (var developerTeam in developerTeamList)
        //     {
        //         count++;
        //         System.Console.WriteLine($"{count}. {developerTeam.TeamName}");
        //     }

        //     int targetDeveloperTeamId = int.Parse(Console.ReadLine()!);
        //     int targetDeveloperTeam = targetDeveloperTeamId - 1;

        //     if (targetDeveloperTeam >= 0 && targetDeveloperTeam < developerTeamList.Count())
        //     {
        //         DeveloperTeam desiredDeveloperTeam = developerTeamList[targetDeveloperTeam];

        //         if (_dTRepo.DeleteDeveloperTeam(desiredDeveloperTeam))
        //         {
        //             System.Console.WriteLine($"{desiredDeveloperTeam.TeamName} was successfully removed.");
        //             PauseUntilKeyPress();
        //         }
        //         else
        //         {
        //             System.Console.WriteLine("Could not delete selected Developer Team. Please try again.");
        //             PauseUntilKeyPress();
        //             EditDeveloperTeam();
        //         }
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("No Developer Teams found. Please try again.");
        //         PauseUntilKeyPress();
        //         EditDeveloperTeam();
        //     }
        // }
        // else
        // {
        //     System.Console.WriteLine("There are no Developer Teams in the system. Please add a Developer Team.");
        //     PauseUntilKeyPress();
        //     EditDeveloperTeam();
        // }
    }

    private void UpdateADeveloperTeam()
    {
        try
        {
            Console.Clear();
            ShowAllDevTeams();
            List<DeveloperTeam> developerTeam = _dTRepo.GetAllDeveloperTeams();
            if (developerTeam.Count() > 0)
            {
                System.Console.WriteLine("Enter in the Developer Team you would like to Update.");
                int userInput = int.Parse(Console.ReadLine()!);
                DeveloperTeam devTeam = _dTRepo.GetDeveloperTeam(userInput);

                if (devTeam != null)
                {
                    DeveloperTeam updatedDevTeam = SetupDevTeam();
                    if (_dTRepo.UpdateDeveloperTeam(devTeam.ID, updatedDevTeam))
                    {
                        System.Console.WriteLine("Developer Team was updated.");
                    }
                    else
                    {
                        System.Console.WriteLine("Developer Team was not updated.");
                    }
                }
                else
                {
                    System.Console.WriteLine("Developer Team was not found.");
                }
            }
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            SomethingWentWrong();
        }
        PauseUntilKeyPress();
        // System.Console.WriteLine("Which would you like to do?\n" +
        // "1. Add a Developer to a Team\n" +
        // "2. Remove a Developer from a Team");
        // string userInput = Console.ReadLine()!;

        // switch (userInput)
        // {
        //     case "1":
        //         AddDeveloperToADeveloperTeam();
        //         break;
        //     case "2":
        //         RemoveDeveloperFromADeveloperTeam();
        //         break;
        //     default:
        //         System.Console.WriteLine("Invalid Selection. Please try again.");
        //         PauseUntilKeyPress();
        //         EditDeveloperTeam();
        //         break;
        // }
    }



    private void PauseUntilKeyPress()
    {
        System.Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
}
