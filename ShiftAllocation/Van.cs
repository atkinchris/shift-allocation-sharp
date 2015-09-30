using System.Collections.Generic;
using System.Linq;

namespace ShiftAllocation {
    public class Van {
        public IList<Shift> Shifts { get; set; }

        public Van() {
            Shifts = new List<Shift>();
        }

        public int End() {
            return Shifts.Max( s => s.End );
        }

        public override string ToString() {
            return string.Join( " | ", Shifts );
        }
    }
}
