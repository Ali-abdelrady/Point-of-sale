# Point-Of-Sale-System
This Point of Sale System is aimed for small convenience stores which are still unfamiliar to computerized system of running the business. This system is simple yet effective as the functions are easy to use for the users, that is, for the store owner or store manager and store cashiers.

In the admin panel, there are fields which are effective for the administration of the whole store. The admin can manage list of product items, product categories, cashier information, customer information and supplier information.

In the cashier panel, the user will be provided with interfaces to sell items to customers. He/she can search the selling items by barcode or item-name. The cashier can also redeem the payment card or create new cards.


This project is implemented with Model–view–controller (MVC) software design pattern.

<hr>

# Technology Used
- C# .Net Framework
- Microsoft Sql Server
- Winforms
<hr>

# Features 
- User authorization (admin, cashier)
- Stock management (add/delete/modify inventory item)
- Sell Items With barcode 
- Supplier management (company info, supply date, supply amount)
- Track popular item over customer interest (i.e. Most selling item)
- Report generation
<hr>
<h1>Video</h1>
<video src="https://github.com/Ali-abdelrady/Point-of-sale/assets/110298275/319f768f-4367-4a37-8240-cfacacca8e5f" controls autoplay></video>
<hr>
<h1>Setup</h1>
<ul>
  <li>Download the source code</li>
  <li>Install .Net framework, version 4.7 </li>
  <li>Install Sql server 2019</li>
  <li>Install IDE (Visual Studio)</li>
</ul>
<hr>
<h1>Problems</h1> 
### Issue: Database Connection Failure on Another Computer

**Problem**: The application fails to connect to the database when published and run on another computer.

**Description**: After publishing the application and transferring it to another computer, users encounter a database connection error when attempting to launch the application. This issue occurs even when the database server is running and accessible from the new computer.

**Context**: 
- Operating System: Windows 10
- Database Server: SQL Server 2019
- Connection String: `Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\Grocery_Shop\Grocery_Shop\bin\Debug\PosDb.mdf;Integrated Security=True;Connect Timeout=30`

## How to Contribute

If you have experience with database connectivity issues and would like to help resolve this issue, you can contribute in the following ways:
- Clone the repository to your local machine.
- Set up the development environment
- Investigate the code related to database connection and identify any potential issues.
- Propose solutions and submit a pull request with your proposed fixes.

Your contributions are greatly appreciated and will help improve the overall reliability and compatibility of the application.

