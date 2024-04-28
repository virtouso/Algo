using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class TowerOfHanoi
    {
        public  void MoveDisks(int disks, Stack<int> source, Stack<int> auxiliary, Stack<int> destination)
        {
            if (disks > 0)
            {
                // Move top (disks - 1) disks from source to auxiliary using destination as auxiliary
                MoveDisks(disks - 1, source, destination, auxiliary);

                // Move the nth disk from source to destination
                int disk = source.Pop();
                destination.Push(disk);
                Console.WriteLine($"Move disk {disk} from Source to Destination");

                // Move (disks - 1) disks from auxiliary to destination using source as auxiliary
                MoveDisks(disks - 1, auxiliary, source, destination);
            }
        }
    }
}