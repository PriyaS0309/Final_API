namespace Final_API.Models
{
    public class EmployeeRepoBase
    {

        public async Task<Employee> DeleteEmployee(int id)
        {
            var result = departmentDbContext.Employees.FirstOrDefaultAsync(model => model.ID == id);

            if (result != null)
            {
                departmentDbContext.Employees.Remove(await result);
                await departmentDbContext.SaveChangesAsync();
            }
        }
    }
}