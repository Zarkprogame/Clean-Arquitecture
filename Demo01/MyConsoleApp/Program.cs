using MyLibrary;

internal class Program
{
	private static void Main(string[] args)
	{
		MessageWritter MyWritter = new MessageWritter();
		MyWritter.Write("Hello, Writter!");

		FiggleWritter figgleWritter = new FiggleWritter();
		figgleWritter.Write("Hello, Figgle!!!!");
	}
}