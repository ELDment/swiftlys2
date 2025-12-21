namespace SwiftlyS2.Shared.EntitySystem;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class EntityInputHandlerAttribute( string designerName, string inputName ) : Attribute
{
    public string DesignerName { get; set; } = designerName;
    public string InputName { get; set; } = inputName;
}