// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Product.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ProductsService {
  public static partial class ProductServices
  {
    static readonly string __ServiceName = "Products.ProductServices";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::ProductsService.Empty> __Marshaller_Products_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductsService.Empty.Parser));
    static readonly grpc::Marshaller<global::ProductsService.ProductList> __Marshaller_Products_ProductList = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductsService.ProductList.Parser));
    static readonly grpc::Marshaller<global::ProductsService.ProductId> __Marshaller_Products_ProductId = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductsService.ProductId.Parser));
    static readonly grpc::Marshaller<global::ProductsService.Product> __Marshaller_Products_Product = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductsService.Product.Parser));

    static readonly grpc::Method<global::ProductsService.Empty, global::ProductsService.ProductList> __Method_GetAll = new grpc::Method<global::ProductsService.Empty, global::ProductsService.ProductList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAll",
        __Marshaller_Products_Empty,
        __Marshaller_Products_ProductList);

    static readonly grpc::Method<global::ProductsService.ProductId, global::ProductsService.Product> __Method_Get = new grpc::Method<global::ProductsService.ProductId, global::ProductsService.Product>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_Products_ProductId,
        __Marshaller_Products_Product);

    static readonly grpc::Method<global::ProductsService.Product, global::ProductsService.Product> __Method_Insert = new grpc::Method<global::ProductsService.Product, global::ProductsService.Product>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Insert",
        __Marshaller_Products_Product,
        __Marshaller_Products_Product);

    static readonly grpc::Method<global::ProductsService.Product, global::ProductsService.Product> __Method_Update = new grpc::Method<global::ProductsService.Product, global::ProductsService.Product>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_Products_Product,
        __Marshaller_Products_Product);

    static readonly grpc::Method<global::ProductsService.ProductId, global::ProductsService.Empty> __Method_Delete = new grpc::Method<global::ProductsService.ProductId, global::ProductsService.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_Products_ProductId,
        __Marshaller_Products_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ProductsService.ProductReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductServices</summary>
    [grpc::BindServiceMethod(typeof(ProductServices), "BindService")]
    public abstract partial class ProductServicesBase
    {
      public virtual global::System.Threading.Tasks.Task<global::ProductsService.ProductList> GetAll(global::ProductsService.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ProductsService.Product> Get(global::ProductsService.ProductId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ProductsService.Product> Insert(global::ProductsService.Product request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ProductsService.Product> Update(global::ProductsService.Product request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ProductsService.Empty> Delete(global::ProductsService.ProductId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ProductServicesBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAll, serviceImpl.GetAll)
          .AddMethod(__Method_Get, serviceImpl.Get)
          .AddMethod(__Method_Insert, serviceImpl.Insert)
          .AddMethod(__Method_Update, serviceImpl.Update)
          .AddMethod(__Method_Delete, serviceImpl.Delete).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductServicesBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductsService.Empty, global::ProductsService.ProductList>(serviceImpl.GetAll));
      serviceBinder.AddMethod(__Method_Get, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductsService.ProductId, global::ProductsService.Product>(serviceImpl.Get));
      serviceBinder.AddMethod(__Method_Insert, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductsService.Product, global::ProductsService.Product>(serviceImpl.Insert));
      serviceBinder.AddMethod(__Method_Update, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductsService.Product, global::ProductsService.Product>(serviceImpl.Update));
      serviceBinder.AddMethod(__Method_Delete, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductsService.ProductId, global::ProductsService.Empty>(serviceImpl.Delete));
    }

  }
}
#endregion
