// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33595,y:32827,varname:node_9361,prsc:2|custl-7324-OUT;n:type:ShaderForge.SFN_Tex2d,id:851,x:33003,y:32952,ptovrint:False,ptlb:bigTex,ptin:_bigTex,varname:node_851,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:aa762ee7680f35f4fb9a9210fa94ce61,ntxv:0,isnm:False|UVIN-4128-OUT;n:type:ShaderForge.SFN_ScreenPos,id:170,x:31507,y:33175,varname:node_170,prsc:2,sctp:2;n:type:ShaderForge.SFN_Append,id:5687,x:32354,y:32953,varname:node_5687,prsc:2|A-9374-OUT,B-170-V;n:type:ShaderForge.SFN_ScreenParameters,id:3324,x:31502,y:32609,varname:node_3324,prsc:2;n:type:ShaderForge.SFN_Divide,id:7961,x:31735,y:32609,varname:node_7961,prsc:2|A-3324-PXW,B-3324-PXH;n:type:ShaderForge.SFN_Subtract,id:2221,x:31735,y:32983,varname:node_2221,prsc:2|A-170-U,B-539-OUT;n:type:ShaderForge.SFN_Vector1,id:539,x:31507,y:33077,varname:node_539,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Divide,id:3054,x:31735,y:32763,varname:node_3054,prsc:2|A-5944-OUT,B-5738-OUT;n:type:ShaderForge.SFN_Vector1,id:5944,x:31502,y:32763,varname:node_5944,prsc:2,v1:1920;n:type:ShaderForge.SFN_Vector1,id:5738,x:31502,y:32841,varname:node_5738,prsc:2,v1:1080;n:type:ShaderForge.SFN_Divide,id:1003,x:31948,y:32609,varname:node_1003,prsc:2|A-7961-OUT,B-3054-OUT;n:type:ShaderForge.SFN_Multiply,id:8733,x:32156,y:32609,varname:node_8733,prsc:2|A-1003-OUT,B-2221-OUT;n:type:ShaderForge.SFN_Add,id:9580,x:32156,y:32770,varname:node_9580,prsc:2|A-8733-OUT,B-539-OUT;n:type:ShaderForge.SFN_Clamp01,id:9374,x:32156,y:32953,varname:node_9374,prsc:2|IN-9580-OUT;n:type:ShaderForge.SFN_Tex2d,id:1780,x:33003,y:33176,ptovrint:False,ptlb:smallTex,ptin:_smallTex,varname:node_1780,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7bb3f19d6cdac4d4aabef6c3a13c88e3,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Slider,id:3151,x:32354,y:32638,ptovrint:False,ptlb:progress,ptin:_progress,varname:node_3151,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:7395,x:33221,y:32959,varname:node_7395,prsc:2|A-3151-OUT,B-851-RGB;n:type:ShaderForge.SFN_OneMinus,id:573,x:32354,y:32770,varname:node_573,prsc:2|IN-3151-OUT;n:type:ShaderForge.SFN_Multiply,id:1985,x:33221,y:33153,varname:node_1985,prsc:2|A-573-OUT,B-1780-RGB;n:type:ShaderForge.SFN_Add,id:7324,x:33409,y:32959,varname:node_7324,prsc:2|A-7395-OUT,B-1985-OUT;n:type:ShaderForge.SFN_TexCoord,id:380,x:32354,y:33106,varname:node_380,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:4495,x:32559,y:32953,varname:node_4495,prsc:2|A-3151-OUT,B-5687-OUT;n:type:ShaderForge.SFN_Multiply,id:5062,x:32559,y:33106,varname:node_5062,prsc:2|A-573-OUT,B-380-UVOUT;n:type:ShaderForge.SFN_Add,id:4128,x:32782,y:32953,varname:node_4128,prsc:2|A-4495-OUT,B-5062-OUT;proporder:851-1780-3151;pass:END;sub:END;*/

Shader "Shader Forge/Simple Tex" {
    Properties {
        _bigTex ("bigTex", 2D) = "white" {}
        _smallTex ("smallTex", 2D) = "white" {}
        _progress ("progress", Range(0, 1)) = 0
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _bigTex; uniform float4 _bigTex_ST;
            uniform sampler2D _smallTex; uniform float4 _smallTex_ST;
            uniform float _progress;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 projPos : TEXCOORD1;
                UNITY_FOG_COORDS(2)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
////// Lighting:
                float node_539 = 0.5;
                float node_573 = (1.0 - _progress);
                float2 node_4128 = ((_progress*float2(saturate(((((_ScreenParams.r/_ScreenParams.g)/(1920.0/1080.0))*(sceneUVs.r-node_539))+node_539)),sceneUVs.g))+(node_573*i.uv0));
                float4 _bigTex_var = tex2D(_bigTex,TRANSFORM_TEX(node_4128, _bigTex));
                float4 _smallTex_var = tex2D(_smallTex,TRANSFORM_TEX(i.uv0, _smallTex));
                float3 finalColor = ((_progress*_bigTex_var.rgb)+(node_573*_smallTex_var.rgb));
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
