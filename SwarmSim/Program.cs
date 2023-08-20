using SFML;
using SFML.Graphics;
using SFML.System;
using SFML.Window;


namespace SwarmSim
{

    internal class Program
    {
        static void Main(string[] args)
        {
            GameWindow gameWindow = new GameWindow(new Vector2u(800, 600), "Pomocy");
            
            Sprite shipSprite = new Sprite(new Texture(Resource.ship));
            Entity ship = new(new Vector2f(100,100), shipSprite);

            // Game loop
            while (gameWindow.IsOpen())
            {
                gameWindow.Update();
                gameWindow.Draw(ship);
            }
        }
    }
}