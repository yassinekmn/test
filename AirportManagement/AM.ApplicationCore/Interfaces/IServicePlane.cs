using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public interface IServicePlane:IService<Plane>
    {
    IEnumerable<Plane> GetPlaneByDate(DateTime date);
        //   IEnumerable<Flight> GetFlightsbyDate(int n);

        bool Reserverplace(int n, Flight flight);

        void Supprimeravion();

       
    }
}
