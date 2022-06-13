## PierresTreats.Solution 

### By Jake Edgar

A web application to for Pierre's new Treat Place. 

## Tech Used

* C#
* DotNet 
* Razor 
* HTML
* CSS
* Entity Core
* Identity Authorization
* MySQL 

## Description

A web application that allows a user to log in and create treats with flavors, and vice versa. 

## Setup/Installation Requirements

* First make sure you have MySql Workbench downloaded and properly installed. You will also need a text editor and a command line that you are comfortable with. 

* In you command line navigate to your desktop directory and clone this project using *Git Clone https://github.com/jakeedgar/PierresTreats.Solution.git*

* Open the project in your preferred text editor, I recommend VSCode. 

* To access the database please do as follows:

  * First create a file using the *touch* command in your command line, at the root of the project directory called "appsettings.json" and in that file add the following code, but substituting the text in the brackets for your own information. 

  ```
  { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=[your_database];uid=[Your ID];pwd=[Your Password];" } }
  ```

* Then open MySQL Workbench and login. 

* Selected the administrator tab and choose "Data Import/ Restore" followed by "Import from self-contained file" Navigate to the directory here, and select "firstname_lastname.sql"

* in the tab "Default Schema Imported to" select new, and then name the schema *Your database here*.

* The project will not function if the naming convention is not adhered to correctly. 

* Click start to import the file. 

* Refresh the database to make sure synchronization has occurred. 

* In your command line navigate to the directory "Factory.Solution" and run the following commands in order:
  * *dotnet restore*
  * *dotnet build*
  * *dotnet ef migrations add Initial*
  * *dotnet ef database update*
  * *dotnet run*

* Follow the prompt to view the project at *localhost:5000*

## Known Bugs

No known bugs at this time.

## License

Licensed under the [MIT License](LICENSE).
Copyright (c) 2022 Jake Edgar