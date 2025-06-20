Shader "Unlit With Shadows" {
	Properties {
		_Color ("Main Color", Color) = (1,1,1,1)
		_MainTex ("Base (RGB)", 2D) = "white" {}
	}
	SubShader {
		Tags {"Queue" = "Transparent" "RenderType" = "Transparent"}
 		Blend SrcAlpha OneMinusSrcAlpha
 
		Pass {
			Tags {"LightMode" = "ForwardBase"}
			CGPROGRAM
				#pragma vertex vert
				#pragma fragment frag
				#pragma multi_compile_fwdbase
				#pragma fragmentoption ARB_fog_exp2
				#pragma fragmentoption ARB_precision_hint_fastest
				
				#include "UnityCG.cginc"
				#include "AutoLight.cginc"
				
				struct v2f
				{
					float4	pos			: SV_POSITION;
					float2	uv			: TEXCOORD0;
					LIGHTING_COORDS(1,2)
				};
				float4 _MainTex_ST;
				v2f vert (appdata_tan v)
				{
					v2f o;
					o.pos = UnityObjectToClipPos( v.vertex);
					o.uv = TRANSFORM_TEX (v.texcoord, _MainTex).xy;
					TRANSFER_VERTEX_TO_FRAGMENT(o);
					return o;
				}
 
				sampler2D _MainTex;
				fixed4 _Color;

				fixed4 frag(v2f i) : SV_Target
				{
					fixed atten = LIGHT_ATTENUATION(i);	// Light attenuation + shadows.
					//fixed atten = SHADOW_ATTENUATION(i); // Shadows ONLY.
					fixed4 tempColor= tex2D(_MainTex, i.uv) * atten*_Color.rgba;
					return  fixed4(tempColor.rgb,_Color.a);
				}
			ENDCG
		}

	}
	FallBack "VertexLit"
}