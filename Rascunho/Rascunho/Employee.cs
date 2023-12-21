using System.Globalization;

namespace Rascunho
{
    class Employee
    {
        public string Name;
        public double BaseSalay;
        public double Tax;

        public double NetSalary()
        {
            return BaseSalay - Tax;
        }

        public void IncreaseSalary(double percentage)
        {
            BaseSalay += BaseSalay / 100 * percentage;
        }

        public override string ToString()
        {
            return
                Name + ", $ " + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
