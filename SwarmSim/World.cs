using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwarmSim
{
    internal class World
    {
        // -------------------------------------------------------------------
        // Description
        // -------------------------------------------------------------------






        // -------------------------------------------------------------------
        // Properties
        // -------------------------------------------------------------------

        private List<Entity> _entities;
        




        // -------------------------------------------------------------------
        // Getters and setters
        // -------------------------------------------------------------------
        
        public Entity[] Entities
        {
            get { return _entities.ToArray(); }
        }





        // -------------------------------------------------------------------
        // Constructor
        // -------------------------------------------------------------------

        public World() 
        {
            _entities = new List<Entity>();
        }




        // -------------------------------------------------------------------
        // Methods
        // -------------------------------------------------------------------

        // Add an entity to the world
        public void AddEntity(Entity entity)
        {
            _entities.Add(entity);
        }

        // Remove an entity from the world
        public void RemoveEntity(Entity entity)
        {
            _entities.Remove(entity);
        }

        // Clear the world of all entities
        public void Clear()
        {
            _entities.Clear();
        }

        override public string ToString()
        {
            return "Entities: " + _entities.Count;
        }

    }
}
