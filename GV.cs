using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aardvark {
    public class GV {
        private static List<object> G = new List<object>();

        public static void Add(Object o){
            G.Add(o);
        }
        public static void Remove(Object o) {
            G.Remove(o);
        }

        public static Object GetAtIndex(int i) {
            return G[i];
        }

        public static List<object> Variables { get { return G; } }
        public override string ToString() {
            string s="";
            foreach (Object o in G) {
                s += o.ToString() + "\n";
            }
            return s;
        }
    }
}
