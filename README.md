# Shipment Handler System

 Shipment Handler System is a project that is created in order to allow branches of Shipment/Cargo companies to track their operations and access their data

This project was created as the final project of Boğaziçi University - CET 321 


# Technologies that were used in this project

C# using the .NET 6.0 framework

Windows Forms App through Visual Studio

Microsoft SQL Server

# Database Structure

![image](https://user-images.githubusercontent.com/77791748/224485888-12a17b33-41c2-4e89-b4df-c435c6a1df31.png)

For this system I have created the database that can bee seen in the figure. This database consists of 5 different tables which are; tblShipment, tblPickup, tblItem, tblClient and tblShipmentList. Ultimately I have created 4 different tables for the base data that are registered in the shipment and cargo companies. Tables for shipments, items and clients have their ID elements as their primary keys, but as for the pickups I didn’t want to add a separate key, instead I have chosen their license numbers as primary keys since all vehicle numbers are supposed to be unique. 
 
tblShipment holds the data regarding shipment packages, which its delivery type, weight, description, items that are inside of that shipment, its client and the pickup it is assigned to. tblItem holds the data regarding items which are its name, type, price and brand. tblClient holds the data regarding the clients, which are clients name, surname, contact information and address information. tblPickup holds the data regarding the pickup trucks which are, information regarding the driver, the shipment list it is following, its current shipment and its current location. And finally tblShipmentList holds the data all the shipments a pickup is going to deliver.
As can be seen from the figure most of the tables are connected to eachother via foreign keys, to create these connections I have written different constraints for each connection. 
Whilst creating ‘tblShipment’ I have added 3 items that are foreign keys from ‘tblItem’ table, I choose maximum of 3 items per shipment thinkinh of an example company with a business rule ‘A shipment can have maximum of 3 items’. And whilst creating the ‘tblPickup’ instead of adding shipments in the same way as ‘tblShipment’ I have considered creating a separate table named ‘tblShipmentList’ to save the data in a more organized way since the number of shipments a pickup can be huge in respect to the items a shipment can have.

# Front-End Structure

While creating the user interface for the Shipment Handler I have used Windows Forms App class library using Visual Studio 2022. I have used textboxes, gridviews, buttons, labels, panels and such tools from the toolbox to create a simple and easy to navigate UI. In total there 6 different form pages in this software, and they mostly consist similar tools. These form pages are; Main Screen, Clients Form, Inventory Form, Shipments Form, Shipment  List Form and Pickups form.

# Main Form

![image](https://user-images.githubusercontent.com/77791748/224486015-604d3fc5-e6c4-4440-85ef-8618af64aa01.png)

Main screen of the Shipment Handler

The main screen of Shipment Handler is the first form that the user sees when the software is initiated. The interface of this screen is built to make it easy to navigate and access other forms. There are 4 different buttons to access; Clients Form, Inventory Form, Shipments Form and Pickups Form.


# Client Form

![image](https://user-images.githubusercontent.com/77791748/224486020-e4a5728f-fab0-4e1b-af6f-0abeaf59316c.png)

Clients screen of the Shipment Handler

In the clients screen the user is able to;

1-) View clients that are in the database with the use of DataGridView

2-) Inspect each clients data by clicking on their row from the DataGridView, this will make their data appear on the textboxes that appear on the right side of the screen

3-)Search for clients with the search button and searchbox, the user is also able to select the area they want to conclude their search in by selecting that feature from the combobox next to the searchbox.

4-)The user can Add a new Client by using the Add Client button on the screen, to do that, user needs to fill out the information boxes on the right side of the screen and press add client button.

5-)The user can update the information regarding the existing users, to do this the user can manually enter information regarding the client or select the wanted client from the DataGridView to fill in the information to information boxes automatically. After changing any of the information the user needs to press the Update button to complete the action.

6-)The user can also delete the record of an existing client, to do this the user can again manually enter information regarding the client or select the wanted client from the DataGridView to fill in the information to information boxes automatically. After seeing the information of the desired user on the information boxes the user can use remove client button to delete the record of the client from the database.

7-)There is also a Refresh button that refreshes the DataGridView. Normally after operation the DataGridView is updated, however in case the user wants to manually refresh the data on the DataGridView they can use this button.


# Pickup Form

![image](https://user-images.githubusercontent.com/77791748/224486034-e920e47b-fcb0-4c41-bed2-f353dd8a6345.png)

Pickups screen of the Shipment Handler

In the pickups screen the user is able to perform all the tasks that they could perform in the clients screen and also the inventory screen, thus they are able to view pickup data, search for the pickups with the feature they want, add a new pickups to the system by entering the information regarding the new pickup truck, update an existing pickups information and remove an existing pickup. One feature that is different from all the forms used in the software is the use of ‘webBrowser’. With the web browser feature on this screen the user is able to check the location of the desired pickup truck on the map. After the user selects the desired pickup truck they can press ‘Show Live Location’ Button to see the pickup truck on the screen. 


# Back-end Structure

# Refresh
![image](https://user-images.githubusercontent.com/77791748/224486152-c35f1491-f2ce-41fc-ab72-a82a2235599e.png)

Code for the required SQL connection
 
![image](https://user-images.githubusercontent.com/77791748/224486159-06688066-c143-4fa3-8af6-3852f7001872.png)

Code for the refresh method

I have created a refresh method in order to reload the most current state of the database in case the user makes any changes on the database using the add, update or delete operations, after each operation is run the refresh method runs for the form that the operation that was run on. I have created a new sql command to run a “select * fromt tbl…” command inside of the database, and used the “SqlDataAdapter” to make the connection between the database and the SQL. After the wanted SQL command is run the DataGridView from the relevant form gets updated with the most current data from the database.

# DataGridView

![image](https://user-images.githubusercontent.com/77791748/224486217-7fec53dd-df32-444c-b0fd-694ab5f9156a.png)

Code to make DataGridView Interactable and transfer selected data to textboxes
	
In order to make the DataGridView interactable and transfer the data to textboxes so the user can easily update, delete and view the data I have written this piece of code. How it works is that after you click a data from any of the rows on the DataGridView, every data inside of the cells of that row gets turned into a string and thus transferred to the relevant textbox that appear on the user interface. 

# Search

![image](https://user-images.githubusercontent.com/77791748/224486337-9d2887ef-7d0d-41f8-943a-ec57bf9396f1.png)

Code for searching with wanted attribute

In order to allow the users to easily access and find the client/item/pickup/shipment they are looking for I have created a search function using a textbox, combobox and a button. In this code I have firstly created 2 different variables for the search type and also the search itself. The user can select the search type using the combobox since the variable depends on the text of combobox, and write the value they are looking for in the search textbox. After the user presses the search button an SQL command again is run to get the results. As an example in case the user wants to search for a client whose name is “Emre”, after entering the required information and pressing the button a command such as “SELECT * FROM tblClient where ClientName = ‘Emre’” and the DataGridView shows the outcome of this command.

# Add

![image](https://user-images.githubusercontent.com/77791748/224486451-c8c19aac-db6f-43a9-aa23-2fa3c651037c.png)

Code for the Add function

To create this function I firstly wrote the SQL insert command that is going to be registering the new client/item/pickup/shipment. The command on this figure is quite long so I have added the command from the Inventory Screen

    “cmd = new SqlCommand("INSERT INTO tblItem (ItemID,Item_Name,Item_Type,Item_Price,Item_Brand) values (@ItemID,@Item_Name,@Item_Type,@Item_Price,@Item_Brand)", con);”
  
This command implies the table, the value types that are going to be added and the values themselves. The values that are going to be added are taken from the text boxes and thus are the parameters for the SQL command.
After the values are transferred to the SQL command it is ran by the “cmd.ExecuteNonQuery()”;  and the new client/item/pickup/shipment that we wanted to add is registered to the database. After this operation is done the textboxes get cleared and a success message is shown on a messagebox. And finally the refresh method runs to show the latest version of the database. 
However in case the user forgets to insert the ID the none of the SQL commands will be run and there will be an error message displayed from from a messagebox. 

![image](https://user-images.githubusercontent.com/77791748/224486540-48148d8f-f670-47ea-95f6-904f7a9c4376.png)

MessageBox after a client is added

# Update 

![image](https://user-images.githubusercontent.com/77791748/224486563-2c691b21-a28d-469f-b7f4-7f1d8992d20f.png)

Code for the Update function

The code structure of the update function is almost the same as the add function, the only differences in this case is the SQL Command which is an update statement instead of an insert statement. After the user selects a registry by clicking from the DataGridView they can change the information they desire to change and press the update button. After the update operation is done a messagebox will appear to give the message that the data was successfully updated. In case a customer is not selected and the update button is pressed the a messagebox will appear to give the message that a client/item/pickup/shipment should be selected. To make this work I have implemented an if statement with the condition of ID for the client/item/shipment and license for the pickups to be not empty. The reason I chose ID as the deciding factor is because I have chosen them as primary keys in my database design.

![image](https://user-images.githubusercontent.com/77791748/224486579-b9c62fbc-be56-41d6-9774-c7503bfa36c4.png)

MessageBox after a client is updated

# Delete

![image](https://user-images.githubusercontent.com/77791748/224486595-2b3dec98-16bd-4d8d-9e0d-460a0187b087.png)

Code for the Delete function

The code structure of the delete function is also same as the add function and the update function. After the ID of the client/item/pickup/shipment desired to be deleted is entered to the textbox an SQL command for the delete operation is ran on the database and the record is deleted.

# Web Form

![image](https://user-images.githubusercontent.com/77791748/224486611-84a9c085-4fb7-4892-bfc9-0260b6725dc7.png)

Code for the Web Browser and Pickup Location 

I have written this code in order to allow users to see current location of the pickup trucks by using the web browser tool on the pickup screen. To make this function work I have used a “StringBuilder”, with this string builder I aimed to create query address for a google maps link that would show the precise location of the pickup truck on the web browser. When the “Show Live Location” button is pressed a google maps search link gets combined with the string of the “current location” from the “tblPickup” table. And thus the location of the pickup truck is shown on the web browser.




