using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class controls : MonoBehaviour
{

    Animator animator;

    int isWalkingHash;
    int isAttackingHash;

    Player input;

    Vector2 currentMovement;
    bool movementPressed;
    bool attackingPressed;


    void Awake()
    {
        input =  new Player();
        input.PlayerMain.Move.performed += ctx =>{
            currentMovement = ctx.ReadValue<Vector2>();
            movementPressed = currentMovement.x != 0 || currentMovement.y != 0;
        };
        input.PlayerMain.Attack.performed += ctx =>{
            attackingPressed = ctx.ReadValueAsButton();
        };
    }
    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isAttackingHash = Animator.StringToHash("isAttacking");
    }

    // Update is called once per frame
    void Update()
    {
      handleMovement();
      handleRotation();
    }

    void handleRotation()
    {
        Vector3 currentPosition = transform.position;
        Vector3 newPosition = new Vector3(currentMovement.x, 0, currentMovement.y);
        Vector3 positionToLookAt = currentPosition + newPosition;

        transform.LookAt(positionToLookAt);
    }

    void handleMovement(){
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isAttacking = animator.GetBool(isAttackingHash);

        if(movementPressed && !isWalking)
        {
            animator.SetBool(isWalkingHash,true);
        }
        if(!movementPressed && isWalking)
        {
            animator.SetBool(isWalkingHash,false);
        }

        
        if((movementPressed && attackingPressed) && !isAttacking)
        {
            animator.SetBool(isAttackingHash,true);
        }
        if((!movementPressed && !attackingPressed) && isAttacking)
        {
            animator.SetBool(isAttackingHash,false);
        }
    }


    void OnEnable()
    {
        input.PlayerMain.Enable();
    }

    void OnDisable()
    {
        input.PlayerMain.Disable();
    }
}
