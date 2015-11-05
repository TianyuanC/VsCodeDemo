using System;
public class Document{
	public string Name{ get; set;}
	
	public DateTime CreatedDate{get;}
	
	public Document(string name)
	{
		Name = name;
		CreatedDate = DateTime.Now;
	}
	
	public void Print()
	{
		Console.WriteLine(string.Format("Document \"{0}\" create at {1}", Name, CreatedDate.ToString("O")));
	}
}