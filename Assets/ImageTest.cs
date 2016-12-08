using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FreeImageAPI;
using UnityEngine.UI;

public class ImageTest : MonoBehaviour
{
    public string texturePath;
    public Image image;
    // Use this for initialization
    void Start ()
	{
        FIBITMAP fib = FreeImage.LoadEx(texturePath.Substring(0, texturePath.LastIndexOf(".")) + ".png");
        Texture2D t2d = new Texture2D((int)FreeImage.GetWidth(fib), (int)FreeImage.GetHeight(fib));
        
        Debug.Log(t2d.mipmapCount);
        FreeImage.SaveEx(fib,"ssad");
        //t2d.SetPixels(FreeImage.);
        Sprite sp=Sprite.Create(t2d,new Rect(0,0, (int)FreeImage.GetWidth(fib), (int)FreeImage.GetHeight(fib)), new Vector2(0.5f, 0.5f));
	    image.sprite = sp;
        


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
