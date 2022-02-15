using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthFirstSearch : MonoBehaviour
{
    public Node rootNode;
    public Node target;
    
    public int DFS(Node targetNode)
    {
        Stack stack = new Stack();
        List<Node> visitedNodes = new List<Node>();
        visitedNodes.Add(rootNode);
        stack.Push(targetNode);

        while (stack.Count > 0)
        {
            Node node = (Node)stack.Pop();
            Debug.Log("Checking " + node.name);
            foreach (Node child in node.children)
            {
                if (visitedNodes.Contains(child) == false)
                {
                    Debug.Log("Checking child " + child.name + " of node " + node.name);
                }
            }

        }
    }
}
