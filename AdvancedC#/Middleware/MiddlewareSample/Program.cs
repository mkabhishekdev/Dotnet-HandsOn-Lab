public class Program
{
    public static void Main(string[] args)
    {
        Program p = new Program();

        
    }

    public void First(string message)
    {
        Console.WriteLine("executing first function: "+message);
    }

    public void Second(string message)
    {
        Console.WriteLine("executing second function: "+message);
    }
    
    public class PipeBuilder
    {
        Action<string> _mainAction;
        List<Type> _pipeTypes;

        public PipeBuilder(Action<string> mainAction)
        {
            _mainAction = mainAction;
            _pipeTypes = new List<Type>();
        }

        public void AddPipe(Type pipeType)
        {
            if(!pipeType.GetTypeInfo().IsInstanceOfType(typeof(Pipe)))
            {
                throw new Exception();
            }
            _pipeTypes.Add(pipeType);
        }
    }

    public abstract class Pipe
    {
        protected Action<string> _action;  // reflect on why is this 'protected'
        public Pipe(Action<string> action)
        {
            _action = action;    
        }    

        public abstract void Handle(string msg);
    }

    public class Wrap : Pipe
    {
        public Wrap(Action<string> action) : base(action) { }
        public override void Handle(string msg)
        {
            Console.WriteLine("Starts the: "+msg);
            _action(msg);   // you are able to use _action because it is declared 'protected' in the parent class 'Pipe'
            Console.WriteLine("Ends");
        }
    }

    public class Try : Pipe
    {
        public Try(Action<string> action) : base(action) { }
        public override void Handle(string msg)
        {
            try
            {
                Console.WriteLine("trying: "+message);
                _action(message);     // again protected member from parent class being accessed
            }
            catch(Exception)
            {
            
            }
        }
    }
 
   
}