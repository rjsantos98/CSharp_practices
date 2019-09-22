using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var p = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = p[0];
        int k = p[1];

        var h = new int[n];
        var c = new int[n];
        const long M = 1000000007;
        const int MaxH = 50000;

        for (int i = 0; i < n; i++)
        {
            p = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            h[i] = p[0];
            c[i] = p[1];
        }

        int mk = 1 << k;

        var helper = new int[k][];
        var helperN = new int[k][];
        for (int i = 0; i < k; i++)
        {
            helper[i] = new int[mk / 2];
            helperN[i] = new int[mk / 2];
            int off = 1 << i;
            int counter = 0;
            int counter2 = 0;
            for (int j = 1; j < mk; j++)
            {
                if ((j & off) == 0)
                    helper[i][counter++] = j;
                if ((j & off) > 0)
                    helperN[i][counter2++] = j;
            }
        }

        var tree = new long[MaxH + 1, mk];
        int maxUsedH = 0;
        for (int i = 0; i < n; i++)
        {
            if (h[i] > maxUsedH)
                maxUsedH = h[i];

            int idx = h[i] - 1;
            var sum = new long[mk];
            while (idx > 0)
            {
                for (int j = 1; j < mk; j++)
                    sum[j] = (sum[j] + tree[idx, j]);

                idx -= (idx & -idx);
            }

            var x = new long[mk];
            int off = 1 << (c[i] - 1);
            foreach (var j in helper[c[i] - 1])
                x[j | off] = (sum[j | off] + sum[j]);

            x[off]++;

            idx = h[i];
            while (idx <= MaxH)
            {
                foreach (var j in helperN[c[i] - 1])
                    tree[idx, j] = (tree[idx, j] + x[j]) % M;

                idx += (idx & -idx);
            }
        }

        {
            int idx = maxUsedH;
            long sum = 0;
            while (idx > 0)
            {
                sum = (sum + tree[idx, mk - 1]) % M;
                idx -= (idx & -idx);
            }

            Console.WriteLine(sum);
        }
    }
}