﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using TravelFriend.Windows.Database.Model;

namespace TravelFriend.Windows.Chat
{
    public class ChatMessageDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate LeftMessageTemplate { get; set; }
        public DataTemplate RightMessageTemplate { get; set; }
        public DataTemplate TipTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            Message message = item as Message; //CombinedEnity为绑定数据对象
            switch (message.Type)
            {
                case MessageType.Tip:
                    return TipTemplate;
                case MessageType.Message:
                    bool isSendByMe = message.IsSendByMe;
                    if (isSendByMe)
                    {
                        return RightMessageTemplate;
                    }
                    else
                    {
                        return LeftMessageTemplate;
                    }
                default:
                    return null;
            }

        }
    }
}
