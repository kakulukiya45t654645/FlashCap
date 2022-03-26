﻿// FlashCap - Independent camera capture library.
// Copyright (c) Kouji Matsui (@kozy_kekyo, @kekyo@mastodon.cloud)
// This is auto-generated by gen_request_code, do not edit.

using System;

namespace FlashCap.Internal.V4L2;

internal sealed class RequestCode32 : RequestCode
{
    public RequestCode32()
    {
        AssertSize<NativeMethods_V4L2.v4l2_capability>(104);
        AssertSize<NativeMethods_V4L2.v4l2_input>(80);
        AssertSize<NativeMethods_V4L2.v4l2_fmtdesc>(64);
        AssertSize<NativeMethods_V4L2.v4l2_frmsizeenum>(44);
        AssertSize<NativeMethods_V4L2.v4l2_frmivalenum>(52);
        AssertSize<NativeMethods_V4L2.v4l2_format>(204);
        AssertSize<NativeMethods_V4L2.v4l2_requestbuffers>(20);
        AssertSize<NativeMethods_V4L2.v4l2_buffer>(68);
    }

    public override UIntPtr VIDIOC_QUERYCAP => new UIntPtr(0x80685600);
    public override UIntPtr VIDIOC_ENUMINPUT => new UIntPtr(0xc050561a);
    public override UIntPtr VIDIOC_ENUM_FMT => new UIntPtr(0xc0405602);
    public override UIntPtr VIDIOC_ENUM_FRAMESIZES => new UIntPtr(0xc02c564a);
    public override UIntPtr VIDIOC_ENUM_FRAMEINTERVALS => new UIntPtr(0xc034564b);
    public override UIntPtr VIDIOC_S_FMT => new UIntPtr(0xc0cc5605);
    public override UIntPtr VIDIOC_G_FMT => new UIntPtr(0xc0cc5604);
    public override UIntPtr VIDIOC_REQBUFS => new UIntPtr(0xc0145608);
    public override UIntPtr VIDIOC_QUERYBUF => new UIntPtr(0xc0445609);
    public override UIntPtr VIDIOC_QBUF => new UIntPtr(0xc044560f);
    public override UIntPtr VIDIOC_DQBUF => new UIntPtr(0xc0445611);
    public override UIntPtr VIDIOC_STREAMON => new UIntPtr(0x40045612);
    public override UIntPtr VIDIOC_STREAMOFF => new UIntPtr(0x40045613);
}
