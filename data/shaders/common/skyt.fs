uniform sampler2D tex;
void main()
{
	float xer = gl_TexCoord[0].st.x;
	if (xer < 0.25)
	{
		vec4 color = 10 * texture2D(tex,gl_TexCoord[0].st);
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.001, 0.001));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.001, -0.001));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.001, 0.001));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(-0.001, -0.001));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.002, 0.002));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.002, -0.002));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.002, 0.002));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(-0.002, -0.002));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.003, 0.003));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.003, -0.003));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.003, 0.003));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(-0.003, -0.003));
		gl_FragColor = color / 130;
	}
	else if (xer < 0.5)
	{
		vec4 color = 10 * texture2D(tex,gl_TexCoord[0].st);
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.001, 0.001));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.001, -0.001));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.001, 0.001));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(-0.001, -0.001));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.002, 0.002));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.002, -0.002));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.002, 0.002));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(-0.002, -0.002));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.003, 0.003));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.003, -0.003));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(0.003, 0.003));
		color += 10 * texture2D(tex,gl_TexCoord[0].st + vec2(-0.003, -0.003));
		color /= 130;
		color.x = round(color.x * 4.0) / 4.0;
		color.y = round(color.y * 4.0) / 4.0;
		color.z = round(color.z * 4.0) / 4.0;
		gl_FragColor = color;
	}
	else if (xer < 0.75)
	{
		vec4 color = texture2D(tex,gl_TexCoord[0].st);
		color.x = round(color.x * 4.0) / 4.0;
		color.y = round(color.y * 4.0) / 4.0;
		color.z = round(color.z * 4.0) / 4.0;
		gl_FragColor = color;
	}
	else
	{
		vec4 color = texture2D(tex,gl_TexCoord[0].st);
		gl_FragColor = color;
	}
}