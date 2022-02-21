using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthFirstSearch : MonoBehaviour
{
    public Node rootNode;
    public Node target;

    public void Start()
    {
        int visitedNodes = DFS(target); //Call DFS method and store result to variable
        if(visitedNodes > -1) //Check that result is greater than 1 (target found)
        {
            Debug.Log(target.name + " was found by visiting " + visitedNodes + " nodes with DFS.");
        }
        else //If result is -1, target node found
        {
            Debug.Log(target.name + " was not found.");
        }
    }
    public int DFS(Node targetNode)
    {
        Stack stack = new Stack(); //Stack the nodes, the last one attached is the next one visited
        List<Node> visitedNodes = new List<Node>(); //Tracks the visited nodes
        visitedNodes.Add(rootNode); //Visit root node
        stack.Push(targetNode); //Push the root node to the stack

        while (stack.Count > 0) //While the stack is not empty
        {
            Node node = (Node)stack.Pop(); //Get the last stacked node
            Debug.Log("Checking " + node.name);
            foreach (Node child in node.children) //Loop through the children of node
            {
                if (visitedNodes.Contains(child) == false)
                {
                    //If the child has not been visited
                    Debug.Log("Checking child " + child.name + " of node " + node.name);
                    if (child == targetNode) //Target node found
                    {
                        Debug.Log("Target " + child.name + " found");
                        return visitedNodes.Count; //Return number of visited nodes
                    }
                    visitedNodes.Add(child); //Visit the node
                    stack.Push(child);//Add node to stack
                }
            }
        }
        return -1;
    }
}
