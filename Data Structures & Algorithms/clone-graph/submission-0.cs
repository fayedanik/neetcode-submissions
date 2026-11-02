/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null) return node;
        var createdNodes = new Dictionary<Node,Node>();
        createdNodes[node] = new Node(node.val);
        var q = new Queue<Node>();
        q.Enqueue(node);
        while(q.Count > 0) {
            var current = q.Peek();
            q.Dequeue();
            foreach(var neighbor in current.neighbors) {
                if(createdNodes.TryGetValue(neighbor, out Node value)) {
                    createdNodes[current].neighbors.Add(value);
                } else {
                    createdNodes[neighbor] = new Node(neighbor.val);
                    createdNodes[current].neighbors.Add(createdNodes[neighbor]);
                    q.Enqueue(neighbor);
                }
            }
        }
        return createdNodes[node];
    }
}
