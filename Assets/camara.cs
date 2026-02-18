using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform target;

    void Update()
    {

    }
    private void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, -1);
    }
}
