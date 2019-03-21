public class Solution {
    public int MaxEnvelopes (int[, ] envelopes) {
        var dolls = new List<Doll> ();
        var len = envelopes.GetLength (0);
        for (int i = 0; i < len; i++) {
            dolls.Add (new Doll (envelopes[i, 0], envelopes[i, 1]));
        }
        dolls = dolls.OrderBy (e => e.W).ThenBy (e => e.H).ToList ();
        var max = 0;
        var cache = new int[len];
        for (int i = 0; i < len; i++) {
            var re = Recursive (dolls, i, cache);
            max = Math.Max (max, re);
        }
        return max;
    }

    public int Recursive (IList<Doll> dolls, int index, int[] cache) {
        if (cache[index] != 0) {
            return cache[index];
        }
        var max = 1;
        var small = dolls[index];
        for (int i = index + 1; i < dolls.Count; i++) {
            var big = dolls[i];
            if (small.W < big.W && small.H < big.H) {
                var re = Recursive (dolls, i, cache);
                max = Math.Max (max, re + 1);
            }
        }
        cache[index] = max;
        return max;
    }

    public class Doll {
        public Doll (int w, int h) {
            W = w;
            H = h;
        }

        public int W { get; private set; }
        public int H { get; private set; }
    }
}