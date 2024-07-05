# Book Management Application - PRN212 Trial Test
This is a WPF application for managing books, developed as part of the PRN212 course. The application includes functionalities such as user authentication, book listing, adding, editing, and deleting books. The application enforces role-based access control where only administrators have full CRUD permissions.
## Introduction

The Book Management Application is designed to help users manage their book collections with functionalities for user authentication, book listing, and CRUD operations. The application enforces role-based access control, ensuring only users with the appropriate roles can perform certain actions.

## Features

1. **Authentication Function**
    - Users with Administrator or Staff roles can log in using their email address and password.
    - If the login is successful, the user's role is saved to a temporary parameter.
    - All CRUD actions require authentication with the Administrator role.
    - If login is unsuccessful, an error message is displayed: "You have no permission to access this function!".

2. **List Books**
    - Lists all books in the Book table with detailed information (BookId, BookName, Description, PublicationDate, Quantity, Price, Author, BookCategoryId, and BookGenreType).
    - Requires successful login with Administrator or Staff role.

3. **Search Books**
    - Allows searching for books by BookName or Description using relative search.
    - Requires successful login with Administrator or Staff role.

4. **Delete Book**
    - Allows deleting a selected book with confirmation.
    - Updates the book list after deletion.
    - Requires successful login with Administrator role.

5. **Add New Book**
    - Allows adding new books with the following requirements:
        - The BookCategoryId and BookGenreType come from the BookCategory table (using ComboBox UI control).
        - All fields are required.
        - Price and Quantity values must be between 0 and 4,000,000.
        - BookName must be between 5 and 90 characters, with each word starting with a capital letter.
        - Special characters are allowed in BookName.
    - Requires successful login with Administrator role.

6. **Update Book**
    - Allows updating existing book information with the same validation requirements as the Add function.
    - Requires successful login with Administrator role.
