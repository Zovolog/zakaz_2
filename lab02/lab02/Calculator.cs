namespace Task1
{
    public class Calculator<T>
    {
        // Делегат для додавання
        public delegate T AddDelegate(T a, T b);

        // Делегат для віднімання
        public delegate T SubtractDelegate(T a, T b);

        // Делегат для множення
        public delegate T MultiplyDelegate(T a, T b);

        // Делегат для ділення
        public delegate T DivideDelegate(T a, T b);

        public AddDelegate Add { get; set; }
        public SubtractDelegate Subtract { get; set; }
        public MultiplyDelegate Multiply { get; set; }
        public DivideDelegate Divide { get; set; }

        public Calculator()
        {
            Add = (a, b) => (dynamic)a + b;
            Subtract = (a, b) => (dynamic)a - b;
            Multiply = (a, b) => (dynamic)a * b;
            Divide = (a, b) => (dynamic)a / b;
        }
        public T PerformAddition(T a, T b)
        {
            return Add(a, b);
        }

        public T PerformSubtraction(T a, T b)
        {
            return Subtract(a, b);
        }

        public T PerformMultiplication(T a, T b)
        {
            return Multiply(a, b);
        }

        public T PerformDivision(T a, T b)
        {
            if (b.Equals(0))
            {
                throw new DivideByZeroException("Неможливо ділити на нуль.");
            }
            return Divide(a, b);
        }
    }
}