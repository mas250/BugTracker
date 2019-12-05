# BugTracker

**Overview**

This project is a Bug or Issue Tracker Wesbite developed by Matthew Shaw for Sparta Global. Having a portal to keep track of issues as they arise during a project offers many benefits. The advantage of having this as a separate program is that it allows teams to collaborate on problems as a developer on another project may have previously found a solution to a current problem. This project will be developed in an agile manner with incremental releases. 
___
**Current Features**

*Added pages to perform CRUD operations for database entries
*Database implemented using code first and database first with Visual Studio and MSSQL
*Page layout and structure customised
___
**Configuration Instructions**
Pull the latest version of the code from Develop. This includeds all required packages to run the project. Open the project solution in Visuall Studio and run it with IIS in your prefered browser.

**Operating Instructions**
Choose which entity to create by using the navigation bar at the top of the page. You will then see all existing entities. options will appear on screen for creating, deleting and reviewing information. When filling out information, feedback will be provided to the user to ensure the data is captured corrctly.

**Troubleshooting**
If you decided to drop the database, please remember that the foregin key restriant necessitates that an Employee should be created before a Bug.
Reading from the database can occasionaly take some time. thank you for your patience while the site loads. if you are waiting longer than 3 miuntes please refresh the browser window.

**Upcoming Features**
*Map databse entries to an object for use in shared views
*User login feature with more control over the database than standard users
*Drop down list for bugs showing status for create page
*Search for bugs using different options
*Arrange bugs for example alphabetically, by date or by status

___
**Planned Features**

*Selenium automated testing
*Unit tests for controller actions
*Unit tests for user input
*Deployment database using Radis or Azure
*JavaScript animations
___
Last Updated : 29/11/2019
