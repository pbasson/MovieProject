# Movie Database Project 

This is dynamic N-tier web application with Presentation layer that presents data from a database. Before any code was written, the priority was first spent on researching & planning the code and subsequently developing a code plan. 
The project uses N-tier architecture to break the solution into smaller layers (projects) with single purpose. The data the project receives is from a CSV file and filters down individual when the drop downs are selected. 
The requirements were to create additional drop down lists for film years & ratings, create a dynamic table & create hyperlinks to the associated ID. 



This is a c# project that dealt with movie database. This project use methodologies such as N-tier, Object orientated programming, web objects
CSV reader, generics. Focus was drawn to creating a plan before alternating any code, this help give clarity to the code but also
gives a plan to anyone more myself to implement the same project or any derivative type. Generics was used in the Presentation layer
to accept ControlID & datasource list

- Using LINQ/Lambda, we was able to filter the data into a single item based on the associated data & then populate the drop down lists
    - LINQ
- 
- New Drop down lists were created for film year & imbd rating. 
- Created a dynamic table that appears once all the fields have single item. This creates table with headers assigned to values in the selected in the drop down list. 
- Created hyperlinks for films, actors & directors which have associated ID values. Clicking on link send the user to the web address associated. 
- N-Tier: Multilayer architecture used are Presentation, Data, Business & Application/Classes layer.
- CSV Reader extracts the information from the CSV file & stored into a cache.  

## Methodologies: 

- N-Tier architecture is used to segregating an application into tiers. Eg.
    - Presentation Layer: 
    - Data Layer: This layer is used to extract the data from a CSV file using 3rd party CSV reader
    - Classes Layer: Data filtering using LINQ/Lambda into a list. 
    - Business Layer: The Presentation layer communicates with the Classes & Data layers through Business Layer. Eg getting the data from CSV through the data layer.  
    - Application Layer: used to store variables, URL & strings into a structure.  
- Object Oriented Programming: 
	- Encapsulation: 
	- Abstraction: 
	- Polymorphism: This was used in SharedBase with method populateDropDownList().
	- Inheritance: This was used eg with directors & actor derived from Person base class.  
- Agile framework (Loosely): Methods used are "what is done?", "what is is to be done? & "What is blocking you?" done by timesheet & Kanban (basic). 
- SOLID (Single Purpose)

## Tools:
- Visual Studio: This tool was used to write the code, use of intellisense to  
	- Debugger: This tool was used to check runtime if the application is functional, fulfil requirements & defect-free. 
- Chrome/Firefox: The browser was used to display the drop down lists then display a dynamic table when single item of each.  
- Git source control via BitBucket: The git used to upload the project, implement new methods, update it, create a branch, push/pull repository. Includes syntax of git bash. Git editor documentation syntax. 


## Technologies: 
- LINQ/Lambda (Data Filtering)
- Integrating 3rd party CSV/CSV Reader
- Generics: This is used in the SharedBase into accept any datasource
- ASP.NET Tables
- Web Objects
- 

