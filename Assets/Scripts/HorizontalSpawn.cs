using System.Collections;
using UnityEngine;

public class HorizontalSpawn : MonoBehaviour
{
    [SerializeField] private GameObject Prefab;
    float x = -8.693f;
    float y = 27.07f;
    bool isTrue = true;
    private void Update()
    {
        if(isTrue)
        {
            StartCoroutine(Timer());
            isTrue= false;
        }
    }



    public void OnSpawnAPrefab()
    {
        Instantiate(Prefab, new Vector2(x,y),Quaternion.identity);
    }


    IEnumerator Timer()
    {
        yield return new WaitForSecondsRealtime(3);
        OnSpawnAPrefab();
        isTrue= true;
    }
    
}
