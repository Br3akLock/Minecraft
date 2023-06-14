using UnityEngine;

public class AddCubeOnClick : MonoBehaviour
{
    public GameObject cubePrefab;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1)) // Botão direito do mouse
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Cube")) // Verifica se o objeto atingido é um cubo
                {
                    Vector3 spawnPosition = hit.point + hit.normal; // Posição de spawn do novo cubo
                    GameObject newCube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
                    // Atribua qualquer lógica adicional ao novo cubo aqui, se necessário
                }
            }
        }
    }
}
