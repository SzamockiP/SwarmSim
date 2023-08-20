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
            // Create a new window
            GameWindow gameWindow = new GameWindow(new Vector2u(800, 600), "Pomocy");
            World world = new World();


            // Create a new ship
            Sprite shipSprite = new Sprite(new Texture(Resource.ship));
            Entity ship = new(new Vector2f(100,100), shipSprite);


            // Add the ship to the world
            world.AddEntity(ship);
            Console.WriteLine(world.ToString());


            // Game loop
            while (gameWindow.IsOpen)
            {
                gameWindow.Update();
                gameWindow.Draw(world.Entities);
            }
        }
    }
}