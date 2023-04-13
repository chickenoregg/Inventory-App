# Inventory-App

This project involves creating a C# application with a graphical user interface (GUI) based on a provided “GUI Mock-Up”. The GUI consists of five different forms: a main form and four other forms for adding, modifying, and deleting parts and products. The main form includes buttons for adding, modifying, deleting, and searching for parts and products, as well as title labels for parts, products, and the application. The add part form includes radio buttons for “In-House” and “Outsourced” parts, text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID, and buttons for “Save” and “Cancel”. The modify part form has similar fields but with data from an existing part. The add product form includes buttons for “Save,” “Cancel,” “Add” part, and “Delete” part, text boxes for ID, name, inventory level, price, and max and min values, labels for ID, name, inventory level, price, max and min values, and the application, as well as a grid view for all parts and parts associated with the product. The modify product form is similar to the add product form but has fields that populate with data from an existing product.

After creating the GUI, the next step is to write code to create the class structure provided in the attached “UML (unified modeling language) Class Diagram”. This involves creating five classes with all their associated properties and ensuring that variables are accessible/modifiable through properties.

Next, the application’s functionalities are implemented using the methods provided in the UML Class Diagram. The main form allows users to redirect to the “Add Part,” “Modify Part,” “Add Product,” or “Modify Product” forms, delete a selected part or product from the grid view, search for a part or product, and exit the main form. The part forms allow users to add or modify parts by selecting “In-House” or “Outsourced”, entering data values, saving the data, canceling or exiting the form, and redirecting to the main form. Similarly, the product forms allow users to add or modify products, associate or remove parts from a product, save data, cancel or exit the form, and redirect to the main form.

Finally, the code addresses different conditions using exception handling code. Non-numeric values in textboxes that expect numeric values are detected, Min is checked to be less than Max, and Inv is between Min and Max values. Users are prevented from deleting a product that has a part associated with it, and confirm “Delete” actions are implemented. In summary, the completed application provides an easy-to-use interface with a comprehensive set of functionalities for managing parts and products, ensuring data accuracy and user convenience through exception handling code.
