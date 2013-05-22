using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TemplateMVCApp.Data.Contracts;
using TemplateMVCApp.Model;

namespace TemplateMVCApp.ApiControllers
{
    public class LookupsController : ApiControllerBase
    {
        public LookupsController(IEmployeeMaintUow uow)
        {
            Uow = uow;
        }

        // GET: api/lookups/depts
        [ActionName("depts")]
        public IEnumerable<Department> GetDepts()
        {
            return Uow.Departments.GetAll().OrderBy(r => r.DEPARTMENT_NUMBER);
        }

       
        // Lookups: aggregates the many little lookup lists in one payload
        // to reduce roundtrips when the client launches.
        // GET: api/lookups
        [ActionName("all")]
        public Lookups GetLookups()
        {
            var lookups = new Lookups
            {
                Departments = GetDepts().ToList(),
                
            };
            return lookups;
        }

        #region OData Future: IQueryable<T>
        //[Queryable]
        // public IQueryable<Room> Get()        
        // public IQueryable<TimeSlot> Get()
        // public IQueryable<Track> Get()
        #endregion

    }
}