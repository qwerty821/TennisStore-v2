export function urlTransform(text) {
	return text.trim().split(/\s+/).join("-");
}
