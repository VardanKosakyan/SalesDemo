using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSalesDB.Model
{
    [Serializable]
    public abstract class ValueObject : IEquatable<ValueObject>
    {
        public bool Equals(ValueObject other)
        {
            if (object.Equals(other, null) || this.GetType() != other.GetType())
                return false;
            var ValueObjectType = this.GetType();
            var ValueProperties = ValueObjectType.GetProperties();
            foreach (var ValueProperty in ValueProperties)
            {
                if ((ValueProperty.GetValue(this) == null && ValueProperty.GetValue(other) != null) || (ValueProperty.GetValue(this) != null && ValueProperty.GetValue(other) == null))
                    return false;
                if (!(ValueProperty.GetValue(this) == null && ValueProperty.GetValue(other) == null) && !ValueProperty.GetValue(this).Equals(ValueProperty.GetValue(other)))
                    return false;
            }
            return true;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj) && this.Equals(obj as ValueObject);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(ValueObject ValueObj1, ValueObject ValueObj2)
        {
            if (object.Equals(ValueObj1, null))
                return object.Equals(ValueObj2, null);
            return ValueObj1.Equals(ValueObj2);
        }
        public static bool operator !=(ValueObject ValueObj1, ValueObject ValueObj2)
        {
            if (object.Equals(ValueObj1, null))
                return !object.Equals(ValueObj2, null);
            return !ValueObj1.Equals(ValueObj2);
        }
    }
}
