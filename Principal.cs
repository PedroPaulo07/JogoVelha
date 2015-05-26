using UnityEngine;
using System.Collections;

public class Principal : MonoBehaviour {
public GameObject X1,X2,X3,X4,X5,X6,X7,X8,X9;
	public GameObject O1,O2,O3,O4,O5,O6,O7,O8,O9;
	public GameObject player1,player2;
	public int numero;
	public bool contador1,contador2,contador3,contador4,contador5,contador6,contador7,contador8,contador9;
	public bool contador21,contador22,contador23,contador24,contador25,contador26,contador27,contador28,contador29;
	public AudioClip clik;
	

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	

	}
	public void onCommand(string str)

	{
		if (str.Equals ("Player1")) {
			numero=1;
			GetComponent<AudioSource>().PlayOneShot(clik);
		}
		if (str.Equals ("Player2")) {
			numero = 2;
			GetComponent<AudioSource>().PlayOneShot(clik);
		}
		if (str.Equals ("restart")) {
			Application.LoadLevel("Scene");
		}
		if ((str.Equals ("Quadro1")) && numero == 1) {
			X1.SetActive(true);
			contador1=true;	
			contador21=false;	
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 
		if ((str.Equals ("Quadro1")) && numero == 2) {
			O1.SetActive(true);	
			contador1=false;
			contador21=true;
			GetComponent<AudioSource>().PlayOneShot(clik);
		}
		if ((str.Equals ("Quadro2")) && numero == 1) {
			X2.SetActive(true);
			contador2=true;	
			contador22=false;
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 
		if ((str.Equals ("Quadro2")) && numero == 2) {
			O2.SetActive(true);
			contador2=false;
			contador22=true;
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 
		if ((str.Equals ("Quadro3")) && numero == 1) {
			X3.SetActive(true);
			contador3=true;
			contador23=false;
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 
		if ((str.Equals ("Quadro3")) && numero == 2) {
			O3.SetActive(true);
			contador3=false;
			contador23=true;
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 
		if ((str.Equals ("Quadro4")) && numero == 1) {
			X4.SetActive(true);
			contador4=true;
			contador24=false;
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 
		if ((str.Equals ("Quadro4")) && numero == 2) {
			O4.SetActive(true);
			contador4=false;
			contador24=true;
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 
		if ((str.Equals ("Quadro5")) && numero == 1) {
			X5.SetActive(true);
			contador5=true;
			contador25=false;
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 
		if ((str.Equals ("Quadro5")) && numero == 2) {
			O5.SetActive(true);
			contador5=false;
			contador25=true;
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 
		if ((str.Equals ("Quadro6")) && numero == 1) {
			X6.SetActive(true);
			contador6=true;
			contador26=false;
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 
		if ((str.Equals ("Quadro6")) && numero == 2) {
			O6.SetActive(true);
			contador6=false;
			contador26=true;
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 
		if ((str.Equals ("Quadro7")) && numero == 1) {
			X7.SetActive(true);
			contador7=true;
			contador27=true;
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 
		if ((str.Equals ("Quadro7")) && numero == 2) {
			O7.SetActive(true);
			contador7=false;
			contador27=true;
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 
		if ((str.Equals ("Quadro8")) && numero == 1) {
			X8.SetActive(true);
			contador8=true;
			contador28=false;
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 
		if ((str.Equals ("Quadro8")) && numero == 2) {
			O8.SetActive(true);
			contador8=false;
			contador28=true;
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 
		if ((str.Equals ("Quadro9")) && numero == 1) {
			X9.SetActive(true);
			contador9=true;
			contador29=false;
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 
		if ((str.Equals ("Quadro9")) && numero == 2) {
			O9.SetActive(true);
			contador9=false;
			contador29=true;
			GetComponent<AudioSource>().PlayOneShot(clik);
		} 

	}
}