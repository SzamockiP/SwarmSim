using SFML;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace SwarmSim
{
    internal class GameWindow
    {
        // -------------------------------------------------------------------
        // Description
        // -------------------------------------------------------------------

        /*
         * GameWindow class
         * 
         * This class is used to represent the game window.
         * It contains a RenderWindow object from the SFML library.
         * 
         * It contains a constructor that creates a new RenderWindow
         * object with the specified size and title.
         * 
         * It also contains a number of properties that can be used to
         * access and modify the window's size, title and open status.
         * 
         * It contains a method for drawing to the window.
         * 
         * It contains a method for updating the window.
         */





        // -------------------------------------------------------------------
        // Properties
        // -------------------------------------------------------------------

        private RenderWindow _window;





        // -------------------------------------------------------------------
        // Getters and setters
        // -------------------------------------------------------------------
        
        // Public property for getting and setting window size
        public bool IsOpen
        {
            get { return _window.IsOpen; }
        }





        // -------------------------------------------------------------------
        // Constructor
        // -------------------------------------------------------------------

        public GameWindow(Vector2u size, string title)
        {
            // Create window in sfml.net
            _window = new RenderWindow(new VideoMode(size.X, size.Y), title);
            _window.Closed += OnClose;
        }





        // -------------------------------------------------------------------
        // Methods
        // -------------------------------------------------------------------

        // Close window when user presses close button
        private void OnClose(object? sender, EventArgs e)
        {
            // Close window when user presses close button
            //TODO: Fix CS8600 warning
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            RenderWindow window = (RenderWindow) sender;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            if (window != null)
                window.Close();
        }

        // Close window
        public void Close()
        {
            _window.Close();
        }

        // Draw to window a single drawable
        public void Draw(Drawable drawable)
        {
            _window.Draw(drawable);
        }

        // Draw to window an array of drawables
        public void Draw(Drawable[] drawables)
        {
            // Draw circle
            foreach (Drawable drawable in drawables)
            {
                _window.Draw(drawable);
            }
        }

        // Update window and clear it
        public void Update()
        {
            _window.DispatchEvents();
            _window.Display();
            _window.Clear(Color.Black);
        }
    }
}
