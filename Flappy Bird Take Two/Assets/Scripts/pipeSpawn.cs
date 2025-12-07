using UnityEngine;

public class pipeSpawn : MonoBehaviour
{
    public GameObject pipeToclone;

    public float startTime = 2;
    float countdown;
    public float lifeTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        countdown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        
        if(countdown <= 0)
        {
            float SpawnHeight = Random.Range(-3f,3f);

            GameObject clone = Instantiate(pipeToclone);
            pipeMove MoveScript = clone.GetComponent<pipeMove>();
            clone.transform.position = new Vector2(13, SpawnHeight);
            
            Rigidbody2D cloneRB = clone.GetComponent<Rigidbody2D>();
            cloneRB.simulated = true;
            MoveScript.enabled = true;
            Destroy(clone, lifeTime);
            countdown = startTime;
        }
    }
}
