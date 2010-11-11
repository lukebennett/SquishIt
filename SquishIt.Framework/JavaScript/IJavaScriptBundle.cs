namespace SquishIt.Framework.JavaScript
{
    public interface IJavaScriptBundle
    {
        IJavaScriptBundleBuilder Add(string javaScriptPath);
        IJavaScriptBundleBuilder AddRemote(string localPath, string remotePath);
        IJavaScriptBundleBuilder AddEmbeddedResource(string localPath, string embeddedResourcePath);
        IJavaScriptBundleBuilder Watch(string filePath);
        string RenderNamed(string name);
        void ClearTestingCache();
        string RenderCached(string name);
    }
}