using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveLow : MonoBehaviour
{
    public float moveSpeed = 5f;
    public KeyCode pressJ;
    public Rigidbody2D rb;
    public GameObject player;
    public GameObject died;


    // Start is called before the first frame update
    void Start()
    {
        died.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Jump();

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

        transform.position += movement * Time.deltaTime * moveSpeed;

        //Flip Character
        Vector3 characterScale = transform.localScale;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -14f, 44f),
            Mathf.Clamp(transform.position.y, -1000f, 1000f), transform.position.z);

        if(rb.position.y > 70f || rb.position.y < -68f)
        {
            Camera.main.transform.parent = null;
            Destroy(player);
            died.SetActive(true);
            Instantiate(null, transform.position, transform.rotation);

        }
        //if (Input.GetAxis("Horizontal") < 0)
        //{
        //    characterScale.x = (float)(-1 * 0.186147);
        //}
        //if (Input.GetAxis("Horizontal") > 0)
        //{
        //    characterScale.x = (float)(1 * 0.186147);
        //}
        transform.localScale = characterScale;
    }

    public void Jump()
    {
        if(Input.GetKeyDown(pressJ))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
    }
    
}