using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trees : MonoBehaviour
{
    public Animator tree;

    public void Update()
    {
        CallTree();
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        if (!tree)
        {
            GetComponent<Animator>().SetBool("LeftTreeCalled", false);
        }
    }
    private void CallTree()
    {
        
        GetComponent<Animator>().SetBool("LeftTreeCalled", true);
        
    }
}
