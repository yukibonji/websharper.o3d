﻿namespace IntelliFactory.WebSharper.O3DExtension

open IntelliFactory.WebSharper
open IntelliFactory.WebSharper.Dom
open IntelliFactory.WebSharper.Html5

module O3D =
    open IntelliFactory.WebSharper.InterfaceGenerator

    module Util =

        let ConstantStrings type' strings =
            strings |> List.map (fun s ->
                s =? type'
                |> WithGetterInline ("\"" + s + "\"")
                :> CodeModel.IClassMember
            )

        let ConstantStringsType name strings =
            let t = Type.New()
            Class name
            |=> t
            |+> (strings
                 |> List.map (fun s ->
                    s =? t
                    |> WithGetterInline ("\"" + s + "\"")
                    :> CodeModel.IClassMember))

        let ConstantsType name (t : Type.Type) strings =
            Class name
            |=> t
            |+> (strings
                 |> List.map (fun s ->
                    s =? t
                    |> WithGetterInline (name + "." + s)
                    :> CodeModel.IClassMember))

        let ClassWithInitArgs name args =
            Pattern.Config name {Optional=args; Required=[]}

    open Util

    //////// Type declarations, for use with recursive types ////////
    let ObjectBase = Type.New()
    let NamedObjectBase = Type.New()
    let NamedObject = Type.New()
    let Param = Type.New()
    let ParamType = Type.New()
    let ParamObject = Type.New()
    let RawData = Type.New()
    let ArchiveRequest = Type.New()
    let CurveKey = Type.New()
    let BezierCurveKey = Type.New()
    let LinearCurveKey = Type.New()
    let StepCurveKey = Type.New()
    let Bitmap_Semantic = Type.New()
    let Texture_Format = Type.New()
    let Texture = Type.New()
    let Bitmap = Type.New()
    let RenderSurfaceBase = Type.New()
    let RenderSurface = Type.New()
    let Canvas = Type.New()
    let Texture2D = Type.New()
    let TextureCUBE_CubeFace = Type.New()
    let TextureCUBE = Type.New()
    let Field = Type.New()
    let FieldType = Type.New()
    let FloatField = Type.New()
    let UByteNField = Type.New()
    let UInt32Field = Type.New()
    let Buffer = Type.New()
    let CanvasFontMetrics = Type.New()
    let CanvasPaint_Style = Type.New()
    let CanvasPaint_TextAlign = Type.New()
    let CanvasShader_TileMode = Type.New()
    let CanvasShader = Type.New()
    let CanvasPaint = Type.New()
    let CanvasLinearGradient = Type.New()
    let RenderNode = Type.New()
    let ClearBuffer = Type.New()
    let Client_RenderMode = Type.New()
    let RenderDepthStencilSurface = Type.New()
    let FileRequestType = Type.New()
    let FileRequest = Type.New()
    let ObjectType = Type.New()
    let Pack = Type.New()
    let DisplayMode = Type.New()
    let Event_Button = Type.New()
    let Event_Type = Type.New()
    let Event = Type.New()
    let RenderEvent = Type.New()
    let TickEvent = Type.New()
    let ClientInfo = Type.New()
    let Cursor_CursorType = Type.New()
    let Cursor = Type.New()
    let Renderer_InitStatus = Type.New()
    let Renderer_DisplayModes = Type.New()
    let Renderer = Type.New()
    let DrawList_SortMethod = Type.New()
    let DrawList = Type.New()
    let Stream_Semantic = Type.New()
    let Stream = Type.New()
    let Effect_MatrixLoadOrder = Type.New()
    let EffectParameterInfo = Type.New()
    let EffectStreamInfo = Type.New()
    let Effect = Type.New()
    let State_BlendingEquation = Type.New()
    let State_BlendingFunction = Type.New()
    let State_Comparison = Type.New()
    let State_Cull = Type.New()
    let State_Fill = Type.New()
    let State_StencilOperation = Type.New()
    let State = Type.New()
    let Material = Type.New()
    let RayIntersectionInfo = Type.New()
    let Element = Type.New()
    let DrawElement = Type.New()
    let Shape = Type.New()
    let Transform = Type.New()
    let Client = Type.New()
    let Counter_CountMode = Type.New()
    let Counter = Type.New()
    let Function = Type.New()
    let Curve_Infinity = Type.New()
    let Curve = Type.New()
    let DrawContext = Type.New()
    let DrawPass = Type.New()
    let FunctionEval = Type.New()
    let IndexBuffer = Type.New()
    let Matrix4AxisRotation = Type.New()
    let Matrix4Composition = Type.New()
    let Matrix4Scale = Type.New()
    let Matrix4Translation = Type.New()
    let ParamArray = Type.New()
    let ParamOp16FloatsToMatrix4 = Type.New()
    let ParamOp2FloatsToFloat2 = Type.New()
    let ParamOp3FloatsToFloat3 = Type.New()
    let ParamOp4FloatsToFloat4 = Type.New()
    let StreamBank = Type.New()
    let Primitive_PrimitiveType = Type.New()
    let Primitive = Type.New()
    let ProjectionParamMatrix4 = Type.New()
    let ProjectionInverseParamMatrix4 = Type.New()
    let ProjectionTransposeParamMatrix4 = Type.New()
    let ProjectionInverseTransposeParamMatrix4 = Type.New()
    let RenderFrameCounter = Type.New()
    let RenderSurfaceSet = Type.New()
    let Sampler_AddressMode = Type.New()
    let Sampler_FilterType = Type.New()
    let Sampler = Type.New()
    let SecondCounter = Type.New()
    let Skin = Type.New()
    let VertexSource = Type.New()
    let SkinEval = Type.New()
    let VertexBufferBase = Type.New()
    let SourceBuffer = Type.New()
    let StateSet = Type.New()
    let TickCounter = Type.New()
    let TreeTraversal = Type.New()
    let TRSToMatrix4 = Type.New()
    let VertexBuffer = Type.New()
    let ViewParamMatrix4 = Type.New()
    let ViewInverseParamMatrix4 = Type.New()
    let ViewTransposeParamMatrix4 = Type.New()
    let ViewInverseTransposeParamMatrix4 = Type.New()
    let ViewProjectionParamMatrix4 = Type.New()
    let ViewProjectionInverseParamMatrix4 = Type.New()
    let ViewProjectionTransposeParamMatrix4 = Type.New()
    let ViewProjectionInverseTransposeParamMatrix4 = Type.New()
    let Viewport = Type.New()
    let WorldViewParamMatrix4 = Type.New()
    let WorldViewInverseParamMatrix4 = Type.New()
    let WorldViewTransposeParamMatrix4 = Type.New()
    let WorldViewInverseTransposeParamMatrix4 = Type.New()
    let WorldViewProjectionParamMatrix4 = Type.New()
    let WorldViewProjectionInverseParamMatrix4 = Type.New()
    let WorldViewProjectionTransposeParamMatrix4 = Type.New()
    let WorldViewProjectionInverseTransposeParamMatrix4 = Type.New()
    let WorldParamMatrix4 = Type.New()
    let WorldInverseParamMatrix4 = Type.New()
    let WorldTransposeParamMatrix4 = Type.New()
    let WorldInverseTransposeParamMatrix4 = Type.New()
    let canvas_CanvasInfo' = Type.New()
    let debug_DebugHelper' = Type.New()
    let debug_DebugLine' = Type.New()
    let particles_ParticleEmitter' = Type.New()
    let particles_Trail' = Type.New()
    let particles_OneShot' = Type.New()
    let picking_PickInfo' = Type.New()
    let simple_SimpleInfo' = Type.New()

    //////// O3D ////////

    let Float2 = T<float * float>
    let Float3 = T<float * float * float>
    let Float4 = T<float * float * float * float>
    let FloatN = Type.ArrayOf T<float>
    let Matrix = Type.ArrayOf (Type.ArrayOf T<float>)
    let Matrix2 = T<(float * float) *
                    (float * float)>
    let Matrix3 = T<(float * float * float) *
                    (float * float * float) *
                    (float * float * float)>
    let Matrix4 = T<(float * float * float * float) *
                    (float * float * float * float) *
                    (float * float * float * float) *
                    (float * float * float * float)>
    let BoundingBox = Matrix3
    let Quat = Float4

    let ObjectBaseClass =
        Class "o3d.ObjectBase"
        |=> ObjectBase
        |+> Protocol
            [
                "isAClassName" => T<string> ^-> T<bool>
                "className" =? T<string>
                "clientId" =? T<int>
            ]

    let NamedObjectBaseClass =
        ClassWithInitArgs "o3d.NamedObjectBase"
            [
                "name", T<string>
            ]
        |=> NamedObjectBase
        |=> Inherits ObjectBase

    let NamedObjectClass =
        Class "o3d.NamedObject"
        |=> NamedObject
        |=> Inherits NamedObjectBase

    let ParamClass =
        Class "o3d.Param"
        |=> Inherits NamedObjectBase
        |=> Param
        |+> Protocol
            [
                "bind" => Param ^-> T<bool>
                "unbindInput" => T<unit> ^-> T<unit>
                "unbindOutput" => Param ^-> T<unit>
                "unbindOutputs" => T<unit> ^-> T<unit>
                "inputConnection" =? Param
                "outputConnections" =? Type.ArrayOf Param
                "readOnly" => T<bool>
                "updateInput" => T<bool>
                "value" =% T<obj>
            ]

    let ParamTypeClass =
        ConstantStringsType "o3d.ParamType" [
                "o3d.ParamBoolean"
                "o3d.ParamBoundingBox"
                "o3d.ParamDrawContext"
                "o3d.ParamDrawList"
                "o3d.ParamEffect"
                "o3d.ParamFloat"
                "o3d.ParamFloat2"
                "o3d.ParamFloat3"
                "o3d.ParamFloat4"
                "o3d.ParamFunction"
                "o3d.ParamInteger"
                "o3d.ParamMaterial"
                "o3d.ParamMatrix4"
                "o3d.ParamParamArray"
                "o3d.ParamRenderSurface"
                "o3d.ParamRenderDepthStencilSurface"
                "o3d.ParamSampler"
                "o3d.ParamSkin"
                "o3d.ParamStreamBank"
                "o3d.ParamState"
                "o3d.ParamString"
                "o3d.ParamTexture"
                "o3d.ParamTransform"
                "o3d.ProjectionParamMatrix4"
                "o3d.ProjectionInverseParamMatrix4"
                "o3d.ProjectionTransposeParamMatrix4"
                "o3d.ProjectionInverseTransposeParamMatrix4"
                "o3d.ViewParamMatrix4"
                "o3d.ViewInverseParamMatrix4"
                "o3d.ViewTransposeParamMatrix4"
                "o3d.ViewInverseTransposeParamMatrix4"
                "o3d.ViewProjectionParamMatrix4"
                "o3d.ViewProjectionInverseParamMatrix4"
                "o3d.ViewProjectionTransposeParamMatrix4"
                "o3d.ViewProjectionInverseTransposeParamMatrix4"
                "o3d.WorldParamMatrix4"
                "o3d.WorldInverseParamMatrix4"
                "o3d.WorldTransposeParamMatrix4"
                "o3d.WorldInverseTransposeParamMatrix4"
                "o3d.WorldViewParamMatrix4"
                "o3d.WorldViewInverseParamMatrix4"
                "o3d.WorldViewTransposeParamMatrix4"
                "o3d.WorldViewInverseTransposeParamMatrix4"
                "o3d.WorldViewProjectionParamMatrix4"
                "o3d.WorldViewProjectionInverseParamMatrix4"
                "o3d.WorldViewProjectionTransposeParamMatrix4"
                "o3d.WorldViewProjectionInverseTransposeParamMatrix4"
            ]
        |=> ParamType

    let ParamOf = Generic / fun t ->
        Class "Param"
        |=> Inherits Param
        |+> Protocol
            [
                "value" =% t
            ]

    let ParamObjectClass =
        Class "o3d.ParamObject"
        |=> ParamObject
        |=> Inherits NamedObject
        |+> Protocol
            [
                "copyParams" => ParamObject ^-> T<unit>
                "createParam" => T<string> * ParamType ^-> Param
                "createParamBoolean" => T<string> ^-> ParamOf T<bool>
                |> WithInline "$this.createParam($1, 'o3d.ParamBoolean')"
                "createParamBoundingBox" => T<string> ^-> ParamOf BoundingBox
                |> WithInline "$this.createParam($1, 'o3d.ParamBoundingBox')"
                "createParamDrawContext" => T<string> ^-> ParamOf DrawContext
                |> WithInline "$this.createParam($1, 'o3d.ParamDrawContext')"
                "createParamDrawList" => T<string> ^-> ParamOf DrawList
                |> WithInline "$this.createParam($1, 'o3d.ParamDrawList')"
                "createParamEffect" => T<string> ^-> ParamOf Effect
                |> WithInline "$this.createParam($1, 'o3d.ParamEffect')"
                "createParamFloat" => T<string> ^-> ParamOf T<float>
                |> WithInline "$this.createParam($1, 'o3d.ParamFloat')"
                "createParamFloat2" => T<string> ^-> ParamOf Float2
                |> WithInline "$this.createParam($1, 'o3d.ParamFloat2')"
                "createParamFloat3" => T<string> ^-> ParamOf Float3
                |> WithInline "$this.createParam($1, 'o3d.ParamFloat3')"
                "createParamFloat4" => T<string> ^-> ParamOf Float4
                |> WithInline "$this.createParam($1, 'o3d.ParamFloat4')"
                "createParamFunction" => T<string> ^-> ParamOf Function
                |> WithInline "$this.createParam($1, 'o3d.ParamFunction')"
                "createParamInteger" => T<string> ^-> ParamOf T<int>
                |> WithInline "$this.createParam($1, 'o3d.ParamInteger')"
                "createParamMaterial" => T<string> ^-> ParamOf Material
                |> WithInline "$this.createParam($1, 'o3d.ParamMaterial')"
                "createParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.ParamMatrix4')"
                "createParamParamArray" => T<string> ^-> ParamOf ParamArray
                |> WithInline "$this.createParam($1, 'o3d.ParamParamArray')"
                "createParamRenderSurface" => T<string> ^-> ParamOf RenderSurface
                |> WithInline "$this.createParam($1, 'o3d.ParamRenderSurface')"
                "createParamRenderDepthStencilSurface" => T<string> ^-> ParamOf RenderDepthStencilSurface
                |> WithInline "$this.createParam($1, 'o3d.ParamRenderDepthStencilSurface')"
                "createParamSampler" => T<string> ^-> ParamOf Sampler
                |> WithInline "$this.createParam($1, 'o3d.ParamSampler')"
                "createParamSkin" => T<string> ^-> ParamOf Skin
                |> WithInline "$this.createParam($1, 'o3d.ParamSkin')"
                "createParamStreamBank" => T<string> ^-> ParamOf StreamBank
                |> WithInline "$this.createParam($1, 'o3d.ParamStreamBank')"
                "createParamState" => T<string> ^-> ParamOf State
                |> WithInline "$this.createParam($1, 'o3d.ParamState')"
                "createParamString" => T<string> ^-> ParamOf T<string>
                |> WithInline "$this.createParam($1, 'o3d.ParamString')"
                "createParamTexture" => T<string> ^-> ParamOf Texture
                |> WithInline "$this.createParam($1, 'o3d.ParamTexture')"
                "createParamTransform" => T<string> ^-> ParamOf Transform
                |> WithInline "$this.createParam($1, 'o3d.ParamTransform')"

                "createProjectionParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.ProjectionParamMatrix4')"
                "createProjectionInverseParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.ProjectionInverseParamMatrix4')"
                "createProjectionTransposeParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.ProjectionTransposeParamMatrix4')"
                "createProjectionInverseTransposeParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.ProjectionInverseTransposeParamMatrix4')"
                "createViewParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.ViewParamMatrix4')"
                "createViewInverseParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.ViewInverseParamMatrix4')"
                "createViewTransposeParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.ViewTransposeParamMatrix4')"
                "createViewInverseTransposeParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.ViewInverseTransposeParamMatrix4')"
                "createViewProjectionParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.ViewProjectionParamMatrix4')"
                "createViewProjectionInverseParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.ViewProjectionInverseParamMatrix4')"
                "createViewProjectionTransposeParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.ViewProjectionTransposeParamMatrix4')"
                "createViewProjectionInverseTransposeParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.ViewProjectionInverseTransposeParamMatrix4')"
                "createWorldParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.WorldParamMatrix4')"
                "createWorldInverseParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.WorldInverseParamMatrix4')"
                "createWorldTransposeParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.WorldTransposeParamMatrix4')"
                "createWorldInverseTransposeParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.WorldInverseTransposeParamMatrix4')"
                "createWorldViewParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.WorldViewParamMatrix4')"
                "createWorldViewInverseParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.WorldViewInverseParamMatrix4')"
                "createWorldViewTransposeParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.WorldViewTransposeParamMatrix4')"
                "createWorldViewInverseTransposeParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.WorldViewInverseTransposeParamMatrix4')"
                "createWorldViewProjectionParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.WorldViewProjectionParamMatrix4')"
                "createWorldViewProjectionInverseParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.WorldViewProjectionInverseParamMatrix4')"
                "createWorldViewProjectionTransposeParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.WorldViewProjectionTransposeParamMatrix4')"
                "createWorldViewProjectionInverseTransposeParamMatrix4" => T<string> ^-> ParamOf Matrix4
                |> WithInline "$this.createParam($1, 'o3d.WorldViewProjectionInverseTransposeParamMatrix4')"


                "getParam" => T<string> ^-> Param
                "removeParam" => Param ^-> T<bool>
                "params" =? Type.ArrayOf Param
            ]

    let RawDataClass =
        Class "o3d.RawData"
        |=> RawData
        |=> Inherits ParamObject
        |+> Protocol
            [
                "discard" => T<unit> ^-> T<unit>
                "flush" => T<unit> ^-> T<unit>
                "length" => T<int>
                "stringValue" => T<string>
                "uri" => T<string>
            ]

    let ArchiveRequestClass =
        Class "o3d.ArchiveRequest"
        |=> ArchiveRequest
        |=> Inherits ObjectBase
        |+> Protocol
            [
                "open" => T<string>?method_ * T<string>?uri ^-> T<unit>
                "send" => T<unit> ^-> T<unit>
                "bytesReceived" =? T<int>
                "data" =? RawData
                "done" =? T<bool>
                "error" =? T<string>
                "onfileavailable" =! RawData ^-> T<unit>
                "onreadystatechange" =! T<unit> ^-> T<unit>
                "readyState" =? T<int>
                "streamLength" =? T<int>
                "success" =? T<bool>
                "uri" =? T<string>
            ]

    let CurveKeyClass =
        ClassWithInitArgs "o3d.CurveKey"
            [
                "input", T<float>
                "output", T<float>
            ]
        |=> CurveKey
        |=> Inherits ObjectBase
        |+> Protocol
            [
                "destroy" => T<unit> ^-> T<unit>
            ]

    let BezierCurveKeyClass =
        ClassWithInitArgs "o3d.BezierCurveKey"
            [
                "inTangent", Float2
                "outTangent", Float2
            ]
        |=> BezierCurveKey
        |=> Inherits CurveKey

    let LinearCurveKeyClass =
        Class "o3d.LinearCurveKey"
        |=> LinearCurveKey
        |=> Inherits CurveKey

    let StepCurveKeyClass =
        Class "o3d.StepCurveKey"
        |=> StepCurveKey
        |=> Inherits CurveKey

    let Bitmap_SemanticClass =
        ConstantsType "o3d.Bitmap" Bitmap_Semantic [
            "FACE_POSITIVE_X"
            "FACE_NEGATIVE_X"
            "FACE_POSITIVE_Y"
            "FACE_NEGATIVE_Y"
            "FACE_POSITIVE_Z"
            "FACE_NEGATIVE_Z"
            "IMAGE"
            "SLICE"
        ]
        |> WithSourceName "Semantic"

    let Texture_FormatClass =
        ConstantsType "o3d.Texture" Texture_Format [
            "UNKNOWN_FORMAT"
            "XRGB8"
            "ARGB8"
            "ABGR16F"
            "R32F"
            "ABGR32F"
            "DXT1"
            "DXT3"
            "DXT5"
        ]
        |> WithSourceName "Format"

    let TextureClass =
        Class "o3d.Texture"
        |=> Texture
        |=> Inherits ParamObject
        |=> Nested [Texture_FormatClass]
        |+> Protocol
            [
                "generateMips" => T<int> * T<int> ^-> T<unit>
                "alphaIsOne" =? T<bool>
                "format" =? Texture_Format
                |> WithSourceName "format"
                "levels" =? T<int>
            ]

    let BitmapClass =
        Class "o3d.Bitmap"
        |=> Bitmap
        |=> Inherits ParamObject
        |=> Nested [Bitmap_SemanticClass]
        |+> Protocol
            [
                "flipVertically" => T<unit> ^-> T<unit>
                "generateMips" => T<int>?srclevel * T<int>?numlevels ^-> T<unit>
                "format" =? Texture_Format
                "height" =? T<int>
                "numMipmaps" =? T<int>
                "semantic" =? Bitmap_Semantic
                |> WithSourceName "semantic"
                "width" =? T<int>
            ]

    let RenderSurfaceBaseClass =
        Class "o3d.RenderSurfaceBase"
        |=> RenderSurfaceBase
        |=> Inherits ParamObject
        |+> Protocol
            [
                "height" =? T<int>
                "width" =? T<int>
            ]

    let RenderSurfaceClass =
        Class "o3d.RenderSurface"
        |=> RenderSurface
        |=> Inherits RenderSurfaceBase
        |+> Protocol
            [
                "texture" =? Texture
            ]


    let Texture2DClass =
        Class "o3d.Texture2D"
        |=> Texture2D
        |=> Inherits Texture
        |+> Protocol
            [
                "drawImage" => Bitmap?bitmap * T<int>?srclevel * T<int>?srcx * T<int>?srcy * T<int>?srcwidth * T<int>?srcheight * T<int>?dstlevel * T<int>?dstx * T<int>?dsty * T<int>?dstwidth * T<int>?dstheight ^-> T<unit>
                "drawImage" => Bitmap?bitmap * T<int>?srclevel * T<int>?srcx * T<int>?srcy * T<int>?srcwidth * T<int>?srcheight * T<int>?dstlevel * T<int>?dstx * T<int>?dsty * T<int>?dstwidth^-> T<unit>
                "drawImage" => Canvas?canvas * T<int>?srclevel * T<int>?srcx * T<int>?srcy * T<int>?srcwidth * T<int>?srcheight * T<int>?dstlevel * T<int>?dstx * T<int>?dsty * T<int>?dstwidth * T<int>?dstheight ^-> T<unit>
                "drawImage" => Canvas?canvas * T<int>?srclevel * T<int>?srcx * T<int>?srcy * T<int>?srcwidth * T<int>?srcheight * T<int>?dstlevel * T<int>?dstx * T<int>?dsty * T<int>?dstwidth^-> T<unit>
                "getRect" => T<int>?level * T<int>?x * T<int>?y * T<int>?width * T<int>?height ^-> Type.ArrayOf T<float>
                "getRenderSurface" => T<int>?level ^-> RenderSurface
                "set" => T<int>?level * (Type.ArrayOf T<float>)?data ^-> T<unit>
                "setFromBitmap" => Bitmap?source ^-> T<unit>
                "setRect" => T<int>?level * T<int>?dstx * T<int>?dsty * T<int>?srcwidth * (Type.ArrayOf T<float>)?data ^-> T<unit>
                "height" =? T<int>
                "width" =? T<int>
            ]

    let TextureCUBE_CubeFaceClass =
        ConstantsType "o3d.TextureCUBE" TextureCUBE_CubeFace [
            "FACE_POSITIVE_X"
            "FACE_NEGATIVE_X"
            "FACE_POSITIVE_Y"
            "FACE_NEGATIVE_Y"
            "FACE_POSITIVE_Z"
            "FACE_NEGATIVE_Z"
        ]
        |> WithSourceName "CubeFace"

    let TextureCUBEClass =
        Class "o3d.TextureCUBE"
        |=> TextureCUBE
        |=> Inherits Texture
        |+> Protocol
            [
                "drawImage" => Bitmap?bitmap * T<int>?srclevel * T<int>?srcx * T<int>?srcy * T<int>?srcwidth * T<int>?srcheight * T<int>?face * T<int>?dstlevel * T<int>?dstx * T<int>?dsty * T<int>?dstwidth * T<int>?dstheight ^-> T<unit>
                "drawImage" => Bitmap?bitmap * T<int>?srclevel * T<int>?srcx * T<int>?srcy * T<int>?srcwidth * T<int>?srcheight * T<int>?face * T<int>?dstlevel * T<int>?dstx * T<int>?dsty * T<int>?dstwidth^-> T<unit>
                "drawImage" => Canvas?canvas * T<int>?srclevel * T<int>?srcx * T<int>?srcy * T<int>?srcwidth * T<int>?srcheight * T<int>?face * T<int>?dstlevel * T<int>?dstx * T<int>?dsty * T<int>?dstwidth * T<int>?dstheight ^-> T<unit>
                "drawImage" => Canvas?canvas * T<int>?srclevel * T<int>?srcx * T<int>?srcy * T<int>?srcwidth * T<int>?srcheight * T<int>?face * T<int>?dstlevel * T<int>?dstx * T<int>?dsty * T<int>?dstwidth^-> T<unit>
                "getRect" => TextureCUBE_CubeFace?face * T<int>?level * T<int>?x * T<int>?y * T<int>?width * T<int>?height ^-> Type.ArrayOf T<float>
                "getRenderSurface" => TextureCUBE_CubeFace?face * T<int>?level ^-> RenderSurface
                "set" => TextureCUBE_CubeFace?face * T<int>?level * Type.ArrayOf T<float> ^-> T<unit>
                "setFromBitmap" => TextureCUBE_CubeFace * Bitmap ^-> T<unit>
                "setRect" => TextureCUBE_CubeFace?face * T<int>?level * T<int>?dstx * T<int>?dsty * T<int>?srcwidth * Type.ArrayOf T<float> ^-> T<unit>
                "edgeLength" =? T<int>
            ]


    let FieldTypeClass =
        ConstantStringsType "o3d.FieldType" [
                "FloatField"
                "UInt32Field"
                "UByteNField"
            ]
        |=> FieldType

    let FloatFieldClass =
        Class "o3d.FloatField"
        |=> FloatField
        |=> Inherits Field
        |+> Protocol
            [
                "getAt" => T<int>?startIndex * T<int>?numElements ^-> Type.ArrayOf T<float>
                "setAt" => T<int>?startIndex * (Type.ArrayOf T<float>)?data ^-> T<unit>
            ]

    let UByteNFieldClass =
        Class "UByteNField"
        |=> UByteNField
        |+> Protocol
            [
                "getAt" => T<int>?start * T<int>?count ^-> Type.ArrayOf T<int>
                "setAt" => T<int>?start * (Type.ArrayOf T<int>)?data ^-> T<unit>
            ]

    let UInt32FieldClass =
        Class "UInt32Field"
        |=> UInt32Field
        |+> Protocol
            [
                "getAt" => T<int>?start * T<int>?count ^-> Type.ArrayOf T<int>
                "setAt" => T<int>?start * (Type.ArrayOf T<int>)?data ^-> T<unit>
            ]

    let BufferClass =
        Class "o3d.Buffer"
        |=> Buffer
        |=> Inherits NamedObject
        |+> Protocol
            [
                "allocateElements" => T<int> ^-> T<bool>
                "createField" => FieldType * T<int> ^-> Field
                "createUByteNField" => T<int> ^-> UByteNField
                |> WithInline "$this.createField('UByteNField', $1)"
                "createFloatField" => T<int> ^-> FloatField
                |> WithInline "$this.createField('FloatField', $1)"
                "createUInt32Field" => T<int> ^-> UInt32Field
                |> WithInline "$this.createField('UInt32Field', $1)"
                "removeField" => Field ^-> T<unit>
                "set" => RawData?data * T<int>?srcoffset * T<int>?length ^-> T<unit>
                "set" => RawData?data * T<int>?srcoffset ^-> T<unit>
                "set" => RawData ^-> T<unit>
                "fields" =? Type.ArrayOf Field
                "numElements" =? T<int>
                "totalComponents" =? T<int>
            ]

    let CanvasFontMetricsClass =
        Class "o3d.CanvasFontMetrics"
        |=> CanvasFontMetrics
        |+> Protocol
            [
                "ascent" =? T<float>
                "bottom" =? T<float>
                "descent" =? T<float>
                "leading" =? T<float>
                "top" =? T<float>
            ]

    let CanvasPaint_StyleClass =
        ConstantsType "o3d.CanvasPaint" CanvasPaint_Style [
            "NORMAL"
            "BOLD"
            "ITALIC"
            "BOLD_ITALIC"
        ]
        |> WithSourceName "Style"

    let CanvasPaint_TextAlignClass =
        ConstantsType "o3d.CanvasPaint" CanvasPaint_TextAlign [
            "LEFT"
            "CENTER"
            "RIGHT"
        ]
        |> WithSourceName "TextAlign"

    let CanvasShader_TileModeClass =
        ConstantsType "o3d.CanvasShader" CanvasShader_TileMode [
            "CLAMP"
            "REPEAT"
            "MIRROR"
        ]
        |> WithSourceName "TileMode"

    let CanvasShaderClass =
        Class "o3d.CanvasShader"
        |=> CanvasShader
        |=> Inherits ParamObject
        |+> Protocol
            [
            ]

    let CanvasPaintClass =
        ClassWithInitArgs "o3d.CanvasPaint"
            [
                "color", Float4
                "shader", CanvasShader
                "textAlign", CanvasPaint_TextAlign
                "textSize", T<int>
                "textStyle", CanvasPaint_Style
                "textTypeface", T<string>
            ]
        |=> CanvasPaint
        |=> Inherits ParamObject
        |+> Protocol
            [
                "getFontMetrics" => T<unit> ^-> CanvasFontMetrics
                "measureText" => T<string> ^-> Float4
                "setOutline" => T<float>?radius * Float4?color ^-> T<unit>
                "setShadow" => T<float>?radius * T<float>?offsetx * T<float>?offsety * Float4?color ^-> T<unit>
            ]

    let CanvasClass =
        Class "o3d.Canvas"
        |=> Inherits ParamObject
        |=> Canvas
        |+> Protocol
            [
                "clear" => Float4 ^-> T<unit>
                "copyToTexture" => Texture2D ^-> T<unit>
                "drawBitmap" => Texture2D?texture * T<int>?left * T<int>?bottom ^-> T<unit>
                "drawRect" => T<int>?left * T<int>?top * T<int>?right * T<int>?bottom * CanvasPaint?paint ^-> T<unit>
                "drawText" => T<string>?text * T<int>?x * T<int>?y * CanvasPaint?paint ^-> T<unit>
                "drawTextOnPath" => T<string>?text * (Type.ArrayOf Float2)?positions * T<int>?hoffset * T<int>?voffset * CanvasPaint?paint ^-> T<unit>
                "restoreMatrix" => T<unit> ^-> T<unit>
                "rotate" => T<float>?degrees ^-> T<unit>
                "saveMatrix" => T<unit> ^-> T<unit>
                "scale" => T<float>?sx * T<float>?sy ^-> T<unit>
                "setSize" => T<int>?width * T<int>?height ^-> T<unit>
                "translate" => T<float>?dx * T<float>?dy ^-> T<unit>
                "height" =? T<int>
                "width" =? T<int>
            ]

    let CanvasLinearGradientClass =
        ClassWithInitArgs "o3d.CanvasLinearGradient"
            [
                "colors", Type.ArrayOf Float4
                "endPoint", Float2
                "positions", Type.ArrayOf T<int>
                "startPoint", Float2
                "tileMode", CanvasShader_TileMode
            ]
        |=> CanvasLinearGradient
        |=> Inherits CanvasShader

    let RenderNodeClass =
        ClassWithInitArgs "o3d.RenderNode"
            [
                "active", T<bool>
                "priority", T<float>
                "parent", RenderNode
            ]
        |=> RenderNode
        |=> Inherits ParamObject
        |+> Protocol
            [
                "getRenderNodesByClassNameInTree" => T<string> ^-> Type.ArrayOf RenderNode
                "getRenderNodesByNameInTree" => T<string> ^-> Type.ArrayOf RenderNode
                "getRenderNodesInTree" => T<unit> ^-> Type.ArrayOf RenderNode
                "children" =? Type.ArrayOf RenderNode
            ]

    let ClearBufferClass =
        ClassWithInitArgs "o3d.ClearBuffer"
            [
                "clearColor", Float4
                "clearColorFlag", T<bool>
                "clearDepth", T<float>
                "clearDepthFlag", T<bool>
                "clearStencil", T<int>
                "clearStencilFlag", T<bool>
            ]
        |=> ClearBuffer
        |=> Inherits RenderNode

    let Client_RenderModeClass =
        ConstantsType "o3d.Client" Client_RenderMode [
            "RENDERMODE_CONTINUOUS"
            "RENDERMODE_ON_DEMAND"
        ]
        |> WithSourceName "RenderMode"

    let RenderDepthStencilSurfaceClass =
        Class "o3d.RenderDepthStencilSurface"
        |=> RenderDepthStencilSurface
        |=> Inherits RenderSurfaceBase

    let FileRequestTypeClass =
        ConstantStringsType "o3d.FileRequestType" [
            "TEXTURE"
            "RAWDATA"
        ]

    let FileRequestClass =
        Class "o3d.FileRequest"
        |=> FileRequest
        |=> Inherits ObjectBase
        |+> Protocol
            [
                "open" => T<string>?method_ * T<string>?uri * T<bool>?async ^-> T<unit>
                "send" => T<unit> ^-> T<unit>
                "data" =? RawData
                "done" =? T<bool>
                "error" =? T<string>
                "generateMipmaps" =? T<bool>
                "onreadystatechange" =! T<unit -> unit>
                "readyState" =? T<int>
                "success" =? T<bool>
                "texture" =? Texture
                "uri" =? T<string>
            ]

    let ObjectTypeClass =
        ConstantStringsType "o3d.ObjectType" [
            "o3d.Bitmap"
            "o3d.Canvas"
            "o3d.CanvasLinearGradient"
            "o3d.CanvasPaint"
            "o3d.ClearBuffer"
            "o3d.Counter"
            "o3d.Curve"
            "o3d.DrawContext"
            "o3d.DrawElement"
            "o3d.DrawList"
            "o3d.DrawPass"
            "o3d.Effect"
            "o3d.FunctionEval"
            "o3d.IndexBuffer"
            "o3d.Material"
            "o3d.ParamArray"
            "o3d.ParamObject"
            "o3d.Primitive"
            "o3d.RenderFrameCounter"
            "o3d.RenderNode"
            "o3d.RenderSurfaceSet"
            "o3d.Sampler"
            "o3d.SecondCounter"
            "o3d.Shape"
            "o3d.Skin"
            "o3d.SkinEval"
            "o3d.SourceBuffer"
            "o3d.State"
            "o3d.StateSet"
            "o3d.StreamBank"
            "o3d.Texture2D"
            "o3d.TextureCUBE"
            "o3d.TickCounter"
            "o3d.Transform"
            "o3d.TreeTraversal"
            "o3d.VertexBuffer"
            "o3d.Viewport"
            "o3d.Matrix4AxisRotation"
            "o3d.Matrix4Composition"
            "o3d.Matrix4Scale"
            "o3d.Matrix4Translation"
            "o3d.ParamOp2FloatsToFloat2"
            "o3d.ParamOp3FloatsToFloat3"
            "o3d.ParamOp4FloatsToFloat4"
            "o3d.ParamOp16FloatsToMatrix4"
            "o3d.TRSToMatrix4"
        ]
        |=> ObjectType

    let PackClass =
        Class "o3d.Pack"
        |=> Pack
        |=> Inherits NamedObject
        |+> Protocol
            [
                "createArchiveRequest" => T<unit> ^-> ArchiveRequest
                "createBitmapsFromRawData" => RawData ^-> Bitmap
                "createDepthStencilSurface" => T<int>?width * T<int>?height ^-> RenderDepthStencilSurface
                "createFileRequest" => FileRequestType ^-> FileRequest
                "createObject" => ObjectType ^-> ObjectBase // TODO: individual methods ?
                "createBitmap" => T<unit> ^-> Bitmap
                |> WithInline "$this.createObject('o3d.Bitmap')"
                "createCanvas" => T<unit> ^-> Canvas
                |> WithInline "$this.createObject('o3d.Canvas')"
                "createCanvasLinearGradient" => T<unit> ^-> CanvasLinearGradient
                |> WithInline "$this.createObject('o3d.CanvasLinearGradient')"
                "createCanvasPaint" => T<unit> ^-> CanvasPaint
                |> WithInline "$this.createObject('o3d.CanvasPaint')"
                "createClearBuffer" => T<unit> ^-> ClearBuffer
                |> WithInline "$this.createObject('o3d.ClearBuffer')"
                "createCounter" => T<unit> ^-> Counter
                |> WithInline "$this.createObject('o3d.Counter')"
                "createCurve" => T<unit> ^-> Curve
                |> WithInline "$this.createObject('o3d.Curve')"
                "createDrawContext" => T<unit> ^-> DrawContext
                |> WithInline "$this.createObject('o3d.DrawContext')"
                "createDrawElement" => T<unit> ^-> DrawElement
                |> WithInline "$this.createObject('o3d.DrawElement')"
                "createDrawList" => T<unit> ^-> DrawList
                |> WithInline "$this.createObject('o3d.DrawList')"
                "createDrawPass" => T<unit> ^-> DrawPass
                |> WithInline "$this.createObject('o3d.DrawPass')"
                "createEffect" => T<unit> ^-> Effect
                |> WithInline "$this.createObject('o3d.Effect')"
                "createFunctionEval" => T<unit> ^-> FunctionEval
                |> WithInline "$this.createObject('o3d.FunctionEval')"
                "createIndexBuffer" => T<unit> ^-> IndexBuffer
                |> WithInline "$this.createObject('o3d.IndexBuffer')"
                "createMaterial" => T<unit> ^-> Material
                |> WithInline "$this.createObject('o3d.Material')"
                "createParamArray" => T<unit> ^-> ParamArray
                |> WithInline "$this.createObject('o3d.ParamArray')"
                "createParamObject" => T<unit> ^-> ParamObject
                |> WithInline "$this.createObject('o3d.ParamObject')"
                "createPrimitive" => T<unit> ^-> Primitive
                |> WithInline "$this.createObject('o3d.Primitive')"
                "createRenderFrameCounter" => T<unit> ^-> RenderFrameCounter
                |> WithInline "$this.createObject('o3d.RenderFrameCounter')"
                "createRenderNode" => T<unit> ^-> RenderNode
                |> WithInline "$this.createObject('o3d.RenderNode')"
                "createRenderSurfaceSet" => T<unit> ^-> RenderSurfaceSet
                |> WithInline "$this.createObject('o3d.RenderSurfaceSet')"
                "createSampler" => T<unit> ^-> Sampler
                |> WithInline "$this.createObject('o3d.Sampler')"
                "createSecondCounter" => T<unit> ^-> SecondCounter
                |> WithInline "$this.createObject('o3d.SecondCounter')"
                "createShape" => T<unit> ^-> Shape
                |> WithInline "$this.createObject('o3d.Shape')"
                "createSkin" => T<unit> ^-> Skin
                |> WithInline "$this.createObject('o3d.Skin')"
                "createSkinEval" => T<unit> ^-> SkinEval
                |> WithInline "$this.createObject('o3d.SkinEval')"
                "createSourceBuffer" => T<unit> ^-> SourceBuffer
                |> WithInline "$this.createObject('o3d.SourceBuffer')"
                "createState" => T<unit> ^-> State
                |> WithInline "$this.createObject('o3d.State')"
                "createStateSet" => T<unit> ^-> StateSet
                |> WithInline "$this.createObject('o3d.StateSet')"
                "createStreamBank" => T<unit> ^-> StreamBank
                |> WithInline "$this.createObject('o3d.StreamBank')"
                "createTexture2D" => T<unit> ^-> Texture2D
                |> WithInline "$this.createObject('o3d.Texture2D')"
                "createTextureCUBE" => T<unit> ^-> TextureCUBE
                |> WithInline "$this.createObject('o3d.TextureCUBE')"
                "createTickCounter" => T<unit> ^-> TickCounter
                |> WithInline "$this.createObject('o3d.TickCounter')"
                "createTransform" => T<unit> ^-> Transform
                |> WithInline "$this.createObject('o3d.Transform')"
                "createTreeTraversal" => T<unit> ^-> TreeTraversal
                |> WithInline "$this.createObject('o3d.TreeTraversal')"
                "createVertexBuffer" => T<unit> ^-> VertexBuffer
                |> WithInline "$this.createObject('o3d.VertexBuffer')"
                "createViewport" => T<unit> ^-> Viewport
                |> WithInline "$this.createObject('o3d.Viewport')"
                "createMatrix4AxisRotation" => T<unit> ^-> Matrix4AxisRotation
                |> WithInline "$this.createObject('o3d.Matrix4AxisRotation')"
                "createMatrix4Composition" => T<unit> ^-> Matrix4Composition
                |> WithInline "$this.createObject('o3d.Matrix4Composition')"
                "createMatrix4Scale" => T<unit> ^-> Matrix4Scale
                |> WithInline "$this.createObject('o3d.Matrix4Scale')"
                "createMatrix4Translation" => T<unit> ^-> Matrix4Translation
                |> WithInline "$this.createObject('o3d.Matrix4Translation')"
                "createParamOp2FloatsToFloat2" => T<unit> ^-> ParamOp2FloatsToFloat2
                |> WithInline "$this.createObject('o3d.ParamOp2FloatsToFloat2')"
                "createParamOp3FloatsToFloat3" => T<unit> ^-> ParamOp3FloatsToFloat3
                |> WithInline "$this.createObject('o3d.ParamOp3FloatsToFloat3')"
                "createParamOp4FloatsToFloat4" => T<unit> ^-> ParamOp4FloatsToFloat4
                |> WithInline "$this.createObject('o3d.ParamOp4FloatsToFloat4')"
                "createParamOp16FloatsToMatrix4" => T<unit> ^-> ParamOp16FloatsToMatrix4
                |> WithInline "$this.createObject('o3d.ParamOp16FloatsToMatrix4')"
                "createTRSToMatrix4" => T<unit> ^-> TRSToMatrix4
                |> WithInline "$this.createObject('o3d.TRSToMatrix4')"
                "createRawDataFromDataUrl" => T<string> ^-> RawData
                "createTexture2D" => T<int>?width * T<int>?height * Texture_Format?format * T<int>?levels * T<bool>?enableRenderSurfaces ^-> Texture2D
                "createTextureCUBE" => T<int>?edgeLength * Texture_Format?format * T<int>?levels * T<bool>?enableRenderSurface ^-> TextureCUBE
                "createTextureFromRawData" => RawData?data * T<bool>?generateMips ^-> Texture
                "destroy" => T<unit> ^-> T<unit>
                "getObjects" => T<string>?name * ObjectType?type_ ^-> Type.ArrayOf ObjectBase // TODO : individual methods?
                "getBitmaps" => T<string>?name ^-> Type.ArrayOf Bitmap
                |> WithInline "$this.getObjects($name, 'o3d.Bitmap')"
                "getCanvases" => T<string>?name ^-> Type.ArrayOf Canvas
                |> WithInline "$this.getObjects($name, 'o3d.Canvas')"
                "getCanvasLinearGradients" => T<string>?name ^-> Type.ArrayOf CanvasLinearGradient
                |> WithInline "$this.getObjects($name, 'o3d.CanvasLinearGradient')"
                "getCanvasPaints" => T<string>?name ^-> Type.ArrayOf CanvasPaint
                |> WithInline "$this.getObjects($name, 'o3d.CanvasPaint')"
                "getClearBuffers" => T<string>?name ^-> Type.ArrayOf ClearBuffer
                |> WithInline "$this.getObjects($name, 'o3d.ClearBuffer')"
                "getCounters" => T<string>?name ^-> Type.ArrayOf Counter
                |> WithInline "$this.getObjects($name, 'o3d.Counter')"
                "getCurves" => T<string>?name ^-> Type.ArrayOf Curve
                |> WithInline "$this.getObjects($name, 'o3d.Curve')"
                "getDrawContexts" => T<string>?name ^-> Type.ArrayOf DrawContext
                |> WithInline "$this.getObjects($name, 'o3d.DrawContext')"
                "getDrawElements" => T<string>?name ^-> Type.ArrayOf DrawElement
                |> WithInline "$this.getObjects($name, 'o3d.DrawElement')"
                "getDrawLists" => T<string>?name ^-> Type.ArrayOf DrawList
                |> WithInline "$this.getObjects($name, 'o3d.DrawList')"
                "getDrawPasses" => T<string>?name ^-> Type.ArrayOf DrawPass
                |> WithInline "$this.getObjects($name, 'o3d.DrawPass')"
                "getEffects" => T<string>?name ^-> Type.ArrayOf Effect
                |> WithInline "$this.getObjects($name, 'o3d.Effect')"
                "getFunctionEvals" => T<string>?name ^-> Type.ArrayOf FunctionEval
                |> WithInline "$this.getObjects($name, 'o3d.FunctionEval')"
                "getIndexBuffers" => T<string>?name ^-> Type.ArrayOf IndexBuffer
                |> WithInline "$this.getObjects($name, 'o3d.IndexBuffer')"
                "getMaterials" => T<string>?name ^-> Type.ArrayOf Material
                |> WithInline "$this.getObjects($name, 'o3d.Material')"
                "getParamArrays" => T<string>?name ^-> Type.ArrayOf ParamArray
                |> WithInline "$this.getObjects($name, 'o3d.ParamArray')"
                "getParamObjects" => T<string>?name ^-> Type.ArrayOf ParamObject
                |> WithInline "$this.getObjects($name, 'o3d.ParamObject')"
                "getPrimitives" => T<string>?name ^-> Type.ArrayOf Primitive
                |> WithInline "$this.getObjects($name, 'o3d.Primitive')"
                "getRenderFrameCounters" => T<string>?name ^-> Type.ArrayOf RenderFrameCounter
                |> WithInline "$this.getObjects($name, 'o3d.RenderFrameCounter')"
                "getRenderNodes" => T<string>?name ^-> Type.ArrayOf RenderNode
                |> WithInline "$this.getObjects($name, 'o3d.RenderNode')"
                "getRenderSurfaceSets" => T<string>?name ^-> Type.ArrayOf RenderSurfaceSet
                |> WithInline "$this.getObjects($name, 'o3d.RenderSurfaceSet')"
                "getSamplers" => T<string>?name ^-> Type.ArrayOf Sampler
                |> WithInline "$this.getObjects($name, 'o3d.Sampler')"
                "getSecondCounters" => T<string>?name ^-> Type.ArrayOf SecondCounter
                |> WithInline "$this.getObjects($name, 'o3d.SecondCounter')"
                "getShapes" => T<string>?name ^-> Type.ArrayOf Shape
                |> WithInline "$this.getObjects($name, 'o3d.Shape')"
                "getSkins" => T<string>?name ^-> Type.ArrayOf Skin
                |> WithInline "$this.getObjects($name, 'o3d.Skin')"
                "getSkinEvals" => T<string>?name ^-> Type.ArrayOf SkinEval
                |> WithInline "$this.getObjects($name, 'o3d.SkinEval')"
                "getSourceBuffers" => T<string>?name ^-> Type.ArrayOf SourceBuffer
                |> WithInline "$this.getObjects($name, 'o3d.SourceBuffer')"
                "getStates" => T<string>?name ^-> Type.ArrayOf State
                |> WithInline "$this.getObjects($name, 'o3d.State')"
                "getStateSets" => T<string>?name ^-> Type.ArrayOf StateSet
                |> WithInline "$this.getObjects($name, 'o3d.StateSet')"
                "getStreamBanks" => T<string>?name ^-> Type.ArrayOf StreamBank
                |> WithInline "$this.getObjects($name, 'o3d.StreamBank')"
                "getTexture2Ds" => T<string>?name ^-> Type.ArrayOf Texture2D
                |> WithInline "$this.getObjects($name, 'o3d.Texture2D')"
                "getTextureCUBEs" => T<string>?name ^-> Type.ArrayOf TextureCUBE
                |> WithInline "$this.getObjects($name, 'o3d.TextureCUBE')"
                "getTickCounters" => T<string>?name ^-> Type.ArrayOf TickCounter
                |> WithInline "$this.getObjects($name, 'o3d.TickCounter')"
                "getTransforms" => T<string>?name ^-> Type.ArrayOf Transform
                |> WithInline "$this.getObjects($name, 'o3d.Transform')"
                "getTreeTraversals" => T<string>?name ^-> Type.ArrayOf TreeTraversal
                |> WithInline "$this.getObjects($name, 'o3d.TreeTraversal')"
                "getVertexBuffers" => T<string>?name ^-> Type.ArrayOf VertexBuffer
                |> WithInline "$this.getObjects($name, 'o3d.VertexBuffer')"
                "getViewports" => T<string>?name ^-> Type.ArrayOf Viewport
                |> WithInline "$this.getObjects($name, 'o3d.Viewport')"
                "getMatrix4AxisRotations" => T<string>?name ^-> Type.ArrayOf Matrix4AxisRotation
                |> WithInline "$this.getObjects($name, 'o3d.Matrix4AxisRotation')"
                "getMatrix4Compositions" => T<string>?name ^-> Type.ArrayOf Matrix4Composition
                |> WithInline "$this.getObjects($name, 'o3d.Matrix4Composition')"
                "getMatrix4Scales" => T<string>?name ^-> Type.ArrayOf Matrix4Scale
                |> WithInline "$this.getObjects($name, 'o3d.Matrix4Scale')"
                "getMatrix4Translations" => T<string>?name ^-> Type.ArrayOf Matrix4Translation
                |> WithInline "$this.getObjects($name, 'o3d.Matrix4Translation')"
                "getParamOp2FloatsToFloat2s" => T<string>?name ^-> Type.ArrayOf ParamOp2FloatsToFloat2
                |> WithInline "$this.getObjects($name, 'o3d.ParamOp2FloatsToFloat2')"
                "getParamOp3FloatsToFloat3s" => T<string>?name ^-> Type.ArrayOf ParamOp3FloatsToFloat3
                |> WithInline "$this.getObjects($name, 'o3d.ParamOp3FloatsToFloat3')"
                "getParamOp4FloatsToFloat4s" => T<string>?name ^-> Type.ArrayOf ParamOp4FloatsToFloat4
                |> WithInline "$this.getObjects($name, 'o3d.ParamOp4FloatsToFloat4')"
                "getParamOp16FloatsToMatrix4s" => T<string>?name ^-> Type.ArrayOf ParamOp16FloatsToMatrix4
                |> WithInline "$this.getObjects($name, 'o3d.ParamOp16FloatsToMatrix4')"
                "getTRSToMatrix4s" => T<string>?name ^-> Type.ArrayOf TRSToMatrix4
                |> WithInline "$this.getObjects($name, 'o3d.TRSToMatrix4')"
                "getObjectsByClassName" => ObjectType ^-> Type.ArrayOf ObjectBase
                "getBitmaps" => T<unit> ^-> Type.ArrayOf Bitmap
                |> WithInline "$this.getObjectsByClassName('o3d.Bitmap')"
                "getCanvases" => T<unit> ^-> Type.ArrayOf Canvas
                |> WithInline "$this.getObjectsByClassName('o3d.Canvas')"
                "getCanvasLinearGradients" => T<unit> ^-> Type.ArrayOf CanvasLinearGradient
                |> WithInline "$this.getObjectsByClassName('o3d.CanvasLinearGradient')"
                "getCanvasPaints" => T<unit> ^-> Type.ArrayOf CanvasPaint
                |> WithInline "$this.getObjectsByClassName('o3d.CanvasPaint')"
                "getClearBuffers" => T<unit> ^-> Type.ArrayOf ClearBuffer
                |> WithInline "$this.getObjectsByClassName('o3d.ClearBuffer')"
                "getCounters" => T<unit> ^-> Type.ArrayOf Counter
                |> WithInline "$this.getObjectsByClassName('o3d.Counter')"
                "getCurves" => T<unit> ^-> Type.ArrayOf Curve
                |> WithInline "$this.getObjectsByClassName('o3d.Curve')"
                "getDrawContexts" => T<unit> ^-> Type.ArrayOf DrawContext
                |> WithInline "$this.getObjectsByClassName('o3d.DrawContext')"
                "getDrawElements" => T<unit> ^-> Type.ArrayOf DrawElement
                |> WithInline "$this.getObjectsByClassName('o3d.DrawElement')"
                "getDrawLists" => T<unit> ^-> Type.ArrayOf DrawList
                |> WithInline "$this.getObjectsByClassName('o3d.DrawList')"
                "getDrawPasses" => T<unit> ^-> Type.ArrayOf DrawPass
                |> WithInline "$this.getObjectsByClassName('o3d.DrawPass')"
                "getEffects" => T<unit> ^-> Type.ArrayOf Effect
                |> WithInline "$this.getObjectsByClassName('o3d.Effect')"
                "getFunctionEvals" => T<unit> ^-> Type.ArrayOf FunctionEval
                |> WithInline "$this.getObjectsByClassName('o3d.FunctionEval')"
                "getIndexBuffers" => T<unit> ^-> Type.ArrayOf IndexBuffer
                |> WithInline "$this.getObjectsByClassName('o3d.IndexBuffer')"
                "getMaterials" => T<unit> ^-> Type.ArrayOf Material
                |> WithInline "$this.getObjectsByClassName('o3d.Material')"
                "getParamArrays" => T<unit> ^-> Type.ArrayOf ParamArray
                |> WithInline "$this.getObjectsByClassName('o3d.ParamArray')"
                "getParamObjects" => T<unit> ^-> Type.ArrayOf ParamObject
                |> WithInline "$this.getObjectsByClassName('o3d.ParamObject')"
                "getPrimitives" => T<unit> ^-> Type.ArrayOf Primitive
                |> WithInline "$this.getObjectsByClassName('o3d.Primitive')"
                "getRenderFrameCounters" => T<unit> ^-> Type.ArrayOf RenderFrameCounter
                |> WithInline "$this.getObjectsByClassName('o3d.RenderFrameCounter')"
                "getRenderNodes" => T<unit> ^-> Type.ArrayOf RenderNode
                |> WithInline "$this.getObjectsByClassName('o3d.RenderNode')"
                "getRenderSurfaceSets" => T<unit> ^-> Type.ArrayOf RenderSurfaceSet
                |> WithInline "$this.getObjectsByClassName('o3d.RenderSurfaceSet')"
                "getSamplers" => T<unit> ^-> Type.ArrayOf Sampler
                |> WithInline "$this.getObjectsByClassName('o3d.Sampler')"
                "getSecondCounters" => T<unit> ^-> Type.ArrayOf SecondCounter
                |> WithInline "$this.getObjectsByClassName('o3d.SecondCounter')"
                "getShapes" => T<unit> ^-> Type.ArrayOf Shape
                |> WithInline "$this.getObjectsByClassName('o3d.Shape')"
                "getSkins" => T<unit> ^-> Type.ArrayOf Skin
                |> WithInline "$this.getObjectsByClassName('o3d.Skin')"
                "getSkinEvals" => T<unit> ^-> Type.ArrayOf SkinEval
                |> WithInline "$this.getObjectsByClassName('o3d.SkinEval')"
                "getSourceBuffers" => T<unit> ^-> Type.ArrayOf SourceBuffer
                |> WithInline "$this.getObjectsByClassName('o3d.SourceBuffer')"
                "getStates" => T<unit> ^-> Type.ArrayOf State
                |> WithInline "$this.getObjectsByClassName('o3d.State')"
                "getStateSets" => T<unit> ^-> Type.ArrayOf StateSet
                |> WithInline "$this.getObjectsByClassName('o3d.StateSet')"
                "getStreamBanks" => T<unit> ^-> Type.ArrayOf StreamBank
                |> WithInline "$this.getObjectsByClassName('o3d.StreamBank')"
                "getTexture2Ds" => T<unit> ^-> Type.ArrayOf Texture2D
                |> WithInline "$this.getObjectsByClassName('o3d.Texture2D')"
                "getTextureCUBEs" => T<unit> ^-> Type.ArrayOf TextureCUBE
                |> WithInline "$this.getObjectsByClassName('o3d.TextureCUBE')"
                "getTickCounters" => T<unit> ^-> Type.ArrayOf TickCounter
                |> WithInline "$this.getObjectsByClassName('o3d.TickCounter')"
                "getTransforms" => T<unit> ^-> Type.ArrayOf Transform
                |> WithInline "$this.getObjectsByClassName('o3d.Transform')"
                "getTreeTraversals" => T<unit> ^-> Type.ArrayOf TreeTraversal
                |> WithInline "$this.getObjectsByClassName('o3d.TreeTraversal')"
                "getVertexBuffers" => T<unit> ^-> Type.ArrayOf VertexBuffer
                |> WithInline "$this.getObjectsByClassName('o3d.VertexBuffer')"
                "getViewports" => T<unit> ^-> Type.ArrayOf Viewport
                |> WithInline "$this.getObjectsByClassName('o3d.Viewport')"
                "getMatrix4AxisRotations" => T<unit> ^-> Type.ArrayOf Matrix4AxisRotation
                |> WithInline "$this.getObjectsByClassName('o3d.Matrix4AxisRotation')"
                "getMatrix4Compositions" => T<unit> ^-> Type.ArrayOf Matrix4Composition
                |> WithInline "$this.getObjectsByClassName('o3d.Matrix4Composition')"
                "getMatrix4Scales" => T<unit> ^-> Type.ArrayOf Matrix4Scale
                |> WithInline "$this.getObjectsByClassName('o3d.Matrix4Scale')"
                "getMatrix4Translations" => T<unit> ^-> Type.ArrayOf Matrix4Translation
                |> WithInline "$this.getObjectsByClassName('o3d.Matrix4Translation')"
                "getParamOp2FloatsToFloat2s" => T<unit> ^-> Type.ArrayOf ParamOp2FloatsToFloat2
                |> WithInline "$this.getObjectsByClassName('o3d.ParamOp2FloatsToFloat2')"
                "getParamOp3FloatsToFloat3s" => T<unit> ^-> Type.ArrayOf ParamOp3FloatsToFloat3
                |> WithInline "$this.getObjectsByClassName('o3d.ParamOp3FloatsToFloat3')"
                "getParamOp4FloatsToFloat4s" => T<unit> ^-> Type.ArrayOf ParamOp4FloatsToFloat4
                |> WithInline "$this.getObjectsByClassName('o3d.ParamOp4FloatsToFloat4')"
                "getParamOp16FloatsToMatrix4s" => T<unit> ^-> Type.ArrayOf ParamOp16FloatsToMatrix4
                |> WithInline "$this.getObjectsByClassName('o3d.ParamOp16FloatsToMatrix4')"
                "getTRSToMatrix4s" => T<unit> ^-> Type.ArrayOf TRSToMatrix4
                |> WithInline "$this.getObjectsByClassName('o3d.TRSToMatrix4')"
                "removeObject" => ObjectBase ^-> T<bool>
                "objects" =? Type.ArrayOf ObjectBase
            ]

    let DisplayModeClass =
        Class "o3d.DisplayMode"
        |=> DisplayMode
        |+> Protocol
            [
                "height" =? T<int>
                "id" =? T<int>
                "refreshRate" =? T<float>
                "width" =? T<int>
            ]

    let Event_ButtonClass =
        ConstantsType "o3d.Event" Event_Button [
            "BUTTON_LEFT"
            "BUTTON_RIGHT"
            "BUTTON_MIDDLE"
            "BUTTON_4"
            "BUTTON_5"
        ]
        |> WithSourceName "Button"

    let Event_TypeClass =
        ConstantsType "o3d.Event" Event_Type [
            "invalid"
            "click"
            "dblclick"
            "mousedown"
            "mousemove"
            "mouseup"
            "wheel"
            "keydown"
            "keypress"
            "keyup"
            "resize"
        ]
        |> WithSourceName "Type"

    let EventClass =
        Class "o3d.Event"
        |=> Event
        |=> Nested [Event_ButtonClass; Event_TypeClass]
        |+> Protocol
            [
                "altKey" =? T<bool>
                "button" =? Event_Button
                |> WithSourceName "button"
                "charCode" =? T<int>
                "ctrlKey" =? T<bool>
                "deltaX" =? T<int>
                "deltaY" =? T<int>
                "fullscreen" =? T<bool>
                "height" =? T<int>
                "keyCode" =? T<int>
                "metaKey" =? T<bool>
                "screenX" =? T<int>
                "screenY" =? T<int>
                "shiftKey" =? T<bool>
                "type" =? Event_Type
                |> WithSourceName "type"
                "width" =? T<int>
                "x" =? T<int>
                "y" =? T<int>
            ]

    let RenderEventClass =
        Class "o3d.RenderEvent"
        |=> RenderEvent
        |+> Protocol
            [
                "activeTime" =? T<float>
                "drawElementsCulled" =? T<int>
                "drawElementsProcessed" =? T<int>
                "drawElementsRendered" =? T<int>
                "elapsedTime" =? T<float>
                "primitivesRendered" =? T<int>
                "renderTime" =? T<float>
                "transformsCulled" =? T<int>
                "transformsProcessed" =? T<int>
            ]

    let TickEventClass =
        Class "o3d.TickEvent"
        |=> TickEvent
        |+> Protocol
            [
                "elapsedTime" =? T<float>
            ]

    let ClientInfoClass =
        Class "o3d.ClientInfo"
        |=> ClientInfo
        |+> Protocol
            [
                "bufferMemoryUsed" =? T<int>
                "nonPowerOfTwoTextures" =? T<bool>
                "numObjects" =? T<int>
                "softwareRenderer" =? T<bool>
                "textureMemoryUsed" =? T<int>
            ]

    let Cursor_CursorTypeClass =
        ConstantsType "o3d.Cursor" Cursor_CursorType [
            "DEFAULT"
            "NONE"
            "CROSSHAIR"
            "POINTER"
            "E_RESIZE"
            "NE_RESIZE"
            "NW_RESIZE"
            "N_RESIZE"
            "SE_RESIZE"
            "SW_RESIZE"
            "S_RESIZE"
            "W_RESIZE"
            "MOVE"
            "TEXT"
            "WAIT"
            "PROGRESS"
            "HELP"
        ]
        |> WithSourceName "CursorType"

    let CursorClass =
        Class "o3d.Cursor"
        |=> Cursor
        |=> Nested [Cursor_CursorTypeClass]

    let Renderer_InitStatusClass =
        ConstantsType "o3d.Renderer" Renderer_InitStatus [
            "UNINITIALIZED"
            "SUCCESS"
            "GPU_NOT_UP_TO_SPEC"
            "OUT_OF_RESOURCES"
            "INITIALIZATION_ERROR"
        ]
        |> WithSourceName "InitStatus"

    let Renderer_DisplayModesClass =
        ConstantsType "o3d.Renderer" Renderer_DisplayModes [
            "DISPLAY_MODE_DEFAULT"
        ]
        |> WithSourceName "DisplayModes"

    let RendererClass =
        Class "o3d.Renderer"
        |=> Renderer
        |=> Nested [Renderer_InitStatusClass; Renderer_DisplayModesClass]

    let DrawList_SortMethodClass =
        ConstantsType "o3d.DrawList" DrawList_SortMethod [
            "BY_PERFORMANCE"
            "BY_Z_ORDER"
            "BY_PRIORITY"
        ]
        |> WithSourceName "SortMethod"

    let DrawListClass =
        Class "o3d.DrawList"
        |=> DrawList
        |=> Inherits NamedObject
        |=> Nested [DrawList_SortMethodClass]

    let Stream_SemanticClass =
        ConstantsType "o3d.Stream" Stream_Semantic [
            "UNKNOWN_SEMANTIC"
            "POSITION"
            "NORMAL"
            "TANGENT"
            "BINORMAL"
            "COLOR"
            "TEXCOORD"
        ]
        |> WithSourceName "Semantic"

    let StreamClass =
        Class "o3d.Stream"
        |=> Stream
        |=> Nested [Stream_SemanticClass]
        |+> Protocol
            [
                "field" =? Field
                "semantic" =? Stream_Semantic
                |> WithSourceName "semantic"
                "semanticIndex" =? T<int>
                "startIndex" =? T<int>
            ]

    let Effect_MatrixLoadOrderClass =
        ConstantsType "o3d.Effect" Effect_MatrixLoadOrder [
            "ROW_MAJOR"
            "COLUMN_MAJOR"
        ]
        |> WithSourceName "MatrixLoadOrder"

    let EffectParameterInfoClass =
        let semantic =
            ConstantsType "o3d.Effect" (Type.New()) [
                "UPPERCASE"
            ]
            |> WithSourceName "Semantic"
        Class "o3d.EffectParameterInfo"
        |=> EffectParameterInfo
        |=> Nested [semantic]
        |+> Protocol
            [
                "className" =? T<string>
                "name" =? T<string>
                "numElements" =? T<int>
                "sasClassName" =? T<string>
                "semantic" =? semantic
                |> WithSourceName "semantic"
            ]

    let EffectStreamInfoClass =
        Class "o3d.EffectStreamInfo"
        |=> EffectStreamInfo
        |+> Protocol
            [
                "semantic" =? Stream_Semantic
                "semanticIndex" =? T<int>
            ]

    let EffectClass =
        Class "o3d.Effect"
        |=> Effect
        |=> Inherits ParamObject
        |=> Nested [Effect_MatrixLoadOrderClass]
        |+> Protocol
            [
                "createSASParameters" => ParamObject ^-> T<unit>
                "createUniformParameters" => ParamObject ^-> T<unit>
                "getParameterInfo" => T<unit> ^-> EffectParameterInfo
                "getStreamInfo" => T<unit> ^-> EffectStreamInfo
                "loadFromFXString" => T<string> ^-> T<bool>
                "loadVertexShaderFromString" => T<string> ^-> T<bool>
                "loadPixelShaderFromString" => T<string> ^-> T<bool>
                "matrixLoadOrder" => Effect_MatrixLoadOrder
                "source" => T<string>
            ]

    let State_BlendingEquationClass =
        ConstantsType "o3d.State" State_BlendingEquation [
            "BLEND_ADD"
            "BLEND_SUBSTRACT"
            "BLEND_REVERSE_SUBSTRACT"
            "BLEND_MIN"
            "BLEND_MAX"
        ]
        |> WithSourceName "BlendingEquation"

    let State_BlendingFunctionClass =
        ConstantsType "o3d.State" State_BlendingFunction [
            "BLENDFUNC_ZERO"
            "BLENDFUNC_ONE"
            "BLENDFUNC_SOURCE_COLOR"
            "BLENDFUNC_INVERSE_SOURCE_COLOR"
            "BLENDFUNC_SOURCE_ALPHA"
            "BLENDFUNC_INVERSE_SOURCE_ALPHA"
            "BLENDFUNC_DESTINATION_ALPHA"
            "BLENDFUNC_INVERSE_DESTINATION_ALPHA"
            "BLENDFUNC_DESTINATION_COLOR"
            "BLENDFUNC_INVERSE_DESTINATION_COLOR"
            "BLENDFUNC_SOURCE_ALPHA_SATURATE"
        ]
        |> WithSourceName "BlendingFunction"

    let State_ComparisonClass =
        ConstantsType "o3d.State" State_Comparison [
            "CMP_NEVER"
            "CMP_LESS"
            "CMP_EQUAL"
            "CMP_LEQUAL"
            "CMP_GREATER"
            "CMP_NOTEQUAL"
            "CMP_GEQUAL"
            "CMP_ALWAYS"
        ]
        |> WithSourceName "Comparison"

    let State_CullClass =
        ConstantsType "o3d.State" State_Cull [
            "CULL_NONE"
            "CULL_CW"
            "CULL_CCW"
        ]
        |> WithSourceName "Cull"

    let State_FillClass =
        ConstantsType "o3d.State" State_Fill [
            "POINT"
            "WIREFRAME"
            "SOLID"
        ]
        |> WithSourceName "Fill"

    let State_StencilOperationClass =
        ConstantsType "o3d.State" State_StencilOperation [
            "STENCIL_KEEP"
            "STENCIL_ZERO"
            "STENCIL_REPLACE"
            "STENCIL_INCREMENT_SATURATE"
            "STENCIL_DECREMENT_SATURATE"
            "STENCIL_INVERT"
            "STENCIL_INCREMENT"
            "STENCIL_DECREMENT"
        ]
        |> WithSourceName "StencilOperation"

    let StateClass =
        Class "o3d.State"
        |=> State
        |=> Nested [State_BlendingEquationClass
                    State_BlendingFunctionClass
                    State_ComparisonClass
                    State_CullClass
                    State_FillClass
                    State_StencilOperationClass]
        |+> Protocol
            [
                "getStateParam" => T<string> ^-> Param
                "GetStateParamAlphaTestEnable" =? ParamOf T<bool>
                |> WithGetterInline "$this.getStateParam(\"AlphaTestEnable\")"
                "GetStateParamAlphaReference" =? ParamOf T<float>
                |> WithGetterInline "$this.getStateParam(\"AlphaReference\")"
                "GetStateParamAlphaComparisonFunction" =? ParamOf State_Comparison
                |> WithGetterInline "$this.getStateParam(\"AlphaComparisonFunction\")"
                "GetStateParamCullMode" =? ParamOf State_Cull
                |> WithGetterInline "$this.getStateParam(\"CullMode\")"
                "GetStateParamDitherEnable" =? ParamOf T<bool>
                |> WithGetterInline "$this.getStateParam(\"DitherEnable\")"
                "GetStateParamLineSmoothEnable" =? ParamOf T<bool>
                |> WithGetterInline "$this.getStateParam(\"LineSmoothEnable\")"
                "GetStateParamPointSpriteEnable" =? ParamOf T<bool>
                |> WithGetterInline "$this.getStateParam(\"PointSpriteEnable\")"
                "GetStateParamPointSize" =? ParamOf T<float>
                |> WithGetterInline "$this.getStateParam(\"PointSize\")"
                "GetStateParamPolygonOffset1" =? ParamOf T<float>
                |> WithGetterInline "$this.getStateParam(\"PolygonOffset1\")"
                "GetStateParamPolygonOffset2" =? ParamOf T<float>
                |> WithGetterInline "$this.getStateParam(\"PolygonOffset2\")"
                "GetStateParamFillMode" =? ParamOf State_Fill
                |> WithGetterInline "$this.getStateParam(\"FillMode\")"
                "GetStateParamZEnable" =? ParamOf T<bool>
                |> WithGetterInline "$this.getStateParam(\"ZEnable\")"
                "GetStateParamZWriteEnable" =? ParamOf T<bool>
                |> WithGetterInline "$this.getStateParam(\"ZWriteEnable\")"
                "GetStateParamZComparisonFunction" =? ParamOf State_Comparison
                |> WithGetterInline "$this.getStateParam(\"ZComparisonFunction\")"
                "GetStateParamAlphaBlendEnable" =? ParamOf T<bool>
                |> WithGetterInline "$this.getStateParam(\"AlphaBlendEnable\")"
                "GetStateParamSourceBlendFunction" =? ParamOf State_BlendingFunction
                |> WithGetterInline "$this.getStateParam(\"SourceBlendFunction\")"
                "GetStateParamDestinationBlendFunction" =? ParamOf State_BlendingFunction
                |> WithGetterInline "$this.getStateParam(\"DestinationBlendFunction\")"
                "GetStateParamStencilEnable" =? ParamOf T<bool>
                |> WithGetterInline "$this.getStateParam(\"StencilEnable\")"
                "GetStateParamStencilFailOperation" =? ParamOf State_StencilOperation
                |> WithGetterInline "$this.getStateParam(\"StencilFailOperation\")"
                "GetStateParamStencilZFailOperation" =? ParamOf State_StencilOperation
                |> WithGetterInline "$this.getStateParam(\"StencilZFailOperation\")"
                "GetStateParamStencilPassOperation" =? ParamOf State_StencilOperation
                |> WithGetterInline "$this.getStateParam(\"StencilPassOperation\")"
                "GetStateParamStencilComparisonFunction" =? ParamOf State_Comparison
                |> WithGetterInline "$this.getStateParam(\"StencilComparisonFunction\")"
                "GetStateParamStencilReference" =? ParamOf T<int>
                |> WithGetterInline "$this.getStateParam(\"StencilReference\")"
                "GetStateParamStencilMask" =? ParamOf T<int>
                |> WithGetterInline "$this.getStateParam(\"StencilMask\")"
                "GetStateParamStencilWriteMask" =? ParamOf T<int>
                |> WithGetterInline "$this.getStateParam(\"StencilWriteMask\")"
                "GetStateParamColorWriteEnable" =? ParamOf T<int>
                |> WithGetterInline "$this.getStateParam(\"ColorWriteEnable\")"
                "GetStateParamBlendEquation" =? ParamOf State_BlendingEquation
                |> WithGetterInline "$this.getStateParam(\"BlendEquation\")"
                "GetStateParamTwoSidedStencilEnable" =? ParamOf T<bool>
                |> WithGetterInline "$this.getStateParam(\"TwoSidedStencilEnable\")"
                "GetStateParamCCWStencilFailOperation" =? ParamOf State_StencilOperation
                |> WithGetterInline "$this.getStateParam(\"CCWStencilFailOperation\")"
                "GetStateParamCCWStencilZFailOperation" =? ParamOf State_StencilOperation
                |> WithGetterInline "$this.getStateParam(\"CCWStencilZFailOperation\")"
                "GetStateParamCCWStencilPassOperation" =? ParamOf State_StencilOperation
                |> WithGetterInline "$this.getStateParam(\"CCWStencilPassOperation\")"
                "GetStateParamCCWStencilComparisonFunction" =? ParamOf State_Comparison
                |> WithGetterInline "$this.getStateParam(\"CCWStencilComparisonFunction\")"
                "GetStateParamSeparateAlphaBlendEnable" =? ParamOf T<bool>
                |> WithGetterInline "$this.getStateParam(\"SeparateAlphaBlendEnable\")"
                "GetStateParamSourceBlendAlphaFunction" =? ParamOf State_BlendingFunction
                |> WithGetterInline "$this.getStateParam(\"SourceBlendAlphaFunction\")"
                "GetStateParamDestinationBlendAlphaFunction" =? ParamOf State_BlendingFunction
                |> WithGetterInline "$this.getStateParam(\"DestinationBlendAlphaFunction\")"
                "GetStateParamBlendAlphaEquation" =? ParamOf State_BlendingEquation
                |> WithGetterInline "$this.getStateParam(\"BlendAlphaEquation\")"
            ]

    let MaterialClass =
        ClassWithInitArgs "o3d.Material"
            [
                "drawList", DrawList
                "effect", Effect
                "state", State
            ]
        |=> Material
        |=> Inherits ParamObject

    let RayIntersectionInfoClass =
        Class "o3d.RayIntersectionInfo"
        |=> RayIntersectionInfo
        |+> Protocol
            [
                "intersected" =? T<bool>
                "position" =? Float3
                "primitiveIndex" =? T<int>
                "valid" =? T<bool>
            ]


    let DrawElementClass =
        ClassWithInitArgs "o3d.DrawElement"
            [
                "material", Material
                "owner", Element
            ]
        |=> DrawElement
        |=> Inherits ParamObject


    let ElementClass =
        ClassWithInitArgs "o3d.Element"
            [
                "boundingBox", BoundingBox
                "cull", T<bool>
                "owner", Shape
                "material", Material
                "priority", T<int>
                "zSortPoint", Float3
            ]
        |=> Element
        |=> Inherits ParamObject
        |+> Protocol
            [
                "createDrawElement" => Pack * Material ^-> T<unit>
                "getBoundingBox" => T<int> ^-> BoundingBox
                "intersectRay" => T<int>?positionStreamIndex * State_Cull?cull * Float3?start * Float3?end_ ^-> RayIntersectionInfo
                "drawElements" =? DrawElement
            ]

    let ShapeClass =
        Class "o3d.Shape"
        |=> Inherits ParamObject
        |=> Shape
        |+> Protocol
            [
                "createDrawElements" => Pack * Material ^-> T<unit>
                "elements" =? Type.ArrayOf Element
            ]

    let TransformClass =
        ClassWithInitArgs "o3d.Transform"
            [
                "boundingBox", BoundingBox
                "cull", T<bool>
                "localMatrix", Matrix4
                "parent", Transform
                "visible", T<bool>
            ]
        |=> Inherits ParamObject
        |=> Transform
        |+> Protocol
            [
                "addShape" => Shape ^-> T<unit>
                "axisRotate" => T<float>?radians * Float3?axis ^-> T<unit>
                "createDrawElements" => Pack * Material ^-> T<unit>
                "getTransformsByNameInTree" => T<string> ^-> Type.ArrayOf Transform
                "getTransformsInTree" => T<unit> ^-> Type.ArrayOf Transform
                "getUpdatedWorldMatrix" => T<unit> ^-> Matrix4
                "identity" => T<unit> ^-> T<unit>
                "quaternionRotate" => Quat ^-> T<unit>
                "removeShape" => Shape ^-> T<bool>
                "rotateX" => T<float>?radians ^-> T<unit>
                "rotateY" => T<float>?radians ^-> T<unit>
                "rotateZ" => T<float>?radians ^-> T<unit>
                "rotateZYX" => Float3?radiansXYZ ^-> T<unit>
                "scale" => Float3 ^-> T<unit>
                "translate" => Float3 ^-> T<unit>
                "children" =? Type.ArrayOf Transform
                "shapes" =? Type.ArrayOf Shape
                "worldMatrix" =? Matrix4
            ]

    let ClientClass =
        Class "o3d.Client"
        |=> Client
        |=> Nested [Client_RenderModeClass]
        |+> Protocol
            [
                "cancelFullscreenDisplay" => T<unit> ^-> T<unit>
                "cleanup" => T<unit> ^-> T<unit>
                "clearErrorCallback" => T<unit> ^-> T<unit>
                "clearEventCallback" => T<string> ^-> T<unit>
                "clearFullscreenClickRegion" => T<unit> ^-> T<unit>
                "clearLastError" => T<unit> ^-> T<unit>
                "clearLostResourcesCallback" => T<unit> ^-> T<unit>
                "clearPostRenderCallback" => T<unit> ^-> T<unit>
                "clearRenderCallback" => T<unit> ^-> T<unit>
                "clearTickCallback" => T<unit> ^-> T<unit>
                "createPack" => T<unit> ^-> Pack
                "getDisplayModes" => T<unit> ^-> DisplayMode
                "getMessageQueueAddress" => T<unit> ^-> T<string>
                "getObjectById" => T<int> ^-> ObjectBase
                "getObjects" => T<string>?name * ObjectType?type_ ^-> Type.ArrayOf ObjectBase
                "getObjectsByClassName" => ObjectType ^-> Type.ArrayOf ObjectBase
                "invalidateAllParameters" => T<unit> ^-> T<unit>
                "profileReset" => T<unit> ^-> T<unit>
                "profileToString" => T<unit> ^-> T<string>
                "render" => T<unit> ^-> T<unit>
                "renderTree" => RenderNode ^-> T<unit>
                "setErrorCallback" => (T<string> ^-> T<unit>) ^-> T<unit>
                "setErrorTexture" => Texture ^-> T<unit>
                "setEventCallback" => T<string> * (Event ^-> T<unit>) ^-> T<unit>
                "setFullscreenClickRegion" => T<int>?x * T<int>?y * T<int>?width * T<int>?height * T<int>?modeId ^-> T<unit>
                "setLostResourcesCallback" => (T<unit> ^-> T<unit>) ^-> T<unit>
                "setPostRenderCallback" => (RenderEvent ^-> T<unit>) ^-> T<unit>
                "setRenderCallback" => (RenderEvent ^-> T<unit>) ^-> T<unit>
                "setTickCallback" => (TickEvent ^-> T<unit>) ^-> T<unit>
                "toDataUrl" => T<string> ^-> T<string>
                "clientId" =? T<int>
                "clientInfo" =? ClientInfo
                "cursor" =? Cursor_CursorType
                "fullscreen" =? T<bool>
                "height" =? T<int>
                "lastError" =? T<string>
                "objects" =? Type.ArrayOf ObjectBase
                "rendererInitStatus" =? Renderer_InitStatus
                "renderGraphRoot" =? RenderNode
                "renderMode" =? Client_RenderMode
                |> WithSourceName "renderMode"
                "root" =? Transform
                "width" =? T<int>
            ]

    let Counter_CountModeClass =
        ConstantsType "o3d.Counter.CountMode" Counter_CountMode [
            "CONTINUOUS"
            "ONCE"
            "CYCLE"
            "OSCILLATE"
        ]

    let CounterClass =
        ClassWithInitArgs "o3d.Counter"
            [
                "end", T<float>
                "forward", T<bool>
                "multiplier", T<float>
                "running", T<bool>
                "start", T<float>
            ]
        |=> Counter
        |=> Inherits ParamObject
        |=> Nested [Counter_CountModeClass]
        |+> Protocol
            [
                "addCallback" => T<float> * (T<unit> ^-> T<unit>) ^-> T<unit>
                "advance" => T<float> ^-> T<unit>
                "getCallbackCounts" => Type.ArrayOf T<float>
                "removeAllCallbacks" => T<unit> ^-> T<unit>
                "removeCallback" => T<float> ^-> T<bool>
                "reset" => T<unit> ^-> T<unit>
                "setCount" => T<float> ^-> T<unit>
                "count" =? T<float>
                "countMode" =@ Counter_CountMode
                |> WithSourceName "countMode"
            ]

    let FunctionClass =
        Class "o3d.Function"
        |=> Function
        |=> Inherits NamedObject
        |+> Protocol
            [
                "evaluate" => T<float> ^-> T<float>
            ]

    let Curve_InfinityClass =
        ConstantsType "Infinity" Curve_Infinity [
            "CONSTANT"
            "LINEAR"
            "CYCLE"
            "CYCLE_RELATIVE"
            "OSCILLATE"
        ]

    let CurveClass =
        ClassWithInitArgs "o3d.Curve"
            [
                "postInfinity", Curve_Infinity
                "preInfinity", Curve_Infinity
                "sampleRate", T<float>
                "useCache", T<bool>
            ]
        |=> Curve
        |=> Inherits Function
        |=> Nested [Curve_InfinityClass]
        |+> Protocol
            [
                "addBezierKeys" => Type.ArrayOf T<float> ^-> T<unit>
                "addLinearKeys" => Type.ArrayOf T<float> ^-> T<unit>
                "addStepKeys" => Type.ArrayOf T<float> ^-> T<unit>
                "createKey" => T<string> ^-> CurveKey
                "createBezierKey" => T<unit> ^-> BezierCurveKey
                |> WithInline "$this.createKey('o3d.BezierCurveKey')"
                "createLinearKey" => T<unit> ^-> LinearCurveKey
                |> WithInline "$this.createKey('o3d.LinearCurveKey')"
                "createStepKey" => T<unit> ^-> StepCurveKey
                |> WithInline "$this.createKey('o3d.StepCurveKey')"
                "isDiscontinuous" => T<unit> ^-> T<bool>
                "set" => RawData?data * T<int>?offset * T<int>?length ^-> T<bool>
                "set" => RawData?data * T<int>?offset ^-> T<bool>
                "set" => RawData ^-> T<bool>
            ]

    let DrawContextClass =
        ClassWithInitArgs "o3d.DrawContext"
            [
                "projection", Matrix4
                "view", Matrix4
            ]
        |=> DrawContext
        |=> Inherits ParamObject

    let DrawPassClass =
        ClassWithInitArgs "o3d.DrawPass"
            [
                "drawList", DrawList
                "sortMethod", DrawList_SortMethod
            ]
        |=> DrawPass
        |=> Inherits RenderNode

    let FieldClass =
        Class "o3d.Field"
        |=> Inherits NamedObject
        |=> Field
        |+> Protocol
            [
                "buffer" =? Buffer
                "numComponents" =? T<int>
                "offset" =? T<int>
                "size" =? T<int>
            ]

    let FunctionEvalClass =
        ClassWithInitArgs "o3d.FunctionEval"
            [
                "functionObject", Function
                "input", T<float>
            ]
        |=> FunctionEval
        |=> Inherits ParamObject
        |+> Protocol
            [
                "output" =? T<float>
            ]

    let IndexBufferClass =
        Class "o3d.IndexBuffer"
        |=> IndexBuffer
        |=> Inherits Buffer
        |+> Protocol
            [
                "set" => Type.ArrayOf T<int> ^-> T<bool>
                "setAt" => T<int>?startIndex * (Type.ArrayOf T<int>)?data ^-> T<unit>
            ]

    let Matrix4AxisRotationClass =
        ClassWithInitArgs "o3d.Matrix4AxisRotation"
            [
                "angle", T<float>
                "axis", Float3
                "inputMatrix", Matrix4
            ]
        |=> Matrix4AxisRotation
        |=> Inherits ParamObject
        |+> Protocol
            [
                "outputMatrix" =? Matrix4
            ]

    let Matrix4CompositionClass =
        ClassWithInitArgs "o3d.Matrix4Composition"
            [
                "inputMatrix", Matrix4
                "localMatrix", Matrix4
            ]
        |=> Matrix4Composition
        |=> Inherits ParamObject
        |+> Protocol
            [
                "outputMatrix" =? Matrix4
            ]

    let Matrix4ScaleClass =
        ClassWithInitArgs "o3d.Matrix4Scale"
            [
                "inputMatrix", Matrix4
                "scale", Float3
            ]
        |=> Matrix4Scale
        |=> Inherits ParamObject
        |+> Protocol
            [
                "outputMatrix" =? Matrix4
            ]

    let Matrix4TranslationClass =
        ClassWithInitArgs "o3d.Matrix4Translation"
            [
                "inputMatrix", Matrix4
                "translation", Float3
            ]
        |=> Matrix4Translation
        |=> Inherits ParamObject
        |+> Protocol
            [
                "outputMatrix" =? Matrix4
            ]

    let ParamArrayClass =
        Class "o3d.ParamArray"
        |=> ParamArray
        |=> Inherits NamedObject
        |+> Protocol
            [
                "length" =? T<int>
                "params" =? Type.ArrayOf Param
            ]

    let ParamOp16FloatsToMatrix4Class =
        ClassWithInitArgs "ParamOp16FloatsToMatrix4"
            [
                "input0", T<float>
                "input1", T<float>
                "input2", T<float>
                "input3", T<float>
                "input4", T<float>
                "input5", T<float>
                "input6", T<float>
                "input7", T<float>
                "input8", T<float>
                "input9", T<float>
                "input10", T<float>
                "input11", T<float>
                "input12", T<float>
                "input13", T<float>
                "input14", T<float>
                "input15", T<float>
            ]
        |=> ParamOp16FloatsToMatrix4
        |=> Inherits ParamObject
        |+> Protocol
            [
                "output" =? Matrix4
            ]

    let ParamOp2FloatsToFloat2Class =
        ClassWithInitArgs "ParamOp2FloatsToFloat2"
            [
                "input0", T<float>
                "input1", T<float>
            ]
        |=> ParamOp2FloatsToFloat2
        |=> Inherits ParamObject
        |+> Protocol
            [
                "output" =? Float2
            ]

    let ParamOp3FloatsToFloat3Class =
        ClassWithInitArgs "ParamOp3FloatsToFloat3"
            [
                "input0", T<float>
                "input1", T<float>
                "input2", T<float>
            ]
        |=> ParamOp3FloatsToFloat3
        |=> Inherits ParamObject
        |+> Protocol
            [
                "output" =? Float3
            ]

    let ParamOp4FloatsToFloat4Class =
        ClassWithInitArgs "ParamOp4FloatsToFloat4"
            [
                "input0", T<float>
                "input1", T<float>
                "input2", T<float>
                "input3", T<float>
            ]
        |=> ParamOp4FloatsToFloat4
        |=> Inherits ParamObject
        |+> Protocol
            [
                "output" =? Float4
            ]

    let StreamBankClass =
        Class "StreamBank"
        |=> StreamBank
        |+> Protocol
            [
                "getVertexStream" => Stream_Semantic * T<int> ^-> Stream
                "removeVertexStream" => Stream_Semantic * T<int> ^-> T<bool>
                "setVertexStream" => Stream_Semantic * T<int> * Field * T<int> ^-> T<bool>
                "vertexStreams" => Type.ArrayOf Stream
            ]

    let Primitive_PrimitiveTypeClass =
        ConstantsType "PrimitiveType" Primitive_PrimitiveType [
            "POINTLIST"
            "LINELIST"
            "LINESTRIP"
            "TRIANGLELIST"
            "TRIANGLESTRIP"
            "TRIANGLEFAN"
        ]

    let PrimitiveClass =
        ClassWithInitArgs "Primitive"
            [
                "indexBuffer", IndexBuffer
                "numberPrimitives", T<int>
                "numberVertices", T<int>
                "startIndex", T<int>
                "streamBank", StreamBank
            ]
        |=> Primitive
        |=> Inherits Element
        |=> Nested [Primitive_PrimitiveTypeClass]
        |+> Protocol
            [
                "primitiveType" =% Primitive_PrimitiveType
                |> WithSourceName "primitiveType"
            ]

    let ProjectionParamMatrix4Class =
        Class "ProjectionParamMatrix4"
        |=> ProjectionParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let ProjectionInverseParamMatrix4Class =
        Class "ProjectionInverseParamMatrix4"
        |=> ProjectionInverseParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let ProjectionTransposeParamMatrix4Class =
        Class "ProjectionTransposeParamMatrix4"
        |=> ProjectionTransposeParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let ProjectionInverseTransposeParamMatrix4Class =
        Class "ProjectionInverseTransposeParamMatrix4"
        |=> ProjectionInverseTransposeParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let RenderFrameCounterClass =
        Class "RenderFrameCounter"
        |=> RenderFrameCounter
        |=> Inherits Counter

    let RenderSurfaceSetClass =
        ClassWithInitArgs "RenderSurfaceSet"
            [
                "renderDepthStencilSurface", RenderDepthStencilSurface
                "renderSurface", RenderSurface
            ]
        |=> RenderSurfaceSet
        |=> Inherits RenderNode

    let Sampler_AddressModeClass =
        ConstantsType "Sampler.AddressMode" Sampler_AddressMode [
            "WRAP"
            "MIRROR"
            "CLAMP"
            "BORDER"
        ]

    let Sampler_FilterTypeClass =
        ConstantsType "Sampler.FilterType" Sampler_FilterType [
            "NONE"
            "POINT"
            "LINEAR"
            "ANISOTROPIC"
        ]

    let SamplerClass =
        ClassWithInitArgs "Sampler"
            [
                "addressModeU", Sampler_AddressMode
                "addressModeV", Sampler_AddressMode
                "addressModeW", Sampler_AddressMode
                "borderColor", Float4
                "magFilter", Sampler_FilterType
                "maxAnisotropy", T<int>
                "minFilter", Sampler_FilterType
                "mipFilter", Sampler_FilterType
                "texture", Texture
            ]
        |=> Sampler
        |=> Inherits ParamObject
        |=> Nested [Sampler_FilterTypeClass; Sampler_AddressModeClass]

    let SecondCounterClass =
        Class "SecondCounter"
        |=> SecondCounter
        |=> Inherits Counter

    let SkinClass =
        ClassWithInitArgs "Skin"
            [
                "influences", Type.ArrayOf (Type.ArrayOf T<int>)
                "inverseBindPoseMatrices", Type.ArrayOf Matrix4
            ]
        |=> Skin
        |=> Inherits NamedObject
        |+> Protocol
            [
                "getVertexInfluences" => T<int> ^-> Type.ArrayOf T<int>
                "set" => RawData?data * T<int>?offset * T<int>?length ^-> T<bool>
                "set" => RawData?data * T<int>?offset ^-> T<bool>
                "set" => RawData ^-> T<bool>
                "setInverseBindPoseMatrix" => T<int> * Matrix4 ^-> T<unit>
                "setVertexInfluences" => T<int> * Type.ArrayOf T<int> ^-> T<unit>
            ]

    let VertexSourceClass =
        Class "VertexSource"
        |=> VertexSource
        |=> Inherits ParamObject
        |+> Protocol
            [
                "bindStream" => VertexSource * Stream_Semantic * T<int> ^-> T<bool>
                "unbindStream" => Stream_Semantic * T<int> ^-> T<bool>
            ]

    let SkinEvalClass =
        ClassWithInitArgs "SkinEval"
            [
                "base", Matrix4
                "matrices", ParamArray
                "skin", Skin
            ]
        |=> SkinEval
        |=> Inherits VertexSource
        |+> Protocol
            [
                "getVertexStream" => Stream_Semantic * T<int> ^-> Stream
                "removeVertexStream" => Stream_Semantic * T<int> ^-> T<bool>
                "setVertexStream" => Stream_Semantic * T<int> * Field * T<int> ^-> T<bool>
                "vertexStreams" =? Type.ArrayOf Stream
            ]

    let VertexBufferBaseClass =
        Class "VertexBufferBase"
        |=> VertexBufferBase
        |=> Inherits Buffer
        |+> Protocol
            [
                "get" => T<unit> ^-> Type.ArrayOf T<float>
                "getAt" => T<int>?start * T<int>?count ^-> Type.ArrayOf T<float>
                "set" => Type.ArrayOf T<float> ^-> T<bool>
                "setAt" => T<int> * Type.ArrayOf T<float> ^-> T<unit>
            ]

    let SourceBufferClass =
        Class "SourceBuffer"
        |=> SourceBuffer
        |=> Inherits VertexBufferBase

    let StateSetClass =
        ClassWithInitArgs "StateSet"
            [
                "state", State
            ]
        |=> StateSet
        |=> Inherits RenderNode

    let TickCounterClass =
        Class "TickCounter"
        |=> TickCounter
        |=> Inherits Counter

    let TreeTraversalClass =
        ClassWithInitArgs "TreeTraversal"
            [
                "transform", Transform
            ]
        |=> TreeTraversal
        |=> Inherits RenderNode
        |+> Protocol
            [
                "registerDrawList" => DrawList * DrawContext * T<bool> ^-> T<unit>
                "unregisterDrawList" => DrawList ^-> T<bool>
            ]

    let TRSToMatrix4Class =
        ClassWithInitArgs "TRSToMatrix4"
            [
                "rotateX", T<float>
                "rotateY", T<float>
                "rotateZ", T<float>
                "scaleX", T<float>
                "scaleY", T<float>
                "scaleZ", T<float>
                "translateX", T<float>
                "translateY", T<float>
                "translateZ", T<float>
            ]
        |=> TRSToMatrix4
        |=> Inherits ParamObject
        |+> Protocol
            [
                "output" =? Matrix4
            ]

    let VertexBufferClass =
        Class "VertexBuffer"
        |=> VertexBuffer
        |=> Inherits VertexBufferBase

    let ViewParamMatrix4Class =
        Class "ViewParamMatrix4"
        |=> ViewParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let ViewInverseParamMatrix4Class =
        Class "ViewInverseParamMatrix4"
        |=> ViewInverseParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let ViewTransposeParamMatrix4Class =
        Class "ViewTransposeParamMatrix4"
        |=> ViewTransposeParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let ViewInverseTransposeParamMatrix4Class =
        Class "ViewInverseTransposeParamMatrix4"
        |=> ViewInverseTransposeParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let ViewProjectionParamMatrix4Class =
        Class "ViewProjectionParamMatrix4"
        |=> ViewProjectionParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let ViewProjectionInverseParamMatrix4Class =
        Class "ViewProjectionInverseParamMatrix4"
        |=> ViewProjectionInverseParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let ViewProjectionTransposeParamMatrix4Class =
        Class "ViewProjectionTransposeParamMatrix4"
        |=> ViewProjectionTransposeParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let ViewProjectionInverseTransposeParamMatrix4Class =
        Class "ViewProjectionInverseTransposeParamMatrix4"
        |=> ViewProjectionInverseTransposeParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let ViewportClass =
        ClassWithInitArgs "Viewport"
            [
                "depthRange", Float2
            ]
        |=> Viewport
        |=> Inherits RenderNode
        |+> Protocol
            [
                "viewport" =@ Float4
                |> WithSourceName "viewport"
            ]

    let WorldViewParamMatrix4Class =
        Class "WorldViewParamMatrix4"
        |=> WorldViewParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let WorldViewInverseParamMatrix4Class =
        Class "WorldViewInverseParamMatrix4"
        |=> WorldViewInverseParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let WorldViewTransposeParamMatrix4Class =
        Class "WorldViewTransposeParamMatrix4"
        |=> WorldViewTransposeParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let WorldViewInverseTransposeParamMatrix4Class =
        Class "WorldViewInverseTransposeParamMatrix4"
        |=> WorldViewInverseTransposeParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let WorldViewProjectionParamMatrix4Class =
        Class "WorldViewProjectionParamMatrix4"
        |=> WorldViewProjectionParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let WorldViewProjectionInverseParamMatrix4Class =
        Class "WorldViewProjectionInverseParamMatrix4"
        |=> WorldViewProjectionInverseParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let WorldViewProjectionTransposeParamMatrix4Class =
        Class "WorldViewProjectionTransposeParamMatrix4"
        |=> WorldViewProjectionTransposeParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let WorldViewProjectionInverseTransposeParamMatrix4Class =
        Class "WorldViewProjectionInverseTransposeParamMatrix4"
        |=> WorldViewProjectionInverseTransposeParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let WorldParamMatrix4Class =
        Class "WorldParamMatrix4"
        |=> WorldParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let WorldInverseParamMatrix4Class =
        Class "WorldInverseParamMatrix4"
        |=> WorldInverseParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let WorldTransposeParamMatrix4Class =
        Class "WorldTransposeParamMatrix4"
        |=> WorldTransposeParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let WorldInverseTransposeParamMatrix4Class =
        Class "WorldInverseTransposeParamMatrix4"
        |=> WorldInverseTransposeParamMatrix4
        |=> Inherits (ParamOf Matrix4)

    let o3d =
        Class "o3d"
        |> WithSourceName "O3D"
        |=> Nested [
                ArchiveRequestClass
                BezierCurveKeyClass
                BitmapClass
                BufferClass
                CanvasClass
                CanvasFontMetricsClass
                CanvasLinearGradientClass
                CanvasPaintClass
                CanvasShaderClass
                ClearBufferClass
                ClientClass
                ClientInfoClass
                CounterClass
                CurveClass
                CurveKeyClass
                DisplayModeClass
                DrawContextClass
                DrawElementClass
                DrawListClass
                DrawPassClass
                EffectClass
                EffectParameterInfoClass
                EffectStreamInfoClass
                ElementClass
                EventClass
                FieldClass
                FileRequestClass
                FloatFieldClass
                FunctionClass
                FunctionEvalClass
                IndexBufferClass
                LinearCurveKeyClass
                MaterialClass
                Matrix4AxisRotationClass
                Matrix4CompositionClass
                Matrix4ScaleClass
                Matrix4TranslationClass
                NamedObjectClass
                NamedObjectBaseClass
                ObjectBaseClass
                PackClass
                ParamClass
                Generic - ParamOf
                ParamArrayClass
                ParamOp2FloatsToFloat2Class
                ParamOp3FloatsToFloat3Class
                ParamOp4FloatsToFloat4Class
                ParamOp16FloatsToMatrix4Class
                ParamObjectClass
                PrimitiveClass
                RawDataClass
                RayIntersectionInfoClass
                RenderDepthStencilSurfaceClass
                RendererClass
                RenderEventClass
                RenderFrameCounterClass
                RenderNodeClass
                RenderSurfaceClass
                RenderSurfaceBaseClass
                RenderSurfaceSetClass
                SamplerClass
                SecondCounterClass
                ShapeClass
                SkinClass
                SkinEvalClass
                SourceBufferClass
                StateClass
                StateSetClass
                StepCurveKeyClass
                StreamClass
                StreamBankClass
                TextureClass
                Texture2DClass
                TextureCUBEClass
                TickCounterClass
                TickEventClass
                TransformClass
                TreeTraversalClass
                TRSToMatrix4Class
                UByteNFieldClass
                UInt32FieldClass
                VertexBufferClass
                VertexBufferBaseClass
                VertexSourceClass
                ViewportClass
            ]





    //////// O3Djs ////////


    let arcball_ArcBall =
        Class "ArcBall"
        |+> [
                Constructor (T<int> * T<int>)
            ]
        |+> Protocol
            [
                "click" => Float2 ^-> T<unit>
                "drag" => Float2 ^-> Quat
                "mapToSphere" => Float2 ^-> Float3
                "setAreaSize" => T<int> * T<int> ^-> T<unit>
            ]

    let camera_CameraInfo =
        Class "CameraInfo"
        |+> [
                Constructor (Matrix4?view * T<float>?zNear * T<float>?zFar * Float3?eye * Float3?target * Float3?up)
                Constructor (Matrix4?view * T<float>?zNear * T<float>?zFar * Float3?eye * Float3?target)
                Constructor (Matrix4?view * T<float>?zNear * T<float>?zFar * Float3?eye)
                Constructor (Matrix4?view * T<float>?zNear * T<float>?zFar)
            ]
        |+> Protocol
            [
                "computeProjection" => T<int> * T<int> ^-> Matrix4
                "setAsOrthographic" => T<float>?magX * T<float>?magY ^-> T<unit>
                "setAsPerspective" => T<float>?fov ^-> T<unit>
                "fieldOfViewRadians" =? T<float>
                "magX" =? T<float>
                "magY" =? T<float>
                "orthographic" =? T<bool>
                "projection" =% Matrix4
                "eye" =? Float3
                "target" =? Float3
                "up" =? Float3
                "view" =% Matrix4
                "zFar" =? T<float>
                "zNear" =? T<float>
            ]


    let canvas_CanvasQuad =
        Class "CanvasQuad"
        |+> [
                Constructor (canvas_CanvasInfo' * T<int> * T<int> * T<bool> * Transform)
                Constructor (canvas_CanvasInfo' * T<int> * T<int> * T<bool>)
            ]
        |+> Protocol
            [
                "updateTexture" => T<unit> ^-> T<unit>
                "canvas" =? Canvas
                "canvasInfo" =? canvas_CanvasInfo'
                "sampler" =? Sampler
                "scaleTransform" =? Transform
                "texture" =? Texture2D
                "transform" =? Transform
            ]

    let rendergraph_DrawPassInfo =
        Class "DrawPassInfo"
        |+> [
                Constructor (Pack * DrawContext * DrawList_SortMethod * DrawList * RenderNode)
                Constructor (Pack * DrawContext * DrawList_SortMethod * DrawList)
                Constructor (Pack * DrawContext * DrawList_SortMethod)
            ]
        |+> Protocol
            [
                "destroy" => T<unit> ^-> T<unit>
                "drawList" =% DrawList
                "drawPass" =% DrawPass
                "pack" =% Pack
                "root" =% RenderNode
                "state" =% State
                "stateSet" =% StateSet
            ]

    let rendergraph_ViewInfo =
        Class "ViewInfo"
        |+> [
                Constructor (Pack?pack * Transform?transform * RenderNode?parent * Float4?clearColor * T<float>?priority * Float4?viewport * DrawList?performanceDrawList * DrawList?zOrderedDrawList)
                Constructor (Pack?pack * Transform?transform * RenderNode?parent * Float4?clearColor * T<float>?priority * Float4?viewport * DrawList?performanceDrawList)
                Constructor (Pack?pack * Transform?transform * RenderNode?parent * Float4?clearColor * T<float>?priority * Float4?viewport)
                Constructor (Pack?pack * Transform?transform * RenderNode?parent * Float4?clearColor * T<float>?priority)
                Constructor (Pack?pack * Transform?transform * RenderNode?parent * Float4?clearColor)
                Constructor (Pack?pack * Transform?transform * RenderNode?parent)
                Constructor (Pack * Transform)
            ]
        |+> Protocol
            [
                "createDrawPass" => DrawList_SortMethod * DrawList ^-> rendergraph_DrawPassInfo
                "createDrawPass" => DrawList_SortMethod ^-> rendergraph_DrawPassInfo
                "createDrawPass" => DrawList_SortMethod * DrawContext * T<float> * RenderNode * DrawList ^-> rendergraph_DrawPassInfo
                "createDrawPass" => DrawList_SortMethod * DrawContext * T<float> * RenderNode ^-> rendergraph_DrawPassInfo
                "createDrawPass" => DrawList_SortMethod * DrawContext * T<float> ^-> rendergraph_DrawPassInfo
                "createDrawPass" => DrawList_SortMethod * DrawContext ^-> rendergraph_DrawPassInfo
                "destroy" => T<bool> * T<bool> ^-> T<unit>
                "destroy" => T<bool> ^-> T<unit>
                "destroy" => T<unit> ^-> T<unit>
                "clearBuffer" =? ClearBuffer
                "drawContext" =? DrawContext
                "pack" =% Pack
                "performanceDrawList" =% DrawList
                "performanceDrawPass" =% DrawPass
                "performanceDrawPassInfo" =% rendergraph_DrawPassInfo
                "performanceState" =% State
                "performanceStateSet" =% StateSet
                "priority" =% T<float>
                "renderGraphRoot" =% RenderNode
                "root" =% RenderNode
                "treeRoot" =% Transform
                "treeTraversal" =% TreeTraversal
                "viewport" =% Viewport
                "zOrderedDrawList" =% DrawList
                "zOrderedDrawPass" =% DrawPass
                "zOrderedDrawPassInfo" =% rendergraph_DrawPassInfo
                "zOrderedState" =% State
                "zOrderedStateSet" =% StateSet
            ]

    let canvas_CanvasInfo =
        Class "CanvasInfo"
        |=> canvas_CanvasInfo'
        |+> [
                Constructor (Pack * Transform * rendergraph_ViewInfo)
            ]
        |+> Protocol
            [
                "createQuad" => T<float>?w * T<float>?h * T<bool>?transparent * Transform?transform ^-> canvas_CanvasQuad
                "createQuad" => T<float>?w * T<float>?h * T<bool>?transparent ^-> canvas_CanvasQuad
                "createXYQuad" => T<float>?topX * T<float>?topY * T<float>?z * T<float>?w * T<float>?h * T<bool>?transparent * Transform?transform ^-> canvas_CanvasQuad
                "createXYQuad" => T<float>?topX * T<float>?topY * T<float>?z * T<float>?w * T<float>?h * T<bool>?transparent ^-> canvas_CanvasQuad
                "effect_" =? Effect
                "opaqueMaterial_" =? Material
                "opaqueQuadShape" =? Shape
                "pack" =? Pack
                "root" =? Transform
                "transparentMaterial_" =? Material
                "transparentQuadShape" =? Shape
                "transparentState_" =? State
                "viewInfo" =? rendergraph_ViewInfo
            ]


    let debug_DebugLineGroup =
        Class "DebugLineGroup"
        |+> [
                Constructor (debug_DebugHelper' * Transform)
            ]
        |+> Protocol
            [
                "addLine" => Float3?start * Float3?End * Float3?color ^-> debug_DebugLine'
                "addLine" => Float3?start * Float3?End ^-> debug_DebugLine'
                "addLine" => Float3?start ^-> debug_DebugLine'
                "clear" => T<unit> ^-> T<unit>
                "destroy" => T<unit> ^-> T<unit>
                "getColor" => T<unit> ^-> Float4
                "getLineShape" => T<unit> ^-> Shape
                "getPack" => T<unit> ^-> Pack
                "getRoot" => T<unit> ^-> Transform
                "remove" => debug_DebugLine' ^-> T<unit>
                "setColor" => Float4 ^-> T<unit>
            ]

    let debug_DebugHelper =
        Class "DebugHelper"
        |=> debug_DebugHelper'
        |+> [
                Constructor (Pack * rendergraph_ViewInfo)
            ]
        |+> Protocol
            [
                "addAxes" => Transform ^-> T<unit>
                "addAxis" => Transform ^-> T<unit>
                "addCube" => Transform?transform * Float4?color * T<float>?scale ^-> T<unit>
                "addCube" => Transform?transform * Float4?color ^-> T<unit>
                "addCube" => Transform ^-> T<unit>
                "addCubes" => Transform ^-> T<unit>
                "addSphere" => Transform?transform * Float4?color * T<float>?scale ^-> T<unit>
                "addSphere" => Transform?transform * Float4?color ^-> T<unit>
                "addSphere" => Transform ^-> T<unit>
                "addSpheres" => Transform ^-> T<unit>
                "clearAxisColor" => Transform ^-> T<unit>
                "createCube" => Float3?pos * Float4?color * T<float>?scale ^-> Transform
                "createCube" => Float3?pos * Float4?color ^-> Transform
                "createCube" => Float3?pos ^-> Transform
                "createDebugLineGroup" => Transform ^-> debug_DebugLineGroup
                "createSphere" => Float3?pos * Float4?color * T<float>?scale ^-> Transform
                "createSphere" => Float3?pos * Float4?color ^-> Transform
                "createSphere" => Float3?pos ^-> Transform
                "getLineShape" => T<unit> ^-> Shape
                "getPack" => T<unit> ^-> Pack
                "removeAxes" => Transform ^-> T<unit>
                "removeAxis" => Transform ^-> T<unit>
                "removeCube" => Transform ^-> T<unit>
                "removeCubes" => Transform ^-> T<unit>
                "removeSphere" => Transform ^-> T<unit>
                "removeSpheres" => Transform ^-> T<unit>
                "setAxisColor" => Transform * Float4 ^-> T<unit>
                "setAxisScale" => T<float> * T<float> ^-> T<unit>
                "setCubeColor" => Transform * Float3 ^-> T<unit>
                "setCubeScale" => Transform * T<float> ^-> T<unit>
                "setSphereColor" => Transform * Float3 ^-> T<unit>
                "setSphereScale" => Transform * T<float> ^-> T<unit>
            ]

    let debug_DebugLine =
        Class "DebugLine"
        |=> debug_DebugLine'
        |+> [
                Constructor (debug_DebugLineGroup)
            ]
        |+> Protocol
            [
                "destroy" => T<unit> ^-> T<unit>
                "getId" => T<unit> ^-> T<unit>
                "remove" => T<unit> ^-> T<unit>
                "setColor" => Float4 ^-> T<unit>
                "setEnd" => Float3 ^-> T<unit>
                "setEndPoints" => Float3 * Float3 ^-> T<unit>
                "setStart" => Float3 ^-> T<unit>
                "setVisible" => T<bool> ^-> T<unit>
            ]

    let debug_VertexInfo =
        Class "VertexInfo"
        |+> [
                Constructor (Type.ArrayOf Float3 * Type.ArrayOf T<int>)
                Constructor (Type.ArrayOf Float3)
                Constructor (T<unit>)
            ]
        |+> Protocol
            [
                "addLine" => T<int> * T<int> ^-> T<unit>
                "addVertex" => T<float> * T<float> * T<float> ^-> T<unit>
                "createShape" => Pack * Material ^-> Shape
                "numVertices" => T<unit> ^-> T<int>
                "reorient" => Matrix4 ^-> T<unit>
                "vertexIndex" => T<int> ^-> T<int>
                "indices" =? Type.ArrayOf T<float>
                "Offset" =? T<int>
                "vertices" =? Type.ArrayOf Float3
            ]

    let effect_Description =
        Class "Description"
        |+> Protocol
            [
                "description" =? T<string>
                "shader" =? T<string>
            ]

    let effect_Type =
        ConstantStringsType "Type" ["phong"; "lambert"; "constant"]

    let error_ErrorCollector =
        Class "ErrorCollector"
        |+> [
                Constructor (Client)
            ]
        |+> Protocol
            [
                "finish" => T<unit> ^-> T<unit>
                "errors" =? Type.ArrayOf T<string>
            ]

    let fps_ColorRect =
        Class "ColorRect"
        |+> [
                Constructor (Pack?pack * Shape?shape * Transform?transform * T<float>?x * T<float>?y * T<float>?z * T<float>?width * T<float>?height * Float4?color)
                "setColor" => Float4 ^-> T<unit>
                "setPosition" => T<float> * T<float> ^-> T<unit>
                "setSize" => T<float> * T<float> ^-> T<unit>
            ]

    let fps_FPSManager =
        Class "FPSManager"
        |+> [
                Constructor (Pack * T<int> * T<int> * RenderNode)
                Constructor (Pack * T<int> * T<int>)
            ]
        |+> Protocol
            [
                "resize" => T<int> * T<int> ^-> T<unit>
                "setPerfVisible" => T<bool> ^-> T<unit>
                "setPosition" => T<int> * T<int> ^-> T<unit>
                "setVisible" => T<bool> ^-> T<unit>
                "update" => RenderEvent ^-> T<unit>
                "fpsQuad" => T<obj>
                "viewInfo" => rendergraph_ViewInfo
            ]

    let io_ProgressInfo =
        Class "ProgressInfo"
        |+> Protocol
            [
                "percent" =? T<float>
                "dowloaded" =? T<string>
                "totalBytes" =? T<int>
                "base" =? T<int>
                "suffix" =? T<string>
            ]

    let io_LoadInfo =
        let t = Type.New()
        Class "LoadInfo"
        |=> t
        |+> [
                Constructor (ArchiveRequest * T<bool>)
                Constructor (FileRequest * T<bool>)
                Constructor (ArchiveRequest)
                Constructor (FileRequest)
                Constructor (T<unit>)
            ]
        |+> Protocol
            [
                "addChild" => t ^-> T<unit>
                "finish" => T<unit> ^-> T<unit>
                "getKnownProgressInfoSoFar" => T<unit> ^-> io_ProgressInfo
                "getTotalBytesDownloaded" => T<unit> ^-> T<int>
                "getTotalKnownBytesToStreamSoFar" => T<unit> ^-> T<int>
                "getTotalKnownRequestsToStreamSoFar" => T<unit> ^-> T<int>
                "getTotalRequestsDownloaded" => T<unit> ^-> T<int>
            ]

    let io_ArchiveInfo =
        let t = Type.New()
        Class "ArchiveInfo"
        |=> t
        |+> [
                Constructor (Pack * T<string> * (t * T<obj> ^-> T<unit>))
            ]
        |+> Protocol
            [
                "destroy" => T<unit> ^-> T<unit>
                "getFileByUri" => T<string>?uri * T<bool>?caseInsensitive ^-> RawData
                "getFileByUri" => T<string> ^-> RawData
                "getFiles" => T<string>?uri * T<bool>?caseInsensitive ^-> Type.ArrayOf RawData
                "getFiles" => T<string> ^-> Type.ArrayOf RawData
                "destroyed" =? T<bool>
                "file" =? T<obj>
                "loadInfo" =? io_LoadInfo
                "pack" =? Pack
            ]

    let serialization_Options =
        Pattern.Config "Options" {
            Required = []
            Optional =
                [
                    "opt_animSource", (ParamOf T<float>).Type
                    "opt_async", T<bool>
                ]
    }

    let loader_Loader =
        Class "Loader"
        |> WithSourceName "loader"
        |+> [
                Constructor (T<unit> ^-> T<unit>)
            ]
        |+> Protocol
            [
                "createLoader" => (T<unit> ^-> T<unit>) ^-> T<unit>
                "finish" => T<unit> ^-> T<unit>
                "loadBitmaps" => Pack * T<string> * (Type.ArrayOf Bitmap * T<obj> ^-> T<unit>) ^-> T<unit>
                "loadRawData" => Pack * T<string> * (FileRequest * RawData * T<obj> ^-> T<unit>) ^-> T<unit>
                "loadScene" => Client * Pack * Transform * T<string> * serialization_Options * (Pack * Transform * T<obj> ^-> T<unit>) ^-> T<unit>
                "loadScene" => Client * Pack * Transform * T<string> * serialization_Options ^-> T<unit>
                "loadScene" => Client * Pack * Transform * T<string> ^-> T<unit>
                "loadTextFile" => T<string> ^-> T<string> * (T<string> * T<obj> ^-> T<unit>) ^-> T<unit>
                "loadTexture" => Pack * T<string> * (Texture * T<obj> ^-> T<unit>) ^-> T<unit>
                "loadInfo" =? io_LoadInfo
            ]

    let particles_ParticleSpec =
        Pattern.Config "ParticleSpec" {
            Required = []
            Optional =
                [
                    "acceleration", Float3
                    "accelerationRange", Float3
                    "billboard", T<bool>
                    "colorMult", Float4
                    "colorMultRange", Float4
                    "endSize", T<float>
                    "endSizeRange", T<float>
                    "frameDuration", T<float>
                    "frameStart", T<float>
                    "frameStartRange", T<float>
                    "lifeTime", T<float>
                    "lifeTimeRange", T<float>
                    "numFrames", T<int>
                    "numParticles", T<int>
                    "orientation", Quat
                    "position", Float3
                    "positionRange", Float3
                    "spinSpeed", T<float>
                    "spinSpeedRange", T<float>
                    "spinStart", T<float>
                    "spinStartRange", T<float>
                    "startSize", T<float>
                    "startSizeRange", T<float>
                    "startTime", T<float>
                    "timeRange", T<float>
                    "velocity", Float3
                    "velocityRange", Float3
                    "worldAcceleration", Float3
                    "worldVelocity", Float3
                ]
        }

    let particles_ParticleSystem =
        Class "ParticleSystem"
        |+> [
                Constructor (Pack * rendergraph_ViewInfo * ParamOf T<float> * (T<unit> ^-> T<float>))
                Constructor (Pack * rendergraph_ViewInfo * ParamOf T<float>)
                Constructor (Pack * rendergraph_ViewInfo)
            ]
        |+> Protocol
            [
                "createParticleEmitter" => Texture * ParamOf T<float> ^-> particles_ParticleEmitter'
                "createTrail" => Transform * T<float> * particles_ParticleSpec * Texture * (T<int> * particles_ParticleSpec ^-> T<unit>) * ParamOf T<float> ^-> particles_Trail'
                "createTrail" => Transform * T<float> * particles_ParticleSpec * Texture * (T<int> * particles_ParticleSpec ^-> T<unit>) ^-> particles_Trail'
                "createTrail" => Transform * T<float> * particles_ParticleSpec * Texture ^-> particles_Trail'
                "createTrail" => Transform * T<float> * particles_ParticleSpec ^-> particles_Trail'
                "clockParam" =? ParamOf T<float>
                "defaultColorTexture" =? Texture2D
                "defaultRampTexture" =? Texture2D
                "effects" =% Type.ArrayOf Effect
                "pack" =% Pack
                "particleStates" =% Type.ArrayOf State
                "viewInfo" =% rendergraph_ViewInfo
            ]

    let particles_ParticleEmitter =
        Class "ParticleEmitter"
        |=> particles_ParticleEmitter'
        |+> [
                Constructor (particles_ParticleSystem * Texture * ParamOf T<float>)
                Constructor (particles_ParticleSystem * Texture)
                Constructor (particles_ParticleSystem)
            ]
        |+> Protocol
            [
                "createOneShot" => Transform ^-> particles_OneShot'
                "setColorRamp" => Type.ArrayOf T<float>
                "setParameters" => particles_ParticleSpec * (T<float> * particles_ParticleSpec ^-> T<unit>) ^-> T<unit>
                "setParameters" => particles_ParticleSpec ^-> T<unit>
                "setState" => T<obj> ^-> T<unit>
                "validateParameters" => particles_ParticleSpec ^-> T<unit>
                "clockParam" =? ParamOf T<float>
                "material" =% Material
                "particleSystem" =? particles_ParticleSystem
                "shape" =% Shape
            ]

    let particles_Trail =
        Class "Trail"
        |=> particles_Trail'
        |=> Inherits particles_ParticleEmitter
        |+> [
                Constructor (particles_ParticleSystem * Transform * T<int> * particles_ParticleSpec * Texture * (T<int> * particles_ParticleSpec ^-> T<unit>) * ParamOf T<float>)
                Constructor (particles_ParticleSystem * Transform * T<int> * particles_ParticleSpec * Texture * (T<int> * particles_ParticleSpec ^-> T<unit>))
                Constructor (particles_ParticleSystem * Transform * T<int> * particles_ParticleSpec * Texture)
                Constructor (particles_ParticleSystem * Transform * T<int> * particles_ParticleSpec)
            ]
        |+> Protocol
            [
                "birthParticles" => Float3 ^-> T<unit>
                "transform" =% Transform
            ]

    let particles_OneShot =
        Class "OneShot"
        |=> particles_OneShot'
        |+> [
                Constructor (particles_ParticleEmitter * Transform)
                Constructor (particles_ParticleEmitter)
            ]
        |+> Protocol
            [
                "setParent" => Transform ^-> T<unit>
                "trigger" => Float3 * Transform ^-> T<unit>
                "trigger" => Float3 ^-> T<unit>
                "trigger" => T<unit> ^-> T<unit>
                "transform" =? Transform
            ]

    let particles_Fx =
        Pattern.Config "Fx" {
            Required =
                [
                    "name", T<string>
                    "fxString", T<string>
                ]
            Optional = []
        }

    let performance_PerformanceMonitor_Options =
        Pattern.Config "Options" {
            Required = []
            Optional =
                [
                    "opt_minSamples", T<int>
                    "opt_damping", T<float>
                    "opt_delayCycles", T<float>
                ]
        }

    let performance_PerformanceMonitor =
        Class "PerformanceMonitor"
        |=> Nested [performance_PerformanceMonitor_Options]
        |+> [
                Constructor (T<float>?targetFPSMin * T<float>?targetFPSMax * (T<unit> ^-> T<unit>)?increaseQuality * (T<unit> ^-> T<unit>)?decreaseQuality * performance_PerformanceMonitor_Options?options)
                Constructor (T<float>?targetFPSMin * T<float>?targetFPSMax * (T<unit> ^-> T<unit>)?increaseQuality * (T<unit> ^-> T<unit>)?decreaseQuality)
            ]
        |+> Protocol
            [
                "onRender" => T<float> ^-> T<unit>
                "damping" =% T<float>
                "decreaseQuality" =% (T<unit> ^-> T<unit>)
                "delayCycles" =% T<int>
                "increaseQuality" =% (T<unit> ^-> T<unit>)
                "meanFrameTime" =? T<float>
                "minSamples" =? T<int>
                "sampleCount" =? T<int>
            ]

    let picking_Ray =
        Pattern.Config "Ray" {
            Required =
                [
                    "near", Float3
                    "far", Float3
                ]
            Optional = []
        }

    let picking_TransformInfo =
        let t = Type.New()
        Class "TransformInfo"
        |=> t
        |+> [
                Constructor (Transform * t)
                Constructor (Transform)
            ]
        |+> Protocol
            [
                "dump" => T<string>?prefix ^-> T<unit>
                "getBoundingBox" => T<unit> ^-> BoundingBox
                "pick" => picking_Ray ^-> picking_PickInfo'
                "update" => T<unit> ^-> T<unit>
                "parent" =% t
                "transform" =% Transform
            ]

    let picking_ShapeInfo =
        Class "ShapeInfo"
        |+> [
                Constructor (Shape * picking_TransformInfo)
            ]
        |+> Protocol
            [
                "dump" => T<string>?prefix ^-> T<unit>
                "getBoundingBox" => T<unit> ^-> BoundingBox
                "pick" => picking_Ray ^-> picking_PickInfo'
                "update" => T<unit> ^-> T<unit>
                "boundingBox" =% BoundingBox
                "parent" =% picking_TransformInfo
                "shape" =% Shape
            ]

    let picking_PickInfo =
        Class "PickInfo"
        |=> picking_PickInfo'
        |+> [
                Constructor (Element * picking_ShapeInfo * RayIntersectionInfo * Float3)
            ]
        |+> Protocol
            [
                "element" =% Element
                "rayIntersectionInfo" =% RayIntersectionInfo
                "shapeInfo" =% picking_ShapeInfo
                "worldIntersectionPosition" =% Float3
            ]

    let primitives_VertexStreamInfo =
        Class "VertexStreamInfo"
        |+> [
                Constructor (T<int> * Stream_Semantic * T<int>)
                Constructor (T<int> * Stream_Semantic)
            ]
        |+> Protocol
            [
                "addElement" => T<float> * T<float> * T<float> * T<float> ^-> T<unit>
                "addElement" => T<float> * T<float> * T<float> ^-> T<unit>
                "addElement" => T<float> * T<float> ^-> T<unit>
                "addElement" => T<float> ^-> T<unit>
                "addElementVector" => Type.ArrayOf T<float> ^-> T<unit>
                "addElementVector" => Float2 ^-> T<unit>
                "addElementVector" => Float3 ^-> T<unit>
                "addElementVector" => Float4 ^-> T<unit>
                "getElementVector" => T<int> ^-> Type.ArrayOf T<float>
                "numElements" => T<unit> ^-> T<int>
                "setElement" => T<int> * T<float> * T<float> * T<float> * T<float> ^-> T<unit>
                "setElement" => T<int> * T<float> * T<float> * T<float> ^-> T<unit>
                "setElement" => T<int> * T<float> * T<float> ^-> T<unit>
                "setElement" => T<int> * T<float> ^-> T<unit>
                "setElementVector" => T<int> * Type.ArrayOf T<float> ^-> T<unit>
                "setElementVector" => T<int> * Float2 ^-> T<unit>
                "setElementVector" => T<int> * Float3 ^-> T<unit>
                "setElementVector" => T<int> * Float4 ^-> T<unit>
                "elements" =% Type.ArrayOf T<float>
                "numComponents" =% T<int>
                "semantic" =% Stream_Semantic
                "semanticIndex" =% T<int>
            ]

    let primitives_VertexInfo =
        let t = Type.New()
        Class "VertexInfo"
        |=> t
        |+> [
                Constructor (T<unit>)
            ]
        |+> Protocol
            [
                "addStream" => T<int> * Stream_Semantic * T<int> ^-> primitives_VertexStreamInfo
                "addStream" => T<int> * Stream_Semantic ^-> primitives_VertexStreamInfo
                "addTangentStreams" => T<int> ^-> T<unit>
                "addTangentStreams" => T<unit> ^-> T<unit>
                "addTriangle" => T<int> * T<int> * T<int> ^-> T<unit>
                "append" => t ^-> T<unit>
                "createShape" => Pack * Material ^-> Shape
                "findStream" => Stream_Semantic * T<int> ^-> primitives_VertexStreamInfo
                "findStream" => Stream_Semantic ^-> primitives_VertexStreamInfo
                "getTriangle" => T<int> ^-> T<int * int * int>
                "numTriangles" => T<unit> ^-> T<int>
                "removeStream" => Stream_Semantic * T<int> ^-> T<unit>
                "removeStream" => Stream_Semantic ^-> T<unit>
                "reorient" => Matrix4 ^-> T<unit>
                "setTriangle" => T<int> * T<int> * T<int> * T<int> ^-> T<unit>
                "validate" => T<unit> ^-> T<unit>
            ]

    let serialization_Deserializer =
        let t = Type.New()
        Class "Deserializer"
        |=> t
        |+> [
                Constructor (Pack * T<obj>)
            ]
        |+> Protocol
            [
                "addObject" => T<int> * T<obj> ^-> T<unit>
                "deserializeBuffer" => t * T<obj> * T<string> * T<string> ^-> T<unit>
                "deserializeValue" => T<obj> ^-> T<obj>
                "getObjectById" => T<string> ^-> T<obj>
                "run" => T<int> ^-> T<bool>
                "run" => T<unit> ^-> T<bool>
                "runBackground" => Client * Pack * T<float> * (Pack * T<obj> ^-> T<unit>) ^-> T<unit>
                "archiveInfo" =% io_ArchiveInfo
                "createCallbacks" =% T<obj>
                "initCallbacks" =% T<obj>
                "json" =% T<obj>
                "pack" =% Pack
            ]

    let simple_SimpleObject =
        let t = Type.New()
        Class "SimpleObject"
        |=> t
        |+> [
                Constructor (T<unit>)
            ]
        |+> Protocol
            [
                "init" => simple_SimpleInfo' * Transform ^-> T<unit>
                "onPicked" => (t ^-> T<unit>) ^-> T<unit>
                "onUpdate" => T<float> ^-> T<unit>
                "setOnUpdate" => (T<float> ^-> T<unit>) ^-> (T<float> ^-> T<unit>)
                "id" =? T<int>
                "simpleInfo" =% simple_SimpleInfo'
                "transform" =% Transform
            ]

    let simple_SimpleShape =
        Class "SimpleShape"
        |=> Inherits simple_SimpleObject
        |+> [
                Constructor (simple_SimpleInfo' * Transform)
            ]
        |+> Protocol
            [
                "getMaterial" => T<unit> ^-> Material
                "getTexture" => T<unit> ^-> Texture
                "loadTexture" => T<string> ^-> T<unit>
                "setDiffuseColor" => T<float> * T<float> * T<float> * T<float> ^-> T<unit>
                "setMaterial" => Material ^-> T<unit>
            ]

    let simple_SimpleScene =
        Class "SimpleScene"
        |=> Inherits simple_SimpleObject
        |+> [
                Constructor (simple_SimpleInfo' * T<string> * Pack * Transform * ParamObject)
            ]
        |+> Protocol
            [
                "bindParam" => ParamObject * T<string> * Param ^-> T<unit>
                "setAnimTime" => T<float> ^-> T<unit>
                "animTimeParam" =% ParamOf T<float>
                "pack" =% Pack
                "paramObject" =% ParamObject
                "url" =% T<string>
            ]

    let simple_SimpleInfo =
        Class "SimpleInfo"
        |=> simple_SimpleInfo'
        |+> [
                Constructor (T<Dom.Element>)
            ]
        |+> Protocol
            [
                "createBox" => T<float> * T<float> * T<float> ^-> simple_SimpleShape
                "createCube" => T<float> ^-> simple_SimpleShape
                "createMaterialFromEffect" => Effect ^-> Material
                "createNonTexturedMaterial" => effect_Type ^-> Material
                "createSimpleShape" => Shape ^-> simple_SimpleShape
                "createSphere" => T<float> * T<float> ^-> simple_SimpleShape
                "createTexturedMaterial" => effect_Type ^-> Material
                "loadScene" => T<string> * (simple_SimpleScene * T<obj> ^-> T<unit>) ^-> io_LoadInfo
                "registerObjectForUpdate" => simple_SimpleObject ^-> T<unit>
                "setCameraPosition" => T<float> * T<float> * T<float> ^-> T<unit>
                "setCameraTarget" => T<float> * T<float> * T<float> ^-> T<unit>
                "setCameraUp" => T<float> * T<float> * T<float> ^-> T<unit>
                "setFieldOfView" => T<float> ^-> T<unit>
                "setLightColor" => T<float> * T<float> * T<float>  * T<float> ^-> T<unit>
                "setLightPosition" => T<float> * T<float> * T<float> ^-> T<unit>
                "setZClip" => T<float> * T<float> ^-> T<unit>
                "unregisterObjectForUpdate" => simple_SimpleObject ^-> T<unit>
                "viewAll" => T<unit> ^-> T<unit>
                "client" =? Client
                "clientObject" =? T<Dom.Element>
                "o3d" =? o3d
                "pack" =% Pack
                "root" =% Transform
                "viewInfo" =% rendergraph_ViewInfo
            ]

    //////// Modules ////////

    let arcball =
        Class "o3djs.arcball"
        |=> Nested [arcball_ArcBall]
        |+> [
                "create" => T<int> * T<int> ^-> arcball_ArcBall
            ]

    let base' =
        Class "o3djs.base"
        |+> [
                "formatErrorStack" => Type.ArrayOf T<string> ^-> T<string>
                "getFunctionName" => (T<obj> ^-> T<obj>) ^-> T<string>
                "getStackTrace" => T<int> ^-> T<string>
                "inherit" => T<obj> * T<obj> ^-> T<unit>
                "init" => T<obj> ^-> T<unit>
                "initV8" => T<obj> ^-> T<unit>
                "isArray" => T<obj> ^-> T<bool>
                "IsChrome10" => T<unit> ^-> T<bool>
                "IsMSIE" => T<unit> ^-> T<bool>
                "parseErrorStack" => T<obj> ^-> Type.ArrayOf T<string>
                "ready" => T<unit> ^-> T<bool>
                "setErrorHandler" => Client ^-> T<unit>
                "snapshotProvidedNamespaces" => T<unit> ^-> T<unit>
                "o3djs.base.o3d" =% o3d
                |> WithSourceName "O3D"
            ]

    let camera =
        Class "o3djs.camera"
        |=> Nested [camera_CameraInfo]
        |+> [
                "findCameras" => Transform ^-> Type.ArrayOf Transform
                "fitContextToScene" => Transform * T<int> * T<int> * DrawContext ^-> T<unit>
                "getCameraFitToScene" => Transform * T<int> * T<int> ^-> camera_CameraInfo
                "getCameraInfos" => Transform * T<int> * T<int> * Type.ArrayOf camera_CameraInfo
                "getViewAndProjectionFromCamera" => Transform * T<int> * T<int> ^-> camera_CameraInfo
                "getViewAndProjectionFromCameras" => Transform * T<int> * T<int> ^-> camera_CameraInfo
            ]

    let canvas =
        Class "o3djs.canvas"
        |=> Nested [canvas_CanvasInfo
                    canvas_CanvasQuad]
        |+> [
                "create" => Pack * Transform * rendergraph_ViewInfo ^-> canvas_CanvasInfo
                "FX_STRING" =? T<string>
            ]

    let debug =
        Class "o3djs.debug"
        |=> Nested [debug_DebugHelper
                    debug_DebugLine
                    debug_DebugLineGroup
                    debug_VertexInfo]
        |+> [
                "createDebugHelper" => Pack * rendergraph_ViewInfo ^-> debug_DebugHelper
                "createLineInCube" => Pack * Material * T<float> * Matrix4 ^-> Shape
                "createLineCubeVertices" => T<float> * Matrix4 ^-> debug_VertexInfo
                "createLineShape" => Pack * Material * Type.ArrayOf Float3 * Type.ArrayOf T<int> ^-> Shape
                "createLineSphere" => Pack?pack * Material?material * T<float>?radius * T<int>?subdivAxis * T<int>?subdivHeight * Matrix4?matrix ^-> Shape
                "createLineSphereVertices" => T<float>?radius * T<int>?subdivAxis * T<int>?subdivHeight * Matrix4?matrix ^-> debug_VertexInfo
                "createVertexInfo" => Type.ArrayOf Float3 * Type.ArrayOf T<int> ^-> debug_VertexInfo
                "isDebugTransform" => Transform ^-> T<bool>
            ]

    let dump =
        Class "o3djs.dump"
        |+> [
                "dump" => T<string> ^-> T<unit>
                |> WithSourceName "dump"
                "dumpBoundingBox" => T<string>?label * BoundingBox?boundingBox * T<string>?prefix ^-> T<unit>
                "dumpBoundingBox" => T<string>?label * BoundingBox?boundingBox ^-> T<unit>
                "dumpElement" => Element?element * T<string>?prefix ^-> T<unit>
                "dumpElement" => Element ^-> T<unit>
                "dumpFloat3" => T<string>?label * Float3?float3 * T<string>?prefix ^-> T<unit>
                "dumpFloat3" => T<string>?label * Float3?float3 ^-> T<unit>
                "dumpFloat4" => T<string>?label * Float4?float4 * T<string>?prefix ^-> T<unit>
                "dumpFloat4" => T<string>?label * Float4?float4 ^-> T<unit>
                "dumpMatrix" => T<string>?label * Matrix4?matrix * T<string>?prefix ^-> T<unit>
                "dumpMatrix" => T<string>?label * Matrix4?matrix ^-> T<unit>
                "dumpNamedObjectName" => NamedObject * T<string>?prefix ^-> T<unit>
                "dumpNamedObjectName" => NamedObject ^-> T<unit>
                "dumpParam" => Param * T<string>?prefix ^-> T<unit>
                "dumpParam" => Param ^-> T<unit>
                "dumpParamObject" => ParamObject * T<string>?prefix ^-> T<unit>
                "dumpParamObject" => ParamObject ^-> T<unit>
                "dumpParams" => ParamObject?paramObject * T<string>?prefix ^-> T<unit>
                "dumpParams" => ParamObject ^-> T<unit>
                "dumpRenderNode" => RenderNode?renderNode * T<string>?prefix ^-> T<unit>
                "dumpRenderNode" => RenderNode ^-> T<unit>
                "dumpRenderNodeTree" => RenderNode?root * T<string>?prefix ^-> T<unit>
                "dumpRenderNodeTree" => RenderNode ^-> T<unit>
                "dumpShape" => Shape?shape * T<string>?prefix ^-> T<unit>
                "dumpShape" => Shape ^-> T<unit>
                "dumpStackTrace" => T<unit> ^-> T<unit>
                "dumpStream" => Stream?stream * T<string>?prefix ^-> T<unit>
                "dumpStream" => Stream ^-> T<unit>
                "dumpTexture" => Texture?texture * T<string>?prefix ^-> T<unit>
                "dumpTexture" => Texture ^-> T<unit>
                "dumpTransform" => Transform?transform * T<string>?prefix ^-> T<unit>
                "dumpTransform" => Transform ^-> T<unit>
                "dumpTransformList" => Type.ArrayOf Transform ^->T<unit>
                "dumpTransformTree" => Transform?root * T<string>?prefix ^-> T<unit>
                "dumpTransformTree" => Transform?root ^-> T<unit>
                "dumpVector4" => T<string>?label * Float4?vector * T<string>?prefix ^-> T<unit>
                "dumpVector4" => T<string>?label * Float4?vector ^-> T<unit>
                "getMatrixAsString" => Matrix4?matrix * T<string>?prefix ^-> T<string>
                "getMatrixAsString" => Matrix4?matrix ^-> T<string>
                "getParamValueAsString" => Param?param * T<string>?prefix ^-> T<string>
                "getParamValueAsString" => Param?param ^-> T<string>
            ]

    let effect =
        Class "o3djs.effect"
        |+> [
                "attachStandardShader" => Pack * Material * Float3 * effect_Type ^-> T<bool>
                "buildStandardShaderString" => Material * effect_Type ^-> effect_Description
                "createCheckerEffect" => Pack ^-> Effect
                "createEffectFromFile" => Pack * T<string> ^-> Effect
                "createUniformParameters" => Pack * Effect * ParamObject ^-> T<unit>
                "getColladaLightingType" => Material ^-> T<string>
                "getNumTexCoordStreamsNeeded" => Material ^-> T<int>
                "getStandardShader" => Pack * Material * effect_Type ^-> Effect
                "isColladaLightingType" => T<string> ^-> T<bool>
                "loadEffect" => Effect * T<string> ^-> T<unit>
                "COLLADA_LIGHTING_TYPE_PARAM_NAME" =% T<string>
                "COLLADA_LIGHTING_TYPES" =% T<obj>
                "COLLADA_SAMPLER_PARAMETER_PREFIXES" =% Type.ArrayOf T<string>
                "TWO_COLOR_CHECKER_EFFECT_NAME" =% T<string>
                "TWO_COLOR_CHECKER_FXSTRING" =% T<string>
            ]

    let element =
        Class "o3djs.element"
        |+> [
                "addMissingTexCoordStreams" => Element ^-> T<unit>
                "duplicateElement" => Pack * Element ^-> Element
                "getNormalForTriangle" => Primitive * T<int> * T<bool> ^-> Float3
                "getNormalForTriangle" => Primitive * T<int> ^-> Float3
                "setBoundingBoxAndZSortPoint" => Element ^-> T<unit>
            ]

    let error =
        Class "o3djs.error"
        |=> Nested [error_ErrorCollector]
        |+> [
                "createErrorCollector" => Client ^-> error_ErrorCollector
                "setDefaultErrorHandler" => Client ^-> T<unit>
                "setErrerHandler" => Client * (T<string> ^-> T<unit>) ^-> (T<string> ^-> T<unit>)
            ]

    let event =
        Class "o3djs.event"
        |+> [
                "addEventListener" => T<Dom.Element> * T<string> * (T<unit> ^-> T<unit>) ^-> T<unit>
                "addEventListener" => T<Dom.Element> * T<string> * (T<Dom.Event> ^-> T<unit>) ^-> T<unit>
                "addEventListener" => T<Dom.Element> * T<string> * (T<Dom.MouseEvent> ^-> T<unit>) ^-> T<unit>
                "addEventListener" => T<Dom.Element> * T<string> * (T<Dom.KeyboardEvent> ^-> T<unit>) ^-> T<unit>
                "appendWithSpace" => T<string> * T<string> ^-> T<string>
                "appendWithSpaceIf" => T<bool> * T<string> * T<string> ^-> T<string>
                "cancel" => T<Dom.Event> ^-> T<unit>
                "createKeyEvent" => T<string>?eventName * T<int>?charCode * T<int>?keyCode * T<bool>?control * T<bool>?alt * T<bool>?shift * T<bool>?meta ^-> T<obj>
                "getEventKeyChar" => T<Dom.Event> ^-> T<int>
                "getEventKeyIdentifier" => T<int>?charCode * T<int>?keyCode ^-> T<string>
                "getModifierString" => T<bool>?control * T<bool>?alt * T<bool>?shift * T<bool>?meta ^-> T<string>
                "keyIdentifierToChar" => T<string> ^-> T<int>
                "onKey" => T<Dom.Event> * T<Dom.Element> ^-> T<unit>
                "padWithLeadingZeroes" => T<string> * T<int> ^-> T<string>
                "removeEventListener" => T<Dom.Element> * T<string> * (T<unit> ^-> T<unit>) ^-> T<unit>
                "removeEventListener" => T<Dom.Element> * T<string> * (T<Dom.Event> ^-> T<unit>) ^-> T<unit>
                "startKeyboardEventSynthesis" => T<Dom.Element> ^-> T<unit>
            ]

    let fps =
        Class "o3djs.fps"
        |=> Nested [fps_ColorRect
                    fps_FPSManager]
        |+> [
                "createFPSManager" => Pack * T<int> * T<int> * RenderNode ^-> fps_FPSManager
                "CONST_COLOR_EFFECT" =% T<string>
                "NUM_FRAMES_TO_AVERAGE" =% T<int>
                "PERF_BAR_COLORS" =% Type.ArrayOf Float4
            ]

    let io =
        Class "o3djs.io"
        |=> Nested [io_ArchiveInfo
                    io_LoadInfo
                    io_ProgressInfo]
        |+> [
                "createLoadInfo" => ArchiveRequest * T<bool> ^-> io_LoadInfo
                "createLoadInfo" => FileRequest * T<bool> ^-> io_LoadInfo
                "createLoadInfo" => ArchiveRequest ^-> io_LoadInfo
                "createLoadInfo" => FileRequest ^-> io_LoadInfo
                "createLoadInfo" => T<unit> ^-> io_LoadInfo
                "loadArchive" => Pack * T<string> * (io_ArchiveInfo * T<obj> ^-> T<unit>) ^-> io_LoadInfo
                "loadArchiveAdvanced" => Pack * T<string> * (RawData ^-> T<unit>) ^-> (ArchiveRequest * T<obj> ^-> T<unit>) ^-> T<unit>
                "loadBitmaps" => Pack * T<string> * (Type.ArrayOf Bitmap * T<obj> ^-> T<unit>) * T<bool> ^-> io_LoadInfo
                "loadBitmaps" => Pack * T<string> * (Type.ArrayOf Bitmap * T<obj> ^-> T<unit>) ^-> io_LoadInfo
                "loadRawData" => Pack * T<string> * (FileRequest * RawData * T<obj> ^-> T<unit>) ^-> io_LoadInfo
                "loadTextFile" => T<string> * (T<string> * T<obj> ^-> T<unit>) ^-> io_LoadInfo
                "loadTextFileSynchronous" => T<string> ^-> T<string>
                "loadTexture" => Pack * T<string> * (Texture * T<obj> ^-> T<unit>) * T<bool> ^-> T<unit>
            ]

    let loader =
        Class "o3djs.loader"
        |=> Nested [loader_Loader]
        |+> [
                "createLoader" => (T<unit> ^-> T<unit>) ^-> loader_Loader
            ]

    let material =
        Class "o3djs.material"
        |+> [
                "attachStandardEffect" => Pack * Material * rendergraph_ViewInfo * effect_Type ^-> T<unit>
                "bindParams" => Pack * T<obj> ^-> T<unit>
                "bindParamsOnMaterial" => Material * T<obj> ^-> T<unit>
                "createAndBindStandardParams" => Pack ^-> T<obj>
                "createBasicMaterial" => Pack * rendergraph_ViewInfo * Float4 * T<bool> ^-> Material
                "createBasicMaterial" => Pack * rendergraph_ViewInfo * Texture * T<bool> ^-> Material
                "createBasicMaterial" => Pack * rendergraph_ViewInfo * Float4 ^-> Material
                "createBasicMaterial" => Pack * rendergraph_ViewInfo * Texture ^-> Material
                "createCheckerMaterial" => Pack * rendergraph_ViewInfo * Float4 * Float4 * T<bool> * T<int> ^-> Material
                "createCheckerMaterial" => Pack * rendergraph_ViewInfo * Float4 * Float4 * T<bool> ^-> Material
                "createCheckerMaterial" => Pack * rendergraph_ViewInfo * Float4 * Float4 ^-> Material
                "createCheckerMaterial" => Pack * rendergraph_ViewInfo * Float4 ^-> Material
                "createCheckerMaterial" => Pack * rendergraph_ViewInfo ^-> Material
                "createConstantMaterial" => Pack * rendergraph_ViewInfo * Float4 * T<bool> ^-> Material
                "createConstantMaterial" => Pack * rendergraph_ViewInfo * Texture * T<bool> ^-> Material
                "createConstantMaterial" => Pack * rendergraph_ViewInfo * Float4 ^-> Material
                "createConstantMaterial" => Pack * rendergraph_ViewInfo * Texture ^-> Material
                "createMaterialFromFile" => Pack * T<string> * DrawList ^-> Material
                "createParams" => Pack * T<obj> ^-> T<obj>
                "createStandardParams" => Pack ^-> T<obj>
                "prepareMaterial" => Pack * rendergraph_ViewInfo * Material * T<string> ^-> T<unit>
                "prepareMaterial" => Pack * rendergraph_ViewInfo * Material ^-> T<unit>
                "prepareMaterials" => Pack * rendergraph_ViewInfo * Pack ^-> T<unit>
                "prepareMaterials" => Pack * rendergraph_ViewInfo ^-> T<unit>
                "setDrawListOnMaterials" => Pack * DrawList ^-> T<unit>
            ]

    let matrix4 =
        Class "o3djs.math.matrix4"
        |+> [
                "axisRotate" => Matrix4 * Float3 * T<float> ^-> Matrix4
                "axisRotate" => Matrix4 * Float4 * T<float> ^-> Matrix4
                "axisRotation" => Float3 * T<float> ^-> Matrix4
                "axisRotation" => Float4 * T<float> ^-> Matrix4
                "compose" => Matrix4 * Matrix4 ^-> Matrix4
                "composition" => Matrix4 * Matrix4 ^-> Matrix4
                "copy" => Matrix4 ^-> Matrix4
                "det" => Matrix4 ^-> T<float>
                "frustum" => T<float>?left * T<float>?right * T<float>?bottom * T<float>?top * T<float>?near * T<float>?far ^-> Matrix4
                "getTranslation" => Matrix4 ^-> Float3
                "getUpper3x3" => Matrix4 ^-> Matrix3
                "identity" => T<unit> ^-> Matrix4
                "inverse" => Matrix4 ^-> Matrix4
                "lookAt" => Float4 * Float4 * Float4 ^-> Matrix4
                "lookAt" => Float4 * Float4 * Float3 ^-> Matrix4
                "lookAt" => Float4 * Float3 * Float4 ^-> Matrix4
                "lookAt" => Float4 * Float3 * Float3 ^-> Matrix4
                "lookAt" => Float3 * Float4 * Float4 ^-> Matrix4
                "lookAt" => Float3 * Float4 * Float3 ^-> Matrix4
                "lookAt" => Float3 * Float3 * Float4 ^-> Matrix4
                "lookAt" => Float3 * Float3 * Float3 ^-> Matrix4
                "mul" => Matrix4 * Matrix4 ^-> Matrix4
                "orthographic" => T<float>?left * T<float>?right * T<float>?bottom * T<float>?top * T<float>?near * T<float>?far ^-> Matrix4
                "perspective" => T<float>?angle * T<float>?aspect * T<float>?near * T<float>?far ^-> Matrix4
                "rotateX" => Matrix4 * T<float> ^-> Matrix4
                "rotateY" => Matrix4 * T<float> ^-> Matrix4
                "rotateZ" => Matrix4 * T<float> ^-> Matrix4
                "rotateZYX" => Matrix4 * Float3 ^-> Matrix4
                "rotationX" => T<float> ^-> Matrix4
                "rotationY" => T<float> ^-> Matrix4
                "rotationZ" => T<float> ^-> Matrix4
                "rotationZYX" => Float3 ^-> Matrix4
                "scale" => Matrix4 * Float3 ^-> Matrix4
                "scaling" => Float3 ^-> Matrix4
                "setIdentity" => Matrix4 ^-> Matrix4
                "setTranslation" => Matrix4 * Float3 ^-> Matrix4
                "setTranslation" => Matrix4 * Float4 ^-> Matrix4
                "setUpper3x3" => Matrix4 * Matrix3 ^-> Matrix4
                "transformDirection" => Matrix4 * Float3 ^-> Float3
                "transformNormal" => Matrix4 * Float3 ^-> Float3
                "transformNormal" => Matrix4 * FloatN ^-> Float3
                "transformPoint" => Matrix4 * Float3 ^-> Float3
                "transformPoint" => Matrix4 * FloatN ^-> Float3
                "transformVector4" => Matrix4 * Float4 ^-> Float4
                "transformVector4" => Matrix4 * FloatN ^-> Float4
                "translate" => Matrix4 * Float3 ^-> Matrix4
                "translate" => Matrix4 * Float4 ^-> Matrix4
                "translate" => Matrix4 * FloatN ^-> Matrix4
                "translation" => Float3 ^-> Matrix4
                "translation" => Float4 ^-> Matrix4
                "translation" => FloatN ^-> Matrix4
            ]

    let math =
        Class "o3djs.math"
        |=> Nested [matrix4]
        |+> [
                "addMatrix" => Matrix * Matrix ^-> Matrix
                |> WithSourceName "Add"
                "addMatrix" => Matrix2 * Matrix2 ^-> Matrix2
                |> WithSourceName "Add"
                "addMatrix" => Matrix3 * Matrix3 ^-> Matrix3
                |> WithSourceName "Add"
                "addMatrix" => Matrix4 * Matrix4 ^-> Matrix4
                |> WithSourceName "Add"
                "addVector" => Float2 * Float2 ^-> Float2
                |> WithSourceName "Add"
                "addVector" => Float3 * Float3 ^-> Float3
                |> WithSourceName "Add"
                "addVector" => Float4 * Float4 ^-> Float4
                |> WithSourceName "Add"
                "addVector" => FloatN * FloatN ^-> FloatN
                |> WithSourceName "Add"
                "codet" => Matrix * T<int> * T<int> ^-> T<int>
                "codet" => Matrix2 * T<int> * T<int> ^-> T<int>
                "codet" => Matrix3 * T<int> * T<int> ^-> T<int>
                "codet" => Matrix4 * T<int> * T<int> ^-> T<int>
                "copyMatrix" => Matrix ^-> Matrix
                |> WithSourceName "Copy"
                "copyMatrix" => Matrix2 ^-> Matrix2
                |> WithSourceName "Copy"
                "copyMatrix" => Matrix3 ^-> Matrix3
                |> WithSourceName "Copy"
                "copyMatrix" => Matrix4 ^-> Matrix4
                |> WithSourceName "Copy"
                "copyScalar" => T<int> ^-> T<int>
                |> WithSourceName "Copy"
                "copyVector" => Float2 ^-> Float2
                |> WithSourceName "Copy"
                "copyVector" => Float3 ^-> Float3
                |> WithSourceName "Copy"
                "copyVector" => Float4 ^-> Float4
                |> WithSourceName "Copy"
                "copyVector" => FloatN ^-> FloatN
                |> WithSourceName "Copy"
                "cross" => Float3 * Float3 ^-> Float3
                "cross" => FloatN * FloatN ^-> FloatN
                "degToRad" => T<float> ^-> T<float>
                "det" => Matrix ^-> T<float>
                "det2" => Matrix2 ^-> T<float>
                |> WithSourceName "Det"
                "det3" => Matrix3 ^-> T<float>
                |> WithSourceName "Det"
                "det4" => Matrix4 ^-> T<float>
                |> WithSourceName "Det"
                "distance" => Float2 * Float2 ^-> T<float>
                "distance" => Float3 * Float3 ^-> T<float>
                "distance" => Float4 * Float4 ^-> T<float>
                "distance" => FloatN * FloatN ^-> T<float>
                "distanceSquared" => Float2 * Float2 ^-> T<float>
                "distanceSquared" => Float3 * Float3 ^-> T<float>
                "distanceSquared" => Float4 * Float4 ^-> T<float>
                "distanceSquared" => FloatN * FloatN ^-> T<float>
                "divMatrixScalar" => Matrix * T<float> ^-> Matrix
                |> WithSourceName "Div"
                "divMatrixScalar" => Matrix2 * T<float> ^-> Matrix2
                |> WithSourceName "Div"
                "divMatrixScalar" => Matrix3 * T<float> ^-> Matrix3
                |> WithSourceName "Div"
                "divMatrixScalar" => Matrix4 * T<float> ^-> Matrix4
                |> WithSourceName "Div"
                "divVectorScalar" => Float2 * T<float> ^-> Float2
                |> WithSourceName "Div"
                "divVectorScalar" => Float3 * T<float> ^-> Float3
                |> WithSourceName "Div"
                "divVectorScalar" => Float4 * T<float> ^-> Float4
                |> WithSourceName "Div"
                "divVectorScalar" => FloatN * T<float> ^-> Float4
                |> WithSourceName "Div"
                "divVectorVector" => Float2 * Float2 ^-> Float2
                |> WithSourceName "Div"
                "divVectorVector" => Float3 * Float3 ^-> Float3
                |> WithSourceName "Div"
                "divVectorVector" => Float4 * Float4 ^-> Float4
                |> WithSourceName "Div"
                "divVectorVector" => FloatN * FloatN ^-> FloatN
                |> WithSourceName "Div"
                "dot" => Float2 * Float2 ^-> T<float>
                "dot" => Float3 * Float3 ^-> T<float>
                "dot" => Float4 * Float4 ^-> T<float>
                "dot" => FloatN * FloatN ^-> T<float>
                "getMatrixElements" => Matrix ^-> Type.ArrayOf T<float>
                "getMatrixElements" => Matrix2 ^-> Type.ArrayOf T<float>
                "getMatrixElements" => Matrix3 ^-> Type.ArrayOf T<float>
                "getMatrixElements" => Matrix4 ^-> Type.ArrayOf T<float>
                "identity" => T<int> ^-> Matrix
                "identity2" => T<unit> ^-> Matrix2
                |> WithInline "$this.identity(2)"
                "identity3" => T<unit> ^-> Matrix3
                |> WithInline "$this.identity(3)"
                "identity4" => T<unit> ^-> Matrix4
                |> WithInline "$this.identity(4)"
                "installColumnMajorFunctions" => T<unit> ^-> T<unit>
                "installErrerCheckFreeFunctions" => T<unit> ^-> T<unit>
                "installErrorCheckFunctions" => T<unit> ^-> T<unit>
                "installRowMajorFunctions" => T<unit> ^-> T<unit>
                "inverse" => Matrix ^-> Matrix
                "inverse2" => Matrix2 ^-> Matrix2
                |> WithSourceName "Inverse"
                "inverse3" => Matrix3 ^-> Matrix3
                |> WithSourceName "Inverse"
                "inverse4" => Matrix4 ^-> Matrix4
                |> WithSourceName "Inverse"
                "length" => Float2 ^-> T<float>
                "length" => Float3 ^-> T<float>
                "length" => Float4 ^-> T<float>
                "length" => FloatN ^-> T<float>
                "lengthSquared" => Float2 ^-> T<float>
                "lengthSquared" => Float3 ^-> T<float>
                "lengthSquared" => Float4 ^-> T<float>
                "lengthSquared" => FloatN ^-> T<float>
                "lerpCircular" => T<float>?a * T<float>?b * T<float>?t * T<float>?range ^-> T<float>
                "lerpMatrix" => Matrix * Matrix * T<float> ^-> Matrix
                |> WithSourceName "Lerp"
                "lerpMatrix" => Matrix2 * Matrix2 * T<float> ^-> Matrix2
                |> WithSourceName "Lerp"
                "lerpMatrix" => Matrix3 * Matrix3 * T<float> ^-> Matrix3
                |> WithSourceName "Lerp"
                "lerpMatrix" => Matrix4 * Matrix4 * T<float> ^-> Matrix4
                |> WithSourceName "Lerp"
                "lerpRadian" => T<float>?a * T<float>?b * T<float>?t ^-> T<float>
                "lerpScalar" => T<float>?a * T<float>?b * T<float>?t ^-> T<float>
                |> WithSourceName "Lerp"
                "lerpVector" => Float2 * Float2 * T<float> ^-> Float2
                |> WithSourceName "Lerp"
                "lerpVector" => Float3 * Float3 * T<float> ^-> Float3
                |> WithSourceName "Lerp"
                "lerpVector" => Float4 * Float4 * T<float> ^-> Float4
                |> WithSourceName "Lerp"
                "lerpVector" => FloatN * FloatN * T<float> ^-> Float4
                |> WithSourceName "Lerp"
                "modClamp" => T<float>?v * T<float>?range * T<float>?rangeStart ^-> T<float>
                "modClamp" => T<float>?v * T<float>?range ^-> T<float>
                "mulMatrixScalar" => Matrix * T<float> ^-> Matrix
                |> WithSourceName "Mul"
                "mulMatrixScalar" => Matrix2 * T<float> ^-> Matrix2
                |> WithSourceName "Mul"
                "mulMatrixScalar" => Matrix3 * T<float> ^-> Matrix3
                |> WithSourceName "Mul"
                "mulMatrixScalar" => Matrix4 * T<float> ^-> Matrix4
                |> WithSourceName "Mul"
                "mulScalarMatrix" => T<float> * Matrix ^-> Matrix
                |> WithSourceName "Mul"
                "mulScalarMatrix" => T<float> * Matrix2 ^-> Matrix2
                |> WithSourceName "Mul"
                "mulScalarMatrix" => T<float> * Matrix3 ^-> Matrix3
                |> WithSourceName "Mul"
                "mulScalarMatrix" => T<float> * Matrix4 ^-> Matrix4
                |> WithSourceName "Mul"
                "mulScalarScalar" => T<float> * T<float> ^-> T<float>
                |> WithSourceName "Mul"
                "mulScalarVector" => T<float> * Float2 ^-> Float2
                |> WithSourceName "Mul"
                "mulScalarVector" => T<float> * Float3 ^-> Float3
                |> WithSourceName "Mul"
                "mulScalarVector" => T<float> * Float4 ^-> Float4
                |> WithSourceName "Mul"
                "mulScalarVector" => T<float> * FloatN ^-> FloatN
                |> WithSourceName "Mul"
                "mulVectorScalar" => Float2 * T<float> ^-> Float2
                |> WithSourceName "Mul"
                "mulVectorScalar" => Float3 * T<float> ^-> Float3
                |> WithSourceName "Mul"
                "mulVectorScalar" => Float4 * T<float> ^-> Float4
                |> WithSourceName "Mul"
                "mulVectorScalar" => FloatN * T<float> ^-> FloatN
                |> WithSourceName "Mul"
                "mulVectorVector" => Float2 * Float2 ^-> Float2
                |> WithSourceName "Mul"
                "mulVectorVector" => Float3 * Float3 ^-> Float3
                |> WithSourceName "Mul"
                "mulVectorVector" => Float4 * Float4 ^-> Float4
                |> WithSourceName "Mul"
                "mulVectorVector" => FloatN * FloatN ^-> FloatN
                |> WithSourceName "Mul"
                "negativeMatrix" => Matrix ^-> Matrix
                |> WithSourceName "Negative"
                "negativeMatrix" => Matrix2 ^-> Matrix2
                |> WithSourceName "Negative"
                "negativeMatrix" => Matrix3 ^-> Matrix3
                |> WithSourceName "Negative"
                "negativeMatrix" => Matrix4 ^-> Matrix4
                |> WithSourceName "Negative"
                "negativeScalar" => T<float> ^-> T<float>
                |> WithSourceName "Negative"
                "negativeVector" => Float2 ^-> Float2
                |> WithSourceName "Negative"
                "negativeVector" => Float3 ^-> Float3
                |> WithSourceName "Negative"
                "negativeVector" => Float4 ^-> Float4
                |> WithSourceName "Negative"
                "negativeVector" => FloatN ^-> FloatN
                |> WithSourceName "Negative"
                "normalize" => Float2 ^-> Float2
                "normalize" => Float3 ^-> Float3
                "normalize" => Float4 ^-> Float4
                "normalize" => FloatN ^-> FloatN
                "orthonormalize" => Matrix ^-> Matrix
                "orthonormalize" => Matrix2 ^-> Matrix2
                "orthonormalize" => Matrix3 ^-> Matrix3
                "orthonormalize" => Matrix4 ^-> Matrix4
                "pseudoRandom" => T<unit> ^-> T<float>
                "radToDeg" => T<float> ^-> T<float>
                "resetPseudoRandom" => T<unit> ^-> T<unit>
                "subMatrix" => Matrix * Matrix ^-> Matrix
                |> WithSourceName "Sub"
                "subMatrix" => Matrix2 * Matrix2 ^-> Matrix2
                |> WithSourceName "Sub"
                "subMatrix" => Matrix3 * Matrix3 ^-> Matrix3
                |> WithSourceName "Sub"
                "subMatrix" => Matrix4 * Matrix4 ^-> Matrix4
                |> WithSourceName "Sub"
                "subVector" => Float2 * Float2 ^-> Float2
                |> WithSourceName "Sub"
                "subVector" => Float3 * Float3 ^-> Float3
                |> WithSourceName "Sub"
                "subVector" => Float4 * Float4 ^-> Float4
                |> WithSourceName "Sub"
                "subVector" => FloatN * FloatN ^-> FloatN
                |> WithSourceName "Sub"
                "trace" => Matrix ^-> T<float>
                "trace" => Matrix2 ^-> T<float>
                "trace" => Matrix3 ^-> T<float>
                "trace" => Matrix4 ^-> T<float>
                "transpose" => Matrix ^-> Matrix
                "transpose" => Matrix2 ^-> Matrix2
                "transpose" => Matrix3 ^-> Matrix3
                "transpose" => Matrix4 ^-> Matrix4
                "column" => Matrix * T<float> ^-> FloatN
                "column" => Matrix2 * T<float> ^-> Float2
                "column" => Matrix3 * T<float> ^-> Float3
                "column" => Matrix4 * T<float> ^-> Float4
                "mulMatrixMatrix" => Matrix * Matrix ^-> Matrix
                |> WithSourceName "Mul"
                "mulMatrixMatrix2" => Matrix2 * Matrix2 ^-> Matrix2
                |> WithSourceName "Mul"
                "mulMatrixMatrix3" => Matrix3 * Matrix3 ^-> Matrix3
                |> WithSourceName "Mul"
                "mulMatrixMatrix4" => Matrix4 * Matrix4 ^-> Matrix4
                |> WithSourceName "Mul"
                "mulMatrixVector" => Matrix2 * Float2 ^-> Float2
                |> WithSourceName "Mul"
                "mulMatrixVector" => Matrix3 * Float3 ^-> Float3
                |> WithSourceName "Mul"
                "mulMatrixVector" => Matrix4 * Float4 ^-> Float4
                |> WithSourceName "Mul"
                "mulMatrixVector" => Matrix * FloatN ^-> FloatN
                |> WithSourceName "Mul"
                "mulVectorMatrix" => Float2 * Matrix2 ^-> Float2
                |> WithSourceName "Mul"
                "mulVectorMatrix" => Float3 * Matrix3 ^-> Float3
                |> WithSourceName "Mul"
                "mulVectorMatrix" => Float4 * Matrix4 ^-> Float4
                |> WithSourceName "Mul"
                "mulVectorMatrix" => FloatN * Matrix ^-> FloatN
                |> WithSourceName "Mul"
                "row" => Matrix * T<float> ^-> FloatN
                "row" => Matrix2 * T<float> ^-> Float2
                "row" => Matrix3 * T<float> ^-> Float3
                "row" => Matrix4 * T<float> ^-> Float4
            ]

    let columnMajor =
        Class "o3djs.math.columnMajor"
        |+> [
                "column" => Matrix * T<float> ^-> FloatN
                "column" => Matrix2 * T<float> ^-> Float2
                "column" => Matrix3 * T<float> ^-> Float3
                "column" => Matrix4 * T<float> ^-> Float4
                "mulMatrixMatrix" => Matrix * Matrix ^-> Matrix
                |> WithSourceName "Mul"
                "mulMatrixMatrix2" => Matrix2 * Matrix2 ^-> Matrix2
                |> WithSourceName "Mul"
                "mulMatrixMatrix3" => Matrix3 * Matrix3 ^-> Matrix3
                |> WithSourceName "Mul"
                "mulMatrixMatrix4" => Matrix4 * Matrix4 ^-> Matrix4
                |> WithSourceName "Mul"
                "mulMatrixVector" => Matrix2 * Float2 ^-> Float2
                |> WithSourceName "Mul"
                "mulMatrixVector" => Matrix3 * Float3 ^-> Float3
                |> WithSourceName "Mul"
                "mulMatrixVector" => Matrix4 * Float4 ^-> Float4
                |> WithSourceName "Mul"
                "mulMatrixVector" => Matrix * FloatN ^-> FloatN
                |> WithSourceName "Mul"
                "mulVectorMatrix" => Float2 * Matrix2 ^-> Float2
                |> WithSourceName "Mul"
                "mulVectorMatrix" => Float3 * Matrix3 ^-> Float3
                |> WithSourceName "Mul"
                "mulVectorMatrix" => Float4 * Matrix4 ^-> Float4
                |> WithSourceName "Mul"
                "mulVectorMatrix" => FloatN * Matrix ^-> FloatN
                |> WithSourceName "Mul"
                "row" => Matrix * T<float> ^-> FloatN
                "row" => Matrix2 * T<float> ^-> Float2
                "row" => Matrix3 * T<float> ^-> Float3
                "row" => Matrix4 * T<float> ^-> Float4
            ]

    let errorCheck =
        Class "o3djs.errorCheck"

    let errorCheckFree =
        Class "o3djs.errorCheckFree"

    let rowMajor =
        Class "o3djs.math.rowMajor"
        |+> [
                "column" => Matrix * T<float> ^-> FloatN
                "column" => Matrix2 * T<float> ^-> Float2
                "column" => Matrix3 * T<float> ^-> Float3
                "column" => Matrix4 * T<float> ^-> Float4
                "mulMatrixMatrix" => Matrix * Matrix ^-> Matrix
                |> WithSourceName "Mul"
                "mulMatrixMatrix2" => Matrix2 * Matrix2 ^-> Matrix2
                |> WithSourceName "Mul"
                "mulMatrixMatrix3" => Matrix3 * Matrix3 ^-> Matrix3
                |> WithSourceName "Mul"
                "mulMatrixMatrix4" => Matrix4 * Matrix4 ^-> Matrix4
                |> WithSourceName "Mul"
                "mulMatrixVector" => Matrix2 * Float2 ^-> Float2
                |> WithSourceName "Mul"
                "mulMatrixVector" => Matrix3 * Float3 ^-> Float3
                |> WithSourceName "Mul"
                "mulMatrixVector" => Matrix4 * Float4 ^-> Float4
                |> WithSourceName "Mul"
                "mulMatrixVector" => Matrix * FloatN ^-> FloatN
                |> WithSourceName "Mul"
                "mulVectorMatrix" => Float2 * Matrix2 ^-> Float2
                |> WithSourceName "Mul"
                "mulVectorMatrix" => Float3 * Matrix3 ^-> Float3
                |> WithSourceName "Mul"
                "mulVectorMatrix" => Float4 * Matrix4 ^-> Float4
                |> WithSourceName "Mul"
                "mulVectorMatrix" => FloatN * Matrix ^-> FloatN
                |> WithSourceName "Mul"
                "row" => Matrix * T<float> ^-> FloatN
                "row" => Matrix2 * T<float> ^-> Float2
                "row" => Matrix3 * T<float> ^-> Float3
                "row" => Matrix4 * T<float> ^-> Float4
            ]

    let pack =
        Class "o3djs.pack"
        |+> [
                "preparePack" => Pack * rendergraph_ViewInfo * Pack ^-> T<unit>
                "preparePack" => Pack * rendergraph_ViewInfo ^-> T<unit>
            ]

    let particles =
        Class "o3djs.particles"
        |=> Nested [particles_OneShot
                    particles_ParticleEmitter
                    particles_ParticleSpec
                    particles_ParticleSystem
                    particles_Trail]
        |+> [
                "createParticleSystem" => Pack * rendergraph_ViewInfo * ParamOf T<float> * (T<unit> ^-> T<float>) ^-> particles_ParticleSystem
                "FX_STRINGS" =% Type.ArrayOf particles_Fx
            ]

    let performance =
        Class "o3djs.performance"
        |=> Nested [performance_PerformanceMonitor]
        |+> [
                "createPerformanceMonitor" => T<float>?targetFPSMin * T<float>?targetFPSMax * (T<unit> ^-> T<unit>)?increaseQuality * (T<unit> ^-> T<unit>)?decreaseQuality * performance_PerformanceMonitor_Options?options ^-> performance_PerformanceMonitor
                "createPerformanceMonitor" => T<float>?targetFPSMin * T<float>?targetFPSMax * (T<unit> ^-> T<unit>)?increaseQuality * (T<unit> ^-> T<unit>)?decreaseQuality ^-> performance_PerformanceMonitor
            ]

    let picking =
        Class "o3djs.picking"
        |=> Nested [picking_PickInfo
                    picking_Ray
                    picking_ShapeInfo
                    picking_TransformInfo]
        |+> [
                "clientPositionToWorldRay" => T<int>?clientXPosition * T<int>?clientYPosition * DrawContext * T<int>?clientWidth * T<int>?clientHeight ^-> picking_Ray
                "clientPositionToWorldRayEx" => T<int>?clientXPosition * T<int>?clientYPosition * Matrix4?view * Matrix4?projection * T<int>?clientWidth * T<int>?clientHeight ^-> picking_Ray
                "createPickInfo" => Element * picking_ShapeInfo * RayIntersectionInfo * Float3 ^-> picking_PickInfo
                "createShapeInfo" => Shape * picking_TransformInfo ^-> picking_ShapeInfo
                "createTransformInfo" => Transform * picking_TransformInfo ^-> picking_TransformInfo
                "dprint" => T<string> ^-> T<unit>
                "dprintBoundingBox" => T<string>?label * BoundingBox?boundingBox * T<string>?prefix ^-> T<unit>
                "dprintBoundingBox" => T<string>?label * BoundingBox?boundingBox ^-> T<unit>
                "dprintPoint3" => T<string>?label * Float3 ^-> T<unit>
                "dumpRayIntersectionInfo" => T<string>?label * RayIntersectionInfo?intersectionInfo ^-> T<unit>
            ]

    let primitives =
        Class "o3djs.primitives"
        |=> Nested [primitives_VertexInfo
                    primitives_VertexStreamInfo]
        |+> [
                "createBox" => Pack?pack * Material?material * T<float>?width * T<float>?height * T<float>?depth * Matrix4 ^-> Shape
                "createBox" => Pack?pack * Material?material * T<float>?width * T<float>?height * T<float>?depth ^-> Shape
                "createCube" => Pack?pack * Material?material * T<float>?size * Matrix4 ^-> Shape
                "createCube" => Pack?pack * Material?material * T<float>?size ^-> Shape
                "createCubeVertices" => T<float>?size * Matrix4?matrix ^-> primitives_VertexInfo
                "createCubeVertices" => T<float>?size ^-> primitives_VertexInfo
                "createCylinder" => Pack?pack * Material?material * T<float>?radius * T<float>?height * T<int>?radialSubdiv * T<int>?vertSubdiv * Matrix4?matrix ^-> Shape
                "createCylinder" => Pack?pack * Material?material * T<float>?radius * T<float>?height * T<int>?radialSubdiv * T<int>?vertSubdiv ^-> Shape
                "createCylinderVertices" => T<float>?radius * T<float>?height * T<int>?radialSubdiv * T<int>?vertSubdiv * Matrix4?matrix ^-> primitives_VertexInfo
                "createCylinderVertices" => T<float>?radius * T<float>?height * T<int>?radialSubdiv * T<int>?vertSubdiv ^-> primitives_VertexInfo
                "createDisc" => Pack?pack * Material?material * T<float>?radius * T<int>?divisions * T<int>?stacks * T<int>?startStack * T<int>?stackPower * Matrix4?matrix ^-> Shape
                "createDisc" => Pack?pack * Material?material * T<float>?radius * T<int>?divisions * T<int>?stacks * T<int>?startStack * T<int>?stackPower ^-> Shape
                "createDiscVertices" => T<float>?radius * T<int>?divisions * T<int>?stacks * T<int>?startStack * T<int>?stackPower * Matrix4?matrix ^-> primitives_VertexInfo
                "createDiscVertices" => T<float>?radius * T<int>?divisions * T<int>?stacks * T<int>?startStack * T<int>?stackPower ^-> primitives_VertexInfo
                "createFadePlane" => Pack?pack * Material?material * T<float>?width * T<float>?depth * T<int>?subdivWidth * T<int>?subdivDepth * Matrix4?matrix ^-> Shape
                "createFadePlane" => Pack?pack * Material?material * T<float>?width * T<float>?depth * T<int>?subdivWidth * T<int>?subdivDepth ^-> Shape
                "createPlane" => Pack?pack * Material?material * T<float>?width * T<float>?depth * T<int>?subdivWidth * T<int>?subdivDepth * Matrix4?matrix ^-> Shape
                "createPlane" => Pack?pack * Material?material * T<float>?width * T<float>?depth * T<int>?subdivWidth * T<int>?subdivDepth ^-> Shape
                "createPlaneVertices" => T<float>?width * T<float>?depth * T<int>?subdivWidth * T<int>?subdivDepth * Matrix4?matrix ^-> primitives_VertexInfo
                "createPlaneVertices" => T<float>?width * T<float>?depth * T<int>?subdivWidth * T<int>?subdivDepth ^-> primitives_VertexInfo
                "createPrism" => Pack?pack * Material?material * (Type.ArrayOf Float2)?points * T<float>?depth * Matrix4?matrix ^-> Shape
                "createPrism" => Pack?pack * Material?material * (Type.ArrayOf Float2)?points * T<float>?depth ^-> Shape
                "createPrismVertices" => (Type.ArrayOf Float2)?points * T<float>?depth * Matrix4?matrix ^-> primitives_VertexInfo
                "createPrismVertices" => (Type.ArrayOf Float2)?points * T<float>?depth ^-> primitives_VertexInfo
                "createRainbowCube" => Pack?pack * Material?material * T<float>?size * Matrix4?matrix ^-> Shape
                "createRainbowCube" => Pack?pack * Material?material * T<float>?size ^-> Shape
                "createSphere" => Pack?pack * Material?material * T<float>?radius * T<int>?subdivAxis * T<int>?subdivHeight * Matrix4?matrix ^-> Shape
                "createSphere" => Pack?pack * Material?material * T<float>?radius * T<int>?subdivAxis * T<int>?subdivHeight ^-> Shape
                "createSphereVertices" => T<float>?radius * T<int>?subdivAxis * T<int>?subdivHeight * Matrix4?matrix ^-> primitives_VertexInfo
                "createSphereVertices" => T<float>?radius * T<int>?subdivAxis * T<int>?subdivHeight ^-> primitives_VertexInfo
                "createTruncatedCone" => Pack?pack * Material?material * T<float>?bottomRadius * T<float>?topRadius * T<float>?height * T<int>?radialSubdiv * T<int>?verticalSubdiv * Matrix4?matrix ^-> Shape
                "createTruncatedCone" => Pack?pack * Material?material * T<float>?bottomRadius * T<float>?topRadius * T<float>?height * T<int>?radialSubdiv * T<int>?verticalSubdiv ^-> Shape
                "createTruncatedConeVertices" => T<float>?bottomRadius * T<float>?topRadius * T<float>?height * T<int>?radialSubdiv * T<int>?verticalSubdiv * Matrix4?matrix ^-> primitives_VertexInfo
                "createTruncatedConeVertices" => T<float>?bottomRadius * T<float>?topRadius * T<float>?height * T<int>?radialSubdiv * T<int>?verticalSubdiv ^-> primitives_VertexInfo
                "createVertexInfo" => T<unit> ^-> primitives_VertexInfo
                "createVertexStreamInfo" => T<int> * Stream_Semantic * T<int>?semanticIndex ^-> primitives_VertexStreamInfo
                "createVertexStreamInfo" => T<int> * Stream_Semantic ^-> primitives_VertexStreamInfo
                "createWedge" => Pack?pack * Material?material * (Type.ArrayOf Float2)?points * T<float>?depth * Matrix4?matrix ^-> Shape
                "createWedge" => Pack?pack * Material?material * (Type.ArrayOf Float2)?points * T<float>?depth ^-> Shape
                "createWedgeVertices" => (Type.ArrayOf Float2)?points * T<float>?depth * Matrix4?matrix ^-> primitives_VertexInfo
                "createWedgeVertices" => (Type.ArrayOf Float2)?points * T<float>?depth ^-> primitives_VertexInfo
                "setCullingInfo" => Primitive ^-> T<unit>
            ]

    let quaternions =
        Class "o3djs.quaternions"
        |+> [
                "add" => T<float> * T<float> ^-> T<float>
                "addQuaternionQuaternion" => Quat * Quat ^-> Quat
                |> WithSourceName "add"
                "addQuaternionScalar" => Quat * T<float> ^-> Quat
                |> WithSourceName "add"
                "addScalarQuaternion" => T<float> * Quat ^-> Quat
                |> WithSourceName "add"
                "axisRotation" => Float3?axis * T<float>?angle ^-> Quat
                "conjugate" => Quat ^-> Quat
                "copy" => Quat ^-> Quat
                "div" => T<float> * T<float> ^-> T<float>
                "divQuaternionQuaternion" => Quat * Quat ^-> Quat
                |> WithSourceName "div"
                "divQuaternionScalar" => Quat * T<float> ^-> Quat
                |> WithSourceName "div"
                "divScalarQuaternion" => T<float> * Quat ^-> Quat
                |> WithSourceName "div"
                "inverse" => Quat ^-> Quat
                "length" => Quat ^-> Quat
                "lengthSquared" => Quat ^-> Quat
                "mathType" => T<float> ^-> T<string>
                "mathType" => Quat ^-> T<string>
                "mathType" => Type.ArrayOf T<float> ^-> T<string>
                "mul" => T<float> * T<float> ^-> T<float>
                "mulQuaternionQuaternion" => Quat * Quat ^-> Quat
                |> WithSourceName "mul"
                "mulQuaternionScalar" => Quat * T<float> ^-> Quat
                |> WithSourceName "mul"
                "mulScalarQuaternion" => T<float> * Quat ^-> Quat
                |> WithSourceName "mul"
                "negative" => Quat ^-> Quat
                "normalize" => Quat ^-> Quat
                "quaternionToRotation" => Quat ^-> Matrix4
                "rotationToQuaternion" => Matrix4 ^-> Quat
                "rotationToQuaternion" => Matrix3 ^-> Quat
                "rotationX" => T<float> ^-> Quat
                "rotationY" => T<float> ^-> Quat
                "rotationZ" => T<float> ^-> Quat
                "sub" => T<float> * T<float> ^-> T<float>
                "subQuaternionQuaternion" => Quat * Quat ^-> Quat
                |> WithSourceName "sub"
                "subQuaternionScalar" => Quat * T<float> ^-> Quat
                |> WithSourceName "sub"
                "subScalarQuaternion" => T<float> * Quat ^-> Quat
                |> WithSourceName "sub"
            ]

    let rendergraph =
        Class "o3djs.rendergraph"
        |=> Nested [rendergraph_DrawPassInfo
                    rendergraph_ViewInfo]
        |+> [
                "createBasicView" => Pack?pack * Transform?transform * RenderNode?parent * Float4?clearColor * T<float>?priority * Float4?viewport ^-> rendergraph_ViewInfo
                "createBasicView" => Pack?pack * Transform?transform * RenderNode?parent * Float4?clearColor * T<float>?priority ^-> rendergraph_ViewInfo
                "createBasicView" => Pack?pack * Transform?transform * RenderNode?parent * Float4?clearColor ^-> rendergraph_ViewInfo
                "createBasicView" => Pack?pack * Transform?transform * RenderNode?parent ^-> rendergraph_ViewInfo
                "createBasicView" => Pack?pack * Transform?transform ^-> rendergraph_ViewInfo
                "createDrawPassInfo" => Pack * DrawContext * DrawList_SortMethod * DrawList * RenderNode ^-> rendergraph_DrawPassInfo
                "createDrawPassInfo" => Pack * DrawContext * DrawList_SortMethod * DrawList ^-> rendergraph_DrawPassInfo
                "createDrawPassInfo" => Pack * DrawContext * DrawList_SortMethod ^-> rendergraph_DrawPassInfo
                "createExtraView" => rendergraph_ViewInfo?viewinfo * Float4?viewpont * Float4?clearColor * T<float>?priority ^-> rendergraph_ViewInfo
                "createView" => Pack?pack * Transform?transform * RenderNode?parent * Float4?clearColor * T<float>?priority * Float4?viewport * DrawList?performanceDrawList * DrawList?zOrderedDrawList ^-> rendergraph_ViewInfo
                "createView" => Pack?pack * Transform?transform * RenderNode?parent * Float4?clearColor * T<float>?priority * Float4?viewport * DrawList?performanceDrawList ^-> rendergraph_ViewInfo
                "createView" => Pack?pack * Transform?transform * RenderNode?parent * Float4?clearColor * T<float>?priority * Float4?viewport ^-> rendergraph_ViewInfo
                "createView" => Pack?pack * Transform?transform * RenderNode?parent * Float4?clearColor * T<float>?priority ^-> rendergraph_ViewInfo
                "createView" => Pack?pack * Transform?transform * RenderNode?parent * Float4?clearColor ^-> rendergraph_ViewInfo
                "createView" => Pack?pack * Transform?transform * RenderNode?parent ^-> rendergraph_ViewInfo
                "createView" => Pack?pack * Transform?transform ^-> rendergraph_ViewInfo
            ]

    let scene =
        Class "o3djs.scene"
        |+> [
                "loadScene" => Client?client * Pack?pack * Transform?transform * T<string>?url * (Pack * Transform * T<obj> ^-> T<unit>)?callback * serialization_Options?options ^-> io_LoadInfo
                "loadScene" => Client?client * Pack?pack * Transform?transform * T<string>?url * (Pack * Transform * T<obj> ^-> T<unit>)?callback ^-> io_LoadInfo
            ]

    let serialization =
        Class "o3djs.serialization"
        |=> Nested [serialization_Deserializer]
        |+> [
                "createDeserializer" => Pack * T<obj> ^-> serialization_Deserializer
                "deserialize" => Pack * T<obj> ^-> T<unit>
                "deserializeArchive" => io_ArchiveInfo * T<string> * Client * Pack * Transform?parent * (Pack * Transform * T<obj> ^-> T<unit>) * serialization_Options ^-> T<unit>
                "deserializeArchive" => io_ArchiveInfo * T<string> * Client * Pack * Transform?parent * (Pack * Transform * T<obj> ^-> T<unit>) ^-> T<unit>
                "CURVE_KEY_TYPES" =% T<obj>
                "supportedVersion" =% T<int>
            ]

    let shape =
        Class "o3djs.shape"
        |+> [
                "addMissingTexCoordStreams" => Shape ^-> T<unit>
                "deleteDuplicateShape" => Shape * Pack ^-> T<unit>
                "duplicateShape" => Pack * Shape ^-> Shape
                "prepareShape" => Pack * Shape ^-> T<unit>
                "prepareShapes" => Pack ^-> T<unit>
                "setBoundingBoxAndZSortPoints" => Shape ^-> T<unit>
            ]

    let simple =
        Class "o3djs.simple"
        |=> Nested [simple_SimpleInfo
                    simple_SimpleObject
                    simple_SimpleScene
                    simple_SimpleShape]
        |+> [
                "create" => T<Dom.Element> ^-> simple_SimpleShape
            ]

    let texture =
        Class "o3djs.texture"
        |+> [
                "canMakeMipsAndScale" => Texture_Format ^-> T<bool>
                "computeNumLevels" => T<int> * T<int> ^-> T<int>
                "createCubeTextureFrom6Bitmaps" => Pack * T<float> * Type.ArrayOf Bitmap ^-> Texture
                "createTextureFromBitmaps" => Pack * Type.ArrayOf Bitmap * T<bool> ^-> Texture
                "createTextureFromRawData" => Pack?pack * RawData?data * T<bool>?generateMips * T<bool>?flip * T<int>?maxWidth * T<int>?maxHeight ^-> Texture
                "createTextureFromRawData" => Pack?pack * RawData?data * T<bool>?generateMips * T<bool>?flip * T<int>?maxWidth ^-> Texture
                "createTextureFromRawData" => Pack?pack * RawData?data * T<bool>?generateMips * T<bool>?flip ^-> Texture
                "createTextureFromRawData" => Pack?pack * RawData?data * T<bool>?generateMips ^-> Texture
                "createTextureFromRawData" => Pack * RawData ^-> Texture
                "MAX_TEXTURE_DIMENSION" =? T<int>
            ]

    let util =
        Class "o3djs.util"
        |+> [
                "addScriptUri" => T<string> ^-> T<unit>
                "arrayContains" => Type.ArrayOf T<obj> * T<obj> ^-> T<bool>
                "callV8" => T<obj> * (T<obj> ^-> T<obj>) * T<obj> * Type.ArrayOf T<obj> ^-> T<obj>
                "createClient" => T<Dom.Element>?element * T<string>?features * T<string>?requestVersion ^-> T<Dom.Element>
                "createClient" => T<Dom.Element>?element * T<string>?features ^-> T<Dom.Element>
                "createClient" => T<Dom.Element> ^-> T<Dom.Element>
                "curry" => (T<obj> ^-> T<obj>) * T<obj> ^-> (T<obj> ^-> T<obj>)
                "getAbsoluteURI" => T<string> ^-> T<string>
                "getBoundingBoxOfTree" => Transform ^-> BoundingBox
                "getCurrentURI" => T<unit> ^-> T<string>
                "getElementById" => T<string> ^-> T<Dom.Element>
                "getElementContentById" => T<string> ^-> T<string>
                "getElementsByTagAndId" => T<string>?tag * T<string>?id ^-> Type.ArrayOf T<Dom.Element>
                "getPluginVersion" => T<unit> ^-> T<string>
                "getPowerOfTwoSize" => T<int> ^-> T<int>
                "getTransformsInTreeByPrefix" => Transform * T<string> ^-> Type.ArrayOf Transform
                "getTransformsInTreeByTags" => Transform * T<string> ^-> Type.ArrayOf Transform
                "informNoGraphics" => Renderer_InitStatus?initStatus * T<string>?error * T<string>?id * T<string>?tag ^-> T<unit>
                "informNoGraphics" => Renderer_InitStatus?initStatus * T<string>?error * T<string>?id ^-> T<unit>
                "informNoGraphics" => Renderer_InitStatus?initStatus * T<string>?error ^-> T<unit>
                "informPluginFailure" => Renderer_InitStatus?initStatus * T<string>?error * T<string>?id * T<string>?tag ^-> T<unit>
                "informPluginFailure" => Renderer_InitStatus?initStatus * T<string>?error * T<string>?id ^-> T<unit>
                "informPluginFailure" => Renderer_InitStatus?initStatus * T<string>?error ^-> T<unit>
                "isScriptUri" => T<string> ^-> T<bool>
                "makeClients" => (Type.ArrayOf T<Dom.Element> ^-> T<unit>)?callback * T<string>?features * T<string>?requiredVersion * (Renderer_InitStatus * T<string> * T<string> * T<string> ^-> T<unit>)?failureCallback * T<string>?id * T<string>?tag ^-> T<unit>
                "makeClients" => (Type.ArrayOf T<Dom.Element> ^-> T<unit>)?callback * T<string>?features * T<string>?requiredVersion * (Renderer_InitStatus * T<string> * T<string> * T<string> ^-> T<unit>)?failureCallback * T<string>?id ^-> T<unit>
                "makeClients" => (Type.ArrayOf T<Dom.Element> ^-> T<unit>)?callback * T<string>?features * T<string>?requiredVersion * (Renderer_InitStatus * T<string> * T<string> * T<string> ^-> T<unit>)?failureCallback ^-> T<unit>
                "makeClients" => (Type.ArrayOf T<Dom.Element> ^-> T<unit>)?callback * T<string>?features * T<string>?requiredVersion  ^-> T<unit>
                "makeClients" => (Type.ArrayOf T<Dom.Element> ^-> T<unit>)?callback * T<string>?features  ^-> T<unit>
                "makeClients" => (Type.ArrayOf T<Dom.Element> ^-> T<unit>)?callback  ^-> T<unit>
                "offerPlugin" => T<string>?id * T<string>?tag ^-> T<unit>
                "offerPlugin" => T<string>?id ^-> T<unit>
                "offerPlugin" => T<unit> ^-> T<unit>
                "requestVersionAvailable" => T<string> ^-> T<bool>
                "setMainEngine" => T<string> ^-> T<unit>
                "toAbsoluteUri" => T<string> ^-> T<string>
                "MINIMUM_HEIGHT_FOR_MESSAGE" =? T<int>
                "MINIMUM_WIDTH_FOR_MESSAGE" =? T<int>
                "PLUGIN_DOWNLOAD_URL" =? T<string>
                "PLUGIN_NAME" =? T<string>
                "REQUIRED_VERSION" =? T<string>
            ]

    let webgl =
        Class "o3djs.webgl"
        |+> [
                "makeClients" => (Type.ArrayOf T<Dom.Element> ^-> T<unit>)?callback * T<string>?features * T<string>?requiredVersion * (Renderer_InitStatus * T<string> * T<string> * T<string> ^-> T<unit>)?failureCallback * T<string>?id * T<string>?tag ^-> T<unit>
                "makeClients" => (Type.ArrayOf T<Dom.Element> ^-> T<unit>)?callback * T<string>?features * T<string>?requiredVersion * (Renderer_InitStatus * T<string> * T<string> * T<string> ^-> T<unit>)?failureCallback * T<string>?id ^-> T<unit>
                "makeClients" => (Type.ArrayOf T<Dom.Element> ^-> T<unit>)?callback * T<string>?features * T<string>?requiredVersion * (Renderer_InitStatus * T<string> * T<string> * T<string> ^-> T<unit>)?failureCallback ^-> T<unit>
                "makeClients" => (Type.ArrayOf T<Dom.Element> ^-> T<unit>)?callback * T<string>?features * T<string>?requiredVersion  ^-> T<unit>
                "makeClients" => (Type.ArrayOf T<Dom.Element> ^-> T<unit>)?callback * T<string>?features  ^-> T<unit>
                "makeClients" => (Type.ArrayOf T<Dom.Element> ^-> T<unit>)?callback  ^-> T<unit>
                "createGLErrorWrapper" => T<obj>?context * T<string>?fname ^-> T<unit>
                "addDebuggingWrapper" => T<obj>?context ^-> T<unit>
                "webGlCanvasError" => T<Dom.Element> * T<Dom.Element> ^-> T<unit>
                "createClient" => T<Dom.Element>?element * T<string>?features * T<bool>?debug ^-> T<Dom.Element>
                "createClient" => T<Dom.Element>?element * T<string>?features ^-> T<Dom.Element>
                "createClient" => T<Dom.Element>?element ^-> T<Dom.Element>
            ]

    let o3djs =
        Class "o3djs"
        |> WithSourceName "O3DJS"
        |=> Nested [
                arcball
                base'
                camera
                canvas
                debug
                dump
                effect
                element
                error
                event
                fps
                io
                loader
                material
                math
                columnMajor
                errorCheck
                errorCheckFree
                rowMajor
                pack
                particles
                performance
                picking
                primitives
                quaternions
                rendergraph
                scene
                serialization
                shape
                simple
                texture
                util
                webgl
            ]
        |+> [
                "exportSymbol" => T<string> * T<obj> * T<obj> ^-> T<unit>
                "getObjectByName" => T<string> * T<obj> ^-> T<obj>
                "isDef" => T<obj> ^-> T<bool>
                "provide" => T<string> ^-> T<unit>
                "require" => T<string> ^-> T<unit>
                "basePath" =? T<string>
                "BROWSER_ONLY" =% T<bool>
                "global" =? T<obj>
                "test" =? T<obj>
            ]

    let Assembly =
        Assembly [
            Namespace "IntelliFactory.WebSharper.O3D.O3D" [
                ArchiveRequestClass
                BezierCurveKeyClass
                BitmapClass
                BufferClass
                CanvasClass
                CanvasFontMetricsClass
                CanvasLinearGradientClass
                CanvasPaintClass
                CanvasShaderClass
                ClearBufferClass
                ClientClass
                ClientInfoClass
                CounterClass
                CurveClass
                CurveKeyClass
                DisplayModeClass
                DrawContextClass
                DrawElementClass
                DrawListClass
                DrawPassClass
                EffectClass
                EffectParameterInfoClass
                EffectStreamInfoClass
                ElementClass
                EventClass
                FieldClass
                FileRequestClass
                FloatFieldClass
                FunctionClass
                FunctionEvalClass
                IndexBufferClass
                LinearCurveKeyClass
                MaterialClass
                Matrix4AxisRotationClass
                Matrix4CompositionClass
                Matrix4ScaleClass
                Matrix4TranslationClass
                NamedObjectClass
                NamedObjectBaseClass
                ObjectBaseClass
                PackClass
                ParamClass
                Generic - ParamOf
                ParamArrayClass
                ParamOp2FloatsToFloat2Class
                ParamOp3FloatsToFloat3Class
                ParamOp4FloatsToFloat4Class
                ParamOp16FloatsToMatrix4Class
                ParamObjectClass
                PrimitiveClass
                RawDataClass
                RayIntersectionInfoClass
                RenderDepthStencilSurfaceClass
                RendererClass
                RenderEventClass
                RenderFrameCounterClass
                RenderNodeClass
                RenderSurfaceClass
                RenderSurfaceBaseClass
                RenderSurfaceSetClass
                SamplerClass
                SecondCounterClass
                ShapeClass
                SkinClass
                SkinEvalClass
                SourceBufferClass
                StateClass
                StateSetClass
                StepCurveKeyClass
                StreamClass
                StreamBankClass
                TextureClass
                Texture2DClass
                TextureCUBEClass
                TickCounterClass
                TickEventClass
                TransformClass
                TreeTraversalClass
                TRSToMatrix4Class
                UByteNFieldClass
                UInt32FieldClass
                VertexBufferClass
                VertexBufferBaseClass
                VertexSourceClass
                ViewportClass
            ]
            Namespace "IntelliFactory.WebSharper.O3D.O3DJS" [
                arcball
                base'
                camera
                canvas
                debug
                dump
                effect
                element
                error
                event
                fps
                io
                loader
                material
                math
                columnMajor
                errorCheck
                errorCheckFree
                rowMajor
                pack
                particles
                performance
                picking
                primitives
                quaternions
                rendergraph
                scene
                serialization
                shape
                simple
                texture
                util
                webgl
            ]
        ]
