using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
   public float speed = 10f;

   private Transform target;
   private int wavepointIndex = 0;

   void Start ()
   {
        tartet = Waypoints.points[0];
   }

   void Update ()
   {
    Vector3 dir = target.precision - transform.position;
    transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
   }
}
