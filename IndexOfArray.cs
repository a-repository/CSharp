using System;
					
public class Program
{
	public static void Main()
	{
		// Create an array of names
		string [] names = new string[10]{"Joe", "Jack", "John", "Joe", "Joe", "John", "James", "Jordan", "Jimmy", "Jack"};
		
		// Loop through the array and prints all the names with it's position in array
		for(int j=0; j<names.Length; j++){
			Console.WriteLine("The name is {0} and has the number {1}", names[j], j);
						  
		}
		
		// Ask the user for a name to search for it in array
		Console.WriteLine("\nEnter a name to find it's position");
		string searchName = Console.ReadLine();
		
		
		int i;
		// Declaring variable index and set it to searched variable in array
		int index = Array.IndexOf(names, searchName);
		
		// if Index is -1 means no instance of variable found in array
		if(index == -1){
			Console.WriteLine("The name \"{0}\" does not exist in the array!", searchName);	
		}
		
		// If an instance of index found in array so print it out with its index number
		else
		{
			// It loops through array and finds the new instances after found array
			for(i=0; i<names.Length; i++){
				if(names[i] == searchName){
					Console.WriteLine("The name \"{0}\" have founded in position {1}",names[i], i);	
				}
			}
		}
		
				
	}
}