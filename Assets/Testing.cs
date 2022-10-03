using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UDEV.HelloWorld1;


public class Testing : MonoBehaviour 
{ 
	int a;
	int b;
	int c;
	int d;
	int e;
	int f;
	int S;
	int t;

	private void Start () 
	{ 
		a = 4;
		b = 7;
		c = 6;
		d = 5;
		e = 8;
		f = 2;
		S = 20;
		t = 5;
		
		// tinh trung binh cong cua bon so bat ky
		Debug.Log((float)(d + e + f + a) / 4);

		// tinh chu vi tam giac co canh lan luot la a b c
		Debug.Log(a + b + c);

		// tinh dien tich tam giac vuong co canh lan luot la a b c
		Debug.Log((float)0.5 * (a + b));

		// tinh chu vi hinh tron trong do a la duong kinh
		Debug.Log((float) 4 * 3.14);

		// tinh dien tich hinh tron trong do a la duong kinh
		Debug.Log((float) 4 * 4 * 3.14);

		// tinh van toc trong do quang duong S = 20km, thoi gian t = 5m
		Debug.Log((float)(S * 1000) / (t * 60) * 3.6);

		





	}
}
	


