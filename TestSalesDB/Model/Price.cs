using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSalesDB.Model.Enums;

namespace TestSalesDB.Model
{
    public record Price //: IComparable<Price>
    {
        public decimal Value { get; init; }
        public Unit Unit { get; init; }

        public Price() { }
        public Price(decimal Value, Unit Unit) => (this.Value, this.Unit) = (Value, Unit);
       
        #region  IComparable
        /*
        public int CompareTo(Price other)
        {         

            Func<Unit,int> CalcIndex  =  (Unit u ) => u switch { Unit.g => 1, Unit.g100 => 100, Unit.kg => 1000, _ => 0 };

            return ( (Value * CalcIndex(Unit) / other.Value * CalcIndex(other.Unit) ) switch
            {
                decimal r  when r == 1 => 0,
                decimal r  when r > 1 =>  1,
                decimal r  when r < 1 => -1,
                _ => 0
            });
            
        }
        */
        #endregion 
    }
}
