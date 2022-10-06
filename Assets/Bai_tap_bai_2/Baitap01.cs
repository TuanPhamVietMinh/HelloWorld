using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UDEV.HelloWorld1;
using System.Linq;
using System;


public class Baitap01 : MonoBehaviour
{
    int a = 8;
	int b = 2;
	
	
	private void Start () 
	{ 
	   if((a + b )> 10)
	   { 
		   Debug.Log(a - b);
	   }
	   else if(( a + b )> 7)
	   {
	     Debug.Log(a * b);
	   }else
	   {
	     Debug.Log(a / b);
	   }
	}
 }
