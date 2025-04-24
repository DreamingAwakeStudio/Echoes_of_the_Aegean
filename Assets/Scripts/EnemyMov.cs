using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMov :MonoBehaviour
{
    [Header("IA follow navigation")]
    public float minDistanceToFollow = 1.2f;
    public float minDistanceToPoint = 1.0f;
    public float timeToStartNavegation = 3.0f;
    public float speedToNavegation = 1.0f;
    public float speedToFollow = 3.0f;

    [Header("IA Vision")]
    public Transform eyes;
    public float visionRadius = 10f;
    public float visionAngle = 45f;
    public float timeToNavegation;
    public GameObject[] navegationPoints;
    //- - - Variáveis privadas - - -
    private float timerNav; private int pointIndex; private bool canSeePlayer = false;
    private Animator anim; private Transform target; private NavMeshAgent navMesh;
    void Start()
    {
        anim = GetComponent<Animator>();
        navMesh = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        navegationPoints = GameObject.FindGameObjectsWithTag("NavegationPoints"); //Isso possivelmente vai tirar no futuro
        pointIndex = GetRandomPointIndex(); //Isso possivelmente vai tirar no futuro
    }
    void Update()
    {
        
    }

    private int GetRandomPointIndex()
    {
        var i = UnityEngine.Random.Range(0, (navegationPoints.Length - 1));
        if (pointIndex == 1)
        {
            return GetRandomPointIndex;
        }
        var monsters = GameObject.FindGameObjectWithTag("Enemy");
        foreach (GameObject monster in monsters)
        {
            if (monster.GetComponent<EnemyMov>().pointIndex == i)
            {
                return GetRandomPointIndex();
            }
        }
        return i;

    }
}
