<h1 align="center">E-Commerce Admin Dashboard</h1>

https://evangeline-ecommerce-app-ms-sql-net-react.vercel.app/


### Built With

* React.js
* Microsoft SQL Server
* .NET Web API
* Redux
* SCSS

<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running, follow these steps.

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/mariangle/ecommerce-app-ms-sql-net-react.git
   ```

2. Back end:
   * Configure your database connection details in an `app.config` file.
   * Build and run the solution file from the "Backend" folder in Visual Studio.

> Note: This project is dated, and there are many aspects I would approach differently now. I am no longer actively developing it. However, if you intend to clone or fork it: The database was initially set up using SQL statements, which were not saved. Starting the project may be challenging due to this. I recommend using Entity Framework's update-database command to recreate the database schema based on the models.


3. Front end:
   * Navigate to the "Frontend" directory 
   * Install required npm packages   

     ```sh
     npm install
     ```
     
   * Start the front end development server   

     ```sh
     npm start
     ```

     
## Previews

**Browsing and Shopping**

https://user-images.githubusercontent.com/124585244/232165426-5b6ef0fe-9d9c-44b1-a7a6-00236a7ac21e.mp4


**Complete Checkout and User Profile**

https://user-images.githubusercontent.com/124585244/232165800-c91f324c-d68a-4244-be8e-42a71947e062.mp4



**Managing Products**

https://user-images.githubusercontent.com/124585244/232165214-5f6338a3-c6ee-4018-98c7-ae8ef98efa30.mp4

<!-- ROADMAP -->
## Roadmap
- [x] Store cart and wishlist items in local storage
- [x] Filtering and sorting options
- [x] Implement promotional offers and free shipping for orders exceeding a specific amount.
- [x] Integrate PayPal as a payment method
- [ ] Improve the application's responsiveness for smaller screens
- [ ] Implement encryption and decryption for user passwords
  - [ ] Hash passwords
- [ ] Add guest checkout functionality

