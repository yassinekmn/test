using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class ServicePlane : Service<Plane>, IServicePlane
    {
        public ServicePlane(ApplicationCore.Interfaces.IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

       /* public IEnumerable<Flight> GetFlightsbyDate()
        {
            return GetMany(f=>f.);
        }
       */
        public IEnumerable<Plane> GetPlaneByDate(DateTime date)
        {
         //  return GetMany(p=>p.ManufactureDate.Equals(date));   
            var query = from a in GetAll()
                        where a.ManufactureDate == date 
                        select a;
            return query;
        }

       

        public bool Reserverplace(int n, Flight flight)
        {
            return (flight.Plane.Capacity-flight.Passengers.Count()>=n);
        }

        public void Supprimeravion()
        {
           Delete(p=>p.ManufactureDate.AddYears(10) <DateTime.Now);
        }
    }
}
