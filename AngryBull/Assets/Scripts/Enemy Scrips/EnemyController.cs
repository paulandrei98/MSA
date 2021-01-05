
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;
    Animator animator;
    [SerializeField] int damage;
    public float attackCooldown = 2;
    float lastAttackTime = 0;

    PlayerManager playerManager;

    CharacterCombat combat;
    public int maxHealth = 100;
    public int score = 10;
    int currentHealth;
    public static bool isDead;
    public event System.Action<int, int> OnHealthChanged;


    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();    
        playerManager = PlayerManager.instance;
        currentHealth = maxHealth;

    }

    PlayerController playerHealth;

    void Awake()
    {
         playerHealth = FindObjectOfType<PlayerController>();
    }
    void Update()
    {
        float distance = Vector3.Distance(target.position ,transform.position);

        if(distance <= lookRadius)
        {
    

            isDead = PlayerController.isdead;
            if(isDead == false)
            {
              animator.SetBool("isRunning",false);  
            }
            else
            {
                agent.SetDestination(target.position);
                animator.SetBool("isRunning", true);
            }
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
        if(distance <= agent.stoppingDistance)
        {
            animator.SetBool("isAttacking",true);
            if(Time.time - lastAttackTime >= attackCooldown)
            {
                target.GetComponent<PlayerController>().CheckHealth();
                if(playerHealth.currentHealth <= 0)
                {
                    animator.SetBool("isAttacking",false);
                }
                else
                {
                    lastAttackTime = Time.time;
                    target.GetComponent<PlayerController>().TakeDamage(damage);
                    
                }

            }

            

        }
        else
        {
            
            animator.SetBool("isAttacking",false);
            
        }

    }


    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3 (direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation,lookRotation,Time.deltaTime * 5f);
    }


    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,lookRadius);

    }


    public void TakeDamage(int damage)
    {
        currentHealth -=damage;
        Debug.Log("Enemy takes "+damage);
        if(OnHealthChanged != null)
        {
            OnHealthChanged(maxHealth,currentHealth);
        }
        if(currentHealth <= 0)
        {
            StartCoroutine(Die());
            
        }
    
    }
    IEnumerator Die()
    {
        animator.SetTrigger("dead");
        Debug.Log("Enemy died! ");
        target.GetComponent<GameController>().AddScore(score);
        GetComponent<Collider>().enabled = false;
        this.enabled = false;

        yield return  new WaitForSeconds(1.5f);
        Destroy(gameObject);

    }
}