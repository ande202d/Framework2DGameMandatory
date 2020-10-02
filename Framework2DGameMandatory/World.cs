using System;
using System.Collections.Generic;
using System.Text;

namespace Framework2DGameMandatory
{
    class World
    {
        private Random random = new Random();
        private static int _width; //the width of the playground
        private static int _height; //the height of the playground
        private static int[,] _playground; //the actual playground
        private Dictionary<int[], IObjectInWorld> _objectLocations; //this should be all the locations that something is placed

        private static List<Creature> _creatures; //list of all the creatures that will live and move around in the playground
        private List<Obstacle> _obstacles; //list of all the obstacles (trees, rocks, spikes)
        private List<Wearable> _wearables; //list of all the weapons, shields, armour, etc.
        public World(int width, int height)
        {
            _width = width;
            _height = height;

            _playground = new int[height, width];
            _objectLocations = new Dictionary<int[], IObjectInWorld>();
        }

        bool PlaceOneObject<T>(T o) where T : IObjectInWorld
        {
            if (!_objectLocations.ContainsKey(o.Position))
            {
                _objectLocations.Add(o.Position, o);
                return true;
            }
            else return false; //the location was not free, and the object could not be placed
        }
    }
}
