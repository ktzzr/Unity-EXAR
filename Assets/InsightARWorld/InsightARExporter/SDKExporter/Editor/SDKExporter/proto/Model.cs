// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: model.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ProtoWorld {

  /// <summary>Holder for reflection information generated from model.proto</summary>
  public static partial class ModelReflection {

    #region Descriptor
    /// <summary>File descriptor for model.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ModelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgttb2RlbC5wcm90bxILcHJvdG9fd29ybGQaCm1hdGgucHJvdG8aC2VudW1z",
            "LnByb3RvIkIKBE1lc2gSKQoEdHlwZRhlIAEoDjIbLnByb3RvX3dvcmxkLlBS",
            "SU1JVElWRV9UWVBFEg8KBmluZGljZRjJASADKAUiOwoEQm9uZRIMCgRuYW1l",
            "GGUgASgJEiUKCGJpbmRwb3NlGMkBIAEoCzISLnByb3RvX21hdGgubWF0cml4",
            "ItQECgVNb2RlbBIPCgd2ZXJzaW9uGAEgASgJEgwKBG5hbWUYZSABKAkSDAoE",
            "ZmlsZRhmIAEoCRIlCghwb3NpdGlvbhjJASADKAsyEi5wcm90b19tYXRoLmZs",
            "b2F0MxIjCgZub3JtYWwYygEgAygLMhIucHJvdG9fbWF0aC5mbG9hdDMSJAoH",
            "dGFuZ2VudBjLASADKAsyEi5wcm90b19tYXRoLmZsb2F0NBIiCgVjb2xvchjM",
            "ASADKAsyEi5wcm90b19tYXRoLmZsb2F0NBImCgl0ZXhjb29yZDAYzQEgAygL",
            "MhIucHJvdG9fbWF0aC5mbG9hdDISJgoJdGV4Y29vcmQxGM4BIAMoCzISLnBy",
            "b3RvX21hdGguZmxvYXQyEiYKCXRleGNvb3JkMhjPASADKAsyEi5wcm90b19t",
            "YXRoLmZsb2F0MhImCgl0ZXhjb29yZDMY0AEgAygLMhIucHJvdG9fbWF0aC5m",
            "bG9hdDISJAoHYndlaWdodBjRASADKAsyEi5wcm90b19tYXRoLmZsb2F0NBIi",
            "CgdiaW5kaWNlGNIBIAMoCzIQLnByb3RvX21hdGguaW50NBIhCgVib25lcxit",
            "AiADKAsyES5wcm90b193b3JsZC5Cb25lEiIKBm1lc2hlcxiRAyADKAsyES5w",
            "cm90b193b3JsZC5NZXNoEioKDWJvdW5kc19jZW50ZXIY9QMgASgLMhIucHJv",
            "dG9fbWF0aC5mbG9hdDMSKwoOYm91bmRzX2V4dGVudHMY9gMgASgLMhIucHJv",
            "dG9fbWF0aC5mbG9hdDNCAkgDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::ProtoMath.MathReflection.Descriptor, global::ProtoWorld.EnumsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ProtoWorld.Mesh), global::ProtoWorld.Mesh.Parser, new[]{ "Type", "Indice" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ProtoWorld.Bone), global::ProtoWorld.Bone.Parser, new[]{ "Name", "Bindpose" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ProtoWorld.Model), global::ProtoWorld.Model.Parser, new[]{ "Version", "Name", "File", "Position", "Normal", "Tangent", "Color", "Texcoord0", "Texcoord1", "Texcoord2", "Texcoord3", "Bweight", "Bindice", "Bones", "Meshes", "BoundsCenter", "BoundsExtents" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Mesh : pb::IMessage<Mesh> {
    private static readonly pb::MessageParser<Mesh> _parser = new pb::MessageParser<Mesh>(() => new Mesh());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Mesh> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtoWorld.ModelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Mesh() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Mesh(Mesh other) : this() {
      type_ = other.type_;
      indice_ = other.indice_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Mesh Clone() {
      return new Mesh(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 101;
    private global::ProtoWorld.PRIMITIVE_TYPE type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ProtoWorld.PRIMITIVE_TYPE Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "indice" field.</summary>
    public const int IndiceFieldNumber = 201;
    private static readonly pb::FieldCodec<int> _repeated_indice_codec
        = pb::FieldCodec.ForInt32(1610);
    private readonly pbc::RepeatedField<int> indice_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Indice {
      get { return indice_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Mesh);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Mesh other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if(!indice_.Equals(other.indice_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != 0) hash ^= Type.GetHashCode();
      hash ^= indice_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Type != 0) {
        output.WriteRawTag(168, 6);
        output.WriteEnum((int) Type);
      }
      indice_.WriteTo(output, _repeated_indice_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      size += indice_.CalculateSize(_repeated_indice_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Mesh other) {
      if (other == null) {
        return;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      indice_.Add(other.indice_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 808: {
            type_ = (global::ProtoWorld.PRIMITIVE_TYPE) input.ReadEnum();
            break;
          }
          case 1610:
          case 1608: {
            indice_.AddEntriesFrom(input, _repeated_indice_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Bone : pb::IMessage<Bone> {
    private static readonly pb::MessageParser<Bone> _parser = new pb::MessageParser<Bone>(() => new Bone());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Bone> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtoWorld.ModelReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Bone() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Bone(Bone other) : this() {
      name_ = other.name_;
      Bindpose = other.bindpose_ != null ? other.Bindpose.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Bone Clone() {
      return new Bone(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 101;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "bindpose" field.</summary>
    public const int BindposeFieldNumber = 201;
    private global::ProtoMath.matrix bindpose_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ProtoMath.matrix Bindpose {
      get { return bindpose_; }
      set {
        bindpose_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Bone);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Bone other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(Bindpose, other.Bindpose)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (bindpose_ != null) hash ^= Bindpose.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(170, 6);
        output.WriteString(Name);
      }
      if (bindpose_ != null) {
        output.WriteRawTag(202, 12);
        output.WriteMessage(Bindpose);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (bindpose_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Bindpose);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Bone other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.bindpose_ != null) {
        if (bindpose_ == null) {
          bindpose_ = new global::ProtoMath.matrix();
        }
        Bindpose.MergeFrom(other.Bindpose);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 810: {
            Name = input.ReadString();
            break;
          }
          case 1610: {
            if (bindpose_ == null) {
              bindpose_ = new global::ProtoMath.matrix();
            }
            input.ReadMessage(bindpose_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Model : pb::IMessage<Model> {
    private static readonly pb::MessageParser<Model> _parser = new pb::MessageParser<Model>(() => new Model());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Model> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtoWorld.ModelReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Model() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Model(Model other) : this() {
      version_ = other.version_;
      name_ = other.name_;
      file_ = other.file_;
      position_ = other.position_.Clone();
      normal_ = other.normal_.Clone();
      tangent_ = other.tangent_.Clone();
      color_ = other.color_.Clone();
      texcoord0_ = other.texcoord0_.Clone();
      texcoord1_ = other.texcoord1_.Clone();
      texcoord2_ = other.texcoord2_.Clone();
      texcoord3_ = other.texcoord3_.Clone();
      bweight_ = other.bweight_.Clone();
      bindice_ = other.bindice_.Clone();
      bones_ = other.bones_.Clone();
      meshes_ = other.meshes_.Clone();
      BoundsCenter = other.boundsCenter_ != null ? other.BoundsCenter.Clone() : null;
      BoundsExtents = other.boundsExtents_ != null ? other.BoundsExtents.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Model Clone() {
      return new Model(this);
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 1;
    private string version_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 101;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "file" field.</summary>
    public const int FileFieldNumber = 102;
    private string file_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string File {
      get { return file_; }
      set {
        file_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 201;
    private static readonly pb::FieldCodec<global::ProtoMath.float3> _repeated_position_codec
        = pb::FieldCodec.ForMessage(1610, global::ProtoMath.float3.Parser);
    private readonly pbc::RepeatedField<global::ProtoMath.float3> position_ = new pbc::RepeatedField<global::ProtoMath.float3>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ProtoMath.float3> Position {
      get { return position_; }
    }

    /// <summary>Field number for the "normal" field.</summary>
    public const int NormalFieldNumber = 202;
    private static readonly pb::FieldCodec<global::ProtoMath.float3> _repeated_normal_codec
        = pb::FieldCodec.ForMessage(1618, global::ProtoMath.float3.Parser);
    private readonly pbc::RepeatedField<global::ProtoMath.float3> normal_ = new pbc::RepeatedField<global::ProtoMath.float3>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ProtoMath.float3> Normal {
      get { return normal_; }
    }

    /// <summary>Field number for the "tangent" field.</summary>
    public const int TangentFieldNumber = 203;
    private static readonly pb::FieldCodec<global::ProtoMath.float4> _repeated_tangent_codec
        = pb::FieldCodec.ForMessage(1626, global::ProtoMath.float4.Parser);
    private readonly pbc::RepeatedField<global::ProtoMath.float4> tangent_ = new pbc::RepeatedField<global::ProtoMath.float4>();
    /// <summary>
    /// Unity calculates the other surface vector (binormal)
    /// by taking a cross product between the normal and the tangent,
    /// and multiplying the result by tangent.w.
    /// Therefore, w should always be 1 or -1.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ProtoMath.float4> Tangent {
      get { return tangent_; }
    }

    /// <summary>Field number for the "color" field.</summary>
    public const int ColorFieldNumber = 204;
    private static readonly pb::FieldCodec<global::ProtoMath.float4> _repeated_color_codec
        = pb::FieldCodec.ForMessage(1634, global::ProtoMath.float4.Parser);
    private readonly pbc::RepeatedField<global::ProtoMath.float4> color_ = new pbc::RepeatedField<global::ProtoMath.float4>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ProtoMath.float4> Color {
      get { return color_; }
    }

    /// <summary>Field number for the "texcoord0" field.</summary>
    public const int Texcoord0FieldNumber = 205;
    private static readonly pb::FieldCodec<global::ProtoMath.float2> _repeated_texcoord0_codec
        = pb::FieldCodec.ForMessage(1642, global::ProtoMath.float2.Parser);
    private readonly pbc::RepeatedField<global::ProtoMath.float2> texcoord0_ = new pbc::RepeatedField<global::ProtoMath.float2>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ProtoMath.float2> Texcoord0 {
      get { return texcoord0_; }
    }

    /// <summary>Field number for the "texcoord1" field.</summary>
    public const int Texcoord1FieldNumber = 206;
    private static readonly pb::FieldCodec<global::ProtoMath.float2> _repeated_texcoord1_codec
        = pb::FieldCodec.ForMessage(1650, global::ProtoMath.float2.Parser);
    private readonly pbc::RepeatedField<global::ProtoMath.float2> texcoord1_ = new pbc::RepeatedField<global::ProtoMath.float2>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ProtoMath.float2> Texcoord1 {
      get { return texcoord1_; }
    }

    /// <summary>Field number for the "texcoord2" field.</summary>
    public const int Texcoord2FieldNumber = 207;
    private static readonly pb::FieldCodec<global::ProtoMath.float2> _repeated_texcoord2_codec
        = pb::FieldCodec.ForMessage(1658, global::ProtoMath.float2.Parser);
    private readonly pbc::RepeatedField<global::ProtoMath.float2> texcoord2_ = new pbc::RepeatedField<global::ProtoMath.float2>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ProtoMath.float2> Texcoord2 {
      get { return texcoord2_; }
    }

    /// <summary>Field number for the "texcoord3" field.</summary>
    public const int Texcoord3FieldNumber = 208;
    private static readonly pb::FieldCodec<global::ProtoMath.float2> _repeated_texcoord3_codec
        = pb::FieldCodec.ForMessage(1666, global::ProtoMath.float2.Parser);
    private readonly pbc::RepeatedField<global::ProtoMath.float2> texcoord3_ = new pbc::RepeatedField<global::ProtoMath.float2>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ProtoMath.float2> Texcoord3 {
      get { return texcoord3_; }
    }

    /// <summary>Field number for the "bweight" field.</summary>
    public const int BweightFieldNumber = 209;
    private static readonly pb::FieldCodec<global::ProtoMath.float4> _repeated_bweight_codec
        = pb::FieldCodec.ForMessage(1674, global::ProtoMath.float4.Parser);
    private readonly pbc::RepeatedField<global::ProtoMath.float4> bweight_ = new pbc::RepeatedField<global::ProtoMath.float4>();
    /// <summary>
    /// weights of bones
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ProtoMath.float4> Bweight {
      get { return bweight_; }
    }

    /// <summary>Field number for the "bindice" field.</summary>
    public const int BindiceFieldNumber = 210;
    private static readonly pb::FieldCodec<global::ProtoMath.int4> _repeated_bindice_codec
        = pb::FieldCodec.ForMessage(1682, global::ProtoMath.int4.Parser);
    private readonly pbc::RepeatedField<global::ProtoMath.int4> bindice_ = new pbc::RepeatedField<global::ProtoMath.int4>();
    /// <summary>
    /// indice of bones
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ProtoMath.int4> Bindice {
      get { return bindice_; }
    }

    /// <summary>Field number for the "bones" field.</summary>
    public const int BonesFieldNumber = 301;
    private static readonly pb::FieldCodec<global::ProtoWorld.Bone> _repeated_bones_codec
        = pb::FieldCodec.ForMessage(2410, global::ProtoWorld.Bone.Parser);
    private readonly pbc::RepeatedField<global::ProtoWorld.Bone> bones_ = new pbc::RepeatedField<global::ProtoWorld.Bone>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ProtoWorld.Bone> Bones {
      get { return bones_; }
    }

    /// <summary>Field number for the "meshes" field.</summary>
    public const int MeshesFieldNumber = 401;
    private static readonly pb::FieldCodec<global::ProtoWorld.Mesh> _repeated_meshes_codec
        = pb::FieldCodec.ForMessage(3210, global::ProtoWorld.Mesh.Parser);
    private readonly pbc::RepeatedField<global::ProtoWorld.Mesh> meshes_ = new pbc::RepeatedField<global::ProtoWorld.Mesh>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ProtoWorld.Mesh> Meshes {
      get { return meshes_; }
    }

    /// <summary>Field number for the "bounds_center" field.</summary>
    public const int BoundsCenterFieldNumber = 501;
    private global::ProtoMath.float3 boundsCenter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ProtoMath.float3 BoundsCenter {
      get { return boundsCenter_; }
      set {
        boundsCenter_ = value;
      }
    }

    /// <summary>Field number for the "bounds_extents" field.</summary>
    public const int BoundsExtentsFieldNumber = 502;
    private global::ProtoMath.float3 boundsExtents_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ProtoMath.float3 BoundsExtents {
      get { return boundsExtents_; }
      set {
        boundsExtents_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Model);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Model other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Version != other.Version) return false;
      if (Name != other.Name) return false;
      if (File != other.File) return false;
      if(!position_.Equals(other.position_)) return false;
      if(!normal_.Equals(other.normal_)) return false;
      if(!tangent_.Equals(other.tangent_)) return false;
      if(!color_.Equals(other.color_)) return false;
      if(!texcoord0_.Equals(other.texcoord0_)) return false;
      if(!texcoord1_.Equals(other.texcoord1_)) return false;
      if(!texcoord2_.Equals(other.texcoord2_)) return false;
      if(!texcoord3_.Equals(other.texcoord3_)) return false;
      if(!bweight_.Equals(other.bweight_)) return false;
      if(!bindice_.Equals(other.bindice_)) return false;
      if(!bones_.Equals(other.bones_)) return false;
      if(!meshes_.Equals(other.meshes_)) return false;
      if (!object.Equals(BoundsCenter, other.BoundsCenter)) return false;
      if (!object.Equals(BoundsExtents, other.BoundsExtents)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (File.Length != 0) hash ^= File.GetHashCode();
      hash ^= position_.GetHashCode();
      hash ^= normal_.GetHashCode();
      hash ^= tangent_.GetHashCode();
      hash ^= color_.GetHashCode();
      hash ^= texcoord0_.GetHashCode();
      hash ^= texcoord1_.GetHashCode();
      hash ^= texcoord2_.GetHashCode();
      hash ^= texcoord3_.GetHashCode();
      hash ^= bweight_.GetHashCode();
      hash ^= bindice_.GetHashCode();
      hash ^= bones_.GetHashCode();
      hash ^= meshes_.GetHashCode();
      if (boundsCenter_ != null) hash ^= BoundsCenter.GetHashCode();
      if (boundsExtents_ != null) hash ^= BoundsExtents.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Version.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Version);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(170, 6);
        output.WriteString(Name);
      }
      if (File.Length != 0) {
        output.WriteRawTag(178, 6);
        output.WriteString(File);
      }
      position_.WriteTo(output, _repeated_position_codec);
      normal_.WriteTo(output, _repeated_normal_codec);
      tangent_.WriteTo(output, _repeated_tangent_codec);
      color_.WriteTo(output, _repeated_color_codec);
      texcoord0_.WriteTo(output, _repeated_texcoord0_codec);
      texcoord1_.WriteTo(output, _repeated_texcoord1_codec);
      texcoord2_.WriteTo(output, _repeated_texcoord2_codec);
      texcoord3_.WriteTo(output, _repeated_texcoord3_codec);
      bweight_.WriteTo(output, _repeated_bweight_codec);
      bindice_.WriteTo(output, _repeated_bindice_codec);
      bones_.WriteTo(output, _repeated_bones_codec);
      meshes_.WriteTo(output, _repeated_meshes_codec);
      if (boundsCenter_ != null) {
        output.WriteRawTag(170, 31);
        output.WriteMessage(BoundsCenter);
      }
      if (boundsExtents_ != null) {
        output.WriteRawTag(178, 31);
        output.WriteMessage(BoundsExtents);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (Name.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (File.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(File);
      }
      size += position_.CalculateSize(_repeated_position_codec);
      size += normal_.CalculateSize(_repeated_normal_codec);
      size += tangent_.CalculateSize(_repeated_tangent_codec);
      size += color_.CalculateSize(_repeated_color_codec);
      size += texcoord0_.CalculateSize(_repeated_texcoord0_codec);
      size += texcoord1_.CalculateSize(_repeated_texcoord1_codec);
      size += texcoord2_.CalculateSize(_repeated_texcoord2_codec);
      size += texcoord3_.CalculateSize(_repeated_texcoord3_codec);
      size += bweight_.CalculateSize(_repeated_bweight_codec);
      size += bindice_.CalculateSize(_repeated_bindice_codec);
      size += bones_.CalculateSize(_repeated_bones_codec);
      size += meshes_.CalculateSize(_repeated_meshes_codec);
      if (boundsCenter_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(BoundsCenter);
      }
      if (boundsExtents_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(BoundsExtents);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Model other) {
      if (other == null) {
        return;
      }
      if (other.Version.Length != 0) {
        Version = other.Version;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.File.Length != 0) {
        File = other.File;
      }
      position_.Add(other.position_);
      normal_.Add(other.normal_);
      tangent_.Add(other.tangent_);
      color_.Add(other.color_);
      texcoord0_.Add(other.texcoord0_);
      texcoord1_.Add(other.texcoord1_);
      texcoord2_.Add(other.texcoord2_);
      texcoord3_.Add(other.texcoord3_);
      bweight_.Add(other.bweight_);
      bindice_.Add(other.bindice_);
      bones_.Add(other.bones_);
      meshes_.Add(other.meshes_);
      if (other.boundsCenter_ != null) {
        if (boundsCenter_ == null) {
          boundsCenter_ = new global::ProtoMath.float3();
        }
        BoundsCenter.MergeFrom(other.BoundsCenter);
      }
      if (other.boundsExtents_ != null) {
        if (boundsExtents_ == null) {
          boundsExtents_ = new global::ProtoMath.float3();
        }
        BoundsExtents.MergeFrom(other.BoundsExtents);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Version = input.ReadString();
            break;
          }
          case 810: {
            Name = input.ReadString();
            break;
          }
          case 818: {
            File = input.ReadString();
            break;
          }
          case 1610: {
            position_.AddEntriesFrom(input, _repeated_position_codec);
            break;
          }
          case 1618: {
            normal_.AddEntriesFrom(input, _repeated_normal_codec);
            break;
          }
          case 1626: {
            tangent_.AddEntriesFrom(input, _repeated_tangent_codec);
            break;
          }
          case 1634: {
            color_.AddEntriesFrom(input, _repeated_color_codec);
            break;
          }
          case 1642: {
            texcoord0_.AddEntriesFrom(input, _repeated_texcoord0_codec);
            break;
          }
          case 1650: {
            texcoord1_.AddEntriesFrom(input, _repeated_texcoord1_codec);
            break;
          }
          case 1658: {
            texcoord2_.AddEntriesFrom(input, _repeated_texcoord2_codec);
            break;
          }
          case 1666: {
            texcoord3_.AddEntriesFrom(input, _repeated_texcoord3_codec);
            break;
          }
          case 1674: {
            bweight_.AddEntriesFrom(input, _repeated_bweight_codec);
            break;
          }
          case 1682: {
            bindice_.AddEntriesFrom(input, _repeated_bindice_codec);
            break;
          }
          case 2410: {
            bones_.AddEntriesFrom(input, _repeated_bones_codec);
            break;
          }
          case 3210: {
            meshes_.AddEntriesFrom(input, _repeated_meshes_codec);
            break;
          }
          case 4010: {
            if (boundsCenter_ == null) {
              boundsCenter_ = new global::ProtoMath.float3();
            }
            input.ReadMessage(boundsCenter_);
            break;
          }
          case 4018: {
            if (boundsExtents_ == null) {
              boundsExtents_ = new global::ProtoMath.float3();
            }
            input.ReadMessage(boundsExtents_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
