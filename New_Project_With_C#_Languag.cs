using System;
// using System.Array;

class New_Project_with_C {

    static void Main(string[] args) {

        string[] Code_List = new string[4];
        string Code_For_Find;
        bool User_Code_Is_Fuond = false;
        
        for (int i = 0; i < Code_List.Length; i++)
        {
            Console.WriteLine("Enter Code {0} :",i+1);
            Code_List[i] = Console.ReadLine();
        }
        
        Console.WriteLine("Enter Code For Search In Code List :");
        Code_For_Find = Console.ReadLine();
        
        for (int i = 0; i < Code_List.Length; i++)
        {
            if(Code_List[i] == Code_For_Find)
            {
                Console.WriteLine("Code Found");
                User_Code_Is_Fuond = true;
                break;
            }
        }
        if(User_Code_Is_Fuond == false)
            Console.WriteLine("Code Not Found");
        Console.ReadKey();
  }
}