﻿using System.Collections.Generic;

namespace MemBus.Publishing
{
    public class PublishToken
    {
        public object Message { get; }
        public IEnumerable<ISubscription> Subscriptions { get; }

        /// <summary>
        /// When set to true, the subsequent members in the publish pipeline will not be called anymore
        /// </summary>
        public bool Cancel { get; set; }

        public PublishToken(object message, IEnumerable<ISubscription> subscriptions)
        {
            Message = message;
            Subscriptions = subscriptions;
        }
    }
}