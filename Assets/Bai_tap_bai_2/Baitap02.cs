using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UDEV.HelloWorld1;
using System.Linq;
using System;


public class Baitap02 : MonoBehaviour
{
    int a = 3;
	int b = 7;
	int c;
	
	
	private void Start () 
	{ 
	   switch (c)
	   { 
	    case 1:
		   Debug.Log(a + b+ c);
		   break;
		case 2:
		   Debug.Log((a + b) * c);
		   break;
		case 4:
		   Debug.Log((a * b) - (a + b));
		   break;
		case 0:
		   Debug.Log((a * b * c) + c - a);
		   break;
		default: Debug.Log("khong co phep tinh thoa man");
		   break;

	   } 
       
	   
	}
 }
