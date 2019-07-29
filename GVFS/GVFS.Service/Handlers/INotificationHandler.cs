﻿using GVFS.Common.NamedPipes;

namespace GVFS.Service.Handlers
{
    public interface INotificationHandler
    {
        void SendNotification(int sessionId, NamedPipeMessages.Notification.Request request);
    }
}
