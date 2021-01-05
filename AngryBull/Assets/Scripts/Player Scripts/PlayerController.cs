using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Animator animator;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;

    public int maxHealth = 100;
    public int currentHealth;

    public float playerSpeed = 6.0f;
    [SerializeField]

    private Transform cameraMain;
    private Transform child;

    private Player playerInput;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public int doDamage = 25;
    public float attackRate = 2f;
    float nextAttackTime = 0;
    public static bool isdead = true;

    public event System.Action<int, int> OnHealthChanged;

    private void Awake(){
        playerInput =  new Player();
        controller = GetComponent<CharacterController>();
    }

    private void OnEnable(){
        playerInput.Enable();
    }

    private void OnDisable(){
        playerInput.Disable();
    }


    private void Start()
    {
        animator = GetComponent<Animator>();
        cameraMain = Camera.main.transform;
        child = transform.GetChild(0).transform;
        currentHealth = maxHealth;
        Debug.Log(currentHealth);
    }

    void Update()
    {
        if(Time.time >= nextAttackTime)
        {
            if(playerInput.PlayerMain.Attack.triggered)
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }

        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        Vector2 movementInput = playerInput.PlayerMain.Move.ReadValue<Vector2>();
        Vector3 move = (cameraMain.forward * movementInput.y + cameraMain.right * movementInput.x);
        move.y = 0f;
        controller.Move(move * Time.deltaTime * playerSpeed);
        if(movementInput.x != 0 || movementInput.y != 0)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking",false);
        }


        Vector3 currentPosition = transform.position;
        Vector3 newPosition = new Vector3(movementInput.x, 0, movementInput.y);
        Vector3 positionToLookAt = currentPosition + newPosition;

        transform.LookAt(positionToLookAt);



       

        void Attack()
        {
            animator.SetTrigger("attack");

            Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange,enemyLayers);
        
            foreach(Collider enemy in hitEnemies)
            {
                enemy.GetComponent<EnemyController>().TakeDamage(doDamage);
                Debug.Log("we hit"+ enemy.name);
            }
        }
    }

    public void TakeDamage(int damage)
    {

        currentHealth -=damage;
        Debug.Log("Player takes "+damage);
        Debug.Log("Player HP: " + currentHealth);
        if(OnHealthChanged != null)
        {
            OnHealthChanged(maxHealth,currentHealth);
        }
        CheckHealth();

    }

    public virtual void CheckHealth()
    {
        if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            if(isdead == true)
            {
                Die();
            }
            
        }
    }

    public GameObject show;
    public GameObject hide1;
    public GameObject hide2;
    public void Die()
    {
        if(isdead == true )
        {
            animator.SetBool("isDead", true);
            Debug.Log("Player died! ");
        }
        isdead = false;

        show.SetActive(true);  
        hide1.SetActive(false);
        hide2.SetActive(false);
        Time.timeScale = 0;
        GetComponent<PlayerController>().enabled = false;   

    }

    void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }


}
