Shader "Graph/Point Surface"
{
	Properties
	{
		_Smoothness("Smoothness",Range(0,1)) = 0.5
	}
		SubShader
	{
		CGPROGRAM
		#pragma surface surf Standard fullforwardshadows
		#pragma target 3.0

        float _Smoothness;

		struct Input
		{
			float3 worldPos;
		};
		
		void surf(Input input, inout SurfaceOutputStandard surface)
		{
			surface.Smoothness = _Smoothness;
			surface.Albedo.rg = input.worldPos.xy * 0.5 + 0.5;
		}
		ENDCG
	}
		FallBack "Diffuse"
}
