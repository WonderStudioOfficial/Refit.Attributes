namespace Wonder.Refit.Attributes;

public class WonderDeleteAttribute(string path) : WonderHttpMethodAttribute(path, HttpMethod.Delete);
public class WonderGetAttribute(string path) : WonderHttpMethodAttribute(path, HttpMethod.Get);
public class WonderPatchAttribute(string path) : WonderHttpMethodAttribute(path, HttpMethod.Patch);
public class WonderPostAttribute(string path) : WonderHttpMethodAttribute(path, HttpMethod.Post);
public class WonderPutAttribute(string path) : WonderHttpMethodAttribute(path, HttpMethod.Put);