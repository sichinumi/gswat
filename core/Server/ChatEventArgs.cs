﻿using System;
using core.TableStoreEntities;

namespace core.Server
{
    public class ChatEventArgs : EventArgs
    {
        /// <summary>
        ///     Constructs a new ChatEventArgs object with a predefined ChatMessage
        /// </summary>
        /// <param name="msg">ChatMessage to pass along</param>
        public ChatEventArgs(ChatMessageEntity msg)
        {
            ServerMessage = msg;
        }

        // ChatMessage contained in this ChatEventArgs object
        public ChatMessageEntity ServerMessage { get; private set; }
    }
}