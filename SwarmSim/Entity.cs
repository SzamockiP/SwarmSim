using SFML.Graphics;
using SFML.System;

namespace SwarmSim
{
    internal class Entity : Drawable
    {
        // -------------------------------------------------------------------
        // Description
        // -------------------------------------------------------------------

        /*
         * Entity class
         * 
         * This class is used to represent any object in the game world.
         * It implements the Drawable interface so that it can be drawn
         * to the game window.
         * 
         * It contains a static count of the number of instances of the
         * class that have been created, and a constructor that increments
         * this count when called.
         * 
         * It also contains a number of properties that can be used to
         * access and modify the entity's position, sprite and scale.
         */






        // -------------------------------------------------------------------
        // Properties
        // -------------------------------------------------------------------

        // Static count of Entity instances
        static int _count = 0;

        // Private fields to store entity properties
        private Vector2f _position;
        private Sprite _sprite;
        private Vector2f _scale;





        // -------------------------------------------------------------------
        // Getters and setters
        // -------------------------------------------------------------------

        // Constructor count getter for external access
        public int Count
        {
            get { return _count; }
        }

        // Public property for getting and setting entity position
        public Vector2f Position
        {
            get { return _position; }
            set 
            { 
                _position = value;
                _sprite.Position = value; // Update sprite position when set
            }
        }

        // Public property for getting entity sprite
        public Sprite Sprite
        {
            get { return _sprite; }
        }

        // Public property for getting and setting entity scale
        public Vector2f Scale
        {
            get { return _scale; }
            set
            {
                _scale = value;
                _sprite.Scale = value; // Update sprite scale when set
            }
        }





        // -------------------------------------------------------------------
        // Constructors
        // -------------------------------------------------------------------

        // Constructor with optional parameters
        public Entity(Vector2f position = default, Sprite? sprite = null, Vector2f? scale = null)
        {
            _count++; // Increment instance count
            Position = position;
            _sprite = sprite ?? new Sprite(); // Use provided sprite or create new
            Scale = scale ?? new Vector2f(1.0f, 1.0f); // Use provided scale or default
        }
        




        // -------------------------------------------------------------------
        // Methods
        // -------------------------------------------------------------------

        // Draw method required for Drawable interface
        public void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(_sprite); // Draw the sprite to the target
        }
    }
}