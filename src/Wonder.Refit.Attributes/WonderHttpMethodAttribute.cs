using Refit;

namespace Wonder.Refit.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public abstract class WonderHttpMethodAttribute(string path, HttpMethod httpMethod) : HttpMethodAttribute(path)
{
    public override HttpMethod Method { get; } = httpMethod;

    public override string Path
    {
        get => $"/{base.Path.Trim(' ', '/')}";
        protected set => base.Path = value;
    }
}