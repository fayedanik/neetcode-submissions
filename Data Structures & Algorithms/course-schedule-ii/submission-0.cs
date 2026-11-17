public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var edges = new List<List<int>>();
        bool[] vis = new bool[numCourses]; 
        bool[] inCurrentPath = new bool[numCourses];
        int[] outDeg = new int[numCourses];
        var visOrder = new List<int>();

        bool IsCyclic(int u) {
            vis[u] = true;
            inCurrentPath[u] = true;
            foreach(var n in edges[u]) {
                if(inCurrentPath[n]) {
                    return true;
                }
                else if(!vis[n]) {
                    if(IsCyclic(n)) return true;
                }
            }
            inCurrentPath[u] = false;
            return false;
        }

        for(int i = 0; i < numCourses; i++) {
            edges.Add(new List<int>());
            vis[i] = false;
            inCurrentPath[i] = false;
        }

        for(int i = 0; i < prerequisites.Length; i++) {
            var u = prerequisites[i][0];
            var v = prerequisites[i][1];
            edges[v].Add(u);
            outDeg[u]++;
        }

        var ans = new List<int>();
        for(int i = 0; i < numCourses; i++) {
            if(!vis[i] && IsCyclic(i)) {
                return ans.ToArray();
            }
        }

        var q = new Queue<int>();

        for(int i = 0; i < numCourses; i++) {
            vis[i] = false;
            if(outDeg[i] == 0) {
                q.Enqueue(i);
                vis[i] = true;
            }
        }
        while(q.Count > 0) {
            var tp = q.Peek();
            q.Dequeue();
            ans.Add(tp);
            foreach(var p in edges[tp]) {
                if(!vis[p]) {
                    q.Enqueue(p);
                    vis[p] = true;
                }
            }
        }
        return ans.ToArray();
    }
}
