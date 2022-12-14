// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: shader.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ProtoWorld {

  /// <summary>Holder for reflection information generated from shader.proto</summary>
  public static partial class ShaderReflection {

    #region Descriptor
    /// <summary>File descriptor for shader.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ShaderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxzaGFkZXIucHJvdG8SC3Byb3RvX3dvcmxkIrABCgZTaGFkZXISDwoHdmVy",
            "c2lvbhgBIAEoCRIMCgRuYW1lGGUgASgJEgwKBGZpbGUYZiABKAkSDwoHdnNf",
            "ZmlsZRhnIAEoCRIPCgdmc19maWxlGGggASgJEhAKB3ZzX2NvZGUYyQEgASgJ",
            "EhAKB2ZzX2NvZGUYygEgASgJEg8KBnZzX2JpbhitAiABKAwSDwoGZnNfYmlu",
            "GK4CIAEoDBIRCghjcHVfYm9uZRjoByABKAhCAkgDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ProtoWorld.Shader), global::ProtoWorld.Shader.Parser, new[]{ "Version", "Name", "File", "VsFile", "FsFile", "VsCode", "FsCode", "VsBin", "FsBin", "CpuBone" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Shader : pb::IMessage<Shader> {
    private static readonly pb::MessageParser<Shader> _parser = new pb::MessageParser<Shader>(() => new Shader());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Shader> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtoWorld.ShaderReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Shader() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Shader(Shader other) : this() {
      version_ = other.version_;
      name_ = other.name_;
      file_ = other.file_;
      vsFile_ = other.vsFile_;
      fsFile_ = other.fsFile_;
      vsCode_ = other.vsCode_;
      fsCode_ = other.fsCode_;
      vsBin_ = other.vsBin_;
      fsBin_ = other.fsBin_;
      cpuBone_ = other.cpuBone_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Shader Clone() {
      return new Shader(this);
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
    /// <summary>
    /// deprecated
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string File {
      get { return file_; }
      set {
        file_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "vs_file" field.</summary>
    public const int VsFileFieldNumber = 103;
    private string vsFile_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string VsFile {
      get { return vsFile_; }
      set {
        vsFile_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fs_file" field.</summary>
    public const int FsFileFieldNumber = 104;
    private string fsFile_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FsFile {
      get { return fsFile_; }
      set {
        fsFile_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "vs_code" field.</summary>
    public const int VsCodeFieldNumber = 201;
    private string vsCode_ = "";
    /// <summary>
    /// deprecated
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string VsCode {
      get { return vsCode_; }
      set {
        vsCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fs_code" field.</summary>
    public const int FsCodeFieldNumber = 202;
    private string fsCode_ = "";
    /// <summary>
    /// deprecated
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FsCode {
      get { return fsCode_; }
      set {
        fsCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "vs_bin" field.</summary>
    public const int VsBinFieldNumber = 301;
    private pb::ByteString vsBin_ = pb::ByteString.Empty;
    /// <summary>
    /// deprecated
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString VsBin {
      get { return vsBin_; }
      set {
        vsBin_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fs_bin" field.</summary>
    public const int FsBinFieldNumber = 302;
    private pb::ByteString fsBin_ = pb::ByteString.Empty;
    /// <summary>
    /// deprecated
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString FsBin {
      get { return fsBin_; }
      set {
        fsBin_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cpu_bone" field.</summary>
    public const int CpuBoneFieldNumber = 1000;
    private bool cpuBone_;
    /// <summary>
    /// deprecated
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool CpuBone {
      get { return cpuBone_; }
      set {
        cpuBone_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Shader);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Shader other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Version != other.Version) return false;
      if (Name != other.Name) return false;
      if (File != other.File) return false;
      if (VsFile != other.VsFile) return false;
      if (FsFile != other.FsFile) return false;
      if (VsCode != other.VsCode) return false;
      if (FsCode != other.FsCode) return false;
      if (VsBin != other.VsBin) return false;
      if (FsBin != other.FsBin) return false;
      if (CpuBone != other.CpuBone) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (File.Length != 0) hash ^= File.GetHashCode();
      if (VsFile.Length != 0) hash ^= VsFile.GetHashCode();
      if (FsFile.Length != 0) hash ^= FsFile.GetHashCode();
      if (VsCode.Length != 0) hash ^= VsCode.GetHashCode();
      if (FsCode.Length != 0) hash ^= FsCode.GetHashCode();
      if (VsBin.Length != 0) hash ^= VsBin.GetHashCode();
      if (FsBin.Length != 0) hash ^= FsBin.GetHashCode();
      if (CpuBone != false) hash ^= CpuBone.GetHashCode();
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
      if (VsFile.Length != 0) {
        output.WriteRawTag(186, 6);
        output.WriteString(VsFile);
      }
      if (FsFile.Length != 0) {
        output.WriteRawTag(194, 6);
        output.WriteString(FsFile);
      }
      if (VsCode.Length != 0) {
        output.WriteRawTag(202, 12);
        output.WriteString(VsCode);
      }
      if (FsCode.Length != 0) {
        output.WriteRawTag(210, 12);
        output.WriteString(FsCode);
      }
      if (VsBin.Length != 0) {
        output.WriteRawTag(234, 18);
        output.WriteBytes(VsBin);
      }
      if (FsBin.Length != 0) {
        output.WriteRawTag(242, 18);
        output.WriteBytes(FsBin);
      }
      if (CpuBone != false) {
        output.WriteRawTag(192, 62);
        output.WriteBool(CpuBone);
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
      if (VsFile.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(VsFile);
      }
      if (FsFile.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(FsFile);
      }
      if (VsCode.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(VsCode);
      }
      if (FsCode.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(FsCode);
      }
      if (VsBin.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeBytesSize(VsBin);
      }
      if (FsBin.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeBytesSize(FsBin);
      }
      if (CpuBone != false) {
        size += 2 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Shader other) {
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
      if (other.VsFile.Length != 0) {
        VsFile = other.VsFile;
      }
      if (other.FsFile.Length != 0) {
        FsFile = other.FsFile;
      }
      if (other.VsCode.Length != 0) {
        VsCode = other.VsCode;
      }
      if (other.FsCode.Length != 0) {
        FsCode = other.FsCode;
      }
      if (other.VsBin.Length != 0) {
        VsBin = other.VsBin;
      }
      if (other.FsBin.Length != 0) {
        FsBin = other.FsBin;
      }
      if (other.CpuBone != false) {
        CpuBone = other.CpuBone;
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
          case 826: {
            VsFile = input.ReadString();
            break;
          }
          case 834: {
            FsFile = input.ReadString();
            break;
          }
          case 1610: {
            VsCode = input.ReadString();
            break;
          }
          case 1618: {
            FsCode = input.ReadString();
            break;
          }
          case 2410: {
            VsBin = input.ReadBytes();
            break;
          }
          case 2418: {
            FsBin = input.ReadBytes();
            break;
          }
          case 8000: {
            CpuBone = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
