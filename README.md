# DataStructure

This repository contains some examples of data structure.


<div>
  <b> Example using Stack</b>
  <br>
  <div>    
     var stack = new MyStack<int>();
    
    Console.WriteLine($"Starting stack...");
    
    for (int i = 0; i < 10; i++)
    {
        stack.Push(i);
    }
                           
   Console.WriteLine($"Peek:  {stack.Peek()}");
   
    var items = stack.GetStack();
    
     while (items != null)
    {
         Console.WriteLine($"Item: {items.data}");
         items = items.next;
    }   
   </div>
</div>
