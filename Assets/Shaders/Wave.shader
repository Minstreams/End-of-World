// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:2,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:False,rfrpn:Refraction,coma:15,ufog:False,aust:False,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33314,y:32674,varname:node_9361,prsc:2|custl-753-OUT,alpha-6293-OUT,refract-4394-OUT;n:type:ShaderForge.SFN_TexCoord,id:7267,x:31105,y:33123,varname:node_7267,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Distance,id:8545,x:31288,y:33123,varname:node_8545,prsc:2|A-7267-UVOUT,B-2067-OUT;n:type:ShaderForge.SFN_Vector1,id:2067,x:31105,y:33293,varname:node_2067,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Step,id:1466,x:31476,y:33123,varname:node_1466,prsc:2|A-8545-OUT,B-2067-OUT;n:type:ShaderForge.SFN_Slider,id:2904,x:31509,y:33316,ptovrint:False,ptlb:Depth,ptin:_Depth,varname:node_2904,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.03589744,max:10;n:type:ShaderForge.SFN_Multiply,id:8009,x:31666,y:33123,varname:node_8009,prsc:2|A-1466-OUT,B-8545-OUT;n:type:ShaderForge.SFN_RemapRange,id:8292,x:31848,y:33123,varname:node_8292,prsc:2,frmn:0,frmx:0.5,tomn:0,tomx:1|IN-8009-OUT;n:type:ShaderForge.SFN_Power,id:2438,x:32025,y:33123,varname:node_2438,prsc:2|VAL-8292-OUT,EXP-8903-OUT;n:type:ShaderForge.SFN_Exp,id:8903,x:31848,y:33317,varname:node_8903,prsc:2,et:0|IN-2904-OUT;n:type:ShaderForge.SFN_Slider,id:5106,x:32236,y:32810,ptovrint:False,ptlb:emission,ptin:_emission,varname:node_5106,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:856,x:32621,y:32898,varname:node_856,prsc:2|A-5106-OUT,B-191-OUT;n:type:ShaderForge.SFN_Color,id:2235,x:32393,y:32613,ptovrint:False,ptlb:EdgeColor,ptin:_EdgeColor,varname:node_2235,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_VertexColor,id:533,x:32025,y:32949,varname:node_533,prsc:2;n:type:ShaderForge.SFN_Multiply,id:191,x:32303,y:32950,varname:node_191,prsc:2|A-3346-OUT,B-2438-OUT,C-533-R;n:type:ShaderForge.SFN_Vector1,id:3346,x:32026,y:32849,varname:node_3346,prsc:2,v1:1;n:type:ShaderForge.SFN_Append,id:4394,x:32813,y:33108,varname:node_4394,prsc:2|A-2420-OUT,B-2420-OUT;n:type:ShaderForge.SFN_Multiply,id:2420,x:32621,y:33108,varname:node_2420,prsc:2|A-191-OUT,B-4709-OUT;n:type:ShaderForge.SFN_Slider,id:4709,x:32185,y:33297,ptovrint:False,ptlb:Height,ptin:_Height,varname:node_4709,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-0.2,cur:0,max:0.2;n:type:ShaderForge.SFN_Multiply,id:753,x:32818,y:32791,varname:node_753,prsc:2|A-2235-RGB,B-856-OUT;n:type:ShaderForge.SFN_Clamp01,id:6293,x:32864,y:32965,varname:node_6293,prsc:2|IN-856-OUT;proporder:2904-5106-2235-4709;pass:END;sub:END;*/

Shader "Shader Forge/Wave" {
    Properties {
        _Depth ("Depth", Range(0, 10)) = 0.03589744
        _emission ("emission", Range(0, 1)) = 0
        _EdgeColor ("EdgeColor", Color) = (0.5,0.5,0.5,1)
        _Height ("Height", Range(-0.2, 0.2)) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ "Refraction" }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D Refraction;
            uniform float _Depth;
            uniform float _emission;
            uniform float4 _EdgeColor;
            uniform float _Height;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
                float4 projPos : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                float4x4 bbmv = UNITY_MATRIX_MV;
                bbmv._m00 = -1.0/length(unity_WorldToObject[0].xyz);
                bbmv._m10 = 0.0f;
                bbmv._m20 = 0.0f;
                bbmv._m01 = 0.0f;
                bbmv._m11 = -1.0/length(unity_WorldToObject[1].xyz);
                bbmv._m21 = 0.0f;
                bbmv._m02 = 0.0f;
                bbmv._m12 = 0.0f;
                bbmv._m22 = -1.0/length(unity_WorldToObject[2].xyz);
                o.pos = mul( UNITY_MATRIX_P, mul( bbmv, v.vertex ));
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float node_2067 = 0.5;
                float node_8545 = distance(i.uv0,node_2067);
                float node_191 = (1.0*pow(((step(node_8545,node_2067)*node_8545)*2.0+0.0),exp(_Depth))*i.vertexColor.r);
                float node_2420 = (node_191*_Height);
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + float2(node_2420,node_2420);
                float4 sceneColor = tex2D(Refraction, sceneUVs);
////// Lighting:
                float node_856 = (_emission*node_191);
                float3 finalColor = (_EdgeColor.rgb*node_856);
                return fixed4(lerp(sceneColor.rgb, finalColor,saturate(node_856)),1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
