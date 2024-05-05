public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add 2 people to a priority queue with the second person having a higher priority: Michael (1), Fred (2) 
        // Expected Result: Fred, Michael
        Console.WriteLine("Test 1");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Michael", 1);
        priorityQueue.Enqueue("Fred", 2);

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(priorityQueue.Dequeue());
        }

        // Defect(s) Found: 
        // Dequeue doesn't remove someone from the queue
        // Dequeue priority check doesn't dequeue the person with the highest priority

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Add 3 people to a priority queue with the first and the last having the same priority, higher than th second: Michael (2), Fred (1), Harry (2)
        // Expected Result: Michael, Harry, Fred
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Michael", 2);
        priorityQueue.Enqueue("Fred", 1);
        priorityQueue.Enqueue("Harry", 2);

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(priorityQueue.Dequeue());
        }

        // Defect(s) Found: 
        // Dequeue doesn't remove someone from the queue
        // Dequeue priority check doesn't dequeue the person with the highest priority
        // Dequeue removes the person closest the back if there are multiple with the highest priority

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Try to get the next person from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue.Dequeue());
    }
}