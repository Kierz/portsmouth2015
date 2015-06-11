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
	   SubShader {
            Material {
	           Emission [_Color]
            }
            Pass {
	           SetTexture [_MainTex] {
	                  Combine Texture * Primary, Texture * Primary
                }
            }
        } 
    }
}
