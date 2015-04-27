using RoughSet;

namespace MSI
{
    public class Result : Item
    {
        public Result(Item i, Rule r) : base(i)
        {
            _r = r.Decide(i);
        }

        private bool _r;

        public bool R
        {
            get { return _r; }
        }
    }
}