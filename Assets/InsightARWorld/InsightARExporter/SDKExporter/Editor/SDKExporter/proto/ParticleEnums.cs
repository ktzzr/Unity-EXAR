// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: particle_enums.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ProtoPs {

  /// <summary>Holder for reflection information generated from particle_enums.proto</summary>
  public static partial class ParticleEnumsReflection {

    #region Descriptor
    /// <summary>File descriptor for particle_enums.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ParticleEnumsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRwYXJ0aWNsZV9lbnVtcy5wcm90bxIIcHJvdG9fcHMqSgodUGFydGljbGVT",
            "eXN0ZW1TaW11bGF0aW9uU3BhY2USDAoIU1NfTG9jYWwQABIMCghTU19Xb3Js",
            "ZBABEg0KCVNTX0N1c3RvbRACKlsKF1BhcnRpY2xlU3lzdGVtQ3VydmVNb2Rl",
            "Eg4KCkNNQ29uc3RhbnQQABILCgdDTUN1cnZlEAESDwoLQ01Ud29DdXJ2ZXMQ",
            "AhISCg5DTVR3b0NvbnN0YW50cxADKkYKGVBhcnRpY2xlU3lzdGVtU2NhbGlu",
            "Z01vZGUSDwoLU01IaWVyYXJjaHkQABILCgdTTUxvY2FsEAESCwoHU01TaGFw",
            "ZRACKkcKIVBhcnRpY2xlU3lzdGVtRW1pdHRlclZlbG9jaXR5TW9kZRIQCgxF",
            "Vk1UcmFuc2Zvcm0QABIQCgxFVk1SaWdpZGJvZHkQASpfChlQYXJ0aWNsZVN5",
            "c3RlbVJlbmRlclNwYWNlEgoKBlJTVmlldxAAEgsKB1JTV29ybGQQARILCgdS",
            "U0xvY2FsEAISDAoIUlNGYWNpbmcQAxIOCgpSU1ZlbG9jaXR5EAQqhgEKGFBh",
            "cnRpY2xlU3lzdGVtUmVuZGVyTW9kZRIPCgtSTUJpbGxib2FyZBAAEg0KCVJN",
            "U3RyZXRjaBABEhkKFVJNSG9yaXpvbnRhbEJpbGxib2FyZBACEhcKE1JNVmVy",
            "dGljYWxCaWxsYm9hcmQQAxIKCgZSTU1lc2gQBBIKCgZSTU5vbmUQBSpgChZQ",
            "YXJ0aWNsZVN5c3RlbVNvcnRNb2RlEgoKBlNNTm9uZRAAEg4KClNNRGlzdGFu",
            "Y2UQARITCg9TTU9sZGVzdEluRnJvbnQQAhIVChFTTVlvdW5nZXN0SW5Gcm9u",
            "dBADKnEKGlBhcnRpY2xlU3lzdGVtR3JhZGllbnRNb2RlEgsKB0dNQ29sb3IQ",
            "ABIOCgpHTUdyYWRpZW50EAESDwoLR01Ud29Db2xvcnMQAhISCg5HTVR3b0dy",
            "YWRpZW50cxADEhEKDUdNUmFuZG9tQ29sb3IQBCooCgxHcmFkaWVudE1vZGUS",
            "CwoHR01CbGVuZBAAEgsKB0dNRml4ZWQQASpVCghXcmFwTW9kZRINCglXTURl",
            "ZmF1bHQQABIKCgZXTU9uY2UQARIKCgZXTUxvb3AQAhIOCgpXTVBpbmdQb25n",
            "EAQSEgoOV01DbGFtcEZvcmV2ZXIQCCrSAgoXUGFydGljbGVTeXN0ZW1TaGFw",
            "ZVR5cGUSDAoIU1RTcGhlcmUQABIRCg1TVFNwaGVyZVNoZWxsEAESEAoMU1RI",
            "ZW1pc3BoZXJlEAISFQoRU1RIZW1pc3BoZXJlU2hlbGwQAxIKCgZTVENvbmUQ",
            "BBIJCgVTVEJveBAFEgoKBlNUTWVzaBAGEg8KC1NUQ29uZVNoZWxsEAcSEAoM",
            "U1RDb25lVm9sdW1lEAgSFQoRU1RDb25lVm9sdW1lU2hlbGwQCRIMCghTVENp",
            "cmNsZRAKEhAKDFNUQ2lyY2xlRWRnZRALEhUKEVNUU2luZ2xlU2lkZWRFZGdl",
            "EAwSEgoOU1RNZXNoUmVuZGVyZXIQDRIZChVTVFNraW5uZWRNZXNoUmVuZGVy",
            "ZXIQDhIOCgpTVEJveFNoZWxsEA8SDQoJU1RCb3hFZGdlEBASCwoHU1REb251",
            "dBARKkcKG1BhcnRpY2xlU3lzdGVtTWVzaFNoYXBlVHlwZRIMCghTVFZlcnRl",
            "eBAAEgoKBlNURWRnZRABEg4KClNUVHJpYW5nbGUQAipAChtQYXJ0aWNsZVN5",
            "c3RlbUFuaW1hdGlvblR5cGUSEAoMQVRXaG9sZVNoZWV0EAASDwoLQVRTaW5n",
            "bGVSb3cQASo4ChtQYXJ0aWNsZVN5c3RlbUFuaW1hdGlvbk1vZGUSCgoGQU1H",
            "cmlkEAASDQoJQU1TcHJpdGVzEAEqTAocUGFydGljbGVTeXN0ZW1TdWJFbWl0",
            "dGVyVHlwZRIMCghTRVRCaXJ0aBAAEhAKDFNFVENvbGxpc2lvbhABEgwKCFNF",
            "VERlYXRoEAIqlgEKIlBhcnRpY2xlU3lzdGVtU3ViRW1pdHRlclByb3BlcnRp",
            "ZXMSFQoRU0VQSW5oZXJpdE5vdGhpbmcQABITCg9TRVBJbmhlcml0Q29sb3IQ",
            "ARISCg5TRVBJbmhlcml0U2l6ZRACEhYKElNFUEluaGVyaXRSb3RhdGlvbhAE",
            "EhgKFFNFUEluaGVyaXRFdmVyeXRoaW5nEAcqOwoaUGFydGljbGVTeXN0ZW1O",
            "b2lzZVF1YWxpdHkSBwoDTG93EAASCgoGTWVkaXVtEAESCAoESGlnaBACKnMK",
            "HlBhcnRpY2xlU3lzdGVtVHJhaWxUZXh0dXJlTW9kZRIOCgpUVE1TdHJldGNo",
            "EAASCwoHVFRNVGlsZRABEhsKF1RUTURpc3RyaWJ1dGVQZXJTZWdtZW50EAIS",
            "FwoTVFRNUmVwZWF0UGVyU2VnbWVudBADKmsKG1BhcnRpY2xlU3lzdGVtT3Zl",
            "cmxhcEFjdGlvbhIYChRPdmVybGFwQWN0aW9uX0lnbm9yZRAAEhYKEk92ZXJs",
            "YXBBY3Rpb25fS2lsbBABEhoKFk92ZXJsYXBBY3Rpb25fQ2FsbGJhY2sQAipC",
            "CiFQYXJ0aWNsZVN5c3RlbUluaGVyaXRWZWxvY2l0eU1vZGUSDAoISVZNX0lu",
            "aXQQABIPCgtJVk1fQ3VycmVudBABKkkKHlBhcnRpY2xlU3lzdGVtQ29sbGlz",
            "aW9uUXVhbGl0eRIMCghDUV9IaWdodBAAEg0KCUNRX01lZGl1bRABEgoKBkNR",
            "X0xvdxACKkUKG1BhcnRpY2xlU3lzdGVtQ29sbGlzaW9uTW9kZRISCg5DTV9D",
            "b2xsaXNpb24zRBAAEhIKDkNNX0NvbGxpc2lvbjJEEAEqOgobUGFydGljbGVT",
            "eXN0ZW1Db2xsaXNpb25UeXBlEg0KCUNUX1BsYW5lcxAAEgwKCENUX1dvcmxk",
            "EAFCAkgDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::ProtoPs.ParticleSystemSimulationSpace), typeof(global::ProtoPs.ParticleSystemCurveMode), typeof(global::ProtoPs.ParticleSystemScalingMode), typeof(global::ProtoPs.ParticleSystemEmitterVelocityMode), typeof(global::ProtoPs.ParticleSystemRenderSpace), typeof(global::ProtoPs.ParticleSystemRenderMode), typeof(global::ProtoPs.ParticleSystemSortMode), typeof(global::ProtoPs.ParticleSystemGradientMode), typeof(global::ProtoPs.GradientMode), typeof(global::ProtoPs.WrapMode), typeof(global::ProtoPs.ParticleSystemShapeType), typeof(global::ProtoPs.ParticleSystemMeshShapeType), typeof(global::ProtoPs.ParticleSystemAnimationType), typeof(global::ProtoPs.ParticleSystemAnimationMode), typeof(global::ProtoPs.ParticleSystemSubEmitterType), typeof(global::ProtoPs.ParticleSystemSubEmitterProperties), typeof(global::ProtoPs.ParticleSystemNoiseQuality), typeof(global::ProtoPs.ParticleSystemTrailTextureMode), typeof(global::ProtoPs.ParticleSystemOverlapAction), typeof(global::ProtoPs.ParticleSystemInheritVelocityMode), typeof(global::ProtoPs.ParticleSystemCollisionQuality), typeof(global::ProtoPs.ParticleSystemCollisionMode), typeof(global::ProtoPs.ParticleSystemCollisionType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ParticleSystemSimulationSpace {
    [pbr::OriginalName("SS_Local")] SsLocal = 0,
    [pbr::OriginalName("SS_World")] SsWorld = 1,
    [pbr::OriginalName("SS_Custom")] SsCustom = 2,
  }

  public enum ParticleSystemCurveMode {
    [pbr::OriginalName("CMConstant")] Cmconstant = 0,
    [pbr::OriginalName("CMCurve")] Cmcurve = 1,
    [pbr::OriginalName("CMTwoCurves")] CmtwoCurves = 2,
    [pbr::OriginalName("CMTwoConstants")] CmtwoConstants = 3,
  }

  public enum ParticleSystemScalingMode {
    /// <summary>
    ///Scale the particle system using the entire transform hierarchy.
    /// </summary>
    [pbr::OriginalName("SMHierarchy")] Smhierarchy = 0,
    /// <summary>
    ///Scale the particle system using only its own transform scale. (Ignores parent scale).
    /// </summary>
    [pbr::OriginalName("SMLocal")] Smlocal = 1,
    /// <summary>
    ///Only apply transform scale to the shape component, which controls where /// particles
    ///     are spawned, but does not affect their size or movement. ///
    /// </summary>
    [pbr::OriginalName("SMShape")] Smshape = 2,
  }

  public enum ParticleSystemEmitterVelocityMode {
    /// <summary>
    ///Calculate the Particle System velocity by using the Transform component.
    /// </summary>
    [pbr::OriginalName("EVMTransform")] Evmtransform = 0,
    /// <summary>
    ///Calculate the Particle System velocity by using a Rigidbody or Rigidbody2D component,
    /// </summary>
    [pbr::OriginalName("EVMRigidbody")] Evmrigidbody = 1,
  }

  public enum ParticleSystemRenderSpace {
    /// <summary>
    ///Particles face the camera plane.
    /// </summary>
    [pbr::OriginalName("RSView")] Rsview = 0,
    /// <summary>
    ///Particles align with the world.
    /// </summary>
    [pbr::OriginalName("RSWorld")] Rsworld = 1,
    /// <summary>
    ///Particles align with their local transform.
    /// </summary>
    [pbr::OriginalName("RSLocal")] Rslocal = 2,
    /// <summary>
    ///Particles face the eye position.
    /// </summary>
    [pbr::OriginalName("RSFacing")] Rsfacing = 3,
    /// <summary>
    ///Particles are aligned to their direction of travel.
    /// </summary>
    [pbr::OriginalName("RSVelocity")] Rsvelocity = 4,
  }

  public enum ParticleSystemRenderMode {
    /// <summary>
    ///Render particles as billboards facing the active camera. (Default)
    /// </summary>
    [pbr::OriginalName("RMBillboard")] Rmbillboard = 0,
    /// <summary>
    ///Stretch particles in the direction of motion.
    /// </summary>
    [pbr::OriginalName("RMStretch")] Rmstretch = 1,
    /// <summary>
    ///Render particles as billboards always facing up along the y-Axis.
    /// </summary>
    [pbr::OriginalName("RMHorizontalBillboard")] RmhorizontalBillboard = 2,
    /// <summary>
    ///Render particles as billboards always facing the player, but not pitching along the x-Axis.
    /// </summary>
    [pbr::OriginalName("RMVerticalBillboard")] RmverticalBillboard = 3,
    /// <summary>
    ///Render particles as meshes.
    /// </summary>
    [pbr::OriginalName("RMMesh")] Rmmesh = 4,
    /// <summary>
    ///Do not render particles.
    /// </summary>
    [pbr::OriginalName("RMNone")] Rmnone = 5,
  }

  public enum ParticleSystemSortMode {
    /// <summary>
    ///    No sorting.
    /// </summary>
    [pbr::OriginalName("SMNone")] Smnone = 0,
    /// <summary>
    ///    Sort based on distance.
    /// </summary>
    [pbr::OriginalName("SMDistance")] Smdistance = 1,
    /// <summary>
    ///    Sort the oldest particles to the front.
    /// </summary>
    [pbr::OriginalName("SMOldestInFront")] SmoldestInFront = 2,
    /// <summary>
    ///Sort the youngest particles to the front.
    /// </summary>
    [pbr::OriginalName("SMYoungestInFront")] SmyoungestInFront = 3,
  }

  public enum ParticleSystemGradientMode {
    /// <summary>
    ///Use a single color for the MinMaxGradient.
    /// </summary>
    [pbr::OriginalName("GMColor")] Gmcolor = 0,
    /// <summary>
    ///    Use a single color gradient for the MinMaxGradient.
    /// </summary>
    [pbr::OriginalName("GMGradient")] Gmgradient = 1,
    /// <summary>
    ///    Use a random value between 2 colors for the MinMaxGradient.
    /// </summary>
    [pbr::OriginalName("GMTwoColors")] GmtwoColors = 2,
    /// <summary>
    ///    Use a random value between 2 color gradients for the MinMaxGradient.
    /// </summary>
    [pbr::OriginalName("GMTwoGradients")] GmtwoGradients = 3,
    /// <summary>
    ///Define a list of colors in the MinMaxGradient, to be chosen from at random.
    /// </summary>
    [pbr::OriginalName("GMRandomColor")] GmrandomColor = 4,
  }

  public enum GradientMode {
    /// <summary>
    ///Find the 2 keys adjacent to the requested evaluation time, and linearly interpolate between them to obtain a blended color.
    /// </summary>
    [pbr::OriginalName("GMBlend")] Gmblend = 0,
    /// <summary>
    ///Return a fixed color, by finding the first key whose time value is greater than the requested evaluation time.
    /// </summary>
    [pbr::OriginalName("GMFixed")] Gmfixed = 1,
  }

  /// <summary>
  /// Determines how time is treated outside of the keyframed range of an AnimationClip or AnimationCurve.
  /// </summary>
  public enum WrapMode {
    /// <summary>
    ///     Reads the default repeat mode set higher up.
    /// </summary>
    [pbr::OriginalName("WMDefault")] Wmdefault = 0,
    /// <summary>
    ///  When time reaches the end of the animation clip, the clip will automatically
    ///     stop playing and time will be reset to beginning of the clip.
    /// </summary>
    [pbr::OriginalName("WMOnce")] Wmonce = 1,
    /// <summary>
    ///     When time reaches the end of the animation clip, time will continue at the beginning.
    /// </summary>
    [pbr::OriginalName("WMLoop")] Wmloop = 2,
    /// <summary>
    ///     When time reaches the end of the animation clip, time will ping pong back between
    ///     beginning and end.
    /// </summary>
    [pbr::OriginalName("WMPingPong")] WmpingPong = 4,
    /// <summary>
    ///     Plays back the animation. When it reaches the end, it will keep playing the last
    ///     frame and never stop playing.
    /// </summary>
    [pbr::OriginalName("WMClampForever")] WmclampForever = 8,
  }

  public enum ParticleSystemShapeType {
    [pbr::OriginalName("STSphere")] Stsphere = 0,
    /// <summary>
    ///     Emit from the surface of a sphere.
    /// </summary>
    [pbr::OriginalName("STSphereShell")] StsphereShell = 1,
    [pbr::OriginalName("STHemisphere")] Sthemisphere = 2,
    /// <summary>
    ///     Emit from the surface of a half-sphere.
    /// </summary>
    [pbr::OriginalName("STHemisphereShell")] SthemisphereShell = 3,
    /// <summary>
    ///     Emit from the base of a cone.
    /// </summary>
    [pbr::OriginalName("STCone")] Stcone = 4,
    /// <summary>
    ///     Emit from the volume of a box.
    /// </summary>
    [pbr::OriginalName("STBox")] Stbox = 5,
    /// <summary>
    ///     Emit from a mesh.
    /// </summary>
    [pbr::OriginalName("STMesh")] Stmesh = 6,
    /// <summary>
    ///     Emit from the base surface of a cone.
    /// </summary>
    [pbr::OriginalName("STConeShell")] StconeShell = 7,
    /// <summary>
    ///     Emit from a cone.
    /// </summary>
    [pbr::OriginalName("STConeVolume")] StconeVolume = 8,
    /// <summary>
    ///     Emit from the surface of a cone.
    /// </summary>
    [pbr::OriginalName("STConeVolumeShell")] StconeVolumeShell = 9,
    /// <summary>
    ///     Emit from a circle.
    /// </summary>
    [pbr::OriginalName("STCircle")] Stcircle = 10,
    /// <summary>
    ///     Emit from the edge of a circle.
    /// </summary>
    [pbr::OriginalName("STCircleEdge")] StcircleEdge = 11,
    /// <summary>
    ///     Emit from an edge.
    /// </summary>
    [pbr::OriginalName("STSingleSidedEdge")] StsingleSidedEdge = 12,
    /// <summary>
    ///     Emit from a mesh renderer.
    /// </summary>
    [pbr::OriginalName("STMeshRenderer")] StmeshRenderer = 13,
    /// <summary>
    ///     Emit from a skinned mesh renderer.
    /// </summary>
    [pbr::OriginalName("STSkinnedMeshRenderer")] StskinnedMeshRenderer = 14,
    /// <summary>
    ///     Emit from the surface of a box.
    /// </summary>
    [pbr::OriginalName("STBoxShell")] StboxShell = 15,
    /// <summary>
    ///     Emit from the edges of a box.
    /// </summary>
    [pbr::OriginalName("STBoxEdge")] StboxEdge = 16,
    /// <summary>
    ///     Emit from a Donut.
    /// </summary>
    [pbr::OriginalName("STDonut")] Stdonut = 17,
  }

  public enum ParticleSystemMeshShapeType {
    [pbr::OriginalName("STVertex")] Stvertex = 0,
    [pbr::OriginalName("STEdge")] Stedge = 1,
    [pbr::OriginalName("STTriangle")] Sttriangle = 2,
  }

  public enum ParticleSystemAnimationType {
    [pbr::OriginalName("ATWholeSheet")] AtwholeSheet = 0,
    [pbr::OriginalName("ATSingleRow")] AtsingleRow = 1,
  }

  public enum ParticleSystemAnimationMode {
    /// <summary>
    ///     Use a regular grid to construct a sequence of animation frames.
    /// </summary>
    [pbr::OriginalName("AMGrid")] Amgrid = 0,
    /// <summary>
    ///     Use a list of sprites to construct a sequence of animation frames.
    /// </summary>
    [pbr::OriginalName("AMSprites")] Amsprites = 1,
  }

  public enum ParticleSystemSubEmitterType {
    [pbr::OriginalName("SETBirth")] Setbirth = 0,
    [pbr::OriginalName("SETCollision")] Setcollision = 1,
    [pbr::OriginalName("SETDeath")] Setdeath = 2,
  }

  public enum ParticleSystemSubEmitterProperties {
    [pbr::OriginalName("SEPInheritNothing")] SepinheritNothing = 0,
    /// <summary>
    ///When spawning new particles, multiply the start color by the color of the parent particles.
    /// </summary>
    [pbr::OriginalName("SEPInheritColor")] SepinheritColor = 1,
    [pbr::OriginalName("SEPInheritSize")] SepinheritSize = 2,
    [pbr::OriginalName("SEPInheritRotation")] SepinheritRotation = 4,
    [pbr::OriginalName("SEPInheritEverything")] SepinheritEverything = 7,
  }

  public enum ParticleSystemNoiseQuality {
    /// <summary>
    ///     Low quality 1D noise.
    /// </summary>
    [pbr::OriginalName("Low")] Low = 0,
    /// <summary>
    ///     Medium quality 2D noise.
    /// </summary>
    [pbr::OriginalName("Medium")] Medium = 1,
    /// <summary>
    ///     High quality 3D noise.
    /// </summary>
    [pbr::OriginalName("High")] High = 2,
  }

  public enum ParticleSystemTrailTextureMode {
    /// <summary>
    ///Map the texture once along the entire length of the trail.
    /// </summary>
    [pbr::OriginalName("TTMStretch")] Ttmstretch = 0,
    /// <summary>
    ///Repeat the texture along the trail. To set the tiling rate, use Material.SetTextureScale.
    /// </summary>
    [pbr::OriginalName("TTMTile")] Ttmtile = 1,
    /// <summary>
    ///Map the texture once along the entire length of the trail, assuming all vertices are evenly spaced.
    /// </summary>
    [pbr::OriginalName("TTMDistributePerSegment")] TtmdistributePerSegment = 2,
    /// <summary>
    ///Repeat the texture along the trail, repeating at a rate of once per trail segment. To adjust the tiling rate, use Material.SetTextureScale.
    /// </summary>
    [pbr::OriginalName("TTMRepeatPerSegment")] TtmrepeatPerSegment = 3,
  }

  public enum ParticleSystemOverlapAction {
    [pbr::OriginalName("OverlapAction_Ignore")] OverlapActionIgnore = 0,
    [pbr::OriginalName("OverlapAction_Kill")] OverlapActionKill = 1,
    [pbr::OriginalName("OverlapAction_Callback")] OverlapActionCallback = 2,
  }

  public enum ParticleSystemInheritVelocityMode {
    [pbr::OriginalName("IVM_Init")] IvmInit = 0,
    [pbr::OriginalName("IVM_Current")] IvmCurrent = 1,
  }

  public enum ParticleSystemCollisionQuality {
    [pbr::OriginalName("CQ_Hight")] CqHight = 0,
    [pbr::OriginalName("CQ_Medium")] CqMedium = 1,
    [pbr::OriginalName("CQ_Low")] CqLow = 2,
  }

  public enum ParticleSystemCollisionMode {
    [pbr::OriginalName("CM_Collision3D")] CmCollision3D = 0,
    [pbr::OriginalName("CM_Collision2D")] CmCollision2D = 1,
  }

  public enum ParticleSystemCollisionType {
    [pbr::OriginalName("CT_Planes")] CtPlanes = 0,
    [pbr::OriginalName("CT_World")] CtWorld = 1,
  }

  #endregion

}

#endregion Designer generated code
