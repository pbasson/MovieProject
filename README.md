# Movie Database Project 

This is dynamic N-tier web application with Presentation layer that presents filtered data from a database. Before any code was written, the priority was first spent on researching & studying the code and subsequently planning the implementation using a code plan. This not only gave clarity and direction but also more risk-aversive both time & effort.   
The project uses N-tier architecture to break the solution into smaller layers (projects) with single purpose. The data the project receives is from a CSV file and filters down to a single item when the drop downs are selected. 
The requirements were to create additional drop down lists for film years & ratings, create a dynamic table & create hyperlinks to the associated ID using ASP.NET webobjects. 

### Brief

- Using LINQ/Lambda, we was able to filter the data into a single item based on the associated data & then populate the drop down lists
- At anytime the reset button can be pressed & all the data will 
- New Drop down lists were created for film year & imbd rating. A new Drop down list method in SharedBase.cs. This is done by using the asp.net web objects. 
- Created a dynamic table that appears once all the fields have single item. This creates table with headers assigned to values in the selected in the drop down list. 
- Created hyperlinks for films, actors & directors which have associated ID values. Clicking on the link sends the user to the web address associated. 
- N-Tier: Multi-layer architecture used are Presentation, Data, Business & Application/Classes layer.
- CSV Reader extracts the information from the CSV file & stored it into a cache.  
- Created HTML table using ASP.NET 

### Methodologies: 

- **N-Tier architecture** is used to segregating an application into tiers. Eg.
    - **Presentation Layer:** 
    - **Data Layer:** This layer is used to extract the data from a CSV file using 3rd party CSV reader
    - **Classes Layer:** Data filtering using LINQ/Lambda into a list. 
    - **Business Layer:** The Presentation layer communicates with the Classes & Data layers through Business Layer. Eg getting the data from CSV through the data layer.  
    - **Application Layer:** used to store variables, URL & strings into a structure.  
- **Object Oriented Programming:** 
	- **Encapsulation:** This is a container of fields & methods. Access modifier public, private & protected are used  
	- **Abstraction** 
	- **Polymorphism:** This was used in SharedBase with method populateDropDownList().
	- **Inheritance:** This was used eg with directors & actor derived from Person base class.  
- **Agile framework (Loosely):** Methods used are "what is done?", "what is is to be done? & "What is blocking you?" done by timesheet & Kanban (basic). 

### Tools:
- **Visual Studio:** This tool was used to write the code, use of intellisense to  
	- **Debugger:** This tool was used to check runtime if the application is functional, fulfil requirements & defect-free. 
- **Chrome/Firefox:** The browser was used to display the drop down lists then display a dynamic table when single item of each.  
- **Git source control via BitBucket:** The git used to upload the project, implement new methods, update it, create a branch, push/pull repository. Includes syntax of git bash. Git editor documentation syntax. 

### Technologies: 
- **LINQ/Lambda (Data Filtering)**
- **Integrating 3rd party CSV/CSV Reader:**  This is used to extract the information from a CSV file & store it into the cache where it can be retrieved. 
- **Generics:** This is used in the SharedBase into accept any datasource (eg. Simplistic Films, directors, actors). 
- **ASP.NET Tables:** The technologies used are the table web server control such as Table, TableRow, TableHeaderRow & TableCell. 
- **Web Objects:** Technology are used such as Page_Load & HTML
