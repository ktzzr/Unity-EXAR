Shader "Mask"
{
	Properties
	{
		_color("Color",Color) = (0,0,0,0)
	}
    SubShader
    {
        Tags { "RenderType" = "Opaque" "Queue" = "Geometry-1000" }
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag


            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            fixed4 _color;

            v2f vert(appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                return _color;
            }
            ENDCG
        }
    }
	Fallback "Diffuse"
}