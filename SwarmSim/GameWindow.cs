using SFML;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace SwarmSim
{
    internal class GameWindow
    {
        RenderWindow _window;
        
        public GameWindow(Vector2u size, string title)
        {
            // Create window in sfml.net
            _window = new RenderWindow(new VideoMode(size.X, size.Y), title);
            _window.Closed += new EventHandler(OnClose);
        }

        void OnClose(object sender, EventArgs e)
        {
            // Close window when user presses close button
            RenderWindow window = (RenderWindow)sender;
            
            window.Close();
        }

        public void Close()
        {
            _window.Close();
        }

        public void Draw()
        {
            _window.Display();
        }

        public void Draw(Drawable drawable)
        {
            _window.Draw(drawable);
            _window.Display();
        }

        public void Draw(Drawable[] drawables)
        {
            // Draw circle
            foreach (Drawable drawable in drawables)
            {
                _window.Draw(drawable);
            }
            _window.Display();
        }

        public void Update()
        {
            _window.DispatchEvents();
            _window.Clear(Color.Black);
        }

        public bool IsOpen()
        {
            return _window.IsOpen;
        }
    }
}
