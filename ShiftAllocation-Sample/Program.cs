using System;
using ShiftAllocation;

namespace ShiftAllocation_Sample {
    class Program {
        static void Main() {
            var shifts = new[] {
                new Shift { Start = 1800, End = 2300},
                new Shift { Start = 0800, End = 1300},
                new Shift { Start = 1200, End = 1800},
                new Shift { Start = 0800, End = 1400},
                new Shift { Start = 0800, End = 1200},
                new Shift { Start = 1300, End = 1700},
                new Shift { Start = 1400, End = 1800},
                new Shift { Start = 1300, End = 1800},
                new Shift { Start = 1800, End = 2300},
                new Shift { Start = 0900, End = 1300},
                new Shift { Start = 1800, End = 2200},
                new Shift { Start = 1900, End = 2300},
            };
            var vans = Allocator.Allocate( shifts );

            Console.WriteLine( "{0} Vans\n", vans.Count );

            var i = 0;
            foreach ( var van in vans ) {
                Console.WriteLine( "Van {0}: {1}", ++i, van );
            }

            Console.ReadLine();
        }
    }
}
