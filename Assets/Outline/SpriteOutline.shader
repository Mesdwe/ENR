Shader "Unlit/SpriteOutline"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _OutlineColor("Outline Color", Color) = (1,1,1,1)
        _OutlineWidth("out line width" , Range(0,1)) = 0.02
        _Outline("Out line",int) = 0
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" }

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
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            float4 _MainTex_TexelSize;
            fixed4 _OutlineColor;
            fixed _OutlineWidth;
            fixed _Outline;
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv);

                fixed leftPixel = tex2D(_MainTex, i.uv+float2(-_MainTex_TexelSize.x-_OutlineWidth,0)*_Outline).a;
                fixed upPixel = tex2D(_MainTex, i.uv+float2(0,_MainTex_TexelSize.y + _OutlineWidth)*_Outline).a;
                fixed rightPixel = tex2D(_MainTex, i.uv+float2(_MainTex_TexelSize.x+_OutlineWidth,0)*_Outline).a;
                fixed bottomPixel = tex2D(_MainTex, i.uv+float2(0,-_MainTex_TexelSize.y-_OutlineWidth)*_Outline).a;

                //inner line
                fixed outline = (1-leftPixel*upPixel*rightPixel*bottomPixel)*col.a;
                //outer outline
                //fixed outline = max(max(leftPixel,upPixel),max(rightPixel,bottomPixel)) -col.a;

                return lerp(col,_OutlineColor,outline);
            }
            ENDCG
        }
    }
}
