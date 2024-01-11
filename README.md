# Travel Client

#### An application that uses Travel API, and allows users to view, create, edit, and delete travel reviews of various travel destinations.

#### By Brian Scherner

## Technologies Used

* C#
* .NET
* MySQL
* ASP.NET MVC

## Description

**Please note**: This application communicates with the `mvc-client-branch` from the [Travel Api repository](https://github.com/besure94/TravelApi.Solution/tree/mvc-client-branch). This application presents users with a user interface (UI), where they can access the Travel API's endpoints to create, read, update, and delete reviews (also known as CRUD functionality).

## How to Run This Project

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-0-lessons-1-5-getting-started-with-c/3-0-0-01-welcome-to-c).

If you have not already, install the `dotnet-ef` tool by running the following command in your terminal:

```
dotnet tool install --global dotnet-ef --version 6.0.0
```

### Set Up and Run Project

Before you set up this project, make sure you follow the setup instructions in the README for the `mvc-client-branch` of the [Travel API repository](https://github.com/besure94/TravelApi.Solution/tree/mvc-client-branch). This application is required in order for this project to run properly.

1. Select the green button that says "Code", and clone this repository to your desktop.
2. Open the terminal and navigate to this project's production directory called `TravelClient`.
3. Within the production directory `TravelClient`, run `dotnet watch run` in the command line to start the project in development mode with a watcher.
4. Open the browser to _https://localhost:7075_. If you cannot access _https://localhost:7075_ it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-2-basic-web-applications/3-2-0-17-redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

None.

## License

MIT

Copyright(c) 2024 Brian Scherner