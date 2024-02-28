using System;

namespace WorkingWithProperties
{
	internal class WorkingWithProperties
	{
		static void Main()
		{
			Player player = new Player(8, 8, '@');
			Renderer renderer = new Renderer();
			renderer.Draw(player.PositionX, player.PositionY, player.PlayerSymbol);
		}
	}
}

class Player
{
	public Player(int positionX, int positionY, char playerSymbol)
	{
		PositionX = positionX;
		PositionY = positionY;
		PlayerSymbol = playerSymbol;
	}

	public int PositionX { get; private set; }
	public int PositionY { get; private set; }
	public char PlayerSymbol { get; private set; }
}

class Renderer
{
	public void Draw(int positionX, int positionY, char playerSymbol)
	{
		Console.SetCursorPosition(positionX, positionY);
		Console.WriteLine(playerSymbol);
	}
}