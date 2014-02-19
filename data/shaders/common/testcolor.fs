uniform sampler2D tex;
uniform vec4 mult_color;
void main()
{
	vec4 color = texture2D(tex,gl_TexCoord[0].st);
	gl_FragColor = vec4(color[0] * mult_color[0], color[1] * mult_color[1], color[2] * mult_color[2], color[3] * mult_color[3]);
}
