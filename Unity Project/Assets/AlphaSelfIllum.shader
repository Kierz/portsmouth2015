//Last edited by James Davidson
//11.06.2015
//Comments : Hackingly thrown together by looking at transparent and self illum shaders built into unity
//			 and a few glimpes of there documentation.


Shader "Self Illumination with ALPHA" {
	Properties {
		//Colour defines a colour we can pick, RGB and A. 
		//Main tex is the texture we're using!
		_Color ("Color Tint", Color) = (1,1,1,1)
		_MainTex ("SelfIllum Color (RGB) Alpha (A)", 2D) = "white"
	}
	Category {
		//We want lighting enabled
	   Lighting On
	   	//Backface culling enabled
	   Cull Back
	   //Don't write to the Z-Buffer
	   ZWrite Off
	   //Blend to make whatever material this is applied too transparent!
	   Blend SrcAlpha OneMinusSrcAlpha
	   Tags {Queue=Transparent}
	   //Shader program starts here.
	   SubShader {

            Material {
				//Tag the emission as colour, i.e. changeable colour.
	           Emission [_Color]
            }
			//When the renderer does a pass on this shader / materials using it....
            Pass {
				//Set the texture as the main texture which we pass in.
	           SetTexture [_MainTex] {
	                  Combine Texture * Primary
                }
            }
        } 
	}
}