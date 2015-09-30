namespace ShiftAllocation {
    public struct Shift {
        public int Start;
        public int End;

        public override string ToString() {
            return string.Format( "{0} - {1}", Start, End );
        }
    }
}
