using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootscript : MonoBehaviour
{
	public Transform gun;
	public GameObject bullet;
	public float bulletspeed;
	public Transform shootpoint;
	public float firerate;
	float readyreadyfornextshot;
	Vector2 direction;
	public Animator gunanim;
	public bool isFacingRight;
	// Use this for initialization
	void Start()
	{
		 isFacingRight = true;
}

	// Update is called once per frame
	void Update()
	{
		Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		direction = mousepos - (Vector2)gun.position;
		FaceMouse();

		if (Input.GetMouseButton(0))
		{
			if (Time.time > readyreadyfornextshot)
			{
				readyreadyfornextshot = Time.time + 1 / firerate;
				shoot();
			}

		}
	
	}
	void FaceMouse()
	{
		gun.transform.right = direction;
	}
	void shoot()
	{
		GameObject bullets = Instantiate(bullet, shootpoint.position, shootpoint.rotation);
		if (!isFacingRight)
		{
			isFacingRight = false;
			bullets.GetComponent<Rigidbody2D>().AddForce(bullets.transform.right * -bulletspeed);
		}
		else
        {
			bullets.GetComponent<Rigidbody2D>().AddForce(bullets.transform.right * bulletspeed);
		}
		gunanim.SetTrigger("shoot");
		Destroy(bullets, 1);

	}



}
