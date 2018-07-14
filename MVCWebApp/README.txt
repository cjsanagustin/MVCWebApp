APPLYING CHANGES TO DATABASE FROM CODE:

Step 1:		IMPORTANT! Set MVCWebApp_Entities as StartUp Project.

Step 2: 	On menu, go to Tools > NuGet Package Manager > Package Manager Console.
		(Shortcut keys: Press hold Alt, click 't', 'n' lastly 'o')

Step 3:		Under Package Manager Console, on Default Projects : select "MVCWebApp_Entities"

Step 4:		Type: "add-migration <SimpleDescriptionAboutYourChanges>" ex. 
		"add migration CreateSystemUser" then press Enter. Visual Studio will create a migration file 
		under MVCWebApp_Entities > Migrations Folder.

Step 5:		Go to Solution Explorer > MVCWebApp_Entities > Migrations Folder, check the 
		file generated ex. "201807140216352_CreateSystemUser.cs"

Step 6:		After checking your Migration file, Go back to Package Manager Console, Type "Update-Database"
		then press Enter. 

