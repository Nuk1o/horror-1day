using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateControllerPlayer : MonoBehaviour
{
    [SerializeField] Animator animator_n;
    IEnumerable Start()
    {
        animator_n = GetComponent<Animator>();
        yield return new WaitForSeconds(3);
        //animator_n.SetTrigger("walk");
    }

    
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        if(x > 0 || z > 0)
        {
            animator_n.SetTrigger("Walk");

            if (Input.GetKey(KeyCode.LeftControl))
            {
                animator_n.SetTrigger("Croun");
            }
            else
            {
                animator_n.ResetTrigger("Croun");
            }
        }
        else
        {
            animator_n.ResetTrigger("Walk");
            animator_n.ResetTrigger("Croun");
        }
    }
}
