using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Strategies
{
    public class HobbyDay : IHobbyStrategy {

        public IQueryable<Hobby> GetHobby( IQueryable<Hobby> hobbies ) {

            hobbies = hobbies.Skip( 1 );

            return hobbies;
        }
    }
}
