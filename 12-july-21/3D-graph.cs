// 2.  Write a program which works like a 3D graph moves. where the user enters x , y and z coordinates.This program should take user inputs initialization using a constructor.  The program can have a Move() method to register the new location. Overload method using value types (int x, int y, intz) and also by passing the actual class instance (which has fields x,y  and z)
// Consider basic exception handling where ever applicable

using System;

namespace day6
{
    class Graph
    {
        public int x, y, z;
        public Graph(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        //initializing new values for new location
        public void move(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        //copying the constructor
        public void move(Graph graph)
        {
            if(graph == null)
                return;
            
            this.x = graph.x;
            this.y = graph.y;
            this.z = graph.z;
        }

        public void printGraph()
        {
            Console.WriteLine($"coordinates x : {x}, coordinates y : {y},coordinates z : {z}", x, y, z);
        }
    }
}
