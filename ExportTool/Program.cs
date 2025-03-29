using Medium.iFX.Utilities;
using Medium.Manager.Feed.Interface.Messages;
using ProtoBuf.Grpc.Reflection;
using ProtoBuf.Meta;

namespace Medium.iFX.ExportTool;

public class Program
{
    public static void Main(string[] args)
    {

        RuntimeTypeModel.Default.Add(typeof(ResponseWrapper), true)
            // .AddSubType(100, typeof(ResponseWrapper<>))
            ;
        // RuntimeTypeModel.Default.Add(typeof(ResponseWrapper<>), true);
        // RuntimeTypeModel.Create()
        //     .AddSerializer(typeof(ResponseWrapper<>), Type.GetTypeFromHandle())
        //     .Add(typeof(ResponseWrapper<>), true);
        SchemaGenerator generator = new SchemaGenerator
        {
            ProtoSyntax = ProtoSyntax.Proto3
        };
        Type[] types = new Type[]
        {
            typeof(Manager.Feed.Interface.Messages.Problem.IFeedManager), typeof(Manager.Feed.Interface.Messages.Official.IFeedManager),
            typeof(Manager.Feed.Interface.Messages.Constraint.IFeedManager)
        };
        foreach (Type type in types)
        {
            string ucName = type.FullName.Split('.')[^2];
            string schema = generator.GetSchema(type);
            string path = Path.Join($"{ucName}.proto") ;
            using StreamWriter writer = new(path);
            writer.Write(schema);
        }
    }
}