uniform sampler2D tex;
void main()
{
	vec4 color = texture2D(tex,gl_TexCoord[0].st);
	float cid = (color[0] + color[1] + color[2]) / 3;
	gl_FragColor = vec4(cid, cid, cid, color[3]);
}
