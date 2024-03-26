using System.Collections;
using System.Collections.Generic;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Interfaces
{
    public interface IAllSessions
    {

        IEnumerable<Session> Sessions { get; set; }
        Session getObjSession(int CarId);
    }
}
