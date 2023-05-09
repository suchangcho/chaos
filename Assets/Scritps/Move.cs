using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5;
    public Animator animator; 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            animator.SetBool("Run",true);
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            this.transform.localScale = new Vector2(6,6);
        }
        else if(Input.GetAxisRaw("Horizontal") < 0)
        {
            animator.SetBool("Run", true);
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            this.transform.localScale = new Vector2(-6, 6);
        }
        else
        {
            animator.SetBool("Run", false);
        }
        //transform.position = new Vector3(Input.GetAxis(horizontal) * 0.1f + transform.position.x,transform.position.y,0f);
    }
}
