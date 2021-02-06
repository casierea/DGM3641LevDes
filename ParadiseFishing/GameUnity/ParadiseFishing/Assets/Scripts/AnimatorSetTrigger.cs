using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSetTrigger : MonoBehaviour
{
    public string name;
    
    public Animator anim;
    
    public void Set()
    {
        anim.SetTrigger(name);
    }
}