using System;
using ClassBonus;
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


void CalculateBonus()
{
    // Creating objects from classes (Director) and setting their properties 
    Director Matheus = new Director("123567");
    Matheus.Name = "Matheus Gomes";

    // Creating objects from classes (Designer) and setting their properties
    Designer Daniel = new Designer("147852");
    Daniel.Name = "Daniel Henrique";

    // Creating objects from classes (Assistant) and setting their properties
    Assistant Edward = new Assistant("235689");
    Edward.Name = "Edward Cullen";

    // Creating objects from classes (AccountManager) and setting their properties
    AccountManager Jonh = new AccountManager("124578");
    Jonh.Name = "Jonh Victor";

    // Creating object from class (BonusManager) and calling its method
    BonusManager bonusManager = new BonusManager();

    bonusManager.Register(Matheus);
    bonusManager.Register(Daniel);
    bonusManager.Register(Edward);
    bonusManager.Register(Jonh);

    Console.WriteLine("Total Bonus = " + bonusManager.BonusAmount);
}


UseSystem();
/*
Output:

Password is incorrect!
Welcome to the system!
Welcome to the system!
Password is incorrect!
*/

CalculateBonus();
/*
Output:

Total Bonus = 4410
*/