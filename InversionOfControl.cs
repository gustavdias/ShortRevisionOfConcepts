//!The process of creating objects and all of its dependencies
//*Give me the object that I want with all its dependencies 

//smart box with everything
//you ask for Service and it know that the Service depends on the DB
// So when it gives you the service, it also gives you the DB
//Creates the Object for you with all its dependencies 
//? It helps with unit testing, 
//? commun to depend on interfaces rather than actual concrete objects (so you can mock objects)
//Service - insted of using a specific DB, you can mock it to test it


//! Lifetimes
//* Transient 
//Service registered as Transient
//ask the box for the service:
//? Transient: When resolving an object a new instance wil be returned every time

//* Scoped
//Period of time that something should exist
//http request in and out - that time is a scope

//? Scoped: When resolving an object inside of a scope. THe same instance is returned.
//throughtout the scope, it gives always the same service
// you ask 3x in the same scope, you will get the same instance 3x.

//* Singleton
//* Single instance of a object throughout the entire application
//every single time that you ask your Service from the box, you will get the same.

//? Singleton: When resolving an object the same instance is returned every time