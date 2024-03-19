## Gym Manager
Gym Manager is a C# .NET application designed to efficiently manage gym operations. It offers a range of features for managing member information and payments effectively.


## Features
Member Management: Easily add, delete, and modify member details.
Search Functionality: Quickly find members by name.
List All Members: View a comprehensive list of all gym members.
Payment Management: Track and manage payments for each month.
Filter by Name: Identify unpaid members by filtering them by name.
Technologies Used
C# .NET: Programming language and framework for development.
SQL Server: Database management system for storing member information and payment records.
DataGridView: Component for displaying member information in a tabular format.



## Usage
- **Adding a Member:** Click on the "Add Member" button, fill in the required details in the form, and click "Save" to add the member.

- **Deleting a Member:** Select a member from the list and click on the "Delete Member" button to remove them from the database.

- **Modifying Member Details:** Double-click on a member's row in the DataGridView to edit their details.

- **Searching for a Member:** Enter the name of the member in the search bar and press Enter to search.

- **Viewing All Members:** Click on the "List All Members" button to display a list of all gym members.

- **Managing Payments:** Use the payment management feature to track and update payment statuses for each month.

- **Filtering by Name:** Enter the name of the member in the filter box to view members with matching names.



## Project Structure
Member.cs: Contains the definition of the Member class representing gym members.
Gym.cs: Defines the Gym class responsible for managing gym operations.
Main.cs: Main program for testing all functionalities of the application.
