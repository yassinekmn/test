using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : Service<Flight>, IServiceFlight
    {
        public ServiceFlight(Interfaces.IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Flight> GetFlightsbyDate(int n)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Staff> GetStaffbyId(int idflight)
        {
            return GetById(idflight).Passengers.OfType<Staff>();
        }
        
    }
}
