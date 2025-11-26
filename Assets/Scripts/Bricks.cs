using UnityEngine;

public class Bricks : MonoBehaviour
{
    public GameObject BrickParticle;

    private void OnCollisionEnter(Collision collision)
    {
        if (BrickParticle != null)
        {
            Instantiate(BrickParticle, transform.position, Quaternion.identity);
        }

        GameManager.Instance.DestroyBrick();
        Destroy(gameObject);
    }
}
