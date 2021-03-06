﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ServiceBus
{
    using System;
    using System.Xml;


    // *** Start programmer edit section *** (Using statements)
    using System.Runtime.Serialization;
    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// ServiceBusMessage.
    /// </summary>
    // *** Start programmer edit section *** (ServiceBusMessage CustomAttributes)
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/IIS.Persona.ServiceBus.Objects")]
    // *** End programmer edit section *** (ServiceBusMessage CustomAttributes)
    public class ServiceBusMessage
    {
        
        private string fID;
        
        private string fBody;
        
        private string fMessageTypeID;
        
        private string fClientID;
        
        private string fGroup;
        
        private System.Collections.Generic.Dictionary<string, string> fTags;
        
        private byte[] fAttachment;
        
        private int fPriority = 0;
        
        private System.DateTime fMessageFormingTime;
        
        private string fSenderName;

        // *** Start programmer edit section *** (ServiceBusMessage CustomMembers)

        // *** End programmer edit section *** (ServiceBusMessage CustomMembers)


        /// <summary>
        /// ID.
        /// </summary>
        // *** Start programmer edit section *** (ServiceBusMessage.ID CustomAttributes)
        [DataMember]
        // *** End programmer edit section *** (ServiceBusMessage.ID CustomAttributes)
        public virtual string ID
        {
            get
            {
                // *** Start programmer edit section *** (ServiceBusMessage.ID Get start)

                // *** End programmer edit section *** (ServiceBusMessage.ID Get start)
                string result = this.fID;
                // *** Start programmer edit section *** (ServiceBusMessage.ID Get end)

                // *** End programmer edit section *** (ServiceBusMessage.ID Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ServiceBusMessage.ID Set start)

                // *** End programmer edit section *** (ServiceBusMessage.ID Set start)
                this.fID = value;
                // *** Start programmer edit section *** (ServiceBusMessage.ID Set end)

                // *** End programmer edit section *** (ServiceBusMessage.ID Set end)
            }
        }

        /// <summary>
        /// Body.
        /// </summary>
        // *** Start programmer edit section *** (ServiceBusMessage.Body CustomAttributes)
        [DataMember]
        // *** End programmer edit section *** (ServiceBusMessage.Body CustomAttributes)
        public virtual string Body
        {
            get
            {
                // *** Start programmer edit section *** (ServiceBusMessage.Body Get start)

                // *** End programmer edit section *** (ServiceBusMessage.Body Get start)
                string result = this.fBody;
                // *** Start programmer edit section *** (ServiceBusMessage.Body Get end)

                // *** End programmer edit section *** (ServiceBusMessage.Body Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ServiceBusMessage.Body Set start)

                // *** End programmer edit section *** (ServiceBusMessage.Body Set start)
                this.fBody = value;
                // *** Start programmer edit section *** (ServiceBusMessage.Body Set end)

                // *** End programmer edit section *** (ServiceBusMessage.Body Set end)
            }
        }

        /// <summary>
        /// MessageTypeID.
        /// </summary>
        // *** Start programmer edit section *** (ServiceBusMessage.MessageTypeID CustomAttributes)
        [DataMember]
        // *** End programmer edit section *** (ServiceBusMessage.MessageTypeID CustomAttributes)
        public virtual string MessageTypeID
        {
            get
            {
                // *** Start programmer edit section *** (ServiceBusMessage.MessageTypeID Get start)

                // *** End programmer edit section *** (ServiceBusMessage.MessageTypeID Get start)
                string result = this.fMessageTypeID;
                // *** Start programmer edit section *** (ServiceBusMessage.MessageTypeID Get end)

                // *** End programmer edit section *** (ServiceBusMessage.MessageTypeID Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ServiceBusMessage.MessageTypeID Set start)

                // *** End programmer edit section *** (ServiceBusMessage.MessageTypeID Set start)
                this.fMessageTypeID = value;
                // *** Start programmer edit section *** (ServiceBusMessage.MessageTypeID Set end)

                // *** End programmer edit section *** (ServiceBusMessage.MessageTypeID Set end)
            }
        }

        /// <summary>
        /// ClientID.
        /// </summary>
        // *** Start programmer edit section *** (ServiceBusMessage.ClientID CustomAttributes)
        [DataMember]
        // *** End programmer edit section *** (ServiceBusMessage.ClientID CustomAttributes)
        public virtual string ClientID
        {
            get
            {
                // *** Start programmer edit section *** (ServiceBusMessage.ClientID Get start)

                // *** End programmer edit section *** (ServiceBusMessage.ClientID Get start)
                string result = this.fClientID;
                // *** Start programmer edit section *** (ServiceBusMessage.ClientID Get end)

                // *** End programmer edit section *** (ServiceBusMessage.ClientID Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ServiceBusMessage.ClientID Set start)

                // *** End programmer edit section *** (ServiceBusMessage.ClientID Set start)
                this.fClientID = value;
                // *** Start programmer edit section *** (ServiceBusMessage.ClientID Set end)

                // *** End programmer edit section *** (ServiceBusMessage.ClientID Set end)
            }
        }

        /// <summary>
        /// Group.
        /// </summary>
        // *** Start programmer edit section *** (ServiceBusMessage.Group CustomAttributes)
        [DataMember]
        // *** End programmer edit section *** (ServiceBusMessage.Group CustomAttributes)
        public virtual string Group
        {
            get
            {
                // *** Start programmer edit section *** (ServiceBusMessage.Group Get start)

                // *** End programmer edit section *** (ServiceBusMessage.Group Get start)
                string result = this.fGroup;
                // *** Start programmer edit section *** (ServiceBusMessage.Group Get end)

                // *** End programmer edit section *** (ServiceBusMessage.Group Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ServiceBusMessage.Group Set start)

                // *** End programmer edit section *** (ServiceBusMessage.Group Set start)
                this.fGroup = value;
                // *** Start programmer edit section *** (ServiceBusMessage.Group Set end)

                // *** End programmer edit section *** (ServiceBusMessage.Group Set end)
            }
        }

        /// <summary>
        /// Tags.
        /// </summary>
        // *** Start programmer edit section *** (ServiceBusMessage.Tags CustomAttributes)
        [DataMember]
        // *** End programmer edit section *** (ServiceBusMessage.Tags CustomAttributes)
        public virtual System.Collections.Generic.Dictionary<string, string> Tags
        {
            get
            {
                // *** Start programmer edit section *** (ServiceBusMessage.Tags Get start)

                // *** End programmer edit section *** (ServiceBusMessage.Tags Get start)
                System.Collections.Generic.Dictionary<string, string> result = this.fTags;
                // *** Start programmer edit section *** (ServiceBusMessage.Tags Get end)

                // *** End programmer edit section *** (ServiceBusMessage.Tags Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ServiceBusMessage.Tags Set start)

                // *** End programmer edit section *** (ServiceBusMessage.Tags Set start)
                this.fTags = value;
                // *** Start programmer edit section *** (ServiceBusMessage.Tags Set end)

                // *** End programmer edit section *** (ServiceBusMessage.Tags Set end)
            }
        }

        /// <summary>
        /// Attachment.
        /// </summary>
        // *** Start programmer edit section *** (ServiceBusMessage.Attachment CustomAttributes)
        [DataMember]
        // *** End programmer edit section *** (ServiceBusMessage.Attachment CustomAttributes)
        public virtual byte[] Attachment
        {
            get
            {
                // *** Start programmer edit section *** (ServiceBusMessage.Attachment Get start)

                // *** End programmer edit section *** (ServiceBusMessage.Attachment Get start)
                byte[] result = this.fAttachment;
                // *** Start programmer edit section *** (ServiceBusMessage.Attachment Get end)

                // *** End programmer edit section *** (ServiceBusMessage.Attachment Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ServiceBusMessage.Attachment Set start)

                // *** End programmer edit section *** (ServiceBusMessage.Attachment Set start)
                this.fAttachment = value;
                // *** Start programmer edit section *** (ServiceBusMessage.Attachment Set end)

                // *** End programmer edit section *** (ServiceBusMessage.Attachment Set end)
            }
        }

        /// <summary>
        /// Priority.
        /// </summary>
        // *** Start programmer edit section *** (ServiceBusMessage.Priority CustomAttributes)
        [DataMember]
        // *** End programmer edit section *** (ServiceBusMessage.Priority CustomAttributes)
        public virtual int Priority
        {
            get
            {
                // *** Start programmer edit section *** (ServiceBusMessage.Priority Get start)

                // *** End programmer edit section *** (ServiceBusMessage.Priority Get start)
                int result = this.fPriority;
                // *** Start programmer edit section *** (ServiceBusMessage.Priority Get end)

                // *** End programmer edit section *** (ServiceBusMessage.Priority Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ServiceBusMessage.Priority Set start)

                // *** End programmer edit section *** (ServiceBusMessage.Priority Set start)
                this.fPriority = value;
                // *** Start programmer edit section *** (ServiceBusMessage.Priority Set end)

                // *** End programmer edit section *** (ServiceBusMessage.Priority Set end)
            }
        }

        /// <summary>
        /// MessageFormingTime.
        /// </summary>
        // *** Start programmer edit section *** (ServiceBusMessage.MessageFormingTime CustomAttributes)
        [DataMember]
        // *** End programmer edit section *** (ServiceBusMessage.MessageFormingTime CustomAttributes)
        public virtual System.DateTime MessageFormingTime
        {
            get
            {
                // *** Start programmer edit section *** (ServiceBusMessage.MessageFormingTime Get start)

                // *** End programmer edit section *** (ServiceBusMessage.MessageFormingTime Get start)
                System.DateTime result = this.fMessageFormingTime;
                // *** Start programmer edit section *** (ServiceBusMessage.MessageFormingTime Get end)

                // *** End programmer edit section *** (ServiceBusMessage.MessageFormingTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ServiceBusMessage.MessageFormingTime Set start)

                // *** End programmer edit section *** (ServiceBusMessage.MessageFormingTime Set start)
                this.fMessageFormingTime = value;
                // *** Start programmer edit section *** (ServiceBusMessage.MessageFormingTime Set end)

                // *** End programmer edit section *** (ServiceBusMessage.MessageFormingTime Set end)
            }
        }

        /// <summary>
        /// SenderName.
        /// </summary>
        // *** Start programmer edit section *** (ServiceBusMessage.SenderName CustomAttributes)
        [DataMember]
        // *** End programmer edit section *** (ServiceBusMessage.SenderName CustomAttributes)
        public virtual string SenderName
        {
            get
            {
                // *** Start programmer edit section *** (ServiceBusMessage.SenderName Get start)

                // *** End programmer edit section *** (ServiceBusMessage.SenderName Get start)
                string result = this.fSenderName;
                // *** Start programmer edit section *** (ServiceBusMessage.SenderName Get end)

                // *** End programmer edit section *** (ServiceBusMessage.SenderName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ServiceBusMessage.SenderName Set start)

                // *** End programmer edit section *** (ServiceBusMessage.SenderName Set start)
                this.fSenderName = value;
                // *** Start programmer edit section *** (ServiceBusMessage.SenderName Set end)

                // *** End programmer edit section *** (ServiceBusMessage.SenderName Set end)
            }
        }
    }
}
