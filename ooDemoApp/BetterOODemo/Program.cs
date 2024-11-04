namespace  BetterOODemo;

class Program
{
    static void Main(string[] args)
    {
        string[] words = ["bot", "apple", "apricot"];
        var minimalLength = words
            .Where(w => w.StartsWith('a'))
            .Min(w => w.Length);
        Console.WriteLine(minimalLength);
        var sum = (params int[] values) => values.Sum();

        // var pet = new Pet() {Age = 10};
        //
        // var identity = new Matrix
        // {
        //     [0, 0] = 1,
        // };
        //
        // List<string> products = new List<string>();

        // var pet = new {Age = 10, Name = "Peter"};

        // Cat cat = new Cat {Age = 10, Name = "Kenny"};
        // Cat sameCat = new Cat("Kenny"){Age = 10};

        // List<IRental> rentals = new List<IRental>();
        //
        // rentals.Add(new Car() {CurrentRenter = "Car Renter"});
        // rentals.Add(new Truck() {CurrentRenter = "Truck Renter"});
        // rentals.Add(new Sailboat() {CurrentRenter = "Sailboat Renter"});
        //
        // foreach (var rental in rentals)
        // {
        //     Console.WriteLine(rental.CurrentRenter);
        // }
    }

    public class Pet
    {
        public required int Age;
        public string Name;

        public override string ToString() => $"Name: {Name} age:{Age}";
    }
    
    public class Matrix
    {
        private double[,] storage = new double[3, 3];

        public double this[int row, int col]
        {
            get => storage[row, col];
            set => storage[row, col] = value;
        }

        // public async Task<int> ExampleMethodAsync()
        // {
        //     // ...
        //     string contents = await HttpClient.GetS
        // }
    }

    public class Cat
    {   
        public int Age { get; set; }
        public string? Name { get; set; }
        
        public Cat()
        {}

        public Cat(string name)
        {
            this.Name = name;
        }
    }
    
}