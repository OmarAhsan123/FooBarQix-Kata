using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKataProblem2
{
    public class FooBarQix
    {
        private readonly int _number;
        private readonly Dictionary<int, string> _lookupValues;
        private bool _isNotDivisible;

        public FooBarQix(int number)
        {
            this._number = number;

            _lookupValues = new Dictionary<int, string>()
            {
                {3, "Foo"},
                {5, "Bar"},
                {7, "Qix"},
                {0, "*"}
            };

        }

        private string IsDivisible(int value, string fooBarQix)
        {
            return _number % value == 0 ? fooBarQix : "";
        }

        private string ResultContains()
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in _number.ToString())
            {
                int val = int.Parse(c.ToString());

                if (_lookupValues.ContainsKey(val))
                    result.Append(_lookupValues[val]);
                else if (_isNotDivisible)
                    result.Append(c.ToString());
            }

            return result.ToString();
        }
        
        private string FooBarQixResult()
        {
            StringBuilder result = new StringBuilder();

            if (_number == 0)
                return "*";

            result.Append(IsDivisible(3, "Foo"));
            result.Append(IsDivisible(5, "Bar"));
            result.Append(IsDivisible(7, "Qix"));

            _isNotDivisible = string.IsNullOrEmpty(result.ToString());

            return result.Append(ResultContains()).ToString();

        }

        private string GetResultIfEmpty(string result)
        {
            return string.IsNullOrEmpty(result.ToString()) ? _number.ToString() : result.ToString();
        }

        public string GetFooBarQixResult()
        {
            return GetResultIfEmpty(FooBarQixResult());
        }

    }
}
