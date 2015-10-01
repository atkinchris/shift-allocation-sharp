using System.Collections.Generic;
using System.Linq;

namespace ShiftAllocation {
    public static class Allocator {
        public static IList<Van> Allocate( IEnumerable<Shift> shifts ) {
            shifts = shifts.OrderBy( s => s.Start ).ThenBy( s => s.End );

            IList<Van> vans = new List<Van>();

            foreach ( var shift in shifts ) {
                vans = SortVans( vans );
                var van = vans.FirstOrDefault( v => shift.Start >= v.End() );
                if ( van != null ) {
                    van.Shifts.Add( shift );
                } else {
                    van = new Van();
                    van.Shifts.Add( shift );
                    vans.Add( van );
                }
            }

            return vans;
        }

        private static IList<Van> SortVans( IEnumerable<Van> vans ) {
            return vans.OrderBy( v => v.End() ).ToList();
        }
    }
}
