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
    /// MessageForESB.
    /// </summary>
    // *** Start programmer edit section *** (MessageForESB CustomAttributes)
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/IIS.Persona.ServiceBus.Objects")]
    // *** End programmer edit section *** (MessageForESB CustomAttributes)
    public class MessageForESB
    {
        
        private string fBody;
        
        private string fMessageTypeID;
        
        private string fClientID;
        
        private System.Collections.Generic.Dictionary<string, string> fTags;
        
        private byte[] fAttachment;
        
        private int fPriority = 0;
        
        // *** Start programmer edit section *** (MessageForESB CustomMembers)

        // *** End programmer edit section *** (MessageForESB CustomMembers)

        
        /// <summary>
        /// Body.
        /// </summary>
        // *** Start programmer edit section *** (MessageForESB.Body CustomAttributes)
        [DataMember]
        // *** End programmer edit section *** (MessageForESB.Body CustomAttributes)
        public virtual string Body
        {
            get
            {
                // *** Start programmer edit section *** (MessageForESB.Body Get start)

                // *** End programmer edit section *** (MessageForESB.Body Get start)
                string result = this.fBody;
                // *** Start programmer edit section *** (MessageForESB.Body Get end)

                // *** End programmer edit section *** (MessageForESB.Body Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageForESB.Body Set start)

                // *** End programmer edit section *** (MessageForESB.Body Set start)
                this.fBody = value;
                // *** Start programmer edit section *** (MessageForESB.Body Set end)

                // *** End programmer edit section *** (MessageForESB.Body Set end)
            }
        }
        
        /// <summary>
        /// MessageTypeID.
        /// </summary>
        // *** Start programmer edit section *** (MessageForESB.MessageTypeID CustomAttributes)
        [DataMember]
        // *** End programmer edit section *** (MessageForESB.MessageTypeID CustomAttributes)
        public virtual string MessageTypeID
        {
            get
            {
                // *** Start programmer edit section *** (MessageForESB.MessageTypeID Get start)

                // *** End programmer edit section *** (MessageForESB.MessageTypeID Get start)
                string result = this.fMessageTypeID;
                // *** Start programmer edit section *** (MessageForESB.MessageTypeID Get end)

                // *** End programmer edit section *** (MessageForESB.MessageTypeID Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageForESB.MessageTypeID Set start)

                // *** End programmer edit section *** (MessageForESB.MessageTypeID Set start)
                this.fMessageTypeID = value;
                // *** Start programmer edit section *** (MessageForESB.MessageTypeID Set end)

                // *** End programmer edit section *** (MessageForESB.MessageTypeID Set end)
            }
        }
        
        /// <summary>
        /// ClientID.
        /// </summary>
        // *** Start programmer edit section *** (MessageForESB.ClientID CustomAttributes)
        [DataMember]
        // *** End programmer edit section *** (MessageForESB.ClientID CustomAttributes)
        public virtual string ClientID
        {
            get
            {
                // *** Start programmer edit section *** (MessageForESB.ClientID Get start)

                // *** End programmer edit section *** (MessageForESB.ClientID Get start)
                string result = this.fClientID;
                // *** Start programmer edit section *** (MessageForESB.ClientID Get end)

                // *** End programmer edit section *** (MessageForESB.ClientID Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageForESB.ClientID Set start)

                // *** End programmer edit section *** (MessageForESB.ClientID Set start)
                this.fClientID = value;
                // *** Start programmer edit section *** (MessageForESB.ClientID Set end)

                // *** End programmer edit section *** (MessageForESB.ClientID Set end)
            }
        }
        
        /// <summary>
        /// Tags.
        /// </summary>
        // *** Start programmer edit section *** (MessageForESB.Tags CustomAttributes)
        [DataMember]
        // *** End programmer edit section *** (MessageForESB.Tags CustomAttributes)
        public virtual System.Collections.Generic.Dictionary<string, string> Tags
        {
            get
            {
                // *** Start programmer edit section *** (MessageForESB.Tags Get start)

                // *** End programmer edit section *** (MessageForESB.Tags Get start)
                System.Collections.Generic.Dictionary<string, string> result = this.fTags;
                // *** Start programmer edit section *** (MessageForESB.Tags Get end)

                // *** End programmer edit section *** (MessageForESB.Tags Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageForESB.Tags Set start)

                // *** End programmer edit section *** (MessageForESB.Tags Set start)
                this.fTags = value;
                // *** Start programmer edit section *** (MessageForESB.Tags Set end)

                // *** End programmer edit section *** (MessageForESB.Tags Set end)
            }
        }
        
        /// <summary>
        /// Attachment.
        /// </summary>
        // *** Start programmer edit section *** (MessageForESB.Attachment CustomAttributes)
        [DataMember]
        // *** End programmer edit section *** (MessageForESB.Attachment CustomAttributes)
        public virtual byte[] Attachment
        {
            get
            {
                // *** Start programmer edit section *** (MessageForESB.Attachment Get start)

                // *** End programmer edit section *** (MessageForESB.Attachment Get start)
                byte[] result = this.fAttachment;
                // *** Start programmer edit section *** (MessageForESB.Attachment Get end)

                // *** End programmer edit section *** (MessageForESB.Attachment Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageForESB.Attachment Set start)

                // *** End programmer edit section *** (MessageForESB.Attachment Set start)
                this.fAttachment = value;
                // *** Start programmer edit section *** (MessageForESB.Attachment Set end)

                // *** End programmer edit section *** (MessageForESB.Attachment Set end)
            }
        }
        
        /// <summary>
        /// Priority.
        /// </summary>
        // *** Start programmer edit section *** (MessageForESB.Priority CustomAttributes)
        [DataMember]
        // *** End programmer edit section *** (MessageForESB.Priority CustomAttributes)
        public virtual int Priority
        {
            get
            {
                // *** Start programmer edit section *** (MessageForESB.Priority Get start)

                // *** End programmer edit section *** (MessageForESB.Priority Get start)
                int result = this.fPriority;
                // *** Start programmer edit section *** (MessageForESB.Priority Get end)

                // *** End programmer edit section *** (MessageForESB.Priority Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageForESB.Priority Set start)

                // *** End programmer edit section *** (MessageForESB.Priority Set start)
                this.fPriority = value;
                // *** Start programmer edit section *** (MessageForESB.Priority Set end)

                // *** End programmer edit section *** (MessageForESB.Priority Set end)
            }
        }
    }
}
