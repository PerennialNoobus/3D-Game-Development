using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Node[] parents;
    public Node[] children;

    private void test()
    {
        if (children.Length > 0)
        {
            for (int i = 0; i < children.Length; i++)
            {
                Debug.DrawLine(transform.position, children[1].transform.position, Color.green);
            }
        }
    }
}