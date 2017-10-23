# Movie Database Project #



This is a c# project that dealt with movie database. This project use methodogies such as N-tier, Object orientated programming, web objects
CSV reader, generics. Focus was drawn to creating a plan before alternating any code, this help give clarity to the code but also
gives a plan to anyone more myself to implement the same project or any derivative type. Generics was used in the Presentation layer
to accept ControlID & datasource list

- Using LINQ/Lambda, we was about to filter the data into a single instance & populate the dropdownlists
    - LINQ
- 2 New Drop down lists were created for film year & imbd rating. 
- Created a dynamic table that appears once all the fields have single item. This creates table with headers assigned to values in the selected in the drop down list. 
- Created hyperlinks for films, actors & directors which have associated ID values. Clicking on link send the user to the web address associated. 
- N-Tier architecture is used to segregating an application into tiers. Eg.
    - Presentation Layer: 
    - Data Layer: This layer is used to extract the data from a CSV file using 3rd party CSV reader
    - Classes Layer: Data filtering using LINQ/Lambda 
    - Business Layer: The Presentation layer communicates with the Classes & Data layers through Business Layer. 
    - Application Layer: used to store variables, URL & strings into a structure.  
- CSV Reader extracts the information from the CSV file & stored into a cache.  

## Methodologies: 
- N-Tier: Multilayer architecture used are Presentation, Data, Business & Application/Classes layer.
- Object Oriented Programming
	- Encapsulation
	- Abstraction
	- Polymorphism
	- Inheritence 
- Agile framework (Loosely): 
- SOLID (Single Purpose)

## Tools:
- Visual Studio
	- Debugger
- Chrome/Firefox
- Git source control
-

## Technologies: 
- LINQ/Lambda (Data Filtering)
- Integrating 3rd party CSV/CSV Reader
- Generics
- ASP.NET Tables
- Web Objects
- 
