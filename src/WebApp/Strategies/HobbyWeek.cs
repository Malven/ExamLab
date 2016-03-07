using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Strategies
{
    public class HobbyWeek : IHobbyStrategy {
        public IQueryable<Hobby> GetHobby( IQueryable<Hobby> hobbies ) {

            hobbies = hobbies.Skip(2);

            return hobbies;
        }
    }
}
