using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _04_Time : MonoBehaviour
{
    private const float radius = 8f, maxAngle = 360f, halfRadius = radius / 2;
    private const string s_color = "_Color";

    [SerializeField]
    private Transform cubePrefab;
    [SerializeField, Range(12, 360)]
    private int count = 12;
    [SerializeField]
    private float rotSpeed = 30f;

    private int _count;
    private Transform parent, line;
    private List<Transform> cubeList;
    private List<Color> colorList;
    private float offset, angle;



    private void Awake()
    {
        parent = GameObject.Find("Plane").transform;
        cubeList = new List<Transform>();
        colorList = new List<Color> {
            Color.cyan,Color.clear,Color.grey,Color.gray,Color.magenta,
            Color.red,Color.yellow,Color.black,Color.white,
            Color.green,Color.blue,};
        line = GameObject.Find("Line").transform;
    }

    private void Update()
    {
        SpawnCube();
        UpdateItem();
    }

    private void SpawnCube()
    {
        if (_count != count)
        {
            _count = count;
            offset = 0;
            angle = maxAngle / _count;

            foreach (Transform item in parent)
            {
                cubeList.Remove(item);
                Destroy(item.gameObject);
            }

            for (int i = 0; i < _count; i++)
            {
                var newTs = Instantiate(cubePrefab, radius * new Vector3(Mathf.Cos(angle * i * Mathf.Deg2Rad), Mathf.Sin(angle * i * Mathf.Deg2Rad), 0)
                    , Quaternion.Euler(0, 0, Random.Range(0, 360)), parent);
                cubeList.Add(newTs);
            }
        }
    }

    private void UpdateItem()
    {
        offset = (offset + rotSpeed * Time.deltaTime) % maxAngle;
        int i = 0;
        foreach (var cube in cubeList)
        {
            cube.GetComponent<MeshRenderer>().material.SetColor(s_color, colorList[Random.Range(0, colorList.Count)]);
            var eulerAngle = cube.eulerAngles;
            eulerAngle.z += Time.deltaTime * rotSpeed;
            cube.eulerAngles = eulerAngle;
            cube.position = radius * new Vector3(Mathf.Cos((offset + angle * i) * Mathf.Deg2Rad), Mathf.Sin((offset + angle * i) * Mathf.Deg2Rad), 0);
            i++;
        }

        line.position=halfRadius * new Vector3(Mathf.Cos(offset  * Mathf.Deg2Rad), Mathf.Sin(offset  * Mathf.Deg2Rad), 0);
        line.eulerAngles = new Vector3(0, offset, 0);

    }
}
