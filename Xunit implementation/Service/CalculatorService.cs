namespace Xunit_implementation.Service
{
    public class CalculatorService: ICalculatorService
    {
        public int add(int v1, int v2)=> v1 + v2;
        public int sub(int v1, int v2)=> v1 - v2;
        public int mul(int v1, int v2)=> v1 * v2;   

    }

    public interface ICalculatorService
    {
        int add(int v1, int v2);
        int sub(int v1, int v2);
        int mul(int v1, int v2);
    }
}
