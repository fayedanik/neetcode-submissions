public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var adjList = new Dictionary<int, List<int>>();
        for(int i = 0; i < numCourses; i++) adjList[i] = new List<int>();
        for(int i = 0; i < prerequisites.Length; i++) {
            adjList[prerequisites[i][0]].Add(prerequisites[i][1]);
        }
        bool[] visited = new bool[numCourses];
        bool[] pathTrac = new bool[numCourses];
        bool Dfs(int u) {
            visited[u] = true;
            pathTrac[u] = true;
            bool isCylic = false;
            foreach(var v in adjList[u]) {
                if(pathTrac[v] && visited[v]) return true;
                else if(!visited[v]) {
                    isCylic = isCylic | Dfs(v);
                } 
            }
            pathTrac[u] = false;
            return isCylic;
        }
        for(int i = 0; i < numCourses; i++) {
            if(!visited[i]) {
                if(Dfs(i)) return false;
            }
        }
        return true;
    }
}
