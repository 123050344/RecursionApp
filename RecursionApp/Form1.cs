namespace RecursionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Factorial Recursivo
        private int FactorialRecursivo(int n)
        {
            if (n == 0) return 1; 
            return n * FactorialRecursivo(n - 1); 
        }

        // Fibonacci Recursivo
        private int FibonacciRecursivo(int n)
        {
            if (n <= 1) return n; 
            return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2); 
        }

        // Suma Recursiva
        private int SumaRecursiva(int[] lista)
        {
            if (lista.Length == 0) return 0; 
            return lista[0] + SumaRecursiva(lista.Skip(1).ToArray()); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularFactorial_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtFactorial.Text);
            int resultado = FactorialRecursivo(n);
            lblResultadoFactorial.Text = $"Factorial: {resultado}";
        }

        private void btnCalcularFibonacci_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtFibonacci.Text);
            int resultado = FibonacciRecursivo(n);
            lblResultadoFibonacci.Text = $"Fibonacci: {resultado}";
        }

        private void btnCalcularSuma_Click(object sender, EventArgs e)
        {
            int[] lista = txtSuma.Text.Split(',').Select(int.Parse).ToArray();
            int resultado = SumaRecursiva(lista);
            lblResultadoSuma.Text = $"Suma: {resultado}";
        }
    }
}
