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
    [SerializeField] private GameObject Prefab5;
    [SerializeField] private GameObject ColorChanger;
    public float space = 7;
    float y = -4f;
    float yChanger = -7.5f;

    private void Start()
    {
        for (int i = 0; i <= 20; i++)
        {
            Instantiate(ColorChanger, new Vector2(0, yChanger += space), Quaternion.identity);

            RandNum = Random.Range(0, 6);
            switch (RandNum)
            {
                case 0:
                    Instantiate(Prefab0, new Vector2(0, y += space), Quaternion.identity);
                    Prefab0.SetActive(true);
                    break;
                case 1:
                    Instantiate(Prefab1, new Vector2(0, y += space), Quaternion.identity);
                    Prefab1.SetActive(true);
                    break;
                case 2:
                    Instantiate(Prefab2, new Vector2(0, y += space), Quaternion.identity);
                    Prefab2.SetActive(true);
                    break;
                case 3:
                    Instantiate(Prefab3, new Vector2(0, y += space), Quaternion.identity);
                    Prefab3.SetActive(true);
                    break;
                case 4:
                    Instantiate(Prefab4, new Vector2(0, y += space), Quaternion.identity);
                    Prefab4.SetActive(true);
                    break;
                case 5:
                    Instantiate(Prefab5, new Vector2(-1.32f, y += space), Quaternion.identity);
                    Prefab5.SetActive(true);
                    break;
            }
        }
    }

}
