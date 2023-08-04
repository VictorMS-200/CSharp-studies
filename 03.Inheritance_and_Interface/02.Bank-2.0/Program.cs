using ClassInnerSystem;
using Employees;


void UseSystem()
{
    // Creating objects from classes (Director) and setting their properties 
    Director Matheus = new Director("123567");
    Matheus.Name = "Matheus Gomes";
    Matheus.Password = "456";


    // Creating objects from classes (Designer) and setting their properties
    Designer Daniel = new Designer("147852");
    Daniel.Name = "Daniel Henrique";
    Daniel.Password = "987";


    // Creating objects from classes (Assistant) and setting their properties
    Assistant Edward = new Assistant("235689");
    Edward.Name = "Edward Cullen";
    Edward.Password = "123";


    // Creating objects from classes (AccountManager) and setting their properties
    AccountManager Jonh = new AccountManager("124578");
    Jonh.Name = "Jonh Victor";
    Jonh.Password = "125";


    // Creating object from class (InnerSystem) and calling its method
    InnerSystem system = new InnerSystem();


    system.LogInto(Matheus, "457"); 
    system.LogInto(Daniel, "987");
    system.LogInto(Edward, "123");
    system.LogInto(Jonh, "456");
}


UseSystem();
/*
Output:

Password is incorrect!
Welcome to the system!
Welcome to the system!
Password is incorrect!
*/