namespace AdminLET.Models
{
    public class ItemModel
    {
        public class Item
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public decimal Salary { get; set; }
        }
        public class EmployeeModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public decimal Salary { get; set; }
        }
        public class Fruit
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

    }
}
