using System;
using System.Reflection;

namespace Vektis {
    public class VektisData {
        public dynamic Item { get; set; }
        
        public bool HasMethod(string methodName) {
            return GetType().GetMethod(methodName) != null;
        }
        
        public dynamic Call(string methodName) {
            var method = GetType().GetMethod(methodName);
            if (method == null) {
                return null;
            }
            return method.Invoke(this, null);
        }

        public virtual dynamic Veld(VeldDefinitie velddefinitie) {
            throw new NotImplementedException();
        }
    }
}