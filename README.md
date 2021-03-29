# Setup voor de database
Om gebruik te maken van de app, heb je een database nodig. De database wordt aangemaakt met behulp van de migraties
1. Ga naar Tools > NuGet Package Manager > Package Manager Console
2. Voer in de commando: update-database
3. Ga naar View > SQL Server Object Explorer en dan in de geopende window naar SQL Server > (localdb)\MSSQLLocal... > Database > BikeRental.Models.BikeRental > Tables. Klik met je rechter muisknop op één van de tables in dit mapje om de table data in te zien. 

Als de SQL Server Object Explorer niet aanwezig is in de View tab dan dient deze gedownload te worden in Tools > Get Tools and Features > Individual Components  en dan bij de sectie "Cloud, database en server" selecteer je alles dat met "SQL" begint. 
