using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Strategies
{
    public class HobbyFactory
    {
        private IHobbyStrategy strategy;

        public HobbyFactory() { }

        public HobbyFactory(IHobbyStrategy _strategy ) {
            strategy = _strategy;
        }

        public IHobbyStrategy GetHobbyStrategy() {
            if(DateTime.Now.DayOfWeek == DayOfWeek.Monday ) {
                HobbyDay hobbyDay = new HobbyDay();
                return hobbyDay;
            } else {
                HobbyWeek hobbyWeek = new HobbyWeek();
                return hobbyWeek;
            }
        }
    }
}
