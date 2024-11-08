namespace ASPEntityProj.Models
{
    public class Departament
    {
        public int DepartamentId { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
