CustomersDAO Class
==================

This class implements the `IDAO<Customer>` interface and provides methods to perform CRUD (Create, Read, Update, and Delete) operations on a database table called `customers`.

### Constructors


*   `CustomersDAO(Database database)`: constructs a new instance of the `CustomersDAO` class with a `Database` object as a parameter.

### Methods

*   `Add(Customer customer)`: adds a new `Customer` object to the `customers` table in the database.
*   `Update(Customer customer)`: updates an existing `Customer` object in the `customers` table with the same ID as the input parameter.
*   `Delete(int id)`: deletes the `Customer` object with the specified ID from the `customers` table.
*   `GetAll()`: retrieves all `Customer` objects from the `customers` table and returns them as a `List<Customer>`.
*   `GetById(int id)`: retrieves the `Customer` object with the specified ID from the `customers` table and returns it as a `Customer` object.
*   `GetIdByName(string firstName, string lastName)`: retrieves the ID of the `Customer` object with the specified first name and last name from the `customers` table and returns it as an integer.
*   `hasTable()`: checks if the `customers` table exists in the database and returns a boolean value.
*   `CreateTable()`: creates the `customers` table in the database if it does not already exist.
*   `AddFromJSON(string path)`: reads a JSON file from the specified file path and deserializes the contents to a list of `Customer` objects, then adds each object to the `customers` table.

### Dependencies

This code uses the following namespaces:

*   `Microsoft.Data.SqlClient`
*   `System.Text.Json`
*   `System.Text.Json.Serialization`