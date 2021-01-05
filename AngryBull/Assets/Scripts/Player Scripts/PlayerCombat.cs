using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    Animator animator;
    private Player playerInput;
    



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerInput =  new Player();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInput.PlayerMain.Attack.triggered)
        {
            Attack();
        }
    }

    void Attack()
    {
        animator.SetTrigger("attack");
    }

    private void OnEnable(){
        playerInput.Enable();
    }

    private void OnDisable(){
        playerInput.Disable();
    }
}
