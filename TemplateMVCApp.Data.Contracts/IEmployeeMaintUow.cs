

using TemplateMVCApp.Model;

namespace TemplateMVCApp.Data.Contracts
{
    /// <summary>
    /// Interface for the Employee Maint "Unit of Work"
    /// </summary>
    public interface IEmployeeMaintUow
    {
        // Save pending changes to the data store.
        void Commit();

        // Repositories
        //IPersonsRepository Persons { get; }
        IRepository<Employee> Employees { get; }
        IRepository<Department> Departments { get; }
        //ISessionsRepository Sessions { get; }
        //IRepository<TimeSlot> TimeSlots { get; }
        //IRepository<Track> Tracks { get; }
        //IAttendanceRepository Attendance { get; }
    }
}