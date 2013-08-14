﻿using System;
using ProtoBuf;
using ZyGames.Framework.Game.Model;
using ZyGames.Framework.Model;

namespace ZyGames.Framework.Game.Message
{
    /// <summary>
    /// 公告消息
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadWrite, CacheType.Queue, false)]
    public class NoticeMessage : ShareEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public NoticeMessage()
            : this(0, 0)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="noticeType"></param>
        /// <param name="versionId"></param>
        public NoticeMessage(NoticeType noticeType, int versionId)
            :base(AccessLevel.ReadWrite)
        {
            _id = Guid.NewGuid();
            _noticeType = noticeType;
            VersionId = versionId;
        }
        /// <summary>
        /// 
        /// </summary>
        public int VersionId { get; private set; }

        private Guid _id;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1001)]
        public virtual Guid Id
        {
            get { return _id; }
            protected set { _id = value; }
        }

        private NoticeType _noticeType;

        /// <summary>
        /// 类型
        /// </summary>
        [ProtoMember(1002)]
        public virtual NoticeType NoticeType
        {
            get { return _noticeType; }
            set { _noticeType = value; }
        }

        private string _title;

        /// <summary>
        /// 标题
        /// </summary>
        [ProtoMember(1003)]
        public virtual string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _content;

        /// <summary>
        /// 内容
        /// </summary>
        [ProtoMember(1004)]
        public virtual string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        private DateTime _expiryDate;

        /// <summary>
        /// 过期时间
        /// </summary>
        [ProtoMember(1006)]
        public virtual DateTime ExpiryDate
        {
            get { return _expiryDate; }
            set { _expiryDate = value; }
        }

        private string _sender;

        /// <summary>
        /// 发送人
        /// </summary>
        [ProtoMember(1007)]
        public virtual string Sender
        {
            get { return _sender; }
            set { _sender = value; }
        }

        private DateTime _sendDate;

        /// <summary>
        /// 发送时间
        /// </summary>
        [ProtoMember(1008)]
        public virtual DateTime SendDate
        {
            get { return _sendDate; }
            set { _sendDate = value; }
        }

        protected override int GetIdentityId()
        {
            return DefIdentityId;
        }

        protected override object this[string index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}
