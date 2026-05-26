using UnityEngine;

public class ObstacleCollisionGetVelocity : MonoBehaviour
{
    public PlayerController playerScript;
    private float hitVelocity;
    void Start()
    {
        
    }

    void OnTriggerEnter()
    {
        hitVelocity = playerScript.velocidade;
        Debug.Log(hitVelocity);

        var emitter = GetComponent<FMODUnity.StudioEventEmitter>();
        emitter.SetParameter("impact", hitVelocity);
    }
}
