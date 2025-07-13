using CompanyApp;

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
#region 2

    public class HiringDate
    {
        // Properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public HiringDate(int day, int month, int year)
        {
            if (!IsValidDate(day, month, year))
                throw new ArgumentException("Invalid date. Please provide a valid day, month, and year.");

            Day = day;
            Month = month;
            Year = year;
        }
        private bool IsValidDate(int day, int month, int year)
        {
            return DateTime.TryParse($"{year}-{month}-{day}", out _);
        }
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        }
}

#endregion

#region 3
   
    class Program
    {
        static void Main()
        {
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "Alice Johnson", SecurityLevel.DBA, 15000m, new DateTime(2020, 3, 15), 'F');
            EmpArr[1] = new Employee(2, "Bob Smith", SecurityLevel.Guest, 5000m, new DateTime(2022, 7, 10), 'M');
            EmpArr[2] = new Employee(3, "Charlie Brown", SecurityLevel.DBA, 18000m, new DateTime(2019, 1, 5), 'M');
            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
                Console.WriteLine(new string('-', 40));
            }
        }
    }

#endregion