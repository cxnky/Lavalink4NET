/*
 *  File:   ConnectedEventArgs.cs
 *  Author: Angelo Breuer
 *
 *  The MIT License (MIT)
 *
 *  Copyright (c) Angelo Breuer 2022
 *
 *  Permission is hereby granted, free of charge, to any person obtaining a copy
 *  of this software and associated documentation files (the "Software"), to deal
 *  in the Software without restriction, including without limitation the rights
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *  copies of the Software, and to permit persons to whom the Software is
 *  furnished to do so, subject to the following conditions:
 *
 *  The above copyright notice and this permission notice shall be included in
 *  all copies or substantial portions of the Software.
 *
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 *  THE SOFTWARE.
 */

namespace Lavalink4NET.Events;

using System;

/// <summary>
///     The event arguments for the <see cref="LavalinkSocket.Connected"/> event.
/// </summary>
public class ConnectedEventArgs : ConnectionEventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ConnectedEventArgs"/> class.
    /// </summary>
    /// <param name="uri">the URI connect / reconnected / disconnected from / to</param>
    /// <param name="wasReconnect">a value indicating whether the connect was a reconnect</param>
    /// <exception cref="ArgumentNullException">
    ///     thrown if the specified <paramref name="uri"/> is <see langword="null"/>.
    /// </exception>
    public ConnectedEventArgs(Uri uri, bool wasReconnect) : base(uri)
        => WasReconnect = wasReconnect;

    /// <summary>
    ///     Gets a value indicating whether the connect was a reconnect.
    /// </summary>
    public bool WasReconnect { get; }
}
