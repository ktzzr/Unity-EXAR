// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: texture.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ProtoWorld {

  /// <summary>Holder for reflection information generated from texture.proto</summary>
  public static partial class TextureReflection {

    #region Descriptor
    /// <summary>File descriptor for texture.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TextureReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg10ZXh0dXJlLnByb3RvEgtwcm90b193b3JsZBoLZW51bXMucHJvdG8aCm1h",
            "dGgucHJvdG8i8wQKB1RleHR1cmUSDwoHdmVyc2lvbhgBIAEoCRIMCgRuYW1l",
            "GGUgASgJEgwKBGZpbGUYZiABKAkSKAoEdHlwZRjJASABKA4yGS5wcm90b193",
            "b3JsZC5URVhUVVJFX1RZUEUSLAoGZm9ybWF0GMoBIAEoDjIbLnByb3RvX3dv",
            "cmxkLlRFWFRVUkVfRk9STUFUEiYKCXRyYW5zZm9ybRjZASABKAsyEi5wcm90",
            "b19tYXRoLmZsb2F0NBIOCgV3aWR0aBjLASABKAUSDwoGaGVpZ2h0GMwBIAEo",
            "BRIOCgVkZXB0aBjNASABKAUSKgoGd3JhcF91GM4BIAEoDjIZLnByb3RvX3dv",
            "cmxkLlRFWFRVUkVfV1JBUBIqCgZ3cmFwX3YYzwEgASgOMhkucHJvdG9fd29y",
            "bGQuVEVYVFVSRV9XUkFQEioKBndyYXBfdxjQASABKA4yGS5wcm90b193b3Js",
            "ZC5URVhUVVJFX1dSQVASLAoGZmlsdGVyGNEBIAEoDjIbLnByb3RvX3dvcmxk",
            "LlRFWFRVUkVfRklMVEVSEhgKD2dlbmVyYXRlX21pcG1hcBjTASABKAgSFgoN",
            "cmVuZGVyX3RhcmdldBjUASABKAgSOQoJc2l6ZV90eXBlGNUBIAEoDjIlLnBy",
            "b3RvX3dvcmxkLlJFTkRFUl9URVhUVVJFX1NJWkVfVFlQRRIdChRyZWxhdGl2",
            "ZV90b19zY3JlZW5fdxjWASABKAISHQoUcmVsYXRpdmVfdG9fc2NyZWVuX2gY",
            "1wEgASgCEh0KFHJlbGF0aXZlX3RvX3NjcmVlbl9kGNgBIAEoAhIOCgVkYXRh",
            "cxitAiADKAxCAkgDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::ProtoWorld.EnumsReflection.Descriptor, global::ProtoMath.MathReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ProtoWorld.Texture), global::ProtoWorld.Texture.Parser, new[]{ "Version", "Name", "File", "Type", "Format", "Transform", "Width", "Height", "Depth", "WrapU", "WrapV", "WrapW", "Filter", "GenerateMipmap", "RenderTarget", "SizeType", "RelativeToScreenW", "RelativeToScreenH", "RelativeToScreenD", "Datas" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Texture : pb::IMessage<Texture> {
    private static readonly pb::MessageParser<Texture> _parser = new pb::MessageParser<Texture>(() => new Texture());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Texture> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtoWorld.TextureReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Texture() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Texture(Texture other) : this() {
      version_ = other.version_;
      name_ = other.name_;
      file_ = other.file_;
      type_ = other.type_;
      format_ = other.format_;
      Transform = other.transform_ != null ? other.Transform.Clone() : null;
      width_ = other.width_;
      height_ = other.height_;
      depth_ = other.depth_;
      wrapU_ = other.wrapU_;
      wrapV_ = other.wrapV_;
      wrapW_ = other.wrapW_;
      filter_ = other.filter_;
      generateMipmap_ = other.generateMipmap_;
      renderTarget_ = other.renderTarget_;
      sizeType_ = other.sizeType_;
      relativeToScreenW_ = other.relativeToScreenW_;
      relativeToScreenH_ = other.relativeToScreenH_;
      relativeToScreenD_ = other.relativeToScreenD_;
      datas_ = other.datas_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Texture Clone() {
      return new Texture(this);
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

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 201;
    private global::ProtoWorld.TEXTURE_TYPE type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ProtoWorld.TEXTURE_TYPE Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "format" field.</summary>
    public const int FormatFieldNumber = 202;
    private global::ProtoWorld.TEXTURE_FORMAT format_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ProtoWorld.TEXTURE_FORMAT Format {
      get { return format_; }
      set {
        format_ = value;
      }
    }

    /// <summary>Field number for the "transform" field.</summary>
    public const int TransformFieldNumber = 217;
    private global::ProtoMath.float4 transform_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ProtoMath.float4 Transform {
      get { return transform_; }
      set {
        transform_ = value;
      }
    }

    /// <summary>Field number for the "width" field.</summary>
    public const int WidthFieldNumber = 203;
    private int width_;
    /// <summary>
    /// valid if (render_target == false) or (render_target == true and size_type == ABSOLUTE_SIZE_IN_PIXEL)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Width {
      get { return width_; }
      set {
        width_ = value;
      }
    }

    /// <summary>Field number for the "height" field.</summary>
    public const int HeightFieldNumber = 204;
    private int height_;
    /// <summary>
    /// valid if (render_target == false) or (render_target == true and size_type == ABSOLUTE_SIZE_IN_PIXEL)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Height {
      get { return height_; }
      set {
        height_ = value;
      }
    }

    /// <summary>Field number for the "depth" field.</summary>
    public const int DepthFieldNumber = 205;
    private int depth_;
    /// <summary>
    /// valid if (render_target == false) or (render_target == true and size_type == ABSOLUTE_SIZE_IN_PIXEL)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Depth {
      get { return depth_; }
      set {
        depth_ = value;
      }
    }

    /// <summary>Field number for the "wrap_u" field.</summary>
    public const int WrapUFieldNumber = 206;
    private global::ProtoWorld.TEXTURE_WRAP wrapU_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ProtoWorld.TEXTURE_WRAP WrapU {
      get { return wrapU_; }
      set {
        wrapU_ = value;
      }
    }

    /// <summary>Field number for the "wrap_v" field.</summary>
    public const int WrapVFieldNumber = 207;
    private global::ProtoWorld.TEXTURE_WRAP wrapV_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ProtoWorld.TEXTURE_WRAP WrapV {
      get { return wrapV_; }
      set {
        wrapV_ = value;
      }
    }

    /// <summary>Field number for the "wrap_w" field.</summary>
    public const int WrapWFieldNumber = 208;
    private global::ProtoWorld.TEXTURE_WRAP wrapW_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ProtoWorld.TEXTURE_WRAP WrapW {
      get { return wrapW_; }
      set {
        wrapW_ = value;
      }
    }

    /// <summary>Field number for the "filter" field.</summary>
    public const int FilterFieldNumber = 209;
    private global::ProtoWorld.TEXTURE_FILTER filter_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ProtoWorld.TEXTURE_FILTER Filter {
      get { return filter_; }
      set {
        filter_ = value;
      }
    }

    /// <summary>Field number for the "generate_mipmap" field.</summary>
    public const int GenerateMipmapFieldNumber = 211;
    private bool generateMipmap_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool GenerateMipmap {
      get { return generateMipmap_; }
      set {
        generateMipmap_ = value;
      }
    }

    /// <summary>Field number for the "render_target" field.</summary>
    public const int RenderTargetFieldNumber = 212;
    private bool renderTarget_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool RenderTarget {
      get { return renderTarget_; }
      set {
        renderTarget_ = value;
      }
    }

    /// <summary>Field number for the "size_type" field.</summary>
    public const int SizeTypeFieldNumber = 213;
    private global::ProtoWorld.RENDER_TEXTURE_SIZE_TYPE sizeType_ = 0;
    /// <summary>
    /// valid only if this is a render target( render_target == true )
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ProtoWorld.RENDER_TEXTURE_SIZE_TYPE SizeType {
      get { return sizeType_; }
      set {
        sizeType_ = value;
      }
    }

    /// <summary>Field number for the "relative_to_screen_w" field.</summary>
    public const int RelativeToScreenWFieldNumber = 214;
    private float relativeToScreenW_;
    /// <summary>
    /// valid only if (render_target == true) and (size_type == RELATIVE_TO_SCREEN)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float RelativeToScreenW {
      get { return relativeToScreenW_; }
      set {
        relativeToScreenW_ = value;
      }
    }

    /// <summary>Field number for the "relative_to_screen_h" field.</summary>
    public const int RelativeToScreenHFieldNumber = 215;
    private float relativeToScreenH_;
    /// <summary>
    /// valid only if (render_target == true) and (size_type == RELATIVE_TO_SCREEN)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float RelativeToScreenH {
      get { return relativeToScreenH_; }
      set {
        relativeToScreenH_ = value;
      }
    }

    /// <summary>Field number for the "relative_to_screen_d" field.</summary>
    public const int RelativeToScreenDFieldNumber = 216;
    private float relativeToScreenD_;
    /// <summary>
    /// valid only if (render_target == true) and (size_type == RELATIVE_TO_SCREEN)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float RelativeToScreenD {
      get { return relativeToScreenD_; }
      set {
        relativeToScreenD_ = value;
      }
    }

    /// <summary>Field number for the "datas" field.</summary>
    public const int DatasFieldNumber = 301;
    private static readonly pb::FieldCodec<pb::ByteString> _repeated_datas_codec
        = pb::FieldCodec.ForBytes(2410);
    private readonly pbc::RepeatedField<pb::ByteString> datas_ = new pbc::RepeatedField<pb::ByteString>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<pb::ByteString> Datas {
      get { return datas_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Texture);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Texture other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Version != other.Version) return false;
      if (Name != other.Name) return false;
      if (File != other.File) return false;
      if (Type != other.Type) return false;
      if (Format != other.Format) return false;
      if (!object.Equals(Transform, other.Transform)) return false;
      if (Width != other.Width) return false;
      if (Height != other.Height) return false;
      if (Depth != other.Depth) return false;
      if (WrapU != other.WrapU) return false;
      if (WrapV != other.WrapV) return false;
      if (WrapW != other.WrapW) return false;
      if (Filter != other.Filter) return false;
      if (GenerateMipmap != other.GenerateMipmap) return false;
      if (RenderTarget != other.RenderTarget) return false;
      if (SizeType != other.SizeType) return false;
      if (RelativeToScreenW != other.RelativeToScreenW) return false;
      if (RelativeToScreenH != other.RelativeToScreenH) return false;
      if (RelativeToScreenD != other.RelativeToScreenD) return false;
      if(!datas_.Equals(other.datas_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (File.Length != 0) hash ^= File.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Format != 0) hash ^= Format.GetHashCode();
      if (transform_ != null) hash ^= Transform.GetHashCode();
      if (Width != 0) hash ^= Width.GetHashCode();
      if (Height != 0) hash ^= Height.GetHashCode();
      if (Depth != 0) hash ^= Depth.GetHashCode();
      if (WrapU != 0) hash ^= WrapU.GetHashCode();
      if (WrapV != 0) hash ^= WrapV.GetHashCode();
      if (WrapW != 0) hash ^= WrapW.GetHashCode();
      if (Filter != 0) hash ^= Filter.GetHashCode();
      if (GenerateMipmap != false) hash ^= GenerateMipmap.GetHashCode();
      if (RenderTarget != false) hash ^= RenderTarget.GetHashCode();
      if (SizeType != 0) hash ^= SizeType.GetHashCode();
      if (RelativeToScreenW != 0F) hash ^= RelativeToScreenW.GetHashCode();
      if (RelativeToScreenH != 0F) hash ^= RelativeToScreenH.GetHashCode();
      if (RelativeToScreenD != 0F) hash ^= RelativeToScreenD.GetHashCode();
      hash ^= datas_.GetHashCode();
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
      if (Type != 0) {
        output.WriteRawTag(200, 12);
        output.WriteEnum((int) Type);
      }
      if (Format != 0) {
        output.WriteRawTag(208, 12);
        output.WriteEnum((int) Format);
      }
      if (Width != 0) {
        output.WriteRawTag(216, 12);
        output.WriteInt32(Width);
      }
      if (Height != 0) {
        output.WriteRawTag(224, 12);
        output.WriteInt32(Height);
      }
      if (Depth != 0) {
        output.WriteRawTag(232, 12);
        output.WriteInt32(Depth);
      }
      if (WrapU != 0) {
        output.WriteRawTag(240, 12);
        output.WriteEnum((int) WrapU);
      }
      if (WrapV != 0) {
        output.WriteRawTag(248, 12);
        output.WriteEnum((int) WrapV);
      }
      if (WrapW != 0) {
        output.WriteRawTag(128, 13);
        output.WriteEnum((int) WrapW);
      }
      if (Filter != 0) {
        output.WriteRawTag(136, 13);
        output.WriteEnum((int) Filter);
      }
      if (GenerateMipmap != false) {
        output.WriteRawTag(152, 13);
        output.WriteBool(GenerateMipmap);
      }
      if (RenderTarget != false) {
        output.WriteRawTag(160, 13);
        output.WriteBool(RenderTarget);
      }
      if (SizeType != 0) {
        output.WriteRawTag(168, 13);
        output.WriteEnum((int) SizeType);
      }
      if (RelativeToScreenW != 0F) {
        output.WriteRawTag(181, 13);
        output.WriteFloat(RelativeToScreenW);
      }
      if (RelativeToScreenH != 0F) {
        output.WriteRawTag(189, 13);
        output.WriteFloat(RelativeToScreenH);
      }
      if (RelativeToScreenD != 0F) {
        output.WriteRawTag(197, 13);
        output.WriteFloat(RelativeToScreenD);
      }
      if (transform_ != null) {
        output.WriteRawTag(202, 13);
        output.WriteMessage(Transform);
      }
      datas_.WriteTo(output, _repeated_datas_codec);
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
      if (Type != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Format != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) Format);
      }
      if (transform_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Transform);
      }
      if (Width != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Width);
      }
      if (Height != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Height);
      }
      if (Depth != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Depth);
      }
      if (WrapU != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) WrapU);
      }
      if (WrapV != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) WrapV);
      }
      if (WrapW != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) WrapW);
      }
      if (Filter != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) Filter);
      }
      if (GenerateMipmap != false) {
        size += 2 + 1;
      }
      if (RenderTarget != false) {
        size += 2 + 1;
      }
      if (SizeType != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) SizeType);
      }
      if (RelativeToScreenW != 0F) {
        size += 2 + 4;
      }
      if (RelativeToScreenH != 0F) {
        size += 2 + 4;
      }
      if (RelativeToScreenD != 0F) {
        size += 2 + 4;
      }
      size += datas_.CalculateSize(_repeated_datas_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Texture other) {
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
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Format != 0) {
        Format = other.Format;
      }
      if (other.transform_ != null) {
        if (transform_ == null) {
          transform_ = new global::ProtoMath.float4();
        }
        Transform.MergeFrom(other.Transform);
      }
      if (other.Width != 0) {
        Width = other.Width;
      }
      if (other.Height != 0) {
        Height = other.Height;
      }
      if (other.Depth != 0) {
        Depth = other.Depth;
      }
      if (other.WrapU != 0) {
        WrapU = other.WrapU;
      }
      if (other.WrapV != 0) {
        WrapV = other.WrapV;
      }
      if (other.WrapW != 0) {
        WrapW = other.WrapW;
      }
      if (other.Filter != 0) {
        Filter = other.Filter;
      }
      if (other.GenerateMipmap != false) {
        GenerateMipmap = other.GenerateMipmap;
      }
      if (other.RenderTarget != false) {
        RenderTarget = other.RenderTarget;
      }
      if (other.SizeType != 0) {
        SizeType = other.SizeType;
      }
      if (other.RelativeToScreenW != 0F) {
        RelativeToScreenW = other.RelativeToScreenW;
      }
      if (other.RelativeToScreenH != 0F) {
        RelativeToScreenH = other.RelativeToScreenH;
      }
      if (other.RelativeToScreenD != 0F) {
        RelativeToScreenD = other.RelativeToScreenD;
      }
      datas_.Add(other.datas_);
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
          case 1608: {
            type_ = (global::ProtoWorld.TEXTURE_TYPE) input.ReadEnum();
            break;
          }
          case 1616: {
            format_ = (global::ProtoWorld.TEXTURE_FORMAT) input.ReadEnum();
            break;
          }
          case 1624: {
            Width = input.ReadInt32();
            break;
          }
          case 1632: {
            Height = input.ReadInt32();
            break;
          }
          case 1640: {
            Depth = input.ReadInt32();
            break;
          }
          case 1648: {
            wrapU_ = (global::ProtoWorld.TEXTURE_WRAP) input.ReadEnum();
            break;
          }
          case 1656: {
            wrapV_ = (global::ProtoWorld.TEXTURE_WRAP) input.ReadEnum();
            break;
          }
          case 1664: {
            wrapW_ = (global::ProtoWorld.TEXTURE_WRAP) input.ReadEnum();
            break;
          }
          case 1672: {
            filter_ = (global::ProtoWorld.TEXTURE_FILTER) input.ReadEnum();
            break;
          }
          case 1688: {
            GenerateMipmap = input.ReadBool();
            break;
          }
          case 1696: {
            RenderTarget = input.ReadBool();
            break;
          }
          case 1704: {
            sizeType_ = (global::ProtoWorld.RENDER_TEXTURE_SIZE_TYPE) input.ReadEnum();
            break;
          }
          case 1717: {
            RelativeToScreenW = input.ReadFloat();
            break;
          }
          case 1725: {
            RelativeToScreenH = input.ReadFloat();
            break;
          }
          case 1733: {
            RelativeToScreenD = input.ReadFloat();
            break;
          }
          case 1738: {
            if (transform_ == null) {
              transform_ = new global::ProtoMath.float4();
            }
            input.ReadMessage(transform_);
            break;
          }
          case 2410: {
            datas_.AddEntriesFrom(input, _repeated_datas_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
