using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_player : MonoBehaviour
{ public LayerMask nonwalkableLayer;
    public LayerMask InteractableLayer;
    public float movespeed;
    public bool isMoving;
    private Vector2 input;
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (!isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");//right key hori input 1 and left hori input -1
            input.y = Input.GetAxisRaw("Vertical");
            if (input.x != 0)
                input.y = 0;
            if (input != Vector2.zero)
            {
                animator.SetFloat("X", input.x);
                animator.SetFloat("Y", input.y);
                var targetPos = transform.position;
                targetPos.x += input.x;
                targetPos.y += input.y;
                if(IsWalkable(targetPos))
                StartCoroutine(Move(targetPos));            }
        }
        animator.SetBool("isMoving", isMoving);

        if (Input.GetKeyDown(KeyCode.Z))
            Interact();
    }
    void Interact()
    {
        var facingDir = new Vector3(animator.GetFloat("X"),animator.GetFloat("Y"));
        var interactPos = transform.position+facingDir;
        var collider = Physics2D.OverlapCircle(interactPos, 0.3f, InteractableLayer);
        if (collider != null )
        {
            collider.GetComponent<Interactable>()?.Interact();
        }
    }
    IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;
        while((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon){
            transform.position = Vector3.MoveTowards(transform.position, targetPos, movespeed);
                yield return null;
        }
        transform.position = targetPos;
        isMoving = false;
    }

    private bool IsWalkable(Vector3 targetPos)
    {
        if(Physics2D.OverlapCircle(targetPos, 0.3f, nonwalkableLayer| InteractableLayer)!= null){
            return false;
        }
        return true;
    }
   
}
 