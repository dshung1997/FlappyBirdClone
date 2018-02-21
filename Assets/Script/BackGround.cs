using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour {

    public float speed;
    // Use this for initialization
	void Start () { }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    public int numBGPanels = 6;
    //Sao cái này lại bằng 6?

    void OnTriggerEnter2D(Collider2D collider)
    /* Collider2D: được sử dụng để xác định hình dạng vật lý của một đối tượng
     * Có thể tham gia trong va chạm 2D và kích hoạt các sự kiện
     */
    {

        if (collider.name == "BGLooper") /*Nếu chạm trúng thằng có tên là BGLooper*/
        {
            float widthOfBGObject = ((BoxCollider2D)GetComponent<Collider2D>()).size.x - 0.01f;
            // biến widthOfBGObject này là để làm cđg?
            Vector3 pos = this.transform.position;

            pos.x += widthOfBGObject * numBGPanels;
            this.transform.position = pos;
        }
    }
}
