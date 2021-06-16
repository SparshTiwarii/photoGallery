class Program 
{ 
         static void Main(string[] args) 
         { 
             Pet p1 = new Pet(2,"Sweety","Dog"); 
             p1.Display(); 
             Pet p2 = new Pet(3,"Lovely"); 
             p2.Display(); 
             Console.ReadKey(); 
         } 
 }
 class Pet 
 { 
         int age; 
         string family; 
         string name;  
         public Pet(int age,string name, string family) 
         { 
             this.age = age; 
             this.name = name; 
             this.family = family; 
           }  
         public Pet(int age, string family) 
         { 
             this.age = 1; 
             this.name = "Chocky"; 
             this.family = family;    
         } 
         public void Display() 
         { 
             Console.WriteLine("Age: " + age + " Family: " + family + " Name: " + name); 
         } 
 }   