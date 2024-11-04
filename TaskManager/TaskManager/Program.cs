namespace taskManager 
{
    internal abstract class Program
    {
        static void Main(string[] args)
        {
            Menu.Start();

            while (true) {
                
                Console.WriteLine("Click A to Add Task, B to Remove Task, C to Edit Task, D to display all tasks, E to display a single Task, Q to Quit");
                var chr = Console.ReadLine();
                
                if (chr == null) continue;
                if (chr.Equals("Q", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                } else if (chr.Equals("E", StringComparison.CurrentCultureIgnoreCase))
                {
                    Menu.PromptGetTask();
                } else if (chr.Equals("C", StringComparison.CurrentCultureIgnoreCase))
                {
                    Menu.PromptEditTask();
                } else if (chr.Equals("A", StringComparison.CurrentCultureIgnoreCase))
                {
                    Menu.PromptAddTask();
                } else if (chr.Equals("D", StringComparison.CurrentCultureIgnoreCase))
                {
                    Menu.PromptDisplayAll();
                } else if (chr.Equals("B", StringComparison.CurrentCultureIgnoreCase))
                {
                  Menu.PromotRemoveTask();  
                }
            } 
            
            
        }    
    }
        
    
}

