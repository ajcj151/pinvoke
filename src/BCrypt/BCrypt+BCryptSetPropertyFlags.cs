﻿// Copyright (c) All contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PInvoke
{
    using System;

    /// <content>
    /// Contains the <see cref="BCryptSetPropertyFlags"/> nested type.
    /// </content>
    public partial class BCrypt
    {
        [Flags]
        public enum BCryptSetPropertyFlags
        {
            None = 0x0,
        }
    }
}
