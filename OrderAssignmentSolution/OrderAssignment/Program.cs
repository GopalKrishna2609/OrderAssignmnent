using System;


namespace OrderAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************************Welcome to Order Assignment******************************************");
            Console.WriteLine("Please Select One of the Options:\n");
            Console.WriteLine("\t\tPress 1 for Item Master");
            Console.WriteLine("\t\tPress 2 for Customer Master");
            Console.WriteLine("\t\tPress 3 to Exit");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            switch (choice1)
            {


                case 1:

                Portal:

                    ItemMaster itemMaster = new ItemMaster();

                    Console.WriteLine("****************************************Welcome to Item Portal************************************");
                    Console.WriteLine("Please Select one of the Options :\n");
                    Console.WriteLine("\t\tPress 1 to Insert Item Data.");
                    Console.WriteLine("\t\tPress 2 to Update Item Data.");
                    Console.WriteLine("\t\tPress 3 to Delete Item.");
                    Console.WriteLine("\t\tPress 4 to all item Table data.");
                    Console.WriteLine("\t\tPress 5 to Exit");

                    int choice2 = Convert.ToInt32(Console.ReadLine());
                    switch (choice2)
                    {
                        case 1:
                            itemMaster.AddItem();
                            goto Portal;
                        case 2:
                            itemMaster.DeleteItem();
                            goto Portal;
                        case 3:
                            itemMaster.UpdateItem();
                            goto Portal;
                        case 4:
                            itemMaster.ListAllItems();
                            goto Portal;
                        case 5:

                            break;


                        default:
                            Console.WriteLine("Wrong Choise Try Again");
                            goto Portal;


                            ;

                    }
                    break;

                case 2:

                    CustomerMaster customerMaster = new CustomerMaster();

                portal1:

                    Console.WriteLine("********************************************Welcome to Customer Portal*****************************************");
                    Console.WriteLine("Please Select one of the Options :\n");
                    Console.WriteLine("\t\tPress 1 to Insert New Customer.");
                    Console.WriteLine("\t\tPress 2 to Update Customer.");
                    Console.WriteLine("\t\tPress 3 to Delete Customer.");
                    Console.WriteLine("\t\tPress 4 to all Customer Table data.");
                    Console.WriteLine("\t\tPress 5 to Exit");
                    int choice3 = Convert.ToInt32(Console.ReadLine());
                    switch (choice3)
                    {
                        case 1:
                            customerMaster.AddCustomer();
                            goto portal1;

                           

                        case 2:
                            customerMaster.UpdateCustomer();
                            goto Portal;


                            

                        case 3:
                            customerMaster.DeleteCustomer();
                            goto portal1;

                            


                        case 4:
                            customerMaster.ListAllCustomers();
                            goto portal1;
                            


                        case 5:
                            break;
                    }


                    Console.ReadLine();


                    break;

                case 3:

                    break;





            }


        }
    }
}
