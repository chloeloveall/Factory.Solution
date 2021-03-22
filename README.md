![SillyStringz splash page screenshot](Factory/wwwroot/img/sillystringz-screenshot.png)

# _Sillystringz: From the Insane Mind of Dr. Sillystringz_

#### _An MVC application that allows a fictional factory manager to track their machines, engineers, and specify which machines each engineer can repair_

#### By _**Chloe Loveall**_
<br>

![license](https://img.shields.io/github/license/chloeloveall/Factory.Solution?color=blue&style=flat-square) &nbsp; ![top project language](https://img.shields.io/github/languages/top/chloeloveall/Factory.Solution?style=flat-square) &nbsp; ![last github commit](https://img.shields.io/github/last-commit/chloeloveall/Factory.Solution?style=flat-square) &nbsp; ![github pull requests](https://img.shields.io/github/issues-pr/chloeloveall/Factory.Solution?style=flat-square) &nbsp; ![open issues](https://img.shields.io/github/issues-raw/chloeloveall/Factory.Solution?style=flat-square) &nbsp; ![github contributors](https://img.shields.io/github/contributors/chloeloveall/Factory.Solution?color=brightgreen&style=flat-square)

## Table of Contents


1. [Table of Contents](#table-of-contents)
2. [Description](#description)
3. [Preview](#preview)
4. [Technologies Used](#technologies-used)
5. [Setup and Installation Requirements](#setup-and-installation-requirements)
    * [Prior to Installation](#prior-to-installation)
      * [Git Installation](#confirm-you-have-git-installed)
      * [.NET Installation](#confirm-you-have-.net-installed)
    * [Installation](#installation)
    * [Database Setup](#database-setup)
      * [MySQL Password Protection](#mysql-password-protection)
6. [User Stories](#user-stories)
7. [Specifications](#specifications)
8. [Known Bugs](#known-bugs)
9. [Issues](#issues)
10. [Roadmap](#roadmap)
11. [Design](#design)
12. [Contributing](#contributing)
13. [License](#license)
14. [Acknowledgements](#acknowledgements)
15. [Contact Information](#contact-information)

## Description

An [Epicodus](https://www.epicodus.com/) project to create an MVC web application to help a fictional factory owner manage the company's engineers and machines. The manager can add to a list of engineers working for the factory, a list of machines at the factory, and link engineers and machines if desired.

## Preview

Live preview with Heroku 

## Technologies Used

* ASP.NET 5.0.1
* C#
* Entity Framework 5.0.0
* MySQL 8.0.15
* MySQL Workbench 8.0.15
* Razor

## Setup and Installation Requirements

### Prior to Installation

#### Confirm you have Git installed
  * Installing Git on Macs:
    * Install the package manager [Homebrew](https://brew.sh/) by copying and pasting the following in the terminal: ```$ /usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"```
    * Copy and paste once of the following lines in the terminal so that Homebrew packages are run before the system versions of the same packages:
      * For bash users: ```$ echo 'export PATH=/usr/local/bin:$PATH' >> ~/.bash_profile```
      * For zsh users: ```$ echo 'export PATH=/usr/local/bin:$PATH' >> ~/.zshrc```
    * Last, install Git with the following terminal command: ```$ brew install git```

  * Installing Git on Windows:
    * Open Command Prompt, the Windows terminal program. You can access it by typing ```Cmd``` in the search bar in the bottom left corner.
    * **NOTE** There are many options available, but we recommend using a free program called [Git Bash](https://gitforwindows.org/)
    * Navigate to [Git Bash](https://gitforwindows.org/) and click on the Download button. This will take you to a page with the latest version of Git Bash. Determine whether you have 32-bit or 64-bit Windows by following these instructions. Then download the corresponding exe file from the Git for Windows site. (If you have a package manager already installed, you can also choose to download the tar.bz2 version.)
    * Click on the downloaded file and then follow the instructions in the Setup menu until you reach the Install button and install the package.
    
#### Confirm you have .NET installed 
Installing .NET will provide provide access to the C# language
  * [.NET for macOS](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-macos-x64-installer)
  * [.NET for Windows](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer)
* Additionally, you may want to install a REPL to allow you to practice, test, and experiment with C#. Below are instructions for the ```dotnet script``` REPL:
  * Install ```dotnet script``` by running the following terminal command: ```$ dotnet tool install -g dotnet-script```
  * **NOTE:** If you just installed .NET 5, restart the terminal. (Otherwise, you will not be able to run the following command.) 
    * Enter ```$ dotnet script``` in your terminal and a prompt will open: ```>```
    * To exit the REPL press: Ctrl +C

### Installation
* Clone the repository with the following git terminal command: ```$ git clone https://github.com/chloeloveall/HairSalon.Solution.git```
* Open the project directory in your terminal
* Navigate to the ```HairSalon``` directory
    * To create ```obj``` directories in both production and test projects, run the terminal command: ```$ dotnet restore```
    * **NOTE**: Do not touch the code in either ```obj``` directory.
* To launch the program, run the terminal command: ```dotnet run```

### Database Setup 
* Confirm you have [MySQL](https://dev.mysql.com/downloads/file/?id=484914) installed
* Confirm you have [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391) installed
* Open ```MySQL Workbench``` and select ```Local Instance 3306```
* In the ```Administration``` tab, select ```Data Import/Restore```
  * ![Data Import/Restore Screenshot](HairSalon/wwwroot/img/data-import-screenshot.png)
* Select ```Import from Self-Contained File```
* Select the file ```chloe_loveall.sql``` from the ```HairSalon.Solutions``` root directory
* Select ```New``` from the ```Default Schema to be Imported To``` section
  * ![Default Schema Screenshot](HairSalon/wwwroot/img/default-schema-screenshot.png)
* Choose a name for the database and select ```Ok```
* Select ```Start Import```

#### MySQL Password Protection
* Create a the following file: ```appsettings.json```
* Add the following code:
  * ![Setup of appsettings.json Screenshot](HairSalon/wwwroot/img/appsettings-screenshot.png)
* **NOTE**: [YOUR_DATABASE] must match the database name you chose to import above
* **NOTE**: [YOUR_PASSWORD] must match your local MySQL server password
* **NOTE**: The ```appsettings.json``` file is included in the ```.gitignore``` file 
  * You can read more about best practices for storing private information with ASP.NET Core [here](https://www.humankode.com/asp-net-core/asp-net-core-configuration-best-practices-for-keeping-secrets-out-of-source-control)
  
## User Stories

* As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines.
* As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it.
As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed.
* As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed
* As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine.
* I should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it.

## Specifications

| Behavior                                                         | Input                      | Output                     |
| ---------------------------------------------------------------- | :------------------------- | :------------------------- |
| User can click a link to be directed to a engineers page         | user clicks link           | localhost:5000/engineers   |
| User can add an engineer to the database                         | "Janet Weiss"              | "Janet Weiss"              |
| User will be routed to engineer index page after engineer is added | user adds engineer       | localhost:5000/engineers    |
| User can click engineer's name and view all associated details    | user clicks "Janet Weiss"  | localhost:5000/engineers/details{janet-weiss-id}  |
| User can search for an engineer by name (whole or partial match) | "Frank N Furter"           | "Frank N Furter"           |
| User can click a link to be directed to a machines page          | user clicks link           | localhost:5000/machines    |
| User can add a machine to the database                           | "RiffRaffer"                | "Riff Raff"                |
| User will be routed to machines index page after machine is added | user adds machine           | localhost:5000/machines  |
| User can click machine's name and view all associated details     | user clicks "RiffRaffer"    | localhost:5000/localhost:5000/engineers/details{riffraffer-id}  |

## Known Bugs

* The animated header is not very responsive - it loads slowly and does not resize well. 

## Issues 

* Report issues [here](https://github.com/chloeloveall/Factory.Solution/issues) and select the ```New issue``` button
for support and

## Roadmap

* Use HireDate to set up annual certification renewal 
* Merge edit/delete functionality into a single view
* Add ability to search by multiple search parameters
* Add buttons to sort list by multiple criteria in single view 

### Design

* Animated logo designed with [Canva](https://www.canva.com/)

   ![Sillystringz logo gif](Factory/wwwroot/img/sillystringz-logo.gif)

## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are greatly appreciated.

1. Fork the project on GirHub
    * Follow [Installation and Setup Requirements](#setup-and-installation-requirements) above
2. Create your Feature Branch: ```$ git checkout -b YourFeatureBranchName```
3. Commit your Changes ```$ git commit -m 'Add some Amazing Feature'```
4. Push to your feature branch on Github ```$ git push origin YourFeatureBranchName```
5. Open a Pull Request

## License

[MIT](LICENSE.md)

## Acknowledgements

* [Absurd Design](https://absurd.design/)
* [Canva](https://www.canva.com/)
* [Choose an open source license](https://choosealicense.com/)
* [Codepen.io/ClaireLarsen](https://codepen.io/ClaireLarsen/pen/XmVyVX)
* [Coolors](https://coolors.co/)
* [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [Pexels: Royalty Free Images](https://www.pexels.com/royalty-free-images/)
* [Shields](https://shields.io/)
* [Unplash: Photos for Everyone](https://unsplash.com/)
* [Zombie Ipsum](http://www.zombieipsum.com/)

## Contact Information

_Chloe Loveall <chloeloveall@protonmail.com>_

![github followers](https://img.shields.io/github/followers/chloeloveall?style=social) &nbsp; ![github forks](https://img.shields.io/github/forks/chloeloveall/Factory.Solution?label=Forks&style=social) &nbsp; ![github stars](https://img.shields.io/github/stars/chloeloveall/Factory.Solution?style=social)

[Back to Top](#table-of-contents)