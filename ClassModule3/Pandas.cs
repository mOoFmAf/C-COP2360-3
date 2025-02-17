
using System;
using System.Collections;

	
public class Panda
{
  string name;                   // Define field
  public Panda (string n)        // Define constructor
  {
    name = n;                    // Initialization code (set up field)
  }
  
  public string getName() {
	  return name;
  }
}


public class Program {
	static void Main() {
		
		ArrayList pandas = new ArrayList();
		
		
		pandas.Add(new Panda("Gerald"));
		pandas.Add(new Panda("Hopkins"));
		
		foreach (Panda p in pandas) {
			Console.WriteLine(p.getName());
		}
	}
}