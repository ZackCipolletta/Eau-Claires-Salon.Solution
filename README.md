# Eau Claire's Salon

#### A web application using .NET Core MVC, SQL databases, EF Core, one to many relationships, C# classes, methods and auto-implemented properites.

#### By Zachary Cipolletta

## Technologies Used

* C#
* .Net 6
* HTML
* JavaScript
* JSON
* SQL
* EF core

## Description
This web application is a vendor and order tracker built using C#.  The user has the ability to add a new vendor to the list and add orders to an existing vendor including the Order title, description, price and date.

## Setup/Installation Requirements

1. Clone this repo.
2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory named "HairSalon".
3. Open MySQL Workbench, under the administration tab of the navigator click the link named "Data Import/Restore' under the 'Management' heading. Select the option to 'Import from Self-Contained File'.  Then use the file picker to navigate to the directory for this project and select the folder named 'Production Database', open the file in that folder.  In MySQL Workbench under the section named 'Default Schema to be Imported To', create a New schema and give it a name. Click the 'Start Import' button.
4. Create a file named ['appsettings.json'] in the production directory (HairSalon) and include a new database connection string. The string should be as follows:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];",
  }
}
Change the database name to the same name as the schema created in stip 3, update username and password to match the username and password of your computer.
5. Run `dotnet watch run` in the command line to start the project in development mode with a watcher (Optionally, you can run "dotnet build" to compile the app without running it). 
6. Open the browser to https://localhost:5001.

## Known Bugs

* no known bugs at this time

## License
MIT

Copyright (c) 3/310/2023 Zachary Cipolletta

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.


Open MySQL Workbench, under the administration tab of the navigator click the link named "Data Import/Restore' under the 'Management' heading. Select the option to 'Import from Self-Contained File'.  Then use the file picker to navigate to the directory for this project and select the folder named 'Production Database', open the file in that folder.  In MySQL Workbench under the section named 'Default Schema to be Imported To', create a New schema and give it a name. Click the 'Start Import' button.