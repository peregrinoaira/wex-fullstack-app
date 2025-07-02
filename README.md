
# wex-fs-22-team-2

Github Repo: https://github.com/York-Solutions-B2E/wex-fs-22-team-2

## Overview

This is the group project for the B2E Wex Cohort.<br/>
This application will support a small online only business to keep track of its
inventory and serve its customers.

## Team Members

- David Barclay
- Valeria Sanchez
- Phil Kerschner
- Adam Flood
- Art Gomez
- Kokou Pomenou
- Ben Betzold
- Grant Gaither

## Content Table
* [Installation](#Installation)
* [Technologies](#Technologies)
* [Planning](#Planning)
* [Requirements](#Requirements)
* [Components](#Components)
* [ERD/Models](#ERD/Models)
* [Features](#Features)
* [ProjectSchedule](#ProjectSchedule)
* [Usage](#Usage)

<a name="Installation"></a>
## Installation

Github Repo: https://github.com/York-Solutions-B2E/wex-fs-22-team-2<br/>
VS Code: Run npm install, ng serve <br/>
Visual Studio: Connect with database (docker compose up -d), dotnet run<br/>

<a name="Technologies"></a>
## Technologies

- Docker: https://www.docker.com/
- DataGrip: DataBase Management https://www.jetbrains.com/datagrip/
- Swagger: BE Testing
- Dependencies: EntityFrameworkCore, EntityFrameworkCore.SqlServer, NodePacketManager


<a name="Planning"></a>
## Planning

- Jira : https://teddybears.atlassian.net/jira/software/projects/TED/boards/1
- Figma: https://www.figma.com/file/XpHeTmun6jc7MaYvDd44la/Team-Teddy-Bear?node-id=0%3A1

![image](https://user-images.githubusercontent.com/99301347/191664287-b1fc4bbf-9811-4530-b4f7-d61757ed4cc4.png)
![image](https://user-images.githubusercontent.com/99301347/191664312-9c241ef8-5deb-462d-bd47-8b7cc9af72b2.png)


<a name="Requirements"></a>
## Requirements

### Users
There are three types of users: **administrators**, **shopkeepers**, and **customers**. <br/>

**Administrators**: <br/>
-Manage all types of user accounts. <br/>
-Create/Edit/Delete all user accounts except for deleting or deescalating their own account<br/>

**Shopkeeper**
-Manage all aspects of inventory, sales, and order fulfillment. <br/>
-Create/Edit/Delete product categories <br/>
-Create/Edit/Delete inventory <br/>
-Create/Edit/Delete coupon codes with start/stop dates and use limits<br/>
-View errors/warnings <br/>

**Customers**
-Create/Edit/Delete their account (email / password). <br/>
-Place orders as guests, or with a customer account. <br/>
-View all available inventory with current price, current sale, description, discontinued status, categories<br/>
-Add items to cart, view/edit/delete items in their cart, view total cost of their cart, and checkout <br/>
-View past orders and their current cart contents if they are signed into their account <br/>

### Product/Inventory
Inventory/Product includes: <br/>
- Scheduled minimum advertised prices (effective on date), scheduled Prices (effective date), Scheduled Sales (effective date)
- Description, Images, Quantities at cost (not all shipments cost the same), Discontinued status, Available on date and Categories

<a name="Components"></a>
## Components

![image](https://user-images.githubusercontent.com/99301347/191664173-87030f8d-e8fa-4cda-88a3-b3cc122a05b7.png)


**Login/Logout**<br/>
![image](https://user-images.githubusercontent.com/99301347/191622956-629cc20c-b347-4d39-8568-564201b8d89b.png)

**Registration**<br/>
![image](https://user-images.githubusercontent.com/99301347/191622989-01454b1c-f199-4bca-a774-465559245aba.png)

**Admin View** <br/>
![image](https://user-images.githubusercontent.com/99301347/191623433-8f051aa2-5602-4216-8324-f38ae5d9e6a2.png)

**User View Edit Profile** <br/>
![image](https://user-images.githubusercontent.com/99301347/191640697-73e44ca7-4690-410e-b444-a0b639883893.png)

**View Products** <br/>
![image](https://user-images.githubusercontent.com/99301347/191640949-2e93535f-414e-4cba-946e-0d4801fd7559.png)

**View Shop** <br/>
![image](https://user-images.githubusercontent.com/99301347/191641029-233d01cc-9022-41d2-82ab-2ddc91c08196.png)

**Checkout** <br/>
![image](https://user-images.githubusercontent.com/99301347/191641129-a3e3f208-4a4b-420a-907c-e3369711f0f0.png)

**View Category** <br/>
![image](https://user-images.githubusercontent.com/99301347/191641506-199f8861-1edd-4735-b404-5b74fa5fba73.png)


<a name="ERD/Models"></a>
## ERD/Models

![image](https://user-images.githubusercontent.com/99301347/191627055-ab8cae72-eb34-4c11-8972-ecb0f69cc28a.png)

<a name="Features"></a>
## Features

<a name="ProjectSchedule"></a>
## Project Schedule

**Day 1 - W** <br/>
  Organized as a team, reviewed requirements, initiated product planning. <br/>
  Implemented Figma, Jira, set up GitHub Repository with individual repositories for each of the team members <br/>

**Day 2 - T** <br/>
  Finalized project planning, assigned frontend and backend teams.  <br/>
  Developed code relied upon by multiple components/ services. <br/>

**Day 3 - F** <br/>
  Assigned tasks to individuals, began developing individual components.<br/>
  BE: model creation and controllers creation based on figma board.<br/>

**Day 4 - M** <br/>
  Continued to implement individual components. 
  Frontend consolidated code by way of Merging in Github to assess progress and continued developing individual components.<br/>
  BE: CRUD for intial controllers and consolidating code by mergin into Github - main branch. <br/>

**Day 5 - T**<br/>
  Reconsolidated components, coordinated with backend team to verify functionality and communication between frontend and backend. <br/>
  BE: Code review and test and started connection with front end <br/>

**Day 6 - W**<br/>
  Reorganized as a team to consolidate final coding changes, assigned members to finalize presentation items.<br/>

<a name="Usage"></a>
## Usage
This is an app which acts as an online store. Customers can register and edit their own profiles. The cart is persistent, storing any items the <br/>
customer may have stored in it for later. The customer may also view previous orders, including prices and descriptions for individual products. <br/>
Shopkeepers are responsible for editing store items, such as products, categories, coupons, and sales. They may update their profile as well. <br/>
Admins oversee all users and may create, update, and delete any profile that is not thier own. <br/>
Finally, guest users may enjoy shopping without creating a profile.



