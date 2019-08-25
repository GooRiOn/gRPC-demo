PROTOC=tools/macosx_x64/protoc
PLUGIN=tools/macosx_x64/grpc_csharp_plugin
PROTO=Messages.proto
SERVER=src/GrpcServer
CLIENT=src/GrpcClient

$PROTOC --csharp_out $SERVER --grpc_out $SERVER --plugin=protoc-gen-grpc=$PLUGIN $SERVER/$PROTO
$PROTOC --csharp_out $CLIENT --grpc_out $CLIENT --plugin=protoc-gen-grpc=$PLUGIN $CLIENT/$PROTO