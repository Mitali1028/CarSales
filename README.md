# Carsales

This is the solution for Vehicle Management system as requested in task description.

## Design consideration.

During design of the solution I have considered future change requests like. 
 1. Requirement of processing new vehicle type (bike, boat etc) 
 2. Serivce that allows controller to get required data for display from repository.
 3. Base Repository interface for CRUD operation which can be used for different vehicle type in future and different database.
 4. Commom properties for all vehicle types in vehicle class.
 5. Some basic validation like making most of the basic fields mentioned in task as required. 
	Also checking no of doors is a integer greater than 0 etc.
 6. Basic error page to display to user in case of failure.
 


## Solution

1. Following is the Structure of the code :
   * All interfaces are generic so they can be implemented for different vehicle types.
   * IRepository - interface for CRUD operation to database.
   * CarRepository - implements the Car add, edit and select operations. All this method can be implemented in a generic base class that can be shared.
   * IService : Interface between repository and controller.
   * Carservice : implements the Iservice and calls Repository for Car Info.
   * MVC Website Project 
       Controller:
		CarController: To add car, edit and display.
		ErrorController : to handle errors in app.
	   Model: 
		Car.cs for car properties.
		Vehicle.cs for common vehicle properties.
	  View:
	    Car folder : car related pages(To add , edit and display car details)
	         
2. Unit test project added to test functionality. Not all functions have been tested but enough code coverage has been added to demonstrate the intent.


## Things considered but not taken care right now.

1. Logging
2. AngularJs or ReactJs Framework. I do not have much experience with this framework. I am currently in process of learning it.
3. Right now same Model is passed from repository to controller. This is not ideal as backend model can be different to view model. 
   Again it is kept simple for MVP, but should be considered in light of requirements.
4. Database and Tables design for the vehicle management system.
5. Properties of car are currently part of Car model. It has been done this way for MVP. In future we can consider option of having a car model
   with list of properties, but this would require more thought on database normalization and few other factors.
6. Functions in Car repository can be implemented in a generic way for sharing accross multiple repository implementation. 
   The function are small and seperated enough to easily refactor if required.
7. As seen in code most classes have default constructor and constructor that takes depenedency. Testing for classes uses contructor with parameter to inject
   mock dependency. It obviously points to missing dependency framework during project initialization. Unity framework should be considered for it.

## How to execute.

1. Clone the repository and import the project in visual studio.
2. Run the application from visual studio. User will be directed to index page with option to edit and add a new car.
3. Add car will redirect to add car page where user can add car details and save it.
4. User can edit car information and save it.
5. After each operation user will be redirect to index page.

## Feedback
It would be great if you can review the code and provide any feedback on architecture and coding based on your experience. 



  
   