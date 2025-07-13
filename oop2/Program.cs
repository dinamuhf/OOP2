namespace CompanyApp
{
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    #region 1

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel Security { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        private char gender;
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be 'M' or 'F' only.");
                }
            }
        }

        public Employee(int id, string name, SecurityLevel security, decimal salary, DateTime hireDate, char gender)
        {
            ID = id;
            Name = name;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"ID: {ID}\n" +
                   $"Name: {Name}\n" +
                   $"Gender: {Gender}\n" +
                   $"Security Level: {Security}\n" +
                   $"Hire Date: {HireDate.ToShortDateString()}\n" +
                   $"Salary: {String.Format("{0:C}", Salary)}";
        }
    }
    class Program
    {
        static void Main()
        {
            try
            {
                Employee emp = new Employee(101, "Dina Mohamed", SecurityLevel.Developer, 8500.50m, new DateTime(2023, 5, 1), 'F');
                Console.WriteLine(emp.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
#endregion
