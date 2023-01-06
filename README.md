# _SillyStringz's Factory_

### By _Henry Sullivan_

#### _Tracks engineers, machines, and associations with each other._

## Technologies Used

* _C Sharp_
* _.Net 6.0_
* _ASP.NET Core MVC_
* _EF Core 6_
* _Linq_
* _MySql_

## Description

_This program allows for the user to keep track of their engineers and their machines. The user can click on an engineer and see all machines associated with that engineer and vice versa. _

## Setup/Installation Requirements

### Run project
* _Clone the repo from GitHub_
* _Navigate to the project root directory_
* _Create a file called ```appsettings.json``` _
* _Within the newly created file add the following code:_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
* _Be sure to replace ```YOUR-USER-HERE``` and ```YOUR-PASSWORD-HERE``` with your own username and password_
* _Also make sure to add ```bin```, ```obj```, and ```appsettings.json``` to your ```.gitignore``` file_
* _Navigate to the Factory directory_
* _Install all dependencies with ```dotnet restore```_
* _Create database on your local machine by typing the command ```dotnet ef migrations add Initial``` and then ```dotnet ef database update``` in your terminal_
* _Enter the dotnet watch run command:_
  ```dotnet watch run```

## Known Bugs

* _No known bugs_

## License

MIT License

Copyright (c) [2022] [Henry Sullivan]

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.