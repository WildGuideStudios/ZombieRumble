using UnityEngine;
using System.Collections;

public class OptionPathFollow : MonoBehaviour
{

    public float speed = 3f;
    public Transform pathParentOpt;
    public Transform target;
    Transform targetPoint;
    int index;

    void OnDrawGizmos()
    {
        Vector3 from;
        Vector3 to;
        for (int a = 0; a < pathParentOpt.childCount; a++)
        {
            from = pathParentOpt.GetChild(a).position;
            to = pathParentOpt.GetChild((a + 1) % pathParentOpt.childCount).position;
            Gizmos.color = new Color(1, 0, 0);
            Gizmos.DrawLine(from, to);
        }
    }
    void Start()
    {
        index = 0;
        targetPoint = pathParentOpt.GetChild(index);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
        {
            index++;
            index %= pathParentOpt.childCount;
            targetPoint = pathParentOpt.GetChild(index);
        }
    }
}
