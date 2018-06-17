using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{

    public GameObject Zombie1;
    public int MaxY, MaxX;
    public float time = 0;
    public float repeat = 0;
    public float force1;

    // Use this for initialization
    void Start()
    {
        Invoke("StartSpawning", 1f);


    }

    // Update is called once per frame
    void Update()
    {

        time = Time.time;
        repeat = repeat + 0.2f * time;
    }

    public void StartSpawning()
    {
        InvokeRepeating("SpawnZombieGroup", 1, repeat);
    }
    public void StopSpawning()
    {
        CancelInvoke("SpawnZombieGroup");
        StopCoroutine("SpawnZombie");
    }
    public void SpawnZombieGroup()
    {
        StartCoroutine("SpawnZombie");
    }
    IEnumerator SpawnZombie()
    {

        int RandY = Random.Range(0, MaxY);
        int RandX = Random.Range(-MaxX, MaxX);

        Vector3 pos = new Vector3(RandX, RandY, transform.position.z);
        GameObject z = Instantiate(Zombie1, pos, Quaternion.identity) as GameObject;
        force1 = force1 + 0.01f;
        z.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, force1), ForceMode.Impulse);
        yield return new WaitForSeconds(0.5f);


    }
}
