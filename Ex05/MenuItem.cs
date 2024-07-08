using System;
namespace Ex05
{
	public interface MenuItem
	{
		void action();
	}

	public class Menu
	{
		string title;
		int NumberOfItems = 0;
		List<MenuItem> Items;
		bool exitOrBackFlag;
	}

	public class MainMenu: Menu
	{

	}

	public class tatMenu : Menu, MenuItem
	{
		void MenuItem.action()
		{

		}
	}
	
}

