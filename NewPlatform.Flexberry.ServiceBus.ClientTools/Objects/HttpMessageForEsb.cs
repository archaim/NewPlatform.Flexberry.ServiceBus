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

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// HttpMessageForEsb.
    /// </summary>
    // *** Start programmer edit section *** (HttpMessageForEsb CustomAttributes)
    // *** End programmer edit section *** (HttpMessageForEsb CustomAttributes)
    public class HttpMessageForEsb
    {
        
        private string fBody;
        
        private string fMessageTypeID;
        
        private string fClientID;
        
        private System.Collections.Generic.Dictionary<string, string> fTags;
        
        private byte[] fAttachment;
        
        private int fPriority = 0;
        
        // *** Start programmer edit section *** (HttpMessageForEsb CustomMembers)

        // *** End programmer edit section *** (HttpMessageForEsb CustomMembers)

        
        /// <summary>
        /// Body.
        /// </summary>
        // *** Start programmer edit section *** (HttpMessageForEsb.Body CustomAttributes)

        // *** End programmer edit section *** (HttpMessageForEsb.Body CustomAttributes)
        public virtual string Body
        {
            get
            {
                // *** Start programmer edit section *** (HttpMessageForEsb.Body Get start)

                // *** End programmer edit section *** (HttpMessageForEsb.Body Get start)
                string result = this.fBody;
                // *** Start programmer edit section *** (HttpMessageForEsb.Body Get end)

                // *** End programmer edit section *** (HttpMessageForEsb.Body Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (HttpMessageForEsb.Body Set start)

                // *** End programmer edit section *** (HttpMessageForEsb.Body Set start)
                this.fBody = value;
                // *** Start programmer edit section *** (HttpMessageForEsb.Body Set end)

                // *** End programmer edit section *** (HttpMessageForEsb.Body Set end)
            }
        }
        
        /// <summary>
        /// MessageTypeID.
        /// </summary>
        // *** Start programmer edit section *** (HttpMessageForEsb.MessageTypeID CustomAttributes)

        // *** End programmer edit section *** (HttpMessageForEsb.MessageTypeID CustomAttributes)
        public virtual string MessageTypeID
        {
            get
            {
                // *** Start programmer edit section *** (HttpMessageForEsb.MessageTypeID Get start)

                // *** End programmer edit section *** (HttpMessageForEsb.MessageTypeID Get start)
                string result = this.fMessageTypeID;
                // *** Start programmer edit section *** (HttpMessageForEsb.MessageTypeID Get end)

                // *** End programmer edit section *** (HttpMessageForEsb.MessageTypeID Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (HttpMessageForEsb.MessageTypeID Set start)

                // *** End programmer edit section *** (HttpMessageForEsb.MessageTypeID Set start)
                this.fMessageTypeID = value;
                // *** Start programmer edit section *** (HttpMessageForEsb.MessageTypeID Set end)

                // *** End programmer edit section *** (HttpMessageForEsb.MessageTypeID Set end)
            }
        }
        
        /// <summary>
        /// ClientID.
        /// </summary>
        // *** Start programmer edit section *** (HttpMessageForEsb.ClientID CustomAttributes)

        // *** End programmer edit section *** (HttpMessageForEsb.ClientID CustomAttributes)
        public virtual string ClientID
        {
            get
            {
                // *** Start programmer edit section *** (HttpMessageForEsb.ClientID Get start)

                // *** End programmer edit section *** (HttpMessageForEsb.ClientID Get start)
                string result = this.fClientID;
                // *** Start programmer edit section *** (HttpMessageForEsb.ClientID Get end)

                // *** End programmer edit section *** (HttpMessageForEsb.ClientID Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (HttpMessageForEsb.ClientID Set start)

                // *** End programmer edit section *** (HttpMessageForEsb.ClientID Set start)
                this.fClientID = value;
                // *** Start programmer edit section *** (HttpMessageForEsb.ClientID Set end)

                // *** End programmer edit section *** (HttpMessageForEsb.ClientID Set end)
            }
        }
        
        /// <summary>
        /// Tags.
        /// </summary>
        // *** Start programmer edit section *** (HttpMessageForEsb.Tags CustomAttributes)

        // *** End programmer edit section *** (HttpMessageForEsb.Tags CustomAttributes)
        public virtual System.Collections.Generic.Dictionary<string, string> Tags
        {
            get
            {
                // *** Start programmer edit section *** (HttpMessageForEsb.Tags Get start)

                // *** End programmer edit section *** (HttpMessageForEsb.Tags Get start)
                System.Collections.Generic.Dictionary<string, string> result = this.fTags;
                // *** Start programmer edit section *** (HttpMessageForEsb.Tags Get end)

                // *** End programmer edit section *** (HttpMessageForEsb.Tags Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (HttpMessageForEsb.Tags Set start)

                // *** End programmer edit section *** (HttpMessageForEsb.Tags Set start)
                this.fTags = value;
                // *** Start programmer edit section *** (HttpMessageForEsb.Tags Set end)

                // *** End programmer edit section *** (HttpMessageForEsb.Tags Set end)
            }
        }
        
        /// <summary>
        /// Attachment.
        /// </summary>
        // *** Start programmer edit section *** (HttpMessageForEsb.Attachment CustomAttributes)

        // *** End programmer edit section *** (HttpMessageForEsb.Attachment CustomAttributes)
        public virtual byte[] Attachment
        {
            get
            {
                // *** Start programmer edit section *** (HttpMessageForEsb.Attachment Get start)

                // *** End programmer edit section *** (HttpMessageForEsb.Attachment Get start)
                byte[] result = this.fAttachment;
                // *** Start programmer edit section *** (HttpMessageForEsb.Attachment Get end)

                // *** End programmer edit section *** (HttpMessageForEsb.Attachment Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (HttpMessageForEsb.Attachment Set start)

                // *** End programmer edit section *** (HttpMessageForEsb.Attachment Set start)
                this.fAttachment = value;
                // *** Start programmer edit section *** (HttpMessageForEsb.Attachment Set end)

                // *** End programmer edit section *** (HttpMessageForEsb.Attachment Set end)
            }
        }
        
        /// <summary>
        /// Priority.
        /// </summary>
        // *** Start programmer edit section *** (HttpMessageForEsb.Priority CustomAttributes)

        // *** End programmer edit section *** (HttpMessageForEsb.Priority CustomAttributes)
        public virtual int Priority
        {
            get
            {
                // *** Start programmer edit section *** (HttpMessageForEsb.Priority Get start)

                // *** End programmer edit section *** (HttpMessageForEsb.Priority Get start)
                int result = this.fPriority;
                // *** Start programmer edit section *** (HttpMessageForEsb.Priority Get end)

                // *** End programmer edit section *** (HttpMessageForEsb.Priority Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (HttpMessageForEsb.Priority Set start)

                // *** End programmer edit section *** (HttpMessageForEsb.Priority Set start)
                this.fPriority = value;
                // *** Start programmer edit section *** (HttpMessageForEsb.Priority Set end)

                // *** End programmer edit section *** (HttpMessageForEsb.Priority Set end)
            }
        }
    }
}
