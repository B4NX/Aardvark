using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aardvark {
    static class GV {
        private static List<object> G = new List<object>();

        public static void Add(Object o){
            G.Add(o);
        }
        public static void Remove(Object o) {
            G.Remove(o);
        }

        public static List<object> Variables { get { return G; } }
    }
}
