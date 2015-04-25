using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public GameObject posicaoInicio;

	public void Morrer()
	{
		transform.position = posicaoInicio.transform.position;
		GetComponent<Rigidbody2D>().velocity.Set(0,0);
	}
	// Use this for initialization
	void Start () 
	{
		transform.position = posicaoInicio.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
