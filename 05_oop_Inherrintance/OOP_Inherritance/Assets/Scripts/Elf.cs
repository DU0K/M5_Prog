using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Elf : Enemy
{
    [SerializeField] private int speed = 5;
    MeshRenderer meshRenderer;
    private void Update()
    {
        Walk(speed);
    }

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        StartCoroutine(Disapear());
    }

    private IEnumerator Disapear()
    {
        yield return new WaitForSeconds(2f);
        meshRenderer.enabled = false;
        yield return new WaitForSeconds(0.5f);
        meshRenderer.enabled = true;
        StartCoroutine(Disapear());
    }
}
