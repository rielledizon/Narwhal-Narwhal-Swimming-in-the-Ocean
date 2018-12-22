Shader "Unlit/SingleColor"
{
	Properties
	{
		_MainTex ("Albedo Texture", 2D) = "white" {}
		_Color ("Main Color", Color) = (1, 1, 1, 1) //rgba colors
	}
	SubShader
	{
		//Sets render queue; no need for transparency in this shader
		Tags { "Queue" = "Opaque"}
		LOD 100

		//Disables z-buffering and allows alpha blending
		Zwrite Off
		Blend SrcAlpha OneMinusSrcAlpha

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata //calls vertices and uv coords
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f //calls texture specific verticies and uv coords
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			//variables
			sampler2D _MainTex;
			float4 _MainTex_ST;
			float4 _Color;

			v2f vert (appdata v)//shader vertex function
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target //shader fragment function
			{
				// sample the texture
				fixed4 col = _Color;
				return col;
			}
			ENDCG
		}
	}
}
