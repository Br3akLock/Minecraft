using UnityEngine;

public class CubeClickHandler : MonoBehaviour
{
    public GameObject cubePrefab; // Reference to the Cube prefab

    private float cubeSize; // Size of the cube

    private void Start()
    {
        cubeSize = transform.localScale.x; // Assuming the cube is a perfect cube (equal dimensions on all sides)
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Calculate the hit point in local coordinates
                Vector3 localHitPoint = transform.InverseTransformPoint(hit.point);

                // Calculate the normalized local hit point
                Vector3 normalizedLocalHitPoint = new Vector3(
                    Mathf.Round(localHitPoint.x),
                    Mathf.Round(localHitPoint.y),
                    Mathf.Round(localHitPoint.z)
                );

                // Calculate the adjacent position based on the clicked side
                Vector3 adjacentPosition = transform.TransformPoint(normalizedLocalHitPoint + hit.normal * (cubeSize / 2f));

                // Instantiate the Cube prefab at the adjacent position
                Instantiate(cubePrefab, adjacentPosition, Quaternion.identity);
            }
        }
    }
}