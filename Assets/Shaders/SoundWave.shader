// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:34294,y:32434,varname:node_9361,prsc:2|custl-9424-OUT;n:type:ShaderForge.SFN_Tex2d,id:8645,x:33927,y:32676,ptovrint:False,ptlb:Wave,ptin:_Wave,varname:node_8645,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:d1ad9772e135720488c5c88d33ec6194,ntxv:0,isnm:False|UVIN-4881-OUT;n:type:ShaderForge.SFN_TexCoord,id:9639,x:31639,y:32899,varname:node_9639,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Parallax,id:7156,x:32964,y:32676,varname:node_7156,prsc:2|UVIN-6177-OUT,HEI-7751-OUT;n:type:ShaderForge.SFN_Multiply,id:7751,x:32769,y:32838,varname:node_7751,prsc:2|A-2998-OUT,B-8275-OUT,C-382-OUT;n:type:ShaderForge.SFN_Slider,id:8275,x:31681,y:33199,ptovrint:False,ptlb:depth,ptin:_depth,varname:node_8275,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.043257,max:3;n:type:ShaderForge.SFN_Panner,id:8974,x:33139,y:32676,varname:node_8974,prsc:2,spu:0.7,spv:0|UVIN-7156-UVOUT;n:type:ShaderForge.SFN_Frac,id:500,x:33542,y:32676,varname:node_500,prsc:2|IN-7439-R;n:type:ShaderForge.SFN_Noise,id:2998,x:31831,y:32899,varname:node_2998,prsc:2|XY-9639-UVOUT;n:type:ShaderForge.SFN_Vector1,id:6584,x:31831,y:32604,varname:node_6584,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Distance,id:3128,x:31831,y:32674,varname:node_3128,prsc:2|A-6584-OUT,B-9639-U;n:type:ShaderForge.SFN_Subtract,id:405,x:32206,y:32837,varname:node_405,prsc:2|A-9639-V,B-6584-OUT;n:type:ShaderForge.SFN_Add,id:3511,x:32565,y:32673,varname:node_3511,prsc:2|A-6584-OUT,B-3732-OUT;n:type:ShaderForge.SFN_Multiply,id:3732,x:32396,y:32673,varname:node_3732,prsc:2|A-3269-OUT,B-405-OUT;n:type:ShaderForge.SFN_Append,id:6177,x:32769,y:32673,varname:node_6177,prsc:2|A-9639-U,B-3511-OUT;n:type:ShaderForge.SFN_Add,id:6516,x:32031,y:32674,varname:node_6516,prsc:2|A-3128-OUT,B-1593-OUT;n:type:ShaderForge.SFN_Power,id:3269,x:32206,y:32674,varname:node_3269,prsc:2|VAL-6516-OUT,EXP-6004-OUT;n:type:ShaderForge.SFN_Exp,id:6004,x:32031,y:32850,varname:node_6004,prsc:2,et:0|IN-9940-OUT;n:type:ShaderForge.SFN_Vector1,id:1593,x:31831,y:32812,varname:node_1593,prsc:2,v1:0.88;n:type:ShaderForge.SFN_ComponentMask,id:7439,x:33354,y:32676,varname:node_7439,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-8974-UVOUT;n:type:ShaderForge.SFN_Clamp01,id:3684,x:33542,y:32875,varname:node_3684,prsc:2|IN-7439-G;n:type:ShaderForge.SFN_Append,id:4881,x:33742,y:32676,varname:node_4881,prsc:2|A-500-OUT,B-3684-OUT;n:type:ShaderForge.SFN_Slider,id:9940,x:31675,y:33093,ptovrint:False,ptlb:roll,ptin:_roll,varname:node_9940,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:5;n:type:ShaderForge.SFN_Color,id:6710,x:33927,y:32887,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_6710,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.221237,c2:0.8775653,c3:0.9705882,c4:1;n:type:ShaderForge.SFN_Multiply,id:9424,x:34118,y:32676,varname:node_9424,prsc:2|A-8645-RGB,B-6710-RGB;n:type:ShaderForge.SFN_Add,id:382,x:32601,y:32880,varname:node_382,prsc:2|A-3128-OUT,B-4511-OUT;n:type:ShaderForge.SFN_Vector1,id:4511,x:32311,y:33024,varname:node_4511,prsc:2,v1:0.2;proporder:8645-8275-9940-6710;pass:END;sub:END;*/

Shader "Shader Forge/SoundWave" {
    Properties {
        _Wave ("Wave", 2D) = "white" {}
        _depth ("depth", Range(0, 3)) = 1.043257
        _roll ("roll", Range(0, 5)) = 0
        _Color ("Color", Color) = (0.221237,0.8775653,0.9705882,1)
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
            uniform sampler2D _Wave; uniform float4 _Wave_ST;
            uniform float _depth;
            uniform float _roll;
            uniform float4 _Color;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
////// Lighting:
                float4 node_7744 = _Time;
                float node_6584 = 0.5;
                float node_3128 = distance(node_6584,i.uv0.r);
                float2 node_2998_skew = i.uv0 + 0.2127+i.uv0.x*0.3713*i.uv0.y;
                float2 node_2998_rnd = 4.789*sin(489.123*(node_2998_skew));
                float node_2998 = frac(node_2998_rnd.x*node_2998_rnd.y*(1+node_2998_skew.x));
                float2 node_7439 = ((0.05*((node_2998*_depth*(node_3128+0.2)) - 0.5)*mul(tangentTransform, viewDirection).xy + float2(i.uv0.r,(node_6584+(pow((node_3128+0.88),exp(_roll))*(i.uv0.g-node_6584))))).rg+node_7744.g*float2(0.7,0)).rg;
                float2 node_4881 = float2(frac(node_7439.r),saturate(node_7439.g));
                float4 _Wave_var = tex2D(_Wave,TRANSFORM_TEX(node_4881, _Wave));
                float3 finalColor = (_Wave_var.rgb*_Color.rgb);
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
