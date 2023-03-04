using System.Collections;
using UnityEngine;

public class HorizontalSpawn : MonoBehaviour
{
    int RandNum;
    [SerializeField] private GameObject Prefab0;
    [SerializeField] private GameObject Prefab1;
    [SerializeField] private GameObject Prefab2;
    [SerializeField] private GameObject Prefab3;
    [SerializeField] private GameObject Prefab4;
    public float space = 7;
    float y = -4f;

    private void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            RandNum = Random.Range(0, 5);
            switch (RandNum)
            {
                case 0:
                    Instantiate(Prefab0, new Vector2(0, y += space), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(Prefab1, new Vector2(0, y += space), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(Prefab2, new Vector2(0, y += space), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(Prefab3, new Vector2(0, y += space), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(Prefab4, new Vector2(0, y += space), Quaternion.identity);
                    break;
            }
        }
    }




}
