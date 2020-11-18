
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;
    Animator animator; //link the animator


    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position ,transform.position);

        if(distance <= lookRadius)
        {
            agent.SetDestination(target.position);
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if(distance <= agent.stoppingDistance)
        {
            //attack the target
            //face the target
            FaceTarget();
            animator.SetBool("isRunning", false);

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
}
