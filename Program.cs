<<<<<<< HEAD
﻿//// Tipos de datos
//int myint = 5;
//double mydouble = 3.4;
//float myfloat = 4.56f;
//decimal mydecimal = 4.56m;

//string mystring = "Michelle";

//bool mybool = true;

//var myVar = 23.4;


//Console.WriteLine($"Mi valor entero es..: {myint, 20:N2}");
//Console.WriteLine($"Mi valor doble es..: {mydouble, 20:N2}");
//Console.WriteLine($"Mi valor float es..: {myfloat, 20:P2}");
//Console.WriteLine($"Mi valor decimal es: {mydecimal, 20:C2}");
//Console.WriteLine($"Mi nombre es.......: {mystring}");
//Console.WriteLine($"Mi boolean es......: {(mybool ? "Correcto": "Incorrecto")}");  //if en una sola linea o tenrnarios


using OOPConceptos.Logica;
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

try
{
    var empleado1 = new SalaryEmployes()
    {
        Id = 1010,
        FirsName = "Carlos",
        LastName = "Mencias",
        BornDate = new Date(1993, 5, 23),
        HireDate = new Date(2023, 5, 10),
        IsActive = true,
        Salary = 600
    };

    var empleado2 = new HourEmploye()
    {
        Id = 2020,
        FirsName = "Alexis",
        LastName = "Sanchez",
        BornDate = new Date(1996, 9, 25),
        HireDate = new Date(2020, 6, 20),
        IsActive = true,
        HourValue = 8,
        WorkingValue = 25
    };

    var empleado3 = new ComisinEmployed()
    {
        Id = 3030,
        FirsName = "Michelle",
        LastName = "Vaca",
        BornDate = new Date(2000, 5, 20),
        HireDate = new Date(2022, 5, 10),
        IsActive = true,
        ComisionPorcentaje = 0.5f,
        Sales = 300
    };

    var empleado4 = new BaseComisionEmployes()
    {
        Id = 4040,
        FirsName = "Jorge",
        LastName = "Yanez",
        BornDate = new Date(1997, 7, 25),
        HireDate = new Date(2011, 11, 2),
        IsActive = true,
        ComisionPorcentaje = 0.25f,
        Sales = 3050,
        Salary = 200
    };

    //Invoices

    var invoice1 = new Invoice()
    {
        Id = 0034,
        Description = "Mac Pro",
        Price = 1500,
        Quantity = 3
    };

    var invoice2 = new Invoice()
    {
        Id = 0038,
        Description = "Samsung Tablet",
        Price = 500,
        Quantity = 30
    };

    var invoice3 = new Invoice()
    {
        Id = 0040,
        Description = "Impresoras",
        Price = 200,
        Quantity = 12
    };



    //Impresiones

    Employes[] empleados = new Employes[]
    {
        empleado1, empleado2, empleado3, empleado4
    };

    decimal comisionTotalaPagar = 0;

    foreach (Employes empleado in empleados)
    {
        Console.WriteLine(empleado);
        comisionTotalaPagar += empleado.GetValueToPay();
    }

    Console.WriteLine($"==========================   TOTAL   ============================");
    Console.WriteLine($"Total a Pagar Empleados \t\t     {comisionTotalaPagar,20:C2}\n\n");




    decimal totalFacturas = 0;

    Invoice[] invoices = new Invoice[]
    {
        invoice1, invoice2, invoice3
    };

    foreach (Invoice invoice in invoices)
    {
        Console.WriteLine(invoice);
        totalFacturas += invoice.GetValueToPay();
    }

    Console.WriteLine($"======================== TOTAL FACTURAS =========================");
    Console.WriteLine($"Total a Pagar Productos \t\t     {totalFacturas,20:C2}");




    // Implementar la suma de egresos

    decimal SumaEgresos()
    {
        decimal SumaEgresos = comisionTotalaPagar;
        return SumaEgresos;
    }

    Console.WriteLine($"======================== TOTAL EGRESOS ==========================");
    Console.WriteLine($"Total Egresos \t\t\t\t     {SumaEgresos(),20:C2}");

    // Implementar ingresos que genera el total de vendedores por comision
    decimal SumaIngresos()
    {
        decimal sumaIngresos = totalFacturas;
        return sumaIngresos;
    }

    // Restar ingresos - egresos
    Console.WriteLine($"======================== TOTAL INGRESOS - EGRESOS ==========================");
    Console.WriteLine($"Total Ingresos - Egresos \t\t     {(SumaIngresos() - SumaEgresos()),20:C2}");

}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}