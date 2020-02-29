# _Alex's Bakery!_

#### _A fun C# program that allows a user to buy bread and pastries from a local bakery!_

#### By _**Alex Skreen**_

## Description
### Alex's Bakery

When the user runs the application, they should receive a prompt with a welcome message along with the cost for both Bread and Pastry.

A user should be able to specify how many loaves of Bread and how many Pastrys they'd like.

The application will return the total cost of the order.

Alex offers the following deals:

Bread: Buy 2, get 1 free. A single loaf costs \$5.
Pastry: Buy 1 for \$2 or 3 for \$5.

## Setup/Installation Requirements


### Node install

_Install Git with the following command:_
* ``$ brew install git``

_Next, install Node.js by entering the following command in Terminal:_
* ``$ brew install node``

### .NET and C# install

#### For macOS:
_If .NET and C# are not installed on your computer already, then install using the following steps:_
* download [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer)

* Open the file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.

* install and use a REPL called dotnet script.
* run ``dotnet tool install -g dotnet-script`` in the command line
* Download the [MySQL Community Server DMG File](https://dev.mysql.com/downloads/file/?id=484914)
* Click the download icon Use the No thanks, just start my download link.
* Follow along with the Installer
* run ``echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`` in the command line.
* Download the [MySQL Workbench DMG File](https://dev.mysql.com/downloads/file/?id=484391)
* Click the download icon Use the No thanks, just start my download link.
### Setup/install this application

_Clone this repository via Terminal using the following commands:_
* ``$ cd desktop``
* ``$ git clone https://github.com/alexskreen/Bakery``
* ``$ cd bakery``

_Confirm that you have navigated to the Bakery directory (e.g., by entering the command_ ``pwd`` in terminal). 

_Next, build the project and all of its dependencies at the project's root directory via the following command:_
* ``$ dotnet build``

_Open this application via live server using the following command:_
* ``$ dotnet run``

_To view/edit the source code of this application, open the contents of the camping directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._



## Specs
### Behavior Driven Development Spec List

Behavoir | Input | Output
:---------:|:------:|:------:
| The program will welcome the user | User starts program | Welcome to Alex's Bakery! |
| The program will display the cost of bread | User starts program | Bread: Buy 2 get 1 free! Single loaf: $5 |
| The program will display the cost of pastries | User starts program | Pastries: Buy 1 for \$2 or 3 for \$5 |
| The program will ask the user how many loaves of Bread and how many Pastrys they'd like and take in the users answer | 3 bread, 3 pastry | 3 bread, 3 pastry |
| The Program will return the cost to the user | 3 bread | 3 loaves of Bread: $10 |
| The Program will return the cost to the user | 3 pastry | 3 Pastries: $5 |






## Support 

_The software is provided as is. If you experience an issue please reach out to me using the contact information provided._


## Built With




* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [.NET](https://dotnet.microsoft.com/)



### License

This project is licensed under the MIT License

Copyright (c) 2020 **_Alex Skreen_**