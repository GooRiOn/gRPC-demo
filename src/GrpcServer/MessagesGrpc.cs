// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: src/GrpcServer/Messages.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Services.Messages {
  public static partial class GrpcMessageService
  {
    static readonly string __ServiceName = "Services.Messages.GrpcMessageService";

    static readonly grpc::Marshaller<global::Services.Messages.GetMessageRequest> __Marshaller_Services_Messages_GetMessageRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.Messages.GetMessageRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.Messages.GetMessageResponse> __Marshaller_Services_Messages_GetMessageResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.Messages.GetMessageResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Services.Messages.GetMessageRequest, global::Services.Messages.GetMessageResponse> __Method_GetMessage = new grpc::Method<global::Services.Messages.GetMessageRequest, global::Services.Messages.GetMessageResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetMessage",
        __Marshaller_Services_Messages_GetMessageRequest,
        __Marshaller_Services_Messages_GetMessageResponse);

    static readonly grpc::Method<global::Services.Messages.GetMessageRequest, global::Services.Messages.GetMessageResponse> __Method_GetMessagesStream = new grpc::Method<global::Services.Messages.GetMessageRequest, global::Services.Messages.GetMessageResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetMessagesStream",
        __Marshaller_Services_Messages_GetMessageRequest,
        __Marshaller_Services_Messages_GetMessageResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Services.Messages.MessagesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GrpcMessageService</summary>
    [grpc::BindServiceMethod(typeof(GrpcMessageService), "BindService")]
    public abstract partial class GrpcMessageServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Services.Messages.GetMessageResponse> GetMessage(global::Services.Messages.GetMessageRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetMessagesStream(global::Services.Messages.GetMessageRequest request, grpc::IServerStreamWriter<global::Services.Messages.GetMessageResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GrpcMessageService</summary>
    public partial class GrpcMessageServiceClient : grpc::ClientBase<GrpcMessageServiceClient>
    {
      /// <summary>Creates a new client for GrpcMessageService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GrpcMessageServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GrpcMessageService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GrpcMessageServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GrpcMessageServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GrpcMessageServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Services.Messages.GetMessageResponse GetMessage(global::Services.Messages.GetMessageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetMessage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Services.Messages.GetMessageResponse GetMessage(global::Services.Messages.GetMessageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetMessage, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Services.Messages.GetMessageResponse> GetMessageAsync(global::Services.Messages.GetMessageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetMessageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Services.Messages.GetMessageResponse> GetMessageAsync(global::Services.Messages.GetMessageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetMessage, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::Services.Messages.GetMessageResponse> GetMessagesStream(global::Services.Messages.GetMessageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetMessagesStream(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Services.Messages.GetMessageResponse> GetMessagesStream(global::Services.Messages.GetMessageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetMessagesStream, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GrpcMessageServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GrpcMessageServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GrpcMessageServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetMessage, serviceImpl.GetMessage)
          .AddMethod(__Method_GetMessagesStream, serviceImpl.GetMessagesStream).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GrpcMessageServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetMessage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Services.Messages.GetMessageRequest, global::Services.Messages.GetMessageResponse>(serviceImpl.GetMessage));
      serviceBinder.AddMethod(__Method_GetMessagesStream, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Services.Messages.GetMessageRequest, global::Services.Messages.GetMessageResponse>(serviceImpl.GetMessagesStream));
    }

  }
}
#endregion
