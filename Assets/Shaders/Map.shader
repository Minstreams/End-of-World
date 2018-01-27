// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:34015,y:32228,varname:node_9361,prsc:2|custl-8143-OUT;n:type:ShaderForge.SFN_Tex2d,id:851,x:32353,y:33180,ptovrint:False,ptlb:Mask,ptin:_Mask,varname:node_851,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:9970f4f9364abd34faae863160e35243,ntxv:0,isnm:False|UVIN-3591-OUT;n:type:ShaderForge.SFN_ScreenPos,id:170,x:32598,y:32288,varname:node_170,prsc:2,sctp:2;n:type:ShaderForge.SFN_Append,id:5687,x:33597,y:31851,varname:node_5687,prsc:2|A-9374-OUT,B-170-V;n:type:ShaderForge.SFN_ScreenParameters,id:3324,x:32351,y:31851,varname:node_3324,prsc:2;n:type:ShaderForge.SFN_Divide,id:7961,x:32595,y:31851,varname:node_7961,prsc:2|A-3324-PXW,B-3324-PXH;n:type:ShaderForge.SFN_Subtract,id:2221,x:32808,y:32015,varname:node_2221,prsc:2|A-170-U,B-539-OUT;n:type:ShaderForge.SFN_Vector1,id:539,x:32598,y:32190,varname:node_539,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Divide,id:3054,x:32595,y:32005,varname:node_3054,prsc:2|A-5944-OUT,B-5738-OUT;n:type:ShaderForge.SFN_Vector1,id:5944,x:32351,y:32005,varname:node_5944,prsc:2,v1:1920;n:type:ShaderForge.SFN_Vector1,id:5738,x:32351,y:32083,varname:node_5738,prsc:2,v1:1080;n:type:ShaderForge.SFN_Divide,id:1003,x:32808,y:31851,varname:node_1003,prsc:2|A-7961-OUT,B-3054-OUT;n:type:ShaderForge.SFN_Multiply,id:8733,x:33010,y:31851,varname:node_8733,prsc:2|A-1003-OUT,B-2221-OUT;n:type:ShaderForge.SFN_Add,id:9580,x:33208,y:31851,varname:node_9580,prsc:2|A-8733-OUT,B-539-OUT;n:type:ShaderForge.SFN_Clamp01,id:9374,x:33399,y:31851,varname:node_9374,prsc:2|IN-9580-OUT;n:type:ShaderForge.SFN_Slider,id:3151,x:31958,y:32190,ptovrint:False,ptlb:chaos,ptin:_chaos,varname:node_3151,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4861523,max:1;n:type:ShaderForge.SFN_Set,id:7107,x:33827,y:31851,varname:ScreenUV,prsc:2|IN-5687-OUT;n:type:ShaderForge.SFN_Get,id:3591,x:32110,y:33180,varname:node_3591,prsc:2|IN-7107-OUT;n:type:ShaderForge.SFN_Tex2d,id:7124,x:32110,y:32986,ptovrint:False,ptlb:Noise,ptin:_Noise,varname:node_7124,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-8456-UVOUT;n:type:ShaderForge.SFN_Color,id:9053,x:32354,y:33389,ptovrint:False,ptlb:Red,ptin:_Red,varname:node_9053,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8676471,c2:0.1977725,c3:0.1977725,c4:1;n:type:ShaderForge.SFN_Multiply,id:8998,x:32598,y:33399,varname:node_8998,prsc:2|A-851-A,B-9053-RGB;n:type:ShaderForge.SFN_Color,id:8636,x:32354,y:33588,ptovrint:False,ptlb:Orange,ptin:_Orange,varname:node_8636,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8823529,c2:0.5530366,c3:0.1362457,c4:1;n:type:ShaderForge.SFN_Multiply,id:6533,x:32598,y:33588,varname:node_6533,prsc:2|A-851-A,B-8636-RGB;n:type:ShaderForge.SFN_Color,id:1556,x:32354,y:33781,ptovrint:False,ptlb:Yellow,ptin:_Yellow,varname:node_1556,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8420982,c2:0.9632353,c3:0.08499137,c4:1;n:type:ShaderForge.SFN_Color,id:3490,x:32354,y:33984,ptovrint:False,ptlb:Green,ptin:_Green,varname:node_3490,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.0724481,c2:0.9852941,c3:0.2676082,c4:1;n:type:ShaderForge.SFN_Multiply,id:8777,x:32598,y:33781,varname:node_8777,prsc:2|A-851-A,B-1556-RGB;n:type:ShaderForge.SFN_Multiply,id:3499,x:32598,y:33984,varname:node_3499,prsc:2|A-851-A,B-3490-RGB;n:type:ShaderForge.SFN_Set,id:641,x:32330,y:32190,varname:chaos,prsc:2|IN-3151-OUT;n:type:ShaderForge.SFN_Slider,id:9326,x:32598,y:32489,ptovrint:False,ptlb:redGate,ptin:_redGate,varname:node_9326,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.757571,max:1;n:type:ShaderForge.SFN_Slider,id:9654,x:32598,y:32831,ptovrint:False,ptlb:orangeGate,ptin:_orangeGate,varname:_redGate_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5383624,max:1;n:type:ShaderForge.SFN_Slider,id:4956,x:32598,y:33145,ptovrint:False,ptlb:yellowGate,ptin:_yellowGate,varname:_orangeGate_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.2019523,max:1;n:type:ShaderForge.SFN_Slider,id:2108,x:32188,y:32686,ptovrint:False,ptlb:line,ptin:_line,varname:node_2108,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.0502432,max:0.3;n:type:ShaderForge.SFN_Get,id:5158,x:31928,y:32785,varname:node_5158,prsc:2|IN-641-OUT;n:type:ShaderForge.SFN_RemapRange,id:4867,x:32110,y:32785,varname:node_4867,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-5158-OUT;n:type:ShaderForge.SFN_Get,id:4578,x:31659,y:32988,varname:node_4578,prsc:2|IN-7107-OUT;n:type:ShaderForge.SFN_Add,id:7469,x:32345,y:32785,varname:node_7469,prsc:2|A-4867-OUT,B-7124-R;n:type:ShaderForge.SFN_Vector1,id:8808,x:32598,y:33288,varname:node_8808,prsc:2,v1:1;n:type:ShaderForge.SFN_Step,id:2585,x:32986,y:33147,varname:node_2585,prsc:2|A-4956-OUT,B-7469-OUT;n:type:ShaderForge.SFN_Subtract,id:6238,x:32755,y:33288,varname:node_6238,prsc:2|A-4956-OUT,B-2108-OUT;n:type:ShaderForge.SFN_Step,id:2271,x:32986,y:33288,varname:node_2271,prsc:2|A-6238-OUT,B-7469-OUT;n:type:ShaderForge.SFN_Subtract,id:446,x:33184,y:33288,varname:node_446,prsc:2|A-8808-OUT,B-2271-OUT;n:type:ShaderForge.SFN_Subtract,id:4745,x:32755,y:32949,varname:node_4745,prsc:2|A-9654-OUT,B-2108-OUT;n:type:ShaderForge.SFN_Step,id:4466,x:32986,y:32959,varname:node_4466,prsc:2|A-4745-OUT,B-7469-OUT;n:type:ShaderForge.SFN_Subtract,id:9976,x:33179,y:32959,varname:node_9976,prsc:2|A-2585-OUT,B-4466-OUT;n:type:ShaderForge.SFN_Subtract,id:9071,x:32755,y:32632,varname:node_9071,prsc:2|A-9326-OUT,B-2108-OUT;n:type:ShaderForge.SFN_Step,id:6540,x:32986,y:32810,varname:node_6540,prsc:2|A-9654-OUT,B-7469-OUT;n:type:ShaderForge.SFN_Step,id:4923,x:32986,y:32632,varname:node_4923,prsc:2|A-9071-OUT,B-7469-OUT;n:type:ShaderForge.SFN_Step,id:4889,x:33183,y:32469,varname:node_4889,prsc:2|A-9326-OUT,B-7469-OUT;n:type:ShaderForge.SFN_Subtract,id:9840,x:33183,y:32632,varname:node_9840,prsc:2|A-6540-OUT,B-4923-OUT;n:type:ShaderForge.SFN_Multiply,id:3433,x:33417,y:33288,varname:node_3433,prsc:2|A-446-OUT,B-3499-OUT;n:type:ShaderForge.SFN_Multiply,id:2649,x:33408,y:32959,varname:node_2649,prsc:2|A-9976-OUT,B-8777-OUT;n:type:ShaderForge.SFN_Multiply,id:3720,x:33408,y:32632,varname:node_3720,prsc:2|A-9840-OUT,B-6533-OUT;n:type:ShaderForge.SFN_Multiply,id:5882,x:33408,y:32469,varname:node_5882,prsc:2|A-4889-OUT,B-8998-OUT;n:type:ShaderForge.SFN_Add,id:8143,x:33739,y:32469,varname:node_8143,prsc:2|A-5882-OUT,B-3720-OUT,C-2649-OUT,D-3433-OUT;n:type:ShaderForge.SFN_Panner,id:8456,x:31884,y:32988,varname:node_8456,prsc:2,spu:1,spv:1|UVIN-4578-OUT,DIST-7295-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7295,x:31680,y:33117,ptovrint:False,ptlb:NoiseDis,ptin:_NoiseDis,varname:node_7295,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.7;proporder:851-9053-8636-1556-3490-7124-3151-9326-9654-4956-2108-7295;pass:END;sub:END;*/

Shader "Shader Forge/Map" {
    Properties {
        _Mask ("Mask", 2D) = "white" {}
        _Red ("Red", Color) = (0.8676471,0.1977725,0.1977725,1)
        _Orange ("Orange", Color) = (0.8823529,0.5530366,0.1362457,1)
        _Yellow ("Yellow", Color) = (0.8420982,0.9632353,0.08499137,1)
        _Green ("Green", Color) = (0.0724481,0.9852941,0.2676082,1)
        _Noise ("Noise", 2D) = "white" {}
        _chaos ("chaos", Range(0, 1)) = 0.4861523
        _redGate ("redGate", Range(0, 1)) = 0.757571
        _orangeGate ("orangeGate", Range(0, 1)) = 0.5383624
        _yellowGate ("yellowGate", Range(0, 1)) = 0.2019523
        _line ("line", Range(0, 0.3)) = 0.0502432
        _NoiseDis ("NoiseDis", Float ) = 0.7
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
            uniform sampler2D _Mask; uniform float4 _Mask_ST;
            uniform float _chaos;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform float4 _Red;
            uniform float4 _Orange;
            uniform float4 _Yellow;
            uniform float4 _Green;
            uniform float _redGate;
            uniform float _orangeGate;
            uniform float _yellowGate;
            uniform float _line;
            uniform float _NoiseDis;
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 projPos : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
////// Lighting:
                float chaos = _chaos;
                float node_539 = 0.5;
                float2 ScreenUV = float2(saturate(((((_ScreenParams.r/_ScreenParams.g)/(1920.0/1080.0))*(sceneUVs.r-node_539))+node_539)),sceneUVs.g);
                float2 node_8456 = (ScreenUV+_NoiseDis*float2(1,1));
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(node_8456, _Noise));
                float node_7469 = ((chaos*2.0+-1.0)+_Noise_var.r);
                float2 node_3591 = ScreenUV;
                float4 _Mask_var = tex2D(_Mask,TRANSFORM_TEX(node_3591, _Mask));
                float3 finalColor = ((step(_redGate,node_7469)*(_Mask_var.a*_Red.rgb))+((step(_orangeGate,node_7469)-step((_redGate-_line),node_7469))*(_Mask_var.a*_Orange.rgb))+((step(_yellowGate,node_7469)-step((_orangeGate-_line),node_7469))*(_Mask_var.a*_Yellow.rgb))+((1.0-step((_yellowGate-_line),node_7469))*(_Mask_var.a*_Green.rgb)));
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
