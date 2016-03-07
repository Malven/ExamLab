using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Strategies
{
    public interface IHobbyStrategy
    {
        IQueryable<Hobby> GetHobby( IQueryable<Hobby> context );
    }
}
